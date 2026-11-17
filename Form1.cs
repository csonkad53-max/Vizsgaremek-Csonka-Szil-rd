
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace orszag
{
    public partial class Form1 : Form
    {
        List<Orszag> orszagok = new List<Orszag>();

        string fajl = Path.Combine(
            Application.StartupPath,
            "orszagok.txt"
        );

        public Form1()
        {
            InitializeComponent();

            
            btnHozzaadas.Click += btnHozzaadas_Click;
            btnKereses.Click += btnKereses_Click;

           
            this.Text = "Országok nyilvántartása";
            this.Size = new Size(900, 600);
            this.BackColor = Color.LightSkyBlue;
            this.Font = new Font("Segoe UI", 10);
            this.StartPosition = FormStartPosition.CenterScreen;

            
            dgvOrszagok.AutoGenerateColumns = true;
            dgvOrszagok.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrszagok.ReadOnly = true;
            dgvOrszagok.AllowUserToAddRows = false;

            
            if (!File.Exists(fajl))
            {
                string[] alapAdatok =
                {
                    "Magyarország;Budapest;9500000",
                    "Ausztria;Bécs;9200000",
                    "Németország;Berlin;84000000",
                    "Franciaország;Párizs;68000000",
                    "Olaszország;Róma;58900000",
                    "Spanyolország;Madrid;48000000",
                    "Lengyelország;Varsó;37500000",
                    "Szlovákia;Pozsony;5400000"
                };

                File.WriteAllLines(fajl, alapAdatok, Encoding.UTF8);
            }

            
            AdatokBetoltese();
        }

        
        private void AdatokBetoltese()
        {
            try
            {
                orszagok.Clear();

                string[] sorok = File.ReadAllLines(
                    fajl,
                    Encoding.UTF8
                );

                foreach (string sor in sorok)
                {
                    if (string.IsNullOrWhiteSpace(sor))
                        continue;

                    string[] adatok = sor.Split(';');

                    int lakossag;

                    if (adatok.Length != 3 ||
                        string.IsNullOrWhiteSpace(adatok[0]) ||
                        string.IsNullOrWhiteSpace(adatok[1]) ||
                        !int.TryParse(adatok[2].Trim(), out lakossag) ||
                        lakossag <= 0)
                    {
                        MessageBox.Show(
                            "Hibás formátumú sor: " + sor
                        );
                        continue;
                    }

                    Orszag uj = new Orszag(
                        adatok[0].Trim(),
                        adatok[1].Trim(),
                        lakossag
                    );

                    orszagok.Add(uj);
                }

                TablazatFrissites(orszagok);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Hiba a fájl beolvasásakor: " + ex.Message
                );
            }
        }

        
        private void btnBeolvasas_Click(object sender, EventArgs e)
        {
            AdatokBetoltese();

            MessageBox.Show("Az adatok beolvasása sikeres!");
        }

        
        private void btnHozzaadas_Click(object sender, EventArgs e)
        {
            string nev = txtOrszag.Text.Trim();
            string fovaros = txtFovaros.Text.Trim();
            int lakossag;

            if (nev == "")
            {
                MessageBox.Show("Add meg az ország nevét!");
                return;
            }

            if (fovaros == "")
            {
                MessageBox.Show("Add meg a főváros nevét!");
                return;
            }

            if (!int.TryParse(txtLakossag.Text.Trim(), out lakossag))
            {
                MessageBox.Show("A lakosság csak egész szám lehet!");
                return;
            }

            if (lakossag <= 0)
            {
                MessageBox.Show("A lakosságnak pozitív számnak kell lennie!");
                return;
            }

            Orszag uj = new Orszag(
                nev,
                fovaros,
                lakossag
            );

            orszagok.Add(uj);

            try
            {
                File.AppendAllText(
                    fajl,
                    nev + ";" + fovaros + ";" + lakossag +
                    Environment.NewLine,
                    Encoding.UTF8
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Az ország hozzáadva, de a mentés nem sikerült: "
                    + ex.Message
                );
            }

            TablazatFrissites(orszagok);

            txtOrszag.Clear();
            txtFovaros.Clear();
            txtLakossag.Clear();

            MessageBox.Show("Az ország sikeresen hozzáadva!");
        }

        
        private void btnKereses_Click(object sender, EventArgs e)
        {
            string keres = txtKereses.Text.Trim();

            if (keres == "")
            {
                MessageBox.Show("Írj be egy keresendő szót!");
                return;
            }

            List<Orszag> talalatok = orszagok.Where(o =>
                o.Nev.IndexOf(
                    keres,
                    StringComparison.OrdinalIgnoreCase
                ) >= 0
                ||
                o.Fovaros.IndexOf(
                    keres,
                    StringComparison.OrdinalIgnoreCase
                ) >= 0
            ).ToList();

            if (talalatok.Count == 0)
            {
                MessageBox.Show("Nincs találat!");
                return;
            }

            TablazatFrissites(talalatok);
        }

        
        private void btnRendezes_Click(object sender, EventArgs e)
        {
            if (orszagok.Count == 0)
            {
                MessageBox.Show("Nincs adat a rendezéshez!");
                return;
            }

            orszagok = orszagok
                .OrderByDescending(o => o.Lakossag)
                .ToList();

            TablazatFrissites(orszagok);

            MessageBox.Show(
                "Az országok lakosság szerint rendezve!\n" +
                "Legnépesebb ország: " +
                orszagok[0].Nev + " - " +
                orszagok[0].Lakossag + " fő"
            );
        }

        
        private void btnRendezes_Click_1(object sender, EventArgs e)
        {
            btnRendezes_Click(sender, e);
        }

        
        private void TablazatFrissites(List<Orszag> lista)
        {
            dgvOrszagok.DataSource = null;
            dgvOrszagok.DataSource = lista.ToList();

            if (dgvOrszagok.Columns.Count > 0)
            {
                dgvOrszagok.Columns["Nev"].HeaderText = "Ország";
                dgvOrszagok.Columns["Fovaros"].HeaderText = "Főváros";
                dgvOrszagok.Columns["Lakossag"].HeaderText =
                    "Lakosság (fő)";
            }
        }

        
        private void txtOrszag_TextChanged(object sender, EventArgs e)
        {
        }

        private void dgvOrszagok_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_2(object sender, EventArgs e)
        {

        }

        private void label5_Click_3(object sender, EventArgs e)
        {

        }
    }


    public class Orszag
    {
        public string Nev { get; set; }
        public string Fovaros { get; set; }
        public int Lakossag { get; set; }

        public Orszag(string nev, string fovaros, int lakossag)
        {
            Nev = nev;
            Fovaros = fovaros;
            Lakossag = lakossag;
        }
    }
}
