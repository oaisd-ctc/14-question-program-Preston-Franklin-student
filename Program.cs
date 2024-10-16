using System;

public class Program
{
    static string name;
    static string age;
    static string eyeColor;
    static string hairColor;
    static string shoeSize;
    static string favoriteColor;
    static string favoriteTVorMovie;
    static string favoriteTeacher;
    static string favoriteClass;
    static string favoriteHoliday;
    static string favoriteSeason;
    static string dreamJob;
    static string numberOfSiblings;
    static int ageIn5Years;
    public static void Main(string[] args)
    {
        AskName();
        AskAge();
        AskEyeColor();
        AskHairColor();
        AskShoeSize();
        AskFavoriteColor();
        AskFavoriteTvShow();
        AskFavoriteTeacher();
        AskFavoriteClass();
        AskFavoriteHoliday();
        AskFavoriteSeason();
        AskDreamJob();
        CalculateAgeIn5Years(age);
        AskNumberOfSiblings();
        DisplaySummaryMessage();

    }

    public static void AskName(){
        Console.WriteLine("What's your name?");
        name = Console.ReadLine();
    }
    public static void AskAge(){
        Console.WriteLine("What's your age?");
        age = Console.ReadLine();
    }
    public static void AskEyeColor(){
        Console.WriteLine("What's your eye color?");
        eyeColor = Console.ReadLine();
    }
    public static void AskHairColor(){
        Console.WriteLine("What's your hair color?");
        hairColor = Console.ReadLine();
    }
    public static void AskShoeSize(){
        Console.WriteLine("What's your shoe size?");
        shoeSize = Console.ReadLine();
    }
    public static void AskFavoriteColor(){
        Console.WriteLine("What's your favorite color?");
        favoriteColor = Console.ReadLine();
    }
    public static void AskFavoriteTvShow(){
        Console.WriteLine("What's your favorite TV show?");
        favoriteTVorMovie = Console.ReadLine();
    }
    public static void AskFavoriteTeacher(){
        Console.WriteLine("What's your favorite teacher");
        favoriteTeacher = Console.ReadLine();
    }
    public static void AskFavoriteClass(){
        Console.WriteLine("What's your favorite class");
        favoriteClass = Console.ReadLine();
    }
    public static void AskFavoriteHoliday(){
        Console.WriteLine("What's your favorite holiday?");
        favoriteHoliday = Console.ReadLine();
    }
    public static void AskFavoriteSeason(){
        Console.WriteLine("What's your favorite season?");
        favoriteSeason = Console.ReadLine();
    }
    public static void AskDreamJob(){
        Console.WriteLine("What's your dream job?");
        dreamJob = Console.ReadLine();
    }
    public static void CalculateAgeIn5Years(string age){
        ageIn5Years = Int32.Parse(age);
        ageIn5Years = ageIn5Years + 5;
    }
    public static void AskNumberOfSiblings(){
        Console.WriteLine("How many siblings do you have?");
        numberOfSiblings = Console.ReadLine();
    }
    public static void DisplaySummaryMessage(){
        Console.WriteLine("My friend's name is " + name + ".");
        Console.WriteLine(name + " is " + age + " years old.");
        Console.WriteLine(name + " has " + eyeColor + " eyes.");
        Console.WriteLine(name + " has " + hairColor + " hair.");
        Console.WriteLine(name + " has a shoesize of " + shoeSize + ".");
        Console.WriteLine(name + "'s favorite color is " + favoriteColor + ".");
        Console.WriteLine(name + "'s favorite movie is " + favoriteTVorMovie + ".");
        Console.WriteLine(name + "'s favorite teacher is " + favoriteTeacher + ".");
        Console.WriteLine(name + "'s favorite class is " + favoriteClass + ".");
        Console.WriteLine(name + "'s favorite holiday is " + favoriteHoliday + ".");
        Console.WriteLine(name + "'s favorite season is " + favoriteSeason + ".");
        Console.WriteLine(name + "'s dream job is " + dreamJob + ".");
        Console.WriteLine(name + "'s age in 5 years is " + ageIn5Years + ".");
        Console.WriteLine(name + " has " + numberOfSiblings + " siblings.");
    }
}