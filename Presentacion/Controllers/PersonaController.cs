using System;
using System.Collections.Generic;
using System.Linq;
using Datos;
using Entity;
using Logica;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Presentacion.Models;

namespace Presentacion.Controllers
{
    [ApiController]
    [Route ("api/[controller]")]
    public class PersonaController : ControllerBase
    {
        private readonly PersonaService _personaService;
        public IConfiguration Configuration { get; }
        public PersonaController(PersonaContext context)
        {            
            _personaService = new PersonaService(context);
        }
        // GET: api/Persona
        [HttpGet]
        public IEnumerable<PersonaViewModel> Gets()
        {
            var persona= _personaService.ConsultarTodos().Select(p=> new PersonaViewModel(p));
            return persona;
        }
        // GET: api/Persona/5
        [HttpGet("{identificacion}")]
        public ActionResult<PersonaViewModel> Get(string identificacion)
        {
            var persona= _personaService.BuscarxIdentificacion(identificacion);
            if (persona== null) return NotFound();
            var personaViewModel = new PersonaViewModel(persona);
            return personaViewModel;
        }
        // POST: api/Persona
        [HttpPost]
        public ActionResult<PersonaViewModel> Post(PersonaInputModel personaInput)
        {
            Persona persona= MapearPersona(personaInput);
            var response = _personaService.Guardar(persona);
            if (response.Error) 
            {
                ModelState.AddModelError("Guardar Persona", response.Mensaje);
                var problemDetails = new ValidationProblemDetails(ModelState)
                {
                     Status = StatusCodes.Status400BadRequest,
                };
                return BadRequest(problemDetails);
            }
            return Ok(response.Persona);
        }
       private Persona MapearPersona(PersonaInputModel personaInput)
        {
            var persona= new Persona
            {           
                Identificacion = personaInput.Identificacion,
                Nombre = personaInput.Nombre,
                Apellido = personaInput.Apellido,
                Sexo = personaInput.Sexo,
                Edad = personaInput.Edad,
                Departamento = personaInput.Departamento,
                Ciudad = personaInput.Ciudad,
                Tipo = personaInput.Tipo,
                Valor = personaInput.Valor,
                Fecha = personaInput.Fecha            
            };
            return persona;
        }
    }
}
