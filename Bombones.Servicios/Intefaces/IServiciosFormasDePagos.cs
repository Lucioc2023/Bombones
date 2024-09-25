using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;

namespace Bombones.Servicios.Intefaces
{
     public interface  IServiciosFormasDePagos
    {
        void Borrar(int formaDePagoId);
        bool EstaRelacionado(int formaDePagoId);
        bool Existe(FormaPago formaPago);
        List<FormaPagoListDto>? GetLista();
        void Guardar(FormaPago formaPago);
        FormaPago? GetFormaDePagoPorId(int formaDePagoId);
        int GetCantidad();
        int GetPaginaPorRegistro(string descripcion, int pageSize);
    }
}
