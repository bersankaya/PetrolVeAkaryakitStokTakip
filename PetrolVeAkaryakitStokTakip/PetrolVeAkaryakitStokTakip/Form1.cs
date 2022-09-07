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
namespace PetrolVeAkaryakitStokTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-AGQ4V6UP;Initial Catalog=PetrolVeAkaryakitTakip;Integrated Security=True");
       void listele()
        {
            //kurşunsuz 95
            conn.Open();
            SqlCommand komut = new SqlCommand("select * from TBLBENZIN where PetrolTUR='Kurşunsuz95' ", conn);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblKursunsuz95.Text = dr[3].ToString();
                try
                {
                    progressBar1.Value = int.Parse(dr[4].ToString());
                    LblKursunsuz95Litre.Text = dr[4].ToString();
                }
                catch (Exception)
                {

                    MessageBox.Show("Depo Boşaldı Lütfen Doldurunuz");
                }
                
            }
            conn.Close();
            //kurşunsuz 97  
            conn.Open();
            SqlCommand komut1 = new SqlCommand("select * from TBLBENZIN where PetrolTUR='Kurşunsuz97'", conn);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblKursunsuz97.Text = dr1[3].ToString();
                progressBar2.Value = int.Parse(dr1[4].ToString());
                LblKursunsuz97Litre.Text = dr1[4].ToString();


            }
            conn.Close();
            //Diesel
            conn.Open();
            SqlCommand komut2 = new SqlCommand("select * from TBLBENZIN where PetrolTUR='Diesel'", conn);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblDiesel.Text = dr2[3].ToString();
                progressBar3.Value = int.Parse(dr2[4].ToString());
                LblDieselLitre.Text = dr2[4].ToString();


            }
            conn.Close();
            //ProDiesel
            conn.Open();
            SqlCommand komut3 = new SqlCommand("select * from TBLBENZIN where PetrolTUR='proDiesel'", conn);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                LblProDiesel.Text = dr3[3].ToString();
                progressBar4.Value = int.Parse(dr3[4].ToString());
                LblProDieselLitre.Text = dr3[4].ToString();


            }
            conn.Close();
            //Otogaz
            conn.Open();
            SqlCommand komut4 = new SqlCommand("select * from TBLBENZIN where PetrolTUR='Otogaz'", conn);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                LblOtogaz.Text = dr4[3].ToString();
                progressBar5.Value = int.Parse(dr4[4].ToString());
                LblOtogazLitre.Text = dr4[4].ToString();


            }
            conn.Close();
            //kasa
            conn.Open();
            SqlCommand komut5 = new SqlCommand("select * from TBLKASA", conn);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                LblKasa.Text = dr5[0].ToString();
            }
            conn.Close();
        }
        void listele2()
        {
            //kurşunsuz 95
            conn.Open();
            SqlCommand komut = new SqlCommand("select * from TBLBENZIN where PetrolTUR='Kurşunsuz95' ", conn);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblKursunsuz95Alis.Text = dr[2].ToString();
                try
                {
                    progressBar1.Value = int.Parse(dr[4].ToString());
                    LblKursunsuz95Litre.Text = dr[4].ToString();
                }
                catch (Exception)
                {

                    MessageBox.Show("Depo Doldu Lütfen Durunuz");
                }
               
            }
            conn.Close();
            //kurşunsuz 97  
            conn.Open();
            SqlCommand komut1 = new SqlCommand("select * from TBLBENZIN where PetrolTUR='Kurşunsuz97'", conn);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblKursunsuz97Alis.Text = dr1[2].ToString();
                progressBar2.Value = int.Parse(dr1[4].ToString());
                LblKursunsuz97Litre.Text = dr1[4].ToString();


            }
            conn.Close();
            //Diesel
            conn.Open();
            SqlCommand komut2 = new SqlCommand("select * from TBLBENZIN where PetrolTUR='Diesel'", conn);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblDieselAlis.Text = dr2[2].ToString();
                progressBar3.Value = int.Parse(dr2[4].ToString());
                LblDieselLitre.Text = dr2[4].ToString();


            }
            conn.Close();
            //ProDiesel
            conn.Open();
            SqlCommand komut3 = new SqlCommand("select * from TBLBENZIN where PetrolTUR='proDiesel'", conn);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                LblProDieselAlis.Text = dr3[2].ToString();
                progressBar4.Value = int.Parse(dr3[4].ToString());
                LblProDieselLitre.Text = dr3[4].ToString();


            }
            conn.Close();
            //Otogaz
            conn.Open();
            SqlCommand komut4 = new SqlCommand("select * from TBLBENZIN where PetrolTUR='Otogaz'", conn);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                LblOtogazAlis.Text = dr4[2].ToString();
                progressBar5.Value = int.Parse(dr4[4].ToString());
                LblOtogazLitre.Text = dr4[4].ToString();


            }
            conn.Close();
            //kasa
            conn.Open();
            SqlCommand komut5 = new SqlCommand("select * from TBLKASA", conn);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                LblKasa.Text = dr5[0].ToString();
            }
            conn.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
            listele2();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz95, litre, tutar;
            kursunsuz95 = Convert.ToDouble(LblKursunsuz95.Text);
            litre = Convert.ToDouble(numericUpDown1.Value);
            tutar = kursunsuz95 * litre;
            TxtKursunsuz95Tutar.Text = tutar.ToString();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz97, litre, tutar;
            kursunsuz97 = Convert.ToDouble(LblKursunsuz97.Text);
            litre = Convert.ToDouble(numericUpDown2.Value);
            tutar = kursunsuz97 * litre;
            TxtKursunsuz97Tutar.Text = tutar.ToString();    
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

            double diesel, litre, tutar;
            diesel = Convert.ToDouble(LblDiesel.Text);
            litre = Convert.ToDouble(numericUpDown3.Value);
            tutar = diesel * litre;
            TxtDieselTutar.Text = tutar.ToString();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            double prodiesel, litre, tutar;
            prodiesel = Convert.ToDouble(LblProDiesel.Text);
            litre = Convert.ToDouble(numericUpDown4.Value);
            tutar = prodiesel * litre;
            TxtProDieselTutar.Text = tutar.ToString();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            double Otogaz, litre, tutar;
            Otogaz = Convert.ToDouble(LblOtogaz.Text);
            litre = Convert.ToDouble(numericUpDown5.Value);
            tutar = Otogaz * litre;
            TxtOtogazTutar.Text = tutar.ToString();
        }

        private void BtnDepoDoldur_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value !=0)
            {
                conn.Open();
                SqlCommand komut1 = new SqlCommand("insert into TBLHAREKET (PLAKA,BENZINTURU,LITRE,FIYAT) values (@p1,@p2,@p3,@p4)", conn);
                komut1.Parameters.AddWithValue("@p1", TxtPlaka.Text);
                komut1.Parameters.AddWithValue("@p2", "Kurşunsuz95");
                komut1.Parameters.AddWithValue("@p3", numericUpDown1.Value);
                komut1.Parameters.AddWithValue("@p4", decimal.Parse(TxtKursunsuz95Tutar.Text));
                komut1.ExecuteNonQuery();
                conn.Close();


                conn.Open();
                SqlCommand komut2 = new SqlCommand("Update TBLKASA set MIKTAR=MIKTAR+@k1", conn);
                komut2.Parameters.AddWithValue("@k1",decimal.Parse( TxtKursunsuz95Tutar.Text));
                komut2.ExecuteNonQuery();
                conn.Close();



                conn.Open();
                SqlCommand komut3 = new SqlCommand("update TBLBENZIN set STOK=STOK-@t1 where PETROLTUR='Kurşunsuz95'", conn);
                komut3.Parameters.AddWithValue("@t1", numericUpDown1.Value);
                komut3.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Satış Gerçekleşti");
                listele();
            }
           else if (numericUpDown2.Value != 0)
            {
                conn.Open();
                SqlCommand komut4 = new SqlCommand("insert into TBLHAREKET (PLAKA,BENZINTURU,LITRE,FIYAT) values (@p1,@p2,@p3,@p4)", conn);
                komut4.Parameters.AddWithValue("@p1", TxtPlaka.Text);
                komut4.Parameters.AddWithValue("@p2", "Kurşunsuz97");
                komut4.Parameters.AddWithValue("@p3", numericUpDown2.Value);
                komut4.Parameters.AddWithValue("@p4", decimal.Parse(TxtKursunsuz97Tutar.Text));
                komut4.ExecuteNonQuery();
                conn.Close();


                conn.Open();
                SqlCommand komut5 = new SqlCommand("Update TBLKASA set MIKTAR=MIKTAR+@k1", conn);
                komut5.Parameters.AddWithValue("@k1", decimal.Parse(TxtKursunsuz97Tutar.Text));
                komut5.ExecuteNonQuery();
                conn.Close();



                conn.Open();
                SqlCommand komut6 = new SqlCommand("update TBLBENZIN set STOK=STOK-@t1 where PETROLTUR='Kurşunsuz97'", conn);
                komut6.Parameters.AddWithValue("@t1", numericUpDown2.Value);
                komut6.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Satış Gerçekleşti");
                listele();
            }
            else if (numericUpDown3.Value != 0)
            {
                conn.Open();
                SqlCommand komut7 = new SqlCommand("insert into TBLHAREKET (PLAKA,BENZINTURU,LITRE,FIYAT) values (@p1,@p2,@p3,@p4)", conn);
                komut7.Parameters.AddWithValue("@p1", TxtPlaka.Text);
                komut7.Parameters.AddWithValue("@p2", "Diesel");
                komut7.Parameters.AddWithValue("@p3", numericUpDown3.Value);
                komut7.Parameters.AddWithValue("@p4", decimal.Parse(TxtDieselTutar.Text));
                komut7.ExecuteNonQuery();
                conn.Close();


                conn.Open();
                SqlCommand komut8 = new SqlCommand("Update TBLKASA set MIKTAR=MIKTAR+@k1", conn);
                komut8.Parameters.AddWithValue("@k1", decimal.Parse(TxtDieselTutar.Text));
                komut8.ExecuteNonQuery();
                conn.Close();



                conn.Open();
                SqlCommand komut9 = new SqlCommand("update TBLBENZIN set STOK=STOK-@t1 where PETROLTUR='Diesel'", conn);
                komut9.Parameters.AddWithValue("@t1", numericUpDown3.Value);
                komut9.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Satış Gerçekleşti");
                listele();
            }
            else if (numericUpDown4.Value != 0)
            {
                conn.Open();
                SqlCommand komut10 = new SqlCommand("insert into TBLHAREKET (PLAKA,BENZINTURU,LITRE,FIYAT) values (@p1,@p2,@p3,@p4)", conn);
                komut10.Parameters.AddWithValue("@p1", TxtPlaka.Text);
                komut10.Parameters.AddWithValue("@p2", "proDiesel");
                komut10.Parameters.AddWithValue("@p3", numericUpDown4.Value);
                komut10.Parameters.AddWithValue("@p4", decimal.Parse(TxtProDieselTutar.Text));
                komut10.ExecuteNonQuery();
                conn.Close();


                conn.Open();
                SqlCommand komut11 = new SqlCommand("Update TBLKASA set MIKTAR=MIKTAR+@k1", conn);
                komut11.Parameters.AddWithValue("@k1", decimal.Parse(TxtProDieselTutar.Text));
                komut11.ExecuteNonQuery();
                conn.Close();



                conn.Open();
                SqlCommand komut12 = new SqlCommand("update TBLBENZIN set STOK=STOK-@t1 where PETROLTUR='proDiesel'", conn);
                komut12.Parameters.AddWithValue("@t1", numericUpDown4.Value);
                komut12.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Satış Gerçekleşti");
                listele();
            }
            else if (numericUpDown5.Value != 0)
            {
                conn.Open();
                SqlCommand komut13 = new SqlCommand("insert into TBLHAREKET (PLAKA,BENZINTURU,LITRE,FIYAT) values (@p1,@p2,@p3,@p4)", conn);
                komut13.Parameters.AddWithValue("@p1", TxtPlaka.Text);
                komut13.Parameters.AddWithValue("@p2", "Otogaz");
                komut13.Parameters.AddWithValue("@p3", numericUpDown5.Value);
                komut13.Parameters.AddWithValue("@p4", decimal.Parse(TxtOtogazTutar.Text));
                komut13.ExecuteNonQuery();
                conn.Close();


                conn.Open();
                SqlCommand komut14 = new SqlCommand("Update TBLKASA set MIKTAR=MIKTAR+@k1", conn);
                komut14.Parameters.AddWithValue("@k1", decimal.Parse(TxtOtogazTutar.Text));
                komut14.ExecuteNonQuery();
                conn.Close();



                conn.Open();
                SqlCommand komut15 = new SqlCommand("update TBLBENZIN set STOK=STOK-@t1 where PETROLTUR='Otogaz'", conn);
                komut15.Parameters.AddWithValue("@t1", numericUpDown5.Value);
                komut15.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Satış Gerçekleşti");
                listele();
            }

        }
        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz95, litre, tutar;
            kursunsuz95 = Convert.ToDouble(LblKursunsuz95Alis.Text);
            litre = Convert.ToDouble(numericUpDown7.Value);
            tutar = kursunsuz95 * litre;
            txtkursunsuz95alis.Text = tutar.ToString();
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz97, litre, tutar;
            kursunsuz97 = Convert.ToDouble(LblKursunsuz97Alis.Text);
            litre = Convert.ToDouble(numericUpDown6.Value);
            tutar = kursunsuz97 * litre;
            txtkursunsuz97alis.Text = tutar.ToString();
        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {

            double diesel, litre, tutar;
            diesel = Convert.ToDouble(LblDieselAlis.Text);
            litre = Convert.ToDouble(numericUpDown9.Value);
            tutar = diesel * litre;
            TxtDieselAlis.Text = tutar.ToString();
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            double prodiesel, litre, tutar;
            prodiesel = Convert.ToDouble(LblProDieselAlis.Text);
            litre = Convert.ToDouble(numericUpDown8.Value);
            tutar = prodiesel * litre;
            TxtProDieselAlis.Text = tutar.ToString();
        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {
            double Otogaz, litre, tutar;
            Otogaz = Convert.ToDouble(LblOtogazAlis.Text);
            litre = Convert.ToDouble(numericUpDown10.Value);
            tutar = Otogaz * litre;
            TxtOtogazAlis.Text = tutar.ToString();
        }

        private void BtnPetrolAlimi_Click(object sender, EventArgs e)
        {
            
                if (numericUpDown7.Value != 0)
                {
                    conn.Open();
                    SqlCommand komut2 = new SqlCommand("Update TBLKASA set MIKTAR=MIKTAR-@k1", conn);
                    komut2.Parameters.AddWithValue("@k1", decimal.Parse(txtkursunsuz95alis.Text));
                    komut2.ExecuteNonQuery();
                    conn.Close();



                    conn.Open();
                    SqlCommand komut3 = new SqlCommand("update TBLBENZIN set STOK=STOK+@t1 where PETROLTUR='Kurşunsuz95'", conn);
                    komut3.Parameters.AddWithValue("@t1", numericUpDown7.Value);
                    komut3.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Alış Gerçekleşti");
                    listele();
                }
            
            if (numericUpDown6.Value != 0)
                {
                    conn.Open();
                    SqlCommand komut4 = new SqlCommand("Update TBLKASA set MIKTAR=MIKTAR-@k1", conn);
                    komut4.Parameters.AddWithValue("@k1", decimal.Parse(txtkursunsuz97alis.Text));
                    komut4.ExecuteNonQuery();
                    conn.Close();



                    conn.Open();
                    SqlCommand komut5 = new SqlCommand("update TBLBENZIN set STOK=STOK+@t1 where PETROLTUR='Kurşunsuz97'", conn);
                    komut5.Parameters.AddWithValue("@t1", numericUpDown6.Value);
                    komut5.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Alış Gerçekleşti");
                    listele();
                }
                if (numericUpDown9.Value != 0)
                {
                    conn.Open();
                    SqlCommand komut6 = new SqlCommand("Update TBLKASA set MIKTAR=MIKTAR-@k1", conn);
                    komut6.Parameters.AddWithValue("@k1", decimal.Parse(TxtDieselAlis.Text));
                    komut6.ExecuteNonQuery();
                    conn.Close();



                    conn.Open();
                    SqlCommand komut7 = new SqlCommand("update TBLBENZIN set STOK=STOK+@t1 where PETROLTUR='Diesel'", conn);
                    komut7.Parameters.AddWithValue("@t1", numericUpDown9.Value);
                    komut7.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Alış Gerçekleşti");
                    listele();
                }
                if (numericUpDown8.Value != 0)
                {
                    conn.Open();
                    SqlCommand komut8 = new SqlCommand("Update TBLKASA set MIKTAR=MIKTAR-@k1", conn);
                    komut8.Parameters.AddWithValue("@k1", decimal.Parse(TxtProDieselAlis.Text));
                    komut8.ExecuteNonQuery();
                    conn.Close();



                    conn.Open();
                    SqlCommand komut9 = new SqlCommand("update TBLBENZIN set STOK=STOK+@t1 where PETROLTUR='proDiesel'", conn);
                    komut9.Parameters.AddWithValue("@t1", numericUpDown8.Value);
                    komut9.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Alış Gerçekleşti");
                    listele();
                }
                if (numericUpDown10.Value != 0)
                {
                    conn.Open();
                    SqlCommand komut10 = new SqlCommand("Update TBLKASA set MIKTAR=MIKTAR-@k1", conn);
                    komut10.Parameters.AddWithValue("@k1", decimal.Parse(TxtOtogazAlis.Text));
                    komut10.ExecuteNonQuery();
                    conn.Close();



                    conn.Open();
                    SqlCommand komut11 = new SqlCommand("update TBLBENZIN set STOK=STOK+@t1 where PETROLTUR='Otogaz'", conn);
                    komut11.Parameters.AddWithValue("@t1", numericUpDown10.Value);
                    komut11.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Alış Gerçekleşti");
                    listele();
                }
           
        }
    }
}
