using System;

namespace UsefulPatterns.Bridge.Before
{
    public class XmppCustomerMessageOld : CustomerMessageOld
    {
        public override void Send(string subject, string body)
        {
            Console.WriteLine("Customer - Message Sent by XMPP \n{0}\n{1}\n", subject, body);
        }
    }
}