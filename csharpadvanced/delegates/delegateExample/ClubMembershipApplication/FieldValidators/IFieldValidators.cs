namespace ClubMemberShipApplication.FieldValidors;

public delegate bool FieldValidatorDel(int fieldIndex, string fieldValue,string[] fieldarray,out string fieldInvalidMessage);

public interface IFieldValidor {
    void InitialiseValidorDelegates();
    string[] fieldArray { get;}
    FieldValidatorDel  validatorDel {get;}
}
