namespace Packt.Shared;
// This file simulates an auto-generated class.
public partial class Person
{
  #region Properties
  public string Origin
  {
    get
    {
      return string.Format($"{Name} was born on {HomePlanet}");
    }
  }

  public string Greeting => $"{Name} says 'Hello!";

  public int Age => DateTime.Today.Year - Born.Year;

  public string? FavoriteIceCream { get; set; }
  private string? _favoritePrimaryColor;
  public string? FavoritePrimaryColor
  {
    get
    {
      return _favoritePrimaryColor;
    }
    set
    {
      switch (value?.ToLower())
      {
        case "red":
        case "green":
        case "blue":
          _favoritePrimaryColor = value;
          break;
        default:
          throw new ArgumentException(
            $"{value} is not a primary color." +
            "Choose from: red, green, blue."
          );
      }
    }
  }

  private WondersOfheAncientWorld _favoriteAncientWonder;

  public WondersOfheAncientWorld FavoriteAncientWonder
  {
    get
    {
      return _favoriteAncientWonder;
    }
    set
    {
      string wonderName = value.ToString();

      if (wonderName.Contains(','))
      {
        throw new ArgumentException(
          message: "Favorite ancient wonder can only have a single enum value.",
          paramName: nameof(FavoriteAncientWonder));
      }
      if (!Enum.IsDefined(typeof(WondersOfheAncientWorld), value))
      {
        throw new ArgumentException(
          $"{value} is not a member of the WondersOfTheAncientWorld enum.",
          paramName: nameof(FavoriteAncientWonder));
      }

      _favoriteAncientWonder = value;
    }
  }
  #endregion

  #region Indexers

  public Person this[int index]
  {
    get
    {
      return Children[index];
    }
    set
    {
      Children[index] = value;
    }
  }

  public Person this[string name]
  {
    get
    {
      return Children.Find(p => p.Name == name);
    }
  }

  #endregion
}
