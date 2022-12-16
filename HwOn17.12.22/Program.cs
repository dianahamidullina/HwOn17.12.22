﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HwOn17._12._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Тест индексатора");
            Console.WriteLine("TestCase1");
            Account account1 = new Account(type: TypeAccount.accountCurrent, balance: 34000);
            Account account2 = new Account(type: TypeAccount.accountSavings, balance: 12000);
            account2.PutMoneyFromAccount(account1, 3000);
            Console.WriteLine(account1);
            Console.WriteLine(account1[0]);
            Console.WriteLine(account2);
            Console.WriteLine(account2[0]);
            Console.WriteLine("TeastCase2");
            DecadeBuilding decade = new DecadeBuilding();
            for (int i = 0; i < 10; i++)
            {
                decade[i] = new Building(height: 25 + i, numberStoreys: 5 + i, numberEntrance: 2 + i, numberFlats: 10 + i);
                Console.WriteLine(decade[i]);
            }
            Console.ReadKey();
        }
    }
}
