using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityModels;
using EntityModels.Catalogos;

namespace SistemaTiseyFacturacion.Catalogos
{
    public partial class FrmSexo : Form
    {
        private bool editar = false;

        public FrmSexo()
        {
            InitializeComponent();
        }

        private void FrmSexo_Load(object sender, EventArgs e)
        {
            dgvSexo.DataSource = GlobalApp.Sexos;
        }

        public void CleanAndRefrech()
        {
            txtCodigoSexo.Text = "";
            txtDescripcionSexo.Text = "";
            editar = false;

            dgvSexo.DataSource = GlobalApp.Sexos.ToList();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            { 
                //Edita un registro de la lista
                if (editar)
                {
                    var sexo = new Sexo();
                    sexo.Codigo = txtCodigoSexo.Text.Trim().ToUpper();
                    sexo.Descripcion = txtDescripcionSexo.Text.Trim();

                    var sexoLista = GlobalApp.Sexos.First(x => x.Codigo == sexo.Codigo);
                    if (sexo != null)
                    {
                        sexoLista.Codigo = sexo.Codigo;
                        sexoLista.Descripcion = sexo.Descripcion;
                        CleanAndRefrech();

                        MessageBox.Show("El registro se Actualizo correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("El registro no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var sexo = new Sexo();
                    sexo.Codigo = txtCodigoSexo.Text.Trim().ToUpper();
                    sexo.Descripcion = txtDescripcionSexo.Text.Trim();

                    var exist = GlobalApp.Sexos.Any(x => x.Codigo == sexo.Codigo);
                    if (exist)
                        MessageBox.Show("Ya existe un sexo con ese codigo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        GlobalApp.Sexos.Add(sexo);
                        CleanAndRefrech();
                        MessageBox.Show("El registro se creo correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSexo.SelectedRows.Count > 0)
                {
                    var codigo = dgvSexo.CurrentRow.Cells["Codigo"].Value.ToString();

                    var sexo = GlobalApp.Sexos.First(x => x.Codigo == codigo);

                    if (sexo != null)
                    {
                        GlobalApp.Sexos.Remove(sexo);
                        CleanAndRefrech();
                        MessageBox.Show("El registro se elimino correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("El registro no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Debe seleccionar una fila de la lista", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSexo.SelectedRows.Count > 0)
                {
                    txtCodigoSexo.Text = dgvSexo.CurrentRow.Cells["Codigo"].Value.ToString();
                    txtDescripcionSexo.Text = dgvSexo.CurrentRow.Cells["Descripcion"].Value.ToString();
                    editar = true;
                }
                else
                    MessageBox.Show("Debe seleccionar una fila de la lista", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CleanAndRefrech();
        }
    }
}
