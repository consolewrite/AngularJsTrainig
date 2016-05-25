using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoApp.Models
{
    public class MailItem
    {
        public int Id { get; set; }
        public string Sender { get; set; }
        public string Subject { get; set; }
        public DateTime Date { get; set; }
        public string [] Recipients { get; set; }
        public string Message { get; set; }
    }
}