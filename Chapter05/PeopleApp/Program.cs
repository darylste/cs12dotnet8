using System.IO.Compression;
using Packt.Shared;

ConfigureConsole();

// Alternatives:
// ConfigureConsole(useComputerCulture: true); // Use your culture
// ConfigureConsole(culture: "fr-FR"); // Use French culture

Person bob = new();
bob.Name = "Bob Smith";
bob.Born = new DateTimeOffset(1965, 12, 22, 16, 28, 0, TimeSpan.FromHours(-5));
bob.FavoriteAncientWonder = WondersOfheAncientWorld.StatueOfZuesAtOlympia;
bob.BucketList = WondersOfheAncientWorld.HangingGardensOfBabylon | WondersOfheAncientWorld.MausoleumAtHalicarnassus;


// // Compatible with all versions.
// Person alfred = new Person();
// alfred.Name = "Alfred";
// bob.Children.Add(alfred);

// // Compatible with C# 3 or later.
// bob.Children.Add(new Person { Name = "Bella" });

// // Compatible with C# 9 or later.
// bob.Children.Add(new() { Name = "Zoe" });

// WriteLine(format: "{0} was born on {1:D}.", arg0: bob.Name, arg1: bob.Born);
// WriteLine(format: "{0}'s favorite wonder is {1}. Its integer is {2}.", arg0: bob.Name, arg1: bob.FavoriteAncientWonder,
// arg2: (int)bob.FavoriteAncientWonder);
// WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}.");
// WriteLine($"{bob.Name} has {bob.Children.Count} children.");
// for (int i = 0; i < bob.Children.Count; i++)
// {
//   WriteLine($"> {bob.Children[i].Name}");
// }
// Person alice = new()
// {
//   Name = "Alice Jones",
//   Born = new DateTimeOffset(1998, 3, 7, 16, 28, 0, TimeSpan.Zero)
// };

// WriteLine(format: "{0} was born on {1:d}", arg0: alice.Name, arg1: alice.Born);

// BankAccount.InterestRate = 0.012M;

// BankAccount jonesAccount = new();
// jonesAccount.AccountName = "Mrs. Jones";
// jonesAccount.Balance = 2400;
// WriteLine("{0} earned {1:C} interest.",
//   arg0: jonesAccount.AccountName,
//   arg1: jonesAccount.Balance * BankAccount.InterestRate);

// BankAccount gerrierAccount = new();
// gerrierAccount.AccountName = "Ms. Gerrier";
// gerrierAccount.Balance = 98;
// WriteLine("{0} earned {1:C} interest.",
//   arg0: gerrierAccount.AccountName,
//   arg1: gerrierAccount.Balance * BankAccount.InterestRate);

// WriteLine($"{bob.Name} is a {Person.Species}.");
// WriteLine($"{bob.Name} was born on {bob.HomePlanet}.");

// Book book = new("978-1803237800", "C# 12 and .NET 8 - Modern Cross-Platform Development Fundamentals")
// {
//   Author = "Mark J. Price",
//   PageCount = 821
// };

// WriteLine("{0}: {1} written by {2} has {3:N0} pages.",
//   book.Isbn,
//   book.Title,
//   book.Author,
//   book.PageCount);

// Person blankPerson = new();

// WriteLine("{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
//   arg0: blankPerson.Name,
//   arg1: blankPerson.HomePlanet,
//   arg2: blankPerson.Instantiated);

// Person gunny = new(initialName: "Gunny", homePlanet: "Mars");

// WriteLine("{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
//   arg0: gunny.Name,
//   arg1: gunny.HomePlanet,
//   arg2: gunny.Instantiated);

// bob.WriteToConsole();
// WriteLine(bob.GetOrigin());

// WriteLine(bob.SayHello(bob.Name));

// WriteLine(bob.OptionalPerameters(count: 1, "Jump!", 20.5, false));

// int a = 10;
// int b = 20;
// int c = 30;
// int d = 40;

// WriteLine($"Before: a={a}, b={b}, c={c}, d={d}");

// bob.PassingParameters(a, b, ref c, out d);

// WriteLine($"After: a={a}, b={b}, c={c}, d={d}");

// var (Name, Number) = bob.GetFruit();
// WriteLine($"{Name}, {Number} there are.");

// var thing1 = ("Neville", 4);
// WriteLine($"{thing1.Item1} has {thing1.Item2} children.");

