using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    public partial class Genre
    {
        public Genre()
        {
            Artists = new HashSet<Artist>();
        }
        public int Genre_ID { get; set; }
        public string Genre_Name { get; set; }
        public virtual Genre IdGenreNavigation { get; set; }
        public virtual ICollection<Artist> Artists { get; set; }

    }
}
