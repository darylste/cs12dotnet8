using static System.Console;

partial class Program
{
  static void WhatsMyNamespace()
  {
    WriteLine($"Namespace of Program Class: {typeof(Program).Namespace ?? "null"}");
  }
}