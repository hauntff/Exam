using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    public partial class Album
    {
        public Album()
        {
            Albums_Songs = new HashSet<Album_song>();
        }
        public int Album_ID { get; set; }
        public int Artist_ID { get; set; }
        public string Album_Title { get; set; }
        public DateTime Album_Year { get; set; }
        public string Tracks { get; set; }
        public virtual ICollection<Album_song> Albums_Songs { get; set; }
        public virtual Artist IdArtistNavigation { get; set; }


    }
}
