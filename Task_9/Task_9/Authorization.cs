
namespace Task_9
{
    internal class Authorization
    {
       internal static bool PassAuthorization(string login, string password, string confirmPassword)
        { 
            if (login.Length >= 20 || login.IndexOf(" ") > (-1))
            {
                throw new WrongLoginException("Login is Fail");
            }

            if (password.Length >= 20 || password.IndexOf(" ") > (-1) || !IsHaveNumber(password)|| password != confirmPassword)
            {
                throw new WrongPasswordException("Pasword is Fail");
            }
            return true;
        }

      static bool IsHaveNumber(string str)
        {
            bool IsNumber = false;
            foreach (char c in str)
            {
                if (Char.IsNumber(c))
                {
                    IsNumber = true;
                    break;
                }; 
            }
            return IsNumber;
        }
    }
}
