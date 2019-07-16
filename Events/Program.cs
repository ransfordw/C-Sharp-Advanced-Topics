using System.Threading;

namespace Events
{
    class Program
    {
        // Events: Mechanism for communication between objects
        // Used in building loosely coupled applications
        // Helps with extending applications

        // Delegate: Agreement or Contract between a Publisher and Subscriber
        // Determines the signature of the event handler method in the subscriber

        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //subscriber
            var messageService = new MessageService(); //subscriber
            // subscribing
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; // no bracket or parens, indicating that this is a pointer to a method (i.e. a delegate)
            // videoEncoder = publisher
            // .VideoEncoded = desired event
            // +=  =  subscribing
            // messageService = subscriber
            // .OnVideoEncoded = pointer
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}
