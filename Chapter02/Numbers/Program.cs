// An unassigned integer is a positive whole number or 0
// uint naturalNumber = 23;
// An integer is a negative or positve whole number or 0
// int integerNumber = -23;
// A float is a single-precision floating-point number
// The F or f suffix makes the value a float literal
// var realNumber = 2.3f;

// A double is a double precission floating point number
// double is the default for a number value with decimal point
// double anotherRealNumber = 2.3;

// Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
// Console.WriteLine($"doubes uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
// Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range of {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");

// Console.WriteLine("Using doubles:");
// double a = 0.1;
// double b = 0.2;
// if(a + b == 0.3)
// {
//   Console.WriteLine($"{a} + {b} equals {0.3}");
// }
// else 
// {
//   Console.WriteLine($"{a} + {b} does NOT equal {0.3}");
// }

// Console.WriteLine("Using decimals:");
// decimal c = 0.1M; // M suffix means a decimal literal value
// decimal d = 0.2M;
// if(c + d == 0.3M)
// {
//   Console.WriteLine($"{c} + {d} equals {0.3M}");
// }
// else 
// {
//   Console.WriteLine($"{c} + {d} does NOT equal {0.3M}");
// }

unsafe
{
  Console.WriteLine($"Half uses {sizeof(Half)} bytes and can store numbers in the rage of {Half.MinValue:N0} to {Half.MaxValue:N0}.");
  Console.WriteLine($"Int128 uses {sizeof(Int128)} bytes and can store numbers in the rage of {Int128.MinValue:N0} to {Int128.MaxValue:N0}.");
}