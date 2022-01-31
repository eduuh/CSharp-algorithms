namespace BenchmarkDotNet;

public interface BulbInterface {
   void turnOn();
   void turnOff();
   bool IsOn {get;}
}

internal class Bulb : BulbInterface {

   internal enum BulbSize {Small, Medium, Large}
   internal BulbSize size;
    //class variable
   private static int TotalBulbCount = 0;

    // instance variable
   private bool isOn = false;

   public Bulb()
   {
       TotalBulbCount++;
   }

   //class Method
   public static int BulbCount {
      get {
         return TotalBulbCount;
      }
   }

   //instance Method
   public virtual void turnOn(){
      isOn = true;
   }

   //instance Method
   public virtual void turnOff(){
      isOn = false;
   }


   //instance Method
   public virtual bool IsOn {
      get {
          return isOn;
      }
   }

}


internal class AdvancedBulb : Bulb {
   //instance variable
   private int intesity;

   public virtual int Intersity {
       get{ return Intersity;}
       set { intesity = value;}
   }

}
