using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            //GamerManager gamerManager2 = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer {Id=1,BirthYear=1998,FirstName="YASİN", IdentityNumber=11111111111 });
        }
    }
}
