using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using RPshipment.form_message;

namespace RPshipment.form_shipment
{
    public partial class FormClient : Form
    {
        private Form currentChildForm;
        public FormClient()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-ICVQ0GL;Initial Catalog=dbShipment;Integrated Security=True");
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
                currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
                panelDesktop.Controls.Add(childForm);
                panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void ShowFormPass_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FormPass());
            //panelClient.Visible = false;
        }
        private void ErrorMessageUserConnection()
        {
            Form Ferrorconn = new FormErrorConnection();
            Ferrorconn.ShowDialog();
        }
        private void FormClient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbSHPclient.Клиент". При необходимости она может быть перемещена или удалена.
            this.клиентTableAdapter.Fill(this.dbSHPclient.Клиент);
            viewClients();
        }
        private void viewClients ()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from Клиент", conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                dgvClient.DataSource = dt;
            }
            catch
            {
                ErrorMessageUserConnection();
            }
            finally
            {
                conn.Close();
            }

        }
        private void ClearAllSection()
        {
            txtlastname.Clear();
            txtfirstname.Clear();
            txtpatroymic.Clear();

            mtxtnumber.Clear();
            txtmail.Clear();
            txtnum.Clear();
        }

        private void iconBtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtlastname.Text != "" && txtfirstname.Text != "" && txtpatroymic.Text != "" && mtxtnumber.Text != "" && txtmail.Text != "" && txtnum.Text != "")
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into [Клиент] values (@фамилия,@имя,@отчество,@телефон,@почта,@ИНН)", conn);
                    cmd.Parameters.AddWithValue("@фамилия", txtlastname.Text);
                    cmd.Parameters.AddWithValue("@имя", txtfirstname.Text);
                    cmd.Parameters.AddWithValue("@отчество", txtpatroymic.Text);
                    cmd.Parameters.AddWithValue("@телефон", mtxtnumber.Text);
                    cmd.Parameters.AddWithValue("@почта", txtmail.Text);
                    cmd.Parameters.AddWithValue("@ИНН", int.Parse(txtnum.Text));
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Ты не всё заполнил...");
                }
            }
            catch
            {
                ErrorMessageUserConnection();
            }
            finally
            {
                conn.Close();
                viewClients();
                ClearAllSection();
            }
        }

        private void iconBtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClient.Rows != null && dgvClient.Rows.Count != 0)
                {
                    if (txtlastname.Text != "" && txtfirstname.Text != "" && txtpatroymic.Text != "" && mtxtnumber.Text != "" && txtmail.Text != "" && txtnum.Text != "")
                    {
                        int ID = Convert.ToInt32(dgvClient.Rows[dgvClient.CurrentCell.RowIndex].Cells[0].Value.ToString());
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("update Клиент set фамилия=@фамилия, имя=@имя, отчество=@отчество, телефон=@телефон, почта=@почта, ИНН=@ИНН where ID=@ID", conn);
                        cmd.Parameters.AddWithValue("@ID", ID);
                        cmd.Parameters.AddWithValue("@фамилия", txtlastname.Text);
                        cmd.Parameters.AddWithValue("@имя", txtfirstname.Text);
                        cmd.Parameters.AddWithValue("@отчество", txtpatroymic.Text);
                        cmd.Parameters.AddWithValue("@телефон", mtxtnumber.Text);
                        cmd.Parameters.AddWithValue("@почта", txtmail.Text);
                        cmd.Parameters.AddWithValue("@ИНН", int.Parse(txtnum.Text));
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        MessageBox.Show("Ты не всё заполнил для обновления...");
                    }
                }
                else
                {
                    MessageBox.Show("Нет ничего на обновление");
                }
            }
            catch
            {
                ErrorMessageUserConnection();
            }
            finally
            {
                conn.Close();
                viewClients();
                ClearAllSection();
            }
        }

        private void iconBtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClient.Rows != null && dgvClient.Rows.Count != 0)
                {
                    int ID = Convert.ToInt32(dgvClient.Rows[dgvClient.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    SqlCommand cmd = new SqlCommand("delete Клиент where ID=@ID", conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Нет ничего на удаление");
                }
            }
            catch
            {
                ErrorMessageUserConnection();
            }
            finally
            {
                conn.Close();
                viewClients();
            }
        }

        private void dgvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtlastname.Text = dgvClient.Rows[dgvClient.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtfirstname.Text = dgvClient.Rows[dgvClient.CurrentCell.RowIndex].Cells[2].Value.ToString();
            txtpatroymic.Text = dgvClient.Rows[dgvClient.CurrentCell.RowIndex].Cells[3].Value.ToString();

            mtxtnumber.Text = dgvClient.Rows[dgvClient.CurrentCell.RowIndex].Cells[4].Value.ToString();
            txtmail.Text = dgvClient.Rows[dgvClient.CurrentCell.RowIndex].Cells[5].Value.ToString();
            txtnum.Text = dgvClient.Rows[dgvClient.CurrentCell.RowIndex].Cells[6].Value.ToString();
        }
    }
}

