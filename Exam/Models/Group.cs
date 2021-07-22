using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    public partial class Group
    {
        public int Artist_ID { get; set; }
        public string Group_Name { get; set; }
        public virtual Album IdArtistNavigation { get; set; }

    }
}
