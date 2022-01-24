namespace ClubMemberShipApplication.FieldValidors;

public delegate bool FieldValidatorDel(int fieldIndex, string fieldValue,string[] fieldarray,out string fieldInvalidMessage);

public interface IFieldValidor {
    void InitialiseValidatorDelegates();
    string[] FieldArray { get;}
    FieldValidatorDel  ValidatorDel {get;}
}
