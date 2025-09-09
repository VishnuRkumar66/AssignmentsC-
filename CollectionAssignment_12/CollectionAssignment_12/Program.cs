namespace CollectionAssignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a queue to hold patient names
            Queue<string> waitingList = new Queue<string>();

            // Adding patients to the waiting list
            waitingList.Enqueue("vishnu");
            waitingList.Enqueue("amal");
            waitingList.Enqueue("ancy");
            waitingList.Enqueue("albin");

            // Display welcome message
            Console.WriteLine("Hospital Waiting List System\n");

            // Show all patients in waiting list
            Console.WriteLine("Patients currently waiting:");

            foreach (var patient in waitingList)
            {
                Console.WriteLine(patient);
            }

            Console.WriteLine("\nCalling patients to doctor’s room:\n");

            // Send patients one by one to the doctor
            while (waitingList.Count > 0)
            {
                string nextPatient = waitingList.Dequeue(); // get the next patient
                Console.WriteLine($"{nextPatient} goes in to see the doctor.");
            }

            Console.WriteLine("\nNo more patients in the waiting list.");
        }
    }
}
