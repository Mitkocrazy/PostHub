using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System;

namespace PostHub.Models
{
    public class User
    {


        public class ApplicationUser : Microsoft.AspNet.Identity.EntityFramework.IdentityUser
        {
            public string FullName { get; set; }

            public DateTime RegisteredOn { get; set; } = DateTime.Now;

            public virtual ICollection<Ad> Ads { get; set; }
            public virtual ICollection<Favorite> Favorites { get; set; }

            public virtual ICollection<Message> SentMessages { get; set; }
            public virtual ICollection<Message> ReceivedMessages { get; set; }
        }
    }
}
