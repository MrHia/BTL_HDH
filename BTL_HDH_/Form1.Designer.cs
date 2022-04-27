namespace BTL_HDH_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.control = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btRestart = new System.Windows.Forms.Button();
            this.btShutdow = new System.Windows.Forms.Button();
            this.nmGiay = new System.Windows.Forms.NumericUpDown();
            this.nmPhut = new System.Windows.Forms.NumericUpDown();
            this.nmGio = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BT_Cancel = new System.Windows.Forms.Button();
            this.BT_TurnOn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.NMR_shutdowwithbattery = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCharge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Timeturnoff = new System.Windows.Forms.Timer(this.components);
            this.realtime = new System.Windows.Forms.Timer(this.components);
            this.checkturnoff = new System.Windows.Forms.Timer(this.components);
            this.control.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmGiay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPhut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmGio)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NMR_shutdowwithbattery)).BeginInit();
            this.SuspendLayout();
            // 
            // control
            // 
            this.control.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.control.Controls.Add(this.tabPage1);
            this.control.Controls.Add(this.tabPage2);
            this.control.Location = new System.Drawing.Point(13, 13);
            this.control.Name = "control";
            this.control.SelectedIndex = 0;
            this.control.Size = new System.Drawing.Size(676, 215);
            this.control.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btCancel);
            this.tabPage1.Controls.Add(this.btRestart);
            this.tabPage1.Controls.Add(this.btShutdow);
            this.tabPage1.Controls.Add(this.nmGiay);
            this.tabPage1.Controls.Add(this.nmPhut);
            this.tabPage1.Controls.Add(this.nmGio);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(668, 186);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hẹn giờ tắt laptop ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(3, 161);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(662, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Giây";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Phút";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Giờ";
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(245, 100);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(106, 52);
            this.btCancel.TabIndex = 9;
            this.btCancel.Text = "Hủy";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btRestart
            // 
            this.btRestart.Location = new System.Drawing.Point(127, 100);
            this.btRestart.Name = "btRestart";
            this.btRestart.Size = new System.Drawing.Size(112, 52);
            this.btRestart.TabIndex = 7;
            this.btRestart.Text = "khởi động lại";
            this.btRestart.UseVisualStyleBackColor = true;
            this.btRestart.Click += new System.EventHandler(this.btRestart_Click);
            // 
            // btShutdow
            // 
            this.btShutdow.Location = new System.Drawing.Point(19, 100);
            this.btShutdow.Name = "btShutdow";
            this.btShutdow.Size = new System.Drawing.Size(102, 52);
            this.btShutdow.TabIndex = 6;
            this.btShutdow.Text = "Tắt máy";
            this.btShutdow.UseVisualStyleBackColor = true;
            this.btShutdow.Click += new System.EventHandler(this.btShutdow_Click);
            // 
            // nmGiay
            // 
            this.nmGiay.Location = new System.Drawing.Point(244, 29);
            this.nmGiay.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nmGiay.Name = "nmGiay";
            this.nmGiay.Size = new System.Drawing.Size(41, 22);
            this.nmGiay.TabIndex = 5;
            this.nmGiay.ValueChanged += new System.EventHandler(this.nmGiay_ValueChanged);
            // 
            // nmPhut
            // 
            this.nmPhut.Location = new System.Drawing.Point(127, 29);
            this.nmPhut.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nmPhut.Name = "nmPhut";
            this.nmPhut.Size = new System.Drawing.Size(41, 22);
            this.nmPhut.TabIndex = 4;
            this.nmPhut.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmPhut.ValueChanged += new System.EventHandler(this.nmPhut_ValueChanged);
            // 
            // nmGio
            // 
            this.nmGio.Location = new System.Drawing.Point(19, 29);
            this.nmGio.Name = "nmGio";
            this.nmGio.Size = new System.Drawing.Size(42, 22);
            this.nmGio.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BT_Cancel);
            this.tabPage2.Controls.Add(this.BT_TurnOn);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.NMR_shutdowwithbattery);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtCharge);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(668, 186);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tự động tắt laptop với phần trăm pin";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BT_Cancel
            // 
            this.BT_Cancel.Location = new System.Drawing.Point(237, 108);
            this.BT_Cancel.Name = "BT_Cancel";
            this.BT_Cancel.Size = new System.Drawing.Size(96, 51);
            this.BT_Cancel.TabIndex = 5;
            this.BT_Cancel.Text = "Hủy";
            this.BT_Cancel.UseVisualStyleBackColor = true;
            this.BT_Cancel.Click += new System.EventHandler(this.BT_Cancel_Click);
            // 
            // BT_TurnOn
            // 
            this.BT_TurnOn.Location = new System.Drawing.Point(25, 108);
            this.BT_TurnOn.Name = "BT_TurnOn";
            this.BT_TurnOn.Size = new System.Drawing.Size(126, 51);
            this.BT_TurnOn.TabIndex = 1;
            this.BT_TurnOn.Text = "Bật tự động tắt";
            this.BT_TurnOn.UseVisualStyleBackColor = true;
            this.BT_TurnOn.Click += new System.EventHandler(this.BT_TurnOn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(244, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "%";
            // 
            // NMR_shutdowwithbattery
            // 
            this.NMR_shutdowwithbattery.Location = new System.Drawing.Point(181, 45);
            this.NMR_shutdowwithbattery.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NMR_shutdowwithbattery.Name = "NMR_shutdowwithbattery";
            this.NMR_shutdowwithbattery.Size = new System.Drawing.Size(57, 22);
            this.NMR_shutdowwithbattery.TabIndex = 3;
            this.NMR_shutdowwithbattery.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cài đặt lượng pin tắt: ";
            // 
            // txtCharge
            // 
            this.txtCharge.Location = new System.Drawing.Point(181, 16);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.ReadOnly = true;
            this.txtCharge.Size = new System.Drawing.Size(108, 22);
            this.txtCharge.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lượng pin còn lại : ";
            // 
            // Timeturnoff
            // 
            this.Timeturnoff.Interval = 1000;
            this.Timeturnoff.Tick += new System.EventHandler(this.Timeturnoff_Tick);
            // 
            // realtime
            // 
            this.realtime.Tick += new System.EventHandler(this.realtime_Tick);
            // 
            // checkturnoff
            // 
            this.checkturnoff.Interval = 1000;
            this.checkturnoff.Tick += new System.EventHandler(this.checkturnoff_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 240);
            this.Controls.Add(this.control);
            this.Name = "Form1";
            this.Text = "Tắt máy tính";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.control.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmGiay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPhut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmGio)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NMR_shutdowwithbattery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl control;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btRestart;
        private System.Windows.Forms.Button btShutdow;
        private System.Windows.Forms.NumericUpDown nmGiay;
        private System.Windows.Forms.NumericUpDown nmPhut;
        private System.Windows.Forms.NumericUpDown nmGio;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer Timeturnoff;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NMR_shutdowwithbattery;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCharge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer realtime;
        private System.Windows.Forms.Button BT_Cancel;
        private System.Windows.Forms.Button BT_TurnOn;
        private System.Windows.Forms.Timer checkturnoff;
    }
}

