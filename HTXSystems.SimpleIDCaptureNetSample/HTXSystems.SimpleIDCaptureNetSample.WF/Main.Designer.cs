namespace HTXSystems.SimpleIDCaptureNetSample.WF
{
    partial class Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabRegister = new System.Windows.Forms.TabPage();
            this.gbFingers = new System.Windows.Forms.GroupBox();
            this.btLeftLittle = new System.Windows.Forms.Button();
            this.btLeftRing = new System.Windows.Forms.Button();
            this.btLeftMiddle = new System.Windows.Forms.Button();
            this.btLeftIndex = new System.Windows.Forms.Button();
            this.btLeftThumb = new System.Windows.Forms.Button();
            this.btRightLittle = new System.Windows.Forms.Button();
            this.btRightRing = new System.Windows.Forms.Button();
            this.btRightMiddle = new System.Windows.Forms.Button();
            this.btRightIndex = new System.Windows.Forms.Button();
            this.btRightThumb = new System.Windows.Forms.Button();
            this.pbRegisterFingerprint = new System.Windows.Forms.PictureBox();
            this.tbCustom3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCustom2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCustom1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btSubmitRegister = new System.Windows.Forms.Button();
            this.btStartRegister = new System.Windows.Forms.Button();
            this.btRegisterFaceOnly = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btLoadImageRegisterFace = new System.Windows.Forms.Button();
            this.pbRegisterFace = new System.Windows.Forms.PictureBox();
            this.tabSearchFingerprint = new System.Windows.Forms.TabPage();
            this.pbSearchFingerprint = new System.Windows.Forms.PictureBox();
            this.btCancelSearchFingerprint = new System.Windows.Forms.Button();
            this.btSearchFingerprint = new System.Windows.Forms.Button();
            this.tabSearchFace = new System.Windows.Forms.TabPage();
            this.btSearchFace = new System.Windows.Forms.Button();
            this.pbSearchFace = new System.Windows.Forms.PictureBox();
            this.btLoadImageSearchFace = new System.Windows.Forms.Button();
            this.tabDelete = new System.Windows.Forms.TabPage();
            this.btDeletePerson = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAccountId = new System.Windows.Forms.TextBox();
            this.tbPersonId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.btCancelRegister = new System.Windows.Forms.Button();
            this.btClearRegister = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabRegister.SuspendLayout();
            this.gbFingers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegisterFingerprint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegisterFace)).BeginInit();
            this.tabSearchFingerprint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchFingerprint)).BeginInit();
            this.tabSearchFace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchFace)).BeginInit();
            this.tabDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabRegister);
            this.tabControl1.Controls.Add(this.tabSearchFingerprint);
            this.tabControl1.Controls.Add(this.tabSearchFace);
            this.tabControl1.Controls.Add(this.tabDelete);
            this.tabControl1.Location = new System.Drawing.Point(12, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(982, 440);
            this.tabControl1.TabIndex = 5;
            // 
            // tabRegister
            // 
            this.tabRegister.Controls.Add(this.btClearRegister);
            this.tabRegister.Controls.Add(this.btCancelRegister);
            this.tabRegister.Controls.Add(this.gbFingers);
            this.tabRegister.Controls.Add(this.pbRegisterFingerprint);
            this.tabRegister.Controls.Add(this.tbCustom3);
            this.tabRegister.Controls.Add(this.label6);
            this.tabRegister.Controls.Add(this.tbCustom2);
            this.tabRegister.Controls.Add(this.label5);
            this.tabRegister.Controls.Add(this.tbCustom1);
            this.tabRegister.Controls.Add(this.label4);
            this.tabRegister.Controls.Add(this.btSubmitRegister);
            this.tabRegister.Controls.Add(this.btStartRegister);
            this.tabRegister.Controls.Add(this.btRegisterFaceOnly);
            this.tabRegister.Controls.Add(this.label3);
            this.tabRegister.Controls.Add(this.btLoadImageRegisterFace);
            this.tabRegister.Controls.Add(this.pbRegisterFace);
            this.tabRegister.Location = new System.Drawing.Point(4, 25);
            this.tabRegister.Name = "tabRegister";
            this.tabRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegister.Size = new System.Drawing.Size(974, 411);
            this.tabRegister.TabIndex = 0;
            this.tabRegister.Text = "Register";
            this.tabRegister.UseVisualStyleBackColor = true;
            // 
            // gbFingers
            // 
            this.gbFingers.Controls.Add(this.btLeftLittle);
            this.gbFingers.Controls.Add(this.btLeftRing);
            this.gbFingers.Controls.Add(this.btLeftMiddle);
            this.gbFingers.Controls.Add(this.btLeftIndex);
            this.gbFingers.Controls.Add(this.btLeftThumb);
            this.gbFingers.Controls.Add(this.btRightLittle);
            this.gbFingers.Controls.Add(this.btRightRing);
            this.gbFingers.Controls.Add(this.btRightMiddle);
            this.gbFingers.Controls.Add(this.btRightIndex);
            this.gbFingers.Controls.Add(this.btRightThumb);
            this.gbFingers.Enabled = false;
            this.gbFingers.Location = new System.Drawing.Point(312, 211);
            this.gbFingers.Name = "gbFingers";
            this.gbFingers.Size = new System.Drawing.Size(602, 130);
            this.gbFingers.TabIndex = 18;
            this.gbFingers.TabStop = false;
            this.gbFingers.Text = "Fingers";
            // 
            // btLeftLittle
            // 
            this.btLeftLittle.Location = new System.Drawing.Point(478, 79);
            this.btLeftLittle.Name = "btLeftLittle";
            this.btLeftLittle.Size = new System.Drawing.Size(104, 34);
            this.btLeftLittle.TabIndex = 9;
            this.btLeftLittle.Text = "Left Little";
            this.btLeftLittle.UseVisualStyleBackColor = true;
            this.btLeftLittle.Click += new System.EventHandler(this.btLeftLittle_Click);
            // 
            // btLeftRing
            // 
            this.btLeftRing.Location = new System.Drawing.Point(359, 79);
            this.btLeftRing.Name = "btLeftRing";
            this.btLeftRing.Size = new System.Drawing.Size(104, 34);
            this.btLeftRing.TabIndex = 8;
            this.btLeftRing.Text = "Left Ring";
            this.btLeftRing.UseVisualStyleBackColor = true;
            this.btLeftRing.Click += new System.EventHandler(this.btLeftRing_Click);
            // 
            // btLeftMiddle
            // 
            this.btLeftMiddle.Location = new System.Drawing.Point(239, 79);
            this.btLeftMiddle.Name = "btLeftMiddle";
            this.btLeftMiddle.Size = new System.Drawing.Size(104, 34);
            this.btLeftMiddle.TabIndex = 7;
            this.btLeftMiddle.Text = "Left Middle";
            this.btLeftMiddle.UseVisualStyleBackColor = true;
            this.btLeftMiddle.Click += new System.EventHandler(this.btLeftMiddle_Click);
            // 
            // btLeftIndex
            // 
            this.btLeftIndex.Location = new System.Drawing.Point(122, 79);
            this.btLeftIndex.Name = "btLeftIndex";
            this.btLeftIndex.Size = new System.Drawing.Size(104, 34);
            this.btLeftIndex.TabIndex = 6;
            this.btLeftIndex.Text = "Left Index";
            this.btLeftIndex.UseVisualStyleBackColor = true;
            this.btLeftIndex.Click += new System.EventHandler(this.btLeftIndex_Click);
            // 
            // btLeftThumb
            // 
            this.btLeftThumb.Location = new System.Drawing.Point(6, 79);
            this.btLeftThumb.Name = "btLeftThumb";
            this.btLeftThumb.Size = new System.Drawing.Size(104, 34);
            this.btLeftThumb.TabIndex = 5;
            this.btLeftThumb.Text = "Left Thumb";
            this.btLeftThumb.UseVisualStyleBackColor = true;
            this.btLeftThumb.Click += new System.EventHandler(this.btLeftThumb_Click);
            // 
            // btRightLittle
            // 
            this.btRightLittle.Location = new System.Drawing.Point(478, 28);
            this.btRightLittle.Name = "btRightLittle";
            this.btRightLittle.Size = new System.Drawing.Size(104, 34);
            this.btRightLittle.TabIndex = 4;
            this.btRightLittle.Text = "Right Little";
            this.btRightLittle.UseVisualStyleBackColor = true;
            this.btRightLittle.Click += new System.EventHandler(this.btRightLittle_Click);
            // 
            // btRightRing
            // 
            this.btRightRing.Location = new System.Drawing.Point(359, 28);
            this.btRightRing.Name = "btRightRing";
            this.btRightRing.Size = new System.Drawing.Size(104, 34);
            this.btRightRing.TabIndex = 3;
            this.btRightRing.Text = "Right Ring";
            this.btRightRing.UseVisualStyleBackColor = true;
            this.btRightRing.Click += new System.EventHandler(this.btRightRing_Click);
            // 
            // btRightMiddle
            // 
            this.btRightMiddle.Location = new System.Drawing.Point(239, 28);
            this.btRightMiddle.Name = "btRightMiddle";
            this.btRightMiddle.Size = new System.Drawing.Size(104, 34);
            this.btRightMiddle.TabIndex = 2;
            this.btRightMiddle.Text = "Right Middle";
            this.btRightMiddle.UseVisualStyleBackColor = true;
            this.btRightMiddle.Click += new System.EventHandler(this.btRightMiddle_Click);
            // 
            // btRightIndex
            // 
            this.btRightIndex.Location = new System.Drawing.Point(122, 28);
            this.btRightIndex.Name = "btRightIndex";
            this.btRightIndex.Size = new System.Drawing.Size(104, 34);
            this.btRightIndex.TabIndex = 1;
            this.btRightIndex.Text = "Right Index";
            this.btRightIndex.UseVisualStyleBackColor = true;
            this.btRightIndex.Click += new System.EventHandler(this.btRightIndex_Click);
            // 
            // btRightThumb
            // 
            this.btRightThumb.Location = new System.Drawing.Point(6, 28);
            this.btRightThumb.Name = "btRightThumb";
            this.btRightThumb.Size = new System.Drawing.Size(104, 34);
            this.btRightThumb.TabIndex = 0;
            this.btRightThumb.Text = "Right Thumb";
            this.btRightThumb.UseVisualStyleBackColor = true;
            this.btRightThumb.Click += new System.EventHandler(this.btRightThumb_Click);
            // 
            // pbRegisterFingerprint
            // 
            this.pbRegisterFingerprint.Location = new System.Drawing.Point(780, 43);
            this.pbRegisterFingerprint.Name = "pbRegisterFingerprint";
            this.pbRegisterFingerprint.Size = new System.Drawing.Size(134, 141);
            this.pbRegisterFingerprint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRegisterFingerprint.TabIndex = 17;
            this.pbRegisterFingerprint.TabStop = false;
            // 
            // tbCustom3
            // 
            this.tbCustom3.Location = new System.Drawing.Point(353, 117);
            this.tbCustom3.Name = "tbCustom3";
            this.tbCustom3.Size = new System.Drawing.Size(147, 22);
            this.tbCustom3.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Custom 3:";
            // 
            // tbCustom2
            // 
            this.tbCustom2.Location = new System.Drawing.Point(353, 80);
            this.tbCustom2.Name = "tbCustom2";
            this.tbCustom2.Size = new System.Drawing.Size(147, 22);
            this.tbCustom2.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Custom 2:";
            // 
            // tbCustom1
            // 
            this.tbCustom1.Location = new System.Drawing.Point(353, 43);
            this.tbCustom1.Name = "tbCustom1";
            this.tbCustom1.Size = new System.Drawing.Size(147, 22);
            this.tbCustom1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Custom 1:";
            // 
            // btSubmitRegister
            // 
            this.btSubmitRegister.Enabled = false;
            this.btSubmitRegister.Location = new System.Drawing.Point(801, 347);
            this.btSubmitRegister.Name = "btSubmitRegister";
            this.btSubmitRegister.Size = new System.Drawing.Size(137, 45);
            this.btSubmitRegister.TabIndex = 5;
            this.btSubmitRegister.Text = "Submit";
            this.btSubmitRegister.UseVisualStyleBackColor = true;
            this.btSubmitRegister.Click += new System.EventHandler(this.btSubmitRegister_Click);
            // 
            // btStartRegister
            // 
            this.btStartRegister.Location = new System.Drawing.Point(39, 337);
            this.btStartRegister.Name = "btStartRegister";
            this.btStartRegister.Size = new System.Drawing.Size(185, 55);
            this.btStartRegister.TabIndex = 4;
            this.btStartRegister.Text = "Start Register";
            this.btStartRegister.UseVisualStyleBackColor = true;
            this.btStartRegister.Click += new System.EventHandler(this.btStartRegister_Click);
            // 
            // btRegisterFaceOnly
            // 
            this.btRegisterFaceOnly.Enabled = false;
            this.btRegisterFaceOnly.Location = new System.Drawing.Point(472, 347);
            this.btRegisterFaceOnly.Name = "btRegisterFaceOnly";
            this.btRegisterFaceOnly.Size = new System.Drawing.Size(137, 45);
            this.btRegisterFaceOnly.TabIndex = 3;
            this.btRegisterFaceOnly.Text = "Register Face Only";
            this.btRegisterFaceOnly.UseVisualStyleBackColor = true;
            this.btRegisterFaceOnly.Click += new System.EventHandler(this.btRegisterFaceOnly_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(229, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(505, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Face image must be loaded BEFORE starting registration";
            // 
            // btLoadImageRegisterFace
            // 
            this.btLoadImageRegisterFace.Location = new System.Drawing.Point(39, 239);
            this.btLoadImageRegisterFace.Name = "btLoadImageRegisterFace";
            this.btLoadImageRegisterFace.Size = new System.Drawing.Size(185, 55);
            this.btLoadImageRegisterFace.TabIndex = 1;
            this.btLoadImageRegisterFace.Text = "Load Image";
            this.btLoadImageRegisterFace.UseVisualStyleBackColor = true;
            this.btLoadImageRegisterFace.Click += new System.EventHandler(this.btLoadImageRegisterFace_Click);
            // 
            // pbRegisterFace
            // 
            this.pbRegisterFace.Location = new System.Drawing.Point(16, 43);
            this.pbRegisterFace.Name = "pbRegisterFace";
            this.pbRegisterFace.Size = new System.Drawing.Size(240, 181);
            this.pbRegisterFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRegisterFace.TabIndex = 0;
            this.pbRegisterFace.TabStop = false;
            // 
            // tabSearchFingerprint
            // 
            this.tabSearchFingerprint.Controls.Add(this.pbSearchFingerprint);
            this.tabSearchFingerprint.Controls.Add(this.btCancelSearchFingerprint);
            this.tabSearchFingerprint.Controls.Add(this.btSearchFingerprint);
            this.tabSearchFingerprint.Location = new System.Drawing.Point(4, 25);
            this.tabSearchFingerprint.Name = "tabSearchFingerprint";
            this.tabSearchFingerprint.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearchFingerprint.Size = new System.Drawing.Size(974, 411);
            this.tabSearchFingerprint.TabIndex = 1;
            this.tabSearchFingerprint.Text = "Search Fingerprint";
            this.tabSearchFingerprint.UseVisualStyleBackColor = true;
            // 
            // pbSearchFingerprint
            // 
            this.pbSearchFingerprint.Location = new System.Drawing.Point(44, 42);
            this.pbSearchFingerprint.Name = "pbSearchFingerprint";
            this.pbSearchFingerprint.Size = new System.Drawing.Size(169, 190);
            this.pbSearchFingerprint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearchFingerprint.TabIndex = 7;
            this.pbSearchFingerprint.TabStop = false;
            // 
            // btCancelSearchFingerprint
            // 
            this.btCancelSearchFingerprint.Location = new System.Drawing.Point(368, 273);
            this.btCancelSearchFingerprint.Name = "btCancelSearchFingerprint";
            this.btCancelSearchFingerprint.Size = new System.Drawing.Size(239, 51);
            this.btCancelSearchFingerprint.TabIndex = 6;
            this.btCancelSearchFingerprint.Text = "Cancel Search";
            this.btCancelSearchFingerprint.UseVisualStyleBackColor = true;
            this.btCancelSearchFingerprint.Click += new System.EventHandler(this.btCancelSearchFingerprint_Click);
            // 
            // btSearchFingerprint
            // 
            this.btSearchFingerprint.Location = new System.Drawing.Point(368, 136);
            this.btSearchFingerprint.Name = "btSearchFingerprint";
            this.btSearchFingerprint.Size = new System.Drawing.Size(239, 51);
            this.btSearchFingerprint.TabIndex = 5;
            this.btSearchFingerprint.Text = "Search Fingerprint";
            this.btSearchFingerprint.UseVisualStyleBackColor = true;
            this.btSearchFingerprint.Click += new System.EventHandler(this.btSearchFingerprint_Click);
            // 
            // tabSearchFace
            // 
            this.tabSearchFace.Controls.Add(this.btSearchFace);
            this.tabSearchFace.Controls.Add(this.pbSearchFace);
            this.tabSearchFace.Controls.Add(this.btLoadImageSearchFace);
            this.tabSearchFace.Location = new System.Drawing.Point(4, 25);
            this.tabSearchFace.Name = "tabSearchFace";
            this.tabSearchFace.Size = new System.Drawing.Size(974, 411);
            this.tabSearchFace.TabIndex = 2;
            this.tabSearchFace.Text = "Search Face";
            this.tabSearchFace.UseVisualStyleBackColor = true;
            // 
            // btSearchFace
            // 
            this.btSearchFace.Location = new System.Drawing.Point(762, 350);
            this.btSearchFace.Name = "btSearchFace";
            this.btSearchFace.Size = new System.Drawing.Size(199, 46);
            this.btSearchFace.TabIndex = 2;
            this.btSearchFace.Text = "Search Face";
            this.btSearchFace.UseVisualStyleBackColor = true;
            this.btSearchFace.Click += new System.EventHandler(this.btSearchFace_Click);
            // 
            // pbSearchFace
            // 
            this.pbSearchFace.Location = new System.Drawing.Point(259, 33);
            this.pbSearchFace.Name = "pbSearchFace";
            this.pbSearchFace.Size = new System.Drawing.Size(396, 223);
            this.pbSearchFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearchFace.TabIndex = 1;
            this.pbSearchFace.TabStop = false;
            // 
            // btLoadImageSearchFace
            // 
            this.btLoadImageSearchFace.Location = new System.Drawing.Point(328, 276);
            this.btLoadImageSearchFace.Name = "btLoadImageSearchFace";
            this.btLoadImageSearchFace.Size = new System.Drawing.Size(241, 38);
            this.btLoadImageSearchFace.TabIndex = 0;
            this.btLoadImageSearchFace.Text = "Load Image";
            this.btLoadImageSearchFace.UseVisualStyleBackColor = true;
            this.btLoadImageSearchFace.Click += new System.EventHandler(this.btLoadImageSearchFace_Click);
            // 
            // tabDelete
            // 
            this.tabDelete.Controls.Add(this.btDeletePerson);
            this.tabDelete.Location = new System.Drawing.Point(4, 25);
            this.tabDelete.Name = "tabDelete";
            this.tabDelete.Size = new System.Drawing.Size(974, 411);
            this.tabDelete.TabIndex = 3;
            this.tabDelete.Text = "Delete";
            this.tabDelete.UseVisualStyleBackColor = true;
            // 
            // btDeletePerson
            // 
            this.btDeletePerson.Location = new System.Drawing.Point(372, 249);
            this.btDeletePerson.Name = "btDeletePerson";
            this.btDeletePerson.Size = new System.Drawing.Size(239, 51);
            this.btDeletePerson.TabIndex = 4;
            this.btDeletePerson.Text = "DeletePerson";
            this.btDeletePerson.UseVisualStyleBackColor = true;
            this.btDeletePerson.Click += new System.EventHandler(this.btDeletePerson_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Account Id:";
            // 
            // tbAccountId
            // 
            this.tbAccountId.Location = new System.Drawing.Point(100, 12);
            this.tbAccountId.Name = "tbAccountId";
            this.tbAccountId.Size = new System.Drawing.Size(221, 22);
            this.tbAccountId.TabIndex = 7;
            // 
            // tbPersonId
            // 
            this.tbPersonId.Location = new System.Drawing.Point(450, 13);
            this.tbPersonId.Name = "tbPersonId";
            this.tbPersonId.Size = new System.Drawing.Size(221, 22);
            this.tbPersonId.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Person Id:";
            // 
            // lbLog
            // 
            this.lbLog.FormattingEnabled = true;
            this.lbLog.ItemHeight = 16;
            this.lbLog.Location = new System.Drawing.Point(12, 509);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(978, 196);
            this.lbLog.TabIndex = 10;
            // 
            // btCancelRegister
            // 
            this.btCancelRegister.Enabled = false;
            this.btCancelRegister.Location = new System.Drawing.Point(693, 361);
            this.btCancelRegister.Name = "btCancelRegister";
            this.btCancelRegister.Size = new System.Drawing.Size(93, 31);
            this.btCancelRegister.TabIndex = 19;
            this.btCancelRegister.Text = "Cancel";
            this.btCancelRegister.UseVisualStyleBackColor = true;
            this.btCancelRegister.Click += new System.EventHandler(this.btCancelRegister_Click);
            // 
            // btClearRegister
            // 
            this.btClearRegister.Location = new System.Drawing.Point(6, 6);
            this.btClearRegister.Name = "btClearRegister";
            this.btClearRegister.Size = new System.Drawing.Size(93, 31);
            this.btClearRegister.TabIndex = 20;
            this.btClearRegister.Text = "Clear";
            this.btClearRegister.UseVisualStyleBackColor = true;
            this.btClearRegister.Click += new System.EventHandler(this.btClearRegister_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.tbPersonId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAccountId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "SimpleID C#.NET Sample";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabRegister.ResumeLayout(false);
            this.tabRegister.PerformLayout();
            this.gbFingers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRegisterFingerprint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRegisterFace)).EndInit();
            this.tabSearchFingerprint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchFingerprint)).EndInit();
            this.tabSearchFace.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchFace)).EndInit();
            this.tabDelete.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRegister;
        private System.Windows.Forms.TabPage tabSearchFingerprint;
        private System.Windows.Forms.TabPage tabSearchFace;
        private System.Windows.Forms.TabPage tabDelete;
        private System.Windows.Forms.Button btDeletePerson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAccountId;
        private System.Windows.Forms.TextBox tbPersonId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCancelSearchFingerprint;
        private System.Windows.Forms.Button btSearchFingerprint;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.PictureBox pbSearchFace;
        private System.Windows.Forms.Button btLoadImageSearchFace;
        private System.Windows.Forms.Button btSearchFace;
        private System.Windows.Forms.Button btLoadImageRegisterFace;
        private System.Windows.Forms.PictureBox pbRegisterFace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btSubmitRegister;
        private System.Windows.Forms.Button btStartRegister;
        private System.Windows.Forms.Button btRegisterFaceOnly;
        private System.Windows.Forms.PictureBox pbRegisterFingerprint;
        private System.Windows.Forms.TextBox tbCustom3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCustom2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCustom1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbFingers;
        private System.Windows.Forms.Button btLeftLittle;
        private System.Windows.Forms.Button btLeftRing;
        private System.Windows.Forms.Button btLeftMiddle;
        private System.Windows.Forms.Button btLeftIndex;
        private System.Windows.Forms.Button btLeftThumb;
        private System.Windows.Forms.Button btRightLittle;
        private System.Windows.Forms.Button btRightRing;
        private System.Windows.Forms.Button btRightMiddle;
        private System.Windows.Forms.Button btRightIndex;
        private System.Windows.Forms.Button btRightThumb;
        private System.Windows.Forms.PictureBox pbSearchFingerprint;
        private System.Windows.Forms.Button btCancelRegister;
        private System.Windows.Forms.Button btClearRegister;
    }
}

