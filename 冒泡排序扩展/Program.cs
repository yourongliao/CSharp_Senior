using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 冒泡排序扩展
{
    class Program
    {
        static void Sort(int[] sortArray)
        {
            bool swapped = true;

            do
            {
                swapped = false;

                for (int i = 0; i < sortArray.Length - 1; i++)
                {
                    if (sortArray[i] > sortArray[i + 1])
                    {
                        int temp = sortArray[i];

                        sortArray[i] = sortArray[i + 1];

                        sortArray[i + 1] = temp;

                        swapped = true;
                    }
                }

            } while (swapped);
        }

        static void CommonSort<T>(T[] sortArray, Func<T, T, bool> compareMethod)
        {
            bool swapped = true;

            do
            {
                swapped = false;

                for (int i = 0; i < sortArray.Length - 1; i++)
                {
                    if (compareMethod(sortArray[i],sortArray[i+1]))
                    {
                        T temp = sortArray[i];

                        sortArray[i] = sortArray[i + 1];

                        sortArray[i + 1] = temp;

                        swapped = true;
                    }
                }

            } while (swapped);
        }

        static void Main(string[] args)
        {
            //int[] sortArray = new int[] { 123, 23, 45, 32, 567, 53, 21 };

            //Sort(sortArray);

            //foreach (var temp in sortArray)
            //{
            //    Console.Write(temp + " ");
            //}

            //Console.ReadKey();

            Employee[] employees = new Employee[]
            {
                new Employee("lall",12),
                new Employee("sas1",35),
                new Employee("oaipdka8",76),
                new Employee("kjsakjl",100)
            };

            CommonSort<Employee>(employees, Employee.Compare);

            foreach (Employee em in employees)
            {
                Console.WriteLine(em.ToString());
            }

            Console.ReadKey();

        }
    }
}
