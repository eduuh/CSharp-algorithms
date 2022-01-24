using ClubMemberShipApplication.FieldValidors;
using ClubMemberShipApplication.Models;

namespace ClubMemberShipApplication.Views;

public class WelcomeUserView: IView{
    User _user = null;

   public WelcomeUserView(User user)
   {
       _user = user;
   }

    public IFieldValidor FieldValidator => throw new NotImplementedException();

    public void RunView()
    {
       CommonOutputFormat.ChangeFontColor(FontTheme.Success);
       Console.WriteLine($"Hi {_user.FirstName} || {Environment.NewLine} Welcome to the Cycling club");
       CommonOutputFormat.ChangeFontColor(FontTheme.Default);
       Console.ReadKey();
    }
}