// var thing2 = (bob.Name, bob.Children.Count);
// WriteLine($"{thing2.Name} has {thing2.Count} children.");

// var (name1, dob1) = bob;
// WriteLine($"Deconstructed person: {name1}, {dob1}");

// var (name2, dob2, fav2) = bob;
// WriteLine($"Deconstructed person: {name2}, {dob2}, {fav2}");

// Change to -1 to make the exception handling code execute.
// int number = -5;

// try
// {
//   WriteLine($"{number}! is {Person.Factorial(number)}");
// }
// catch (Exception ex)
// {
//   WriteLine($"{ex.GetType()} says: {ex.Message} number was {number}.");
// }

Person sam = new()
{
  Name = "Sam",
  Born = new(1969, 6, 25, 0, 0, 0, TimeSpan.Zero)
};

WriteLine(sam.Origin);
WriteLine(sam.Greeting);
WriteLine(sam.Age);

sam.FavoriteIceCream = "Chocolate Fudge";
WriteLine($"Sam's favourite ice-cream flavor is {sam.FavoriteIceCream}");

string color = "Red";

try
{
  sam.FavoritePrimaryColor = color;
  WriteLine($"Sam's favourite color is {sam.FavoritePrimaryColor}");
}
catch (Exception ex)
{
  WriteLine("Tried to set {0} to '{1}': {2}", nameof(sam.FavoritePrimaryColor), color, ex.Message);
}

sam.Children.Add(new() { Name = "Charlie", Born = new(2010, 3, 18, 0, 0, 0, TimeSpan.Zero) });

sam.Children.Add(new() { Name = "Ella", Born = new(2020, 12, 24, 0, 0, 0, TimeSpan.Zero) });

// Get using children list
WriteLine($"Sam's first child is {sam.Children[0].Name}");
WriteLine($"Sam's second child is {sam.Children[1].Name}");

// Get using the string indexer
WriteLine($"Sam's child named Ella is {sam["Ella"].Age} years old.");

// An array containing a mix of passenger types,
Passenger[] passengers = {
  new FirstClassPassenger {AirMiles = 1_419, Name = "Suman"},
  new FirstClassPassenger {AirMiles = 16_562, Name = "Lucy"},
  new BusinessClassPassenger {Name = "Janice"},
  new CoachClassPassenger { CarryOnKG = 25.7, Name = "Dave"},
  new CoachClassPassenger { CarryOnKG = 0, Name = "Amit"},
};

foreach (Passenger passenger in passengers)
{
  decimal flightCost = passenger switch
  {
    FirstClassPassenger p when p.AirMiles > 35_000 => 1_500M,
    FirstClassPassenger p when p.AirMiles > 15_000 => 1_750M,
    FirstClassPassenger _ => 2_000M,
    BusinessClassPassenger _ => 1_000M,
    CoachClassPassenger p when p.CarryOnKG < 10.0 => 500M,
    CoachClassPassenger _ => 650M,
    _ => 800M
  };
  WriteLine($"Flight costs {flightCost:C} for {passenger}");
}

ImmutablePerson jeff = new()
{
  FirstName = "Jeff",
  LastName = "Winger"
};

ImmutableVehicle car = new()
{
  Brand = "Mazda MX-5 RF",
  Color = "Soul Red Crystal Metallic",
  Wheels = 4
};
ImmutableVehicle repaintedCar = car with
{
  Color = "Polymetal Grey Metallic"
};
WriteLine($"Original car color was {car.Color}");
WriteLine($"New car color is {repaintedCar.Color}");

AnimalClass ac1 = new() { Name = "Rex" };
AnimalClass ac2 = new() { Name = "Rex" };

WriteLine($"ac1 == ac2: {ac1 == ac2}");

AnimalRecord ar1 = new() { Name = "Rex" };
AnimalRecord ar2 = new() { Name = "Rex" };

WriteLine($"ar1 == ar2: {ar1 == ar2}");

ImmutableAnimal fred = new("Fred", "Labrador");
var (who, what) = fred; // Calls the deconstructor
WriteLine($"{who} is a {what}.");

Headset vp = new("Apple", "Vision Pro");
WriteLine($"{vp.ProductName} is made by {vp.Manufacturer}.");

Headset holo = new();
WriteLine($"{holo.ProductName} is made by {holo.Manufacturer}.");

Headset mq = new() { Manufacturer = "Meta", ProductName = "Quest 3" };
WriteLine($"{mq.ProductName} is made by {mq.ProductName}.");