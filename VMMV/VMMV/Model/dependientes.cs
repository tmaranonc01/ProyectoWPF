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
        public string Nombre {
            get
            {
               return nombre;
            }
            set => nombre = value; 
        }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public double Comision { get => comision; set => comision = value; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
