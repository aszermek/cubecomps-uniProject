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
using Svg;

namespace projektfeladat_z7kfuz
{
    public partial class Form1 : Form
    {
        Database1Entities context = new Database1Entities();

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            populateListBox();
        }

        private void populateListBox()
        {
            var complist = from x in context.Competitions select x;
            listBoxCompetitions.DataSource = complist.ToList();
            listBoxCompetitions.DisplayMember = "CompetitionName";
        }

        private void filterCompetitions_TextChanged(object sender, EventArgs e)
        {
            compListing();
        }

        private void compListing()
        {


            if (comboBoxRegion.SelectedIndex == 0 || comboBoxRegion.SelectedIndex == -1)
            {
                var comp = from x in context.Competitions
                           where x.CompetitionName.Contains(filterCompetitions.Text)
                           select x;
                listBoxCompetitions.DataSource = comp.ToList();
                listBoxCompetitions.DisplayMember = "CompetitionName";
            }
            else
            {
                var comp = from x in context.Competitions
                           where x.CompetitionName.Contains(filterCompetitions.Text)
                           && x.Continent.Contains(comboBoxRegion.Text)
                           select x;
                listBoxCompetitions.DataSource = comp.ToList();
                listBoxCompetitions.DisplayMember = "CompetitionName";
            }

            
        }

        private void listBoxCompetitions_SelectedIndexChanged(object sender, EventArgs e)
        {
            competitorListing();
            populateTextBoxes();
        }

