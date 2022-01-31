//var results = BenchmarkRunner.Run<Demo>();
//var results = BenchmarkRunner.Run<CSharpConcepts>();


//pass by value

int i = 10;
Console.WriteLine($"Value of i before increment is: {i}");
CSharpConcepts.incrementPassByValue(i);
Console.WriteLine($"Value of i before increment is: {i}");

//pass by reference
Console.WriteLine($"Value of i before increment is: {i}");
CSharpConcepts.incrementPassReference(ref i);
Console.WriteLine($"Value of i before increment by reference is: {i}");


//Variable typess
var bulb = new Bulb();
bulb.size = Bulb.BulbSize.Medium;
var bulbe = new Bulb();
Console.WriteLine("Bulb Count are {0}", Bulb.BulbCount);
Console.WriteLine("Bulb is On", bulb.IsOn);

//Method types
//1. Class Methods
//2. Instant Methods
//3. Constructors


//Access Modifiers
//1. Default Modifier: has visibility to the package
//2. Private Modifier: has visibliity within the package
//3. Public  Modifier; has visibility to all the classes
//4. Protected Modifier has visibliyt within it own class and the subclasses in own class:
//5. Internal modifier: has visibility  access limited to the current assembly
//6. Protected & internal modifier together has visibility either form derived classes of form the same assembly
//



// Relatioships
// Dependency: 
// Assocation: Aggregation , Composition
// Iheritance = shown in created of AdvancedBulb



// Abstract class & Method
// abstract method are method which does not have a definition. declared with abtract keyword
// A class with abstract method need to defined as abstract. We cannot create obbject of abstract clasese

double width = 2, length = 3;
Shape rectangle = new Rectangle(width, length);
WriteLine($"rectangle Width is: {width} and length is {length}");
WriteLine($"rectangle Area is: {rectangle.area()} and Perimeter is {rectangle.Perimeter()}");


// Nested classes
// why 
// It is a way of logically grouping clasesd  that are only used in one place.
// it increases encapsulation
// it can lead to more readable and maitainable code

public class OuterClass {
    private class NestedClass {
    }
}

// LinkedList and Tree have Nodes by their nodes are different. therefore its important to declare their corresponding nodes class inside their own class to prevent name conflict and increase encapusualation

public class LinkedList {
   private class Node {
       internal int value;
       internal Node next;
   }

   private Node head;
}

public class Tree {
   private class Node {
      private int value;
      private Node lChild;
      private Node rChild;
   }
   private Node root;
}

// Enums : restricts a variable to have one of the few predifined values

//b.size = Bulb.BulbSize.Medium;
//


// Constant
// constants are defined by using static modifier in combination with the final modifier
// The final modifier indicate that the value of this field cannod be changed.
// The static modifer indicates taht there will be only one instance of the variable and is a class variable

