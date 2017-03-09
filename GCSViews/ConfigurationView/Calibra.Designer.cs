namespace MissionPlanner.GCSViews.ConfigurationView
{
    partial class Calibration
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calibration));
            this.label1 = new System.Windows.Forms.Label();
            this.BUT_level = new MissionPlanner.Controls.MyButton();
            this.lbl_Accel_user = new System.Windows.Forms.Label();
            this.BUT_calib_accell = new MissionPlanner.Controls.MyButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BUT_MagCalibrationLive = new MissionPlanner.Controls.MyButton();
            this.LBL_primary_compass = new System.Windows.Forms.Label();
            this.LBL_compass1_mot = new System.Windows.Forms.Label();
            this.LBL_compass1_offset = new System.Windows.Forms.Label();
            this.LBL_compass2_mot = new System.Windows.Forms.Label();
            this.LBL_compass3_mot = new System.Windows.Forms.Label();
            this.LBL_compass3_offset = new System.Windows.Forms.Label();
            this.LBL_compass2_offset = new System.Windows.Forms.Label();
            this.groupBoxCompass3 = new System.Windows.Forms.GroupBox();
            this.CHK_autodec = new System.Windows.Forms.CheckBox();
            this.TXT_declination_deg = new System.Windows.Forms.TextBox();
            this.linkLabelmagdec = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TXT_declination_min = new System.Windows.Forms.TextBox();
            this.groupBoxCompass2 = new System.Windows.Forms.GroupBox();
            this.groupBoxCompass1 = new System.Windows.Forms.GroupBox();
            this.groupBoxGeneralSettings = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.CHK_compass3_external = new MissionPlanner.Controls.MavlinkCheckBox();
            this.CHK_compass3_use = new MissionPlanner.Controls.MavlinkCheckBox();
            this.CMB_compass3_orient = new MissionPlanner.Controls.MavlinkComboBox();
            this.CHK_compass2_external = new MissionPlanner.Controls.MavlinkCheckBox();
            this.CHK_compass2_use = new MissionPlanner.Controls.MavlinkCheckBox();
            this.CMB_compass2_orient = new MissionPlanner.Controls.MavlinkComboBox();
            this.CHK_compass1_external = new MissionPlanner.Controls.MavlinkCheckBox();
            this.CHK_compass1_use = new MissionPlanner.Controls.MavlinkCheckBox();
            this.CMB_compass1_orient = new MissionPlanner.Controls.MavlinkComboBox();
            this.CMB_primary_compass = new MissionPlanner.Controls.MavlinkComboBox();
            this.CHK_compass_learn = new MissionPlanner.Controls.MavlinkCheckBox();
            this.CHK_enablecompass = new MissionPlanner.Controls.MavlinkCheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBoxCompass3.SuspendLayout();
            this.groupBoxCompass2.SuspendLayout();
            this.groupBoxCompass1.SuspendLayout();
            this.groupBoxGeneralSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(34, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 24);
            this.label1.TabIndex = 92;
            this.label1.Text = "Level your Autopilot to set default accelerometer offsets (1 axis/AHRS trims).\nTh" +
    "is requires you to place your autopilot flat and level.";
            // 
            // BUT_level
            // 
            this.BUT_level.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(168)))), ((int)(((byte)(173)))));
            this.BUT_level.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(168)))), ((int)(((byte)(173)))));
            this.BUT_level.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.BUT_level.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_level.Location = new System.Drawing.Point(339, 340);
            this.BUT_level.Name = "BUT_level";
            this.BUT_level.Size = new System.Drawing.Size(102, 21);
            this.BUT_level.TabIndex = 91;
            this.BUT_level.Text = "Calibrate Level";
            this.BUT_level.UseVisualStyleBackColor = true;
            this.BUT_level.Click += new System.EventHandler(this.BUT_level_Click);
            // 
            // lbl_Accel_user
            // 
            this.lbl_Accel_user.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Accel_user.Location = new System.Drawing.Point(337, 86);
            this.lbl_Accel_user.Name = "lbl_Accel_user";
            this.lbl_Accel_user.Size = new System.Drawing.Size(105, 76);
            this.lbl_Accel_user.TabIndex = 90;
            this.lbl_Accel_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BUT_calib_accell
            // 
            this.BUT_calib_accell.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(168)))), ((int)(((byte)(173)))));
            this.BUT_calib_accell.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(168)))), ((int)(((byte)(173)))));
            this.BUT_calib_accell.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.BUT_calib_accell.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_calib_accell.Location = new System.Drawing.Point(339, 165);
            this.BUT_calib_accell.Name = "BUT_calib_accell";
            this.BUT_calib_accell.Size = new System.Drawing.Size(102, 21);
            this.BUT_calib_accell.TabIndex = 89;
            this.BUT_calib_accell.Text = "Calibrate Accel";
            this.BUT_calib_accell.UseVisualStyleBackColor = true;
            this.BUT_calib_accell.Click += new System.EventHandler(this.BUT_calib_accell_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(25, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(407, 24);
            this.label4.TabIndex = 87;
            this.label4.Text = "Level your Autopilot to set default accelerometer Min/Max (3 axis).\nThis will ask" +
    " you to place your autopilot on each edge.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(88, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 20);
            this.label5.TabIndex = 86;
            this.label5.Text = "Accelerometer Calibration";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::MissionPlanner.Properties.Resources.rotor;
            this.pictureBox1.Location = new System.Drawing.Point(124, 236);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 93;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(124, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(178, 112);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 94;
            this.pictureBox2.TabStop = false;
            // 
            // BUT_MagCalibrationLive
            // 
            this.BUT_MagCalibrationLive.BGGradBot = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(168)))), ((int)(((byte)(173)))));
            this.BUT_MagCalibrationLive.BGGradTop = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(168)))), ((int)(((byte)(173)))));
            this.BUT_MagCalibrationLive.ColorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.BUT_MagCalibrationLive.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_MagCalibrationLive.Location = new System.Drawing.Point(201, 821);
            this.BUT_MagCalibrationLive.Name = "BUT_MagCalibrationLive";
            this.BUT_MagCalibrationLive.Size = new System.Drawing.Size(196, 37);
            this.BUT_MagCalibrationLive.TabIndex = 0;
            this.BUT_MagCalibrationLive.Text = "Live Calibration";
            this.BUT_MagCalibrationLive.UseVisualStyleBackColor = true;
            // 
            // LBL_primary_compass
            // 
            this.LBL_primary_compass.AutoSize = true;
            this.LBL_primary_compass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LBL_primary_compass.Location = new System.Drawing.Point(12, 48);
            this.LBL_primary_compass.Name = "LBL_primary_compass";
            this.LBL_primary_compass.Size = new System.Drawing.Size(101, 12);
            this.LBL_primary_compass.TabIndex = 1;
            this.LBL_primary_compass.Text = "Primary Compass:";
            // 
            // LBL_compass1_mot
            // 
            this.LBL_compass1_mot.AutoSize = true;
            this.LBL_compass1_mot.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LBL_compass1_mot.Location = new System.Drawing.Point(12, 120);
            this.LBL_compass1_mot.Name = "LBL_compass1_mot";
            this.LBL_compass1_mot.Size = new System.Drawing.Size(23, 12);
            this.LBL_compass1_mot.TabIndex = 4;
            this.LBL_compass1_mot.Text = "MOT";
            // 
            // LBL_compass1_offset
            // 
            this.LBL_compass1_offset.AutoSize = true;
            this.LBL_compass1_offset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LBL_compass1_offset.Location = new System.Drawing.Point(12, 103);
            this.LBL_compass1_offset.Name = "LBL_compass1_offset";
            this.LBL_compass1_offset.Size = new System.Drawing.Size(41, 12);
            this.LBL_compass1_offset.TabIndex = 3;
            this.LBL_compass1_offset.Text = "OFFSET";
            // 
            // LBL_compass2_mot
            // 
            this.LBL_compass2_mot.AutoSize = true;
            this.LBL_compass2_mot.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LBL_compass2_mot.Location = new System.Drawing.Point(9, 120);
            this.LBL_compass2_mot.Name = "LBL_compass2_mot";
            this.LBL_compass2_mot.Size = new System.Drawing.Size(23, 12);
            this.LBL_compass2_mot.TabIndex = 4;
            this.LBL_compass2_mot.Text = "MOT";
            // 
            // LBL_compass3_mot
            // 
            this.LBL_compass3_mot.AutoSize = true;
            this.LBL_compass3_mot.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LBL_compass3_mot.Location = new System.Drawing.Point(9, 120);
            this.LBL_compass3_mot.Name = "LBL_compass3_mot";
            this.LBL_compass3_mot.Size = new System.Drawing.Size(23, 12);
            this.LBL_compass3_mot.TabIndex = 4;
            this.LBL_compass3_mot.Text = "MOT";
            // 
            // LBL_compass3_offset
            // 
            this.LBL_compass3_offset.AutoSize = true;
            this.LBL_compass3_offset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LBL_compass3_offset.Location = new System.Drawing.Point(9, 103);
            this.LBL_compass3_offset.Name = "LBL_compass3_offset";
            this.LBL_compass3_offset.Size = new System.Drawing.Size(41, 12);
            this.LBL_compass3_offset.TabIndex = 3;
            this.LBL_compass3_offset.Text = "OFFSET";
            // 
            // LBL_compass2_offset
            // 
            this.LBL_compass2_offset.AutoSize = true;
            this.LBL_compass2_offset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LBL_compass2_offset.Location = new System.Drawing.Point(9, 103);
            this.LBL_compass2_offset.Name = "LBL_compass2_offset";
            this.LBL_compass2_offset.Size = new System.Drawing.Size(41, 12);
            this.LBL_compass2_offset.TabIndex = 3;
            this.LBL_compass2_offset.Text = "OFFSET";
            // 
            // groupBoxCompass3
            // 
            this.groupBoxCompass3.Controls.Add(this.LBL_compass3_mot);
            this.groupBoxCompass3.Controls.Add(this.LBL_compass3_offset);
            this.groupBoxCompass3.Controls.Add(this.CHK_compass3_external);
            this.groupBoxCompass3.Controls.Add(this.CHK_compass3_use);
            this.groupBoxCompass3.Controls.Add(this.CMB_compass3_orient);
            this.groupBoxCompass3.Location = new System.Drawing.Point(457, 645);
            this.groupBoxCompass3.Name = "groupBoxCompass3";
            this.groupBoxCompass3.Size = new System.Drawing.Size(200, 150);
            this.groupBoxCompass3.TabIndex = 104;
            this.groupBoxCompass3.TabStop = false;
            this.groupBoxCompass3.Text = "Compass #3";
            // 
            // CHK_autodec
            // 
            this.CHK_autodec.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CHK_autodec.Location = new System.Drawing.Point(218, 18);
            this.CHK_autodec.Name = "CHK_autodec";
            this.CHK_autodec.Size = new System.Drawing.Size(177, 22);
            this.CHK_autodec.TabIndex = 3;
            this.CHK_autodec.Text = "Obtain declination automatically";
            this.CHK_autodec.UseVisualStyleBackColor = true;
            // 
            // TXT_declination_deg
            // 
            this.TXT_declination_deg.Enabled = false;
            this.TXT_declination_deg.Location = new System.Drawing.Point(284, 41);
            this.TXT_declination_deg.Name = "TXT_declination_deg";
            this.TXT_declination_deg.Size = new System.Drawing.Size(53, 21);
            this.TXT_declination_deg.TabIndex = 6;
            // 
            // linkLabelmagdec
            // 
            this.linkLabelmagdec.AutoSize = true;
            this.linkLabelmagdec.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkLabelmagdec.Location = new System.Drawing.Point(236, 64);
            this.linkLabelmagdec.Name = "linkLabelmagdec";
            this.linkLabelmagdec.Size = new System.Drawing.Size(119, 12);
            this.linkLabelmagdec.TabIndex = 9;
            this.linkLabelmagdec.TabStop = true;
            this.linkLabelmagdec.Text = "Declination WebSite";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(115, 496);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 20);
            this.label3.TabIndex = 95;
            this.label3.Text = "Compass";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Location = new System.Drawing.Point(28, 519);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 5);
            this.groupBox2.TabIndex = 96;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(236, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "Degrees";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(343, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 7;
            this.label7.Text = "Minutes";
            // 
            // TXT_declination_min
            // 
            this.TXT_declination_min.Enabled = false;
            this.TXT_declination_min.Location = new System.Drawing.Point(391, 40);
            this.TXT_declination_min.Name = "TXT_declination_min";
            this.TXT_declination_min.Size = new System.Drawing.Size(53, 21);
            this.TXT_declination_min.TabIndex = 8;
            // 
            // groupBoxCompass2
            // 
            this.groupBoxCompass2.Controls.Add(this.LBL_compass2_mot);
            this.groupBoxCompass2.Controls.Add(this.LBL_compass2_offset);
            this.groupBoxCompass2.Controls.Add(this.CHK_compass2_external);
            this.groupBoxCompass2.Controls.Add(this.CHK_compass2_use);
            this.groupBoxCompass2.Controls.Add(this.CMB_compass2_orient);
            this.groupBoxCompass2.Location = new System.Drawing.Point(248, 645);
            this.groupBoxCompass2.Name = "groupBoxCompass2";
            this.groupBoxCompass2.Size = new System.Drawing.Size(200, 150);
            this.groupBoxCompass2.TabIndex = 103;
            this.groupBoxCompass2.TabStop = false;
            this.groupBoxCompass2.Text = "Compass #2";
            // 
            // groupBoxCompass1
            // 
            this.groupBoxCompass1.Controls.Add(this.LBL_compass1_mot);
            this.groupBoxCompass1.Controls.Add(this.LBL_compass1_offset);
            this.groupBoxCompass1.Controls.Add(this.CHK_compass1_external);
            this.groupBoxCompass1.Controls.Add(this.CHK_compass1_use);
            this.groupBoxCompass1.Controls.Add(this.CMB_compass1_orient);
            this.groupBoxCompass1.Location = new System.Drawing.Point(42, 645);
            this.groupBoxCompass1.Name = "groupBoxCompass1";
            this.groupBoxCompass1.Size = new System.Drawing.Size(200, 150);
            this.groupBoxCompass1.TabIndex = 102;
            this.groupBoxCompass1.TabStop = false;
            this.groupBoxCompass1.Text = "Compass #1";
            // 
            // groupBoxGeneralSettings
            // 
            this.groupBoxGeneralSettings.Controls.Add(this.CMB_primary_compass);
            this.groupBoxGeneralSettings.Controls.Add(this.LBL_primary_compass);
            this.groupBoxGeneralSettings.Controls.Add(this.CHK_compass_learn);
            this.groupBoxGeneralSettings.Controls.Add(this.CHK_enablecompass);
            this.groupBoxGeneralSettings.Controls.Add(this.CHK_autodec);
            this.groupBoxGeneralSettings.Controls.Add(this.label6);
            this.groupBoxGeneralSettings.Controls.Add(this.label7);
            this.groupBoxGeneralSettings.Controls.Add(this.TXT_declination_min);
            this.groupBoxGeneralSettings.Controls.Add(this.TXT_declination_deg);
            this.groupBoxGeneralSettings.Controls.Add(this.linkLabelmagdec);
            this.groupBoxGeneralSettings.Location = new System.Drawing.Point(42, 554);
            this.groupBoxGeneralSettings.Name = "groupBoxGeneralSettings";
            this.groupBoxGeneralSettings.Size = new System.Drawing.Size(615, 85);
            this.groupBoxGeneralSettings.TabIndex = 101;
            this.groupBoxGeneralSettings.TabStop = false;
            this.groupBoxGeneralSettings.Text = "General Compass Settings";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(31, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 48);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 108;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(28, 454);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(58, 59);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 109;
            this.pictureBox4.TabStop = false;
            // 
            // CHK_compass3_external
            // 
            this.CHK_compass3_external.Enabled = false;
            this.CHK_compass3_external.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CHK_compass3_external.Location = new System.Drawing.Point(12, 39);
            this.CHK_compass3_external.Name = "CHK_compass3_external";
            this.CHK_compass3_external.OffValue = 0D;
            this.CHK_compass3_external.OnValue = 1D;
            this.CHK_compass3_external.ParamName = null;
            this.CHK_compass3_external.Size = new System.Drawing.Size(148, 23);
            this.CHK_compass3_external.TabIndex = 1;
            this.CHK_compass3_external.Text = "Externally mounted";
            this.CHK_compass3_external.UseVisualStyleBackColor = true;
            // 
            // CHK_compass3_use
            // 
            this.CHK_compass3_use.Enabled = false;
            this.CHK_compass3_use.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CHK_compass3_use.Location = new System.Drawing.Point(12, 20);
            this.CHK_compass3_use.Name = "CHK_compass3_use";
            this.CHK_compass3_use.OffValue = 0D;
            this.CHK_compass3_use.OnValue = 1D;
            this.CHK_compass3_use.ParamName = null;
            this.CHK_compass3_use.Size = new System.Drawing.Size(148, 23);
            this.CHK_compass3_use.TabIndex = 0;
            this.CHK_compass3_use.Text = "Use this compass";
            this.CHK_compass3_use.UseVisualStyleBackColor = true;
            // 
            // CMB_compass3_orient
            // 
            this.CMB_compass3_orient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_compass3_orient.Enabled = false;
            this.CMB_compass3_orient.FormattingEnabled = true;
            this.CMB_compass3_orient.Location = new System.Drawing.Point(12, 68);
            this.CMB_compass3_orient.Name = "CMB_compass3_orient";
            this.CMB_compass3_orient.ParamName = null;
            this.CMB_compass3_orient.Size = new System.Drawing.Size(182, 20);
            this.CMB_compass3_orient.SubControl = null;
            this.CMB_compass3_orient.TabIndex = 2;
            // 
            // CHK_compass2_external
            // 
            this.CHK_compass2_external.Enabled = false;
            this.CHK_compass2_external.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CHK_compass2_external.Location = new System.Drawing.Point(12, 39);
            this.CHK_compass2_external.Name = "CHK_compass2_external";
            this.CHK_compass2_external.OffValue = 0D;
            this.CHK_compass2_external.OnValue = 1D;
            this.CHK_compass2_external.ParamName = null;
            this.CHK_compass2_external.Size = new System.Drawing.Size(148, 23);
            this.CHK_compass2_external.TabIndex = 1;
            this.CHK_compass2_external.Text = "Externally mounted";
            this.CHK_compass2_external.UseVisualStyleBackColor = true;
            // 
            // CHK_compass2_use
            // 
            this.CHK_compass2_use.Enabled = false;
            this.CHK_compass2_use.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CHK_compass2_use.Location = new System.Drawing.Point(12, 20);
            this.CHK_compass2_use.Name = "CHK_compass2_use";
            this.CHK_compass2_use.OffValue = 0D;
            this.CHK_compass2_use.OnValue = 1D;
            this.CHK_compass2_use.ParamName = null;
            this.CHK_compass2_use.Size = new System.Drawing.Size(148, 23);
            this.CHK_compass2_use.TabIndex = 0;
            this.CHK_compass2_use.Text = "Use this compass";
            this.CHK_compass2_use.UseVisualStyleBackColor = true;
            // 
            // CMB_compass2_orient
            // 
            this.CMB_compass2_orient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_compass2_orient.Enabled = false;
            this.CMB_compass2_orient.FormattingEnabled = true;
            this.CMB_compass2_orient.Location = new System.Drawing.Point(12, 68);
            this.CMB_compass2_orient.Name = "CMB_compass2_orient";
            this.CMB_compass2_orient.ParamName = null;
            this.CMB_compass2_orient.Size = new System.Drawing.Size(182, 20);
            this.CMB_compass2_orient.SubControl = null;
            this.CMB_compass2_orient.TabIndex = 2;
            // 
            // CHK_compass1_external
            // 
            this.CHK_compass1_external.Enabled = false;
            this.CHK_compass1_external.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CHK_compass1_external.Location = new System.Drawing.Point(12, 39);
            this.CHK_compass1_external.Name = "CHK_compass1_external";
            this.CHK_compass1_external.OffValue = 0D;
            this.CHK_compass1_external.OnValue = 1D;
            this.CHK_compass1_external.ParamName = null;
            this.CHK_compass1_external.Size = new System.Drawing.Size(148, 23);
            this.CHK_compass1_external.TabIndex = 1;
            this.CHK_compass1_external.Text = "Externally mounted";
            this.CHK_compass1_external.UseVisualStyleBackColor = true;
            // 
            // CHK_compass1_use
            // 
            this.CHK_compass1_use.Enabled = false;
            this.CHK_compass1_use.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CHK_compass1_use.Location = new System.Drawing.Point(12, 20);
            this.CHK_compass1_use.Name = "CHK_compass1_use";
            this.CHK_compass1_use.OffValue = 0D;
            this.CHK_compass1_use.OnValue = 1D;
            this.CHK_compass1_use.ParamName = null;
            this.CHK_compass1_use.Size = new System.Drawing.Size(148, 23);
            this.CHK_compass1_use.TabIndex = 0;
            this.CHK_compass1_use.Text = "Use this compass";
            this.CHK_compass1_use.UseVisualStyleBackColor = true;
            // 
            // CMB_compass1_orient
            // 
            this.CMB_compass1_orient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_compass1_orient.Enabled = false;
            this.CMB_compass1_orient.FormattingEnabled = true;
            this.CMB_compass1_orient.Location = new System.Drawing.Point(12, 68);
            this.CMB_compass1_orient.Name = "CMB_compass1_orient";
            this.CMB_compass1_orient.ParamName = null;
            this.CMB_compass1_orient.Size = new System.Drawing.Size(182, 20);
            this.CMB_compass1_orient.SubControl = null;
            this.CMB_compass1_orient.TabIndex = 2;
            // 
            // CMB_primary_compass
            // 
            this.CMB_primary_compass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_primary_compass.Enabled = false;
            this.CMB_primary_compass.FormattingEnabled = true;
            this.CMB_primary_compass.Location = new System.Drawing.Point(108, 44);
            this.CMB_primary_compass.Name = "CMB_primary_compass";
            this.CMB_primary_compass.ParamName = null;
            this.CMB_primary_compass.Size = new System.Drawing.Size(92, 20);
            this.CMB_primary_compass.SubControl = null;
            this.CMB_primary_compass.TabIndex = 2;
            // 
            // CHK_compass_learn
            // 
            this.CHK_compass_learn.Enabled = false;
            this.CHK_compass_learn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CHK_compass_learn.Location = new System.Drawing.Point(465, 18);
            this.CHK_compass_learn.Name = "CHK_compass_learn";
            this.CHK_compass_learn.OffValue = 0D;
            this.CHK_compass_learn.OnValue = 1D;
            this.CHK_compass_learn.ParamName = null;
            this.CHK_compass_learn.Size = new System.Drawing.Size(148, 23);
            this.CHK_compass_learn.TabIndex = 0;
            this.CHK_compass_learn.Text = "Automatically learn offsets";
            this.CHK_compass_learn.UseVisualStyleBackColor = true;
            // 
            // CHK_enablecompass
            // 
            this.CHK_enablecompass.Enabled = false;
            this.CHK_enablecompass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CHK_enablecompass.Location = new System.Drawing.Point(6, 18);
            this.CHK_enablecompass.Name = "CHK_enablecompass";
            this.CHK_enablecompass.OffValue = 0D;
            this.CHK_enablecompass.OnValue = 1D;
            this.CHK_enablecompass.ParamName = null;
            this.CHK_enablecompass.Size = new System.Drawing.Size(148, 23);
            this.CHK_enablecompass.TabIndex = 0;
            this.CHK_enablecompass.Text = "Enable compasses";
            this.CHK_enablecompass.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(22, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 5);
            this.groupBox1.TabIndex = 110;
            this.groupBox1.TabStop = false;
            // 
            // Calibration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BUT_MagCalibrationLive);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBoxCompass3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxCompass2);
            this.Controls.Add(this.groupBoxCompass1);
            this.Controls.Add(this.groupBoxGeneralSettings);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BUT_level);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Accel_user);
            this.Controls.Add(this.BUT_calib_accell);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Name = "Calibration";
            this.Size = new System.Drawing.Size(906, 1016);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBoxCompass3.ResumeLayout(false);
            this.groupBoxCompass3.PerformLayout();
            this.groupBoxCompass2.ResumeLayout(false);
            this.groupBoxCompass2.PerformLayout();
            this.groupBoxCompass1.ResumeLayout(false);
            this.groupBoxCompass1.PerformLayout();
            this.groupBoxGeneralSettings.ResumeLayout(false);
            this.groupBoxGeneralSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Controls.MyButton BUT_level;
        private System.Windows.Forms.Label lbl_Accel_user;
        private Controls.MyButton BUT_calib_accell;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private Controls.MyButton BUT_MagCalibrationLive;
        private Controls.MavlinkComboBox CMB_primary_compass;
        private System.Windows.Forms.Label LBL_primary_compass;
        private Controls.MavlinkCheckBox CHK_compass_learn;
        private Controls.MavlinkCheckBox CHK_enablecompass;
        private System.Windows.Forms.Label LBL_compass1_mot;
        private System.Windows.Forms.Label LBL_compass1_offset;
        private Controls.MavlinkCheckBox CHK_compass1_external;
        private Controls.MavlinkCheckBox CHK_compass1_use;
        private Controls.MavlinkComboBox CMB_compass1_orient;
        private System.Windows.Forms.Label LBL_compass2_mot;
        private Controls.MavlinkCheckBox CHK_compass2_external;
        private Controls.MavlinkCheckBox CHK_compass2_use;
        private Controls.MavlinkComboBox CMB_compass2_orient;
        private System.Windows.Forms.Label LBL_compass3_mot;
        private System.Windows.Forms.Label LBL_compass3_offset;
        private Controls.MavlinkCheckBox CHK_compass3_external;
        private Controls.MavlinkCheckBox CHK_compass3_use;
        private Controls.MavlinkComboBox CMB_compass3_orient;
        private System.Windows.Forms.Label LBL_compass2_offset;
        private System.Windows.Forms.GroupBox groupBoxCompass3;
        private System.Windows.Forms.CheckBox CHK_autodec;
        private System.Windows.Forms.TextBox TXT_declination_deg;
        private System.Windows.Forms.LinkLabel linkLabelmagdec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TXT_declination_min;
        private System.Windows.Forms.GroupBox groupBoxCompass2;
        private System.Windows.Forms.GroupBox groupBoxCompass1;
        private System.Windows.Forms.GroupBox groupBoxGeneralSettings;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
