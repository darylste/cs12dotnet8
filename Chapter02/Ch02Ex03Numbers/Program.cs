WriteLine("---------------------------------------------------------------------------------------------------------------------------");
WriteLine(format: $"{"Type", -10} {"Byte(s) of memory", -10} {"Min", 43} {"Max", 50}");
WriteLine("---------------------------------------------------------------------------------------------------------------------------");
WriteLine(format: $"{"sbyte", -10} {sizeof(sbyte), -10} {sbyte.MinValue, 50} {sbyte.MaxValue, 50}");
WriteLine(format: $"{"byte", -10} {sizeof(byte), -10} {byte.MinValue, 50} {byte.MaxValue, 50}");
WriteLine(format: $"{"short", -10} {sizeof(short), -10} {short.MinValue, 50} {short.MaxValue, 50}");
WriteLine(format: $"{"ushort", -10} {sizeof(ushort), -10} {ushort.MinValue, 50} {ushort.MaxValue, 50}");
WriteLine(format: $"{"int", -10} {sizeof(int), -10} {int.MinValue, 50} {int.MaxValue, 50}");
WriteLine(format: $"{"uint", -10} {sizeof(uint), -10} {uint.MinValue, 50} {uint.MaxValue, 50}");
WriteLine(format: $"{"long", -10} {sizeof(long), -10} {long.MinValue, 50} {long.MaxValue, 50}");
unsafe
{
WriteLine(format: $"{"Int128", -10} {sizeof(Int128), -10} {Int128.MinValue, 50} {Int128.MaxValue, 50}");
WriteLine(format: $"{"UInt128", -10} {sizeof(UInt128), -10} {UInt128.MinValue, 50} {UInt128.MaxValue, 50}");
WriteLine(format: $"{"Half", -10} {sizeof(Half), -10} {Half.MinValue, 50} {Half.MaxValue, 50}");
}
WriteLine(format: $"{"float", -10} {sizeof(float), -10} {float.MinValue, 50} {float.MaxValue, 50}");
WriteLine(format: $"{"double", -10} {sizeof(double), -10} {double.MinValue, 50} {double.MaxValue, 50}");
WriteLine(format: $"{"decimal", -10} {sizeof(decimal), -10} {decimal.MinValue, 50} {decimal.MaxValue, 50}");
