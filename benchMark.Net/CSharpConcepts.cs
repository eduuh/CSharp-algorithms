namespace BenchmarkDotNet;

[SimpleJob(RuntimeMoniker.Net60, baseline: true)]
[MemoryDiagnoser]
public class CSharpConcepts
{
    [Benchmark]
    public int vaiableExamples()
    {
        int var1, var2, var3;
        var1 = 100;
        var2 = 200;
        var3 = var1 + var2;
        WriteLine($"Adding {var1} and {var2} will give {var3}");
        return var3;
    }
    [Benchmark]
    public void PrimitiveTypes()
    {
        sbyte maxByte = sbyte.MaxValue;
        sbyte minByte = sbyte.MinValue;
        short maxShort = short.MaxValue;
        short minShort = short.MinValue;
        int maxInteger = int.MaxValue;
        int minInteger = int.MinValue;
        long maxLong = long.MaxValue;
        long minLong = long.MinValue;
        float maxFloat = float.MaxValue;
        float minFloat = float.Epsilon;
        double maxDouble = double.MaxValue;

        double minDouble = double.Epsilon;
        Console.WriteLine("Range of byte :: " + minByte + " to " + maxByte + ".");
        Console.WriteLine("Range of short :: " + minShort + " to " + maxShort + ".");
        Console.WriteLine("Range of integer :: " + minInteger + " to " + maxInteger + ".");
        Console.WriteLine("Range of long :: " + minLong + " to " + maxLong + ".");
        Console.WriteLine("Range of float :: " + minFloat + " to " + maxFloat + ".");
        Console.WriteLine("Range of double :: " + minDouble + " to " + maxDouble + ".");
    }

   public static void incrementPassByValue(int var){
      var ++;
   }

   public static void incrementPassReference( ref int var){
      var ++;
   }
}
