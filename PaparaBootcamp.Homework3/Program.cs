
using PaparaBootcamp.Homework3;
using PaparaBootcamp.Homework3.DependenciesShouldBeInjected.IdealCode;
using PaparaBootcamp.Homework3.DependenciesShouldBeInjected.NotIdealCode;
using PaparaBootcamp.Homework3.SingleResponsibilityPrinciple;

//MeaningfulNamingExample();
//FunctionsShouldBeSmallExample();
//SingleResponsibilityPrincipleExample();
//DependenciesShouldBeInjectedExample();



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