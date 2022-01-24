
using ClubMemberShipApplication.Data;
using ClubMemberShipApplication.FieldValidors;
using ClubMemberShipApplication.Models;

namespace ClubMemberShipApplication.Views;

public class UserLoginView : IView
{
    public IFieldValidor FieldValidator => null;

     ILogin _loginUser = null;

     public UserLoginView(ILogin login)
     {
         _loginUser = login;
     }

    public void RunView()
    {
        CommonOutputText.WriteMainHeading(); 
        CommonOutputText.WriteLoginHeading();

        Console.WriteLine("Please enter your email address");
        string email = Console.ReadLine();
        Console.WriteLine("Please enter you password");

        string password = Console.ReadLine();

        User user = _loginUser.Login(email, password);

        if(user is not null){
           WelcomeUserView welcomeUser  = new WelcomeUserView(user);
           welcomeUser.RunView();
        } else {
            Console.Clear();
            CommonOutputFormat.ChangeFontColor(FontTheme.Danger);
            Console.WriteLine("The credentials that you entered do not match our records");
            CommonOutputFormat.ChangeFontColor(FontTheme.Default);
            Console.ReadKey();
        }
    }
}
