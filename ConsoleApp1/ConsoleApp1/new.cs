using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        int studentid;
        string sname;
        string scity;
        int smobile;

        public void insert()
        {
            Program p = new Program();
            Console.WriteLine("Enter student id");
            p.studentid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name");
            p.sname = Console.ReadLine();
            Console.WriteLine("Enter city");
            p.scity = Console.ReadLine();
            Console.WriteLine("Enter mobile");
            p.smobile = Convert.ToInt32(Console.ReadLine());


            DataClasses1DataContext LTS = new DataClasses1DataContext(" Data Source=Lab-Host\\SQLEXPRESS03;Initial Catalog=e_commerce;Integrated Security=True");
            student obj = new student();
            obj.studid = p.studentid;
            obj.name = p.sname;
            obj.city = p.scity;
            obj.mobile = p.smobile;

            LTS.students.InsertOnSubmit(obj);
            LTS.SubmitChanges(); Console.WriteLine("insert is succesfull");
        }

        public void display()
        {
            DataClasses1DataContext LTS = new DataClasses1DataContext(" Data Source=Lab-Host\\SQLEXPRESS03;Initial Catalog=e_commerce;Integrated Security=True");
            var selectquery = from s in LTS.students
                              select s;

            foreach (var e in selectquery)
            {
                Console.WriteLine(e.studid + "\t" + e.name + "\t" + e.city + "\t" + e.mobile);
            }
        }
        public void update()
        {
            DataClasses1DataContext LTS = new DataClasses1DataContext(" Data Source=Lab-Host\\SQLEXPRESS03;Initial Catalog=e_commerce;Integrated Security=True");
            Program p = new Program();
            Console.WriteLine("enter the student id inorder to update");
            p.studentid = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the new name to update");
            p.sname = Console.ReadLine();
            student e = new student();
            var row = from s in LTS.students
                      select s;
            foreach (var r in row)
            {
                if (r.studid == p.studentid)
                {
                    r.name = p.sname;
                }
            }
            LTS.SubmitChanges();
            Console.WriteLine("updated successfully");
        }





        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.insert();
            p1.display();
            p1.update();
            Console.ReadLine();
        }
    }
}


