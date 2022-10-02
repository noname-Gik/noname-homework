using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using RPshipment.form_message;

namespace RPshipment.form_auth
{
    public partial class FormUser : Form
    {
        public FormUser()
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
        public int mistake = 0;
        public static string passtext;
        TimeSpan totalTime;
        private void iconBtnAuth_Click(object sender, EventArgs e)
        {
            try
            {
                string selectUser = "SELECT * FROM [Менеджер по продажам] WHERE почта = '" + txtmail.Text + "' AND пароль = '" + txtpassword.Text + "' AND активность=1;";
                string updateUser = "UPDATE [Менеджер по продажам] set [дата входа]=GETDATE(), [дата сброса пароля]=DATEADD(DAY,15,GETDATE()), [дата блокировка пользователя]=DATEADD(MONTH,1,GETDATE()) where почта = '" + txtmail.Text + "'";
                string findnull = "SELECT * FROM [Менеджер по продажам] where почта = '" + txtmail.Text + "' AND пароль IS null";

                SqlDataAdapter sda = new SqlDataAdapter(selectUser, conn);
                SqlDataAdapter upd = new SqlDataAdapter(updateUser, conn);
                SqlDataAdapter fnd = new SqlDataAdapter(findnull, conn);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows != null && dt.Rows.Count != 0)
                {
                    upd.Fill(dt);
                    Close();
                }
                else
                {
                    //search of null password
                    fnd.Fill(dt);
                    if (dt.Rows != null && dt.Rows.Count != 0)
                    {
                        Form chngERpass = new FormErrorPass();
                        passtext = txtmail.Text;
                        Form chngpass = new FormChngPass();
                        chngERpass.ShowDialog();
                    }
                    else
                    {
                            // add if{ } for message about block account
                            ErrorMessageUser();

                            //score of mistakes 
                            mistake++;
                            if (mistake == 3)
                            {
                                iconBtnAuth.Enabled = false;
                                iconBtnAuth.Text = "Ожидайте";
                                totalTime = new TimeSpan(0, 0, 0, 15);
                                timerTRYagain.Start();
                            }

                            txtmail.Clear();
                            txtpassword.Clear();
                            sda.Fill(dt);
                    }
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
            Application.OpenForms["FormMain"].Close();
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

        private void iconBtnUser_Click(object sender, EventArgs e)
        {
            Form Fcrt = new FormADDUser();
            Fcrt.Owner = this;
            Fcrt.ShowDialog();
        }

        private void timerTRYagain_Tick(object sender, EventArgs e)
        {
            totalTime = totalTime.Subtract(new TimeSpan(0, 0, 0, 1));
            if (totalTime.Seconds == 0)
            {
                mistake = 0;
                iconBtnAuth.Enabled = true;
                iconBtnAuth.Text = "Подвердить";
                timerTRYagain.Stop();
            }
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            try
            {
                string nullUserTime = "UPDATE [Менеджер по продажам] set [пароль]=null where [дата сброса пароля] <= cast(GETDATE() as DATE);";
                string blockUserTime = "UPDATE [Менеджер по продажам] set [активность]=0 where [дата блокировка пользователя] <= cast(GETDATE() as DATE);";
                string delUser = "DELETE [Менеджер по продажам] where [активность]=0;";

                SqlDataAdapter nut = new SqlDataAdapter(nullUserTime, conn);
                SqlDataAdapter but = new SqlDataAdapter(blockUserTime, conn);
                SqlDataAdapter del = new SqlDataAdapter(delUser, conn);

                DataTable dt = new DataTable();
                nut.Fill(dt);
                but.Fill(dt);
                del.Fill(dt);
            }
            catch
            {
                ErrorUserConnection();
            }
            finally
            {
                //sample text ¯\_(ツ)_/¯ - код готов к работе
            }
        }
    }
}
