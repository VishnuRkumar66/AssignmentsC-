namespace AbstractionAndInterfaces
{
    public class Dog : MyAnimals
    {
        private int v1;
        private string v2;

        public Dog(int v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public override void SaySomething()
        {
            Console.WriteLine("Dogs Say Bow Wow");
        }
    }
}
