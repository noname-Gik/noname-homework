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

namespace RPshipment.form_auth
{
    public partial class FormChngPass : Form
    {
        public FormChngPass()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ErrorUserConnection()
        {
            Form Ferrorconn = new FormErrorConnection();
            Ferrorconn.ShowDialog();
        }
        private void FormChngPass_Load(object sender, EventArgs e)
        {
            txtmail.Text = FormUser.passtext;
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-ICVQ0GL;Initial Catalog=dbShipment;Integrated Security=True");
        private void iconBtnAuth_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtpassword.Text != "")
                {
                    string updateUser = "UPDATE [Менеджер по продажам] set [пароль]='"+txtpassword.Text+"' where почта = '" + txtmail.Text + "'";
                    string updateUserTime = "UPDATE [Менеджер по продажам] set [дата входа]=GETDATE(), [дата сброса пароля]=DATEADD(DAY,15,GETDATE()), [дата блокировка пользователя]=DATEADD(MONTH,1,GETDATE()) where почта = '" + txtmail.Text + "'";

                    SqlDataAdapter upd = new SqlDataAdapter(updateUser, conn);
                    SqlDataAdapter updt = new SqlDataAdapter(updateUserTime, conn);
                    DataTable dt = new DataTable();
                    upd.Fill(dt);
                    updt.Fill(dt);

                    Application.OpenForms["FormErrorPass"].Close();
                    Application.OpenForms["FormUser"].Close();
                    Close();
                }
                else
                {
                    MessageBox.Show("Придумайте пароль");
                }
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
    }
}
