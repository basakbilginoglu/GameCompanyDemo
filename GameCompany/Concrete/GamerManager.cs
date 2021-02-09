using GameCompany.Abstract;
using GameCompany.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCompany.Concrete
{
    public class GamerManager : IGamerService
    {
        private UserValidationManager userValidationManager;

        public GamerManager(UserValidationManager userValidationManager)
        {
            this.userValidationManager = userValidationManager;
        }

        public void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " Adlı kullanıcı eklendi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " Adlı kullanıcı bilgileri güncellendi");
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " Adlı kullanıcı silindi");
        }
    }
}
