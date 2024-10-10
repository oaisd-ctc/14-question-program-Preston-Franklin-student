using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("What's your name?");
        String name = Console.ReadLine();
        Console.WriteLine("What's your age?");
        int age = Convert.ToInt32(Console.ReadLine());
        int ageNumber = age + 5;
        Console.WriteLine("What's your eye color?");
        String eyeColor = Console.ReadLine();
        Console.WriteLine("What's your hair color?");
        String hairColor = Console.ReadLine();
        Console.WriteLine("What's your shoe size?");
        String shoeSize = Console.ReadLine();
        Console.WriteLine("What's your favorite color?");
        String favoriteColor = Console.ReadLine();
        Console.WriteLine("What's your favorite movie?");
        String favoriteMovie = Console.ReadLine();
        Console.WriteLine("What's your favorite teacher?");
        String favoriteTeacher = Console.ReadLine();
        Console.WriteLine("What's your favorite class?");
        String favoriteClass = Console.ReadLine();
        Console.WriteLine("What's your favorite holiday?");
        String favoriteHoliday = Console.ReadLine();
        Console.WriteLine("What's your favorite season?");
        String favoriteSeason = Console.ReadLine();
        Console.WriteLine("What's your dream job?");
        String dreamJob = Console.ReadLine();
        Console.WriteLine("How many siblings do you have?");
        String numberOfSiblings = Console.ReadLine();

        Console.WriteLine("My friend's name is " + name + ".");
        Console.WriteLine(name + " is " + age + " years old.");
        Console.WriteLine(name + " has " + eyeColor + " eyes.");
        Console.WriteLine(name + " has " + hairColor + " hair.");
        Console.WriteLine(name + " has a shoesize of " + shoeSize + ".");
        Console.WriteLine(name + "'s favorite color is " + favoriteColor + ".");
        Console.WriteLine(name + "'s favorite movie is " + favoriteMovie + ".");
        Console.WriteLine(name + "'s favorite teacher is " + favoriteTeacher + ".");
        Console.WriteLine(name + "'s favorite class is " + favoriteClass + ".");
        Console.WriteLine(name + "'s favorite holiday is " + favoriteHoliday + ".");
        Console.WriteLine(name + "'s favorite season is " + favoriteSeason + ".");
        Console.WriteLine(name + "'s dream job is " + dreamJob + ".");
        Console.WriteLine(name + "'s age in 5 years is " + ageNumber + ".");
        Console.WriteLine(name + " has " + numberOfSiblings + " siblings.");
    }

}