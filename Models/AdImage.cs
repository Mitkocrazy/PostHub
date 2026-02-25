using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PostHub.Models
{
    public class AdImage
    {
      


    
        public int Id { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public int AdId { get; set; }
        public virtual Ad Ad { get; set; }
    }
}

