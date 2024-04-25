namespace Packt.Shared;

public partial class Person : object
{
  #region Fields

  public string? Name;
  public DateTimeOffset Born;
  // Moved to PersonAutoGen.cs
  // public WondersOfheAncientWorld FavoriteAncientWonder;
  public WondersOfheAncientWorld BucketList;
  public List<Person> Children = new();
  public const string Species = "Homo Sapiens";
  public readonly string HomePlanet = "Earth";
  public readonly DateTime Instantiated;

  #endregion

  #region  Constructors

  public Person()
  {
    Name = "Unknown";
    Instantiated = DateTime.Now;
  }

  public Person(string initialName, string homePlanet)
  {
    Name = initialName;
    HomePlanet = homePlanet;
    Instantiated = DateTime.Now;
  }

  #endregion

  #region Methods

  public void WriteToConsole()
  {
    WriteLine($"{Name} was born on a {Born:dddd}.");
  }

  public string GetOrigin()
  {
    return $"{Name} was born on {HomePlanet}.";
  }

  public string SayHello()
  {
    return "Hello";
  }
  public string SayHello(string name)
  {
    return $"Hello {name}";
  }

  public string OptionalPerameters(
    int count,
    string command = "Run!",
    double number = 0.0,
    bool active = true
    )
  {
    return string.Format("command is {0}, number is {1}, active is {2}",
      command,
      number,
      active);
  }

  public void PassingParameters(int w, in int x, ref int y, out int z)
  {
    // out params cannot have a default, the must be initialized in the method
    z = 100;

    // in params are read-only
    w++;
    // x++ // will give compiler error as read-only
    y++;
    z++;

    WriteLine($"In the method w={w}, x={x}, y={y}, z={z}");
  }

  public (string Name, int Number) GetFruit()
  {
    return (Name: "Apples", Number: 5);
  }

  // Deconstructors
  public void Deconstruct(
    out string? name,
    out DateTimeOffset dob)
  {
    name = Name;
    dob = Born;
  }

  public void Deconstruct(
    out string? name,
    out DateTimeOffset dob,
    out WondersOfheAncientWorld fav)
  {
    name = Name;
    dob = Born;
    fav = FavoriteAncientWonder;
  }

  // Method with a local function
  public static int Factorial(int number)
  {
    if (number < 0)
    {
      throw new ArgumentException(
        $"{nameof(number)} cannot be less than zero.");
    }
    return localFactorial(number);

    int localFactorial(int localNumber)
    {
      if (localNumber == 0) return 1;
      return localNumber * localFactorial(localNumber - 1);
    }
  }

  #endregion
}
