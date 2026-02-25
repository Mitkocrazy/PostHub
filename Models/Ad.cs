using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PostHub.Models.User;
using System;
using System.Collections.Generic;



namespace PostHub.Models
{
    public class Ad
    {
       
        
            public int Id { get; set; }

            [Required]
            [MaxLength(150)]
            public string Title { get; set; }

            [Required]
            public string Description { get; set; }

            [Required]
            public decimal Price { get; set; }

            public string Location { get; set; }

            public DateTime CreatedOn { get; set; } = DateTime.Now;

            public bool IsActive { get; set; } = true;

            // User
            public string UserId { get; set; }
            public virtual ApplicationUser User { get; set; }

            // Category
            public int CategoryId { get; set; }
            public virtual Category Category { get; set; }

            public virtual ICollection<AdImage> Images { get; set; }

            public virtual ICollection<Favorite> FavoritedBy { get; set; }
        }
    }

