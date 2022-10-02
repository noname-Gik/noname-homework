using System;
using System.Windows.Forms;

namespace RPshipment.form_shipment
{
    public partial class FormShip : Form
    {
        private Form currentChildForm;
        public FormShip()
        {
            InitializeComponent();
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

        private void iconBtnAdd_Click(object sender, EventArgs e)
        {

        }

        private void iconBtnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Нет ничего на добавление");
        }

        private void iconBtnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Нет ничего на удаление");
        }
    }
}
