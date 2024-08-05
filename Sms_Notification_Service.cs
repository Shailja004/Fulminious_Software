using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification
{
    public class SmsNotificationService : INotificationService
    {
        public void Send(NotificationMessage notification)
        {
            Console.WriteLine("Sending SMS : " + notification.Message);
        }
    }
}
