using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager:IGamerService
    {
        IUserValidationService userValidationService;


        public GamerManager(IUserValidationService userValidationService)
        {
            this.userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (userValidationService.UserValidate(gamer)==true)
            {
                Console.WriteLine("Kayıt işlemi başarıyla gerçekleşti.");
            }
            else
            {
                Console.WriteLine("Kayıt işlemi gerçekleştirilemedi.");
            }

        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " isimli oyuncu silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " isimli oyuncu güncellendi");
        }

    }
}
