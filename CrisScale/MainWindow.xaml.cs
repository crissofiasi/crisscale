using MySql.Data.MySqlClient;
using System;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;

namespace CrisScale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public ObservableCollection<ComandaAchizitie> Comenzi ;
        public ComandaAchizitie comanda;
        public AvizExpeditie aviz;

        public ObservableCollection<Cantarire> Cantariri;


        public MainWindow()
        {
            //  Comenzi = new ObservableCollection<ComandaAchizitie>();
            comanda = new ComandaAchizitie();
            aviz = new AvizExpeditie();

            //Comenzi.Add(comanda);

            InitializeComponent();

            stkComandaAprovizionare.DataContext = comanda;
            stkAvizBrut.DataContext = aviz;
            Cantariri = new ObservableCollection<Cantarire>();

            GetCantaririDeschise();
            stkCantariri.DataContext = Cantariri;



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
                                    where ORDNAME='" + comanda.NumePo.Trim() + "'";


            var connectionString = ConfigurationManager.ConnectionStrings["priority"].ConnectionString;



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    if (reader.Read())
                    {

                        comanda.IdPo = Convert.ToInt32(reader["IdPo"]);
                        comanda.IdFurnizor = Convert.ToInt32(reader["IdFurnizor"].ToString());
                        comanda.NumeFurnizor = reader["NumeFurnizor"].ToString().Trim();
                        comanda.IdDestinatie = GetInt(reader["IdDestinatie"].ToString());
                        comanda.NumeDestinatie = reader["NumeDestinatie"].ToString().Trim();
                        comanda.IdTransportator = GetInt(reader["IdTransportator"].ToString());
                        comanda.NumeTransportator = reader["NumeTransportator"].ToString().Trim();
                        comanda.IdDelegat = GetInt(reader["IdDelegat"].ToString());
                        comanda.NumeDelegat = reader["NumeDelegat"].ToString().Trim();
                        comanda.IdMasina = GetInt(reader["IdMasina"].ToString());
                        comanda.NumeMasina = reader["NumeMasina"].ToString().Trim();
                        comanda.IdSofer = GetInt(reader["IdSofer"].ToString());
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


        public void GetAvizBrut()
        {
            string queryString = @"
                                    select DOCUMENTS.DOC AS IdSh
                                		,DOCUMENTS.DOCNO AS NumeSh
   		                                ,CUSTOMERS.CUST AS IdClient
	                                	,CUSTOMERS.CUSTDES AS NumeClient
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
                                    from DOCUMENTS
                                    JOIN CUSTOMERS ON CUSTOMERS.CUST = DOCUMENTS.CUST
                                    LEFT JOIN CRI_DATE_EXP ON CRI_DATE_EXP.ID_DOC_LEG=DOCUMENTS.DOC
                                    LEFT JOIN CRI_DESTINATII ON CRI_DESTINATII.ID=CRI_DATE_EXP.ID_DESTINATIE
                                    LEFT JOIN CRI_TRANSPORTATOR ON CRI_TRANSPORTATOR.ID=CRI_DATE_EXP.ID_TRANSPORTATOR
                                    LEFT JOIN CRI_DELEGATI ON CRI_DELEGATI.ID=CRI_DATE_EXP.ID_DELEGAT
                                    LEFT JOIN CRI_MASINI ON CRI_MASINI.ID=CRI_DATE_EXP.ID_MASINA
                                    LEFT JOIN CRI_SOFERI ON CRI_SOFERI.ID= CRI_DATE_EXP.ID_SOFER
                                    where DOCNO='" + aviz.NumeSh.Trim() + "'";


            var connectionString = ConfigurationManager.ConnectionStrings["priority"].ConnectionString;



            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    if (reader.Read())
                    {
                        //aviz.IdSh = Convert.ToInt32(reader["IdSh"]);
                        aviz.IdClient = Convert.ToInt32(reader["IdClient"].ToString());
                        aviz.NumeClient = reader["NumeClient"].ToString().Trim();
                        aviz.IdDestinatie = GetInt(reader["IdDestinatie"].ToString());
                        aviz.NumeDestinatie = reader["NumeDestinatie"].ToString().Trim();
                        aviz.IdTransportator = GetInt(reader["IdTransportator"].ToString());
                        aviz.NumeTransportator = reader["NumeTransportator"].ToString().Trim();
                        aviz.IdDelegat = GetInt(reader["IdDelegat"].ToString());
                        aviz.NumeDelegat = reader["NumeDelegat"].ToString().Trim();
                        aviz.IdMasina = GetInt(reader["IdMasina"].ToString());
                        aviz.NumeMasina = reader["NumeMasina"].ToString().Trim();
                        aviz.IdSofer = GetInt(reader["IdSofer"].ToString());
                        aviz.NumeSofer = reader["NumeSofer"].ToString().Trim();
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

        public void GetCantaririDeschise()
        {

            var connectionString = ConfigurationManager.ConnectionStrings["dsp_scales"].ConnectionString;

            string queryString = @" SELECT `id`, 
                                           `status`, 
                                           `data_in`, 
                                           `ora_in`, 
                                           `data_out`, 
                                           `ora_out`, 
                                           `nr_cantarire_in`,
                                           `greutate_in`, 
                                           `nr_cantarire_out`, 
                                           `greutate_out`, 
                                           `greutate_neta`, 
                                           `tip_operatie`, 
                                           `um`, 
                                           `nume_um`, 
                                           `nr_cantarire`, 
                                           `client`, 
                                           `nume_client`, 
                                           `sofer`, 
                                           `nume_sofer`, 
                                           `transportator`, 
                                           `nume_transp`, 
                                           `material`, 
                                           `nume_material`, 
                                           `destinatie`, 
                                           `nume_destinatie`, 
                                           `masina`, 
                                           `nume_masina`, 
                                           `remorca`, 
                                           `nume_remorca`, 
                                           `nr_axe`,
                                           `tara`, 
                                           `nota`, 
                                           `tip_cantar_in`, 
                                           `tip_cantar_out`, 
                                           `nrcio` 
                                    FROM `cantariri` 
                                    WHERE status = 0";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(queryString, connection);
                try
                {
                    connection.Open();

                    MySqlDataReader reader = command.ExecuteReader();
                    try
                    {
                        while (reader.Read())
                        {
                            Cantarire cantarire = new Cantarire();


                            cantarire.Client = GetInt(reader["client"].ToString());
                            cantarire.Data_in = GetDateTime(reader["data_in"].ToString());
                            cantarire.Data_out = GetDateTime(reader["data_out"].ToString());
                            cantarire.Destinatie = GetInt(reader["destinatie"].ToString());
                            cantarire.Greutate_in = GetInt(reader["greutate_in"].ToString());
                            cantarire.Greutate_neta = GetInt(reader["greutate_neta"].ToString());
                            cantarire.Greutate_out = GetInt(reader["greutate_out"].ToString());
                            cantarire.Id = GetInt(reader["id"].ToString());
                            cantarire.Masina = GetInt(reader["masina"].ToString());
                            cantarire.Material = GetInt(reader["material"].ToString());
                            cantarire.Nota = reader["nota"].ToString();
                            cantarire.Nrcio = GetInt(reader["nrcio"].ToString());
                            cantarire.Nr_axe = GetInt(reader["nr_axe"].ToString());
                            cantarire.Nr_cantarire = GetInt(reader["nr_cantarire"].ToString());
                            cantarire.Nr_cantarire_in = GetInt(reader["nr_cantarire_in"].ToString());
                            cantarire.Nr_cantarire_out = GetInt(reader["nr_cantarire_out"].ToString());
                            cantarire.Nume_client = reader["nume_client"].ToString();
                            cantarire.Nume_destinatie = reader["nume_destinatie"].ToString();
                            cantarire.Nume_masina = reader["nume_masina"].ToString();
                            cantarire.Nume_material = reader["nume_material"].ToString();
                            cantarire.Nume_remorca = reader["nume_remorca"].ToString();
                            cantarire.Nume_sofer = reader["nume_sofer"].ToString();
                            cantarire.Nume_transp = reader["nume_transp"].ToString();
                            cantarire.Nume_um = reader["nume_um"].ToString();
                            cantarire.Ora_in = GetDateTime(reader["ora_in"].ToString());
                            cantarire.Ora_out = GetDateTime(reader["ora_out"].ToString());
                            cantarire.Remorca = GetInt(reader["remorca"].ToString());
                            cantarire.Sofer = GetInt(reader["sofer"].ToString());
                            cantarire.Status = GetInt(reader["status"].ToString());
                            cantarire.Tara = GetInt(reader["tara"].ToString());
                            cantarire.Tip_cantar_in = GetInt(reader["tip_cantar_in"].ToString());
                            cantarire.Tip_cantar_out = GetInt(reader["tip_cantar_out"].ToString());
                            cantarire.Tip_operatie = reader["tip_operatie"].ToString();
                            cantarire.Transportator = GetInt(reader["transportator"].ToString());
                            cantarire.Um = reader["um"].ToString();


                            DateTime di = new DateTime(cantarire.Data_in.Year, cantarire.Data_in.Month, cantarire.Data_in.Day, cantarire.Ora_in.Hour, cantarire.Ora_in.Minute, cantarire.Ora_in.Second);

                            DateTime dout = new DateTime(cantarire.Data_out.Year, cantarire.Data_out.Month, cantarire.Data_out.Day, cantarire.Ora_out.Hour, cantarire.Ora_out.Minute, cantarire.Ora_out.Second);


                            cantarire.Data_in = di;
                            cantarire.Ora_in = di;
                            cantarire.Data_out = dout;
                            cantarire.Ora_out = dout;


                            Cantariri.Add(cantarire);

                        }

                    }
                    finally
                    {
                        // Always call Close when done reading.
                        reader.Close();
                    }

                }
                catch
                {
                    string message = "Nu ma pot conecta la calculatorul de la cantar";
                    string caption = "Eroare cantar";
                    MessageBoxButton buttons = MessageBoxButton.OK;
                    MessageBoxResult result = MessageBox.Show(message, caption, buttons);

                    Cantarire cantarire = new Cantarire();
                    Cantariri.Add(cantarire);
                    App.Current.Shutdown();

                }

            }


        }

        private int GetInt(string s)
        {
            int tmp;
            tmp = Int32.TryParse(s, out tmp) ? tmp : 0;
            return tmp;
        }

        private DateTime GetDateTime(string s)
        {
            DateTime tmp;
            tmp = DateTime.TryParse(s, out tmp) ? tmp : new DateTime();
            return tmp;
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {

            Cantarire c = dtGdCantariri.SelectedItem as Cantarire;

            c.Nume_client = comanda.NumeFurnizor;
            c.Nume_destinatie = comanda.NumeDestinatie;
            c.Nume_transp = comanda.NumeTransportator;
            c.Nume_masina = comanda.NumeMasina;
            c.Nume_sofer = comanda.NumeSofer;

            c.UpdateScale();

            Close();
        }

        private void BtnGetAviz_Click(object sender, RoutedEventArgs e)
        {
            this.GetAvizBrut();
        }

        private void BtnUpdateAviz_Click(object sender, RoutedEventArgs e)
        {
            Cantarire c = dtGdCantariri.SelectedItem as Cantarire;

            c.Nume_client = aviz.NumeClient;
            c.Nume_destinatie = aviz.NumeDestinatie;
            c.Nume_transp = aviz.NumeTransportator;
            c.Nume_masina = aviz.NumeMasina;
            c.Nume_sofer = aviz.NumeSofer;

            c.UpdateScale();

            Close();

        }

        private void BtnRefresh_Click(object sender, RoutedEventArgs e)
        {
            Cantariri.Clear(); 

            GetCantaririDeschise();
        }
    }
}
