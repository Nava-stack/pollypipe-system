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

namespace PollyPipe
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private SqlConnection con = new SqlConnection(@"Data Source=NAVA;Initial Catalog=Polly_Pipe;Integrated Security=True");
        private void commonLoadGrid()
        {
            string sql = "select * from Customer";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Customer");
            Cus_LoadTable.DataSource = ds.Tables["Customer"].DefaultView;
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            commonLoadGrid();
        }

        private void Cus_SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string id = Cus_IdBox.Text;
                string name = Cus_nameBox.Text;
                string NICno = Cus_NICbox.Text;
                string gender;
                string address = Cus_AdBox.Text;
                string email = Cus_mailBox.Text;
                int tele = int.Parse(Cus_teleBox.Text);
                if (Cus_MaleBtn.Checked)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                if ( id !="" && name !="" && NICno !="")
                {
                    string query_insert = "insert into Customer values('" + id + "','" + name + "','" + gender + "','" + NICno + "','" + address + "','" + tele + "','" + email + "')";
                    SqlCommand cmd = new SqlCommand(query_insert, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    commonLoadGrid();
                    MessageBox.Show("Inserted Record Successfully...!", "Insert Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Please fill the Mandatory details first..!", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }    
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while saving : "+ex );
            }
            finally
            {
                con.Close();
            }
           // ClearFunction();
        }

        private void Cus_CanBtn_Click(object sender, EventArgs e)
        {
            var BackForm = new Company_Details();
            this.Hide();
            BackForm.Show();
        }

        private void Cus_UpdateBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Update", "Update Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
               
                try
                {
                    string name = Cus_nameBox.Text;
                    string NICno = Cus_NICbox.Text;
                    string gender;
                    string address = Cus_AdBox.Text;
                    string email = Cus_mailBox.Text;
                    int tele = int.Parse(Cus_teleBox.Text);
                    if (Cus_MaleBtn.Checked)
                    {
                        gender = "Male";
                    }
                    else
                    {
                        gender = "Female";
                    }
                    string query_update = "Update Customer set C_Name='" + name + "',C_Gender='" + gender + "',C_Address='" + address + "',C_Phone='" + tele + "',C_Mail='" + email + "' where C_ICno='" + NICno + "'";
                    SqlCommand cmd = new SqlCommand(query_update, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    commonLoadGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while updating : " + ex);
                }
                finally
                {
                    con.Close();
                }
                ClearFunction();
            }          
        }

        private void Cus_DeleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Delete?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    string id = Cus_IdBox.Text;
                    string name = Cus_nameBox.Text;
                    string NICno = Cus_NICbox.Text;
                    string gender;
                    string address = Cus_AdBox.Text;
                    string email = Cus_mailBox.Text;
                    int tele = int.Parse(Cus_teleBox.Text);

                    if (Cus_MaleBtn.Checked)
                    {
                        gender = "Male";
                    }
                    else
                    {
                        gender = "Female";
                    }

                    string query_delete = "delete from Customer where C_ICno='" + NICno + "'";
                    SqlCommand cmd = new SqlCommand(query_delete, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    commonLoadGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while deleting : " + ex);
                }
                finally
                {
                    con.Close();
                    MessageBox.Show("Deleted Record Successfully...!", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                ClearFunction();
            }           
        }

        private void Cus_SearchBtn_Click(object sender, EventArgs e)
        {
            //Cus_IdBox.Enabled = false;
            //Cus_NICbox.Enabled = false;
            try 
            {
                string Cus_ID_Search = Cus_IDsearchBox.Text;
                string Cus_Mail_Search = Cus_mailSearchBox.Text;
                string Cus_NICno_Search = Cus_NICsearchBox.Text;

                string query_search = "select * from Customer where CustomerID='" + Cus_ID_Search + "' or C_Mail='" + Cus_Mail_Search + "' or C_ICno='" + Cus_NICno_Search + "'";
                SqlCommand cmd = new SqlCommand(query_search, con);
                con.Open();
                SqlDataReader re = cmd.ExecuteReader();
                while (re.Read())
                {
                    Cus_IdBox.Text = re[0].ToString();
                    Cus_nameBox.Text = re[1].ToString();
                    string gender = re[2].ToString();
                    if (gender == "Male")
                    {
                        Cus_MaleBtn.Checked = true;
                    }
                    else
                    {
                        Cus_FemaleBtn.Checked = true;
                    }
                    Cus_NICbox.Text = re[3].ToString();
                    Cus_AdBox.Text = re[4].ToString();
                    Cus_teleBox.Text = re[5].ToString();
                    Cus_mailBox.Text = re[6].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while searching : " +ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void ClearFunction()
        {
            Cus_IdBox.Clear();
            Cus_nameBox.Clear();
            Cus_NICbox.Clear();
            Cus_FemaleBtn.Checked = false;
            Cus_MaleBtn.Checked = false;
            Cus_AdBox.Clear();
            Cus_teleBox.Clear();
            Cus_mailBox.Clear();
        }
        private void Cus_ClearTextBtn_Click(object sender, EventArgs e)
        {
            ClearFunction();
        }

        private void Cus_ClearSearchBtn_Click(object sender, EventArgs e)
        {
            Cus_IDsearchBox.Clear();
            Cus_mailSearchBox.Clear();
            Cus_NICsearchBox.Clear();
        }
    }



}
