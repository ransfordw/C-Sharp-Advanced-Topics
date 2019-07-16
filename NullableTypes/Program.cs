using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = new DateTime(2014, 1, 1); // == Nullable<DateTime> date = null
             // DateTime date2=  date; // error because nullable cant be set as non-nullable
            DateTime date2;//= date.GetValueOrDefault();

            if (date != null)
                date2 = date.GetValueOrDefault();
            else
                date2 = DateTime.Today;

            DateTime date3 = date ?? DateTime.Today; // null coalescing operator
            // Same as
            DateTime date4 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;

            //Console.WriteLine("GetValueOrDefault: " +date.GetValueOrDefault());
            //Console.WriteLine("HasValue: "+date.HasValue);
            //Console.WriteLine("Value: " + date.Value);
        }
    }
}
