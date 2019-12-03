using AutoMapper;
using MDC.Desafio.Domain.Entities;
using MDC.Desafio.Domain.Interfaces;
using MDC.Desafio.Domain.Services;
using MDC.Desafio.Presentation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MDC.Desafio.Presentation.Controllers
{
    public class PeopleController : Controller
    {
        private readonly PersonService _personService;
        private readonly IMapper _mapper;

        public PeopleController(IPersonRepository _personRepository, IMapper mapper)
        {
            _personService = new PersonService(_personRepository);
            _mapper = mapper;
        }
        // GET: People
        public IActionResult Index()
        {
            return View();
        }

        // GET: People/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: People/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: People/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PersonViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            var person = _mapper.Map<Person>(viewModel);
            person.AddPhoto(new PersonPhoto(viewModel.Photo64));
            try
            {
                _personService.Add(person);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: People/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: People/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: People/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: People/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}