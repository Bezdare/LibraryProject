using System;

namespace Entities.Classies
{
    public class Book
    {
        public string Name { get; private set; }
        public string Genre { get; private set; }
        public Authors Author { get; private set; }
        public string Year { get; private set; }
        public string Series { get; private set; }
        public int Size { get; private set; }

        public Book()
        {
            Name = string.Empty;
            Genre = string.Empty;
            //Author = author;
            Series = string.Empty;
            Year = string.Empty;
            Size = 0;
        }

        public Book(string name)
        {
            Name = name;
            Genre = string.Empty;
            //Author = author;
            Series = string.Empty;
            Year = string.Empty;
            Size = 0;
        }
        
        public Book(string name, string series)
        {
            Name = name;
            Genre = string.Empty;
            //Author = author;
            Series = series;
            Year = string.Empty;
            Size = 0;
        }
        
        public Book(string name, string series, Authors author)
        {
            Name = name;
            Genre = string.Empty;
            Author = author;
            Series = series;
            Year = string.Empty;
            Size = 0;
        }
        
        public Book(string name, string series, Authors author, int size)
        {
            Name = name;
            Genre = string.Empty;
            Author = author;
            Series = series;
            Year = string.Empty;
            Size = size;
        }
        
        public Book(string name, string series, Authors author, int size, string year)
        {
            Name = name;
            Genre = string.Empty;
            Author = author;
            Series = series;
            Year = year;
            Size = size;
        }
        
        public Book(string name, string series, Authors author, int size, string year, string genre)
        {
            Name = name;
            Genre = genre;
            Author = author;
            Series = series;
            Year = year;
            Size = size;
        }

        public bool NameIsEmpty => Name == string.Empty;
        public bool GenreIsEmpty => Genre == string.Empty;
        public bool SeriesIsEmpty => Series == string.Empty;
        public bool SizeIsEmpty => Size == 0;
        
        public void Rename(string newName)
        {
            Name = newName;
        }

        public void ChangeGenre(string newGenre)
        {
            Genre = newGenre;
        }

        public void ChangeAuthor(Authors newAuthor)
        {
            Author = newAuthor;
        }

        public void ChangeYear(string newYear)
        {
            Year = newYear;
        }

        public void ChangeSeries(string newSeries)
        {
            Series = newSeries;
        }

        public void ChangeSize(int newSize)
        {
            Size = newSize;
        }

        public override string ToString()
        {
            if (NameIsEmpty && SeriesIsEmpty && GenreIsEmpty)
                return string.Empty;

            if (GenreIsEmpty && SeriesIsEmpty)
                return $"Book {Name}";

            if (Author.AuthorIsEmpty)
                return $"Book {Name} in genre {Genre}";

            if (GenreIsEmpty)
                return $"Book {Name} from {Author.ToString()}";
            
            return $"Book {Name} from author {Author.ToString()} in genre {Genre}";
        }
    }
}