using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace C15_Ex01_FacbookApp
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 1000;
        }

        User m_LoggedInUser;

        private void loginAndInit()
        {
            //if (m_LoggedInUser != null)
            //{
            //    FacebookService.Logout(new Action(logoutSequence));
            //}

            LoginResult result = FacebookService.Login("126414254366289", /// (dima & guy "DP.3­0­0­0­6­0­8­4­5­.­3­0­8­8­1­3088" app)
                "user_about_me", "user_friends", "publish_actions", "user_events", "user_posts", "user_photos",
                "user_status");
            // These are NOT the complete list of permissions. Other permissions for example:
            // "user_birthday", "user_education_history", "user_hometown", "user_likes","user_location","user_relationships","user_relationship_details","user_religion_politics", "user_videos", "user_website", "user_work_history", "email","read_insights","rsvp_event","manage_pages"
            // The documentation regarding facebook login and permissions can be found here: 
            // v2.4: https://developers.facebook.com/docs/facebook-login/permissions/v2.4

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_LoggedInUser = result.LoggedInUser;
                fetchUserInfo();
                buttonLogin.Enabled = false;
                buttonLogout.Enabled = true;
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }

        }

        private void logoutSequence()
        {
            pictureBoxProfile.Image = null;
            textBoxStatus.Text = String.Empty;
            listBoxFriends.Items.Clear();
            pictureBoxFriend.Image = null;
            m_LoggedInUser = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.Logout(new Action(logoutSequence));
        }

        private void fetchUserInfo()
        {
            pictureBoxProfile.LoadAsync(m_LoggedInUser.PictureNormalURL);
            if (m_LoggedInUser.Statuses.Count > 0)
            {
                textBoxStatus.Text = m_LoggedInUser.Statuses[0].Message;
            }
        }

        private void linkFriends_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fetchFriends();
        }

        private void fetchFriends()
        {
            if (m_LoggedInUser != null)
            {
                listBoxFriends.DisplayMember = "Name";
                foreach (User friend in m_LoggedInUser.Friends)
                {
                    listBoxFriends.Items.Add(friend);
                }

                if (m_LoggedInUser.Friends.Count == 0)
                {
                    MessageBox.Show("No Friends to retrieve :(");
                }
            }
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedFriend();
        }

        private void displaySelectedFriend()
        {
            if (listBoxFriends.SelectedItems.Count == 1)
            {
                User selectedFriend = listBoxFriends.SelectedItem as User;
                if (selectedFriend.PictureNormalURL != null)
                {
                    pictureBoxFriend.LoadAsync(selectedFriend.PictureNormalURL);
                }
                else
                {
                    pictureBoxFriend.Image = pictureBoxFriend.ErrorImage;
                }
            }
        }
    }
}
