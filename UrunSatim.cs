﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace ProfeTasarimDeneme
{
    public partial class UrunSatim : Form
    {
        public UrunSatim()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection("Server=localhost; Database=otomasyonprojesi; User= root; Password=''; ");
        MySqlCommand cmd, cmd2, cmd3, cmd4, cmd5, cmd6, cmd7;



        private void btn_ekle1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO urunsatis (fatura_no, urun, musteri, miktar, fiyat, tarih) values (@fat_no,@urun,@musteri,@miktar,@fiyat,@tarih)";
            int a = Int32.Parse(fiyat1.Text);
            int b = Int32.Parse(n1.Value.ToString());

            int fiyat = a * b;
            MySqlCommand Lcmd = new MySqlCommand(sql, conn);
            Lcmd.Parameters.AddWithValue("@musteri", cmb_must.SelectedItem);
            Lcmd.Parameters.AddWithValue("@fat_no", fat_no.Text);
            Lcmd.Parameters.AddWithValue("@urun", cmb_kagit.SelectedItem);
            Lcmd.Parameters.AddWithValue("@miktar", n1.Value.ToString());
            Lcmd.Parameters.AddWithValue("@fiyat", fiyat);
            Lcmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Text);

            conn.Open();
            Lcmd.ExecuteNonQuery();
            string veri = "SELECT * FROM urunsatis ";
            MySqlDataAdapter da = new MySqlDataAdapter(veri, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_urun.DataSource = ds.Tables[0];

            conn.Close();
            fat_no.Clear();
            dateTimePicker1.ResetText();
            cmb_must.ResetText();
            cmb_kagit.ResetText();
            fiyat1.Clear();
            n1.ResetText();
            MessageBox.Show("Kayıt Eklendi");
        }

        private void btn_ekle2_Click(object sender, EventArgs e)
        {

            string sql = "INSERT INTO urunsatis (fatura_no, urun, musteri, miktar, fiyat, tarih) values (@fat_no,@urun,@musteri,@miktar,@fiyat,@tarih)";
            int a = Int32.Parse(fiyat2.Text);
            int b = Int32.Parse(n2.Value.ToString());

            int fiyat = a * b;
            MySqlCommand Lcmd = new MySqlCommand(sql, conn);
            Lcmd.Parameters.AddWithValue("@musteri", cmb_must.SelectedItem);
            Lcmd.Parameters.AddWithValue("@fat_no", fat_no.Text);
            Lcmd.Parameters.AddWithValue("@urun", cmb_demir.SelectedItem);          
            Lcmd.Parameters.AddWithValue("@miktar", n2.Value.ToString());
            Lcmd.Parameters.AddWithValue("@fiyat", fiyat);
            Lcmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Text);

            conn.Open();
            Lcmd.ExecuteNonQuery();
            string veri = "SELECT * FROM urunsatis ";
            MySqlDataAdapter da = new MySqlDataAdapter(veri, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_urun.DataSource = ds.Tables[0];

            conn.Close();
            fat_no.Clear();
            dateTimePicker1.ResetText();
            cmb_must.ResetText();
            cmb_demir.ResetText();
            fiyat2.Clear();
            n2.ResetText();
            MessageBox.Show("Kayıt Eklendi");
        }

        private void btn_ekle3_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO urunsatis (fatura_no, urun, musteri, miktar, fiyat, tarih) values (@fat_no, @urun,@musteri,@miktar,@fiyat,@tarih)";
            int a = Int32.Parse(fiyat3.Text);
            int b = Int32.Parse(n3.Value.ToString());

            int fiyat = a * b;
            MySqlCommand Lcmd = new MySqlCommand(sql, conn);
            Lcmd.Parameters.AddWithValue("@musteri", cmb_must.SelectedItem);
            Lcmd.Parameters.AddWithValue("@fat_no", fat_no.Text);
            Lcmd.Parameters.AddWithValue("@urun", cmb_palet.SelectedItem);
            Lcmd.Parameters.AddWithValue("@miktar", n3.Value.ToString());
            Lcmd.Parameters.AddWithValue("@fiyat", fiyat);
            Lcmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Text);

            conn.Open();
            Lcmd.ExecuteNonQuery();
            string veri = "SELECT * FROM urunsatis ";
            MySqlDataAdapter da = new MySqlDataAdapter(veri, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_urun.DataSource = ds.Tables[0];
            
            conn.Close();
            fat_no.Clear();
            dateTimePicker1.ResetText();
            cmb_must.ResetText();
            cmb_palet.ResetText();
            fiyat3.Clear();
            n3.ResetText();
            MessageBox.Show("Kayıt Eklendi");
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili Ögeyi Silmek İstiyor Musunuz ?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Open();
                MySqlCommand kmt = new MySqlCommand();
                kmt.Connection = conn;
                kmt.CommandText = "DELETE FROM urunsatis WHERE fatura_no=@fat_no";
                kmt.Parameters.AddWithValue("@fat_no", dgw_urun.CurrentRow.Cells[0].Value.ToString());
                kmt.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Silme İşlemi Başarılı", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string veri = "SELECT * FROM urunsatis ";
                MySqlDataAdapter da = new MySqlDataAdapter(veri, conn);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dgw_urun.DataSource = ds.Tables[0];
            }
        }

        private void btn_ekle4_Click_1(object sender, EventArgs e)
        {
            string sql = "INSERT INTO urunsatis (fatura_no, urun, musteri, miktar, fiyat, tarih) values (@fat_no,@urun,@musteri,@miktar,@fiyat,@tarih)";
            int a = Int32.Parse(fiyat4.Text);
            int b = Int32.Parse(n4.Value.ToString());

            int fiyat = a * b;
            MySqlCommand Lcmd = new MySqlCommand(sql, conn);
            Lcmd.Parameters.AddWithValue("@musteri", cmb_must.SelectedItem);
            Lcmd.Parameters.AddWithValue("@fat_no", fat_no.Text);
            Lcmd.Parameters.AddWithValue("@urun", cmb_maden.SelectedItem);
            Lcmd.Parameters.AddWithValue("@miktar", n4.Value.ToString());
            Lcmd.Parameters.AddWithValue("@fiyat", fiyat);
            Lcmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Text);

            conn.Open();
            Lcmd.ExecuteNonQuery();
            string veri = "SELECT * FROM urunsatis ";
            MySqlDataAdapter da = new MySqlDataAdapter(veri, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_urun.DataSource = ds.Tables[0];

            conn.Close();
            dateTimePicker1.ResetText();
            fat_no.Clear();
            cmb_must.ResetText();
            cmb_maden.ResetText();
            fiyat4.Clear();
            n4.ResetText();
            MessageBox.Show("Kayıt Eklendi");
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void btn_ekle6_Click_1(object sender, EventArgs e)
        {
            string sql = "INSERT INTO urunsatis (fatura_no, urun, musteri, miktar, fiyat, tarih) values (@fat_no,@urun,@musteri,@miktar,@fiyat,@tarih)";
            int a = Int32.Parse(fiyat6.Text);
            int b = Int32.Parse(n6.Value.ToString());

            int fiyat = a * b;
            MySqlCommand Lcmd = new MySqlCommand(sql, conn);
            Lcmd.Parameters.AddWithValue("@musteri", cmb_must.SelectedItem);
            Lcmd.Parameters.AddWithValue("@fat_no", fat_no.Text);
            Lcmd.Parameters.AddWithValue("@urun", cmb_cam.SelectedItem);
            Lcmd.Parameters.AddWithValue("@miktar", n6.Value.ToString());
            Lcmd.Parameters.AddWithValue("@fiyat", fiyat);
            Lcmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Text);

            conn.Open();
            Lcmd.ExecuteNonQuery();
            string veri = "SELECT * FROM urunsatis ";
            MySqlDataAdapter da = new MySqlDataAdapter(veri, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_urun.DataSource = ds.Tables[0];

            conn.Close();
            dateTimePicker1.ResetText();
            fat_no.Clear();
            cmb_must.ResetText();
            cmb_cam.ResetText();
            fiyat6.Clear();
            n6.ResetText();
            MessageBox.Show("Kayıt Eklendi");

        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Select * From urunsatis where urun like '%" + textBox1.Text + "%'", conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_urun.DataSource = ds.Tables[0];
            conn.Close();
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ekle5_Click_1(object sender, EventArgs e)
        {
            string sql = "INSERT INTO urunsatis (urun, musteri, miktar, fiyat, tarih) values (@urun,@musteri,@miktar,@fiyat,@tarih)";
            int a = Int32.Parse(fiyat5.Text);
            int b = Int32.Parse(n5.Value.ToString());

            int fiyat = a * b;
            
            MySqlCommand Lcmd = new MySqlCommand(sql, conn);
            Lcmd.Parameters.AddWithValue("@urun", cmb_plastik.SelectedItem);
            Lcmd.Parameters.AddWithValue("@musteri", cmb_must.SelectedItem);
            Lcmd.Parameters.AddWithValue("@miktar", n5.Value.ToString());
            Lcmd.Parameters.AddWithValue("@fiyat", fiyat);
            Lcmd.Parameters.AddWithValue("@tarih", dateTimePicker1.Text);

            conn.Open();
            Lcmd.ExecuteNonQuery();
            string veri = "SELECT * FROM urunsatis ";
            MySqlDataAdapter da = new MySqlDataAdapter(veri, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_urun.DataSource = ds.Tables[0];

            conn.Close();
            dateTimePicker1.ResetText();
            fat_no.Clear();
            cmb_must.ResetText();
            cmb_plastik.ResetText();
            fiyat5.Clear();
            n5.ResetText();
            MessageBox.Show("Kayıt Eklendi");
        }



        private void btn_listele_Click(object sender, EventArgs e)
        {
            conn.Open();
            string veri = "SELECT * FROM urunsatis ";
            MySqlDataAdapter da = new MySqlDataAdapter(veri, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgw_urun.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void UrunSatim_Load(object sender, EventArgs e)
        {

            #region ComboBox 
            conn.Open();
            string sorgu1 = "Select * From kagit where 1";

            cmd = new MySqlCommand(sorgu1, conn);
            cmd.CommandType = CommandType.Text;
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cmb_kagit.Items.Add(dr["Kalite"]);
            }
            conn.Close();

            conn.Open();
            string sorgu2 = "Select * From palet where 1";
            cmd2 = new MySqlCommand(sorgu2, conn);
            cmd2.CommandType = CommandType.Text;
            MySqlDataReader dr2;
            dr2 = cmd2.ExecuteReader();

            while (dr2.Read())
            {
                cmb_palet.Items.Add(dr2["Tur"]);
            }
            conn.Close();


            conn.Open();
            string sorgu3 = "Select * From plastik where 1";
            cmd3 = new MySqlCommand(sorgu3, conn);
            cmd3.CommandType = CommandType.Text;
            MySqlDataReader dr3;
            dr3 = cmd3.ExecuteReader();

            while (dr3.Read())
            {
                cmb_plastik.Items.Add(dr3["Tur"]);
            }
            conn.Close();


            conn.Open();
            string sorgu4 = "Select * From maden where 1";
            cmd4 = new MySqlCommand(sorgu4, conn);
            cmd4.CommandType = CommandType.Text;
            MySqlDataReader dr4;
            dr4 = cmd4.ExecuteReader();

            while (dr4.Read())
            {
                cmb_maden.Items.Add(dr4["Cesit"]);
            }
            conn.Close();

            conn.Open();
            string sorgu5 = "Select * From demir where 1";
            cmd5 = new MySqlCommand(sorgu5, conn);
            cmd5.CommandType = CommandType.Text;
            MySqlDataReader dr5;
            dr5 = cmd5.ExecuteReader();

            while (dr5.Read())
            {
                cmb_demir.Items.Add(dr5["Tur"]);
            }
            conn.Close();

            conn.Open();
            string sorgu6 = "Select * From cam where 1";
            cmd6 = new MySqlCommand(sorgu6, conn);
            cmd6.CommandType = CommandType.Text;
            MySqlDataReader dr6;
            dr6 = cmd6.ExecuteReader();

            while (dr6.Read())
            {
                cmb_cam.Items.Add(dr6["Tur"]);
            }
            conn.Close();


            conn.Open();
            string sorgu7 = "Select * From musteri where 1";

            cmd7 = new MySqlCommand(sorgu7, conn);
            cmd7.CommandType = CommandType.Text;
            MySqlDataReader dr7;
            dr7 = cmd7.ExecuteReader();

            while (dr7.Read())
            {
                cmb_must.Items.Add(dr7["must_ad_soyad"]);

            }
            conn.Close();

            #endregion

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

                Categories c = new Categories();
                c.Show();
                this.Hide();
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


    }
}
