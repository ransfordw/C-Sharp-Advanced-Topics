using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        // Delegate = Object that knows how to call a method or a group of methods
        // Help designing extensible and flexible applications
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            // PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;


            processor.Process("photo.jpg",filterHandler);

            Console.ReadKey();
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine($"Apply RemoveRedEye to {photo}");
        }
    }
}
