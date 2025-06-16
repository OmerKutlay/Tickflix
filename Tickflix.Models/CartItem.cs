using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickflix.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public virtual Cart Cart { get; set; }
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
        public int Quantity { get; set; }
    }
}
