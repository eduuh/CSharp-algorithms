using ClubMemberShipApplication.FieldValidors;

namespace ClubMemberShipApplication.Views;

public interface IView {
    void RunView();
    IFieldValidor FieldValidator {get; } 
}
