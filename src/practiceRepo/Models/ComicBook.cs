using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace practiceRepo.Models
{
    public class ComicBook
    {
        public int Id { set; get; }
        public string SeriesTitle { set; get; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public string[] Artists { get; set; }
        public bool Favorite { set; get; }

        public string DisplayText
        {
            get
            {
                return SeriesTitle + " #" + IssueNumber; 
            }
        }
        // series-title-issuenumber.jpg
        public string CoverImageFileName
        {
            get
            {
                return SeriesTitle.Replace(" ", "-")
                    .ToLower() + "-" + IssueNumber + ".jpg";
            }
        }
    }
}