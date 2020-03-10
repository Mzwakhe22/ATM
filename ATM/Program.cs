using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is an ATM");  
          int amount = 2034, deposit, withdraw;  
        int choice, pin = 0, x = 0;  
        Console.WriteLine("Please enter your pin code :");

       
        pin = int.Parse(Console.ReadLine());

        Console.WriteLine("The Value You entered is : " + pin +" Please Press enter to Continue ");

        Console.ReadLine();

        while (true) {  
            Console.WriteLine("*************WELCOME TO YES BANK ATM SERVICE *****************\n");  
            Console.WriteLine("1. Current Balance\n");  
            Console.WriteLine("2. Withdraw Cash \n");  
            Console.WriteLine("3. Deposit Cash \n");  
            Console.WriteLine("4. Quit \n");  
            Console.WriteLine("***************************\n\n");  
            Console.WriteLine("ENTER YOUR CHOICE : ");  
            choice = int.Parse(Console.ReadLine());  
            switch (choice) {  
                case 1:  
                    Console.WriteLine("\n YOUR CURRENT BALANCE IS Rs : {0} ", amount);  
                    break;  
                case 2:  
                    Console.WriteLine("\n ENTER THE WITHDRAW AMOUNT : ");  
                    withdraw = int.Parse(Console.ReadLine());  
                    if (withdraw % 100 != 0) {  
                        Console.WriteLine("\n PLEASE ENTER THE AMOUNT IN ABOVE 100");  
                    } else if (withdraw > (amount - 1000)) {  
                        Console.WriteLine("\n SORRY! INSUFFICENT BALANCE");  
                    } else {  
                        amount = amount - withdraw;  
                        Console.WriteLine("\n\n PLEASE COLLECT YOUR CASH");  
                        Console.WriteLine("\n CURRENT BALANCE IS Rs : {0}", amount);  
                    }  

                    break;  
                case 3:  
                    Console.WriteLine("\n ENTER THE DEPOSIT AMOUNT");  
                    deposit = int.Parse(Console.ReadLine());  
                    amount = amount + deposit;  
                    Console.WriteLine("YOUR AMOUNT HAS BEEN DEPOSITED SUCCESSFULLY..");  
                    Console.WriteLine("YOUR TOTAL BALANCE IS Rs : {0}", amount);  
                    break;  
                case 4:  
                    Console.WriteLine("\n THANK YOU…");  
                        break;  
                    }  
            }  
         //   Console.WriteLine("\n\n THANKS FOR USING YES ATM SERVICE");  
        }  

        }
    }
