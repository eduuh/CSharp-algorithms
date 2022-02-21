

Console.WriteLine(findmax(3,4,6));

static int findmax(int a , int b , int c) {
   int max = a;

   if(b > max) {
     max = b;
   }

   if(c > max) {
      max = c;
   }
   return c;
}
