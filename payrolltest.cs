using System;
using System.Collections;
using System.Collections.Generic;



namespace Payroll
{
    class Program
    {

        static void Main(string[] args)
        {
            admin myAdmin = new admin();
            int ctr = 0, dd = 0;
            string u, p;
            do
            {
                Console.WriteLine("enter your username");
                u = Console.ReadLine();
                Console.WriteLine("enter your password");
                p = Console.ReadLine();

                if (u == myAdmin.username && p == myAdmin.password)
                {
                    dd = 1;
                    ctr = 3;
                }
                else
                {
                    dd = 0;
                    ctr++;
                }
            }
            while ((u != myAdmin.username || p != myAdmin.password) && (ctr != 3));
                if (dd == 0)
                {
                    Console.WriteLine("more than three times");
                    return;
                }
                else
                if (dd == 1)
                {
                    Console.WriteLine("welcome");
                }



                int empstocreat = 0;

                Console.WriteLine("how many employees do you want to add?");
                var empnumbers = Convert.ToInt32(Console.ReadLine());
                empstocreat = empnumbers;

                List<Employee> EmployeeList = new List<Employee>();
                for (int i = 0; i < empstocreat; i++)
                {
                    Console.WriteLine("enter your employee first name");
                    var firstName = Console.ReadLine();

                    Console.WriteLine("enter your employee last name");
                    var lastName = Console.ReadLine();

                    Console.WriteLine("enter your employee age");
                    int age1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("enter your ID employee number");
                    int idnum = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("enter your team employee name");
                    var teamName = Console.ReadLine();
                    var data = EmployeeList;
                    EmployeeList.Add(new Employee(firstName, lastName, age1, idnum, teamName));

                }

                foreach (var employee in EmployeeList)
                {
                    Console.WriteLine("employee: {0},{1},{2},{3},{4}", employee.name, employee.lastname, employee.age, employee.idnumber, employee.team);
                }
            }




            /*

            for (int i = 0; i < empstocreat; i++)
            {
               Employee myEmployee  = new Employee();
            }
            
            while (true)
            {
               

                Console.WriteLine("enter your first name");
                var firstName = Console.ReadLine();
                myEmployee.name = firstName;

                Console.WriteLine("enter your last name");
                var lastName = Console.ReadLine();
                myEmployee.lastname = lastName;

                Console.WriteLine("enter your age");
                int age1 = Convert.ToInt32(Console.ReadLine());
                myEmployee.age = age1;

                Console.WriteLine("enter your ID number");
                int idnum = Convert.ToInt32(Console.ReadLine());
                myEmployee.idnumber = idnum;

                Console.WriteLine("enter your team name");
                var teamName = Console.ReadLine();
                myEmployee.team = teamName;

                var employee1 = new ArrayList()
                {
                    myEmployee.name, myEmployee.lastname, myEmployee.age, myEmployee.idnumber, myEmployee.team
                };

                foreach (var item in employee1)
                    Console.Write(item + ", \n");

              

               /* Console.WriteLine("your first name is:" + myEmployee.name);
                Console.WriteLine("your last name is:" + myEmployee.lastname);
                Console.WriteLine("your age is:" + myEmployee.age);
                Console.WriteLine("your ID number is:" + myEmployee.idnumber);
                Console.WriteLine("your team name is:" + myEmployee.team); 
            }*/


        }
    }

