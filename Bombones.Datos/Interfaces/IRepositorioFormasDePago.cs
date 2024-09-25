using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;
using System.Data.SqlClient;

namespace Bombones.Datos.Interfaces
{
    public interface IRepositorioFormasDePago
    {
        int GetCantidad(SqlConnection conn, SqlTransaction? tran = null);
        void Agregar(FormaPago formaDePago, SqlConnection conn, SqlTransaction? tran = null);
        void Borrar(int formaDePagoId, SqlConnection conn, SqlTransaction? tran = null);
        void Editar(FormaPago formaDePago, SqlConnection conn, SqlTransaction? tran = null);
        bool EstaRelacionado(int tipoId, SqlConnection conn, SqlTransaction? tran = null);
        bool Existe(FormaPago formaDePago, SqlConnection conn, SqlTransaction? tran = null);
        List<FormaPagoListDto>? GetLista(SqlConnection conn, SqlTransaction? tran = null);
        FormaPago? GetFormaPagoPorId(int formaDePagoId, SqlConnection conn, SqlTransaction? tran = null);
        int GetPaginaPorRegistro(SqlConnection conn, string descripcion, int totalPages);
    }
}
