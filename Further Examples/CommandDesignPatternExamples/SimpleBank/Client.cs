using SimpleBank.Commands;
using SimpleBank.Invokers;
using SimpleBank.Receivers;
using System;

namespace SimpleBank
{
    static class Client
    {
        static Client() { }

        public static void Test_AllTransactionsSuccessful()
        {
            var transactionManager = new TransactionManager();

            var suesAccount = new Account("Sue Smith", 0);

            var deposit = new Deposit(1, suesAccount, 100);
            transactionManager.AddTransaction(deposit);

            // Command has been added to the queue, but not executed.
            Console.WriteLine("Transaction Manager has pending transactions? {0}", 
                transactionManager.HasPendingTransactions);
            Console.WriteLine("Sue's account balance: {0}", suesAccount.Balance);

            // This executes the commands.
            transactionManager.ProcessPendingTransactions();

            Console.WriteLine("Transaction Manager has pending transactions? {0}", 
                transactionManager.HasPendingTransactions);
            Console.WriteLine("Sue's account balance: {0}", suesAccount.Balance);

            // Add a withdrawal, apply it, and verify the balance changed.
            var withdrawal = new Withdraw(2, suesAccount, 50);
            transactionManager.AddTransaction(withdrawal);

            transactionManager.ProcessPendingTransactions();

            Console.WriteLine("Transaction Manager has pending transactions? {0}",
                transactionManager.HasPendingTransactions);
            Console.WriteLine("Sue's account balance: {0}", suesAccount.Balance);

            // Test the undo
            transactionManager.UndoTransactionNumber(2);

            Console.WriteLine("Transaction Manager has pending transactions? {0}",
                transactionManager.HasPendingTransactions);
            Console.WriteLine("Sue's account balance: {0}", suesAccount.Balance);
        }
        
        public static void Test_OverdraftRemainsInPendingTransactions()
        {
            var transactionManager = new TransactionManager();

            // Create an account with a balance of 75
            var bobsAccount = new Account("Bob Jones", 75);

            // The first command is a withdrawal that is larger than the account's balance.
            // It will not be executed, because of the check in Withdraw.Execute.
            // The deposit will be successful.
            transactionManager.AddTransaction(new Withdraw(1, bobsAccount, 100));
            transactionManager.AddTransaction(new Deposit(2, bobsAccount, 75));

            transactionManager.ProcessPendingTransactions();

            // The withdrawal of 100 was not completed, 
            // because there was not enough money in the account.
            // So, it is still pending.
            Console.WriteLine("Transaction Manager has pending transactions? {0}",
                transactionManager.HasPendingTransactions);
            Console.WriteLine("Bob's account balance: {0}", bobsAccount.Balance);

            // The pending transactions (the withdrawal of 100), should execute now.
            transactionManager.ProcessPendingTransactions();

            Console.WriteLine("Transaction Manager has pending transactions? {0}",
                transactionManager.HasPendingTransactions);
            Console.WriteLine("Bob's account balance: {0}", bobsAccount.Balance);

            // Test the undo
            transactionManager.UndoTransactionNumber(2);

            // The undo failed, because there is not enough money in the account to undo a deposit of 75
            Console.WriteLine("Transaction Manager has pending transactions? {0}",
                transactionManager.HasPendingTransactions);
            Console.WriteLine("Bob's account balance: {0}", bobsAccount.Balance);

            transactionManager.UndoTransactionNumber(1);

            // The previous undo (for transaction ID 2) is still pending.
            // But, we successfully undid transaction ID 1.
            Console.WriteLine("Transaction Manager has pending transactions? {0}",
                transactionManager.HasPendingTransactions);
            Console.WriteLine("Bob's account balance: {0}", bobsAccount.Balance);

            // This should re-do the failed undo for transaction ID 2
            transactionManager.ProcessPendingTransactions();

            Console.WriteLine("Transaction Manager has pending transactions? {0}",
                transactionManager.HasPendingTransactions);
            Console.WriteLine("Bob's account balance: {0}", bobsAccount.Balance);
        }
        
        public static void Test_Transfer()
        {
            var random = new Random();

            var transactionManager = new TransactionManager();

            var checking = new Account("Mike Brown", 1000);
            var savings = new Account("Mike Brown", 100);

            transactionManager.AddTransaction(new Transfer(random.Next(), checking, savings, 750));

            transactionManager.ProcessPendingTransactions();

            Console.WriteLine("Mike Brown's checking account balance: {0}", checking.Balance);
            Console.WriteLine("Bob's savings account balance: {0}", savings.Balance);

            // Undo the transfer, and check the account balances.
            transactionManager.UndoTransactionNumber(1);

            Console.WriteLine("Transaction Manager has pending transactions? {0}",
                transactionManager.HasPendingTransactions);
            Console.WriteLine("Mike Brown's checking account balance: {0}", checking.Balance);
            Console.WriteLine("Bob's savings account balance: {0}", savings.Balance);
        }
    }
}
