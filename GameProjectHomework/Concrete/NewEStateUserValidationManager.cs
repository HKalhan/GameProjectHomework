using System;
using System.Collections.Generic;
using System.Text;
using GameProjectHomework.Abstract;

namespace GameProjectHomework.Concrete
{
    class NewEStateUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
