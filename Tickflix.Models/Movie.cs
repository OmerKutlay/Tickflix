using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tickflix.Models.Data.Enums;

namespace Tickflix.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        public int CinemaId { get; set; }
        public virtual Cinema Cinema { get; set; }
        public int ProducerId { get; set; }
        public virtual Producer Producer { get; set; }
        public ICollection<Actor> Actors { get; set; } = new List<Actor>();
        
    }
}
