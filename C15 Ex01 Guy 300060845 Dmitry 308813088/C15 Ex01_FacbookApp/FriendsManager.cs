using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace C15_Ex01_FacebookApp
{
    public class FriendsManager
    {
        public List<User> AllFriends { get; private set; }
        public List<User> MaleFriends { get; private set; }
        public List<User> FemaleFriends { get; private set; }
        public List<User> UnknownGenderFriends { get; private set; }
        bool m_SortedGenders = false;

        public FriendsManager(List<User> i_Friends)
        {
            AllFriends = i_Friends;
            UnknownGenderFriends = new List<User>();
            MaleFriends = new List<User>();
            FemaleFriends = new List<User>();
        }

        public void SortFriendsByGender()
        {
            if (!m_SortedGenders)
            {
                foreach (User friend in AllFriends)
                {
                    sortFriendByGender(friend);
                }
                m_SortedGenders = true;
            }
        }

        private void sortFriendByGender(User i_friend)
        {
            switch (i_friend.Gender)
            {
                case User.eGender.female:
                    FemaleFriends.Add(i_friend);
                    break;
                case User.eGender.male:
                    MaleFriends.Add(i_friend);
                    break;
                default:
                    UnknownGenderFriends.Add(i_friend);
                    break;
            }
        }

        public float MalePercentage()
        {
            return GenderPercentage(MaleFriends.Count);
        }

        public float FemalePercentage()
        {
            return GenderPercentage(FemaleFriends.Count);
        }

        public float UnknownGenderPercentage()
        {
            return GenderPercentage(UnknownGenderFriends.Count);
        }

        private float GenderPercentage(int i_GenderCount)
        {
            return ((float)i_GenderCount / (float)AllFriends.Count) * 100;
        }

        public void GeneratePagesLikedByFriendsList(string i_Category, List<PageLikeFreq> io_LikedPages)
        {
            foreach (User friend in AllFriends)
            {
                foreach (Page page in friend.LikedPages)
                {
                    if (i_Category == "All Categories" || page.Category == i_Category)
                    {
                        PageLikeFreq pageToAdd = new PageLikeFreq(page, 1);
                        bool pageFound = false;

                        foreach (PageLikeFreq pageLikeFreq in io_LikedPages)
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
                            io_LikedPages.Add(pageToAdd);
                        }
                    }
                }
            }
        }

    }
}
