using DeLaSalle.Practica1.Core.Entities;
using DeLaSalle.Practica1.Core.Managers.Interfaces;
using DeLaSalle.Practica1.Core.Services.Interfaces;

namespace DeLaSalle.Practica1.Core.Managers;

public class PmManager : IPmManager
{
    private readonly IPmService _service;

    public PmManager(IPmService service){
        _service = service;
    }

    public Pm GetPm(Person person){
        return _service.ProcessPm(person);
    }
}