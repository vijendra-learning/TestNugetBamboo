using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFNuget
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }

        public int AddNumbers(int a, int b)
        {
            return (a + b);
        }
    }

    class Student
    {
        public string Name { get; set; }
        [MaxLength(3)]
        public int Age { get; set; }
    }
}
