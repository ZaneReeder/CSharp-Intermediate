using System;

namespace Section3
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("onject Copied to Clipboard.");
        }

        public void Duplicate()
        {
            Console.WriteLine("Object Duplicated");
        }


    }
}
