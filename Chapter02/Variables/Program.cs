using System.Xml;
// object height = 1.88; // storing a double in an object.
// object name = "Daryl"; // storing a string in an object.
// Console.WriteLine($"{name} is {height} metres tall.");

// // int lenght1 = name.Length; // this gives a compile error.
// int length2 = ((string)name).Length; // cast name to string.
// Console.WriteLine($"{name} has {length2} characters.");

// dynamic something;

// // storing an array of ints in a dynamic object.
// // An array of any type has a Lenght property.
// something = new[] { 3, 5, 7 };

// // storing an int in a dynamic object.
// // int does not have a Lenght property.
// // something = 12;

// // storing a string in a dynamic object.
// // string does have an Length property.
// // something = "Daryl";

// // This compiles but might throw an exeption at run-time.
// Console.WriteLine($"The length of someting is {something.Length}");

// // Output the type of 'something'
// Console.WriteLine($"something is a {something.GetType()}");

// var population = 67_000_000;
// var weight = 1.88;
// var price = 4.99M;
// var fruit = "Apples";
// var letter = 'Z';
// var happy = true;

// // Good use of var because it avoids the repeated type as shown in the more verbose second satement
// var m11 = new XmlDocument();
// XmlDocument xm12 = new XmlDocument();

// // Bad use of var because we cannot tell the type, so we should use a specific type declaration as shown ins the second statement
// var file1 = File.CreateText("somthing1.txt");
// StreamWriter file2 = File.CreateText("something2.txt");

Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string)}");

int number = 13;
Console.WriteLine($"number is set to {number}");
number = default;
Console.WriteLine($"number reset to its default: {number}");
