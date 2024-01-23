
using PaparaBootcamp.Homework3;
using PaparaBootcamp.Homework3.Conditions;
using PaparaBootcamp.Homework3.DependenciesShouldBeInjected.IdealCode;
using PaparaBootcamp.Homework3.DependenciesShouldBeInjected.NotIdealCode;
using PaparaBootcamp.Homework3.DontRepeatYourself.IdealCode;
using PaparaBootcamp.Homework3.DontRepeatYourself.NotIdealCode;
using PaparaBootcamp.Homework3.SingleResponsibilityPrinciple;

//MeaningfulNamingExample();
//FunctionsShouldBeSmallExample();
//SingleResponsibilityPrincipleExample();
//DependenciesShouldBeInjectedExample();
//DontRepeatYourselfExample();
//ConditionCodeExample();
TernaryIfExample();



#region MeaningfulNaming
static void MeaningfulNamingExample()
{
    MeaningfulNaming meaningfulNaming = new MeaningfulNaming();
    //bad code
    int a = 20;
    int b = 40;
    Console.WriteLine("--------Meaningful Naming Example--------");
    meaningfulNaming.func(a, b);

    //good code
    int number1 = 10;
    int number2 = 20;
    meaningfulNaming.Sum(number1, number2);
}
#endregion

#region FunctionsShouldBeSmall
static void FunctionsShouldBeSmallExample()
{
    FunctionsShouldBeSmall functionsShouldBeSmall = new FunctionsShouldBeSmall();
    //bad code
    Console.WriteLine("--------Functions Should Be Small Example---------");
    Console.WriteLine("--------Bad code example--------");
    functionsShouldBeSmall.DatabaseConnectionAndSendMessage();
    Console.WriteLine("\n -------Clean code example-------");
    functionsShouldBeSmall.DatabaseConnection();
}

#endregion

#region SingleResponsibilityPrinciple
static void SingleResponsibilityPrincipleExample()
{
    Console.WriteLine("--------Single Responsibility Principle Example---------");
    NotIdealCode notIdealCode = new NotIdealCode();
    Console.WriteLine("--------Bad code example--------");
    notIdealCode.DatabaseConnection();
    var users = notIdealCode.GetUsers();
    foreach (var user in users)
    {
        Console.WriteLine($"{user.Name}, {user.Email}, {user.Password}");
    }
    Console.WriteLine("\n -------Clean code example-------");
    UserExampleDatabase database = new UserExampleDatabase();
    database.DatabaseConnection();
    GetUsers getUsers = new GetUsers();
    var userList = getUsers.Users();
    foreach (var user in userList)
    {
        Console.WriteLine($"{user.Name}, {user.Email}, {user.Password}");
    }
}
#endregion

#region DependenciesShouldBeInjected
static void DependenciesShouldBeInjectedExample()
{
    Console.WriteLine("-------Dependencies Should Be Injected-------");
    Console.WriteLine("--------Bad code example--------");
    MessageSender messageSender = new MessageSender();
    messageSender.Send();
    Console.WriteLine("\n -------Clean code example-------");
    IdealMessageSender idealMessageSender = new IdealMessageSender();
    idealMessageSender.Send(new Letter());
    idealMessageSender.Send(new IdealCodeGmail());
}
#endregion

#region DontRepeatYourself
static void DontRepeatYourselfExample()
{
    Console.WriteLine("-------Don't Repeat Yourself-------");
    Console.WriteLine("--------Bad code example--------");
    PersonEmployee personEmployee = new();
    personEmployee.Work();
    RobotEmployee robotEmployee = new();
    robotEmployee.Work();
    Console.WriteLine("\n -------Clean code example-------");
    Employee person = new Person();
    person.Work();
    Employee robot = new Robot();
    robot.Work();
}
#endregion

#region Conditions
static void ConditionCodeExample()
{
    //Bool controlleri
    ConditionCode conditionCode = new ConditionCode();
    Console.WriteLine("-----bool değişkeni için tekrar true false yazılmaması gerek onun için bir örnek-----");
    conditionCode.BoolControl();
    Console.WriteLine("-----bool için uzun uzun if else yazılmaması gerek onun için bir örnek-------");
    Console.WriteLine("------bad code------");
    conditionCode.AgeControlBadCode(24);
    Console.WriteLine("------clean code------");
    conditionCode.AgeControlCleanCode(26);
    Console.WriteLine("-----bool değişkenlerini tersten kontrol etmemek gerekir--------");
    Console.WriteLine("------bad code------");
    conditionCode.IsFailed(30);
    Console.WriteLine("------clean code------");
    conditionCode.IsPassed(90);
    Console.WriteLine("-----birden fazla ortak değişken varsa onları enum içinde tanımlama için örnek------");
    Console.WriteLine("-----bad code------");
    conditionCode.ColorSelectBadCode("Yellow");
    Console.WriteLine("------clean code------");
    conditionCode.ColorSelectCleanCode(Color.Green);
    Console.WriteLine("-----değişkenleri kontrollerin içinde direkt yazmamak daha uygundur------");
    Console.WriteLine("-----bad code------");
    conditionCode.AdultControlBadCode(30);
    Console.WriteLine("------clean code------");
    conditionCode.AdultControlCleanCode(30, 16);
    Console.WriteLine("--------kompleks koşullar ile ilgili örnek-------------");
    Console.WriteLine("-----bad code------");
    conditionCode.CanDriveCarBadCode();
    Console.WriteLine("------clean code------");
    conditionCode.CadDriveCarCleanCode(24, 18, false, true);
    Console.WriteLine("------iç içe geçmiş sorgular ile örnek----------");
    Console.WriteLine("-----bad code------");
    conditionCode.CheckMilitaryBadCode(25, Gender.Man, false);
    Console.WriteLine("------clean code------");
    conditionCode.CheckMilitaryCleanCode(25, Gender.Man, false);
}
#endregion

#region TernaryIf
static void TernaryIfExample()
{
    Console.WriteLine("-----if i tek satırda kullanma örneği------");
    TernaryIf ternaryIf = new();
    Console.WriteLine("-----bad code------");
    ternaryIf.GetUsersBadCode();
    Console.WriteLine("------clean code------");
    ternaryIf.GetUsersCleanCode();
}
#endregion