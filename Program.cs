using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution
{
    public static void Main(string[] args)
    {
        int balance = 1699;
        double savings;
        int deposit;
        string answer;

        Console.WriteLine("Enter Pin:");
        int enterdPin = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < enterdPin; i++)
        {

            //Enter Pin 
            if (enterdPin == 071220)
            {
                Console.WriteLine("Choose Transaction? Press D for Deposit W for Witdraw S to show Savings" +
                    " X to Exit.");
                answer = Console.ReadLine();

                //Withdraw
                if (answer == "W" || answer == "w")
                {
                    Console.WriteLine("How much you want to withdraw?");

                    int withdrawMoney = Convert.ToInt16(Console.ReadLine());

                    int currentBalance = balance - withdrawMoney;
                    balance = currentBalance;

                    Console.WriteLine("You Withdraw {0}", withdrawMoney);

                    Console.WriteLine("Your current balance is {0}", currentBalance);

                    if (currentBalance == 0)
                    {
                        Console.WriteLine("No Money {0} deposit now ", currentBalance);
                    }
                }

                //Deposit
                if (answer == "D" || answer == "d")
                {
                    Console.WriteLine("Insert the amount you want to deposit?");

                    int depositedMoney = Convert.ToInt16(Console.ReadLine());
                    deposit = depositedMoney;

                    int currentBalance = balance + depositedMoney;
                    balance = currentBalance;

                    Console.WriteLine("You Deposited {0}", depositedMoney);

                    Console.WriteLine("Your current balance is {0}", currentBalance);
                }

                //Savings
                if (answer == "S" || answer == "s")
                {
                    Console.WriteLine("Your current balance is {0}", balance);
                }

                //Exit
                if (answer == "X" || answer == "x")
                {
                    Console.WriteLine("Thank you for using ATM");
                    break;
                }

                else
                {
                    Console.WriteLine("Thank you try again next time");
                }
            }
            else
            {
                Console.WriteLine("Incorrect Pin try again");
                break;
            }
        }
    }
}
