using System.Collections.Generic;

namespace Section5
{   //Polymorphism
    //Many Forms
    public class Canvas
    {
        public void DrawShapes (List<Shape> shapes)
        {
            foreach(var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
