namespace C15_Ex01_FacebookApp
{
    partial class AppForm
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.linkFriends = new System.Windows.Forms.LinkLabel();
            this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.buttonFetchPages = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxFriendsPages = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxOtherCategory = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCalculateFriendsStatstics = new System.Windows.Forms.Button();
            this.labelMale = new System.Windows.Forms.Label();
            this.labelFemale = new System.Windows.Forms.Label();
            this.labelUnknownGender = new System.Windows.Forms.Label();
            this.listBoxMaleFriends = new System.Windows.Forms.ListBox();
            this.listBoxFemaleFriends = new System.Windows.Forms.ListBox();
            this.listBoxUnkownGender = new System.Windows.Forms.ListBox();
            this.labelMalePercentage = new System.Windows.Forms.Label();
            this.labelUnknownGenderPercentage = new System.Windows.Forms.Label();
            this.labelFemalePercentage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.AccessibleName = "";
            this.buttonLogin.Location = new System.Drawing.Point(187, 12);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(107, 30);
            this.buttonLogin.TabIndex = 0;
            this.buttonLogin.Text = "login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.AccessibleName = "Profile Picture";
            this.pictureBoxProfile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxProfile.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(149, 163);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 1;
            this.pictureBoxProfile.TabStop = false;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(187, 56);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(331, 119);
            this.textBoxStatus.TabIndex = 2;
            // 
            // linkFriends
            // 
            this.linkFriends.AutoSize = true;
            this.linkFriends.LinkArea = new System.Windows.Forms.LinkArea(0, 13);
            this.linkFriends.Location = new System.Drawing.Point(12, 198);
            this.linkFriends.Name = "linkFriends";
            this.linkFriends.Size = new System.Drawing.Size(185, 30);
            this.linkFriends.TabIndex = 50;
            this.linkFriends.TabStop = true;
            this.linkFriends.Text = "Fetch Friends \r\n(Click on a friend to view it\'s picture)";
            this.linkFriends.UseCompatibleTextRendering = true;
            this.linkFriends.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFriends_LinkClicked);
            // 
            // pictureBoxFriend
            // 
            this.pictureBoxFriend.Location = new System.Drawing.Point(127, 231);
            this.pictureBoxFriend.Name = "pictureBoxFriend";
            this.pictureBoxFriend.Size = new System.Drawing.Size(137, 173);
            this.pictureBoxFriend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFriend.TabIndex = 49;
            this.pictureBoxFriend.TabStop = false;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.Location = new System.Drawing.Point(12, 231);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(109, 173);
            this.listBoxFriends.TabIndex = 48;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // buttonLogout
            // 
            this.buttonLogout.AccessibleName = "";
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Location = new System.Drawing.Point(310, 12);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(107, 30);
            this.buttonLogout.TabIndex = 51;
            this.buttonLogout.Text = "logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.Enabled = false;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "All Categories",
            "Book",
            "Movie",
            "TV Show",
            "Song",
            "Music Video",
            "Sports Team",
            "Artist ",
            "Athlete",
            "Other"});
            this.comboBoxCategory.Location = new System.Drawing.Point(70, 467);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(117, 21);
            this.comboBoxCategory.TabIndex = 52;
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // buttonFetchPages
            // 
            this.buttonFetchPages.AccessibleName = "";
            this.buttonFetchPages.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonFetchPages.Enabled = false;
            this.buttonFetchPages.Location = new System.Drawing.Point(199, 493);
            this.buttonFetchPages.Name = "buttonFetchPages";
            this.buttonFetchPages.Size = new System.Drawing.Size(84, 21);
            this.buttonFetchPages.TabIndex = 53;
            this.buttonFetchPages.Text = "Fetch Pages";
            this.buttonFetchPages.UseVisualStyleBackColor = true;
            this.buttonFetchPages.Click += new System.EventHandler(this.buttonFetchPages_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(8, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "Search your friends favorite pages\r\n";
            // 
            // listBoxFriendsPages
            // 
            this.listBoxFriendsPages.DisplayMember = "Name";
            this.listBoxFriendsPages.FormattingEnabled = true;
            this.listBoxFriendsPages.Location = new System.Drawing.Point(18, 520);
            this.listBoxFriendsPages.Name = "listBoxFriendsPages";
            this.listBoxFriendsPages.Size = new System.Drawing.Size(342, 95);
            this.listBoxFriendsPages.TabIndex = 57;
            this.listBoxFriendsPages.SelectedIndexChanged += new System.EventHandler(this.listBoxFriendsPages_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Category";
            // 
            // textBoxOtherCategory
            // 
            this.textBoxOtherCategory.Enabled = false;
            this.textBoxOtherCategory.Location = new System.Drawing.Point(70, 494);
            this.textBoxOtherCategory.Name = "textBoxOtherCategory";
            this.textBoxOtherCategory.Size = new System.Drawing.Size(117, 20);
            this.textBoxOtherCategory.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(391, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 40);
            this.label4.TabIndex = 60;
            this.label4.Text = "Display friends gender distribution\r\n\r\n";
            // 
            // buttonCalculateFriendsStatstics
            // 
            this.buttonCalculateFriendsStatstics.Enabled = false;
            this.buttonCalculateFriendsStatstics.Location = new System.Drawing.Point(665, 381);
            this.buttonCalculateFriendsStatstics.Name = "buttonCalculateFriendsStatstics";
            this.buttonCalculateFriendsStatstics.Size = new System.Drawing.Size(75, 23);
            this.buttonCalculateFriendsStatstics.TabIndex = 0;
            this.buttonCalculateFriendsStatstics.Text = "Start";
            this.buttonCalculateFriendsStatstics.UseVisualStyleBackColor = true;
            this.buttonCalculateFriendsStatstics.Click += new System.EventHandler(this.buttonCalculateFriendsStatstics_Click);
            // 
            // labelMale
            // 
            this.labelMale.AutoSize = true;
            this.labelMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMale.Location = new System.Drawing.Point(393, 422);
            this.labelMale.Name = "labelMale";
            this.labelMale.Size = new System.Drawing.Size(46, 17);
            this.labelMale.TabIndex = 61;
            this.labelMale.Text = "Male: ";
            // 
            // labelFemale
            // 
            this.labelFemale.AutoSize = true;
            this.labelFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFemale.Location = new System.Drawing.Point(526, 422);
            this.labelFemale.Name = "labelFemale";
            this.labelFemale.Size = new System.Drawing.Size(62, 17);
            this.labelFemale.TabIndex = 62;
            this.labelFemale.Text = "Female: ";
            // 
            // labelUnknownGender
            // 
            this.labelUnknownGender.AutoSize = true;
            this.labelUnknownGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelUnknownGender.Location = new System.Drawing.Point(662, 422);
            this.labelUnknownGender.Name = "labelUnknownGender";
            this.labelUnknownGender.Size = new System.Drawing.Size(74, 17);
            this.labelUnknownGender.TabIndex = 63;
            this.labelUnknownGender.Text = "Unknown: ";
            // 
            // listBoxMaleFriends
            // 
            this.listBoxMaleFriends.FormattingEnabled = true;
            this.listBoxMaleFriends.Location = new System.Drawing.Point(395, 442);
            this.listBoxMaleFriends.Name = "listBoxMaleFriends";
            this.listBoxMaleFriends.Size = new System.Drawing.Size(109, 173);
            this.listBoxMaleFriends.TabIndex = 64;
            // 
            // listBoxFemaleFriends
            // 
            this.listBoxFemaleFriends.FormattingEnabled = true;
            this.listBoxFemaleFriends.Location = new System.Drawing.Point(529, 442);
            this.listBoxFemaleFriends.Name = "listBoxFemaleFriends";
            this.listBoxFemaleFriends.Size = new System.Drawing.Size(109, 173);
            this.listBoxFemaleFriends.TabIndex = 65;
            // 
            // listBoxUnkownGender
            // 
            this.listBoxUnkownGender.FormattingEnabled = true;
            this.listBoxUnkownGender.Location = new System.Drawing.Point(664, 442);
            this.listBoxUnkownGender.Name = "listBoxUnkownGender";
            this.listBoxUnkownGender.Size = new System.Drawing.Size(109, 173);
            this.listBoxUnkownGender.TabIndex = 66;
            // 
            // labelMalePercentage
            // 
            this.labelMalePercentage.AutoSize = true;
            this.labelMalePercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelMalePercentage.Location = new System.Drawing.Point(436, 422);
            this.labelMalePercentage.Name = "labelMalePercentage";
            this.labelMalePercentage.Size = new System.Drawing.Size(0, 17);
            this.labelMalePercentage.TabIndex = 67;
            // 
            // labelUnknownGenderPercentage
            // 
            this.labelUnknownGenderPercentage.AutoSize = true;
            this.labelUnknownGenderPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelUnknownGenderPercentage.Location = new System.Drawing.Point(731, 422);
            this.labelUnknownGenderPercentage.Name = "labelUnknownGenderPercentage";
            this.labelUnknownGenderPercentage.Size = new System.Drawing.Size(0, 17);
            this.labelUnknownGenderPercentage.TabIndex = 68;
            // 
            // labelFemalePercentage
            // 
            this.labelFemalePercentage.AutoSize = true;
            this.labelFemalePercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFemalePercentage.Location = new System.Drawing.Point(583, 422);
            this.labelFemalePercentage.Name = "labelFemalePercentage";
            this.labelFemalePercentage.Size = new System.Drawing.Size(0, 17);
            this.labelFemalePercentage.TabIndex = 69;
            // 
            // AppForm
            // 
            this.AccessibleName = "Facebook App";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 641);
            this.Controls.Add(this.labelFemalePercentage);
            this.Controls.Add(this.labelUnknownGenderPercentage);
            this.Controls.Add(this.labelMalePercentage);
            this.Controls.Add(this.listBoxUnkownGender);
            this.Controls.Add(this.listBoxFemaleFriends);
            this.Controls.Add(this.listBoxMaleFriends);
            this.Controls.Add(this.labelUnknownGender);
            this.Controls.Add(this.labelFemale);
            this.Controls.Add(this.labelMale);
            this.Controls.Add(this.buttonCalculateFriendsStatstics);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxOtherCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxFriendsPages);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonFetchPages);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.linkFriends);
            this.Controls.Add(this.pictureBoxFriend);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.buttonLogin);
            this.Name = "AppForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.LinkLabel linkFriends;
        private System.Windows.Forms.PictureBox pictureBoxFriend;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button buttonFetchPages;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxFriendsPages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxOtherCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCalculateFriendsStatstics;
        private System.Windows.Forms.Label labelMale;
        private System.Windows.Forms.Label labelFemale;
        private System.Windows.Forms.Label labelUnknownGender;
        private System.Windows.Forms.ListBox listBoxMaleFriends;
        private System.Windows.Forms.ListBox listBoxFemaleFriends;
        private System.Windows.Forms.ListBox listBoxUnkownGender;
        private System.Windows.Forms.Label labelMalePercentage;
        private System.Windows.Forms.Label labelUnknownGenderPercentage;
        private System.Windows.Forms.Label labelFemalePercentage;
    }
}

