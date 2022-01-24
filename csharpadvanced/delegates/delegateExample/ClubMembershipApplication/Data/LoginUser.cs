using ClubMemberShipApplication.Models;

namespace ClubMemberShipApplication.Data;

public class LoginUser : ILogin
{
    public User Login(string emailAddress, string password)
    {
       User user = null;
       using(var dbcontext = new ClubMemberShipDBContext()) {

          user = dbcontext.Users.FirstOrDefault( u => u.EmailAddress.Trim().ToLower() == emailAddress.Trim().ToLower() && u.PassWord.Equals(password));
       }
       return user;
    }
}
