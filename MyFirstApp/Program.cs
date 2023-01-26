// Rakendus palub kasutajal sisestada oma nimi
// Rakendus tervitab kasutajat nimepidi

Console.WriteLine("Enter your name:"); //Output - väljund
//string - sõne
string userName = Console.ReadLine(); //Input - sisend

Console.WriteLine("Hello, " + userName + "!");

// string interpolation
Console.WriteLine($"Hello, {userName}!");