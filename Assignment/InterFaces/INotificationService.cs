using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.InterFaces
{
    public interface INotificationService
    {
       public  string recipient { get; set; }   
        public string message { get; set; }
        public string SendNotification(string recipient, string message);

    }
}
