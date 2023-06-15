//-----------------------------------------------------------------------------------------------------------------------
// Before C# version 10
//-----------------------------------------------------------------------------------------------------------------------

//Test prueba = new();
//Console.WriteLine(prueba.cadena1);
//Console.WriteLine(prueba.cadena2);

//public class Test
//{
//    private const string scheme = "https";
//    private const string LoginUri = "login";
//    private const string HomeUri = "home";

//    private const string dev = scheme + "://localhost:5001";

//    public const string LoginUriDev = dev + "/" + LoginUri;
//    public const string HomeUriDev = dev + "/" + "myaccount" + "/" + HomeUri;

//    public string cadena1 = LoginUriDev;
//    public string cadena2 = HomeUriDev;

//    public Test() 
//    {

//    }
//}

//-----------------------------------------------------------------------------------------------------------------------
// After C# version 10
//-----------------------------------------------------------------------------------------------------------------------

//Test prueba = new();
//Console.WriteLine(prueba.cadena1);
//Console.WriteLine(prueba.cadena2);

//public class Test
//{
//    private const string scheme = "https";
//    private const string LoginUri = "login";
//    private const string HomeUri = "home";

//    private const string dev = $"{scheme}://localhost:5001";

//    private const string LoginUriDev = $"{dev}/{LoginUri}";
//    private const string HomeUriDev = $"{dev}/myaccount/{HomeUri}";

//    public string cadena1 = LoginUriDev;
//    public string cadena2 = HomeUriDev;

//    public Test()
//    {

//    }
//}

//-----------------------------------------------------------------------------------------------------------------------
// Before C# version 10
//-----------------------------------------------------------------------------------------------------------------------

//Test prueba = new();
//Console.WriteLine(prueba.cadena1);

//public class Test
//{
//    const string SupportedCurrencyCodes = "GPB, USD, AUD";
//    const string Copyright = "Jason Roberts";
//    const string TwitterSupportAccount = "@RobertsJason";

//    const string AboutMessage = "Currency codes supported '"
//                                        + SupportedCurrencyCodes
//                                        + "'. Support via Twitter: " + TwitterSupportAccount
//                                        + ". Copyright 2022 " + Copyright + ".";

//    public string cadena1 = AboutMessage;

//    public Test()
//    {

//    }
//}

//-----------------------------------------------------------------------------------------------------------------------
// After C# version 10
//-----------------------------------------------------------------------------------------------------------------------

Test prueba = new();
Console.WriteLine(prueba.cadena1);

public class Test
{
    const string SupportedCurrencyCodes = "GPB, USD, AUD";
    const string Copyright = "Jason Roberts";
    const string TwitterSupportAccount = "@RobertsJason";

    const string AboutMessage = $"Currency codes supported '{SupportedCurrencyCodes}'. Support via Twitter: {TwitterSupportAccount}. Copyright 2022 {Copyright}.";

    public string cadena1 = AboutMessage;

    public Test()
    {

    }
}

