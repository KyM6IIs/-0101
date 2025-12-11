using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Student
    {
        public string Name;
        public int Score;
    }
    class Program
    {
        static void Main()
        {
            List<Student> list = new List<Student>();
            list.Add(new Student { Name = "Анна", Score = 95 });
            list.Add(new Student { Name = "Пётр", Score = 95 });
            list.Add(new Student { Name = "Ольга", Score = 88 });
            list.Add(new Student { Name = "Иван", Score = 75 });
            list.Add(new Student { Name = "Мария", Score = 75 });

            Dictionary<int, List<string>> dict = new Dictionary<int, List<string>>();

            foreach (Student s in list)
            {
                int score = s.Score;
                if (!dict.ContainsKey(score))
                {
                    dict[score] = new List<string>();
                }
                dict[score].Add(s.Name);
            }
            List<int> scores = new List<int>();
            foreach (int score in dict.Keys)
            {
                scores.Add(score);
            }
            for (int i = 0; i < scores.Count; i++)
            {
                for (int j = i + 1; j < scores.Count; j++)
                {
                    if (scores[i] < scores[j])
                    {
                        int temp = scores[i];
                        scores[i] = scores[j];
                        scores[j] = temp;
                    }
                }
            }

            Console.WriteLine("результат:");
            foreach (int score in scores)
            {
                string names = "";
                List<string> nameList = dict[score];

                for (int i = 0; i < nameList.Count; i++)
                {
                    names += nameList[i];
                    if (i < nameList.Count - 1)
                        names += ", ";
                }

                Console.WriteLine(score + ": " + names);
            }
        }
    }
}