using fieldValidator;

namespace ClubMemberShipApplication.FieldValidors;

public class UserRegistrationValidator : IFieldValidor {
  const int FirstName_min_Length = 2;
  const int FirstName_max_Length = 200;

  const int LastName_min_Length = 2;
  const int LastName_max_Length = 200;

  delegate bool EmailExistsDel(string emailAddress);

  FieldValidatorDel _fieldValidatorDel = null;
  RequiredValidDel _requiredValiDel = null;
  StringLengthValidDel _stringLengthValidDel = null;
  DateValidDel _dateValidDel = null;
  patternMatchValidDel _patternMatchValidDel = null;
  CompareFieldValidDel _comparefieldValidDel = null;
  EmailExistsDel _emailExistsDel = null;

  string[] _fieldArray = null;

  public string[] FieldArray  {
     get {
       if(_fieldArray is null)
          _fieldArray = new string[Enum.GetValues(typeof(FieldConstants.UserRegistrationField)).Length];
       return _fieldArray;
     }
  }

    public FieldValidatorDel validatorDel => _fieldValidatorDel;

    public string[] fieldArray => throw new NotImplementedException();

    public void InitialiseValidorDelegates()
    {
       _fieldValidatorDel = new FieldValidatorDel(ValidField);

       _requiredValiDel = CommonFieldValidorFunctions.RequiredFieldValidDel;          
       _stringLengthValidDel = CommonFieldValidorFunctions.StringLengthValidDel;
       _dateValidDel = CommonFieldValidorFunctions.DateValidDel;
       _patternMatchValidDel = CommonFieldValidorFunctions.patternMatchValidDel;
       _comparefieldValidDel = CommonFieldValidorFunctions.CompareFieldValidDel;
    }

