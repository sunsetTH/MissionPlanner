using MissionPlanner.Controls;
namespace MissionPlanner.GCSViews.ConfigurationView
{
    partial class ConfigRadioInput
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigRadioInput));
            this.groupBoxElevons = new System.Windows.Forms.GroupBox();
            this.CHK_mixmode = new MissionPlanner.Controls.MavlinkCheckBox();
            this.CHK_elevonch2rev = new MissionPlanner.Controls.MavlinkCheckBox();
            this.CHK_elevonrev = new MissionPlanner.Controls.MavlinkCheckBox();
            this.CHK_elevonch1rev = new MissionPlanner.Controls.MavlinkCheckBox();
            this.BUT_BindDSM8 = new MissionPlanner.Controls.MyButton();
            this.BUT_BindDSMX = new MissionPlanner.Controls.MyButton();
            this.BUT_BindDSM2 = new MissionPlanner.Controls.MyButton();
            this.BUT_Calibrateradio = new MissionPlanner.Controls.MyButton();
            this.BAR8 = new MissionPlanner.Controls.HorizontalProgressBar2();
            this.BAR7 = new MissionPlanner.Controls.HorizontalProgressBar2();
            this.BAR6 = new MissionPlanner.Controls.HorizontalProgressBar2();
            this.BAR5 = new MissionPlanner.Controls.HorizontalProgressBar2();
            this.BARpitch = new MissionPlanner.Controls.VerticalProgressBar2();
            this.BARthrottle = new MissionPlanner.Controls.VerticalProgressBar2();
            this.BARyaw = new MissionPlanner.Controls.HorizontalProgressBar2();
            this.BARroll = new MissionPlanner.Controls.HorizontalProgressBar2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BAR9 = new MissionPlanner.Controls.HorizontalProgressBar2();
            this.BAR14 = new MissionPlanner.Controls.HorizontalProgressBar2();
            this.BAR13 = new MissionPlanner.Controls.HorizontalProgressBar2();
            this.BAR12 = new MissionPlanner.Controls.HorizontalProgressBar2();
            this.BAR11 = new MissionPlanner.Controls.HorizontalProgressBar2();
            this.BAR10 = new MissionPlanner.Controls.HorizontalProgressBar2();
            this.CHK_revch3 = new MissionPlanner.Controls.MavlinkCheckBox();
            this.CHK_revch4 = new MissionPlanner.Controls.MavlinkCheckBox();
            this.CHK_revch2 = new MissionPlanner.Controls.MavlinkCheckBox();
            this.CHK_revch1 = new MissionPlanner.Controls.MavlinkCheckBox();
            this.currentStateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelfm1 = new System.Windows.Forms.Label();
            this.CMB_fmode1 = new System.Windows.Forms.ComboBox();
            this.labelfm2 = new System.Windows.Forms.Label();
            this.labelfm3 = new System.Windows.Forms.Label();
            this.labelfm4 = new System.Windows.Forms.Label();
            this.labelfm5 = new System.Windows.Forms.Label();
            this.labelfm6 = new System.Windows.Forms.Label();
            this.BUT_SaveModes = new MissionPlanner.Controls.MyButton();
            this.CMB_fmode6 = new System.Windows.Forms.ComboBox();
            this.CMB_fmode5 = new System.Windows.Forms.ComboBox();
            this.CMB_fmode4 = new System.Windows.Forms.ComboBox();
            this.CMB_fmode3 = new System.Windows.Forms.ComboBox();
            this.CMB_fmode2 = new System.Windows.Forms.ComboBox();
            this.CB_simple1 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.chk_ss1 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.LBL_flightmodepwm = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_currentmode = new System.Windows.Forms.Label();
            this.groupBoxElevons.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentStateBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxElevons
            // 
            this.groupBoxElevons.Controls.Add(this.CHK_mixmode);
            this.groupBoxElevons.Controls.Add(this.CHK_elevonch2rev);
            this.groupBoxElevons.Controls.Add(this.CHK_elevonrev);
            this.groupBoxElevons.Controls.Add(this.CHK_elevonch1rev);
            resources.ApplyResources(this.groupBoxElevons, "groupBoxElevons");
            this.groupBoxElevons.Name = "groupBoxElevons";
            this.groupBoxElevons.TabStop = false;
            // 
            // CHK_mixmode
            // 
            resources.ApplyResources(this.CHK_mixmode, "CHK_mixmode");
            this.CHK_mixmode.Name = "CHK_mixmode";
            this.CHK_mixmode.OffValue = 0D;
            this.CHK_mixmode.OnValue = 1D;
            this.CHK_mixmode.ParamName = null;
            this.CHK_mixmode.UseVisualStyleBackColor = true;
            // 
            // CHK_elevonch2rev
            // 
            resources.ApplyResources(this.CHK_elevonch2rev, "CHK_elevonch2rev");
            this.CHK_elevonch2rev.Name = "CHK_elevonch2rev";
            this.CHK_elevonch2rev.OffValue = 0D;
            this.CHK_elevonch2rev.OnValue = 1D;
            this.CHK_elevonch2rev.ParamName = null;
            this.CHK_elevonch2rev.UseVisualStyleBackColor = true;
            // 
            // CHK_elevonrev
            // 
            resources.ApplyResources(this.CHK_elevonrev, "CHK_elevonrev");
            this.CHK_elevonrev.Name = "CHK_elevonrev";
            this.CHK_elevonrev.OffValue = 0D;
            this.CHK_elevonrev.OnValue = 1D;
            this.CHK_elevonrev.ParamName = null;
            this.CHK_elevonrev.UseVisualStyleBackColor = true;
            // 
            // CHK_elevonch1rev
            // 
            resources.ApplyResources(this.CHK_elevonch1rev, "CHK_elevonch1rev");
            this.CHK_elevonch1rev.Name = "CHK_elevonch1rev";
            this.CHK_elevonch1rev.OffValue = 0D;
            this.CHK_elevonch1rev.OnValue = 1D;
            this.CHK_elevonch1rev.ParamName = null;
            this.CHK_elevonch1rev.UseVisualStyleBackColor = true;
            // 
            // BUT_BindDSM8
            // 
            this.BUT_BindDSM8.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(168)))), ((int)(((byte)(173)))));
            this.BUT_BindDSM8.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(168)))), ((int)(((byte)(173)))));
            this.BUT_BindDSM8.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.BUT_BindDSM8, "BUT_BindDSM8");
            this.BUT_BindDSM8.Name = "BUT_BindDSM8";
            this.BUT_BindDSM8.UseVisualStyleBackColor = true;
            this.BUT_BindDSM8.Click += new System.EventHandler(this.BUT_Bindradiodsm8_Click);
            // 
            // BUT_BindDSMX
            // 
            this.BUT_BindDSMX.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(168)))), ((int)(((byte)(173)))));
            this.BUT_BindDSMX.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(168)))), ((int)(((byte)(173)))));
            this.BUT_BindDSMX.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.BUT_BindDSMX, "BUT_BindDSMX");
            this.BUT_BindDSMX.Name = "BUT_BindDSMX";
            this.BUT_BindDSMX.UseVisualStyleBackColor = true;
            this.BUT_BindDSMX.Click += new System.EventHandler(this.BUT_BindradiodsmX_Click);
            // 
            // BUT_BindDSM2
            // 
            this.BUT_BindDSM2.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(168)))), ((int)(((byte)(173)))));
            this.BUT_BindDSM2.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(168)))), ((int)(((byte)(173)))));
            this.BUT_BindDSM2.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.BUT_BindDSM2, "BUT_BindDSM2");
            this.BUT_BindDSM2.Name = "BUT_BindDSM2";
            this.BUT_BindDSM2.UseVisualStyleBackColor = true;
            this.BUT_BindDSM2.Click += new System.EventHandler(this.BUT_Bindradiodsm2_Click);
            // 
            // BUT_Calibrateradio
            // 
            this.BUT_Calibrateradio.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(168)))), ((int)(((byte)(173)))));
            this.BUT_Calibrateradio.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(168)))), ((int)(((byte)(173)))));
            this.BUT_Calibrateradio.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.BUT_Calibrateradio, "BUT_Calibrateradio");
            this.BUT_Calibrateradio.Name = "BUT_Calibrateradio";
            this.BUT_Calibrateradio.UseVisualStyleBackColor = true;
            this.BUT_Calibrateradio.Click += new System.EventHandler(this.BUT_Calibrateradio_Click);
            // 
            // BAR8
            // 
            this.BAR8.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(255)))));
            this.BAR8.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BAR8.DisplayScale = 1F;
            this.BAR8.DrawLabel = true;
            this.BAR8.Label = "Radio 8";
            resources.ApplyResources(this.BAR8, "BAR8");
            this.BAR8.Maximum = 2200;
            this.BAR8.maxline = 0;
            this.BAR8.Minimum = 800;
            this.BAR8.minline = 0;
            this.BAR8.Name = "BAR8";
            this.BAR8.Value = 1500;
            this.BAR8.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            // 
            // BAR7
            // 
            this.BAR7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(255)))));
            this.BAR7.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BAR7.DisplayScale = 1F;
            this.BAR7.DrawLabel = true;
            this.BAR7.Label = "Radio 7";
            resources.ApplyResources(this.BAR7, "BAR7");
            this.BAR7.Maximum = 2200;
            this.BAR7.maxline = 0;
            this.BAR7.Minimum = 800;
            this.BAR7.minline = 0;
            this.BAR7.Name = "BAR7";
            this.BAR7.Value = 1500;
            this.BAR7.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            // 
            // BAR6
            // 
            this.BAR6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(255)))));
            this.BAR6.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BAR6.DisplayScale = 1F;
            this.BAR6.DrawLabel = true;
            this.BAR6.Label = "Radio 6";
            resources.ApplyResources(this.BAR6, "BAR6");
            this.BAR6.Maximum = 2200;
            this.BAR6.maxline = 0;
            this.BAR6.Minimum = 800;
            this.BAR6.minline = 0;
            this.BAR6.Name = "BAR6";
            this.BAR6.Value = 1500;
            this.BAR6.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            // 
            // BAR5
            // 
            this.BAR5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(255)))));
            this.BAR5.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BAR5.DisplayScale = 1F;
            this.BAR5.DrawLabel = true;
            this.BAR5.Label = "Radio 5";
            resources.ApplyResources(this.BAR5, "BAR5");
            this.BAR5.Maximum = 2200;
            this.BAR5.maxline = 0;
            this.BAR5.Minimum = 800;
            this.BAR5.minline = 0;
            this.BAR5.Name = "BAR5";
            this.BAR5.Value = 1500;
            this.BAR5.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            // 
            // BARpitch
            // 
            this.BARpitch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(255)))));
            this.BARpitch.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BARpitch.DisplayScale = 1F;
            this.BARpitch.DrawLabel = true;
            this.BARpitch.Label = "Pitch";
            resources.ApplyResources(this.BARpitch, "BARpitch");
            this.BARpitch.Maximum = 2200;
            this.BARpitch.maxline = 0;
            this.BARpitch.Minimum = 800;
            this.BARpitch.minline = 0;
            this.BARpitch.Name = "BARpitch";
            this.BARpitch.Value = 1500;
            this.BARpitch.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            // 
            // BARthrottle
            // 
            this.BARthrottle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(68)))), ((int)(((byte)(69)))));
            this.BARthrottle.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BARthrottle.DisplayScale = 1F;
            this.BARthrottle.DrawLabel = true;
            this.BARthrottle.Label = "Throttle";
            resources.ApplyResources(this.BARthrottle, "BARthrottle");
            this.BARthrottle.Maximum = 2200;
            this.BARthrottle.maxline = 0;
            this.BARthrottle.Minimum = 800;
            this.BARthrottle.minline = 0;
            this.BARthrottle.Name = "BARthrottle";
            this.BARthrottle.Value = 1000;
            this.BARthrottle.ValueColor = System.Drawing.Color.Magenta;
            // 
            // BARyaw
            // 
            this.BARyaw.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(255)))));
            this.BARyaw.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BARyaw.DisplayScale = 1F;
            this.BARyaw.DrawLabel = true;
            this.BARyaw.Label = "Yaw";
            resources.ApplyResources(this.BARyaw, "BARyaw");
            this.BARyaw.Maximum = 2200;
            this.BARyaw.maxline = 0;
            this.BARyaw.Minimum = 800;
            this.BARyaw.minline = 0;
            this.BARyaw.Name = "BARyaw";
            this.BARyaw.Value = 1500;
            this.BARyaw.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            // 
            // BARroll
            // 
            this.BARroll.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(255)))));
            this.BARroll.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BARroll.DisplayScale = 1F;
            this.BARroll.DrawLabel = true;
            this.BARroll.Label = "Roll";
            resources.ApplyResources(this.BARroll, "BARroll");
            this.BARroll.Maximum = 2200;
            this.BARroll.maxline = 0;
            this.BARroll.Minimum = 800;
            this.BARroll.minline = 0;
            this.BARroll.Name = "BARroll";
            this.BARroll.Value = 1500;
            this.BARroll.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BUT_BindDSM2);
            this.groupBox1.Controls.Add(this.BUT_BindDSM8);
            this.groupBox1.Controls.Add(this.BUT_BindDSMX);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // BAR9
            // 
            this.BAR9.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(255)))));
            this.BAR9.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BAR9.DisplayScale = 1F;
            this.BAR9.DrawLabel = true;
            this.BAR9.Label = "Radio 9";
            resources.ApplyResources(this.BAR9, "BAR9");
            this.BAR9.Maximum = 2200;
            this.BAR9.maxline = 0;
            this.BAR9.Minimum = 800;
            this.BAR9.minline = 0;
            this.BAR9.Name = "BAR9";
            this.BAR9.Value = 1500;
            this.BAR9.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            // 
            // BAR14
            // 
            this.BAR14.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(255)))));
            this.BAR14.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BAR14.DisplayScale = 1F;
            this.BAR14.DrawLabel = true;
            this.BAR14.Label = "Radio 14";
            resources.ApplyResources(this.BAR14, "BAR14");
            this.BAR14.Maximum = 2200;
            this.BAR14.maxline = 0;
            this.BAR14.Minimum = 800;
            this.BAR14.minline = 0;
            this.BAR14.Name = "BAR14";
            this.BAR14.Value = 1500;
            this.BAR14.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            // 
            // BAR13
            // 
            this.BAR13.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(255)))));
            this.BAR13.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BAR13.DisplayScale = 1F;
            this.BAR13.DrawLabel = true;
            this.BAR13.Label = "Radio 13";
            resources.ApplyResources(this.BAR13, "BAR13");
            this.BAR13.Maximum = 2200;
            this.BAR13.maxline = 0;
            this.BAR13.Minimum = 800;
            this.BAR13.minline = 0;
            this.BAR13.Name = "BAR13";
            this.BAR13.Value = 1500;
            this.BAR13.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            // 
            // BAR12
            // 
            this.BAR12.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(255)))));
            this.BAR12.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BAR12.DisplayScale = 1F;
            this.BAR12.DrawLabel = true;
            this.BAR12.Label = "Radio 12";
            resources.ApplyResources(this.BAR12, "BAR12");
            this.BAR12.Maximum = 2200;
            this.BAR12.maxline = 0;
            this.BAR12.Minimum = 800;
            this.BAR12.minline = 0;
            this.BAR12.Name = "BAR12";
            this.BAR12.Value = 1500;
            this.BAR12.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            // 
            // BAR11
            // 
            this.BAR11.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(255)))));
            this.BAR11.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BAR11.DisplayScale = 1F;
            this.BAR11.DrawLabel = true;
            this.BAR11.Label = "Radio 11";
            resources.ApplyResources(this.BAR11, "BAR11");
            this.BAR11.Maximum = 2200;
            this.BAR11.maxline = 0;
            this.BAR11.Minimum = 800;
            this.BAR11.minline = 0;
            this.BAR11.Name = "BAR11";
            this.BAR11.Value = 1500;
            this.BAR11.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            // 
            // BAR10
            // 
            this.BAR10.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(255)))));
            this.BAR10.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.BAR10.DisplayScale = 1F;
            this.BAR10.DrawLabel = true;
            this.BAR10.Label = "Radio 10";
            resources.ApplyResources(this.BAR10, "BAR10");
            this.BAR10.Maximum = 2200;
            this.BAR10.maxline = 0;
            this.BAR10.Minimum = 800;
            this.BAR10.minline = 0;
            this.BAR10.Name = "BAR10";
            this.BAR10.Value = 1500;
            this.BAR10.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            // 
            // CHK_revch3
            // 
            resources.ApplyResources(this.CHK_revch3, "CHK_revch3");
            this.CHK_revch3.Name = "CHK_revch3";
            this.CHK_revch3.OffValue = 0D;
            this.CHK_revch3.OnValue = 1D;
            this.CHK_revch3.ParamName = null;
            this.CHK_revch3.UseVisualStyleBackColor = true;
            this.CHK_revch3.CheckedChanged += new System.EventHandler(this.CHK_revch3_CheckedChanged);
            // 
            // CHK_revch4
            // 
            resources.ApplyResources(this.CHK_revch4, "CHK_revch4");
            this.CHK_revch4.Name = "CHK_revch4";
            this.CHK_revch4.OffValue = 0D;
            this.CHK_revch4.OnValue = 1D;
            this.CHK_revch4.ParamName = null;
            this.CHK_revch4.UseVisualStyleBackColor = true;
            this.CHK_revch4.CheckedChanged += new System.EventHandler(this.CHK_revch4_CheckedChanged);
            // 
            // CHK_revch2
            // 
            resources.ApplyResources(this.CHK_revch2, "CHK_revch2");
            this.CHK_revch2.Name = "CHK_revch2";
            this.CHK_revch2.OffValue = 0D;
            this.CHK_revch2.OnValue = 1D;
            this.CHK_revch2.ParamName = null;
            this.CHK_revch2.UseVisualStyleBackColor = true;
            this.CHK_revch2.CheckedChanged += new System.EventHandler(this.CHK_revch2_CheckedChanged);
            // 
            // CHK_revch1
            // 
            resources.ApplyResources(this.CHK_revch1, "CHK_revch1");
            this.CHK_revch1.Name = "CHK_revch1";
            this.CHK_revch1.OffValue = 0D;
            this.CHK_revch1.OnValue = 1D;
            this.CHK_revch1.ParamName = null;
            this.CHK_revch1.UseVisualStyleBackColor = true;
            this.CHK_revch1.CheckedChanged += new System.EventHandler(this.CHK_revch1_CheckedChanged);
            // 
            // currentStateBindingSource
            // 
            this.currentStateBindingSource.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.labelfm1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CMB_fmode1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelfm2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelfm3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelfm4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelfm5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelfm6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.CMB_fmode6, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.CMB_fmode5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.CMB_fmode4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.CMB_fmode3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.CMB_fmode2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CB_simple1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBox1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBox2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBox3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.checkBox4, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.checkBox5, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.chk_ss1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBox6, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBox7, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.checkBox8, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.checkBox9, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.checkBox10, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.label12, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label10, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.label11, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // labelfm1
            // 
            resources.ApplyResources(this.labelfm1, "labelfm1");
            this.labelfm1.Name = "labelfm1";
            // 
            // CMB_fmode1
            // 
            this.CMB_fmode1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CMB_fmode1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CMB_fmode1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_fmode1.FormattingEnabled = true;
            resources.ApplyResources(this.CMB_fmode1, "CMB_fmode1");
            this.CMB_fmode1.Name = "CMB_fmode1";
            // 
            // labelfm2
            // 
            resources.ApplyResources(this.labelfm2, "labelfm2");
            this.labelfm2.Name = "labelfm2";
            // 
            // labelfm3
            // 
            resources.ApplyResources(this.labelfm3, "labelfm3");
            this.labelfm3.Name = "labelfm3";
            // 
            // labelfm4
            // 
            resources.ApplyResources(this.labelfm4, "labelfm4");
            this.labelfm4.Name = "labelfm4";
            // 
            // labelfm5
            // 
            resources.ApplyResources(this.labelfm5, "labelfm5");
            this.labelfm5.Name = "labelfm5";
            // 
            // labelfm6
            // 
            resources.ApplyResources(this.labelfm6, "labelfm6");
            this.labelfm6.Name = "labelfm6";
            // 
            // BUT_SaveModes
            // 
            this.BUT_SaveModes.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(168)))), ((int)(((byte)(173)))));
            this.BUT_SaveModes.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(168)))), ((int)(((byte)(173)))));
            this.BUT_SaveModes.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.BUT_SaveModes, "BUT_SaveModes");
            this.BUT_SaveModes.Name = "BUT_SaveModes";
            this.BUT_SaveModes.UseVisualStyleBackColor = true;
            // 
            // CMB_fmode6
            // 
            this.CMB_fmode6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CMB_fmode6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CMB_fmode6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_fmode6.FormattingEnabled = true;
            resources.ApplyResources(this.CMB_fmode6, "CMB_fmode6");
            this.CMB_fmode6.Name = "CMB_fmode6";
            // 
            // CMB_fmode5
            // 
            this.CMB_fmode5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CMB_fmode5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CMB_fmode5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_fmode5.FormattingEnabled = true;
            resources.ApplyResources(this.CMB_fmode5, "CMB_fmode5");
            this.CMB_fmode5.Name = "CMB_fmode5";
            // 
            // CMB_fmode4
            // 
            this.CMB_fmode4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CMB_fmode4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CMB_fmode4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_fmode4.FormattingEnabled = true;
            resources.ApplyResources(this.CMB_fmode4, "CMB_fmode4");
            this.CMB_fmode4.Name = "CMB_fmode4";
            // 
            // CMB_fmode3
            // 
            this.CMB_fmode3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CMB_fmode3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CMB_fmode3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_fmode3.FormattingEnabled = true;
            resources.ApplyResources(this.CMB_fmode3, "CMB_fmode3");
            this.CMB_fmode3.Name = "CMB_fmode3";
            // 
            // CMB_fmode2
            // 
            this.CMB_fmode2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CMB_fmode2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CMB_fmode2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_fmode2.FormattingEnabled = true;
            resources.ApplyResources(this.CMB_fmode2, "CMB_fmode2");
            this.CMB_fmode2.Name = "CMB_fmode2";
            // 
            // CB_simple1
            // 
            resources.ApplyResources(this.CB_simple1, "CB_simple1");
            this.CB_simple1.Name = "CB_simple1";
            this.CB_simple1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            resources.ApplyResources(this.checkBox3, "checkBox3");
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            resources.ApplyResources(this.checkBox4, "checkBox4");
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            resources.ApplyResources(this.checkBox5, "checkBox5");
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // chk_ss1
            // 
            resources.ApplyResources(this.chk_ss1, "chk_ss1");
            this.chk_ss1.Name = "chk_ss1";
            this.chk_ss1.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            resources.ApplyResources(this.checkBox6, "checkBox6");
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            resources.ApplyResources(this.checkBox7, "checkBox7");
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            resources.ApplyResources(this.checkBox8, "checkBox8");
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            resources.ApplyResources(this.checkBox9, "checkBox9");
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            resources.ApplyResources(this.checkBox10, "checkBox10");
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // LBL_flightmodepwm
            // 
            resources.ApplyResources(this.LBL_flightmodepwm, "LBL_flightmodepwm");
            this.LBL_flightmodepwm.Name = "LBL_flightmodepwm";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // lbl_currentmode
            // 
            resources.ApplyResources(this.lbl_currentmode, "lbl_currentmode");
            this.lbl_currentmode.Name = "lbl_currentmode";
            // 
            // ConfigRadioInput
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label14);
            this.Controls.Add(this.LBL_flightmodepwm);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbl_currentmode);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.BAR14);
            this.Controls.Add(this.BAR13);
            this.Controls.Add(this.BUT_SaveModes);
            this.Controls.Add(this.BAR12);
            this.Controls.Add(this.BAR11);
            this.Controls.Add(this.BAR10);
            this.Controls.Add(this.BAR9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxElevons);
            this.Controls.Add(this.CHK_revch3);
            this.Controls.Add(this.CHK_revch4);
            this.Controls.Add(this.CHK_revch2);
            this.Controls.Add(this.CHK_revch1);
            this.Controls.Add(this.BUT_Calibrateradio);
            this.Controls.Add(this.BAR8);
            this.Controls.Add(this.BAR7);
            this.Controls.Add(this.BAR6);
            this.Controls.Add(this.BAR5);
            this.Controls.Add(this.BARpitch);
            this.Controls.Add(this.BARthrottle);
            this.Controls.Add(this.BARyaw);
            this.Controls.Add(this.BARroll);
            this.Name = "ConfigRadioInput";
            resources.ApplyResources(this, "$this");
            this.groupBoxElevons.ResumeLayout(false);
            this.groupBoxElevons.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.currentStateBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxElevons;
        private MavlinkCheckBox CHK_mixmode;
        private MavlinkCheckBox CHK_elevonch2rev;
        private MavlinkCheckBox CHK_elevonrev;
        private MavlinkCheckBox CHK_elevonch1rev;
        private MavlinkCheckBox CHK_revch3;
        private MavlinkCheckBox CHK_revch4;
        private MavlinkCheckBox CHK_revch2;
        private MavlinkCheckBox CHK_revch1;
        private Controls.MyButton BUT_Calibrateradio;
        private HorizontalProgressBar2 BAR8;
        private HorizontalProgressBar2 BAR7;
        private HorizontalProgressBar2 BAR6;
        private HorizontalProgressBar2 BAR5;
        private VerticalProgressBar2 BARpitch;
        private VerticalProgressBar2 BARthrottle;
        private HorizontalProgressBar2 BARyaw;
        private HorizontalProgressBar2 BARroll;
        private System.Windows.Forms.BindingSource currentStateBindingSource;
        private MyButton BUT_BindDSM2;
        private MyButton BUT_BindDSMX;
        private MyButton BUT_BindDSM8;
        private System.Windows.Forms.GroupBox groupBox1;
        private HorizontalProgressBar2 BAR9;
        private HorizontalProgressBar2 BAR14;
        private HorizontalProgressBar2 BAR13;
        private HorizontalProgressBar2 BAR12;
        private HorizontalProgressBar2 BAR11;
        private HorizontalProgressBar2 BAR10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelfm1;
        private System.Windows.Forms.ComboBox CMB_fmode1;
        private System.Windows.Forms.Label labelfm2;
        private System.Windows.Forms.Label labelfm3;
        private System.Windows.Forms.Label labelfm4;
        private System.Windows.Forms.Label labelfm5;
        private System.Windows.Forms.Label labelfm6;
        private MyButton BUT_SaveModes;
        private System.Windows.Forms.ComboBox CMB_fmode6;
        private System.Windows.Forms.ComboBox CMB_fmode5;
        private System.Windows.Forms.ComboBox CMB_fmode4;
        private System.Windows.Forms.ComboBox CMB_fmode3;
        private System.Windows.Forms.ComboBox CMB_fmode2;
        private System.Windows.Forms.CheckBox CB_simple1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox chk_ss1;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LBL_flightmodepwm;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_currentmode;
    }
}
