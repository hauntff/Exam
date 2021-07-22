using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Models
{
    public partial class Person
    {
        public int Artist_ID { get; set; }
        public string Last_Name { get; set; }
        public string First_Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Sex { get; set; }
        public virtual Album IdArtistNavigation { get; set; }
    }
}
