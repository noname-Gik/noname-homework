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
using System.Runtime.InteropServices;
using RPshipment.form_message;

namespace RPshipment.form_auth
{
    public partial class FormADDUser : Form
    {
        public FormADDUser()
        {
            InitializeComponent();
        }
        private void ErrorUserConnection()
        {
            Form Ferrorconn = new FormErrorConnection();
            Ferrorconn.ShowDialog();
        }
        private void ErrorMessageUser()
        {
            Form Ferror = new FormError();
            Ferror.ShowDialog();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-ICVQ0GL;Initial Catalog=dbShipment;Integrated Security=True");
        private void iconBtnAuth_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFm.Text != "" && txtIm.Text != "" && txtOtch.Text != "" && mtxtnumber.Text != "" && txtmail.Text != "" && txtpassword.Text != "")
                {
                    string selectUser = "SELECT * FROM [Менеджер по продажам] WHERE (фамилия = '" + txtFm.Text + "' AND имя = '" + txtIm.Text + "' AND отчество = '" + txtOtch.Text + "') OR телефон = '" + mtxtnumber.Text + "' OR почта = '" + txtmail.Text + "';";
                    SqlDataAdapter sda = new SqlDataAdapter(selectUser, conn);

                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows != null && dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Такой пользователь уже есть");
                    }
                    else
                    {
                        conn.Open();
                        SqlDataAdapter cmd = new SqlDataAdapter("insert into [Менеджер по продажам] values ('"+txtFm.Text+"', '"+ txtIm.Text + "', '"+ txtOtch.Text + "', null, '"+ mtxtnumber.Text + "', '"+ txtmail.Text + "', '"+ txtpassword.Text + "', GETDATE(), DATEADD(DAY,15,GETDATE()), DATEADD(MONTH,1,GETDATE()), 1)", conn);                                     
                        cmd.Fill(dt);

                        MessageBox.Show("Добавлен новый пользователь");
                        Application.OpenForms["FormUser"].Close();
                        Close();
                    }
                }
                else
                {
                    ErrorMessageUser();

                    txtmail.Clear();
                    txtpassword.Clear();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        //drag form - порт для перемещения программы по столу.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelAuthorization_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panelAuthorization.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
    }
}
