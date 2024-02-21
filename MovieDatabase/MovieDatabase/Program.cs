using MovieDatabase;
using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.CompilerServices;


List<Movie> MovieList = new List<Movie>
{
new Movie("Star wars", "scifi"),
new Movie("Tremors", "scifi"),
new Movie("Alien", "scifi"),
new Movie("Big Hero 6", "animated"),
new Movie("Finding Nemo", "animated"),
new Movie("Secret Life of Pets", "animated" ),
new Movie("Friday the 13th", "horror"),
new Movie("Nightmare on Elm Street", "horror"),
new Movie("Chucky", "horror"),
new Movie("Devil Wears Prada", "drama"),
new Movie("Once Upon a Time in Hollywood", "drama"),
new Movie("Oppenheimer", "drama")
};

int countOfMovies = MovieList.Count;

Console.WriteLine("Welcome to the Movie List Application!");
Console.WriteLine($"There are {countOfMovies} movies in this list.");
Console.WriteLine();

bool needValidCategory = true;
bool continueLooping = true;

while (continueLooping)
{
    while (needValidCategory == true)
    {
        Console.WriteLine("Which category are you interested in (animated, drama, horror, or scifi)?");
        string chosenCategory = Console.ReadLine().ToLower().Trim();

        if (InvalidCategory(chosenCategory) == false)
        {
            needValidCategory = false;
            foreach (var movie in MovieList)
            {
                if (movie.Category == chosenCategory)
                {
                    Console.WriteLine(movie.Title);
                }
            }
        }
        else Console.WriteLine("That is not a valid category. Please select animated, drama, horror, or scifi");
    }
}
Console.Write("Continue? (y/n): ");
continueLooping = Console.ReadLine().ToLower().Trim() == "y";

Console.WriteLine("Hope you enjoy one of the movies!");


bool InvalidCategory(string category)
{
    if (category == "animated" || category == "horror" || category == "drama" || category == "scifi")
        return false;
    else return true;
}