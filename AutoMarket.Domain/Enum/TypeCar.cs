using System.ComponentModel.DataAnnotations;

namespace AutoMarket.Domain.Enum;

public enum TypeCar
{
    [Display(Name = "Легковой автомобиль")]
    PassengerCar = (int)0,
    [Display(Name = "Седан")]
    Sedan = (int)1,
    [Display(Name = "Хэтчбек")]
    HatchBack =(int) 2,
    [Display(Name = "Минивэн")]
    Minivan =(int) 3,
    [Display(Name = "Спортивная машина")]
    SportsCar =(int) 4,
    [Display(Name = "Внедорожник")]
    Suv = (int)5,
}
