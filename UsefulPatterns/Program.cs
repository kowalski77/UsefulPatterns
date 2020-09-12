using System;
using UsefulPatterns.Bridge.After;
using UsefulPatterns.Bridge.Before;

namespace UsefulPatterns
{
    internal class Program
    {
        private static void Main()
        {
            const string subject = "subject test";
            const string body = "body test";

            // Before Bridge
            var emailCustomerMessage = new EmailCustomerMessageOld();
            emailCustomerMessage.Send(subject, body);

            var xmppCustomerMessage = new XmppCustomerMessageOld();
            xmppCustomerMessage.Send(subject, body);

            var emailEmployeeMessage = new EmailEmployeeMessageOld();
            emailEmployeeMessage.Send(subject, body);

            var xmppEmployeeMessage = new XmppEmployeeMessageOld();
            xmppEmployeeMessage.Send(subject, body);

            // After Bridge
            var customerMessage1 = new CustomerMessage(new EmailMessageSender());
            customerMessage1.Send(subject, body);

            var customerMessage2 = new CustomerMessage(new XmppMessageSender());
            customerMessage2.Send(subject, body);

            var employeeMessage1 = new EmployeeMessage(new EmailMessageSender());
            employeeMessage1.Send(subject, body);

            var employeeMessage2 = new EmployeeMessage(new XmppMessageSender());
            employeeMessage2.Send(subject, body);

            Console.ReadKey();
        }
    }
}