using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Andmebaas_TARpv23
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\marina.oleinik\source\repos\Andmebaas_TARpv23\Database.mdf");

        //SqlConnection conn = new SqlConnection(ConfigurationSettings.AppSettings["AndmebaasConnectionString"]);
        
        SqlCommand cmd;
        SqlDataAdapter adapter;
        OpenFileDialog open;
        SaveFileDialog save;
        FileInfo openfile;
        string extension;
        byte[] imageData;
        DataTable laotable;
        public Form1()
        {
            InitializeComponent();
            NaitaAndmed();
            NaitaLaod();
        }
        private void NaitaLaod()
        {
            conn.Open();
            cmd=new SqlCommand("SELECT Id, LaoNimetus FROM Ladu",conn);
            adapter = new SqlDataAdapter(cmd);
            laotable=new DataTable();
            adapter.Fill(laotable);
            foreach (DataRow item in laotable.Rows)
            {
                Ladu_cb.Items.Add(item["LaoNimetus"]);
            }
            conn.Close();
        }
        public void NaitaAndmed()
        {
            conn.Open();
            DataTable dt = new DataTable();
            cmd = new SqlCommand("SELECT * FROM Toode",conn);
            adapter=new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void lisa_btn_Click(object sender, EventArgs e)
        {
            if (Nimetus_txt.Text.Trim() != string.Empty && Kogus_txt.Text.Trim() != string.Empty && Hind_txt.Text.Trim() != string.Empty )
            {
                try
                {
                    conn.Open();

                    cmd=new SqlCommand("SELECT Id FROM Ladu WHERE LaoNimetus=@ladu",conn);
                    cmd.Parameters.AddWithValue("@ladu", Ladu_cb.Text);
                    cmd.ExecuteNonQuery();

                    ID =Convert.ToInt32(cmd.ExecuteScalar());

                    cmd = new SqlCommand("INSERT INTO Toode(Nimetus,Kogus,Hind,Pilt,FusPilt,LaoID) VALUES (@toode,@kogus,@hind,@pilt,@fpilt,@ladu)", conn);
                    cmd.Parameters.AddWithValue("@toode", Nimetus_txt.Text);
                    cmd.Parameters.AddWithValue("@kogus", Kogus_txt.Text);
                    cmd.Parameters.AddWithValue("@hind", Hind_txt.Text);
                    cmd.Parameters.AddWithValue("@pilt", Nimetus_txt.Text+extension);

                    imageData = File.ReadAllBytes(open.FileName);
                    cmd.Parameters.AddWithValue("@fpilt",imageData);
                    cmd.Parameters.AddWithValue("@ladu", ID);

                    cmd.ExecuteNonQuery();

                    conn.Close();
                    Eemaldamine();
                    NaitaAndmed();
                }
                catch (Exception)
                {
                    MessageBox.Show("Andmebaasiga viga!");
                }
            }
            else
            {
                MessageBox.Show("Sisesta andmeid!");
            }
        }
        int ID=0;
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
            Nimetus_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Nimetus"].Value.ToString();
            Kogus_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Kogus"].Value.ToString();
            Hind_txt.Text = dataGridView1.Rows[e.RowIndex].Cells["Hind"].Value.ToString();
            try
            {

                using (FileStream fs = new FileStream(Path.Combine(Path.GetFullPath(@"..\..\Pildid"), dataGridView1.Rows[e.RowIndex].Cells["Pilt"].Value.ToString()), FileMode.Open, FileAccess.Read))
                {
                    pictureBox1.Image = Image.FromStream(fs);
                }

                //pictureBox1.Image = Image.FromFile(Path.Combine(Path.GetFullPath(@"..\..\Pildid"), dataGridView1.Rows[e.RowIndex].Cells["Pilt"].Value.ToString()));
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (Exception)
            {
                using (FileStream fs = new FileStream(Path.Combine(Path.GetFullPath(@"..\..\Pildid"), "pilt.png"), FileMode.Open, FileAccess.Read))
                {
                    pictureBox1.Image = Image.FromStream(fs);
                }
                //pictureBox1.Image = Image.FromFile(Path.Combine(Path.GetFullPath(@"..\..\Pildid"),"pilt.png"));
                
            }
        }

        private void uuenda_btn_Click(object sender, EventArgs e)
        {
            if (Nimetus_txt.Text.Trim() != string.Empty && Kogus_txt.Text.Trim() != string.Empty && Hind_txt.Text.Trim() != string.Empty)
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("UPDATE Toode SET Nimetus=@toode,Kogus=@kogus,Hind=@hind,Pilt=@pilt WHERE Id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@toode", Nimetus_txt.Text);
                    cmd.Parameters.AddWithValue("@kogus", Kogus_txt.Text);
                    cmd.Parameters.AddWithValue("@hind", Hind_txt.Text);
                    cmd.Parameters.AddWithValue("@pilt", Nimetus_txt.Text+extension);
                    //cmd.Parameters.AddWithValue("@pilt", Nimetus_txt.Text + extension);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    NaitaAndmed();
                    Eemaldamine();                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Andmebaasiga viga!");
                }
            }
            else
            {
                MessageBox.Show("Sisesta andmeid!");
            }
        }

        private void Eemaldamine()
        {
            MessageBox.Show("Andmed edukalt uuendatud", "Uuendamie");
            Nimetus_txt.Text = "";
            Kogus_txt.Text = "";
            Hind_txt.Text = "";
            using (FileStream fs = new FileStream(Path.Combine(Path.GetFullPath(@"..\..\Pildid"), "pilt.png"), FileMode.Open, FileAccess.Read))
            {
                pictureBox1.Image = Image.FromStream(fs);
            }
            //pictureBox1.Image = Image.FromFile(Path.Combine(Path.GetFullPath(@"..\..\Pildid"), "pilt.png"));
        }

        
        private void otsipilt_btn_Click(object sender, EventArgs e)
        {
            open= new OpenFileDialog();
            open.InitialDirectory = @"C:\Users\marina.oleinik\Pictures\";
            open.Multiselect = false;
            open.Filter = "Images Files(*.jpeg;*.png;*.bmp;*.jpg)|*.jpeg;*.png;*.bmp;*.jpg";
            openfile= new FileInfo(@"C:\Users\marina.oleinik\Pictures\"+open.FileName);
            if (open.ShowDialog()==DialogResult.OK && Nimetus_txt.Text!=null)
            { 

                save= new SaveFileDialog();
                save.InitialDirectory = Path.GetFullPath(@"..\..\Pildid");
                
                extension=Path.GetExtension(open.FileName);
                
                save.FileName= Nimetus_txt.Text + extension;
                save.Filter = "Images" + Path.GetExtension(open.FileName) + "|" + Path.GetExtension(open.FileName);
                if (save.ShowDialog()==DialogResult.OK && Nimetus_txt!=null)
                {
                    File.Copy(open.FileName, save.FileName);
                    pictureBox1.Image=Image.FromFile(save.FileName);
                }
            }
            else
            {
                MessageBox.Show("Puudub toode nimetus või ole Cancel vajutatud");
            }
        }
        public void Failivabastus(PictureBox pb)
        {
            if (pb.Image != null)
            {
                pb.Image.Dispose();
                pb = null;
            }
        }
        private void kustuta_btn_Click(object sender, EventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                if(ID!=0) 
                {
                    conn.Open();
                    cmd = new SqlCommand("DELETE FROM Toode WHERE Id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    string file = dataGridView1.SelectedRows[0].Cells["Pilt"].Value.ToString();//Nimetus_txt.Text+extension;                   
                    Eemaldamine();
                    NaitaAndmed();
                    Kustuta_fail(file);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Viga!");
            }
        }
        private void Kustuta_fail(string file)
        {
            try
            {
                string filePath = Path.Combine(Path.GetFullPath(@"..\..\Pildid"), file);
                if (File.Exists(filePath))
                {
                        File.Delete(filePath);
                        MessageBox.Show($"Fail {filePath} on kustutatud");
                }
                else
                {
                    MessageBox.Show("Fail ei leitud");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failiga probleemid {ex.Message}");
            }
        }
        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex ==4 )
            {
                imageData = dataGridView1.Rows[e.RowIndex].Cells["FusPilt"].Value as byte[];
                if (imageData != null)
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        Image image = Image.FromStream(ms);
                        Loopilt(image, e.RowIndex);
                    }
                }
            }
        }
        Form popupForm;
        private void Loopilt(Image image, int r)
        {
            popupForm = new Form();
            popupForm.FormBorderStyle = FormBorderStyle.None;
            popupForm.StartPosition = FormStartPosition.Manual;
            popupForm.Size = image.Size;

            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = image;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            popupForm.Controls.Add(pictureBox);

            Rectangle cellRectangle = dataGridView1.GetCellDisplayRectangle(4, r, true);
            Point popupLocation = dataGridView1.PointToScreen(cellRectangle.Location);

            popupForm.Location = new Point(popupLocation.X + cellRectangle.Width, popupLocation.Y); 
            popupForm.Show();
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (popupForm != null && !popupForm.IsDisposed)
            {
                popupForm.Close();
            }
        }
    }
}
