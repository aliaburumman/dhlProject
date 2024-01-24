using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace assign3
{
    public partial class Form1 : Form
    {
        SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Users\USER\Desktop\vsc\assign3\assign3\bin\Debug\DHL.db;Version=3");
        SQLiteCommand cmd = new SQLiteCommand();
        SQLiteDataAdapter da = new SQLiteDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt;
        SQLiteDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void labelref_Click(object sender, EventArgs e)
        {

        }

        private void textBoxaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelgm_Click(object sender, EventArgs e)
        {

        }

        private void Weight_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Box_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Envelope_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBoxref_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxDetails_Enter(object sender, EventArgs e)
        {

        }

        private void labeladdress_Click(object sender, EventArgs e)
        {

        }

        private void labelweight_Click(object sender, EventArgs e)
        {

        }

        private void labeltype_Click(object sender, EventArgs e)
        {

        }

        private void labelshipname_Click(object sender, EventArgs e)
        {

        }

        private void textBoxshippername_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void deleteRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con.Open();


            //    refnumber, shipname, packagetype, packageweight,shipperaddress,destination,cons1name,cons2name
            //    values (@textBoxref, @textBoxshippername, @Box, @Weight, @textBoxaddress, @comboBoxDest, @textBoxconsname1,@textBoxconsname2)


            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM Orders" +
                " WHERE refnumber=@textBoxref";

            cmd.Parameters.AddWithValue("textBoxref", textBoxref.Text);

            DialogResult result = MessageBox.Show("Are you Sure you want to delete this Record?",
                "Delete Record", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 0)
                    MessageBox.Show("Error .. Record Not Deleted");
                else
                    MessageBox.Show("Record Deleted Successfully");
            }
            con.Close();
        }

        private void newShippingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Insert Into Orders (refnumber, shipname, packagetype, packageweight,shipperaddress,destination,cons1name,cons2name)" +
                            "values (@textBoxref, @textBoxshippername, @Box, @Weight, @textBoxaddress, @comboBoxDest, @textBoxconsname1,@textBoxconsname2)";

            cmd.Parameters.AddWithValue("@textBoxref", textBoxref.Text);
            cmd.Parameters.AddWithValue("@textBoxshippername", textBoxshippername.Text);
            cmd.Parameters.AddWithValue("@Box", (Box.Checked) ? 1 : 0);
            cmd.Parameters.AddWithValue("@Weight", Weight.Value);
            cmd.Parameters.AddWithValue("@textBoxaddress", textBoxaddress.Text);
            cmd.Parameters.AddWithValue("@comboBoxDest", comboBoxDest.SelectedValue);
            cmd.Parameters.AddWithValue("@textBoxconsname1", textBoxConsname1.Text);
            cmd.Parameters.AddWithValue("@textBoxconsname2", textBoxConsname2.Text);


            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected == 0)
                MessageBox.Show("Error .. Record Not Added");
            else
                MessageBox.Show("Record Inserted Successfully");

            // 4- close DB connection
            con.Close();
        }

            private void updateExistingToolStripMenuItem_Click(object sender, EventArgs e)
        {
                con.Open();
            try
            {
              //  "Insert Into Orders (refnumber, shipname, packagetype, packageweight,shipperaddress,destination,cons1name,cons2name)" +
                         //   "values (@textBoxref, @textBoxshippername, @Box, @Weight, @textBoxaddress, @comboBoxDest, @textBoxconsname1,@textBoxconsname2)";
                
                cmd.Connection = con;                     cmd.CommandText = "Update Orders SET shipname=@texBoxshippername, packagetype=@Box, packageweight=@Weight, shipperaddress=@textBoxaddress, destination=@comboBoxDest, cons1name=@textBoxconsname1,cons2name=@textBoxconsname2 WHERE refnumber=@textBoxref";
                cmd.Parameters.AddWithValue("textBoxref", textBoxref.Text);
                cmd.Parameters.AddWithValue("textBoxshippername", textBoxshippername.Text);
                    cmd.Parameters.AddWithValue("Box", (Box.Checked) ? 1 : 0);
                    cmd.Parameters.AddWithValue("Weight", Weight.Value);
                    cmd.Parameters.AddWithValue("textBoxaddress", textBoxaddress.Text);
                    cmd.Parameters.AddWithValue("comboBoxDest", comboBoxDest.SelectedValue);
                    cmd.Parameters.AddWithValue("textBoxconsname1", textBoxConsname1.Text);
                    cmd.Parameters.AddWithValue("textBoxconsname2", textBoxConsname2.Text);


                   int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected == 0)
                        MessageBox.Show("Error .. Record Not Updated");
                    else
                        MessageBox.Show("Record Updated Successfully");
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                }
                finally
                {
                    con.Close();
                }
            
            

            }




        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con.Open();

            string strCmd = "SELECT * FROM Orders WHERE shipname=@textBoxshippername";

            cmd = new SQLiteCommand(strCmd, con);
            cmd.Parameters.AddWithValue("@textBoxshippername", textBoxshippername.Text);

            da = new SQLiteDataAdapter(cmd); 

            ds = new DataSet();
            da.Fill(ds, "Orders");

            var MainForm = new MainForm();
            MainForm.dataGridView1.DataSource = ds.Tables["Orders"].DefaultView;
            MainForm.Show();

            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile("C:\\Users\\USER\\Desktop\\Algo\\download.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}
