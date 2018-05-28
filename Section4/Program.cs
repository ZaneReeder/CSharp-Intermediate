using System.Collections;
using System.Collections.Generic;
using System.IO;
using Amazon;

namespace Section4
{
    class Program
    {
        static void Main(string[] args)
        {
            //AccessModifiers
            var customer = new Customer();
            //RateCalc not acceptable due to internal  && 
            //different assembly
            //Amazon.RateCalculator calc = new RateCalculator();

            //Constructor Inheritance
            var car = new Car("XYZ123");


            //Upcasting and Downcasting
            //Text text = new Text();
            //Shape shape = text;
            //text and shape point to same object

            //text.
            //shape.

            //StreamReader reader = new StreamReader(new MemoryStream());

            //var list = new ArrayList();
            //list.Add(1);
            //list.Add("Zane");
            //list.Add(new Text());

            //var anotherList = new List<int>();

            Shape shape = new Text();
            Text text = (Text)shape;

            //private void Button_Click(object sender, RouteEventArgs e)
            //{
            //    var button = sender as Button;
            //    if (button != null)
            //    {
            //        MessageBox.Show(button.ActualHeight.ToString());
            //    }
            //}


            //Boxing and Unboxing

            var list = new ArrayList();
            //Add(object o). Thus value type 1 is boxed.
            list.Add(1);
            list.Add("Zane");

            //invalid cast exception
            var number = (int)list[1];

            var anotherList = new List<int>();

            //Add(int n). Thus type safety is implemented.
            //No Boxing
            anotherList.Add(10);


        }
    }
}