    public bool ValidField(int fieldIndex, string fieldValue, string[] fieldArray, out string FieldInvalidMessage) {
          FieldInvalidMessage = "";

          FieldConstants.UserRegistrationField userRegistrationField = (FieldConstants.UserRegistrationField)fieldIndex;
          switch(userRegistrationField) {
            case FieldConstants.UserRegistrationField.EmailAddress:
              FieldInvalidMessage = (!_requiredValiDel(fieldValue)) ? $"You must enter a value for field: {Enum.GetName(typeof(FieldConstants.UserRegistrationField), userRegistrationField)} {Environment.NewLine}": "";
               FieldInvalidMessage = (FieldInvalidMessage == "" && !_patternMatchValidDel(fieldValue, CommonReqularExpressionValidationPatterns.Email_Address_RegEx_Pattern)) ? $"You must enter a valid email address": "";

               break;

            case FieldConstants.UserRegistrationField.FirstName:
              FieldInvalidMessage = (!_requiredValiDel(fieldValue)) ? $"You must enter a value for field: {Enum.GetName(typeof(FieldConstants.UserRegistrationField), userRegistrationField)} {Environment.NewLine}": "";
               FieldInvalidMessage = (FieldInvalidMessage == "" && !_stringLengthValidDel(fieldValue, FirstName_min_Length, FirstName_max_Length)) ? $"The length must be between {FirstName_min_Length} and {FirstName_max_Length} {Environment.NewLine}" : "";

               break;

            case FieldConstants.UserRegistrationField.LastName:
              FieldInvalidMessage = (!_requiredValiDel(fieldValue)) ? $"You must enter a value for field: {Enum.GetName(typeof(FieldConstants.UserRegistrationField), userRegistrationField)} {Environment.NewLine}": "";
               FieldInvalidMessage = (FieldInvalidMessage == "" && !_stringLengthValidDel(fieldValue, LastName_min_Length, LastName_max_Length)) ? $"The length must be between {LastName_min_Length} and {LastName_max_Length} {Environment.NewLine}" : "";
               break;

            case FieldConstants.UserRegistrationField.Password:
              FieldInvalidMessage = (!_requiredValiDel(fieldValue)) ? $"You must enter a value for field: {Enum.GetName(typeof(FieldConstants.UserRegistrationField), userRegistrationField)} {Environment.NewLine}": "";
               FieldInvalidMessage = (FieldInvalidMessage == "" && !_patternMatchValidDel(fieldValue, CommonReqularExpressionValidationPatterns.Strong_Password_ReqEx_Pattern)) ? $"You password must be at least 1, 1 small letter, 1 special character and length greater than or equal to 8" : "";

               break;

            case FieldConstants.UserRegistrationField.PasswordCompare:
              FieldInvalidMessage = (!_requiredValiDel(fieldValue)) ? $"You must enter a value for field: {Enum.GetName(typeof(FieldConstants.UserRegistrationField), userRegistrationField)} {Environment.NewLine}": "";
               FieldInvalidMessage = (FieldInvalidMessage == "" && !_comparefieldValidDel(fieldValue, fieldArray[(int)FieldConstants.UserRegistrationField.Password])) ? $"Your entry did not match your password {Environment.NewLine}" : "";

               break;

            case FieldConstants.UserRegistrationField.DateOfBirth:
              FieldInvalidMessage = (!_requiredValiDel(fieldValue)) ? $"You must enter a value for field: {Enum.GetName(typeof(FieldConstants.UserRegistrationField), userRegistrationField)} {Environment.NewLine}": "";
               FieldInvalidMessage = (FieldInvalidMessage == "" && !_dateValidDel(fieldValue, out DateTime validDateTime)) ? $"Your entry did not enter a valid date {Environment.NewLine}" : "";

               break;

            case FieldConstants.UserRegistrationField.PhoneNumber:
              FieldInvalidMessage = (!_requiredValiDel(fieldValue)) ? $"You must enter a value for field: {Enum.GetName(typeof(FieldConstants.UserRegistrationField), userRegistrationField)} {Environment.NewLine}": "";
               FieldInvalidMessage = (FieldInvalidMessage == "" && !_patternMatchValidDel(fieldValue, CommonReqularExpressionValidationPatterns.PhoneNumber_ReqEx_Pattern)) ? $"You should provide a valid PhoneNumber" : "";
               break;

            case FieldConstants.UserRegistrationField.AddressFirstLine:
              FieldInvalidMessage = (!_requiredValiDel(fieldValue)) ? $"You must enter a value for field: {Enum.GetName(typeof(FieldConstants.UserRegistrationField), userRegistrationField)} {Environment.NewLine}": "";
               break;

            case FieldConstants.UserRegistrationField.AddressSecondLine:
              FieldInvalidMessage = (!_requiredValiDel(fieldValue)) ? $"You must enter a value for field: {Enum.GetName(typeof(FieldConstants.UserRegistrationField), userRegistrationField)} {Environment.NewLine}": "";
               break;

            case FieldConstants.UserRegistrationField.AddressCity:
              FieldInvalidMessage = (!_requiredValiDel(fieldValue)) ? $"You must enter a value for field: {Enum.GetName(typeof(FieldConstants.UserRegistrationField), userRegistrationField)} {Environment.NewLine}": "";
               break;


            case FieldConstants.UserRegistrationField.PostCode:
              FieldInvalidMessage = (!_requiredValiDel(fieldValue)) ? $"You must enter a value for field: {Enum.GetName(typeof(FieldConstants.UserRegistrationField), userRegistrationField)} {Environment.NewLine}": "";
               FieldInvalidMessage = (FieldInvalidMessage == "" && !_patternMatchValidDel(fieldValue, CommonReqularExpressionValidationPatterns.UK_PostCode_ReqEx_Pattern)) ? $"You should provide a valid PostCode" : "";
               break;
             default:
               throw new ArgumentException("The field does not exist");

          }

          return (FieldInvalidMessage == "");
    }
}


