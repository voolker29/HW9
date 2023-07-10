using Task_9;

while (true)
{
    Console.WriteLine(new string('-', 50));
    Console.WriteLine("Введите Логин");
    string login = Console.ReadLine();
    Console.WriteLine("Введите пароль");
    string password = Console.ReadLine();
    Console.WriteLine("Повторите пароль");
    string confirmPassword = Console.ReadLine();
    
    try
    {
        if (Authorization.PassAuthorization(login, password, confirmPassword)) 
        {
            Console.WriteLine("Succes!");
            break;
         };
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}



