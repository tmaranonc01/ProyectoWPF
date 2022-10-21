using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace VMMV.Model
{
    public class Ventas : INotifyPropertyChanged
    {

        private int idVenta;
        private string fecha;
        private double importe;
        private string numTarjeta;

        public int IdVenta { get => idVenta; set => idVenta = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public double Importe { get => importe; set => importe = value; }
        public string NumTarjeta { get => numTarjeta; set => numTarjeta = value; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}