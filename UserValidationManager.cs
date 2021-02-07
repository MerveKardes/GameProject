using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager:IUserValidationService
    {
        public bool UserValidate(Gamer gamer)
        {
            if (gamer.FirstName.Length > 1 && gamer.LastName.Length > 1 && gamer.TcNo.Length == 11 && gamer.YearOfBirth > 1800)
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
