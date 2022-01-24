namespace ClubMemberShipApplication;

public static class CommonOutputText
{
    private static string MainHeading
    {
        get
        {
            string heading = "Cycling Club";
            return $"{heading}{Environment.NewLine}{new string('-', heading.Length)}";
        }
    }

    private static string RegistrationHeading
    {
        get
        {
            string heading = "Register";
            return $"{heading}{Environment.NewLine}{new string('-', heading.Length)}";
        }
    }

    private static string LoginHeading
    {
        get
        {
            string heading = "Login";
            return $"{heading}{Environment.NewLine}{new string('-', heading.Length)}";
        }
    }

    public static void WriteMainHeading(){
       Console.Clear();
       Console.WriteLine(MainHeading);
    }

    public static void WriteRegistationHeading() {
       Console.Clear();
       Console.WriteLine(RegistrationHeading);
    }

    public static void WriteLoginHeading() {
       Console.Clear();
       Console.WriteLine(LoginHeading);
    }

}
