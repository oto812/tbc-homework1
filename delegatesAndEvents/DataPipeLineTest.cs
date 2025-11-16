namespace homework1.delegates_events;
using homework1.dataStructures;

public class DataPipeLineTest
{
    public static void Main()
    {
        var pipeline = new DataPipeline<Book>();
        
        var books = new List<Book>
{
    new Book
    {
        Title = "CleanCode",
        Author = "RobertMartin",
        ISBN = 9780132350884,
        Publisher = "Pearson",
        PublishDate = new DateTime(2008, 8, 1),
        Genre = Genre.Comedy,
        NumberOfPages = 464,
        Price = 40,
        IsAvailable = true
    },
    new Book
    {
        Title = "Dune",
        Author = "FrankHerbert",
        ISBN = 9780441013593,
        Publisher = "Ace",
        PublishDate = new DateTime(1965, 6, 1),
        Genre = Genre.Horror,
        NumberOfPages = 896,
        Price = 18,
        IsAvailable = true
    },
    new Book
    {
        Title = "Foundation",
        Author = "IsaacAsimov",
        ISBN = 9780553293357,
        Publisher = "Bantam",
        PublishDate = new DateTime(1951, 5, 1),
        Genre = Genre.Fantasy,
        NumberOfPages = 296,
        Price = 15,
        IsAvailable = false
    },
    new Book
    {
        Title = "Hamlet",
        Author = "WilliamShakespeare",
        ISBN = 9780743477123,
        Publisher = "SimonAndSchuster",
        PublishDate = new DateTime(1603, 1, 1),
        Genre = Genre.Fantasy,
        NumberOfPages = 342,
        Price = 10,
        IsAvailable = true
    },
    new Book
    {
        Title = "Inferno",
        Author = "DanBrown",
        ISBN = 9780385537858,
        Publisher = "Doubleday",
        PublishDate = new DateTime(2013, 5, 14),
        Genre = Genre.Fantasy,
        NumberOfPages = 480,
        Price = 20,
        IsAvailable = true
    },
    new Book
    {
        Title = "TheHobbit",
        Author = "JRRRTolkien",
        ISBN = 9780547928227,
        Publisher = "HoughtonMifflin",
        PublishDate = new DateTime(1937, 9, 21),
        Genre = Genre.Fantasy,
        NumberOfPages = 310,
        Price = 14,
        IsAvailable = true
    },
    new Book
    {
        Title = "MeteorologyBasics",
        Author = "JohnSmith",
        ISBN = 9780101010101,
        Publisher = "WeatherPress",
        PublishDate = new DateTime(2020, 3, 15),
        Genre = Genre.Horror,
        NumberOfPages = 210,
        Price = 25,
        IsAvailable = false
    },
    new Book
    {
        Title = "CookingMastery",
        Author = "AnnaWhite",
        ISBN = 9780202020202,
        Publisher = "KitchenHouse",
        PublishDate = new DateTime(2019, 11, 5),
        Genre = Genre.Romance,
        NumberOfPages = 520,
        Price = 32,
        IsAvailable = true
    },
    new Book
    {
        Title = "DeepSpace",
        Author = "CarlSagan",
        ISBN = 9780306406112,
        Publisher = "RandomHouse",
        PublishDate = new DateTime(1980, 1, 1),
        Genre = Genre.Comedy,
        NumberOfPages = 365,
        Price = 28,
        IsAvailable = false
    },
    new Book
    {
        Title = "ArtOfWar",
        Author = "SunTzu",
        ISBN = 9781599869773,
        Publisher = "TribecaBooks",
        PublishDate = new DateTime(500, 1, 1),
        Genre = Genre.Fantasy,
        NumberOfPages = 273,
        Price = 8,
        IsAvailable = true
    }
};
        
        pipeline.Filters.Add(b => b.Price < 20);
        pipeline.Filters.Add(b => b.IsAvailable);
        pipeline.Filters.Add(b => b.Genre == Genre.Fantasy);
        var filteredBooks = pipeline.ProcessFilters(books);
        
        

        IEnumerable<BookDto> bookDtos = pipeline.ProcessTransform(filteredBooks, b => new BookDto
        {
            Title = b.Title,
            Author = b.Author,
            Genre = b.Genre,
            IsAvailable = b.IsAvailable,
            Price = b.Price
        });
        
        foreach (var dto in bookDtos)
        {
            Console.WriteLine(dto.Title);
            Console.WriteLine(dto.Author);
            Console.WriteLine(dto.Genre);
            Console.WriteLine(dto.IsAvailable);
            Console.WriteLine(dto.Price);
        }



    }
}