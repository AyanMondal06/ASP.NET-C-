/*Define a class to represent a bank account which includes the subsequent members:
Data members:
1.Name of the depositor
2. Account Number
3. Withdraw amount
4. Balance amount in the account
Member Functions:
1.To assign initial values
2. To deposit an amount
3. To withdraw amount after checking the balance
4. To display name and balance*/


using System;


class Bank
{
    private String nameOfDepositor;
    private int accNumber;
    private double balanceAmount;

    public void assignValues(String nameOfDepositor,double balanceAmount)
        {
        this.nameOfDepositor = nameOfDepositor;
        this.balanceAmount = balanceAmount;
        Random random = new Random();
        this.accNumber = random.Next(1000000);
        }
    public void DepositeAmount(double amount)
    {
        if (accNumber == 0)
            Console.WriteLine("Account does not exist...!!!");
        else
        {
            balanceAmount += amount;
            Console.WriteLine("Amount deposited Successfully.!");
        }
        
    }
    public void WithdrawAmount(double amount)
    {
        if (accNumber == 0)
            Console.WriteLine("Account does not exist...!!!");
        else if(balanceAmount>amount)
        {
            balanceAmount -= amount;
            Console.WriteLine("Amount credited Successfully.!");
            Console.WriteLine("Remaining Amount: " + balanceAmount);
        }
        else
        {
            Console.WriteLine("Insufficient Balance...!!!");
        }
    }


        public void DisplayDetails()
    {
        if (accNumber == 0)
            Console.WriteLine("Account does not exist...!!!");
        else
        {
            Console.WriteLine("Name of the Depositor: "+ nameOfDepositor);
            Console.WriteLine("Balance amount in the account: "+balanceAmount);
        }

    }
    public void getInput()
    {
        Console.WriteLine("How can i help you?");
        Console.WriteLine("1. Open account");
        Console.WriteLine("2. Deposit amount");
        Console.WriteLine("3. Withdraw amount");
        Console.WriteLine("4. Account details");
        Console.WriteLine("5. Exit");
        Console.WriteLine("Please choose from above (Eg.2): ");
    }

}

class MiniProject
{
    public static void Main(String[] s)
    {
        Console.WriteLine(":: Welcome to the Bank::");
        Bank newAccount = new Bank();
        int continueState = 0;
        while (continueState == 0)
        {
            try
            {
                newAccount.getInput();
                int currentProcess = Convert.ToInt32(Console.ReadLine());
                if (currentProcess == 1)
                {
                    Console.WriteLine("Enter your name: ");
                    String nameOfDepositor = Console.ReadLine();
                    Console.WriteLine("Enter your opening amount: ");
                    double balanceAmount = Convert.ToDouble(Console.ReadLine());
                    newAccount.assignValues(nameOfDepositor, balanceAmount);
                }
                else if (currentProcess == 2)
                {
                    Console.WriteLine("Enter amount to deposit: ");
                    newAccount.DepositeAmount(Convert.ToDouble(Console.ReadLine()));
                }
                else if (currentProcess == 3)
                {
                    Console.WriteLine("Enter amount to withdraw: ");
                    newAccount.WithdrawAmount(Convert.ToDouble(Console.ReadLine()));
                }
                else if (currentProcess == 4)
                {
                    newAccount.DisplayDetails();
                }
                else if (currentProcess == 5)
                {
                    continueState = 1;
                    Console.WriteLine("THANK YOU");
                }

                Console.WriteLine("press 0 to continue or any other key to exit...!!! ");
                continueState = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException )
            {
                Console.WriteLine("Wrong Input format: ");
            }
        }

    }
}