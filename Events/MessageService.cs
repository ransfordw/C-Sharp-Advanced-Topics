using System;
using System.Threading;

namespace Events
{
    public class MessageService
    {
        public virtual void OnVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("Message Service: Sending a text message..." + args.Video.Title);
            Thread.Sleep(2000);
        }
    }
}
