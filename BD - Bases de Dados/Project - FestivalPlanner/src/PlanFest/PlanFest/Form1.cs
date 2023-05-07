using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PlanFest
{
    public partial class PlanFest : Form
    {
        private SqlConnection CN;
        private Festival festival = new Festival();
        private Promoter promoter = new Promoter();
        private Manager manager = new Manager();
        private Concert concert = new Concert();
        public PlanFest()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hideAll();
            form_login.Show();
        }

        // MSSQL Connection
        private SqlConnection getSGBDConnection()
        {
            /* ---------- For testing only ----------  */
            //return new SqlConnection("data source=WIN11\\SQLEXPRESS;integrated security=true;initial catalog=Projeto");
            /* ---------- For testing only ----------  */

            return new SqlConnection("Data Source = " + server_input.Text + " ;" + "Initial Catalog = " + user_input.Text + "; uid = " + user_input.Text + ";" + "password = " + password_input.Text);
        }

        private bool TestDBConnection()
        {
            bool temp = false;
            CN = getSGBDConnection();
            try
            {
                CN.Open();
                if (CN.State == ConnectionState.Open)
                {
                    MessageBox.Show("Successful connection to database " + CN.Database + " on the " + CN.DataSource + " server", "Connection Test", MessageBoxButtons.OK);
                    temp = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE DUE TO THE FOLLOWING ERROR \r\n" + ex.Message, "Connection Test", MessageBoxButtons.OK);
                temp = false;
            }

            return temp;
        }

        private bool verifySGBDConnection()
        {
            if (CN == null)
                CN = getSGBDConnection();

            if (CN.State != ConnectionState.Open)
                CN.Open();

            return CN.State == ConnectionState.Open;
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            bool temp = TestDBConnection();
            CN.Close();
            if (temp)
            {
                loadFestivals();
                openPanel(panel_openinglist);

            }
        }
        // End MSSQL Connection

        // Switch panel controls
        private void hideAll()
        {
            
            foreach (var pnl in Controls.OfType<Panel>())
            {
                pnl.Hide();
            }
        }

        private void openPanel(Panel e)
        {
            hideAll();
            panel_base.Show();
            e.BringToFront();
            e.Show();
        }
        // End Switch panel controls

        // Festivals Lists
        private void loadFestivals()
        {
            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand("select * from getOverviewBy(@festivalname, @ndays, @promname,@prommail,@promphone, @bandname)", CN);
            cmd.Parameters.AddWithValue("@festivalname",textBox_searchfestivalname.Text);
            cmd.Parameters.AddWithValue("@ndays", textBox_searchndays.Text);
            cmd.Parameters.AddWithValue("@promname", textBox_searchpromotername.Text);
            cmd.Parameters.AddWithValue("@prommail", textBox_searchpromoteremail.Text);
            cmd.Parameters.AddWithValue("@promphone", textBox_searchpromoterphone.Text);
            cmd.Parameters.AddWithValue("@bandname", textBox_searchbandname.Text);
            gridview_festivals.Rows.Clear();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string[] row =
                {
                    reader["id"].ToString(),
                    reader["EVENTO_NOME"].ToString(),
                    reader["dataInicio"].ToString(),
                    reader["nDias"].ToString(),
                    reader["PROMOTOR_NOME"].ToString(),
                    reader["PROMOTOR_EMAIL"].ToString(),
                    reader["PROMOTOR_TELEFONE"].ToString(),
                    reader["nome"].ToString()
                };
                gridview_festivals.Rows.Add(row);
            }

            CN.Close();
        }

        private void gridview_festivals_SelectChange(object sender, EventArgs e)
        {
            if (gridview_festivals.SelectedRows.Count >= 0)
                btn_openfestival.Enabled = true;
                
        }

        private void btn_searchfestival_Click(object sender, EventArgs e)
        {
            loadFestivals();
        }

        private void btn_openfestival_Click(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;

            string id = gridview_festivals.SelectedRows[0].Cells[0].Value.ToString();
            Console.WriteLine(id);
            SqlCommand cmd = new SqlCommand("SELECT * FROM getEventoById(@id);", CN);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();
            this.festival = new Festival(
                id: id,
                name: reader["nome"].ToString(),
                nDays: Int32.Parse(reader["nDias"].ToString()),
                dateBegin: reader["dataInicio"].ToString(),
                dateEnd: reader["dataFim"].ToString(),
                dateProposal: reader["dataProposta"].ToString(),
                nTickets: Int32.Parse(reader["nBilhetes"].ToString()),
                promoter: this.promoter,
                manager: this.manager
                );

            CN.Close();
            updateFestivalView();
            openPanel(panel_festival);
            btn_festivals.Enabled = true;
            btn_concerts.Enabled = true;
            btn_stages.Enabled = true;
            btn_bands.Enabled = true;
            btn_meals.Enabled = true;
            btn_staff.Enabled = true;
        }

        private void btn_addfestival_Click(object sender, EventArgs e)
        {
            this.festival = new Festival();
            this.promoter = new Promoter();
            this.manager = new Manager();
            textBox_festivalname.Enabled = true;
            datepicker_festivalbegin.Enabled = true;
            datepicker_festivalend.Enabled = true;
            datepicker_proposal.Enabled = true;
            numericUpDown_ticketssold.Enabled = true;
            textBox_promoter_cc.Enabled = true;
            textBox_manager_cc.Enabled = true;
            promoter_type.Enabled = true;
            manager_type.Enabled = true;
            btn_editfestival.Text = "Create";
            resetFestivalView();
            openPanel(panel_festival);
        }
        // End Festivals Lists

        // Festival details
        private void readFestivalView()
        {
            DateTime start = datepicker_festivalbegin.Value;
            DateTime end = datepicker_festivalend.Value;
            int numdias = (int)(end - start).TotalDays;

            if (btn_editfestival.Text == "Create")
                label_festivalid.Text = DateTime.Now.Millisecond.ToString();

            this.festival = new Festival(
                id: label_festivalid.Text,
                name: textBox_festivalname.Text,
                dateBegin: datepicker_festivalbegin.Value.ToString(),
                dateEnd: datepicker_festivalend.Value.ToString(),
                dateProposal: datepicker_proposal.Value.ToString(),
                nDays: numdias,
                nTickets: (int)numericUpDown_ticketssold.Value,
                promoter: this.promoter,
                manager: this.manager
                );
            loadPromoter();
            loadManager();
        }

        private void resetFestivalView()
        {
            textBox_festivalname.ResetText();
            datepicker_festivalbegin.ResetText();
            datepicker_festivalend.ResetText();
            datepicker_proposal.ResetText();
            numericUpDown_ticketssold.ResetText();
            label_festivalid.ResetText();
            promoter_type.ResetText();
            manager_type.ResetText();
            textBox_promoter_cc.ResetText();
            textBox_manager_cc.ResetText();
            promoter_name.ResetText();
            manager_name.ResetText();
            promoter_email.ResetText();
            manager_email.ResetText();
            promoter_sex.ResetText();
            manager_sex.ResetText();
        }
        private void updateFestivalView()
        {
            textBox_festivalname.Text = this.festival.name;
            datepicker_festivalbegin.Value = DateTime.Parse(this.festival.dateBegin);
            datepicker_festivalend.Value = DateTime.Parse(this.festival.dateEnd);
            datepicker_proposal.Value = DateTime.Parse(this.festival.dateProposal);
            numericUpDown_ticketssold.Value = this.festival.nTickets;
            label_festivalid.Text = this.festival.id.ToString();
            loadPromoter();
            loadManager();
        }

        private void loadPromoter()
        {
            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CN;
            cmd.Parameters.Clear();
            if (btn_editfestival.Text == "Create")
            {
                cmd.CommandText = "SELECT * FROM FP.Pessoa WHERE cc = @cc;";
                cmd.Parameters.AddWithValue("@cc", textBox_promoter_cc.Text);
            }
            else
            {
                cmd.CommandText = "SELECT Pessoa.* FROM FP.Evento INNER JOIN (SELECT FP.Promotor.tipo, FP.Pessoa.* FROM FP.Promotor INNER JOIN FP.Pessoa ON FP.Promotor.cc = FP.Pessoa.cc) AS Pessoa ON FP.Evento.cc_promotor = Pessoa.cc WHERE FP.Evento.id = @festivalID";
                cmd.Parameters.AddWithValue("@festivalID", this.festival.id);
            }
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            this.promoter.name = promoter_name.Text = reader["nome"].ToString();
            this.promoter.email = promoter_email.Text = reader["email"].ToString();
            this.promoter.sex = promoter_sex.Text = reader["sexo"].ToString();
            this.promoter.telephone = promoter_phone.Text = reader["telefone"].ToString();
            this.promoter.cc = textBox_promoter_cc.Text = reader["cc"].ToString();
            if (btn_editfestival.Text == "Save" || btn_editfestival.Text == "Create")
            {
                this.promoter.type = promoter_type.Text;
            } 
            else
            {
                this.promoter.type = promoter_type.Text = reader["tipo"].ToString();
            }
            this.promoter.festival = this.festival;
            CN.Close();
        }

        private void loadManager()
        {
            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = CN;
            if (btn_editfestival.Text == "Create")
            {
                cmd.CommandText = "SELECT * FROM FP.Pessoa WHERE cc = @cc;";
                cmd.Parameters.AddWithValue("@cc", textBox_manager_cc.Text);
            }
            else
            {
                cmd.CommandText = "SELECT Pessoa.* FROM FP.Evento INNER JOIN (SELECT FP.Manager.tipo, FP.Pessoa.* FROM FP.Manager INNER JOIN FP.Pessoa ON FP.Manager.cc = FP.Pessoa.cc) AS Pessoa ON FP.Evento.cc_manager = Pessoa.cc WHERE FP.Evento.id = @festivalID";
                cmd.Parameters.AddWithValue("@festivalID", this.festival.id);
            }
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            this.manager.name = manager_name.Text = reader["nome"].ToString();
            this.manager.email = manager_email.Text = reader["email"].ToString();
            this.manager.sex = manager_sex.Text = reader["sexo"].ToString();
            this.manager.telephone = manager_phone.Text = reader["telefone"].ToString();
            this.manager.cc = textBox_manager_cc.Text = reader["cc"].ToString();
            if (btn_editfestival.Text == "Save" || btn_editfestival.Text == "Create")
            {
                this.manager.type = manager_type.Text;
            }
            else
            {
                this.manager.type = manager_type.Text = reader["tipo"].ToString();
            }
            this.manager.festival = this.festival;

            CN.Close();
        }
        
        private void btn_editfestival_Click(object sender, EventArgs e)
        {
            if (btn_editfestival.Text == "Edit")
            {
                btn_editfestival.Text = "Save";
                textBox_festivalname.Enabled = true;
                datepicker_festivalbegin.Enabled = true;
                datepicker_festivalend.Enabled = true;
                datepicker_festivalend.Enabled = true;
                datepicker_proposal.Enabled = true;
                numericUpDown_ticketssold.Enabled = true;
                textBox_promoter_cc.Enabled = true;
                textBox_manager_cc.Enabled = true;
                promoter_type.Enabled = true;
                manager_type.Enabled = true;
            }
            else
            {
                readFestivalView();
                if (!verifySGBDConnection())
                    return;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = CN;
                cmd.Parameters.Clear();
                if (btn_editfestival.Text == "Create")
                {
                    cmd.CommandText = "EXEC create_evento @festivalID," + "@festival_name," + "@num_dias," + "@begin_date," + "@end_date," + "@num_tickets," + "@proposal_date," + "@promoter_cc," + "@manager_cc;";
                }
                else
                {
                    cmd.CommandText = "EXEC alter_evento @festivalID," + "@festival_name," + "@num_dias," + "@begin_date," + "@end_date," + "@num_tickets," + "@proposal_date," + "@promoter_cc," + "@manager_cc;";
                }
                cmd.Parameters.AddWithValue("@festivalID", this.festival.id);
                cmd.Parameters.AddWithValue("@festival_name", this.festival.name);
                cmd.Parameters.AddWithValue("@num_dias", this.festival.nDays);
                cmd.Parameters.AddWithValue("@begin_date", DateTime.Parse(this.festival.dateBegin));
                cmd.Parameters.AddWithValue("@end_date", DateTime.Parse(this.festival.dateEnd));
                cmd.Parameters.AddWithValue("@num_tickets", this.festival.nTickets);
                cmd.Parameters.AddWithValue("@proposal_date", DateTime.Parse(this.festival.dateProposal));
                cmd.Parameters.AddWithValue("@promoter_cc", this.festival.promoter.cc);
                cmd.Parameters.AddWithValue("@manager_cc", this.festival.manager.cc);

                try
                {
                    cmd.ExecuteNonQuery();
                    CN.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Failed to update festival in database. \n ERROR MESSAGE: \n" + ex.Message);
                }

                if (!verifySGBDConnection())
                    return;
                cmd = new SqlCommand();
                cmd.Connection = CN;
                cmd.Parameters.Clear();
                cmd.CommandText = "UPDATE FP.Promotor SET tipo=@tipo WHERE cc=@cc";
                cmd.Parameters.AddWithValue("@tipo", promoter_type.Text);
                cmd.Parameters.AddWithValue("@cc", this.festival.promoter.cc);
                try
                {
                    cmd.ExecuteNonQuery();
                    CN.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Failed to update festival in database. \n ERROR MESSAGE: \n" + ex.Message);
                }

                if (!verifySGBDConnection())
                    return;
                cmd = new SqlCommand();
                cmd.Connection = CN;
                cmd.Parameters.Clear();
                cmd.CommandText = "UPDATE FP.Manager SET tipo=@tipo WHERE cc=@cc;";
                cmd.Parameters.AddWithValue("@tipo", manager_type.Text);
                cmd.Parameters.AddWithValue("@cc", this.festival.manager.cc);
                try
                {
                    cmd.ExecuteNonQuery();
                    CN.Close();
                    updateFestivalView();
                    btn_editfestival.Text = "Edit";
                    textBox_festivalname.Enabled = false;
                    datepicker_festivalbegin.Enabled = false;
                    datepicker_festivalend.Enabled = false;
                    datepicker_festivalend.Enabled = false;
                    datepicker_proposal.Enabled = false;
                    numericUpDown_ticketssold.Enabled = false;
                    textBox_promoter_cc.Enabled = false;
                    textBox_manager_cc.Enabled = false;
                    manager_type.Enabled = false;
                    promoter_type.Enabled = false;
                }
                catch (Exception ex)
                {
                    throw new Exception("Failed to update festival in database. \n ERROR MESSAGE: \n" + ex.Message);
                }
            }
        }

        private void btn_deletefestival_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete " + this.festival.name + " event ?", "Connection Test", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (!verifySGBDConnection())
                    return;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = CN;
                cmd.CommandText = "EXEC delete_evento_byId @festivalID;";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@festivalID", this.festival.id);
                try
                {
                    Console.WriteLine(cmd.ExecuteNonQuery());
                    CN.Close();
                    loadFestivals();
                    openPanel(panel_openinglist);
                }
                catch (Exception ex)
                {
                    throw new Exception("Failed to delete festival in database. \n ERROR MESSAGE: \n" + ex.Message);
                }
            }
        }

        private void btn_changefestival_Click(object sender, EventArgs e)
        {
            loadFestivals();
            openPanel(panel_openinglist);
        }
        // Festival details

        // Concert details

        private void loadConcerts()
        {
            if (!verifySGBDConnection())
                return;

            SqlCommand cmd = new SqlCommand("SELECT * FROM FP.V_CONCERTO WHERE event_id=@festivalID", CN);
            cmd.Parameters.AddWithValue("@festivalID", this.festival.id);
            dataGridView_concerts.Rows.Clear();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string[] row =
                {
                    reader["id"].ToString(),
                    reader["stage_id"].ToString(),
                    reader["band_id"].ToString(),
                    reader["dataInicio"].ToString(),
                    reader["concertoDuracao"].ToString(),
                    reader["soundckDuracao"].ToString(),
                    reader["endereco"].ToString(),
                    reader["lotacao"].ToString(),
                    reader["nome"].ToString(),
                    reader["sound_id"].ToString()
                };
                dataGridView_concerts.Rows.Add(row);
            }
            CN.Close();
        }

        private void loadStagelist()
        {
            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("SELECT * FROM FP.Palco WHERE FP.Palco.id_evento=@festival;", CN);
            cmd.Parameters.AddWithValue("@festival", this.festival.id);
            SqlDataReader reader = cmd.ExecuteReader();
            comboBox_stages.Items.Clear();
            while (reader.Read())
            {
                Stage C = new Stage();
                C.id= reader["id"].ToString();
                C.local = reader["endereco"].ToString();
                C.lot = Int32.Parse(reader["lotacao"].ToString());
                comboBox_stages.Items.Add(C);
                    
            }
            CN.Close();
        }

        private void loadBandlist()
        {
            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("SELECT * FROM FP.Banda", CN);
            SqlDataReader reader = cmd.ExecuteReader();
            comboBox_bandslist.Items.Clear();
            while (reader.Read())
            {
                Band C = new Band();
                C.id = reader["id"].ToString();
                C.name = reader["nome"].ToString();
                C.telephone = reader["telefone"].ToString();
                C.email = reader["email"].ToString();
                C.nElem = Int32.Parse(reader["nElementos"].ToString());
                comboBox_bandslist.Items.Add(C);                    
            }
            CN.Close();
        }

        private void loadEditors(object sender, EventArgs e) {

            string id = dataGridView_concerts.SelectedRows[0].Cells[0].Value.ToString();
            this.concert = new Concert(
                id: id,
                dur: dataGridView_concerts.SelectedRows[0].Cells[4].Value.ToString(),
                dateBegin: dataGridView_concerts.SelectedRows[0].Cells[3].Value.ToString()
                );
            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("SELECT * FROM FP.Banda WHERE FP.Banda.id=@id", CN);
            cmd.Parameters.AddWithValue("@id", dataGridView_concerts.SelectedRows[0].Cells[2].Value.ToString());
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            this.concert.band = new Band(
                    id = reader["id"].ToString(),
                    name: reader["nome"].ToString(),
                    telephone: reader["telefone"].ToString(),
                    email: reader["email"].ToString(),
                    nElem: Int32.Parse(reader["nElementos"].ToString())
                );
            CN.Close();
            loadBandlist();
            comboBox_bandslist.Text = this.concert.band.name;

            if (!verifySGBDConnection())
                return;
            cmd = new SqlCommand("SELECT * FROM FP.Palco WHERE FP.Palco.id=@id", CN);
            cmd.Parameters.AddWithValue("@id", dataGridView_concerts.SelectedRows[0].Cells[1].Value.ToString());
            reader = cmd.ExecuteReader();
            reader.Read();
            this.concert.stage = new Stage(
                    id = reader["id"].ToString(),
                    local: reader["endereco"].ToString(),
                    lot: Int32.Parse(reader["lotacao"].ToString())
                );
            CN.Close();
            loadStagelist();
            comboBox_stages.Text = this.concert.stage.local;

            if (!verifySGBDConnection())
                return;
            cmd = new SqlCommand("SELECT * FROM FP.SoundCheck WHERE FP.SoundCheck.id=@id", CN);
            cmd.Parameters.AddWithValue("@id", dataGridView_concerts.SelectedRows[0].Cells[9].Value.ToString());
            reader = cmd.ExecuteReader();
            reader.Read();
            this.concert.soundcheck = new SoundCheck(
                    id = reader["id"].ToString(),
                    dateBegin: reader["dataInicio"].ToString(),
                    dur: Int32.Parse(reader["duracao"].ToString())
                );
            CN.Close();
            dateTimePicker_soundcheck.Value = DateTime.Parse(this.concert.soundcheck.dateBegin);
            textBox_soundckduration.Text = this.concert.soundcheck.dur.ToString();

            btn_saveeditconcert.Enabled = true;
            textBox_concertduration.Text = this.concert.dur;
            dateTimePicker_concert.Value = DateTime.Parse(this.concert.dateBegin);
        }

        private void btn_saveeditconcert_Click(object sender, EventArgs e)
        {
            this.concert.dur = textBox_concertduration.Text;
            this.concert.dateBegin = dateTimePicker_concert.Value.ToString();
            this.concert.band = (Band)comboBox_bandslist.SelectedItem;
            this.concert.stage = (Stage)comboBox_stages.SelectedItem;
            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("UPDATE FP.Concerto SET id_palco=@id_palco, id_banda=@id_banda, duracao=@duracao, dataInicio=@dataInicio WHERE id=@id;", CN);
            cmd.Parameters.AddWithValue("@id", this.concert.id);
            cmd.Parameters.AddWithValue("@id_palco", this.concert.stage.id);
            cmd.Parameters.AddWithValue("@id_banda", this.concert.band.id);
            cmd.Parameters.AddWithValue("@duracao", this.concert.dur);
            cmd.Parameters.AddWithValue("@dataInicio", this.concert.dateBegin);
            try
            {
                cmd.ExecuteNonQuery();
                CN.Close();
                loadConcerts();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update festival in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
        }

        private void btn_addconcert_Click(object sender, EventArgs e)
        {
            if(btn_addconcert.Text == "Add Concert")
            {
                dateTimePicker_concert.ResetText();
                comboBox_stages.SelectedIndex = -1;
                comboBox_bandslist.SelectedIndex = -1;
                textBox_concertduration.ResetText();
                dateTimePicker_soundcheck.ResetText();
                textBox_soundckduration.ResetText();
                btn_addconcert.Text = "Save";
                loadStagelist();
                loadBandlist();
            }
            else
            {
                this.concert.dur = textBox_concertduration.Text;
                this.concert.dateBegin = dateTimePicker_concert.Value.ToString();
                this.concert.band = (Band)comboBox_bandslist.SelectedItem;
                this.concert.stage = (Stage)comboBox_stages.SelectedItem;
                this.concert.soundcheck = new SoundCheck(
                        id: DateTime.Now.Millisecond.ToString(),
                        dateBegin: dateTimePicker_soundcheck.Value.ToString(),
                        dur: Int32.Parse(textBox_soundckduration.Text)
                    );
                if (!verifySGBDConnection())
                    return;
                SqlCommand cmd = new SqlCommand("EXEC create_concerto @id, @id_evento, @id_palco, @id_banda, @duracao, @datatimeini, @id_soundcheck, @duracao_soundcheck, @data_soundcheck;", CN);
                cmd.Parameters.AddWithValue("@id", DateTime.Now.Millisecond);
                cmd.Parameters.AddWithValue("@id_evento", this.festival.id);
                cmd.Parameters.AddWithValue("@id_palco", this.concert.stage.id);
                cmd.Parameters.AddWithValue("@id_banda", this.concert.band.id);
                cmd.Parameters.AddWithValue("@duracao", Int32.Parse(this.concert.dur));
                cmd.Parameters.AddWithValue("@datatimeini", dateTimePicker_concert.Value);
                cmd.Parameters.AddWithValue("@id_soundcheck", this.concert.soundcheck.id);
                cmd.Parameters.AddWithValue("@duracao_soundcheck", this.concert.soundcheck.dur);
                cmd.Parameters.AddWithValue("@data_soundcheck", dateTimePicker_soundcheck.Value);
                try
                {
                    cmd.ExecuteNonQuery();
                    CN.Close();
                    loadConcerts();
                }
                catch (Exception ex)
                {
                    throw new Exception("Failed to update festival in database. \n ERROR MESSAGE: \n" + ex.Message);
                }
                btn_addconcert.Text = "Add Concert";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!verifySGBDConnection())
                return;
            SqlCommand cmd = new SqlCommand("EXEC  delete_concerto_byId @id", CN);
            cmd.Parameters.AddWithValue("@id", this.concert.id);
            try
            {
                cmd.ExecuteNonQuery();
                CN.Close();
                this.concert = new Concert();
                loadConcerts();
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to update festival in database. \n ERROR MESSAGE: \n" + ex.Message);
            }
        }
        // End Concert details

        // Navigation Buttons 
        private void btn_festivals_Click(object sender, EventArgs e)
        {
            openPanel(panel_festival);
        }
        private void btn_concerts_Click(object sender, EventArgs e)
        {
            loadConcerts();
            openPanel(panel_concerts);
        }

        private void btn_stages_Click(object sender, EventArgs e)
        {

        }

        private void btn_bands_Click(object sender, EventArgs e)
        {

        }

        private void btn_meals_Click(object sender, EventArgs e)
        {

        }

        private void btn_staff_Click(object sender, EventArgs e)
        {

        }

        private void panel_concerts_Paint(object sender, PaintEventArgs e)
        {

        }

        
        // End Navigation Buttons
    }
}
