using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PostHub.Models.User;
using System;
namespace PostHub.Models
{
    public class Message
    {
        


    
        public int Id { get; set; }

        public string Content { get; set; }

        public DateTime SentOn { get; set; } = DateTime.Now;

        public string SenderId { get; set; }
        public virtual ApplicationUser Sender { get; set; }

        public string ReceiverId { get; set; }
        public virtual ApplicationUser Receiver { get; set; }
    }
}

