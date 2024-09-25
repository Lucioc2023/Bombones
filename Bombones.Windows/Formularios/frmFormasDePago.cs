using Bombones.Entidades.Dtos;
using Bombones.Entidades.Entidades;
using Bombones.Servicios.Intefaces;
using Bombones.Windows.Helpers;
using Microsoft.Extensions.DependencyInjection;

namespace Bombones.Windows
{
    public partial class frmFormasDePago : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private readonly IServiciosFormasDePagos? _servicio;
        private List<FormaPagoListDto>? lista;


        public frmFormasDePago(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _servicio = serviceProvider?.GetService<IServiciosFormasDePagos>()
                ?? throw new ApplicationException("Dependencias no cargadas!!!"); ;
            _serviceProvider = serviceProvider;

        }

        private void frmFormasDePago_Load(object sender, EventArgs e)
        {
            try
            {

                LoadData();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LoadData()
        {
            try
            {
                lista = _servicio!?.GetLista();
                MostrarDatosEnGrilla(lista);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void MostrarDatosEnGrilla(List<FormaPagoListDto>? lista)
        {
            GridHelper.LimpiarGrilla(dgvDatos);
            if (lista is not null)
            {
                foreach (var fP in lista)
                {
                    var r = GridHelper.ConstruirFila(dgvDatos);
                    GridHelper.SetearFila(r, fP);
                    GridHelper.AgregarFila(r, dgvDatos);
                }

            }
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
