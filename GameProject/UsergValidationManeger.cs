using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UsergValidationManeger : IUsergValidationService
    {
        public bool Validata(Gamer gamer)
        {
            if (gamer.FirtName=="BERKA" && gamer.LastName=="TORUN" &&
                gamer.BirthYear==2001 && gamer.IdentityNumber==12345 )
            {
                Console.WriteLine("Kullanıcı doğrulandı.");
                return true;
            }
            else
            {
                Console.WriteLine("Kullanıcı doğrulanamadı");
                return false;
            }
        }
    }
}
