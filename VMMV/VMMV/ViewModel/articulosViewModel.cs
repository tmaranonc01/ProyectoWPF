using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using VMMV.ViewModel;
using System.Windows.Input;
using VMMV.Model;

namespace VMMV.ViewModel
{
    public class ArticlosViewModel
    {
        private List<Articulos> ArticulosList;

        public ArticlosViewModel()
        {
            ArticulosList = new List<Articulos>
            {
               new Articulos{IdArticulo = 1, Descripcion = "Beniwal", PrecioCoste = 20, IVA = 10},
               new Articulos{2,"naicobot2",1,21,1.21},
               new Articulos{3,"naicobot3",1,21,1.21},
               new Articulos{4,"naicobot4",1,21,1.21},
            };
        }

        public IList<Articulos> articulos
        {
            get { return ArticulosList; }
            set { ArticulosList = value; }
        }

        private ICommand mUpdater;
        public ICommand UpdateCommand
        {
            get
            {
                if (mUpdater == null)
                    mUpdater = new Updater();
                return mUpdater;
            }
            set
            {
                mUpdater = value;
            }
        }
        private class Updater : ICommand
        {
            #region ICommand Members
            public bool CanExecute(object parameter)
            {
                return true;
            }
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {

        }

        #endregion
    }
}