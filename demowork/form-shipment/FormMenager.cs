using RPshipment.form_message;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPshipment.form_shipment
{
    public partial class FormMenager : Form
    {
        public FormMenager()
        {
            InitializeComponent();
        }
        private void ErrorUserConnection()
        {
            Form Ferrorconn = new FormErrorConnection();
            Ferrorconn.ShowDialog();
        }
        private void ErrorUser()
        {
            Form Ferrorconn = new FormError();
            Ferrorconn.ShowDialog();
        }
        private void viewMenagers()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from [Менеджер по продажам]", conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                dgvMenager.DataSource = dt;
            }
            catch
            {
                ErrorUserConnection();
            }
            finally
            {
                conn.Close();
            }
        }
        private void clearALL()
        {
            txtFm.Clear();
            txtIm.Clear();
            txtOtch.Clear();
            mtxtnum.Clear();
            txtmail.Clear();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-ICVQ0GL;Initial Catalog=dbShipment;Integrated Security=True");
        private void iconBtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFm.Text != "" && txtIm.Text != "" && txtOtch.Text != "" && mtxtnum.Text != "" && txtmail.Text != "")
                {
                    string cmdmen = "insert into [Менеджер по продажам] values ('" + txtFm.Text + "', '" + txtIm.Text + "', '" + txtOtch.Text + "', null, '" + mtxtnum.Text + "', '" + txtmail.Text + "', null, GETDATE(), DATEADD(DAY,15,GETDATE()), DATEADD(MONTH,1,GETDATE()), 1)";
                    SqlDataAdapter cmd = new SqlDataAdapter(cmdmen, conn);
                    DataTable dt = new DataTable();
                    cmd.Fill(dt);
                }
                else
                {
                    ErrorUser();
                }
            }
            catch
            {
                ErrorUserConnection();
            }
            finally
            {
                conn.Close();
                clearALL();
                viewMenagers();
            }
        }

        private void iconBtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMenager.Rows != null && dgvMenager.Rows.Count != 0)
                {
                    if (txtFm.Text != "" && txtIm.Text != "" && txtOtch.Text != "" && mtxtnum.Text != "" && txtmail.Text != "")
                    {
                        int ID = Convert.ToInt32(dgvMenager.Rows[dgvMenager.CurrentCell.RowIndex].Cells[0].Value.ToString());
                        string cmdmen = "update [Менеджер по продажам] set фамилия='" + txtFm.Text + "', имя='" + txtIm.Text + "', отчество='" + txtOtch.Text + "', должность=null, телефон='" + mtxtnum.Text + "', почта='" + txtmail.Text + "', пароль=null, [дата входа]=GETDATE(), [дата сброса пароля]=DATEADD(DAY,15,GETDATE()), [дата блокировка пользователя]=DATEADD(MONTH,1,GETDATE()), активность=1 where ID='" + ID + "'";
                        SqlDataAdapter cmd = new SqlDataAdapter(cmdmen, conn);
                        DataTable dt = new DataTable();
                        cmd.Fill(dt);
                    }
                    else
                    {
                        ErrorUser();
                    }
                }
                else
                {
                    MessageBox.Show("Нет ничего на обновление");
                }
            }
            catch
            {
                ErrorUserConnection();
            }
            finally
            {
                conn.Close();
                clearALL();
                viewMenagers();
            }
        }

        private void iconBtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMenager.Rows != null && dgvMenager.Rows.Count != 0)
                {

                    int ID = Convert.ToInt32(dgvMenager.Rows[dgvMenager.CurrentCell.RowIndex].Cells[0].Value.ToString());
                    SqlCommand cmd = new SqlCommand("delete [Менеджер по продажам] where ID=@ID", conn);
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
                ErrorUserConnection();
            }
            finally
            {
                conn.Close();
                clearALL();
                viewMenagers();
            }
        }

        private void FormMenager_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbSHPmenager.Менеджер_по_продажам". При необходимости она может быть перемещена или удалена.
            this.менеджер_по_продажамTableAdapter.Fill(this.dbSHPmenager.Менеджер_по_продажам);
            viewMenagers();
        }

        private void dgvMenager_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFm.Text = dgvMenager.Rows[dgvMenager.CurrentCell.RowIndex].Cells[1].Value.ToString();
            txtIm.Text = dgvMenager.Rows[dgvMenager.CurrentCell.RowIndex].Cells[2].Value.ToString();
            txtOtch.Text = dgvMenager.Rows[dgvMenager.CurrentCell.RowIndex].Cells[3].Value.ToString();

            mtxtnum.Text = dgvMenager.Rows[dgvMenager.CurrentCell.RowIndex].Cells[5].Value.ToString();
            txtmail.Text = dgvMenager.Rows[dgvMenager.CurrentCell.RowIndex].Cells[6].Value.ToString();
        }
    }
}
