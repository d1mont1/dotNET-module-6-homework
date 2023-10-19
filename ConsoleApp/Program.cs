using System;
using ClassLibrary;
using Bankomat;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ex #1");

            Person person = new Person();
            person.FirstName = "Dinmukhammed";
            person.LastName = "Omirzak";
            person.Age = 20;

            string personInfo = Student.GetInfo(person);
            Console.WriteLine(personInfo);

            ////////////////////////////////////
            
            Console.WriteLine("Ex #2");

            Console.WriteLine("Constants:");
            Console.WriteLine($"1. String: {Constants.StringConstant}");
            Console.WriteLine($"2. Int: {Constants.IntConstant}");
            Console.WriteLine($"3. Double: {Constants.DoubleConstant}");

            ////////////////////////////////////

            Console.WriteLine("Ex #3-8");

            Bank bank = new Bank();
            Client client = new Client("Omirzak Dinmukhammed", "123123123");
            Account account = new Account(client, 0);

            int loginAttempts = 3;
            bool isLoggedIn = false;

            while (loginAttempts > 0)
            {
                Console.Write("Введите пароль: ");
                string password = Console.ReadLine();

                if (bank.CheckPassword(client, password))
                {
                    isLoggedIn = true;
                    break;
                }
                else
                {
                    loginAttempts--;
                    Console.WriteLine($"Неверный пароль. Попыток осталось: {loginAttempts}");
                }
            }

            if (!isLoggedIn)
            {
                Console.WriteLine("Попытки исчерпаны. Доступ запрещен.");
                return;
            }

            while (true)
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("a. Вывести баланс");
                Console.WriteLine("b. Пополнить счет");
                Console.WriteLine("c. Снять деньги");
                Console.WriteLine("d. Выход");

                Console.Write("Выберите действие: ");
                char choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                switch (choice)
                {
                    case 'a':
                        if (account != null)
                        {
                            Console.WriteLine($"Баланс: {account.Balance}");
                        }
                        break;

                    case 'b':
                        if (account == null)
                        {
                            Console.WriteLine("Сначала откройте счет.");
                        }
                        else
                        {
                            Console.Write("Введите сумму для пополнения: ");
                            if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                            {
                                account.Deposit(depositAmount);
                                Console.WriteLine($"Счет пополнен на {depositAmount}. Осталось: {account.Balance}.");
                            }
                            else
                            {
                                Console.WriteLine("Некорректная сумма.");
                            }
                        }
                        break;

                    case 'c':
                        if (account == null)
                        {
                            Console.WriteLine("Сначала откройте счет.");
                        }
                        else
                        {
                            Console.Write("Введите сумму для снятия: ");
                            if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount))
                            {
                                if (account.Withdraw(withdrawAmount))
                                {
                                    Console.WriteLine($"Сумма {withdrawAmount} снята со счета. Осталось: {account.Balance}.");
                                }
                                else
                                {
                                    Console.WriteLine("Недостаточно средств на счете.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Некорректная сумма.");
                            }
                        }
                        break;

                    case 'd':
                        return;
                }
            }
        }
    }
}
