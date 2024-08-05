using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification
{
    public class NotificationSender
    {
        private INotificationService _notificationService;
        public NotificationSender(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }
        public void Send(NotificationMessage notification)
        {
            _notificationService.Send(notification);
        }
    }
}

