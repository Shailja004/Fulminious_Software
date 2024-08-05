using Notification;
using System;
public class Program
{
    public static void Main()
    {
        NotificationMessage notification = new NotificationMessage{Message = "You are Shortlisted Candidate." };

        INotificationService emailService = new EmailNotificationService();
        NotificationSender emailSender = new NotificationSender(emailService);
        emailSender.Send(notification);

        INotificationService smsService = new SmsNotificationService();
        NotificationSender smsSender = new NotificationSender(smsService);
        smsSender.Send(notification);
    }
}

