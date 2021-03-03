using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CrisScale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<ComandaAchizitie> Comenzi ;
        public ComandaAchizitie comanda;
        

        public MainWindow()
        {
            Comenzi = new ObservableCollection<ComandaAchizitie>();
            comanda = new ComandaAchizitie();
            comanda.IdPo = 1;
            comanda.NumePo = "PO21000068";
            comanda.IdFurnizor = 2;
            comanda.NumeFurnizor = "SC Furnizorul ( ala de vinde) srl";
            comanda.IdDestinatie = 3;
            comanda.NumeDestinatie = "unde se duce marfa";
            comanda.IdTransportator = 4;
            comanda.NumeTransportator = "ala de face transportul";
            comanda.IdDelegat = 5;
            comanda.NumeDelegat = "Delegat sau De Legat?";
            comanda.IdMasina = 6;
            comanda.NumeMasina = " nr de inmatriculare ";
            comanda.IdSofer = 7;
            comanda.NumeSofer = "Omologul lui Julan";

            Comenzi.Add(comanda);

            InitializeComponent();

            stkComandaAprovizionare.DataContext = Comenzi;


        }

        public void GetComandaAchizitie()
        {
            string queryString = @"
select [PORDERS].ORD AS IdPo
		,PORDERS.ORDNAME AS NumePo
		,SUPPLIERS.SUP AS IdFurnizor
		,SUPPLIERS.SUPDES AS NumeFurnizor
		,CRI_DESTINATII.ID AS IdDestinatie
		,CRI_DESTINATII.NUMEDESTINATIE AS NumeDestinatie
		,CRI_TRANSPORTATOR.ID AS IdTransportator
		,CRI_TRANSPORTATOR.NUMETRANSPORTATOR AS NumeTransportator
		,CRI_DELEGATI.ID AS IdDelegat
		,CRI_DELEGATI.NUMEDELEGAT AS NumeDelegat
		,CRI_MASINI.ID AS IdMasina
		,CRI_MASINI.NUMAR AS NumeMasina
		,CRI_SOFERI.ID AS IdSofer
		,CRI_SOFERI.NUME AS NumeSofer
from [PORDERS]
JOIN SUPPLIERS ON SUPPLIERS.SUP = PORDERS.SUP
LEFT JOIN CRI_DATE_EXP ON CRI_DATE_EXP.ID_DOC_LEG=PORDERS.ORD
LEFT JOIN CRI_DESTINATII ON CRI_DESTINATII.ID=CRI_DATE_EXP.ID_DESTINATIE
LEFT JOIN CRI_TRANSPORTATOR ON CRI_TRANSPORTATOR.ID=CRI_DATE_EXP.ID_TRANSPORTATOR
LEFT JOIN CRI_DELEGATI ON CRI_DELEGATI.ID=CRI_DATE_EXP.ID_DELEGAT
LEFT JOIN CRI_MASINI ON CRI_MASINI.ID=CRI_DATE_EXP.ID_MASINA
LEFT JOIN CRI_SOFERI ON CRI_SOFERI.ID= CRI_DATE_EXP.ID_SOFER
where ORDNAME='" + comanda.NumePo.Trim()+"'";
            string connectionString = @"Data Source=S44022\PRI;Initial Catalog=a012915;Persist Security Info=True;User ID=tabula;Password=tabula~!2;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                //command.Parameters.AddWithValue("@tPatSName", "Your-Parm-Value");
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    if (reader.Read())
                    {
                        Int32 tmp;
                        comanda.IdPo = Convert.ToInt32(reader["IdPo"]);
                        comanda.IdFurnizor = Convert.ToInt32(reader["IdFurnizor"].ToString());
                        comanda.NumeFurnizor = reader["NumeFurnizor"].ToString().Trim();

                        tmp = Int32.TryParse(reader["IdDestinatie"].ToString(), out tmp) ? tmp : 0; 
                        comanda.IdDestinatie = tmp ;

                        comanda.NumeDestinatie = reader["NumeDestinatie"].ToString().Trim();

                        tmp = Int32.TryParse(reader["IdTransportator"].ToString(), out tmp) ? tmp : 0;
                        comanda.IdTransportator = tmp;

                        comanda.NumeTransportator = reader["NumeTransportator"].ToString().Trim();

                        tmp = Int32.TryParse(reader["IdDelegat"].ToString(), out tmp) ? tmp : 0;
                        comanda.IdDelegat = tmp;
                        comanda.NumeDelegat = reader["NumeDelegat"].ToString().Trim();

                        tmp = Int32.TryParse(reader["IdMasina"].ToString(), out tmp) ? tmp : 0;
                        comanda.IdMasina = tmp;
                        comanda.NumeMasina = reader["NumeMasina"].ToString().Trim();

                        tmp = Int32.TryParse(reader["IdSofer"].ToString(), out tmp) ? tmp : 0;
                        comanda.IdSofer = tmp;
                        comanda.NumeSofer = reader["NumeSofer"].ToString().Trim();
                    }
                    
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }
            }

        }

        private void BtnGetPO_Click(object sender, RoutedEventArgs e)
        {
            this.GetComandaAchizitie();

        }
    }
}
