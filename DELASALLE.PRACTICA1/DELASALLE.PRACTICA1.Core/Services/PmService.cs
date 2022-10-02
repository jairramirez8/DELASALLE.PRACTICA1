using DeLaSalle.Practica1.Core.Entities;
using DeLaSalle.Practica1.Core.Services.Interfaces;

namespace DeLaSalle.Practica1.Core.Services;

public class PmService:IPmService
{
    public Pm ProcessPm(Person person)
    {
        var pm = new Pm();
        pm.PesoM = person.Weight / (float)9.81 * (float)(3.69);

        return pm;
    }
}