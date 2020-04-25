namespace SeventhLab.Classes
{
    public class UniversityStudent : AbstractStudent
    {
        public UniversityStudent() : base()
        {
            University = "Пензенский Государственный Университет";
            IsFullTime = true;
            Faculty = "Вычислительной техники";
            Department = "Математическое обеспечение и применение ЭВМ";
        }

        public UniversityStudent(int id) : base(id)
        {
            University = "Пензенский Государственный Университет";
            IsFullTime = true;
            Faculty = "Вычислительной техники";
            Department = "Математическое обеспечение и применение ЭВМ";
        }

        public UniversityStudent(string university, string faculty, string department, bool isFullTime, int course,
            double averageMark, int id) : base(id, course, averageMark)
        {
            University = university;
            Faculty = faculty;
            Department = department;
            IsFullTime = isFullTime;
        }

        public string University { get; set; }
        public string Faculty { get; set; }
        public string Department { get; set; }
        public bool IsFullTime { get; set; }
        
        public override string ToString()
        {
            return
                $"ID: {Id} " +
                $"Университет: {University} " +
                $"Факультет: {Faculty} " +
                $"Кафедра: {Department} " +
                $"Форма обучения: {(IsFullTime ? "Очная" : "Заочная")} " +
                $"Курс: {Course} " +
                $"Средний балл: {AverageMark} " +
                $"Номер зачётки: {Id}";
        }
    }
}