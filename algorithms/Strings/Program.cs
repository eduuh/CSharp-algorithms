using validation;

string name = "EDWIN";
Boolean validation = stringValidation.IsUpper(name);

Console.WriteLine(validation);
Console.WriteLine(stringValidation.IsLower("edwin"));


string password = "123ssP";
string password2 = "134sitn";
Console.WriteLine(stringValidation.IsPasswordComplex(password));

Console.WriteLine(stringValidation.NormalizeString(" Edwin Muraya , Muraya"));

Console.WriteLine("Edwin murya".ToLower().Contains("ya"));

//check for letter is at even index

// empty string

Console.WriteLine(stringValidation.isAtEvenIndex("", 'e'));
Console.WriteLine(stringValidation.isAtEvenIndex("edwin", 'e'));
Console.WriteLine(stringValidation.isAtEvenIndex("Muraya", 'm'));
Console.WriteLine(stringValidation.isAtEvenIndex("Kamau edwin", 'k'));


//reversing a string

Console.WriteLine(stringValidation.Reverse("Hello world"));
Console.WriteLine(stringValidation.Reverse(""));
Console.WriteLine(stringValidation.Reverse("hello"));
Console.WriteLine(stringValidation.Reverse("tacos"));
Console.WriteLine(stringValidation.Reverse("Hi!"));
Console.WriteLine(stringValidation.Reverse(null));

Console.WriteLine(stringValidation.Reverse2("Hello world"));
Console.WriteLine(stringValidation.Reverse2(""));
Console.WriteLine(stringValidation.Reverse2("hello"));
Console.WriteLine(stringValidation.Reverse2("tacos"));
Console.WriteLine(stringValidation.Reverse2("Hi!"));
Console.WriteLine(stringValidation.Reverse2(null));



Console.WriteLine(stringValidation.ReverseEachWord("This is edwins case and Madam"));