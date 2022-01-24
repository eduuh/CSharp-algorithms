using System.Text.RegularExpressions;

namespace fieldValidator;

public delegate bool RequiredFieldValidDel(string field); //form field not left empty
public delegate bool StringLengthValidDel(string field, int min, int max); // length
public delegate bool DateValidDel(string fieldval, out DateTime validdate);
public delegate bool PatternMatchValidDel(string fieldval, string pattern);
public delegate bool CompareFieldsValidDel(string fieldval, string fielvalCompare);

public class CommonFieldValidorFunctions
{
   private static RequiredFieldValidDel _requireValidDel = null;
   private static StringLengthValidDel _stringLengthValidDel = null;
   private static DateValidDel _dateValidDel = null;
   private static PatternMatchValidDel _patternMatchValidDel = null;
   private static CompareFieldsValidDel _compareFieldValidDel = null;


   public static RequiredFieldValidDel RequiredFieldValidDel {
      get {
          if(_requireValidDel is null)
            _requireValidDel = new RequiredFieldValidDel(RequiredFieldValid);
          return _requireValidDel;
      }
   }

   public static StringLengthValidDel StringLengthValidDel {
      get {
          if(_stringLengthValidDel is null)
            _stringLengthValidDel = new StringLengthValidDel(StringFieldLengthValid);
          return _stringLengthValidDel;
      }
   }

   public static PatternMatchValidDel patternMatchValidDel {
      get {
          if(_patternMatchValidDel is null)
            _patternMatchValidDel = new PatternMatchValidDel(FieldPatternValid);
          return _patternMatchValidDel;
      }
   }

   public static DateValidDel DateValidDel {
      get {
          if(_dateValidDel is null)
            _dateValidDel = new DateValidDel(DateFieldValid);
          return _dateValidDel;
      }
   }

   public static CompareFieldsValidDel  CompareFieldValidDel {
      get {
          if(_compareFieldValidDel is null)
            _compareFieldValidDel = new CompareFieldsValidDel(FieldComparisonValid);
          return _compareFieldValidDel;
      }
   }

  private static bool RequiredFieldValid(string fieldval) {
     if(!string.IsNullOrEmpty(fieldval))
       return true;
     return false;
  }

  private static bool StringFieldLengthValid(string fieldval, int min, int max) {
      if(fieldval.Length >= min && fieldval.Length <= max)
         return true;
      return false;
  }

  private static bool DateFieldValid(string dateTime, out DateTime validDateTime){
     if(DateTime.TryParse(dateTime, out validDateTime))
       return true;
     return false;
  }

  private static bool FieldPatternValid(string fieldval, string reqularExpression) {
     Regex regex = new Regex(reqularExpression);
     if(regex.IsMatch(fieldval))
       return true;
     return false;

  }

  private static bool FieldComparisonValid(string field1, string field2){
    if(field1.Equals(field2))
      return true;
    return false;
  }

}
