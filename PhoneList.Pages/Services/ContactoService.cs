using PhoneList.Pages.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneList.Pages.Services
{
    public class ContactoService
    {
        // Conectar con la Data Base
        ModelPhoneDbContext _modelPhoneDbContext = new ModelPhoneDbContext();

        public List<Contacto> ObtenerTodos()
        {
            try
            {
                var contactos = _modelPhoneDbContext.Contacto.ToList();

                List<Contacto> contactoList = new List<Contacto>();

                foreach (var contacto in contactos)
                {
                    contactoList.Add(new Contacto()
                    {
                        Id = contacto.Id,
                        Nombre = contacto.Nombre,
                        Apellido = contacto.Apellido,
                        Compania = contacto.Compania
                    });
                }

                return contactoList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Contacto ObtenerContactoPorId(int requestId)
        {
            try
            {
                return _modelPhoneDbContext.Contacto.FirstOrDefault(x => x.Id == requestId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Crear(Contacto contacto)
        {
            try
            {
                _modelPhoneDbContext.Contacto.Add(contacto);
                _modelPhoneDbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Editar(Contacto request)
        {
            try
            {
                var contacto = _modelPhoneDbContext.Contacto.FirstOrDefault(x => x.Id == request.Id);

                if (contacto != null)
                {
                    contacto.Nombre = request.Nombre;
                    contacto.Apellido = request.Apellido;
                    contacto.Compania = request.Compania;

                    _modelPhoneDbContext.SaveChanges();
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}