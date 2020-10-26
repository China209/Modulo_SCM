using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo.Clases_Modulo
{
    // Metodo para enviar y obtener los datos de vehiculo
    public class clsVehiculo
    {
        private int idVehiculo;
        private int idMarca;
        private string sPlaca_vehiculo;
        private string sModelo_vehiculo;
        private string sColor_vehiculo;
        private string sAnio_vehiculo;
        private string sTpo_Combustible_vehiculo;
        private int iEstado_vehiculo;

        public int IdVehiculo { get => idVehiculo; set => idVehiculo = value; }
        public int IdMarca { get => idMarca; set => idMarca = value; }
        public string SPlaca_vehiculo { get => sPlaca_vehiculo; set => sPlaca_vehiculo = value; }
        public string SModelo_vehiculo { get => sModelo_vehiculo; set => sModelo_vehiculo = value; }
        public string SColor_vehiculo { get => sColor_vehiculo; set => sColor_vehiculo = value; }
        public string SAnio_vehiculo { get => sAnio_vehiculo; set => sAnio_vehiculo = value; }
        public string STpo_Combustible_vehiculo { get => sTpo_Combustible_vehiculo; set => sTpo_Combustible_vehiculo = value; }
        public int IEstado_vehiculo { get => iEstado_vehiculo; set => iEstado_vehiculo = value; }
    }
}
