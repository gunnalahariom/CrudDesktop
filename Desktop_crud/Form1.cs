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

namespace Desktop_crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        
     
        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=LAPTOP-5TGQ2ND4\\MSSQLSERVER1;Integrated Security=True;database=SAMPLEDB");
            cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
        }   

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtENAME.Text == "") || (txtENO.Text == "") || (txtJOB.Text == "") || (txtSALARY.Text == ""))
            {
                MessageBox.Show("enter the values");
            }
            else

            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    cmd = new SqlCommand("Insert into Employee2 Values (@ENO,@ENAME,@JOB,@SALARY,@STATUS)", con);
                    cmd.Parameters.AddWithValue("@Eno", txtENO.Text);
                    cmd.Parameters.AddWithValue("@ENAME", txtENAME.Text);
                    cmd.Parameters.AddWithValue("@JOB", txtJOB.Text);
                    cmd.Parameters.AddWithValue("@SALARY", txtSALARY.Text);
                    cmd.Parameters.AddWithValue("@STATUS", Convert.ToBoolean(chkStatus.Checked));
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("data insearted successfully");
                    }
                    else
                    {
                        MessageBox.Show("data inseartion failed");
                    }
                    con.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    con.Close();
                    dtgrid.Rows.Clear();
                    txtENAME.Clear();
                    txtJOB.Clear();
                    txtSALARY.Clear();
                    txtENO.Clear();
                    chkStatus.Checked = false;
                }
               
            }

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if ((txtENO.Text == "") || (txtENAME.Text == "") || (txtJOB.Text == "") || (txtSALARY.Text == ""))
            {
                MessageBox.Show("enter the Value to update");
            }
            else 
            {
                try 
                {
                    if (con.State == ConnectionState.Closed)
                    { 
                        con.Open();
                    }
                    cmd = new SqlCommand("UPDATE Employee2 SET Ename=@ENAME, job=@JOB, Salary=@SALARY, Status=@STATUS where Eno=@ENO", con);
                    cmd.Parameters.AddWithValue("@ENO", txtENO.Text);
                    cmd.Parameters.AddWithValue("@ENAME", txtENAME.Text);
                    cmd.Parameters.AddWithValue("@JOB", txtJOB.Text);
                    cmd.Parameters.AddWithValue("@SALARY", txtSALARY.Text);
                    cmd.Parameters.AddWithValue("@STATUS", Convert.ToBoolean(chkStatus.Checked));
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0) 
                    {
                        MessageBox.Show("the vales are updated");
                    }
                    else
                    {
                        MessageBox.Show("the values are not updated");
                    }
                }
                catch (Exception ex)
                { 
                    MessageBox.Show(ex.ToString());
                }
                finally 
                {
                    con.Close();
                    dtgrid.Rows.Clear();
                    txtENAME.Clear();
                    txtJOB.Clear();
                    txtSALARY.Clear();
                    txtENO.Clear();
                    chkStatus.Checked = false;
                }
            }
        }

        private void btnget_Click(object sender, EventArgs e)
        {
            if (txtENO.Text == "")
            {
                MessageBox.Show("enter the ENO");
            }
            else 
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Employee2 WHERE ENO=@ENO", con);
                    cmd.Parameters.AddWithValue("@ENO", txtENO.Text);
                    SqlDataAdapter da= new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        txtENAME.Text = dt.Rows[0]["Ename"].ToString();
                        txtJOB.Text = dt.Rows[0]["job"].ToString();
                        txtSALARY.Text = dt.Rows[0]["Salary"].ToString();
                        chkStatus.Checked = Convert.ToBoolean(dt.Rows[0]["Status"].ToString());
                    }
                    else
                    {
                        MessageBox.Show("the are no records to Display");
                    }
                }
                catch( Exception ex) 
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btnSHOWALL_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * FROM Employee2", con);
                SqlDataAdapter da=new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtgrid.DataSource = dt;
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.ToString());
            }
            finally 
            { 
                con.Close();
            }
        }

        private void dtgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtENO.Text = dtgrid.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtENAME.Text = dtgrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtJOB.Text = dtgrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtSALARY.Text = dtgrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                chkStatus.Checked = Convert.ToBoolean(dtgrid.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void btnCLEAR_Click(object sender, EventArgs e)
        {
            dtgrid.DataSource = null;
            dtgrid.Rows.Clear();
            txtENAME.Clear();
            txtJOB.Clear();
            txtSALARY.Clear();
            txtENO.Clear();
            chkStatus.Checked=false;
        }

        private void btnCLOSE_Click(object sender, EventArgs e)
        {
            this.Close();//Code changes made for close button click
        }
    }
    }

