using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, BankAccount> bankAccounts = new Dictionary<int, BankAccount>();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            string[] inputTokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string command = inputTokens[0];
            int id = int.Parse(inputTokens[1]);

            if (command == "Create")
            {
                if (!bankAccounts.ContainsKey(id))
                {
                    bankAccounts.Add(id, new BankAccount());
                }
                else
                {
                    Console.WriteLine("Account already exists");
                }
            }
            else if (command == "Deposit")
            {
                if (!bankAccounts.ContainsKey(id))
                {
                    Console.WriteLine("Account does not exist");
                }
                else
                {
                    decimal amount = decimal.Parse(inputTokens[2]);

                    bankAccounts[id].Deposit(amount);
                }           
            }
            else if (command == "Withdraw")
            {
                if (!bankAccounts.ContainsKey(id))
                {
                    Console.WriteLine("Account does not exist");
                }
                else
                {
                    decimal amount = decimal.Parse(inputTokens[2]);

                    if (amount > bankAccounts[id].Balance)
                    {
                        Console.WriteLine("Insufficient balance");                
                    }
                    else
                    {
                        bankAccounts[id].Withdraw(amount);
                    }
                }
            }
            else if (command == "Print")
            {
                if (!bankAccounts.ContainsKey(id))
                {
                    Console.WriteLine("Account does not exist");
                }
                else
                {
                    Console.WriteLine($"Account ID{id}, balance {bankAccounts[id].Balance:f2}");
                }
            }
        }
    }
}