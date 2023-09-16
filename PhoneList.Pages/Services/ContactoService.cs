using PhoneList.Pages.Data;
using PhoneList.Pages.Dto;
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

        public void Crear(ContactoRequest contactoRequest)
        {
            try
            {
                // Lleno y salvo la tabla "Contacto" que no depende de otra
                Contacto contacto = new Contacto()
                {
                    Nombre = contactoRequest.Nombre,
                    Apellido = contactoRequest.Apellido,
                    Compania = contactoRequest.Compania
                };

                _modelPhoneDbContext.Contacto.Add(contacto);
                _modelPhoneDbContext.SaveChanges();
                var contactoId = contacto.Id;

                // Lleno y salvo la tabla "Telefono" que no depende de otra
                Telefono telefono = new Telefono()
                {
                    Numero = contactoRequest.Telefono,
                    EtiquetaId = contactoRequest.EtiquetaTelefonoId // posible bug?? EtiquetaId > 0
                };
                _modelPhoneDbContext.Telefono.Add(telefono);
                _modelPhoneDbContext.SaveChanges();
                var telefonoId = telefono.Id;

                // Con ambos IDs generados lleno la tabla "ContactoTelefono"
                ContactoTelefono contactoTelefono = new ContactoTelefono()
                {
                    ContactoId = contactoId,
                    TelefonoId = telefonoId
                };
                _modelPhoneDbContext.ContactoTelefono.Add(contactoTelefono);
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

        public List<EtiquetaTelefono> ObtenerEtiquetaTelefono()
        {
            try
            {
                return _modelPhoneDbContext.EtiquetaTelefono.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<EtiquetaEmail> ObtenerEtiquetaEmail()
        {
            try
            {
                return _modelPhoneDbContext.EtiquetaEmail.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<EtiquetaFecha> ObtenerEtiquetaFecha()
        {
            try
            {
                return _modelPhoneDbContext.EtiquetaFecha.ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}