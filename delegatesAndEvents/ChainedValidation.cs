namespace homework1.delegates_events;

public class ChainedValidation
{
    public delegate bool Validator(Book book);
    

    public static bool TitleValidation(Book book)
    {
        if (book.Title == null || book.Title.Length < 1 || book.Title.Length > 255)
        {
            return false;
        }

        foreach (char ch in book.Title)
        {
            if (!char.IsLetter(ch))
            {
                return false;
            }
        }
        return true;
    }

    public static bool AuthorValidation(Book book)
    {
        if (book.Author == null || book.Author.Length < 3 || book.Author.Length > 128)
        {
            return false;
        }
        foreach (char ch in book.Author)
        {
            if (!char.IsLetter(ch))
            {
                return false;
            }
        }

        return true;
    }

    public static bool ISBNValidation(Book book)
    {
        int length = 0;
        long isbn = book.ISBN;
        while (isbn != 0)
        {
            length++;
            isbn /= 10;
        }

        return length == 13;
    }

    public static bool PublisherValidation(Book book)
    {
        if (book.Publisher == null || book.Publisher.Length < 2 || book.Publisher.Length > 64)
        {
            return false;
        }
        return true;
    }

    public static bool GenreValidation(Book book)
    {
        if (book.Genre == null)
        {
            return false;
        }

        return true;
    }

    public static bool NumberOfPagesValidation(Book book)
    {
        if (book.NumberOfPages == null || book.NumberOfPages <= 0)
        {
            return false;
        }
        return true;
    }

    public static bool PriceValidation(Book book)
    {
        if (book.Price != null && book.Price < 0)
        {
            return false;
        }
        return true;
    }

    public static bool IsAvaliableValidation(Book book)
    {
        if (book.IsAvailable == null)
        {
            return false;
        }

        return true;
    }
    
    public static List<string> GetInvalidFields(Book book, Validator chain)
    {
        var invalid = new List<string>();

        foreach (Validator validator in chain.GetInvocationList())
        {
            bool result = validator(book);
        
            if (!result)
            {
                invalid.Add(validator.Method.Name.Replace("Validation", ""));
            }
        }

        return invalid;
    }


    public static void Main()
    {
        
        Book book = new Book
        {
            Title = "Hello123", 
            Author = "A", 
            ISBN = 123456789012, 
            Publisher = "P",
            Genre = null,
            NumberOfPages = -10,
            Price = -5,
            IsAvailable = true
        };
        
        Validator chain1 = TitleValidation;
        chain1 += AuthorValidation;
        chain1 += ISBNValidation;
        Validator chain2 = PublisherValidation;
        chain2 += PublisherValidation;
        chain2 += GenreValidation;
        chain2 += NumberOfPagesValidation;
        
        var invalidFields1 = GetInvalidFields(book, chain1);
        var invalidFields2 = GetInvalidFields(book, chain2);
        
        Console.WriteLine("Invalid fields : ");

        foreach (var invalidField in invalidFields1)
        {
            Console.WriteLine(invalidField);
        }

        foreach (var invalidField in invalidFields2)
        {
            Console.WriteLine(invalidField);
        }
        
    }
}