using DeLaSalle.Practica1.Core.Entities;

namespace DeLaSalle.Practica1.Core.Managers.Interfaces;

public interface IPmManager
{
    Pm GetPm(Person person);
}