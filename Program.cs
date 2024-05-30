List<Movie> myMovies = new List<Movie>();
string[] data = GetDataFromMyFile();
//ReadDataFromArray(data);

foreach(string in line in data)
{
    string[] tempArray = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
    myMovies newMovie = new myMovies(tempArray[0], tempArray[2]);
    myMovies.Add(newMovie);
}

foreach (Movie movie in myMovies)
{
    Console.WriteLine($"One of my favorite movies {movie.Title} was released in {movie.Year}.");
}

static string[] GetDataFromMyFile()
{
    string filePath = @"/Users/mari-anne/projects/movies.txt";
    return File.ReadAllLines(filePath);
}

static void ReadDataFromArray(string[] someArray)
{
    foreach(string line in someArray)
    {
        Console.WriteLine(line);
    }
}


class Movie
{
    string title; //fields
    string year;



    public string Year
    {
        get { return year; }
    }

    public Movie(string _title, string _year)
    {
        title = _title;
        year = _year;
    }

}
