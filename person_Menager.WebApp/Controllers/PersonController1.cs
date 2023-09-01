using Microsoft.AspNetCore.Mvc;
using person_Menager.WebApp.Repostery_;

namespace person_Menager.WebApp.Controllers;

public class PersonController : Controller
{
    private readonly PersonRepository _personRepository;

    public PersonController()
    {
        _personRepository = new PersonRepository();
    }

    public IActionResult GetAll()
    {
        var person= _personRepository.GetAll();
        return View(person);
    }

    public IActionResult GetByID(int id)
    {
        var person = _personRepository.GetById(id);
        return View(person);
    }




}
