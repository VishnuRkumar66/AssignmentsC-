namespace AbstractionAndInterfaces
{
    public class Cat : Animals
    {
        public Cat(int v1, string v2) { }

        public override void SaySomething()
        {
            Console.WriteLine("Cats Say Meoow");
        }
    }
}
