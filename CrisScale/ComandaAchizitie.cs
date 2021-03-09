using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace CrisScale
{
    public class ComandaAchizitie : Document
    {

        int idPo;
        public int IdPo
        {
            get { return idPo; }
            set
            {
                if (idPo != value)
                {
                    idPo = value;
                    // if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("IdPo"));
                    NotifyPropertyChanged();
                }
            }
        }

        string numePo;
        public string NumePo
        {
            get { return numePo; }
            set
            {
                if (numePo != value)
                {
                    numePo = value;
                    //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NumePo"));
                    NotifyPropertyChanged();
                }
            }
        }

        int idFurnizor;
        public int IdFurnizor
        {
            get { return idFurnizor; }
            set
            {
                if (idFurnizor != value)
                {
                    idFurnizor = value;
                  // if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("IdFurnizor"));
                    NotifyPropertyChanged();
                }
            }
        }

        string numeFurnizor;
        public string NumeFurnizor
        {
            get { return numeFurnizor; }
            set
            {
                if (numeFurnizor != value)
                {
                    numeFurnizor = value;
                    // if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("NumeFurnizor"));
                    NotifyPropertyChanged();
                }
            }
        }



    }
}

