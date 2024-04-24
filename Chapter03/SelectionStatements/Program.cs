// if statements
string password = "ninja";

if (password.Length < 8) 
{
  WriteLine("Your passwork is too short. Use at least 8 characters.");
}
else 
{
  WriteLine("Your password is strong");
}

// Pattern Matching
object o = 3;
int j = 4;

if (o is int i)
{
  WriteLine($"{i} x {j} = {i * j}");
}
else 
{
  WriteLine("o is not an int so it cannot multiply!");
}

// Switch Statement
int number = Random.Shared.Next(minValue: 1, maxValue: 7);
WriteLine($"My random number is {number}");

switch (number)
{
  case 1:
    WriteLine("One");
    break;
  case 2:
    WriteLine("Two");
    goto case 1;
  case 3:
  case 4:
    WriteLine("Three or Four");
    goto case 1;
  case 5:
    goto A_label;
  default:
    WriteLine("Default");
    break;
}
WriteLine("After Switch Statement");
A_label:
WriteLine($"After A_label");

// Pattern matching in a switch statement

var animals = new Animal?[]
{
  new Cat {Name = "Karen", Born = new(year: 2022, month: 8, day: 23), Legs = 4, isDomestic = true},
  null,
  new Cat {Name = "Mufasa", Born = new(year: 1994, month: 6, day: 12)},
  new Spider {Name = "Sid Vicious", Born = DateTime.Today, isPoisonous = true},
  new Spider {Name = "Captain Furry", Born = DateTime.Today}
};

foreach (Animal? animal in animals)
{
  string message;

  switch (animal)
  {
    case Cat fourLeggedCat when fourLeggedCat.Legs == 4:
      message = $"The cat named {fourLeggedCat} has four legs.";
      break;
    case Cat wildCat when wildCat.isDomestic == false:
      message = $"The non-domestic cat is named {wildCat.Name}.";
      break;
    case Cat cat:
      message = $"The cat is named {cat.Name}.";
      break;
    default:
      message = $"{animal.Name} is a {animal.GetType().Name}.";
      break;
    case Spider spider when spider.isPoisonous:
      message = $"The {spider.Name} spider is poisonous. Run!";
      break;
    case null:
      message = "The animal is null";
      break;
  }
  WriteLine($"switch statement: {message}");
}