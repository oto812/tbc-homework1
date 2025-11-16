namespace homework1.Exceptions;

public class DebitIban : IBAN
{
    public DebitIban(string ibanNumber, decimal initialBalance)
        : base(ibanNumber, initialBalance) { }

    public override void Withdraw(decimal amount)
    {
        if (amount < 0)
        {
            throw new InvalidAmountException("The amount cannot be negative");
        }

        if (amount > this.Balance)
        {
            throw new InsufficientFundsException("not enough funds for withdrawal");
        }
        Balance -= amount;
        Console.WriteLine($"Withdrawal : {amount} from DebitAccount : {IbanNumber}. BalanceLeft : {Balance} ");

    }
    
}