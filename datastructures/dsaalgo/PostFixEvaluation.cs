
using System.Collections.Generic;
using System;

namespace dsaalgo;

public static class Postfix {

  public static int add(int a, int b){
      return a + b;
  }

  public static int subtract(int a, int b){
      return a - b;
  }

  public static int divide(int a, int b){
      return a / b;
  }

  public static int multiply(int a, int b){
      return a * b;
  }

  public static void matchOperation(Stack<int> stack, char operation){
            if(stack.Count == 2){
              int operanda = stack.Pop();
              int operandb = stack.Pop();
              if(operation == '/') {
                 stack.Push(divide(operandb, operanda));
              }else if(operation == '*' ){
                   stack.Push(multiply(operandb, operandb));
              } else if(operation == '+'){
                  stack.Push(operandb + operanda);
              } else if(operation == '-'){
                  stack.Push(divide(operanda, operandb));
              }
  }
  }
  //string prefix2 = "1+2+6";
  public static int PostfixEvaluation(string Postfix) {
      Stack<int> stack = new(); 
      char operation = 'j';
      foreach(var c in Postfix){
          if(Extensions.isOperand(c)){
             stack.Push((int)Char.GetNumericValue(c));
            }

              matchOperation(stack, operation);
              operation = c;     
          }
         return stack.Pop();
      }
  }

