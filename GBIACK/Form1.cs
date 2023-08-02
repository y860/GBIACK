using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.IO;


namespace GBIACK
{
    public partial class form1 : MaterialForm
    {
        // Initialize the connectionString variable with the correct connection string
        public static string connectionString = "Data Source=STATIONONE;Initial Catalog=gbiak;Integrated Security=True;Pooling=False";

        System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString);

        public string imglocation;

        public form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green700, Primary.Green700, Primary.Green700, Accent.Green700, TextShade.WHITE);
        }
        public void livesearch()
        {
            try
            {
                con.Open();
                SqlDataAdapter da;
                DataTable dt;

                da = new SqlDataAdapter("Select * from SeedBank WHERE  Name like'" + this.txtsearchseedid.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        public void Studentsearch()
        {
            try
            {
                con.Open();
                SqlDataAdapter da;
                DataTable dt;

                da = new SqlDataAdapter("Select * from Student WHERE  StudentName like'" + this.txtsearchstudent.Text + "%' or Admission like'" + this.txtsearchstudent.Text + "%' or ContactNumber like'" + this.txtsearchstudent.Text + "%' or ParentName like'" + this.txtsearchstudent.Text + "%' or PhoneNumber like'" + this.txtsearchstudent.Text + "%' or Location like'" + this.txtsearchstudent.Text + "%'", con);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView7.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        public void binddata()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select *from seedbank", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        public void binddata1()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("select * from student", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView7.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gbiakDataSet14.SeedBank' table. You can move, or remove it, as needed.
            this.seedBankTableAdapter1.Fill(this.gbiakDataSet14.SeedBank);
            // TODO: This line of code loads data into the 'gbiakDataSet13.tracking' table. You can move, or remove it, as needed.
            this.trackingTableAdapter.Fill(this.gbiakDataSet13.tracking);
            Studentsearch();
            // TODO: This line of code loads data into the 'gbiakDataSet12.student' table. You can move, or remove it, as needed.
            this.studentTableAdapter3.Fill(this.gbiakDataSet12.student);
            // TODO: This line of code loads data into the 'gbiakDataSet11.student' table. You can move, or remove it, as needed.
            searchharvest();
            searchsales();
            searchbednumber();
            searchseedid();
            searchmaterial();
            saerchroomnumber();
            binddata1();
            // TODO: This line of code loads data into the 'gbiakDataSet10.student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter1.Fill(this.gbiakDataSet10.student);
            // TODO: This line of code loads data into the 'gbiakDataSet9.Housing' table. You can move, or remove it, as needed.
            //this.housingTableAdapter2.Fill(this.gbiakDataSet9.Housing);
            // TODO: This line of code loads data into the 'gbiakDataSet8.student' table. You can move, or remove it, as needed.
            // this.studentTableAdapter1.Fill(this.gbiakDataSet8.student);
            // TODO: This line of code loads data into the 'gbiakDataSet7.STUDENT' table. You can move, or remove it, as needed.
            //this.sTUDENTTableAdapter.Fill(this.gbiakDataSet7.STUDENT);
            // TODO: This line of code loads data into the 'gbiakDataSet6.Textile' table. You can move, or remove it, as needed.
            //this.textileTableAdapter.Fill(this.gbiakDataSet6.Textile);
            // TODO: This line of code loads data into the 'gbiakDataSet5.Housing' table. You can move, or remove it, as needed.
            //this.housingTableAdapter1.Fill(this.gbiakDataSet5.Housing);
            // TODO: This line of code loads data into the 'gbiakDataSet4.Housing' table. You can move, or remove it, as needed.
            //this.housingTableAdapter.Fill(this.gbiakDataSet4.Housing);
            // TODO: This line of code loads data into the 'gbiakDataSet3.SeedBank' table. You can move, or remove it, as needed.
            // this.seedBankTableAdapter.Fill(this.gbiakDataSet3.SeedBank);
            // TODO: This line of code loads data into the 'gbiakDataSet2.SALES' table. You can move, or remove it, as needed.
            //this.sALESTableAdapter.Fill(this.gbiakDataSet2.SALES);
            // TODO: This line of code loads data into the 'gbiakDataSet1.Garden' table. You can move, or remove it, as needed.
            // this.gardenTableAdapter.Fill(this.gbiakDataSet1.Garden);

        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void materialComboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void materialButton17_Click(object sender, EventArgs e)
        {
            if (txtseedid.Text == "" || txtquantity.Text == "" || txtseedname.Text == "" || cmbseedcategory.Text == "")
            {
                MessageBox.Show("all fields must be filled", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    byte[] images = null;
                    FileStream streem = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                    BinaryReader brs = new BinaryReader(streem);
                    images = brs.ReadBytes((int)streem.Length);
                    SqlCommand cmd = new SqlCommand("Insert into SeedBank(seedid, Name, Category, Destination,Quantity, Description,picture,DOE)Values('" + txtseedid.Text + "', '" + txtseedname.Text + "', '" + cmbseedcategory.Text + "', '" + txtDestination.Text + "','" + txtquantity.Text + "', '" + txtDescription.Text + "',@images,'" + dateTimePicker1.Text + "')", con);
                    cmd.Parameters.Add(new SqlParameter("@images", images));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Inserted sucessfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    binddata();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton16_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|all files(*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imglocation = dialog.FileName.ToString();
                    pictureBox1.ImageLocation = imglocation;
                }
            }
        }
        public void searchseedid()
        {

        }
        private void materialTextBox20_TextChanged(object sender, EventArgs e)
        {
            searchseedid();
            {
                try
                {
                    con.Open();
                    SqlDataAdapter da;
                    DataTable dt;

                    da = new SqlDataAdapter("Select * from SeedBank WHERE  Name like'" + this.txtsearchseedid.Text + "%'", con);
                    dt = new DataTable();
                    da.Fill(dt);
                    dataGridView2.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }

            }
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {


                if (dataGridView4.Columns[e.ColumnIndex].Name == "view")
                {
                    DataGridViewRow dr = new DataGridViewRow();
                    dr = dataGridView4.SelectedRows[0];
                    txtseedid.Text = dr.Cells[0].Value.ToString();
                    txtseedname.Text = dr.Cells[1].Value.ToString();
                    cmbseedcategory.Text = dr.Cells[2].Value.ToString();
                    txtquantity.Text = dr.Cells[4].Value.ToString();
                    txtDescription.Text = dr.Cells[5].Value.ToString();
                    txtDestination.Text = dr.Cells[3].Value.ToString();
                    dateTimePicker1.Text = dr.Cells[7].Value.ToString();
                }

                //Picture1.Text = dr.Cells[0].Value.ToString();
            }
        }

        private void tableLayoutPanel24_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialCard6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "view")
            {
                DataGridViewRow dr = new DataGridViewRow();
                dr = dataGridView1.SelectedRows[0];
                txtbednumber.Text = dr.Cells[0].Value.ToString();
                txtcropplanted.Text = dr.Cells[1].Value.ToString();
                dateplanted.Text = dr.Cells[2].Value.ToString();

            }
        }

        private void materialButton24_Click(object sender, EventArgs e)
        {
            if (txtmaterialid.Text == "" || cmbmaterialcategory.Text == "" || txtquant.Text == "" || dateTimePicker13.Text == "" || txtdesignmade.Text == "" || txtdest.Text == "" || txtamount.Text == "")
            {
                MessageBox.Show("all fields must be filled", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    con.Open();
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        SqlCommand cmd = new SqlCommand("insert into Harvesting(Item, Quantity, Price, Total, Destination, Date harvested)values('" + txtItem.Text + "','" + txtquanty.Text + "','" + txtprice.Text + "','" + txtTotal.Text + "','" + txtdestiny.Text + "','" + dateharvested.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("data inserted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        binddata1();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void materialButton6_Click(object sender, EventArgs e)
        {
            if (txtItem.Text == "" || txtquanty.Text == "" || txtprice.Text == "" || txtTotal.Text == "" || txtdestiny.Text == "")
            {
                MessageBox.Show("all fields must be filled", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    con.Open();
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        SqlCommand cmd = new SqlCommand("insert into Harvesting(Item, Quantity, Price, Total, Destination, Date harvested)values('" + txtItem.Text + "','" + txtquanty.Text + "','" + txtprice.Text + "','" + txtTotal.Text + "','" + txtdestiny.Text + "','" + dateharvested.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("data inserted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        binddata1();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        private void materialButton20_Click(object sender, EventArgs e)
        {
            if (txtroomnumber.Text == "" || txtgbiackstaff.Text == "" || txtammount.Text == "" || dateTimePicker11.Text == "" || dateTimePicker12.Text == "")
            {
                MessageBox.Show("all fields must be filled", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    con.Open();
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        SqlCommand cmd = new SqlCommand("insert into Housing(Room Number, Guest/Staff, Amount, Date,)values('" + txtroomnumber.Text + "','" + txtgbiackstaff.Text + "','" + txtammount.Text + "','" + Date.Text + "') ", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("data inserted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        binddata1();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }

        }
        private void materialComboBox1_SelectedIndexChanged_3(object sender, EventArgs e)
        {

        }

        private void materialLabel6_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            if (txtbednumber.Text == "" || txtcropplanted.Text == "")
            {
                MessageBox.Show("all fields must be filled", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                try
                {
                    con.Open();
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        SqlCommand cmd = new SqlCommand("insert into Garden (bednumber, cropplanted, dateplanted)values('" + txtbednumber.Text + "','" + txtcropplanted.Text + "','" + dateplanted.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("data inserted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        binddata1();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void materialButton11_Click(object sender, EventArgs e)
        {
            if (txtitems.Text == "" || txtquantys.Text == "" || txtprices.Text == "" || txttotals.Text == "" || txtdestinys.Text == "")
            {
                MessageBox.Show("all fields must be filled", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    con.Open();
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        SqlCommand cmd = new SqlCommand("insert into SALES(Item, Quantity, Price, Total, Destination, Date Sold)values('" + txtitems.Text + "','" + txtquantys.Text + "','" + txtprices.Text + "','" + txttotals.Text + "','" + txtdestinys.Text + "','" + datesold.Text + "')", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("data inserted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        binddata1();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void materialButton28_Click(object sender, EventArgs e)
        {
            if (txtstudentname.Text == "" || txtadmissionnumber.Text == "" || txtcontactnumber.Text == "" || txtparentname.Text == "" || txtphonenumber.Text == "" || txtlocation.Text == "")
            {
                MessageBox.Show("all fields must be filled", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                try
                {
                    con.Open();
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        SqlCommand cmd = new SqlCommand("insert into STUDENT (studentname, admission, contactNumber,parentname,location,phonenumber)values('" + txtstudentname.Text + "','" + txtadmissionnumber.Text + "','" + txtcontactnumber.Text + "','" + txtparentname.Text + "','" + txtlocation.Text + "','" + txtphonenumber.Text + "'); ", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("data inserted successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        binddata1();

                    };


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void materialButton29_Click(object sender, EventArgs e)
        {
            if (txtsearchstudent.Text == "" || txtadmissionnumber.Text == "")
            {
                MessageBox.Show("The search field is required", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    con.Open();
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        SqlCommand cmd = new SqlCommand("update Student set studentName ='" + txtstudentname.Text + "',Admission='" + txtadmissionnumber.Text + "',ContactNumber='" + txtcontactnumber.Text + "', ParentName ='" + txtparentname.Text + "',PhoneNumber ='" + txtphonenumber.Text + "', Location = '" + txtlocation.Text + "' where Admission ='" + txtsearchstudent.Text + "'", con);
                        cmd.ExecuteNonQuery();
                        binddata1();
                        MessageBox.Show("Record updated succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }

        }
        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (txtsearchbednumber.Text == "" || txtbednumber.Text == "")
            {
                MessageBox.Show("The search field is required", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                try
                {
                    con.Open();
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        SqlCommand cmd = new SqlCommand("update Garden set Bednumber='" + txtbednumber.Text + "',cropplanted='" + txtcropplanted.Text + "',dateplanted='" + dateplanted.Text + "'where bednumber='" + label1.Text + "'", con);
                        {
                            cmd.ExecuteNonQuery();
                            binddata1();
                            MessageBox.Show("Record updated succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
        }

        private void materialButton30_Click(object sender, EventArgs e)
        {
            if (txtsearchstudent.Text == "" || txtadmissionnumber.Text == "")
            {
                MessageBox.Show("The search field is required", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                {
                    try
                    {
                        con.Open();
                        if (con.State == System.Data.ConnectionState.Open)
                        {
                            SqlCommand cmd = new SqlCommand("delete  from STUDENT Where admission ='" + txtsearchstudent.Text + "'", con);
                            if (MessageBox.Show("Are you sure you want to permanently delete this data", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Record Deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                binddata1();
                            }
                            else
                            {
                                MessageBox.Show("Record retained", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }


                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }


            }
        }
        private void materialButton31_Click(object sender, EventArgs e)
        {

        }

        private void materialButton31_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("Select * from STUDENT Where Student name='" + txtsearchstudent.Text + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                    }
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void materialButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The search field is required", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            {
                try
                {
                    con.Open();
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        SqlCommand cmd = new SqlCommand("delete  from STUDENT Where admission ='" + txtsearchstudent.Text + "'", con);
                        if (MessageBox.Show("Are you sure you want to permanently delete this data", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Record Deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            binddata1();
                        }
                        else
                        {
                            MessageBox.Show("Record retained", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        private void materialButton4_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("Select * from Tracking where bednumber = '" + txtsearchbednumber.Text + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        txtbednumber.Text = dt.Rows[0][1].ToString();
                        txtcropplanted.Text = dt.Rows[0][2].ToString();
                        Date.Text = dt.Rows[0][3].ToString();

                    }
                    else
                    {
                        MessageBox.Show("This record does not exist", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void materialButton5_Click(object sender, EventArgs e)
        {

        }
        public void searchbednumber()
        {

        }

        private void txtsearchusingdednumber_TextChanged(object sender, EventArgs e)
        {
            searchbednumber();
        }

        private void materialButton7_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("update Harvesting set Item='" + txtItem.Text + "',Quantity='" + txtquanty.Text + "',Price='" + txtprice.Text + "',Total='" + txtTotal.Text + "',Destination='" + txtdestiny.Text + "' where Item='" + label1.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    binddata1();
                    MessageBox.Show("Record updated succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void materialButton8_Click(object sender, EventArgs e)
        {
            if (txtsearchseedid.Text == "" || txtItem.Text == "")
            {
                MessageBox.Show("The search field is required", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("delete from Harvesting Where Item='" + txtsearchharvest.Text + "'", con);
                    if (MessageBox.Show("Are you sure you want to permanently delete this data", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        binddata1();
                    }
                }
                else
                {
                    MessageBox.Show("Record retained", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void materialButton9_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("select * from Harvesting Where Item='" + txtsearchseedid.Text + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        txtItem.Text = dt.Rows[0][1].ToString();
                        txtquanty.Text = dt.Rows[0][2].ToString();
                        txtprice.Text = dt.Rows[0][3].ToString();
                        txtdestiny.Text = dt.Rows[0][4].ToString();
                        dateharvested.Text = dt.Rows[0][5].ToString();

                    }
                    else
                    {
                        MessageBox.Show("This record does not exist", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
        public void searchharvest()
        {

        }

        private void txtsearchusingitem_TextChanged(object sender, EventArgs e)
        {
            searchharvest();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "view")
            {
                DataGridViewRow dr = new DataGridViewRow();
                dr = dataGridView2.SelectedRows[0];
                txtItem.Text = dr.Cells[0].Value.ToString();
                txtquanty.Text = dr.Cells[1].Value.ToString();
                txtprice.Text = dr.Cells[2].Value.ToString();
                txtTotal.Text = dr.Cells[3].Value.ToString();
                txtdestiny.Text = dr.Cells[4].Value.ToString();
                dateharvested.Text = dr.Cells[5].Value.ToString();

            }
        }

        private void materialButton12_Click(object sender, EventArgs e)
        {
            if (txtsearchsales.Text == "" || txtitems.Text == "")
            {
                {
                    MessageBox.Show("The search field is required", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                try
                {
                    con.Open();
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        SqlCommand cmd = new SqlCommand("update SALES set Item='" + txtitems.Text + "',Quantity='" + txtquantys.Text + "',Price='" + txtprices.Text + "',Total='" + txttotals.Text + "',Destination='" + txtdestinys.Text + "' where Item='" + label1.Text + "'", con);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void materialButton13_Click(object sender, EventArgs e)
        {
            if (txtsearchsales.Text == "" || txtitems.Text == "")
            {
                MessageBox.Show("The search field is required", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                try
                {
                    con.Open();
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        SqlCommand cmd = new SqlCommand("delete from SALES Where Item='" + txtsearchsales.Text + "'", con);
                        if (MessageBox.Show("Are you sure you want to permanently delete this data", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Record Deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            binddata1();
                        }
                        else
                        {
                            MessageBox.Show("Record retained", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        private void materialButton14_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("select  * from SALES Where Item='" + txtsearchsales.Text + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        txtitems.Text = dt.Rows[0][1].ToString();
                        txtquantys.Text = dt.Rows[0][2].ToString();
                        txtprices.Text = dt.Rows[0][3].ToString();
                        txttotals.Text = dt.Rows[0][4].ToString();
                        txtdestinys.Text = dt.Rows[0][5].ToString();
                        Date.Text = dt.Rows[0][6].ToString();

                    }
                    else
                    {
                        MessageBox.Show("This record does not exist", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView3.Columns[e.ColumnIndex].Name == "view")
            {
                DataGridViewRow dr = new DataGridViewRow();
                dr = dataGridView3.SelectedRows[0];
                txtitems.Text = dr.Cells[0].Value.ToString();
                txtquantys.Text = dr.Cells[1].Value.ToString();
                txtprices.Text = dr.Cells[2].Value.ToString();
                txttotals.Text = dr.Cells[3].Value.ToString();
                txtdestinys.Text = dr.Cells[4].Value.ToString();
                datesold.Text = dr.Cells[5].Value.ToString();


            }
        }

        private void materialButton18_Click(object sender, EventArgs e)
        {
            if (txtsearchseedid.Text == "" || txtseedname.Text == "")
            {
                MessageBox.Show("The search field is required", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            { 
                try
                        {
                            con.Open();
                            byte[] images = null;
                            FileStream streem = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                            BinaryReader brs = new BinaryReader(streem);
                            images = brs.ReadBytes((int)streem.Length);
                            if (con.State == System.Data.ConnectionState.Open)
                            {
                                SqlCommand cmd = new SqlCommand("update seedbank set seedid='" + txtseedid.Text + "',Name='" + txtseedname.Text + "',category='" + cmbseedcategory.Text + "',Destination='" + txtDestination.Text + "',Quantity='" + txtquantity.Text + "',Description='" + txtDescription.Text + "',picture=@images where seedid ='" + txtseedid.Text + "'", con);
                                cmd.ExecuteNonQuery();
                                binddata1();
                                MessageBox.Show("Record updated succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);

                        }
                        finally
                        {
                            con.Close();
                        }
                }
            }
        
        private void materialButton19_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("select * from SeedBank Where SeedID='" + txtsearchseedid.Text + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {

                        txtseedid.Text = dt.Rows[0][1].ToString();
                        txtseedname.Text = dt.Rows[0][2].ToString();
                        cmbseedcategory.Text = dt.Rows[0][3].ToString();
                        txtDestination.Text = dt.Rows[0][4].ToString();
                        txtquantity.Text = dt.Rows[0][5].ToString();
                        txtDescription.Text = dt.Rows[0][6].ToString();
                    }
                    else
                    {
                        MessageBox.Show("This record does not exist", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void txtdestinys_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialButton23_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("select * from Housing Where amount ='" + txtsearchroomnumber.Text + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        txtroomnumber.Text = dt.Rows[0][1].ToString();
                        txtgbiackstaff.Text = dt.Rows[0][2].ToString();
                        txtammount.Text = dt.Rows[0][3].ToString();
                        Date.Text = dt.Rows[0][4].ToString();
                    }
                    else
                    {
                        MessageBox.Show("This record does not exist", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void materialButton27_Click(object sender, EventArgs e)
        {
            if (txtsearchmaterial.Text == "" || txtquant.Text == "")
            {
                MessageBox.Show("The search field is required", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    con.Open();
                    if (con.State == System.Data.ConnectionState.Open)
                    {
                        SqlCommand cmd = new SqlCommand("select from Textile Where Material Category='" + txtsearchseedid.Text + "'", con);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            cmbmaterialcategory.Text = dt.Rows[0][2].ToString();
                            txtquant.Text = dt.Rows[0][1].ToString();
                            Date.Text = dt.Rows[0][3].ToString();
                            txtdesignmade.Text = dt.Rows[0][4].ToString();
                            txtdest.Text = dt.Rows[0][5].ToString();
                            txtamount.Text = dt.Rows[0][6].ToString();
                        }
                        else
                        {
                            MessageBox.Show("This record does not exist", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        private void materialButton25_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("update Textile set quantity ='" + txtquant.Text + "',destination='" + txtdest.Text + "',amount='" + txtamount.Text + "' where quantity ='" + txtsearchmaterial.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    binddata1();
                    MessageBox.Show("Record updated succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void materialButton26_Click(object sender, EventArgs e)
        {
            if (txtsearchmaterial.Text == "" || txtquanty.Text == "")
            {
                MessageBox.Show("The search field is required", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                {
                    try
                    {
                        con.Open();
                        if (con.State == System.Data.ConnectionState.Open)
                        {
                            SqlCommand cmd = new SqlCommand("delete from Textile Where quantity='" + txtsearchmaterial.Text + "'", con);
                            if (MessageBox.Show("Are you sure you want to permanently delete this data", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Record Deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                binddata1();
                            }
                            else
                            {
                                MessageBox.Show("Record retained", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }
        private void materialButton21_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("update Housing set   Amount='" + txtammount.Text + "', Date='" + Date.Text + "' where amount ='" + txtsearchroomnumber.Text + "'", con);
                    cmd.ExecuteNonQuery();
                    binddata1();
                    MessageBox.Show("Record updated succesfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void materialButton22_Click(object sender, EventArgs e)
        {
            if (txtsearchroomnumber.Text == "" || txtgbiackstaff.Text == "")
            {
                MessageBox.Show("The search field is required", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                {
                    try
                    {
                        con.Open();
                        if (con.State == System.Data.ConnectionState.Open)
                        {
                            SqlCommand cmd = new SqlCommand("delete from Housing Where amount='" + txtsearchroomnumber.Text + "'", con);
                            if (MessageBox.Show("Are you sure you want to permanently delete this data", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Record Deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                binddata1();
                            }
                            else
                            {
                                MessageBox.Show("Record retained", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }
        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {


                if (dataGridView5.Columns[e.ColumnIndex].Name == "view")
                {
                    DataGridViewRow dr = new DataGridViewRow();
                    dr = dataGridView5.SelectedRows[0];
                    txtroomnumber.Text = dr.Cells[0].Value.ToString();
                    txtgbiackstaff.Text = dr.Cells[1].Value.ToString();
                    txtammount.Text = dr.Cells[2].Value.ToString();
                    Date.Text = dr.Cells[3].Value.ToString();
                    
                }
            }
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {


                if (dataGridView6.Columns[e.ColumnIndex].Name == "view")
                {
                    DataGridViewRow dr = new DataGridViewRow();
                    dr = dataGridView6.SelectedRows[0];
                    cmbmaterialcategory.Text = dr.Cells[0].Value.ToString();
                    txtquantity.Text = dr.Cells[1].Value.ToString();
                    Date.Text = dr.Cells[2].Value.ToString();
                    txtdesignmade.Text = dr.Cells[3].Value.ToString();
                    txtammount.Text = dr.Cells[4].Value.ToString();
                    dateTimePicker13.Text = dr.Cells[5].Value.ToString();
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView7_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView7.Columns[e.ColumnIndex].Name == "view")
            {
                if (dataGridView7.SelectedRows.Count > 0)
                {
                    DataGridViewRow dr = new DataGridViewRow();
                    dr = dataGridView7.SelectedRows[0];
                    txtstudentname.Text = dr.Cells[0].Value.ToString();
                    txtadmissionnumber.Text = dr.Cells[1].Value.ToString();
                    txtcontactnumber.Text = dr.Cells[2].Value.ToString();
                    txtparentname.Text = dr.Cells[3].Value.ToString();
                    txtphonenumber.Text = dr.Cells[4].Value.ToString();
                    txtlocation.Text = dr.Cells[5].Value.ToString();
                }
            }
        }

        private void txtsearchstudent_TextChanged(object sender, EventArgs e)
        {
            Studentsearch();
        }

        private void materialButton31_Click_2(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if(con.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand("Select * from Student where Admission = '" + txtsearchstudent.Text + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        txtadmissionnumber.Text = dt.Rows[0][2].ToString();
                        txtstudentname.Text = dt.Rows[0][1].ToString();
                        txtcontactnumber.Text = dt.Rows[0][3].ToString();
                        txtparentname.Text = dt.Rows[0][4].ToString();
                        txtphonenumber.Text = dt.Rows[0][5].ToString();
                        txtlocation.Text = dt.Rows[0][6].ToString();
                    }
                    else
                    {
                        MessageBox.Show("This record does not exist", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public void searchsales()
        {

        }
        private void txtsearchsales_TextChanged(object sender, EventArgs e)
        {
            searchsales();
        }
        public void searchmaterial()
        {

        }
        private void txtsearchmaterial_TextChanged(object sender, EventArgs e)
        {
            searchmaterial();
        }
        public void saerchroomnumber()
        {

        }
        private void txtsaerchroomnumber_TextChanged(object sender, EventArgs e)
        {
            saerchroomnumber();
        }
    }
}



