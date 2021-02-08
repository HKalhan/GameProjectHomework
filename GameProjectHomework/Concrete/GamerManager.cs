using System;
using System.Collections.Generic;
using System.Text;
using GameProjectHomework.Abstract;

namespace GameProjectHomework.Concrete
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public UserValidationManager UserValidationManager { get; }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine(gamer.FirstName + "  " + gamer.LastName + "   your account added!");
            }
            else
            {
                Console.WriteLine("Not a valid person!");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + gamer.LastName + " your account deleted!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + gamer.LastName + " your account updated!");
        }
    }
}
