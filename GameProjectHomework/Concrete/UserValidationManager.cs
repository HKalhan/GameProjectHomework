using System;
using System.Collections.Generic;
using System.Text;
using GameProjectHomework.Abstract;

namespace GameProjectHomework.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1999 && gamer.FirstName == "Hasret" && gamer.LastName == "Kalhan" && gamer.IdentityNumber == 11111111111)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
