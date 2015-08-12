using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace C15_Ex01_FacebookApp
{
    public partial class AppForm : Form
    {
        private const string k_AppID = "126414254366289"; // (dima & guy "DP.3­0­0­0­6­0­8­4­5­.­3­0­8­8­1­3088" app)
        private const string k_OtherCategory = "Other";

        private User m_LoggedInUser;

        private FriendsManager m_FriendsManager;

        public AppForm()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 1000;
        }

        private void loginAndInit()
        {
            LoginResult result = FacebookService.Login(
                k_AppID,
                "user_about_me",
                "user_friends",
                "publish_actions",
                "user_posts",
                "user_photos",
                "user_status",
                "user_likes");

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                loginSequence(result);
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }

        private void loginSequence(LoginResult i_result)
        {
            m_LoggedInUser = i_result.LoggedInUser;
            fetchUserInfo();
            m_FriendsManager = new FriendsManager(m_LoggedInUser.Friends.ToList<User>());
            buttonLogin.Enabled = false;
            buttonLogout.Enabled = true;
            buttonCalculateFriendsStatstics.Enabled = true;
            buttonPost.Enabled = true;
            comboBoxCategory.Enabled = true;
        }

        private void logoutSequence()
        {
            m_LoggedInUser = null;
            pictureBoxProfile.Image = null;
            pictureBoxFriend.Image = null;
            textBoxStatus.Text = string.Empty;
            textBoxOtherCategory.Text = string.Empty;
            listBoxFriends.Items.Clear();
            listBoxPosts.Items.Clear();
            listBoxFriendsPages.Items.Clear();
            listBoxMaleFriends.Items.Clear();
            listBoxFemaleFriends.Items.Clear();
            listBoxUnkownGender.Items.Clear();
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
            buttonFetchPages.Enabled = false;
            buttonCalculateFriendsStatstics.Enabled = false;
            buttonPost.Enabled = false;
            comboBoxCategory.Enabled = false;
            labelMalePercentage.Text = string.Empty;
            labelFemalePercentage.Text = string.Empty;
            labelUnknownGenderPercentage.Text = string.Empty;
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
            fetchNewsFeed();
        }

        private void fetchNewsFeed()
        {
            foreach (Post post in m_LoggedInUser.NewsFeed)
            {
                if (post.Message != null && post.From != null)
                {
                    listBoxPosts.Items.Add(post.Message);
                    listBoxPosts.Items.Add(post.From.Name);
                    listBoxPosts.Items.Add(post.CreatedTime.Value.Date);
                    listBoxPosts.Items.Add(string.Empty);
                }
            }
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            postStatus();   
        }

        private void postStatus()
        {
            if (textBoxStatus.Text != string.Empty)
            {
                Status postedStatus = m_LoggedInUser.PostStatus(textBoxStatus.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
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

            textBoxOtherCategory.Enabled = selectedCategory == k_OtherCategory ? true : false;
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

            if (selectedCategory == k_OtherCategory)
            {
                selectedCategory = textBoxOtherCategory.Text;
            }

            m_FriendsManager.GeneratePagesLikedByFriendsList(selectedCategory, likedPages);
            likedPages.Sort();
            likedPages.Reverse();
            listBoxFriendsPages.Items.AddRange(likedPages.ToArray());
        }

        private void listBoxFriendsPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            PageLikeFreq selectedPage = listBoxFriendsPages.Items[listBoxFriendsPages.SelectedIndex] as PageLikeFreq;
            
            Process.Start(selectedPage.Page.URL);
        }

        private void buttonCalculateFriendsStatstics_Click(object sender, EventArgs e)
        {
            calculateFriendsStatistics();
        }

        private void calculateFriendsStatistics()
        {
            const string oneDecimalDigitDormat = "0.0";

            m_FriendsManager.SortFriendsByGender();
            labelMalePercentage.Text = string.Empty;
            labelFemalePercentage.Text = string.Empty;
            labelUnknownGenderPercentage.Text = string.Empty;
            labelMalePercentage.Text = string.Format("{0}%", m_FriendsManager.MalePercentage().ToString(oneDecimalDigitDormat));
            labelFemalePercentage.Text = string.Format("{0}%", m_FriendsManager.FemalePercentage().ToString(oneDecimalDigitDormat));
            labelUnknownGenderPercentage.Text = string.Format("{0}%", m_FriendsManager.UnknownGenderPercentage().ToString(oneDecimalDigitDormat));
            listBoxMaleFriends.Items.Clear();
            listBoxFemaleFriends.Items.Clear();
            listBoxUnkownGender.Items.Clear();
            listBoxMaleFriends.Items.AddRange(m_FriendsManager.MaleFriends.ToArray());
            listBoxFemaleFriends.Items.AddRange(m_FriendsManager.FemaleFriends.ToArray());
            listBoxUnkownGender.Items.AddRange(m_FriendsManager.UnknownGenderFriends.ToArray());
        }
    }
}