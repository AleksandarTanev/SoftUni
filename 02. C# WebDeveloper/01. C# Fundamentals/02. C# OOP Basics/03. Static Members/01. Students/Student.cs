namespace _01.Students
{
    public class Student
    {
        public static int coutStudents = 0;

        public string name;

        public Student(string name)
        {
            this.name = name;
            coutStudents++;
        }
    }
}
