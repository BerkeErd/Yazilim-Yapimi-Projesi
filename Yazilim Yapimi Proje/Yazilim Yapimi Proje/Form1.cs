using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Yazilim_Yapimi_Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        Sistem sistem = new Sistem();
        private void btnStoryEkle_Click(object sender, EventArgs e)
        {
            if (txtStory.Text == "")
            {
                MessageBox.Show("Story bos olamaz.");
            }
            else
            {

                Story s = new Story();
                s.Bilgi = txtStory.Text;
                sistem.Storyler.Add(s);
                int i = sistem.Storyler.Count;
                s.Baslik = "Story#" + i;
                cmboStory.Items.Add(s.Baslik);
                MessageBox.Show("" + s.Baslik + " Eklendi.");

                dtgScrumTable.Rows.Add(s.Baslik);





            }
        }

        private void cmboStory_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnTaskEkle_Click(object sender, EventArgs e)
        {
            if (txtTask.Text == "")
            {
                MessageBox.Show("Task bos olamaz.");
            }
            else if (cmboStory.Text == "")
            {
                MessageBox.Show("Task'in ait olduğu storynin seçilmesi gerekiyor.");
            }
            else
            {


                foreach (Story story in sistem.Storyler)
                {
                    if (story.Baslik == cmboStory.Text)
                    {
                        Task t = new Task(story);
                        t.Bilgi = txtTask.Text;
                        t.YapanKisi = txtYapacakKisi.Text;
                        t.YapilisTarihi = dtBitisTarihi.Value.Date;
                        int i = sistem.Tasklar.Count + 1;
                        t.Baslik = "Task#" + i;

                        if (txtYapacakKisi.Text == "")
                        {
                            t.YapanKisi = "Herhangi birisi";
                        }

                        if (Convert.ToString(cmbDurum.SelectedItem) == "Done")
                        {
                            t.Durumu = taskTuru.Done;
                            dtgScrumTable.Rows.Add(t.aitOlduguStory.Baslik, "", "", t.Baslik);
                        }
                        else if (Convert.ToString(cmbDurum.SelectedItem) == "In Progress")
                        {
                            t.Durumu = taskTuru.In_Progress;
                            dtgScrumTable.Rows.Add(t.aitOlduguStory.Baslik, "", t.Baslik);
                        }
                        else //default
                        {
                            t.Durumu = taskTuru.Not_Started;
                            dtgScrumTable.Rows.Add(t.aitOlduguStory.Baslik, t.Baslik);
                        }


                        story.Tasklar.Add(t);
                        sistem.Tasklar.Add(t);

                        MessageBox.Show("Eklendi.");
                    }
                }







            }
        }

        private void dtgScrumTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string secenek = Convert.ToString(dtgScrumTable.CurrentCell.Value);

            if (secenek.Contains("Task"))
            {

                foreach (Task task in sistem.Tasklar)
                {
                    if (secenek == task.Baslik)
                    {
                        btnTamam.Visible = true;
                        txtTask.Text = task.Bilgi;
                        txtYapacakKisi.Text = task.YapanKisi;
                        dtBitisTarihi.Value = task.YapilisTarihi;
                        cmboStory.SelectedText = task.aitOlduguStory.Baslik;
                        cmbDurum.SelectedText = Convert.ToString(task.Durumu);
                        txtStory.Enabled = false;
                        btnStoryEkle.Enabled = false;
                        btnTaskEkle.Enabled = false;
                        dtBitisTarihi.Enabled = false;
                        txtTask.Enabled = false;
                        txtYapacakKisi.Enabled = false;
                        cmboStory.Enabled = false;
                        dtgScrumTable.Enabled = false;
                        btnSil.Visible = true;
                        if (task.Durumu == taskTuru.Done)
                        {
                            MessageBox.Show("" + task.Baslik + Environment.NewLine + "Ait olduğu Story : " + task.aitOlduguStory.Baslik + Environment.NewLine + "Yapılmış olan iş : " + task.Bilgi + Environment.NewLine + "Task'ı gerçekleştirmiş olan kişi : " + task.YapanKisi + Environment.NewLine + "Durumu :" + task.Durumu);
                        }
                        else if (task.Durumu == taskTuru.In_Progress)
                        {
                            MessageBox.Show("" + task.Baslik + Environment.NewLine + "Ait olduğu Story : " + task.aitOlduguStory.Baslik + Environment.NewLine + "Yapılan İş : " + task.Bilgi + Environment.NewLine + "Task'ı gerçekleştiren kişi : " + task.YapanKisi + Environment.NewLine + "Yapılması gereken tarih : " + task.YapilisTarihi + Environment.NewLine + "Durumu :" + task.Durumu);
                        }
                        else if (task.Durumu == taskTuru.Not_Started)
                        {
                            MessageBox.Show("" + task.Baslik + Environment.NewLine + "Ait olduğu Story : " + task.aitOlduguStory.Baslik + Environment.NewLine + "Yapılacak İş : " + task.Bilgi + Environment.NewLine + "Task'ı gerçekleştirecek kişi : " + task.YapanKisi + Environment.NewLine + "Yapılması gereken tarih : " + task.YapilisTarihi + Environment.NewLine + "Durumu :" + task.Durumu);
                        }
                    }
                }

            }
            else if (secenek.Contains("Story"))
            {

                foreach (Story story in sistem.Storyler)
                {
                    if (secenek == story.Baslik)
                    {
                        btnTamam.Visible = true;
                        txtStory.Text = story.Bilgi;
                        txtStory.Enabled = false;
                        btnStoryEkle.Enabled = false;
                        btnTaskEkle.Enabled = false;
                        dtBitisTarihi.Enabled = false;
                        txtTask.Enabled = false;
                        txtYapacakKisi.Enabled = false;
                        cmboStory.Enabled = false;
                        cmbDurum.Enabled = false;
                        dtgScrumTable.Enabled = false;
                        btnSil.Visible = true;
                        MessageBox.Show("" + story.Baslik + Environment.NewLine + "Yapılacak İş : " + story.Bilgi + Environment.NewLine + "Sahip olduğu Task sayısı : " + story.Tasklar.Count);
                    }
                }

            }

        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            btnTamam.Visible = false;
            txtStory.Enabled = true;
            btnStoryEkle.Enabled = true;
            btnTaskEkle.Enabled = true;
            dtBitisTarihi.Enabled = true;
            txtTask.Enabled = true;
            txtYapacakKisi.Enabled = true;
            cmboStory.Enabled = true;
            cmbDurum.Enabled = true;
            dtgScrumTable.Enabled = true;
            btnSil.Visible = false;
            txtStory.Text = "";
            txtTask.Text = "";
            txtYapacakKisi.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtBitisTarihi.MinDate = DateTime.Today;

        }

        private void cmbDurum_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secenek = Convert.ToString(dtgScrumTable.CurrentCell.Value);

            if (btnTamam.Visible)
            {


                foreach (Task task in sistem.Tasklar)
                {
                    if (secenek == task.Baslik)
                    {
                        dtgScrumTable.CurrentRow.Visible = false;

                        if (Convert.ToString(cmbDurum.SelectedItem) == "Done")
                        {
                            task.Durumu = taskTuru.Done;
                            dtgScrumTable.Rows.Add(task.aitOlduguStory.Baslik, "", "", task.Baslik);
                        }
                        else if (Convert.ToString(cmbDurum.SelectedItem) == "In Progress")
                        {
                            task.Durumu = taskTuru.In_Progress;
                            dtgScrumTable.Rows.Add(task.aitOlduguStory.Baslik, "", task.Baslik);
                        }
                        else //default
                        {
                            task.Durumu = taskTuru.Not_Started;
                            dtgScrumTable.Rows.Add(task.aitOlduguStory.Baslik, task.Baslik);
                        }
                    }
                }
                MessageBox.Show("DEĞİŞİM BAŞARILI");
                cmbDurum.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string secenek = Convert.ToString(dtgScrumTable.CurrentCell.Value);


            DialogResult EvetHayir = MessageBox.Show("Seçili bilgiyi silmek istediğinizden emin misiniz?", "Bilgilendirme Penceresi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (EvetHayir == DialogResult.Yes)
            {
                if (secenek.Contains("Task"))
                {

                    foreach (Task task in sistem.Tasklar)
                    {
                        if (secenek == task.Baslik)
                        {
                            dtgScrumTable.CurrentRow.Visible = false;
                            MessageBox.Show("Task Başarıyla silindi");
                            btnTamam.Visible = false;
                            txtStory.Enabled = true;
                            btnStoryEkle.Enabled = true;
                            btnTaskEkle.Enabled = true;
                            dtBitisTarihi.Enabled = true;
                            txtTask.Enabled = true;
                            txtYapacakKisi.Enabled = true;
                            cmboStory.Enabled = true;
                            cmbDurum.Enabled = true;
                            dtgScrumTable.Enabled = true;
                            btnSil.Visible = false;
                            txtStory.Text = "";
                            txtTask.Text = "";
                            txtYapacakKisi.Text = "";
                        }
                    }

                }
                else if (secenek.Contains("Story"))
                {

                    foreach (Story story in sistem.Storyler)
                    {
                        if (secenek == story.Baslik)
                        {                
                            dtgScrumTable.CurrentRow.Visible = false;
                            MessageBox.Show("Story Başarıyla silindi");
                            btnTamam.Visible = false;
                            txtStory.Enabled = true;
                            btnStoryEkle.Enabled = true;
                            btnTaskEkle.Enabled = true;
                            dtBitisTarihi.Enabled = true;
                            txtTask.Enabled = true;
                            txtYapacakKisi.Enabled = true;
                            cmboStory.Enabled = true;
                            cmbDurum.Enabled = true;
                            dtgScrumTable.Enabled = true;
                            btnSil.Visible = false;
                            txtStory.Text = "";
                            txtTask.Text = "";
                            txtYapacakKisi.Text = "";
                        }
                    }

                }
                
            }
            else if (EvetHayir == DialogResult.No)
            {
                
            }
            

                
                
                
            
        }
    }
}
