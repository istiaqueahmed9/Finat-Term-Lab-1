
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            ?/Console.WriteLine("Employee Information");
            //Console.WriteLine();
            //Console.WriteLine();

            Bank b = new Bank("Sonali Bank");
            Employee e1 = new Employee("Istiaque Ahned", "0001", 1000);
            Employee e2 = new Employee("Mohammad Saif ", "123123", 1000);
            Employee e3 = new Employee("Shafin Mahmud", "12322", 1000);
            b.AddEmployee(e1, e2, e3);
            //b.ShowAllEmployees();
            //Console.WriteLine();
            //Console.WriteLine("Customer and Account Information");
            //Console.WriteLine();
            //Console.WriteLine();
            Customer c = new Customer("121", "Istiaque Ahmed", "Feni");
            Account a1 = new SavingsAccount("Istiaque Ahmed", "12020", 15000);
            Account a2 = new FixedAccount("Istiaque Ahmed", "12020", 10000, 2016, 3);
            c.AddAccounts(a1, a2);
            FixedAccount a3 = new FixedAccount("Istiaque Ahmed", "12020", 15000, 2016, 3);
            Account a5 = new FixedAccount("Mohammad Saif", "12123", 20000, 2016, 3);
            //Console.WriteLine();
            Console.WriteLine("Fixed Account Check");
            //Console.WriteLine();
            Console.WriteLine();
            a2.ShowInfo();
            Console.WriteLine();
            Console.WriteLine("Fixed Account Withdraw Check|");
            Console.WriteLine();
            a2.Withdraw(5000);
            a2.ShowInfo();


            Console.WriteLine();
            Console.WriteLine("Saving Account Check");
            Account a6 = new SavingsAccount("Istiaque Ahmed", "12020", 15000);
            SavingsAccount a4 = new SavingsAccount("Mohammad Saif", "12123", 20000);
            //Console.WriteLine();
            Console.WriteLine();
            a4.ShowInfo();
            a4.Deposit(100000);
            a4.ShowInfo();
            Console.WriteLine();
            Console.WriteLine("Saving Account Withdraw Check");
            Console.WriteLine();

            a4.Withdraw(8000);
            a4.ShowInfo();


            Console.WriteLine();
            Console.WriteLine("Special Savings Account Check");
            Console.WriteLine();
            SpecialSavings s1 = new SpecialSavings("Shafin Mahmud", "12024", 10000);
            SpecialSavings s2 = new SpecialSavings("Shovon Islam", "12025", 10000);
            Console.WriteLine();
            s1.ShowInfo();
            s1.Deposit(100000);
            s1.ShowInfo();
            Console.WriteLine();
            Console.WriteLine("Special Savings Account Withdraw Check");
            Console.WriteLine();

            s2.Withdraw(3300);
            s2.ShowInfo();

            Console.WriteLine();
            Console.WriteLine("OverDraft Account Check");
            Console.WriteLine();
            Overdraft o1 = new Overdraft("Zahim", "12104", 10000);
            Overdraft o2 = new Overdraft("Jahim", "12025", 10000);
            Console.WriteLine();
            o1.ShowInfo();
            o1.Deposit(100000);
            o1.ShowInfo();
            Console.WriteLine();
            Console.WriteLine("OverDraft Account Withdraw Check");
            Console.WriteLine();

            o2.Withdraw(3300);
            o2.ShowInfo();

        }
    }
