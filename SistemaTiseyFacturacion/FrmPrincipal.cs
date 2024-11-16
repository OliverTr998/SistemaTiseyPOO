using SistemaTiseyFacturacion.Catalogos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTiseyFacturacion
{
    public partial class FrmPrincipal : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirFormEnPanel(object formhija)
        {
            if (this.pnPrincipal.Controls.Count > 0)
                this.pnPrincipal.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnPrincipal.Controls.Add(fh);
            this.pnPrincipal.Tag = fh;
            fh.Show();

        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnPrincipal.Controls.Add(childForm);
            this.pnPrincipal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //lblTitle.Text = childForm.Text;

        }

        private void mSexo_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmSexo());
        }
    }
}
