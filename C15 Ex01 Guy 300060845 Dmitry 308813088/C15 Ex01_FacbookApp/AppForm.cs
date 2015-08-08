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
using System.Diagnostics;

namespace C15_Ex01_FacebookApp
{
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 1000;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoginResult result = FacebookService.Connect("CAAByZBRy53lEBAGGlCt8uIfJrqamZAEVSqzyxGfsnZAZBwltDYsufZATqK8WeGJqYcLiG8v8yUAmc7JSCJRJ296VCPGj3ZCSBrAGmSZBpGM3SxBZCZAFYywVw4uwwX2Lajecsp2SwRNBD9LXZAvYuZBEvwWYEmB0sjhxhhwoDmPQztZAkbHPDxDNt9rMGyfeE1qlyBT12qtczFB3rm4QdAmAHIR2");
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

        User m_LoggedInUser;

        private void loginAndInit()
        {
            LoginResult result = FacebookService.Login("126414254366289", /// (dima & guy "DP.3­0­0­0­6­0­8­4­5­.­3­0­8­8­1­3088" app)
                "user_about_me", "user_friends", "publish_actions", "user_events", "user_posts", "user_photos",
                "user_status", "user_likes");
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
                comboBoxCategory.Enabled = true;
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
            comboBoxCategory.Enabled = false;
            listBoxFriendsPages.Items.Clear();
            textBoxOtherCategory.Text = string.Empty;
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

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = comboBoxCategory.Items[comboBoxCategory.SelectedIndex].ToString();

            textBoxOtherCategory.Enabled = selectedCategory == "Other" ? true : false;

            buttonFetchPages.Enabled = true;
        }

        private void buttonFetchPages_Click(object sender, EventArgs e)
        {
            listBoxFriendsPages.Items.Clear();
            fetchMostLikedPages();
        }

        private void fetchMostLikedPages()
        {
            List<PageLikeFreq> likedPages = new List<PageLikeFreq>();
            string selectedCategory = comboBoxCategory.Items[comboBoxCategory.SelectedIndex].ToString();
            
            if (selectedCategory == "Other") 
            {
                selectedCategory = textBoxOtherCategory.Text;
            }

            generatePagesLikedByFriendsList(selectedCategory, likedPages);
            likedPages.Sort();
            likedPages.Reverse();
            listBoxFriendsPages.Items.AddRange(likedPages.ToArray());
        }

        private void generatePagesLikedByFriendsList(string i_Category, List<PageLikeFreq> o_LikedPages)
        {
            foreach (User friend in m_LoggedInUser.Friends)
            {
                foreach (Page page in friend.LikedPages)
                {
                    if (i_Category == "All Categories" || page.Category == i_Category)
                    {
                        PageLikeFreq pageToAdd = new PageLikeFreq(page, 1);
                        bool pageFound = false;

                        foreach (PageLikeFreq pageLikeFreq in o_LikedPages)
                        {
                            if (pageLikeFreq.Equals(pageToAdd))
                            {
                                pageFound = true;
                                pageLikeFreq.LikeCount++;
                                break;
                            }
                        }

                        if (!pageFound)
                        {
                            o_LikedPages.Add(pageToAdd);
                        }
                    }
                }
            }
        }

        private void listBoxFriendsPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            PageLikeFreq selectedPage = listBoxFriendsPages.Items[listBoxFriendsPages.SelectedIndex] as PageLikeFreq;
            Process.Start(selectedPage.Page.URL);
        }

        private void buttonCalculateFriendsStatstics_Click(object sender, EventArgs e)
        {
            generateFriendsStatistics();
        }

        private void generateFriendsStatistics()
        {
            
        }
    }
}
