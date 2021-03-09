using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CrisScale
{
    public class Document : INotifyPropertyChanged
    {
       

       

       


        int idDestinatie;
        public int IdDestinatie
        {
            get { return idDestinatie; }
            set
            {
                if (idDestinatie != value)
                {
                    idDestinatie = value;
                    NotifyPropertyChanged();
                    //if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("IdDestinatie"));
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
                    NotifyPropertyChanged();
                    //if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("NumeDestinatie"));
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
                    NotifyPropertyChanged();
                    //if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("IdTransportator"));
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
                    NotifyPropertyChanged();
                    // if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("NumeTransportator"));
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
                    NotifyPropertyChanged();
                    //if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("IdDelegat"));
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
                    NotifyPropertyChanged();
                    //if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("NumeDelegat"));
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
                    NotifyPropertyChanged();
                    //if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("IdMasina"));
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
                    NotifyPropertyChanged();
                    // if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("NumeMasina"));
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
                    NotifyPropertyChanged();
                    // if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("IdSofer"));
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
                    NotifyPropertyChanged();
                    //if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("NumeSofer"));
                }
            }
        }







        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        //public event PropertyChangedEventHandler PropertyChanged;
        #endregion

    }
}
