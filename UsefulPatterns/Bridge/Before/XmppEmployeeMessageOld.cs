using System;

namespace UsefulPatterns.Bridge.Before
{
    public class XmppEmployeeMessageOld : EmployeeMessageOld
    {
        public override void Send(string subject, string body)
        {
            Console.WriteLine("Employee - Message Sent by Xmpp \n{0}\n{1}\n", subject, body);
        }
    }
}