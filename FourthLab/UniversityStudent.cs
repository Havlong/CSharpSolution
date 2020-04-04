namespace FourthLab
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
                $"Университет: {University}\n" +
                $"Факультет: {Faculty}\n" +
                $"Кафедра: {Department}\n" +
                $"Форма обучения: {(IsFullTime ? "Очная" : "Заочная")}\n" +
                $"Курс: {Course}\n" +
                $"Средний балл: {AverageMark}\n" +
                $"Номер зачётки: {Id}";
        }
    }
}