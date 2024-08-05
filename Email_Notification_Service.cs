using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification
{
    public class EmailNotificationService : INotificationService
    {
        public void Send(NotificationMessage notification)
        {
            Console.WriteLine("Sending Email : " + notification.Message);
        }
    }
}
