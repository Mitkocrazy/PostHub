using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PostHub.Models.User;

namespace PostHub.Models
{
    public class Favorite
    {
       
            public int Id { get; set; }

            public string UserId { get; set; }
            public virtual ApplicationUser User { get; set; }

            public int AdId { get; set; }
            public virtual Ad Ad { get; set; }
        }
    }

