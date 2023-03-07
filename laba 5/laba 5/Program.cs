
using Read;
using Stud;

namespace Stud
{
    public class Student
    {

        public string fam;
        public string numberGR;
        private int age;

        public Student(string fam, string numberGR, int age)
        {
            this.fam = fam;
            this.numberGR = numberGR;
            this.age = age;
        }

        public void Print()
        {
            Console.WriteLine("фамилия" + fam + "группа" + numberGR + "возраст" + age);
        }
    }
}
namespace Read
{
    public class Reader
    {
        private string fio;
        public int numberChitBil;
        public string facultet;
        private int age;
        public Reader(string fio, int numberChitBil, string facultet,int age)
        {
            this.fio = fio;
            this.numberChitBil= numberChitBil;
            this.facultet = facultet;   
            this.age = age;
        }

        public void takeBook(int numberBook)
        {
            Console.WriteLine(String.Format("{0} взял {1} книг(и)"), fio, numberBook);
        }

        public void takeBook(string namesBook)
        {
            Console.WriteLine(String.Format("{0} взял {1} книг(и)"), fio, namesBook);
        }

        public void returnBook(int numberBook)
        {
            Console.WriteLine(String.Format("{0} взял {1} книг(и)"), fio, numberBook);
        }

        public void returnBook(string namesBook)
        {
            Console.WriteLine(String.Format("{0} взял {1} книг(и)"), fio, namesBook);
        }
    }
}
namespace laba_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students =
            {
                new Student("Курятина А. В.","20ИТ17", 18),
                new Student("Марусик М. Д.", "20ИТ17", 19),
                new Student("Исаев Н. А.","20ИТ17", 19)
            };

            Reader[] libraryUsers =
            {
                new Reader("Курятина А. В.",7543456 , "Математика", 18),
                new Reader("Марусик М. Д.",9385949 , "Физика", 19),
                new Reader("Исаев Н. А.", 7473435, "Русский язык", 19)
            };
        }
    }
}