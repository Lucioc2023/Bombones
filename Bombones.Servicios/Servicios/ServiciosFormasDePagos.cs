using Bombones.Datos.Interfaces;
using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;
using Bombones.Servicios.Intefaces;
using System.Data.SqlClient;

namespace Bombones.Servicios.Servicios
{
    public class ServiciosFormasDePagos : IServiciosFormasDePagos
    {
        private readonly IRepositorioFormasDePago? _repositorio;
        private readonly string _cadena;

        public ServiciosFormasDePagos(IRepositorioFormasDePago repositorio, string cadena)
        {
            _repositorio = repositorio ?? throw new ApplicationException("Dependencias no cargadas!");
            _cadena = cadena;
        }

        public void Borrar(int formaDePagoId)
        {
            throw new NotImplementedException();
        }

        public bool EstaRelacionado(int formaDePagoId)
        {
            throw new NotImplementedException();
        }

        public bool Existe(FormaPago formaPago)
        {
            throw new NotImplementedException();
        }

        public int GetCantidad()
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetCantidad(conn);
            }
        }

        public FormaPago? GetFormaDePagoPorId(int formaDePagoId)
        {
            throw new NotImplementedException();
        }

        public List<FormaPagoListDto>? GetLista()
        {
            using (var conn = new SqlConnection(_cadena))
            {
                conn.Open();
                return _repositorio!.GetLista(conn);
            }
        }

        public int GetPaginaPorRegistro(string descripcion, int pageSize)
        {
            throw new NotImplementedException();
        }

        public void Guardar(FormaPago formaPago)
        {
            throw new NotImplementedException();
        }
    }
}

