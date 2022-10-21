using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace VMMV.Model
{
    public class Dependiente : INotifyPropertyChanged
    {
        private string segSocial;
        private string nombre;
        private string apellido1;
        private string apellido2;
        private double comision;

        public string SegSocial
        {
            get
            {
                return segSocial;
            }
            set
            {
                segSocial = value;
                OnPropertyChanged("segSocial");
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
                OnPropertyChanged("nombre");
            }
        }
        public string Apellido1
        {
            get
            {
                return apellido1;
            }
            set
            {
                apellido1 = value;
                OnPropertyChanged("apellido1");
            }
        }
        public string Apellido2
        {
            get
            {
                return apellido2;
            }
            set
            {
                apellido2 = value;
                OnPropertyChanged("apellido2");
            }
        }
        public double Comision
        {
            get
            {
                return comision;
            }
            set
            {
                comision = value;
                OnPropertyChanged("comision");
            }
        }

    }
}