        private void populateTextBoxes()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Competition where Id='" + ((Competition)listBoxCompetitions.SelectedItem).Id + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBoxDate.Text = String.Format("{0:yyyy. MMMM d.}", dr["Date"]);
                textBoxCountry.Text = dr["Country"].ToString();
                textBoxCity.Text = dr["City"].ToString();
                textBoxVenue.Text = dr["Venue"].ToString();
            }
            con.Close();
        }

        private void competitorListing()
        {
            var competitors = from x in context.Competitors
                              where x.CompetitionId == ((Competition)listBoxCompetitions.SelectedItem).Id
                              select new
                              {
                                  x.Id,
                                  x.CompetitorName,
                                  x.WcaId,
                                  x.Country,
                                  x.BirthDate
                              };
            bindingSource1.DataSource = competitors.ToList();
        }

        private void comboBoxRegion_DropDown(object sender, EventArgs e)
        {
            string[] regionlist = new string[] { "(összes)", "Afrika", "Ázsia", "Dél-Amerika", "Észak-Amerika", "Európa" };
            comboBoxRegion.DataSource = regionlist;
        }

        private void comboBoxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            regionFilter();
        }

        private void regionFilter()
        {
            if (comboBoxRegion.SelectedIndex == 0)
            {
                populateListBox();
            }
            else
            {
                var region = from x in context.Competitions
                             where x.Continent.Contains(comboBoxRegion.SelectedItem.ToString())
                             select x;
                listBoxCompetitions.DataSource = region.ToList();
                listBoxCompetitions.DisplayMember = "CompetitionName";
            }
        }

        private void btnResetRegion_Click(object sender, EventArgs e)
        {
            resetCombobox();
        }

        private void resetCombobox()
        {
            comboBoxRegion.ResetText();
            comboBoxRegion.FormattingEnabled = true;
            populateListBox();
        }

        private void dgwCompetitors_SelectionChanged(object sender, EventArgs e)
        {
            populateEvents();
        }

        private void populateEvents()
        {
            clearEvents();
            if (dgwCompetitors.Rows.Count == 0)
            {
                clearEvents();
            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Event where Id='" + dgwCompetitors.CurrentRow.Cells[0].Value + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    if (Convert.ToBoolean(dr["222"]) == true) pic222.Image = Image.FromFile(@"img\222on.png");
                    if (Convert.ToBoolean(dr["333"]) == true) pic333.Image = Image.FromFile(@"img\333on.png");
                    if (Convert.ToBoolean(dr["444"]) == true) pic444.Image = Image.FromFile(@"img\444on.png");
                    if (Convert.ToBoolean(dr["555"]) == true) pic555.Image = Image.FromFile(@"img\555on.png");
                    if (Convert.ToBoolean(dr["666"]) == true) pic666.Image = Image.FromFile(@"img\666on.png");
                    if (Convert.ToBoolean(dr["777"]) == true) pic777.Image = Image.FromFile(@"img\777on.png");
                    if (Convert.ToBoolean(dr["333bld"]) == true) pic333bld.Image = Image.FromFile(@"img\333bldon.png");
                    if (Convert.ToBoolean(dr["333fmc"]) == true) pic333fmc.Image = Image.FromFile(@"img\333fmcon.png");
                    if (Convert.ToBoolean(dr["333oh"]) == true) pic333oh.Image = Image.FromFile(@"img\333ohon.png");
                    if (Convert.ToBoolean(dr["333feet"]) == true) pic333feet.Image = Image.FromFile(@"img\333feeton.png");
                    if (Convert.ToBoolean(dr["Clock"]) == true) picClock.Image = Image.FromFile(@"img\clockon.png");
                    if (Convert.ToBoolean(dr["Mega"]) == true) picMega.Image = Image.FromFile(@"img\megaon.png");
                    if (Convert.ToBoolean(dr["Pyra"]) == true) picPyra.Image = Image.FromFile(@"img\pyraon.png");
                    if (Convert.ToBoolean(dr["Skewb"]) == true) picSkewb.Image = Image.FromFile(@"img\skewbon.png");
                    if (Convert.ToBoolean(dr["Sq1"]) == true) picSq1.Image = Image.FromFile(@"img\sq1on.png");
                    if (Convert.ToBoolean(dr["444bld"]) == true) pic444bld.Image = Image.FromFile(@"img\444bldon.png");
                    if (Convert.ToBoolean(dr["555bld"]) == true) pic555bld.Image = Image.FromFile(@"img\555bldon.png");
                    if (Convert.ToBoolean(dr["Multibld"]) == true) picMultibld.Image = Image.FromFile(@"img\multibldon.png");
                }
                con.Close();
            }
            
        }

        private void clearEvents()
        {
            pic222.Image = Image.FromFile(@"img\222.png");
            pic333.Image = Image.FromFile(@"img\333.png");
            pic444.Image = Image.FromFile(@"img\444.png");
            pic555.Image = Image.FromFile(@"img\555.png");
            pic666.Image = Image.FromFile(@"img\666.png");
            pic777.Image = Image.FromFile(@"img\777.png");
            pic333bld.Image = Image.FromFile(@"img\333bld.png");
            pic333fmc.Image = Image.FromFile(@"img\333fmc.png");
            pic333oh.Image = Image.FromFile(@"img\333oh.png");
            pic333feet.Image = Image.FromFile(@"img\333feet.png");
            picClock.Image = Image.FromFile(@"img\clock.png");
            picMega.Image = Image.FromFile(@"img\mega.png");
            picPyra.Image = Image.FromFile(@"img\pyra.png");
            picSkewb.Image = Image.FromFile(@"img\skewb.png");
            picSq1.Image = Image.FromFile(@"img\sq1.png");
            pic444bld.Image = Image.FromFile(@"img\444bld.png");
            pic555bld.Image = Image.FromFile(@"img\555bld.png");
            picMultibld.Image = Image.FromFile(@"img\multibld.png");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            RegistrationForm rf = new RegistrationForm();

            if (rf.ShowDialog() == DialogResult.OK)
            {
                Competitor competitor = new Competitor();
                competitor.CompetitionId = listBoxCompetitions.SelectedIndex + 1;
                competitor.CompetitorName = rf.textBoxName.Text;
                competitor.WcaId = rf.textBoxWCAID.Text;
                competitor.Country = rf.comboBoxCountry.Text;
                competitor.BirthDate = DateTime.Parse(rf.dateTimePicker.Text);
                context.Competitors.Add(competitor);

                Event @event = new Event();
                if (rf.cb222.Checked == true) @event.C222 = true;
                if (rf.cb333.Checked == true) @event.C333 = true;
                if (rf.cb444.Checked == true) @event.C444 = true;
                if (rf.cb555.Checked == true) @event.C555 = true;
                if (rf.cb666.Checked == true) @event.C666 = true;
                if (rf.cb777.Checked == true) @event.C777 = true;
                if (rf.cb333bld.Checked == true) @event.C333bld = true;
                if (rf.cb333fmc.Checked == true) @event.C333fmc = true;
                if (rf.cb333oh.Checked == true) @event.C333oh = true;
                if (rf.cb333feet.Checked == true) @event.C333feet = true;
                if (rf.cbClock.Checked == true) @event.Clock = true;
                if (rf.cbMega.Checked == true) @event.Mega = true;
                if (rf.cbPyra.Checked == true) @event.Pyra = true;
                if (rf.cbSkewb.Checked == true) @event.Skewb = true;
                if (rf.cbSq1.Checked == true) @event.Sq1 = true;
                if (rf.cb444bld.Checked == true) @event.C444bld = true;
                if (rf.cb555bld.Checked == true) @event.C555bld = true;
                if (rf.cbMultibld.Checked == true) @event.Multibld = true;
                context.Events.Add(@event);

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            competitorListing();
            populateEvents();
            return;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztosan kilépsz?", "Kilépés", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
