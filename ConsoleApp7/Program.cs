using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            FIO Fio=new FIO();
            Air air = new Air();
           
            Fio.printfio();
            air.printair();
          
        }
    }
    class FIO
    {
        public void printfio()
        {
            Console.WriteLine($"ФИО: {fio}");
            Console.WriteLine($"Дата рождения: {date}");
            Console.WriteLine($"Телефон: {phone}");
            Console.WriteLine($"e-mail: {email}");
            Console.WriteLine($"Должность: {title}");
            Console.WriteLine($"Служебные обязаности: {resp}");
        }
        public string fio = "F I O";
        public string date = "01.01.1999";
        public string phone = "09315986257";
        public string email = "E-mail.com";
        public string title = "Job title";
        public string resp = "responsibilities";

        public string Fio
        {
            set
            {
                fio = value;
            }
            get
            {
                return fio;
            }
        }
        public string Date
        {
            set
            {
                date = value;
            }
            get
            {
                return date;
            }
        }
        public string Phone
        {
            set
            {
                phone = value;
            }
            get
            {
                return phone;
            }
        }
        public string Email
        {
            set
            {
                email = value;
            }
            get
            {
                return email;
            }
        }
        public string Title
        {
            set
            {
                title = value;
            }
            get
            {
                return title;
            }
        }
        public string Resp
        {
            set
            {
                resp = value;
            }
            get
            {
                return resp;
            }
        }
    }
    class Air
    {
        public void printair()
        {
            Console.WriteLine($"Название самолёта: {name}");
            Console.WriteLine($"Название производителя: {foreman}");
            Console.WriteLine($"Год выпуска: {years}");
            Console.WriteLine($"Тип: {type}");
        }
        public string name = "name";
        public string foreman = "foreman";
        public string years = "1997";
        public string type = "boing";
        
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }
        public string Foreman
        {
            set
            {
                foreman = value;
            }
            get
            {
                return foreman;
            }
        }
        public string Years
        {
            set
            {
                years = value;
            }
            get
            {
                return years;
            }
        }
        public string Type
        {
            set
            {
                type = value;
            }
            get
            {
                return type;
            }
        }

    }
  
}
