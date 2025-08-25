namespace Inheritance4thQuestion.Models
{
    public class Course
    {
        public string Title { get; set; }
        public int Duration { get; set; } // weeks/hours

        public Course(string title, int duration)
        {
            Title = title;
            Duration = duration;
        }

        public override string ToString()
        {
            return $"Course: {Title}, Duration: {Duration} weeks";
        }
    }
}
