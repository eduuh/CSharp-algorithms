//[SimpleJob(RuntimeMoniker.Net48)]
//[SimpleJob(RuntimeMoniker.Net50)]

namespace BenchmarkDotNet;
[SimpleJob(RuntimeMoniker.Net60, baseline: true)]
[MemoryDiagnoser]
public class Demo{


  [Benchmark]
  //[Benchmark(Baseline= true)]
   public string GetFullStringNormal() {
      string output = "";

       for (int i = 0; i < 100; i++)
       {
           output +=i;
       }
       return output;
   }

  [Benchmark]
   public string GetFullStringWithStringBuilder() {
       StringBuilder output = new StringBuilder();
       for (int i = 0; i < 100; i++)
       {
           output.Append(i);
       }
       return output.ToString();
   }

  [Benchmark]
  public void swapwithInts() {
      int x = 3 ;
      int y  = 4;
      int temp = x;
      x = y;
      y = temp;
  }

  [Benchmark]
  public void swapWithTuples(){
      int x = 3; int y = 4;
      (x, y) = (y, x);
  }
}
