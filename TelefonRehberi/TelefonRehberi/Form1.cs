using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TelefonRehberi
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;//tablo içerisinden belli bi kısmını yada tamamını getirmek için kullanıyoruz.(Veri Taşıyıcısı)
        public Form1()
        {
            InitializeComponent();
        }
        #region DataGridViewde Veri Listeletmek için Goster Metodu
        void Goster()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-RVPCOQD\\SQLSERVER2017; Initial Catalog=Rehber; Integrated Security=true;");
            baglanti.Open();
            da = new SqlDataAdapter("Select * from Kisiler", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);//tablonun içini da ile doldur
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            Goster();
        }
        #region Ekleme
        private void ekle_Click(object sender, EventArgs e)
        {
                baglanti = new SqlConnection("Data Source=DESKTOP-RVPCOQD\\SQLSERVER2017; Initial Catalog=Rehber; Integrated Security=true;");
                baglanti.Open();
                int kisinu = Convert.ToInt32(kisino.Text);
                string adı = adi.Text;
                string soyadı = soyadi.Text;
                string telnu = telno.Text;
                if (telno.TextLength != 11)
                {
                    MessageBox.Show("Lütfen telefon numarasını 11 hane olacak şekilde giriniz.");
                return;
                }

            SqlCommand varmi = new SqlCommand("select count(*) from Kisiler where KisiNo = "+kisinu+" or Telefon="+telnu+"", baglanti);
                int sayı = Convert.ToInt32(varmi.ExecuteScalar());
            //eğer o kişinumarasına ait kişi yoksa kişi eklenicek varsa bu kişi zaten kayıtlı diyecek.
            if (sayı==0)
                {   komut = new SqlCommand("insert into Kisiler values('" + kisinu + "','" + adı + "','" + soyadı + "','" + telnu + "')", baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kişi Eklendi");
                    Goster();
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("Bu kişi zaten kayıtlı.");
                    Goster();
                    baglanti.Close();
                }
        }
        #endregion
        #region Silme
        private void sil_Click(object sender, EventArgs e)
        {
            int kisinumara = 0 ;
                    baglanti = new SqlConnection("Data Source=DESKTOP-RVPCOQD\\SQLSERVER2017; Initial Catalog=Rehber; Integrated Security=true;");
                    baglanti.Open();
                    kisinumara = Convert.ToInt32(kisino.Text);
            SqlCommand varmi = new SqlCommand("select count(KisiNo) from Kisiler where KisiNo="+kisinumara+"", baglanti);
            int sayı = Convert.ToInt32(varmi.ExecuteScalar());
            //eğer o kişi numarasına ait kişi yoksa silme yapılamaz diyip, varsa da silicek.
            if (sayı == 0)
            {
                MessageBox.Show("Bu kişi numarasına ait kişi bulunamadığından silme işlemi gerçekleştirilemedi.");
                Goster();
                baglanti.Close();
            }
            else
            {
                komut = new SqlCommand("delete from Kisiler where KisiNo =" + kisinumara + "",baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kişi Silindi");
                Goster();
                baglanti.Close();
            }
        }
        #endregion
        #region Temizle
        private void temizle_Click(object sender, EventArgs e)
        {
            kisino.Text = "";
            adi.Text = "";
            soyadi.Text = "";
            telno.Text = "";
        }
        #endregion
        #region Güncelleme
        private void guncelle_Click(object sender, EventArgs e)
        {//kişinumarasına göre güncelleme yapılmaktadır.
            int kisinumara = 0;
            baglanti = new SqlConnection("Data Source=DESKTOP-RVPCOQD\\SQLSERVER2017; Initial Catalog=Rehber; Integrated Security=true;");
            baglanti.Open();
            kisinumara = Convert.ToInt32(kisino.Text);
            #region telnoveboşbırakmakontrolü
            if (telno.TextLength != 11)
                {
                    MessageBox.Show("Lütfen telefon numarasını 11 hane olacak şekilde giriniz.");
                    return;
                }
                if (kisino.Text == "" || adi.Text == "" || soyadi.Text == "" || telno.Text == "")
                {
                    MessageBox.Show("Lütfen doldurulması zorunlu alanları doldurunuz.");
                }
            #endregion
            SqlCommand varmi = new SqlCommand("select count(*) from Kisiler where KisiNo=" + kisinumara + "", baglanti);
            int sayı = Convert.ToInt32(varmi.ExecuteScalar());
            //eğer o kişi numarasına sahip kişi yoksa güncellemez diyecek ve varsa da güncelleyecek.
            if (sayı == 0)
            {
                MessageBox.Show("Bu kişi numarasına ait kişi bulunamadığından güncelleme işlemi gerçekleştirilemedi.");
                Goster();
                baglanti.Close();
            }
            else
            {
                komut = new SqlCommand("update Kisiler set Soyad = '" + soyadi.Text + "' ,Ad ='" + adi.Text + "',Telefon ='" + telno.Text + "' where KisiNo =" + kisinumara + "", baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Kişi Güncellendi");
                Goster();
                baglanti.Close();
            }
        }
        #endregion 
        #region Arama
        private void textBox1_TextChanged(object sender, EventArgs e)
        {//ada göre arama
            // textbox a girilen harf ile adı başlayan kisiler tablosunun adı sütununda aranır ve listelenir
                SqlDataAdapter da = new SqlDataAdapter("Select *from Kisiler where ad like '" + textBox1.Text + "%'", baglanti);
                DataSet ds = new DataSet();
                baglanti.Open();
                da.Fill(ds, "Kisiler");
                dataGridView1.DataSource = ds.Tables["Kisiler"];
                baglanti.Close();
            }
        #endregion
        #region sayı ve harf girilme kontrolleri
        private void kisino_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//sadece sayı(digit) girişi
        }

        private void telno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//sadece sayı girişi
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)//arama textboxına sadece harf(letter) girişi
                 && !char.IsSeparator(e.KeyChar);
        }
       
       
        private void soyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)//soyadı textboxına sadece harf(letter) girişi
              && !char.IsSeparator(e.KeyChar);
        }

        private void adi_KeyPress_1(object sender, KeyPressEventArgs e)
        {
             e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)//adı textboxına sadece harf(letter) girişi
              && !char.IsSeparator(e.KeyChar);
        }
        #endregion
    }
}

