using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Ay_pansiyon
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-G9IE592\\MSSQL;Initial Catalog=aypansiyon;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {

            try
            {
                baglanti.Open();
                string sql = "select * from AdminGiris where Kullanici=@KullaniciAdi AND Sifre=@Sifresi ";
                SqlParameter prm1 = new SqlParameter("KullaniciAdi", TxtKullaniciAdi.Text);
                SqlParameter prm2 = new SqlParameter("Sifresi", TxtSifre.Text);
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);

                da.Fill(dt);
                if(dt.Rows.Count>0)
                {
                    AnaForm fr = new AnaForm();
                    fr.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Giriş");
            }
        }
    }
}
