﻿using System;

namespace UsefulPatterns.Bridge.Before
{
    public class EmployeeMessageOld : MessageOld
    {
        public override void Send(string subject, string body)
        {
            Console.WriteLine("Message Sent \n{0}\n{1}\n", subject, body);
        }
    }
}