namespace AbstractionAndInterfaces
{
    public class Numbers : IFirst, ISecond
    {
        public int value = 42;

        void IFirst.Display()
        {
            Console.WriteLine("Display from IFirst");
        }

        void ISecond.Display()
        {
            Console.WriteLine("Display from ISecond");
        }

        public int GetValue()
        {
            return value;
        }

        public void Demo()
        {
            Console.WriteLine("Demo from ISecond");
        }
    }
}
