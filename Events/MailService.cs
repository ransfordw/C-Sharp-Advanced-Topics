﻿using System;

namespace Events
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e) // subscription method
        {
            Console.WriteLine("MailService: Sending an email..." + e.Video.Title);
        }
    }
}
