
using PaparaBootcamp.Homework3;
using PaparaBootcamp.Homework3.Conditions;
using PaparaBootcamp.Homework3.DependenciesShouldBeInjected.IdealCode;
using PaparaBootcamp.Homework3.DependenciesShouldBeInjected.NotIdealCode;
using PaparaBootcamp.Homework3.DontRepeatYourself.IdealCode;
using PaparaBootcamp.Homework3.DontRepeatYourself.NotIdealCode;
using PaparaBootcamp.Homework3.InterfaceSegregationPrinciple.IdealCode.Abstratct;
using PaparaBootcamp.Homework3.InterfaceSegregationPrinciple.IdealCode.Concrete;
using PaparaBootcamp.Homework3.InterfaceSegregationPrinciple.NotIdealCode.Abtract;
using PaparaBootcamp.Homework3.InterfaceSegregationPrinciple.NotIdealCode.Concrete;
using PaparaBootcamp.Homework3.LiskovSubstitutionPrinciple.IdealCode.Abstract;
using PaparaBootcamp.Homework3.LiskovSubstitutionPrinciple.IdealCode.Concrete;
using PaparaBootcamp.Homework3.LiskovSubstitutionPrinciple.NotIdealCode;
using PaparaBootcamp.Homework3.OpenClosedPrinciple.IdealCode;
using PaparaBootcamp.Homework3.OpenClosedPrinciple.NotIdealCode;
using PaparaBootcamp.Homework3.SingleResponsibilityPrinciple;
using Gmail = PaparaBootcamp.Homework3.OpenClosedPrinciple.IdealCode.Gmail;
using OpenClosedMessageSender = PaparaBootcamp.Homework3.OpenClosedPrinciple.IdealCode.OpenClosedMessageSender;


MeaningfulNamingExample();
FunctionsShouldBeSmallExample();
SingleResponsibilityPrincipleExample();
DependenciesShouldBeInjectedExample();
DontRepeatYourselfExample();
ConditionCodeExample();
TernaryIfExample();
OpenClosedPrincipleExample();
LiskovSubstitutionPrincipleExample();
InterfaceSegregationPrincipleExample();


#region MeaningfulNaming
void MeaningfulNamingExample()
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
void FunctionsShouldBeSmallExample()
{
    FunctionsShouldBeSmall functionsShouldBeSmall = new FunctionsShouldBeSmall();
    //bad code
    Console.WriteLine("\n--------Functions Should Be Small Example---------");
    Console.WriteLine("--------Bad code example--------");
    functionsShouldBeSmall.DatabaseConnectionAndSendMessage();
    Console.WriteLine("\n -------Clean code example-------");
    functionsShouldBeSmall.DatabaseConnection();
}

#endregion

#region SingleResponsibilityPrinciple
void SingleResponsibilityPrincipleExample()
{
    Console.WriteLine("\n--------Single Responsibility Principle Example---------");
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
void DependenciesShouldBeInjectedExample()
{
    Console.WriteLine("\n-------Dependencies Should Be Injected-------");
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
void DontRepeatYourselfExample()
{
    Console.WriteLine("\n-------Don't Repeat Yourself-------");
    Console.WriteLine("--------Bad code example--------");
    PersonEmployee personEmployee = new();
    personEmployee.Work();
    RobotEmployee robotEmployee = new();
    robotEmployee.Work();
    Console.WriteLine("\n -------Clean code example-------");
    BaseEmployee person = new Person();
    person.Work();
    BaseEmployee robot = new Robot();
    robot.Work();
}
#endregion

#region Conditions
void ConditionCodeExample()
{
    Console.WriteLine("\n---------Conditions----------");
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
void TernaryIfExample()
{
    Console.WriteLine("\n-----if i tek satırda kullanma örneği------");
    TernaryIf ternaryIf = new();
    Console.WriteLine("-----bad code------");
    ternaryIf.GetUsersBadCode();
    Console.WriteLine("------clean code------");
    ternaryIf.GetUsersCleanCode();
}
#endregion

#region OpenClosedPrinciple
void OpenClosedPrincipleExample()
{
    Console.WriteLine("\n------------Open Closed Principle Example-----------");
    //bad code 
    MessageSenderNotIdeal messageSenderNotIdeal = new MessageSenderNotIdeal();
    messageSenderNotIdeal.MessageSend("Aslı", "bla bla bla");

    //clean code
    OpenClosedMessageSender messageSender = new OpenClosedMessageSender();
    messageSender.MessageSend(new Gmail(), "Volkan", "bla bla bla");
}
#endregion

#region LiskovSubstitutionPrinciple
void LiskovSubstitutionPrincipleExample()
{
    Console.WriteLine("\n------------Liskov Substitution Principle Example-----------");
    Console.WriteLine("-----bad code------");
    RobotNotIdealCode robotNotIdealCode = new RobotNotIdealCode();
    robotNotIdealCode.Work();
    //robotNotIdealCode.Eat(); //bu şekilde kullanmayı çalıştığımız zaman hata fırlatmış olur
    EngineerNotIdealCode engineerNotIdealCode = new EngineerNotIdealCode();
    engineerNotIdealCode.Work();
    engineerNotIdealCode.Eat();
    engineerNotIdealCode.Rest();
    Console.WriteLine("------clean code------");
    WorkerIdealCode worker = new WorkerIdealCode();
    worker.Work();
    worker.Eat();
    worker.Rest();
    RobotIdealCode robot = new RobotIdealCode();
    robot.Work();

}
#endregion

#region InterfaceSegregationPrinciple
void InterfaceSegregationPrincipleExample()
{
    Console.WriteLine("\n------------Interface Segregation Principle Example-----------");
    Console.WriteLine("-----bad code------");
    IBaseDatabaseWorksNotIdealCode admin = new AdminManagerNotIdealCode();
    admin.GetAll();
    //admin.GetAllWithCategory("bbjbkj");  //bu şekilde kullanırsak hata fırlatır
    Console.WriteLine("------clean code------");
    IProduct productManager = new ProductManager();
    productManager.GetAll();
    productManager.GetAllWithCategory("aaaa");
    IBaseDatabaseWorks adminManager = new AdminManager();
    adminManager.GetAll();
    adminManager.Delete();
    adminManager.Add();
}
#endregion