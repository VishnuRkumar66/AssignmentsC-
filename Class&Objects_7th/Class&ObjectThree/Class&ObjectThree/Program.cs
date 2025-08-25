namespace Class_ObjectThree
{
    internal class Program
    {
        public static void Main()
        {
            // Create a movie ticket system
            MovieTicket movie1 = new MovieTicket("Avengers: Endgame", 100);

            Console.WriteLine(movie1);

            // Booking seats
            movie1.BookSeats(20);
            movie1.BookSeats(50);
            movie1.BookSeats(40); // should fail (not enough seats)

            // Cancelling seats
            movie1.CancelSeats(10);
            movie1.CancelSeats(30);
            movie1.CancelSeats(50); // should fail (cancel > booked)

            Console.WriteLine("\nFinal Status:");
            Console.WriteLine(movie1);
        }
    }
}
