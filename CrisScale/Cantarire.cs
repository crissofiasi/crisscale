using MySql.Data.MySqlClient;
using System;
using System.ComponentModel;
using System.Configuration;

namespace CrisScale
{
    public class Cantarire : INotifyPropertyChanged
    {
        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Id"));
                    }
                }
            }
        }

        private int status;
        public int Status
        {
            get { return status; }
            set
            {
                if (status != value)
                {
                    status = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Status"));
                    }
                }
            }
        }

        private DateTime data_in;
        public DateTime Data_in
        {
            get { return data_in; }
            set
            {
                if (data_in != value)
                {
                    data_in = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Data_in"));
                    }
                }
            }
        }

        private DateTime ora_in;
        public DateTime Ora_in
        {
            get { return ora_in; }
            set
            {
                if (ora_in != value)
                {
                    ora_in = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Ora_in"));
                    }
                }
            }
        }

        private DateTime data_out;
        public DateTime Data_out
        {
            get { return data_out; }
            set
            {
                if (data_out != value)
                {
                    data_out = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Data_out"));
                    }
                }
            }

        }

        private DateTime ora_out;
        public DateTime Ora_out
        {
            get { return ora_out; }
            set
            {
                if (ora_out != value)
                {
                    ora_out = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Ora_out"));
                    }
                }
            }
        }

        private int nr_cantarire_in;
        public int Nr_cantarire_in
        {
            get { return nr_cantarire_in; }
            set
            {
                if (nr_cantarire_in != value)
                {
                    nr_cantarire_in = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Nr_cantarire_in"));
                    }
                }
            }
        }

        private double greutate_in;
        public double Greutate_in
        {
            get { return greutate_in; }
            set
            {
                if (greutate_in != value)
                {
                    greutate_in = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Greutate_in"));
                    }
                }
            }
        }

        private int nr_cantarire_out;
        public int Nr_cantarire_out
        {
            get { return nr_cantarire_out; }
            set
            {
                if (nr_cantarire_out != value)
                {
                    nr_cantarire_out = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Nr_cantarire_out"));
                    }
                }
            }
        }

        private double greutate_out;
        public double Greutate_out
        {
            get { return greutate_out; }
            set
            {
                if (greutate_out != value)
                {
                    greutate_out = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Greutate_out"));
                    }
                }
            }
        }

        private double greutate_neta;
        public double Greutate_neta
        {
            get { return greutate_neta; }
            set
            {
                if (greutate_neta != value)
                {
                    greutate_neta = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Greutate_neta"));
                    }
                }
            }
        }

        private string tip_operatie;
        public string Tip_operatie
        {
            get { return tip_operatie; }
            set
            {
                if (tip_operatie != value)
                {
                    tip_operatie = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Tip_operatie"));
                    }
                }
            }
        }

        private string um;
        public string Um
        {
            get { return um; }
            set
            {
                if (um != value)
                {
                    um = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Um"));
                    }
                }
            }
        }

        private string nume_um;
        public string Nume_um
        {
            get { return nume_um; }
            set
            {
                if (nume_um != value)
                {
                    nume_um = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Nume_um"));
                    }
                }
            }
        }

        private int nr_cantarire;
        public int Nr_cantarire
        {
            get { return nr_cantarire; }
            set
            {
                if (nr_cantarire != value)
                {
                    nr_cantarire = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Nr_cantarire"));
                    }
                }
            }
        }

        private int client;
        public int Client
        {
            get { return client; }
            set
            {
                if (client != value)
                {
                    client = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Client"));
                    }
                }
            }
        }

        private string nume_client;
        public string Nume_client
        {
            get { return nume_client; }
            set
            {
                if (nume_client != value)
                {
                    nume_client = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Nume_client"));
                    }
                }
            }
        }

        private int sofer;
        public int Sofer
        {
            get { return sofer; }
            set
            {
                if (sofer != value)
                {
                    sofer = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Sofer"));
                    }
                }
            }
        }

        private string nume_sofer;
        public string Nume_sofer
        {
            get { return nume_sofer; }
            set
            {
                if (nume_sofer != value)
                {
                    nume_sofer = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Nume_sofer"));
                    }
                }
            }
        }

        private int transportator;
        public int Transportator
        {
            get { return transportator; }
            set
            {
                if (transportator != value)
                {
                    transportator = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Transportator"));
                    }
                }
            }
        }

        private string nume_transp;
        public string Nume_transp
        {
            get { return nume_transp; }
            set
            {
                if (nume_transp != value)
                {
                    nume_transp = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Nume_transp"));
                    }
                }
            }
        }

        private int material;
        public int Material
        {
            get { return material; }
            set
            {
                if (material != value)
                {
                    material = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Material"));
                    }
                }
            }
        }

        private string nume_material;
        public string Nume_material
        {
            get { return nume_material; }
            set
            {
                if (nume_material != value)
                {
                    nume_material = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Nume_material"));
                    }
                }
            }
        }

        private int destinatie;
        public int Destinatie
        {
            get { return destinatie; }
            set
            {
                if (destinatie != value)
                {
                    destinatie = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Destinatie"));
                    }
                }
            }
        }

        private string nume_destinatie;
        public string Nume_destinatie
        {
            get { return nume_destinatie; }
            set
            {
                if (nume_destinatie != value)
                {
                    nume_destinatie = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Nume_destinatie"));
                    }
                }
            }
        }

        private int masina;
        public int Masina
        {
            get { return masina; }
            set
            {
                if (masina != value)
                {
                    masina = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Masina"));
                    }
                }
            }
        }

        private string nume_masina;
        public string Nume_masina
        {
            get { return nume_masina; }
            set
            {
                if (nume_masina != value)
                {
                    nume_masina = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Nume_masina"));
                    }
                }
            }
        }

        private int remorca;
        public int Remorca
        {
            get { return remorca; }
            set
            {
                if (remorca != value)
                {
                    remorca = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Remorca"));
                    }
                }
            }
        }

        private string nume_remorca;
        public string Nume_remorca
        {
            get { return nume_remorca; }
            set
            {
                if (nume_remorca != value)
                {
                    nume_remorca = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Nume_remorca"));
                    }
                }
            }
        }

        private int nr_axe;
        public int Nr_axe
        {
            get { return nr_axe; }
            set
            {
                if (nr_axe != value)
                {
                    nr_axe = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Nr_axe"));
                    }
                }
            }
        }

        private double tara;
        public double Tara
        {
            get { return tara; }
            set
            {
                if (tara != value)
                {
                    tara = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Tara"));
                    }
                }
            }
        }

        private string nota;
        public string Nota
        {
            get { return nota; }
            set
            {
                if (nota != value)
                {
                    nota = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Nota"));
                    }
                }
            }
        }

        private int tip_cantar_in;
        public int Tip_cantar_in
        {
            get { return tip_cantar_in; }
            set
            {
                if (tip_cantar_in != value)
                {
                    tip_cantar_in = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Tip_cantar_in"));
                    }
                }
            }
        }

        private int tip_cantar_out;
        public int Tip_cantar_out
        {
            get { return tip_cantar_out; }
            set
            {
                if (tip_cantar_out != value)
                {
                    tip_cantar_out = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Tip_cantar_out"));
                    }
                }
            }
        }

        private int nrcio;
        public int Nrcio
        {
            get { return nrcio; }
            set
            {
                if (nrcio != value)
                {
                    nrcio = value;
                    if (PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Nrcio"));
                    }
                }
            }
        }


        public void UpdateScale()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["dsp_scales"].ConnectionString;

            GetClientId();
            GetTransportatorId();
            AsociereTransportator();
            GetMasinaId();
            AsociereMasina();
            GetSoferId();
            AsociereSoferTransportator();
            AsociereSoferMasina();






            string queryString = @"
                                    UPDATE `cantariri` 
                                    SET `status`=@status,
                                        `data_in`=@data_in,
                                        `ora_in`=@ora_in,
                                        `data_out`=@data_out,
                                        `ora_out`=@ora_out,
                                        `nr_cantarire_in`=@nr_cantarire_in,
                                        `greutate_in`=@greutate_in,
                                        `nr_cantarire_out`=@nr_cantarire_out,
                                        `greutate_out`=@greutate_out,
                                        `greutate_neta`=@greutate_neta,
                                        `tip_operatie`=@tip_operatie,
                                        `um`=@um,
                                        `nume_um`=@nume_um,
                                        `nr_cantarire`=@nr_cantarire,
                                        `client`=@client,
                                        `nume_client`=@nume_client,
                                        `sofer`=@sofer,
                                        `nume_sofer`=@nume_sofer,
                                        `transportator`=@transportator,
                                        `nume_transp`=@nume_transp,
                                        `material`=@material,
                                        `nume_material`=@nume_material,
                                        `destinatie`=@destinatie,
                                        `nume_destinatie`=@nume_destinatie,
                                        `masina`=@masina,
                                        `nume_masina`=@nume_masina,
                                        `remorca`=@remorca,
                                        `nume_remorca`=@nume_remorca,
                                        `nr_axe`=@nr_axe,
                                        `tara`=@tara,
                                        `nota`=@nota,
                                        `tip_cantar_in`=@tip_cantar_in,
                                        `tip_cantar_out`=@tip_cantar_out,
                                        `nrcio`=@nrcio 
                                        WHERE `id`=@id";





            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                MySqlCommand cmd = new MySqlCommand(queryString, connection);
                connection.Open();

                cmd.Parameters.AddWithValue("@status", this.status);
                cmd.Parameters.AddWithValue("@data_in", this.data_in);
                cmd.Parameters.AddWithValue("@ora_in", this.ora_in);
                cmd.Parameters.AddWithValue("@data_out", this.data_out);
                cmd.Parameters.AddWithValue("@ora_out", this.ora_out);
                cmd.Parameters.AddWithValue("@nr_cantarire_in", this.nr_cantarire_in);
                cmd.Parameters.AddWithValue("@greutate_in", this.greutate_in);
                cmd.Parameters.AddWithValue("@nr_cantarire_out", this.nr_cantarire_out);
                cmd.Parameters.AddWithValue("@greutate_out", this.greutate_out);
                cmd.Parameters.AddWithValue("@greutate_neta", this.greutate_neta);
                cmd.Parameters.AddWithValue("@tip_operatie", this.tip_operatie);
                cmd.Parameters.AddWithValue("@um", this.um);
                cmd.Parameters.AddWithValue("@nume_um", this.nume_um);
                cmd.Parameters.AddWithValue("@nr_cantarire", this.nr_cantarire);
                cmd.Parameters.AddWithValue("@client", this.client);
                cmd.Parameters.AddWithValue("@nume_client", this.nume_client);
                cmd.Parameters.AddWithValue("@sofer", this.sofer);
                cmd.Parameters.AddWithValue("@nume_sofer", this.nume_sofer);
                cmd.Parameters.AddWithValue("@transportator", this.transportator);
                cmd.Parameters.AddWithValue("@nume_transp", this.nume_transp);
                cmd.Parameters.AddWithValue("@material", this.material);
                cmd.Parameters.AddWithValue("@nume_material", this.nume_material);
                cmd.Parameters.AddWithValue("@destinatie", this.destinatie);
                cmd.Parameters.AddWithValue("@nume_destinatie", this.nume_destinatie);
                cmd.Parameters.AddWithValue("@masina", this.masina);
                cmd.Parameters.AddWithValue("@nume_masina", this.nume_masina);
                cmd.Parameters.AddWithValue("@remorca", this.remorca);
                cmd.Parameters.AddWithValue("@nume_remorca", this.nume_remorca);
                cmd.Parameters.AddWithValue("@nr_axe", this.nr_axe);
                cmd.Parameters.AddWithValue("@tara", this.tara);
                cmd.Parameters.AddWithValue("@nota", this.nota);
                cmd.Parameters.AddWithValue("@tip_cantar_in", this.tip_cantar_in);
                cmd.Parameters.AddWithValue("@tip_cantar_out", this.tip_cantar_out);
                cmd.Parameters.AddWithValue("@nrcio", this.nrcio);
                cmd.Parameters.AddWithValue("@id", this.id);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    connection.Close();
                }
            }


        }

        public void GetClientId()
        {
            bool ok = false;
            var connectionString = ConfigurationManager.ConnectionStrings["dsp_scales"].ConnectionString;

            while (!ok)
            {
                string queryString = @" SELECT `id`, 
                                           `nume_firma`
                                    FROM  `clienti_furnizori`
                                    WHERE `nume_firma` = '" + this.nume_client + "'";

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    MySqlCommand command = new MySqlCommand(queryString, connection);
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    int i = 0;
                    try
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                this.client = GetInt(reader["id"].ToString());
                                ok = true;
                            }
                        }


                    }
                    finally
                    {
                        // Always call Close when done reading.
                        reader.Close();
                    }

                    if (!ok)
                    {
                        queryString = @" INSERT INTO `clienti_furnizori` (`nume_firma`,`client`,`furnizor`) VALUES ( @nume_firma,1,1)";
                        MySqlCommand cmd = new MySqlCommand(queryString, connection);
                        if (connection.State == 0)
                        {
                            connection.Open();
                        }

                        cmd.Parameters.AddWithValue("@nume_firma", this.nume_client);

                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch
                        {

                        }
                        finally
                        {
                            connection.Close();
                        }

                    }

                }
            }
        }


        public void GetTransportatorId()
        {
            bool ok = false;
            var connectionString = ConfigurationManager.ConnectionStrings["dsp_scales"].ConnectionString;

            while (!ok)
            {
                string queryString = @" SELECT `id`, 
                                           `name`
                                    FROM  `transportatori`
                                    WHERE `name` = '" + this.nume_transp + "'";


                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    MySqlCommand command = new MySqlCommand(queryString, connection);
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    int i = 0;
                    try
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                this.transportator = GetInt(reader["id"].ToString());
                                ok = true;
                            }
                        }


                    }
                    finally
                    {
                        // Always call Close when done reading.
                        reader.Close();
                    }

                    if (!ok)
                    {
                        queryString = @" INSERT INTO `transportatori` (`name`) VALUES ( @nume_firma)";
                        MySqlCommand cmd = new MySqlCommand(queryString, connection);
                        if (connection.State == 0)
                        {
                            connection.Open();
                        }

                        cmd.Parameters.AddWithValue("@nume_firma", this.nume_transp);
                        i = 0;
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch
                        {

                        }
                        finally
                        {
                            connection.Close();
                        }

                    }

                }
            }
        }


        public void AsociereTransportator()
        {

            bool ok = false;
            var connectionString = ConfigurationManager.ConnectionStrings["dsp_scales"].ConnectionString;

            while (!ok)
            {
                string queryString = @" SELECT id FROM `cf_transport` WHERE `id_cf`= " + this.client.ToString() + " and  `id_transp` = " + this.transportator.ToString();


                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    MySqlCommand command = new MySqlCommand(queryString, connection);
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    int i = 0;
                    try
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                ok = true;
                            }
                        }


                    }
                    finally
                    {
                        // Always call Close when done reading.
                        reader.Close();
                    }

                    if (!ok)
                    {
                        queryString = @" INSERT INTO `cf_transport` (`id_cf`,`id_transp`) VALUES ( @client,@transportator)";
                        MySqlCommand cmd = new MySqlCommand(queryString, connection);
                        if (connection.State == 0)
                        {
                            connection.Open();
                        }

                        cmd.Parameters.AddWithValue("@client", this.client.ToString());
                        cmd.Parameters.AddWithValue("@transportator", this.transportator.ToString());
                        i = 0;
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch
                        {

                        }
                        finally
                        {
                            connection.Close();
                        }

                    }

                }
            }



        }

        public void GetMasinaId()
        {
            bool ok = false;
            var connectionString = ConfigurationManager.ConnectionStrings["dsp_scales"].ConnectionString;

            while (!ok)
            {
                string queryString = @" SELECT `id`, 
                                           `nr_inmat`
                                    FROM  `masini`
                                    WHERE `nr_inmat` = '" + this.nume_masina + "'";


                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    MySqlCommand command = new MySqlCommand(queryString, connection);
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    int i = 0;
                    try
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                this.Masina = GetInt(reader["id"].ToString());
                                ok = true;
                            }
                        }


                    }
                    finally
                    {
                        // Always call Close when done reading.
                        reader.Close();
                    }

                    if (!ok)
                    {
                        queryString = @" INSERT INTO `masini` (`nr_inmat`,`nr_axe`,`activ`) VALUES ( @nr_inmat,5,'activ')";
                        MySqlCommand cmd = new MySqlCommand(queryString, connection);
                        if (connection.State == 0)
                        {
                            connection.Open();
                        }

                        cmd.Parameters.AddWithValue("@nr_inmat", this.nume_masina);
                        i = 0;
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch
                        {

                        }
                        finally
                        {
                            connection.Close();
                        }

                    }

                }
            }
        }



        public void AsociereMasina()
        {

            bool ok = false;
            var connectionString = ConfigurationManager.ConnectionStrings["dsp_scales"].ConnectionString;

            while (!ok)
            {
                string queryString = @" SELECT id FROM `transp_masini` WHERE `id_transp`= " + this.transportator.ToString() + " and  `id_masina` = " + this.Masina.ToString();


                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    MySqlCommand command = new MySqlCommand(queryString, connection);
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    int i = 0;
                    try
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                ok = true;
                            }
                        }


                    }
                    finally
                    {
                        // Always call Close when done reading.
                        reader.Close();
                    }

                    if (!ok)
                    {
                        queryString = @" INSERT INTO `transp_masini` (`id_masina`,`id_transp`) VALUES ( @masina,@transportator)";
                        MySqlCommand cmd = new MySqlCommand(queryString, connection);
                        if (connection.State == 0)
                        {
                            connection.Open();
                        }

                        cmd.Parameters.AddWithValue("@masina", this.masina.ToString());
                        cmd.Parameters.AddWithValue("@transportator", this.transportator.ToString());
                        i = 0;
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch
                        {

                        }
                        finally
                        {
                            connection.Close();
                        }

                    }

                }
            }

        }



        public void GetSoferId()
        {
            bool ok = false;
            var connectionString = ConfigurationManager.ConnectionStrings["dsp_scales"].ConnectionString;

            while (!ok)
            {
                string queryString = @" SELECT `id`, 
                                           `nume`
                                    FROM  `soferi`
                                    WHERE `nume` = '" + this.nume_sofer + "'";


                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    MySqlCommand command = new MySqlCommand(queryString, connection);
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    int i = 0;
                    try
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                this.sofer = GetInt(reader["id"].ToString());
                                ok = true;
                            }
                        }


                    }
                    finally
                    {
                        // Always call Close when done reading.
                        reader.Close();
                    }

                    if (!ok)
                    {
                        queryString = @" INSERT INTO `soferi` (`nume`,`activ`) VALUES ( @nume,1)";
                        MySqlCommand cmd = new MySqlCommand(queryString, connection);
                        if (connection.State == 0)
                        {
                            connection.Open();
                        }

                        cmd.Parameters.AddWithValue("@nume", this.nume_sofer);
                        i = 0;
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch
                        {

                        }
                        finally
                        {
                            connection.Close();
                        }

                    }

                }
            }
        }


        public void AsociereSoferTransportator()
        {

            bool ok = false;
            var connectionString = ConfigurationManager.ConnectionStrings["dsp_scales"].ConnectionString;

            while (!ok)
            {
                string queryString = @" SELECT id FROM `transp_soferi` WHERE `id_transp`= " + this.transportator.ToString() + " and  `id_sof` = " + this.sofer.ToString();


                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    MySqlCommand command = new MySqlCommand(queryString, connection);
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    int i = 0;
                    try
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                ok = true;
                            }
                        }


                    }
                    finally
                    {
                        // Always call Close when done reading.
                        reader.Close();
                    }

                    if (!ok)
                    {
                        queryString = @" INSERT INTO `transp_soferi` (`id_sof`,`id_transp`,`activ`) VALUES ( @sofer,@transportator,1)";
                        MySqlCommand cmd = new MySqlCommand(queryString, connection);
                        if (connection.State == 0)
                        {
                            connection.Open();
                        }

                        cmd.Parameters.AddWithValue("@sofer", this.sofer.ToString());
                        cmd.Parameters.AddWithValue("@transportator", this.transportator.ToString());
                        i = 0;
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch
                        {

                        }
                        finally
                        {
                            connection.Close();
                        }

                    }

                }
            }

        }



        public void AsociereSoferMasina()
        {

            bool ok = false;
            var connectionString = ConfigurationManager.ConnectionStrings["dsp_scales"].ConnectionString;

            while (!ok)
            {
                string queryString = @" SELECT id FROM `sofer_masina` WHERE `id_masina`= " + this.masina.ToString() + " and  `id_sofer` = " + this.sofer.ToString();


                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    MySqlCommand command = new MySqlCommand(queryString, connection);
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();
                    int i = 0;
                    try
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                ok = true;
                            }
                        }


                    }
                    finally
                    {
                        // Always call Close when done reading.
                        reader.Close();
                    }

                    if (!ok)
                    {
                        queryString = @" INSERT INTO `sofer_masina` (`id_sofer`,`id_masina`) VALUES ( @sofer,@masina)";
                        MySqlCommand cmd = new MySqlCommand(queryString, connection);
                        if (connection.State == 0)
                        {
                            connection.Open();
                        }

                        cmd.Parameters.AddWithValue("@sofer", this.sofer.ToString());
                        cmd.Parameters.AddWithValue("@masina", this.masina.ToString());
                        i = 0;
                        try
                        {
                            cmd.ExecuteNonQuery();
                        }
                        catch
                        {

                        }
                        finally
                        {
                            connection.Close();
                        }

                    }

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


        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion
    }
}
