namespace Section5
{
    public class Circle : Shape 
    {   //base is reference to the parent class
        public override void Draw()
        {
            System.Console.WriteLine("Draw Circle");
        }
    }
}
