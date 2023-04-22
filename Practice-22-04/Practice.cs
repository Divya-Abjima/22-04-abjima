
namespace Practice_22_04
{
    public static class Practice
    {
        //enum 
        static void Main(string[] args)
        {
            StudentInfo studentInfo= new StudentInfo();
            Student student= new Student();
            student.RollNo = 101;
            student.Name = "John";
            student.Grade = "XII";
            student.Address = "Denver, Colorado";
            student.Phone = 1567382921;
            Console.WriteLine(student.RollNo);
            Console.WriteLine(studentInfo);
            string name = "Divya";
            ChildClass2.printName(name);
            ChildClass.greeting(name);
            PwdInfo.pwdInfo();
        }
    }
    public struct Student
    {
        public int RollNo;
        public string Name;
        public string Grade;
        public long Phone;
        public string Address;
    }
    public enum StudentInfo
    {
        Name,
        Grade,
        Address,
        Phone
    }
}