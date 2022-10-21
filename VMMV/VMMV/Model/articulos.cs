using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace VMMV.Model
{
    public class Articulos : INotifyPropertyChanged
    {

        private int idArticulo;
        private string descripcion;
        private double precioCoste;
        private double iva;
        private double pvp;

        public int IdArticulo
        {
            get
            {
                return idArticulo;
            }
            set
            {
                idArticulo = value;
                OnPropertyChanged("idArticulo");
            }
        }
        public string Descripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                descripcion = value;
                OnPropertyChanged("descripcion");
            }
        }
        public double PrecioCoste
        {
            get
            {
                return precioCoste;
            }
            set
            {
                precioCoste = value;
                OnPropertyChanged("precioCoste");
            }
        }
        public double IVA
        {
            get
            {
                return iva;
            }
            set
            {
                iva = value;
                OnPropertyChanged("iva");
            }
        }
        public double PVP
        {
            get
            {
                return pvp;
            }
            set
            {
                pvp = value;
                OnPropertyChanged("pvp");
            }
        }
    }
}