namespace fieldValidator;

public static class CommonReqularExpressionValidationPatterns {
 public const string Email_Address_RegEx_Pattern = @"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$";
 public const string PhoneNumber_ReqEx_Pattern = @"(^1300\d{6}$)|(^1800|1900|1902\d{6}$)|(^0[2|3|7|8]{1}[0-9]{8}$)|(^13\d{4}$)|(^04\d{2,3}\d{6}$)";
 public const string UK_PostCode_ReqEx_Pattern = @"((^[BEGLMNS][1-9]\d?) | (^W[2-9] ) | ( ^( A[BL] | B[ABDHLNRST] | C[ABFHMORTVW] | D[ADEGHLNTY] | E[HNX] | F[KY] | G[LUY] | H[ADGPRSUX] | I[GMPV] | JE | K[ATWY] | L[ADELNSU] | M[EKL] | N[EGNPRW] | O[LX] | P[AEHLOR] | R[GHM] | S[AEGKL-PRSTWY] | T[ADFNQRSW] | UB | W[ADFNRSV] | YO | ZE ) \d\d?) | (^W1[A-HJKSTUW0-9]) | (( (^WC[1-2]) | (^EC[1-4]) | (^SW1) ) [ABEHMNPRVWXY] ) ) (\s*)? ([0-9][ABD-HJLNP-UW-Z]{2})) | (^GIR\s?0AA)";
 public const string Strong_Password_ReqEx_Pattern = @"^(?=(.*[a-z]){3,})(?=(.*[A-Z]){2,})(?=(.*[0-9]){2,})(?=(.*[!@#$%^&*()\-__+.]){1,}).{8,}$";

}
