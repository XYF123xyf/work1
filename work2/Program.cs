namespace work2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace test
    {
        class Program
        {
            class Student
            {
                private int id;
                private string name;
                private string clas;
                private int age;

                public Student(int id, string name, string clas, int age)
                {
                    this.id = id;
                    this.name = name;
                    this.clas = clas;
                    this.age = age;
                }
                public int Id
                {
                    get
                    {
                        return id;
                    }
                    set
                    {
                        id = value;
                    }
                }
                public string Name
                {
                    get
                    {
                        return name;
                    }
                    set
                    {
                        name = value;
                    }
                }
                public string Clas
                {
                    get
                    {
                        return clas;
                    }
                    set
                    {
                        clas = value;
                    }
                }
                public int Age
                {
                    get
                    {
                        return age;
                    }
                    set
                    {
                        age = value;
                    }
                }
            }
            static void Main(string[] args)
            {
                Student s1 = new Student(03061, "1", "计科1", 36);
                Student s2 = new Student(03062, "2", "计科2", 31);
                Student s3 = new Student(03063, "3", "计科3", 32);
                Student s4 = new Student(03064, "4", "计科4", 28);
                s4.Age = 2;
                Student[] s = new Student[4];
                s[0] = s1;
                s[1] = s2;
                s[2] = s3;
                s[3] = s4;
                int id_find;
                int flag = 0;
                id_find = int.Parse(Console.ReadLine());
                for (int i = 0; i < 4; i++)
                {
                    if (id_find == s[i].Id)
                    {
                        Console.WriteLine("学生id:" + s[i].Id);
                        Console.WriteLine("学生姓名:" + s[i].Name);
                        Console.WriteLine("学生班级:" + s[i].Clas);
                        Console.WriteLine("学生年龄:" + s[i].Age);
                        flag = 1;

                    }
                }

                if (flag == 0)
                {
                    Console.WriteLine("查无此生!");
                }
                Console.WriteLine("--------------------------------");
                Console.WriteLine("输出全部学生:");
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine("学生id:" + s[i].Id);
                    Console.WriteLine("学生姓名:" + s[i].Name);
                    Console.WriteLine("学生班级:" + s[i].Clas);
                    Console.WriteLine("学生年龄:" + s[i].Age);
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }

}