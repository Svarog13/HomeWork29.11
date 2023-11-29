using System;

class Program
{
    static void Main(string[] args)
    {
        Piece myPiece = new Piece("Moonlight Sonata", "Ludwig van Beethoven", "Classical", 1801);
        myPiece.ShowInfo();
    }

    class Piece:IDisposable
    {
        public string Title { get; set; }
        public string NameOfAuthor { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        public Piece(string title, string nameOfAuthor, string genre, int year)
        {
            Title = title;
            NameOfAuthor = nameOfAuthor;
            Genre = genre;
            Year = year;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"NameOfAuthor: {NameOfAuthor}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Year: {Year}");
        }
        public void Dispose()
        {
            Console.WriteLine($"Shop{Title} is being disposed.");

        }

        ~Piece()
        {
            Console.WriteLine($"Destructor called for title {Title}");
        }
    }
}