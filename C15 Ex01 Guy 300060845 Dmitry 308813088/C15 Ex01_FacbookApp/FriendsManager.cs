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

        public FriendsManager(List<User> i_Friends)
        {
            AllFriends = i_Friends;
        }

        public void SortFriendsByGender()
        {
            foreach (User friend in AllFriends)
            {
                sortFriendByGender(friend);
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
                    FemaleFriends.Add(i_friend);
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

        public float MalePercentage()
        {
            return GenderPercentage(UnknownGenderFriends.Count);
        }

        private float GenderPercentage(int i_GenderCount)
        {
            return (i_GenderCount / AllFriends.Count) * 100;
        }
    }
}
