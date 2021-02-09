using GameCompany.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCompany.Abstract
{
    public interface IUserValidationService
    {
        bool UserValidate(Gamer gamer);
    }
}
