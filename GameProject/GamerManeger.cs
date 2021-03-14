using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManeger : IGamerService
    {
        //constracter
        IUsergValidationService _usergValidationService;

        public GamerManeger(IUsergValidationService usingValidationService)
        {
            _usergValidationService = usingValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_usergValidationService.Validata(gamer) == true)
            {
                Console.WriteLine("Kullanıcı kaydedildi.");
            }
            else
            {
                Console.WriteLine("Kullanıcı kaydedlilemedi");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kullanıcı güncellendi.");
        }
    }
}
