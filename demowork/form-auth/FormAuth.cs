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
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-ICVQ0GL;Initial Catalog=dbShipment;Integrated Security=True");
        private void iconBtnAuth_Click(object sender, EventArgs e)
        {
            try 
            {
                string selectUser = "SELECT * FROM Администрация WHERE ID = 1 AND login = '" + txtlogin.Text + "' AND password = '" + txtpassword.Text + "';";
                SqlDataAdapter sda = new SqlDataAdapter(selectUser, conn);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    (this.Owner as FormMain).iconButton1.Visible = true;
                    Close();
                }
                else
                {
                    Form Ferror = new FormError();
                    Ferror.ShowDialog();

                    txtlogin.Clear();
                    txtpassword.Clear();
                }
            }
            catch 
            {
                Form Ferrorconn = new FormErrorConnection();
                Ferrorconn.ShowDialog();
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
