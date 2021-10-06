using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CRUD_Winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //SqlConnection
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mahima\Documents\DB3.mdf;Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {

            //Insert records
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT into ItemTable values ("+int.Parse(textBox1.Text)+ ", '" +textBox2.Text+ "', '" + textBox3.Text + "', getdate())", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Successfully inserted.");
            con.Close();
            BindData();


        }

        void BindData()
        {
            //Show in Datagridview
            SqlCommand cmd2 = new SqlCommand("SELECT * from ItemTable", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Update records
            con.Open();
            SqlCommand cmd3 = new SqlCommand("UPDATE ItemTable set ItemName = '"+textBox2.Text+"', '"+textBox3.Text+"' where ProductID = '"+int.Parse(textBox1.Text)+"' ", con);
            cmd3.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Successfully Updated.");
            BindData();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Delete records 
            if (textBox1.Text != "")
        {
            if (MessageBox.Show("Are you sure to proceed with Delete?", "Delete Record", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
        con.Open();
        SqlCommand cmd4 = new SqlCommand("Delete Itemtable where ProductID = '" + int.Parse(textBox1.Text) + "' ", con);
        cmd4.ExecuteNonQuery();
        con.Close();
        MessageBox.Show("Record Successfully Deleted.");
        BindData();
        }
        }
       else
       {
       MessageBox.Show("Input the Product ID");
       }
            
            
       }

        private void button4_Click(object sender, EventArgs e)
        {
            //Search records

            
        }
    }
}
