namespace homework1.Exceptions;

public class ATM
{
    public static void main()
    {
        User user1 = new User("1234", "oto abashidze");

        DebitIban debitAccount = new DebitIban("123142322312", 50);
        CreditIban creditAccount = new CreditIban("123142322313", 50,30);
        
        user1.AddAccount(debitAccount);
        user1.AddAccount(creditAccount);
        
        
        user1.Accounts[1].Deposit(30);
        user1.Accounts[1].Withdraw(100);
        user1.Accounts[0].Deposit(30);
        //this will thow exception
        user1.Accounts[0].Withdraw(100);
        
        
        
       
        

        
    }
}