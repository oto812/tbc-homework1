namespace homework1.Exceptions;

public class User
{
    public string UserId { get; set; }
    public string FullName { get; set; }
    public List<IBAN> Accounts { get; set; }
    
    public User(string userId, string fullName)
    {
        if (string.IsNullOrWhiteSpace(userId))
        {
            throw new ArgumentException("user id must not be empty or null", nameof(userId));
        }
        UserId = userId;
        FullName = fullName;
        Accounts = new List<IBAN>();
    }
    
    public void AddAccount(IBAN account)
    {
        if (account == null)
        {
            throw new ArgumentNullException(nameof(account), "account can't be null.");
        }
        Accounts.Add(account);
    }
    

}