using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrisScale
{
    public class AvizExpeditie : Document
    {

        int idSh;
        public int IdSh
        {
            get { return idSh; }
            set
            {
                if (idSh != value)
                {
                    idSh = value;
                    NotifyPropertyChanged();
                }
            }
        }

        string numeSh;
        public string NumeSh
        {
            get { return numeSh; }
            set
            {
                if (numeSh != value)
                {
                    numeSh = value;
                    NotifyPropertyChanged();
                }
            }
        }

        int idClient;
        public int IdClient
        {
            get { return idClient; }
            set
            {
                if (idClient != value)
                {
                    idClient = value;
                    NotifyPropertyChanged();
                }
            }
        }

        string numeClient;
        public string NumeClient
        {
            get { return numeClient; }
            set
            {
                if (numeClient != value)
                {
                    numeClient = value;
                    NotifyPropertyChanged();
                }
            }
        }





        
    }
}
