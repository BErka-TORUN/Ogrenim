using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManeger gamerManeger = new GamerManeger(new UsergValidationManeger());
            gamerManeger.Add(new Gamer
            {
                ID=1,
                BirthYear=2000, 
                FirtName="BERKA", 
                LastName="TORUN",
                IdentityNumber=12345
            });
            
        }
    }
}
