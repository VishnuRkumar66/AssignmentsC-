namespace MultiCastDelegate
{
    //declare a delegate
    public delegate void RectangleDelegate(int length, int breadth);

    internal class Program
    {
        static void Main()
        {
            //2.initialize the delegate
            Program demoObj = new Program();
            RectangleDelegate rectDelegate = new RectangleDelegate(demoObj.GetArea);
            Console.WriteLine("Before Multicast:");
            rectDelegate(3, 3);
            rectDelegate += new RectangleDelegate(demoObj.GetPerimeter);

            //3.invoke the delegate
            Console.WriteLine("After Multicast:");
            rectDelegate(5, 10);

            Console.WriteLine("After removing Area:");
            rectDelegate -= demoObj.GetArea;
            rectDelegate(20, 10);
        }

        //find area and perimeter of rectangle using multicast delegate
        //get area --- 1
        public void GetArea(int length, int breadth)
        {
            Console.WriteLine("Area of rectangle: " + (length * breadth));
        }

        //get perimeter --- 2
        public void GetPerimeter(int length, int breadth)
        {
            Console.WriteLine("Perimeter of rectangle: " + 2 * (length + breadth));
        }
    }
}
