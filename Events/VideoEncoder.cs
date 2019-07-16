using System;
using System.Threading;

namespace Events
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        // 1- Define a delegate (contract or agreement between the pub and sub)
        // 2- define an event based on delegate
        // 3- raise the event

        // Delegate holding a reference to a function the is void with two params (object, EventArgs)
        // Name should be <NameOfEvent> append Handler
        // public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        //Instead of createing a custom delegate...
        //public event VideoEncodedEventHandler VideoEncoded;

        public event EventHandler<VideoEventArgs> VideoEncoded; // == public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        public event EventHandler VideoEncoding; // same as above but with default EventArgs as second param

        // DotNet convention for EventPublisher methods should be
        // Protected
        // Virtual
        // Void
        // Named "On<NameOfEvent>"
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null) // Checks if there are any subscribers
                VideoEncoded(this, new VideoEventArgs() { Video = video }); // Delegate: this == this object(OnVideoEncoded), and EventArgs.Empty returns an empty instance of EventArgs

        }

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video); // Raise the event
        }

    }
}
