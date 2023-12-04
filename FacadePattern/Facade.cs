using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
   
    public class HomeWork
    {
        private Github github;
        private Mystat mystat;
        private Task task;

        public HomeWork()
        {
            github= new Github();
            mystat= new Mystat();
            task= new Task();
        }

        public void CompleteHomework()
        {
            task.doTask();
            github.createRepository();
            mystat.Upload();
        }
    }

    public class Github
    {
        public void createRepository()
        {
            Console.WriteLine("Repository Created");
        }
    }
    public class Mystat
    {
        public void Upload()
        {
            Console.WriteLine("Upload");
        }
    }
    public class Task
    {
        public void doTask()
        {
            Console.WriteLine("DoTask");
        }
    }


    class Program
    {
        static void Main()
        {
            HomeWork homework = new HomeWork();
            homework.CompleteHomework();

            Console.ReadLine();
        }
    }



}
