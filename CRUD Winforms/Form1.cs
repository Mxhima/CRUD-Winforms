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
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Update records
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Delete records 
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Search records

            
        }
    }
}
