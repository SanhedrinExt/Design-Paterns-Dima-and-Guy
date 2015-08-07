using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace C15_Ex01_FacebookApp
{
    public class PageLikeFreq : IComparable
    {
        public PageLikeFreq(Page i_Page, int i_LikeCount)
        {
            Page = i_Page;
            LikeCount = i_LikeCount;
        }
        public Page Page { get; set; }
        public int LikeCount { get; set; }

        public override string ToString()
        {
            return string.Format("{0}  Likes: {1}", Page.Name, LikeCount);
        }

        public int CompareTo(object obj)
        {
            return this.LikeCount.CompareTo((obj as PageLikeFreq).LikeCount);
        }

        public override bool Equals(object obj)
        {
            PageLikeFreq toCompare = obj as PageLikeFreq;

            return toCompare != null && toCompare.Page.Id == this.Page.Id;
        }
    }
}
