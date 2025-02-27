using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickflix.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string ProfilePictureURL { get; set; }
        public string Bio { get; set; }
    }
}
