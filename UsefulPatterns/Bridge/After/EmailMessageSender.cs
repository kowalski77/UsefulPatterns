using System;

namespace UsefulPatterns.Bridge.After
{
    public class EmailMessageSender : IMessageSender
    {
        public void Send(string subject, string body)
        {
            Console.WriteLine("Message Sent by Email\n{0}\n{1}\n", subject, body);
        }
    }
}