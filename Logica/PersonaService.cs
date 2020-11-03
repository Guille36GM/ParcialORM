using System;
using System.Collections.Generic;
using System.Linq;
using Datos;
using Entity;

namespace Logica
{
    public class PersonaService
    {
        private readonly PersonaContext _context;
        
        public PersonaService(PersonaContext context)
        {
            _context = context;
        }
        public GuardarPersonaResponse Guardar(Persona persona)
        {
            try
            {
                var personaBuscada = _context.Personas.Find(persona.Identificacion);
                if (personaBuscada != null)
                {
                    return new GuardarPersonaResponse("Error la persona ya se encuentra registrada");
                }
                else
                {
                    _context.Personas.Add(persona);
                    _context.SaveChanges();
                    return new GuardarPersonaResponse(persona);
                }
            }
            catch (Exception e)
            {
                return new GuardarPersonaResponse($"Error de la Aplicacion: {e.Message}");
            }            
        }
        public List<Persona> ConsultarTodos()
        {
            List<Persona> personas = _context.Personas.ToList();
            return personas;
        }
        public Persona BuscarxIdentificacion(string identificacion)
        {
            Persona persona = _context.Personas.Find(identificacion);
            return persona;
        }
        public class GuardarPersonaResponse 
        {
            public GuardarPersonaResponse(Persona persona)
            {
                Error = false;
                Persona = persona;
            }
            public GuardarPersonaResponse(string mensaje)
            {
                Error = true;
                Mensaje = mensaje;
            }
            public bool Error { get; set; }
            public string Mensaje { get; set; }
            public Persona Persona { get; set; }
        }
    }    
}
