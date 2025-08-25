using System;

namespace Class_ObjectThree
{
    public class MovieTicket
    {
        // Fields
        private string movieName;
        private int totalSeats;
        private int bookedSeats;

        // Constructor
        public MovieTicket(string movieName, int totalSeats)
        {
            this.movieName = movieName;
            this.totalSeats = totalSeats;
            this.bookedSeats = 0; // initially no seats booked
        }

        // Method to book seats
        public void BookSeats(int seats)
        {
            if (seats > 0 && bookedSeats + seats <= totalSeats)
            {
                bookedSeats += seats;
                Console.WriteLine(
                    $"{seats} seats booked successfully. Total booked: {bookedSeats}"
                );
            }
            else if (seats <= 0)
            {
                Console.WriteLine("Number of seats must be greater than 0.");
            }
            else
            {
                Console.WriteLine(
                    $"Not enough seats available! Only {totalSeats - bookedSeats} left."
                );
            }
        }

        // Method to cancel seats
        public void CancelSeats(int seats)
        {
            if (seats > 0 && seats <= bookedSeats)
            {
                bookedSeats -= seats;
                Console.WriteLine(
                    $"{seats} seats cancelled successfully. Remaining booked: {bookedSeats}"
                );
            }
            else if (seats <= 0)
            {
                Console.WriteLine("Number of seats must be greater than 0.");
            }
            else
            {
                Console.WriteLine("You cannot cancel more seats than currently booked.");
            }
        }

        // Override ToString to show booking status
        public override string ToString()
        {
            return $"Movie: {movieName}, Total Seats: {totalSeats}, "
                + $"Booked Seats: {bookedSeats}, Available Seats: {totalSeats - bookedSeats}";
        }
    }
}
