using System;

class BankManagementSystemCMD
{
    // Defining variables
    static string accountHolderName;
    static string accountNumber;
    static decimal balance = 0;

    // Main method
    static void Main()
    {
        int choice;

        do
        {
            // Displaying menu options
            Console.Clear();
            Console.WriteLine("===== Bank Management System =====");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Check Balance");
            Console.WriteLine("5. Show Account Details");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
            
            // Get the user's choice
            choice = int.Parse(Console.ReadLine());

            // Switch-case to perform the corresponding action
            switch (choice)
            {
                case 1:
                    CreateAccount();
                    break;
                case 2:
                    Deposit();
                    break;
                case 3:
                    Withdraw();
                    break;
                case 4:
                    CheckBalance();
                    break;
                case 5:
                    ShowAccountDetails();
                    break;
                case 6:
                    Console.WriteLine("Exiting the system... Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }

            // Pause before next iteration
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        while (choice != 6);
    }

    // Create account method
    static void CreateAccount()
    {
        Console.WriteLine("===== Create Account =====");

        // Input account holder's name and account number
        Console.Write("Enter Account Holder Name: ");
        accountHolderName = Console.ReadLine();
        
        Console.Write("Enter Account Number: ");
        accountNumber = Console.ReadLine();

        // Initializing balance to 0 when the account is created
        balance = 0;

        Console.WriteLine("Account created successfully!");
    }

    // Deposit money method
    static void Deposit()
    {
        Console.WriteLine("===== Deposit =====");

        if (string.IsNullOrEmpty(accountHolderName))
        {
            Console.WriteLine("No account found. Please create an account first.");
            return;
        }

        // Ask for deposit amount
        Console.Write("Enter deposit amount: ");
        decimal depositAmount = decimal.Parse(Console.ReadLine());

        if (depositAmount <= 0)
        {
            Console.WriteLine("Deposit amount must be greater than zero.");
            return;
        }

        // Update balance
        balance += depositAmount;
        Console.WriteLine("Deposit successful!");
    }

    // Withdraw money method
    static void Withdraw()
    {
        Console.WriteLine("===== Withdraw =====");

        if (string.IsNullOrEmpty(accountHolderName))
        {
            Console.WriteLine("No account found. Please create an account first.");
            return;
        }

        // Ask for withdraw amount
        Console.Write("Enter withdraw amount: ");
        decimal withdrawAmount = decimal.Parse(Console.ReadLine());

        if (withdrawAmount <= 0)
        {
            Console.WriteLine("Withdraw amount must be greater than zero.");
            return;
        }

        if (withdrawAmount > balance)
        {
            Console.WriteLine("Insufficient balance for withdrawal.");
            return;
        }

        // Update balance after withdrawal
        balance -= withdrawAmount;
        Console.WriteLine("Withdrawal successful!");
    }

    // Check balance method
    static void CheckBalance()
    {
        Console.WriteLine("===== Check Balance =====");

        if (string.IsNullOrEmpty(accountHolderName))
        {
            Console.WriteLine("No account found. Please create an account first.");
            return;
        }

        // Display balance without the $ symbol
        Console.WriteLine("Your current balance is: " + balance.ToString());
    }

    // Show account details method
    static void ShowAccountDetails()
    {
        Console.WriteLine("===== Account Details =====");

        if (string.IsNullOrEmpty(accountHolderName))
        {
            Console.WriteLine("No account found. Please create an account first.");
            return;
        }

        Console.WriteLine("Account Holder Name: " + accountHolderName);
        Console.WriteLine("Account Number: " + accountNumber);
        
        // Display balance without the $ symbol
        Console.WriteLine("Current Balance: " + balance.ToString());
    }
}
