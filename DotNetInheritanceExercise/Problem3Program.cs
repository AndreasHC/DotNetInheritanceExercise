using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetInheritanceExercise
{
    public static class Problem3Program
    {
        public static void Main(string[] args)
        {
            try
            {
                string studentString = Console.ReadLine();
                string workerString = Console.ReadLine();
                string[] studentSegments = studentString.Split(' ');
                string[] workerSegments = workerString.Split(' ');

                Student student = new Student(studentSegments[0], studentSegments[1], studentSegments[2]);
                Worker worker = new Worker(workerSegments[0], workerSegments[1], decimal.Parse(workerSegments[2]), decimal.Parse(workerSegments[3]));

                Console.WriteLine(student + Environment.NewLine);
                Console.WriteLine(worker);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }

        }
    }
}
