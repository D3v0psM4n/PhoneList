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

        public void Crear(Contacto datos)
        {
            try
            {
                Contacto contacto = new Contacto()
                {
                    Nombre = datos.Nombre,
                    Apellido = datos.Apellido,
                    Compania = datos.Compania
                };

                _modelPhoneDbContext.Contacto.Add(contacto);
                _modelPhoneDbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}