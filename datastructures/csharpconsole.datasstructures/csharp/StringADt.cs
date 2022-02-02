using System.Text;

namespace csharp;

public static class Extensions {
  public static  string ToPostfix( string prefix) {
      StringBuilder postfix = new();
      Stack<char> stack = new();

      foreach(char c in prefix){ 
          if(isOperand(c)){
             postfix.Append(c);
          } else{
             if(Precedence(stack.Peek()) > Precedence(c)){
                 postfix.Append(stack.Pop());
             } else{
                postfix.Append(c);
             }
          }
      }
       
      while(stack.Count != 0){
         postfix.Append(stack.Pop());
      }
       return postfix.ToString();
  }

  public static bool isOperand( char x) {
    if( x== '+' || x == '-' || x=='/' || x=='*' ){
       return false;
    }else {
       return true;
    }
    }

    public static int Precedence(char c){
        if(c == '+' || c == '-') return 2;
        else if(c == '*' || c == '/') return 3;
        else return 0;
    }
}
