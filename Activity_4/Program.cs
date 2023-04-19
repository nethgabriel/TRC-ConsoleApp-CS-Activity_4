//For Each Statement & Query Syntax

namespace Activity_4
{
    class Program
    {
        public class Students
        {
            public string Name { get; set;}
            public int Grade { get; set; }
            public int Age { get; set; }

            public Students(string sName, int sGrade, int age)
            {
                Name = sName;
                Grade = sGrade;
                Age = age;
            }
        }
        static void Main(string[] args)
        {
            Students[] std = new Students[5];

            std[0] = new Students("Melissa", 78, 17);
            std[1] = new Students("Kimberly", 60, 17);
            std[2] = new Students("Jordan", 90, 17);
            std[3] = new Students("Fred", 100, 20);
            std[4] = new Students("Leon", 91, 17);

            var res = from x in std
                      where x.Grade > 75
                      select x;

            foreach (var x in res)
            {
                if (x.Grade == 100)
                {
                    Console.WriteLine(x.Name + " with Highest Honors");
                }

                if (x.Grade < 100 && x.Grade >= 90)
                {
                    Console.WriteLine(x.Name + " with High Honors");
                }
            }

        }
    }
}