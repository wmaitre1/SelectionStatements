// See https://aka.ms/new-console-template for more information

    Console.WriteLine("Welcome to the game and good luck!");
    Console.WriteLine("What is the upper limit for the range of the number?");

    var userResponse = Console.ReadLine();

    var upperLimit = int.Parse(userResponse);

    var random = new Random();
    var number = random.Next(3, upperLimit);

    Console.WriteLine("Lets begin and please input your guess");

    var guess = int.Parse(Console.ReadLine());

    if (guess > number)
    {
        Console.WriteLine("you have guessed too high, and need to guess again");
    }
    else if (guess < number)
    {
        Console.WriteLine($"Nevermind too low.  Please try again!");
    }
