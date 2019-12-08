using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Arda.Models;

namespace Arda.Controllers
{
    public class CharactersController : Controller
    {
        //private readonly ICharacterRepository characterRepository;

        //public CharactersController(ICharacterRepository characterRepository) {
        //    this.characterRepository = characterRepository;
        //}

        //public IActionResult Index()
        //{
        //    return View(characterRepository.GetAllCharacters());
        //}

        public IActionResult Index() {
            return View();
        }
    }
}