using DeLaSalle.Practica1.Core.Entities;

namespace DeLaSalle.Practica1.Core.Services.Interfaces;

public interface IPmService
{
    Pm ProcessPm(Person person);
}