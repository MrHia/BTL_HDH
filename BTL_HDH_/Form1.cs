using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_HDH_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadStatusStripHuy();
        }
        /// khởi tạo biến 
        decimal downtime = 0;
        string statustext = "";
        PowerStatus status = SystemInformation.PowerStatus;
        decimal battery;
        decimal Batterypercentageoff;



        /// Hàm LoadStatusStrip hiển thị thời gian đếm ngược
        void LoadStatusStrip()
        {
            var item = new ToolStripLabel() { Text = statustext };
            statusStrip1.Items.Add(item);
            var item1 = new ToolStripLabel() { Text = downtime.ToString() };
            statusStrip1.Items.Add(item1);

        }

        /// hàm LoadStatusStripHuy xóa thời gian đếm ngược 
        void LoadStatusStripHuy()
        {
            var item = new ToolStripLabel() { Text = " " };
            statusStrip1.Items.Add(item);
        }

        /// tạo sự kiện nmGiay_ValueChanged khi biến của giây tăng lên 60 tăng phút lên 1 và giây về 0 
        private void nmGiay_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown box = sender as NumericUpDown;
            if (box.Value >= 60)
            {
                nmPhut.Value++;
                box.Value = 0;
            }
        }
        /// tạo sự kiện nmPhut_ValueChanged khi biến của phút tăng lên 60 tăng giờ lên 1 và phút về 0
        private void nmPhut_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown box = sender as NumericUpDown;
            if (box.Value >= 60)
            {
                nmGio.Value++;
                box.Value = 0;
            }
        }
        /// Hàm CalculateDowntime tính thời gian chuyển về giây
        void CalculateDowntime()
        {
            downtime = nmGiay.Value + nmPhut.Value * 60 + nmGio.Value * 60 * 60;
        }

        //shutdown theo comand 
        void ShutDown(string command)
        {
            System.Diagnostics.Process.Start("shutdown", command); // gọi hàm api shutdow của Windows 
        }

        //hàm xử lý hiển thị thời gian đếm ngược ở statusStrip
        private void Timeturnoff_Tick(object sender, EventArgs e)
        {
            downtime--;
            statusStrip1.Items.Clear();
            LoadStatusStrip();
        }

        // Hàm xử lý nút Shutdown
        private void btShutdow_Click(object sender, EventArgs e)
        {
            statustext = "Máy sẽ shutdow trong: ";
            LoadStatusStrip();
            CalculateDowntime();
            ShutDown("-s -t " + downtime.ToString()); // gọi hàm shutdow với time = dowtime 
            Timeturnoff.Start();
        }

        // Hàm xử lý nút Restart
        private void btRestart_Click(object sender, EventArgs e)
        {
            statustext = "Máy sẽ restart trong: ";
            LoadStatusStrip();
            CalculateDowntime();
            ShutDown("-r -t " + downtime.ToString()); // gọi hàm shutdow với time = dowtime 
            Timeturnoff.Start();
        }

        // Hàm xử lý nút Cancel
        private void btCancel_Click(object sender, EventArgs e)
        {
            statusStrip1.Items.Clear();
            LoadStatusStripHuy();
            ShutDown("-a");
            Timeturnoff.Stop();
        }

        // Hàm xử lý hiển thị phần trăm pin hiện tại
        private void realtime_Tick(object sender, EventArgs e)
        {
            // Gọi hàm api của Windows lấy phần trăm pin hiện tại chuyển về chuỗi và gán cho Text Charge
            txtCharge.Text = status.BatteryLifePercent.ToString("P0");
            battery = Convert.ToDecimal(status.BatteryLifePercent) * 100;
            NMR_shutdowwithbattery.Maximum = battery;
            NMR_shutdowwithbattery.Minimum = 5;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            realtime.Start();
            realtime.Enabled = true;

        }

        // Hàm xử lý nút Bật tự động tắt 
        private void BT_TurnOn_Click(object sender, EventArgs e)
        {
            BT_TurnOn.Enabled = false;
            NMR_shutdowwithbattery.Enabled = false;
            checkturnoff.Start();
        }

        // Hàm xử lý nút Hủy
        private void BT_Cancel_Click(object sender, EventArgs e)
        {
            NMR_shutdowwithbattery.Enabled = true;
            BT_TurnOn.Enabled = true;
            checkturnoff.Stop();
            ShutDown("-a");

        }

        // Hàm xử lý tắt máy tự động khi hết pin
        private void checkturnoff_Tick(object sender, EventArgs e)
        {
            Batterypercentageoff = Convert.ToInt32(NMR_shutdowwithbattery.Value);
            if (Batterypercentageoff == battery)
            {
                ShutDown("-s -t " + 30); // gọi hàm shutdown với time 30s 
            }
        }
    }
}
