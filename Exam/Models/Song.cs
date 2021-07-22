using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    public partial class Song
    {
        public Song()
        {
            Albums_Songs = new HashSet<Album_song>();
        }
        public int Song_ID { get; set; }
        public string Song_Title { get; set; }
        public virtual ICollection<Album_song> Albums_Songs { get; set; }
    }
}
