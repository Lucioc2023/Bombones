using Bombones.Datos.Interfaces;
using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;
using Dapper;
using System.Data.SqlClient;

namespace Bombones.Datos.Repositorios
{
    public class RepositorioFormasDePagos : IRepositorioFormasDePago
    {
        public void Agregar(FormaPago formaDePago, SqlConnection conn, SqlTransaction? tran = null)
        {
            throw new NotImplementedException();
        }

        public void Borrar(int formaDePagoId, SqlConnection conn, SqlTransaction? tran = null)
        {
            throw new NotImplementedException();
        }

        public void Editar(FormaPago formaDePago, SqlConnection conn, SqlTransaction? tran = null)
        {
            throw new NotImplementedException();
        }

        public bool EstaRelacionado(int tipoId, SqlConnection conn, SqlTransaction? tran = null)
        {
            throw new NotImplementedException();
        }

        public bool Existe(FormaPago formaDePago, SqlConnection conn, SqlTransaction? tran = null)
        {
            throw new NotImplementedException();
        }

        public int GetCantidad(SqlConnection conn, SqlTransaction? tran = null)
        {
            string selectQuery = @"SELECT COUNT(*) FROM FormasDePago";
            return conn.ExecuteScalar<int>(selectQuery);
        }

        public FormaPago? GetFormaPagoPorId(int formaDePagoId, SqlConnection conn, SqlTransaction? tran = null)
        {
            throw new NotImplementedException();
        }

        public List<FormaPagoListDto>? GetLista(SqlConnection conn, SqlTransaction? tran = null)
        {
            var selectQuery = @"SELECT FormaDePagoId, Descripcion FROM 
                FormasDePago ORDER BY Descripcion";
            
            return conn.Query<FormaPagoListDto>(selectQuery).ToList();
        }

        public int GetPaginaPorRegistro(SqlConnection conn, string descripcion, int totalPages)
        {
            throw new NotImplementedException();
        }
    }
}
