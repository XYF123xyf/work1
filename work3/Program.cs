namespace work3
{
    using System;

    public delegate void GradePrintDelegate(string name, double score);

    public class Student
    {
        public GradePrintDelegate GradePrint { get; set; }
    }

    public class Transcript
    {
        public void PrintGrade(string name, double score)
        {
            Console.WriteLine($"姓名：{name}，成绩：{score}");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Transcript transcript = new Transcript();

            Student student = new Student();
            student.GradePrint = transcript.PrintGrade;

            student.GradePrint("张三", 90.5);
        }
    }

}