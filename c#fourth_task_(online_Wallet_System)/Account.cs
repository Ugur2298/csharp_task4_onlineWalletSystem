using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace c_fourth_task__online_Wallet_System_
{
    internal class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string AccountNumber { get; set; }
        public decimal CurrentMoney { get; set; }
        public List<Transaction> TransactionList = new List<Transaction>();

        decimal money = 0;
        public void AddMoney()
        {
            
            Console.WriteLine("Zehmet olmasa meblegi daxil edin:");
            money = decimal.Parse(Console.ReadLine());
            CurrentMoney+=money;
            Transaction transaction = new Transaction(money,DateTime.Now,TransactionType.Deposit,OperationType.Success,$"{money} added into {this.AccountNumber}");
            TransactionList.Add(transaction);
            Console.WriteLine($"Account Name:{this.Name} Account Surname: {this.SurName} Account Number: {this.AccountNumber} Account Money: {money}");
        }

        public void GetMoney()
        {
          
            Console.WriteLine("Zehmet olmasa meblegi daxil edin:");
            money = decimal.Parse(Console.ReadLine());
           
            if (money >= CurrentMoney) 
            {
                CurrentMoney = CurrentMoney - money;
                Transaction transaction = new Transaction(money, DateTime.Now, TransactionType.Withdraw, OperationType.Success, $"{money} withdrawed into {this.AccountNumber}");
            }
            else
            {
                Transaction transaction = new Transaction(money, DateTime.Now, TransactionType.Withdraw, OperationType.Failure, $"{money} not  withdrawed into {this.AccountNumber}");
            }
            ;
            Console.WriteLine($"Account Name:{this.Name} Account Surname: {this.SurName} Account Number: {this.AccountNumber} Account Money: {money}");
        }

        public void ShowBalance()
        {
            if (money > 0)
            {
                string showMoney = money.ToString();
                Console.WriteLine($" Account Balance: {showMoney} azn");
            }
            else
            {
                Console.WriteLine("Balansda pul yoxdur");
            }
        }
        

        public void GetTransaction() 
        {
            foreach (var item in TransactionList)
            {
                Console.WriteLine($"Description:{item.Description} Money:{item.Amount} Transaction Type: {item.TypeTransaction} Operation Time: {item.OperationTime} Operation Type: {item.TypeOperation}");
            }
        }
       
    }



}
