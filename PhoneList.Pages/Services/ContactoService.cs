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

        public List<string> ObtenerTelefonosPorContactoId(int contactoId)
        {
            try
            {
                var contacto = ObtenerContactoPorId(contactoId);
                var contactoTelefonos = contacto.ContactoTelefono;

                List<string> telefonos = new List<string>();
                foreach (var contactoTelefono in contactoTelefonos)
                {
                    telefonos.Add(contactoTelefono.Telefono.Numero);
                }

                return telefonos;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<string> ObtenerEmailsPorContactoId(int contactoId)
        {
            try
            {
                var contacto = ObtenerContactoPorId(contactoId);
                var contactoEmails = contacto.ContactoEmail;

                List<string> emails = new List<string>();
                foreach (var contactoEmail in contactoEmails)
                {
                    emails.Add(contactoEmail.Email.Correo);
                }

                return emails;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<DateTime?> ObtenerFechasPorContactoId(int contactoId)
        {
            try
            {
                var contacto = ObtenerContactoPorId(contactoId);
                var contactoFechas = contacto.ContactoFechaImportante;

                List<DateTime?> fechas = new List<DateTime?>();
                foreach (var contactoFecha in contactoFechas)
                {
                    fechas.Add(contactoFecha.FechaImportante.Fecha);
                }

                return fechas;
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