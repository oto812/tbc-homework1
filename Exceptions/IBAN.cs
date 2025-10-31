namespace homework1.Exceptions;

public abstract class IBAN
{
    protected decimal Balance { get; set; }
    protected string? IbanNumber { get; set; }

    public IBAN(string ibanNumber, decimal initialBalance)
    {
        if (string.IsNullOrWhiteSpace(ibanNumber) || ibanNumber.Length != 12) // მაგალითი ვალიდაცია
        {
            throw new InvalidIbanException("you enter invalid iban number.");
        }
        IbanNumber = ibanNumber;
        Balance = initialBalance;
    }


    public void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            throw new InvalidAmountException("Entered amount cannot be negative.");
        }
        Balance += amount;
        Console.WriteLine($"Deposited {amount} to {IbanNumber}. balance is {Balance}");
        
    }

    public abstract void Withdraw(decimal amount);

}