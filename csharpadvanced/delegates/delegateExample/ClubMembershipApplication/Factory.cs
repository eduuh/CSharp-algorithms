using ClubMemberShipApplication.Data;
using ClubMemberShipApplication.FieldValidors;
using ClubMemberShipApplication.Views;

namespace ClubMemberShipApplication;

public static class Factory {

    public static IView GetMainViewObject() {
       ILogin login = new LoginUser();
       IRegister register = new RegisterUser();
       IFieldValidor UserRegistrationValidator = new UserRegistrationValidator(register);
       UserRegistrationValidator.InitialiseValidatorDelegates();

       IView registerView = new UserRegistrationView(register, UserRegistrationValidator);
       IView loginview = new UserLoginView(login);
       IView mainview = new MainView(registerView, loginview);
       return mainview;
    }
}
