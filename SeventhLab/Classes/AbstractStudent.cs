namespace SeventhLab.Classes
{
    public abstract class AbstractStudent
    {
        public int Id { get; set; }
        public int Course { get; set; }
        public double AverageMark { get; set; }

        protected AbstractStudent()
        {
            Id = 1;
            Course = 1;
            AverageMark = 1;
        }

        protected AbstractStudent(int id)
        {
            Id = id;
            Course = 1;
            AverageMark = 1;
        }

        protected AbstractStudent(int id, int course, double averageMark)
        {
            Id = id;
            Course = course;
            AverageMark = averageMark;
        }
    }
}