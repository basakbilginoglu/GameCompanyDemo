using GameCompany.Abstract;
using GameCompany.Entities;


namespace GameCompany.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool UserValidate(Gamer gamer)
        {
            if (gamer.Id==1 && gamer.NationalityId == 123456 && gamer.FirstName == "Ayşe" && gamer.LastName == "Hatice" && gamer.DateOfBirth ==1985)
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
