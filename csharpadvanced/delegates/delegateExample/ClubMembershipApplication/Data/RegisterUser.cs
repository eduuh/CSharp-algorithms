using ClubMemberShipApplication.Data;
using ClubMemberShipApplication.Models;
using ClubMemberShipApplication.FieldValidors;

namespace ClubMemberShipApplication.Data;

public class RegisterUser : IRegister
{
    public bool EmailExist(string emailaddress)
    {
       bool emailExist = false;
       using(var dbContext = new ClubMemberShipDBContext()){
           emailExist = dbContext.Users.Any(b => b.EmailAddress.ToLower().Trim() == emailaddress.Trim().ToLower());
       }
       return emailExist;
    }

    public bool Register(string[] fields)
    {
       using( var dbContext = new ClubMemberShipDBContext()){
         User user = new User {
            EmailAddress = fields[(int)FieldConstants.UserRegistrationField.EmailAddress],
            FirstName = fields[(int)FieldConstants.UserRegistrationField.FirstName],
            LastName = fields[(int)FieldConstants.UserRegistrationField.LastName],
            PassWord = fields[(int)FieldConstants.UserRegistrationField.Password],
            DateOfBirth = DateTime.Parse(fields[(int)FieldConstants.UserRegistrationField.DateOfBirth]),
            AddressFirstLine = fields[(int)FieldConstants.UserRegistrationField.AddressFirstLine],
            AddressSecondLine = fields[(int)FieldConstants.UserRegistrationField.AddressSecondLine],
            AddressCity = fields[(int)FieldConstants.UserRegistrationField.AddressCity],
            PostCode = fields[(int)FieldConstants.UserRegistrationField.PostCode],
         };         

         dbContext.Users.Add(user);
         dbContext.SaveChanges();
       }
       return true;
    }
}
