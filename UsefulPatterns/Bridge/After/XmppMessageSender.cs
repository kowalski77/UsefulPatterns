using System;

namespace UsefulPatterns.Bridge.After
{
    public class XmppMessageSender : IMessageSender
    {
        public void Send(string subject, string body)
        {
            Console.WriteLine("Message Sent by XMPP\n{0}\n{1}\n", subject, body);
        }
    }
}