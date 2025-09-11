// C# Has Ints, Uints, Floats, Doubles

// Underscores In Number Literals Can Be Used For Visual Clarity
int clearNumber = 100_000_000; // Equivalent To 100000000

// C# Features Hex & Binary Prefixes (0b & 0x)
// Print In Binary & Hex With :N0 & :X Suffixes
Console.WriteLine("Hex 13: {13:X} & Binary 13: {13:N0}");

// C# Has A Default sizeof() method & .MaxValue + .MinValue default type members
Console.WriteLine($"Sizeof Int: {sizeof(int)}, Min Value: {int.MinValue}, Max Value: {int.MaxValue}"); // $ Prefix For In Place Variable Placement

// Doubles Store More Precise Values Than Floats Yet Still Are Unsafe To Compare Alongside Floats
// Both Are Stored In Binary Decimals 

#region Decimal Types -> Store Decimals With More Enabled Precisions
// Decimals Are Integer Values That Get Bit Shifted Under The Hood
// The M Suffix Creates Decimal Lvalues
// Exact Comparisons Should Not Be Done Without Using Decimal Types

decimal a = 0.1M;
decimal b = 0.2M;
decimal c = 0.3M;

if (a + b == c)
{
    Console.WriteLine("The Decimal Comparison Holds True");
}

#endregion

#region Special Types -> All Members Of Numeric Datatypes
// NaN -> Not A Number
// Epsilon -> Smallest Possible Number That Can Be Stored
// PositiveInfinity / NegativeInfinity -> Used For Comparison

Console.WriteLine("Epsilon Value: {0}", double.Epsilon);
Console.WriteLine("NaN Value: {0}", double.NaN);
Console.WriteLine("+ / 0 == inf?: {0}", double.PositiveInfinity == (1.0 / 0.0));

#endregion

#region C# Has Unsafe Types That Can Only Be Compiled In Unsafe Code Blocks With A Specific Option Enabled

// System.Half -> 2 Byte Real Number
// System.Int128 -> 128 Bytes

#endregion

// The Object Keyword Enables Inherited Typing -> Any Type Can Be Stored
// The Object Keyword Leads To Messy Code & Slower Performance