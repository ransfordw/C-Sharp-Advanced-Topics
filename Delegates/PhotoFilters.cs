using System;

namespace Delegates
{
    public class PhotoFilters
    {
        public PhotoFilters()
        {
        }

        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine($"Apply brightness to {photo}");
        }

        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine($"Apply contrast to {photo}");
        }

        public void Resize(Photo photo)
        {
            Console.WriteLine($"Resize {photo}");
        }
    }
}