using System.Collections;
using System.Collections.Concurrent;

namespace Dictionaries;

public class Dictionaries {

   public Dictionaries()
   {
      var dictionary = new Dictionary<string, string>();
      dictionary["name"] = "Edwin";

      var name = dictionary["name"];
   }

}

public class HashTables {

   public HashTables()
   {
       var hashtable  = new Hashtable();
       hashtable["name"] = "Nick";
       hashtable["age"] = "Nick";
       var age = hashtable["age"];
   }
}


public class ConcurrentDisctionary {
   public ConcurrentDisctionary () {
      var concurrentDictionary = new ConcurrentDictionary<string,string>();
      concurrentDictionary["name"] = "Edwin";
      var name = concurrentDictionary["name"];
   }
}

