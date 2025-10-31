namespace homework1.Exceptions;

public class CreditIban : IBAN
{
    public decimal CreditLimit { get; set; }

    public CreditIban(string ibanNumber, decimal initialBalance, decimal creditLimit)
        : base(ibanNumber, initialBalance)
    {
        CreditLimit = creditLimit;
    }

    public override void Withdraw(decimal amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Amount cannot be negative");
        }

        if (Balance + CreditLimit < amount)
        {
            throw new InsufficientFundsException("not enough funds for withdrawal");
        }
        Balance -= amount;
        Console.WriteLine($"Withdrawal : {amount} from CreditAccount : {IbanNumber}. CreditLimit: {CreditLimit}. BalanceLeft : {Balance} ");
    }



}