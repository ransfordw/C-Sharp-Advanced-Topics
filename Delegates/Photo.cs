using System;

namespace Delegates
{
    public class Photo
    {
        public string FileName { get; private set; }

        public static Photo Load(string path)
        {
            return new Photo()
            {
                FileName = path
            };
        }

        public void Save()
        {
            Console.WriteLine($"{FileName} was saved.");
        }

        public override string ToString()
        {
            return FileName;
        }
    }
}