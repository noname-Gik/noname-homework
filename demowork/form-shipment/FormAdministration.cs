using RPshipment.form_message;
using RPshipment.form_shipment.form_search;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPshipment.form_shipment
{
    public partial class FormAdministration : Form
    {
        //fields
        private Form currentChildForm;
        public FormAdministration()
        {
            InitializeComponent();
        }

        private void panelAdministration_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panelAdministration.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void panelREGWorker_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panelREGWorker.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void panelDoctor_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panelDoctor.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void panelMedHelper_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panelMedHelper.ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }
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
        private void iconBtnAdmin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new allAdministration());
        }

        private void iconBtnMenager_Click(object sender, EventArgs e)
        {
            Form Fcldoor = new FormCloseDoor();
            Fcldoor.ShowDialog();
        }

        private void iconBtnClient_Click(object sender, EventArgs e)
        {
            Form Fcldoor = new FormCloseDoor();
            Fcldoor.ShowDialog();
        }

        private void iconBtnShip_Click(object sender, EventArgs e)
        {
            Form Fcldoor = new FormCloseDoor();
            Fcldoor.ShowDialog();
        }
    }
}
