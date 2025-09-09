namespace EventDemo
{
    //defining delegate,blueprint for event handlers
    public delegate string WelcomeDelegate(string userName);

    internal class Program
    {
        //2.initialize / declaring an Event using the delegate..
        //this is the publisher (the event lives here and will notify subscribers)
        event WelcomeDelegate WelcomeEvent;

        public Program()
        {
            // 3 attaching the method/function to the event
            //this is a subscriber(welcome method subscribes to the event)

            WelcomeEvent += new WelcomeDelegate(this.welcome);
        }

        static void Main()
        {
            //4.invoke event
            Program obj = new Program();
            string result = obj.WelcomeEvent("appu");
            Console.WriteLine(result);
            Console.ReadKey();
        }

        //simple function ----subscriber's method
        //this is the subcribers method
        //it will be executed when event is raised
        public string welcome(string userName)
        {
            return "welcome " + userName;
        }
    }
}
