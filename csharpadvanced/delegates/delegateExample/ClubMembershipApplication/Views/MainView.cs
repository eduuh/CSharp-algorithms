
using ClubMemberShipApplication.FieldValidors;

namespace ClubMemberShipApplication.Views;

public class MainView : IView
{
    public IFieldValidor FieldValidator => null;

    IView _registerView , _loginView;

    public MainView(IView register , IView LoginView)
    {
        _registerView = register;
        _loginView = LoginView;
    }

    public void RunView()
    {
       CommonOutputText.WriteMainHeading();
       Console.WriteLine("Please press 'l' to login or if you are not register press the 'r' key ");
       //ConsoleKey key = Console.ReadKey().Key;
       ConsoleKey key = ConsoleKey.R;
       if(key == ConsoleKey.R){
           RunUserRegistrationView();
           RunUserLoginView();
       }else if(key == ConsoleKey.L) {
          RunUserLoginView();
       }else {
          Console.Clear();
          Console.WriteLine("Good Bye");
       }
    }

    private void RunUserRegistrationView() {
       _registerView.RunView();
    }

    private void RunUserLoginView() {
       _loginView.RunView();
    }
}
