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

namespace GBIACK
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=STATIONONE;Initial Catalog=gbiak;Integrated Security=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string username, user_password;
            username = txt_username.Text;
            user_password = txt_password.Text;

            try
            {
                SqlCommand cmd  = new SqlCommand("Select* FROM logintbl WHERE username = '" + txt_username.Text + "'AND password = '" + txt_password.Text + "'",conn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)

                {
                    //username = txt_username.Text;
                    //user_password = txt_password.Text;
                    MessageBox.Show("Login Succesful");
                    // page that needed to be load next
                    form1 form = new form1();
                    form.Show();
                    this.Hide();


                }
                else
                {
                    MessageBox.Show ("Invalid Login details,messageboxbutton.OK, MessageBoxIcon.Error");
                    txt_username.Clear();
                    txt_password.Clear();
                    // to focus username
                    txt_username.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();

            txt_username.Focus();

        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit","Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else

            { 
            
                this.Show();
            }
        }
    }
}