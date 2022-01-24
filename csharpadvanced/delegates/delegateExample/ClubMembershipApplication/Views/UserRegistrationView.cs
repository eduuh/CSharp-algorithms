using ClubMemberShipApplication.Data;
using ClubMemberShipApplication.FieldValidors;

namespace ClubMemberShipApplication.Views;

public class UserRegistrationView : IView
{
    IFieldValidor _fiedvalidator = null;
    public IFieldValidor FieldValidator  { get => _fiedvalidator ;}


    IRegister _register = null;


    public UserRegistrationView(IRegister register , IFieldValidor fieldvalidator) {
       _fiedvalidator = fieldvalidator;
       _register = register;
    }

    public void RunView()
    {
        CommonOutputText.WriteMainHeading(); 
        CommonOutputText.WriteRegistationHeading();

       _fiedvalidator.FieldArray[(int)FieldConstants.UserRegistrationField.EmailAddress] = GetInputFromUser(FieldConstants.UserRegistrationField.EmailAddress, "Please Enter your Email address");
       _fiedvalidator.FieldArray[(int)FieldConstants.UserRegistrationField.FirstName] = GetInputFromUser(FieldConstants.UserRegistrationField.FirstName, "Please Enter your first name");
       _fiedvalidator.FieldArray[(int)FieldConstants.UserRegistrationField.LastName] = GetInputFromUser(FieldConstants.UserRegistrationField.LastName, "Please Enter your LastName");
       _fiedvalidator.FieldArray[(int)FieldConstants.UserRegistrationField.Password] = GetInputFromUser(FieldConstants.UserRegistrationField.Password, $"Please Enter your Password. {Environment.NewLine}Your password must contain at least 1 small case letter {Environment.NewLine}1 capital letter, 1 digit, 1 special character. {Environment.NewLine} More that 6 charaters");
       _fiedvalidator.FieldArray[(int)FieldConstants.UserRegistrationField.PasswordCompare] = GetInputFromUser(FieldConstants.UserRegistrationField.PasswordCompare, "Please retype you password");
       _fiedvalidator.FieldArray[(int)FieldConstants.UserRegistrationField.AddressFirstLine] = GetInputFromUser(FieldConstants.UserRegistrationField.AddressFirstLine, "Please enter your first address");
       _fiedvalidator.FieldArray[(int)FieldConstants.UserRegistrationField.AddressSecondLine] = GetInputFromUser(FieldConstants.UserRegistrationField.AddressSecondLine, "Please enter your second Address");
       _fiedvalidator.FieldArray[(int)FieldConstants.UserRegistrationField.AddressCity] = GetInputFromUser(FieldConstants.UserRegistrationField.AddressCity, "Please enter the city where you live");
       _fiedvalidator.FieldArray[(int)FieldConstants.UserRegistrationField.PostCode] = GetInputFromUser(FieldConstants.UserRegistrationField.PostCode, "Please enter the city where you live");

       RegisterUser();
    }

    private string GetInputFromUser(FieldConstants.UserRegistrationField field, string promptText) {
       string fieldval = "";
        do {
           Console.WriteLine(promptText);
           fieldval = Console.ReadLine();
        } while(!FieldValid(field, fieldval));

        return fieldval;
    }

    private bool FieldValid(FieldConstants.UserRegistrationField field, string fieldvalue){
      if(!_fiedvalidator.ValidatorDel((int)field, fieldvalue, _fiedvalidator.FieldArray, out string invalidMessage)) {
         CommonOutputFormat.ChangeFontColor(FontTheme.Danger);
         Console.WriteLine(invalidMessage);
         CommonOutputFormat.ChangeFontColor(FontTheme.Default);
         return false;
      }
      return true;
    }

    private void RegisterUser() {
       _register.Register(_fiedvalidator.FieldArray);

       CommonOutputFormat.ChangeFontColor(FontTheme.Success);
       Console.WriteLine("You have successfull registered, Please press any key to login");
    }
}
