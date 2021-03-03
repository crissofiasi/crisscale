using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace CrisScale
{
    public class ComandaAchizitie : INotifyPropertyChanged
    {
        int idPo;
        public int IdPo { get { return idPo; }
            set
            {
                if (idPo != value)
                {
                    idPo = value;
                    if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("IdPo"));
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
                    if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("NumePo"));
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
                    if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("IdFurnizor"));
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
                    if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("NumeFurnizor"));
                }
            }
        }


        int idDestinatie;
        public int IdDestinatie
        {
            get { return idDestinatie; }
            set
            {
                if (idDestinatie != value)
                {
                    idDestinatie = value;
                    if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("IdDestinatie"));
                }
            }
        }

        string numeDestinatie;
        public string NumeDestinatie
        {
            get { return numeDestinatie; }
            set
            {
                if (numeDestinatie != value)
                {
                    numeDestinatie = value;
                    if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("NumeDestinatie"));
                }
            }
        }


        int idTransportator;
        public int IdTransportator
        {
            get { return idTransportator; }
            set
            {
                if (idTransportator != value)
                {
                    idTransportator = value;
                    if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("IdTransportator"));
                }
            }
        }

        string numeTransportator;
        public string NumeTransportator
        {
            get { return numeTransportator; }
            set
            {
                if (numeTransportator != value)
                {
                    numeTransportator = value;
                    if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("NumeTransportator"));
                }
            }
        }

        int idDelegat;
        public int IdDelegat
        {
            get { return idDelegat; }
            set
            {
                if (idDelegat != value)
                {
                    idDelegat = value;
                    if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("IdDelegat"));
                }
            }
        }

        string numeDelegat;
        public string NumeDelegat
        {
            get { return numeDelegat; }
            set
            {
                if (numeDelegat != value)
                {
                    numeDelegat = value;
                    if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("NumeDelegat"));
                }
            }
        }

        int idMasina;
        public int IdMasina
        {
            get { return idMasina; }
            set
            {
                if (idMasina != value)
                {
                    idMasina = value;
                    if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("IdMasina"));
                }
            }
        }

        string numeMasina;
        public string NumeMasina
        {
            get { return numeMasina; }
            set
            {
                if (numeMasina != value)
                {
                    numeMasina = value;
                    if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("NumeMasina"));
                }
            }
        }

        int idSofer;
        public int IdSofer
        {
            get { return idSofer; }
            set
            {
                if (idSofer != value)
                {
                    idSofer = value;
                    if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("IdSofer"));
                }
            }
        }

        string numeSofer;
        public string NumeSofer
        {
            get { return numeSofer; }
            set
            {
                if (numeSofer != value)
                {
                    numeSofer = value;
                    if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("NumeSofer"));
                }
            }
        }







        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

    }
}
