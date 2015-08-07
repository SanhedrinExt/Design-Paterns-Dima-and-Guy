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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxFriendsPages = new System.Windows.Forms.ListBox();
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
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(301, 257);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(153, 21);
            this.comboBoxCategory.TabIndex = 52;
            this.comboBoxCategory.Text = "Category";
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // buttonFetchPages
            // 
            this.buttonFetchPages.AccessibleName = "";
            this.buttonFetchPages.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonFetchPages.Enabled = false;
            this.buttonFetchPages.Location = new System.Drawing.Point(460, 257);
            this.buttonFetchPages.Name = "buttonFetchPages";
            this.buttonFetchPages.Size = new System.Drawing.Size(107, 30);
            this.buttonFetchPages.TabIndex = 53;
            this.buttonFetchPages.Text = "Fetch Pages";
            this.buttonFetchPages.UseVisualStyleBackColor = true;
            this.buttonFetchPages.Click += new System.EventHandler(this.buttonFetchPages_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(298, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "Search your friends favorite pages\r\n";
            // 
            // listBoxFriendsPages
            // 
            this.listBoxFriendsPages.FormattingEnabled = true;
            this.listBoxFriendsPages.Location = new System.Drawing.Point(302, 299);
            this.listBoxFriendsPages.Name = "listBoxFriendsPages";
            this.listBoxFriendsPages.Size = new System.Drawing.Size(265, 95);
            this.listBoxFriendsPages.TabIndex = 57;
            this.listBoxFriendsPages.SelectedIndexChanged += new System.EventHandler(this.listBoxFriendsPages_SelectedIndexChanged);
            // 
            // AppForm
            // 
            this.AccessibleName = "Facebook App";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 641);
            this.Controls.Add(this.listBoxFriendsPages);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxFriendsPages;
    }
}

