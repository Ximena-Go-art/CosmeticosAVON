using Service.Enums;
using Service.Models;
using Service.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Views
{
    public partial class UsuariosListaView : Form

    {
        GenericServices<Usuario> _usuarioService = new GenericServices<Usuario>();
        //Usuario _currentUsuario;
        List<Usuario>? _usuarios;
        RolEnum RolEnum = RolEnum.Administrador;
        public UsuariosListaView()
        {
            InitializeComponent();
            _ = GetAllData();
            CheckVerEliminados.CheckedChanged += DisplayHideControslRestoreButton;
        }
        private void DisplayHideControslRestoreButton(object? sender, EventArgs e)
        {
            /*BtnRestaurar.Visible = CheckVerEliminados.Checked;
            TxtBuscar.Enabled = !CheckVerEliminados.Checked;//!Marca la inversa de los datos eliminados
            BtnBuscar.Enabled = !CheckVerEliminados.Checked;
            BtnModificar.Enabled = !CheckVerEliminados.Checked;
            BtnAgregar.Enabled = !CheckVerEliminados.Checked;
            BtnEliminar.Enabled = !CheckVerEliminados.Checked;*/
        }

        private async Task GetAllData()
        {
           /*if (CheckVerEliminados.Checked)
            {
                _usuarios = await _usuarioService.GetAllDeletedsAsync("");
            }
            else
            {
                _usuarios = await _usuarioService.GetAllAsync();
            }
            GridUsuarios.DataSource = _usuarios;
            GridUsuarios.Columns["id"].Visible = false;
            GridUsuarios.Columns["IsDeleted"].Visible = false;*/
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            /*//checheamos que haya peliculas seleccionadas
            if (GridUsuarios.RowCount > 0 && GridUsuarios.SelectedRows.Count > 0)
            {
                Usuario entitySelected = (Usuario)GridUsuarios.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Seguro que desea eliminar al usuario {entitySelected.Nombre}?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)//en lo posible poner dentro de un try/catch
                {
                    if (await _usuarioService.DeleteAsync(entitySelected.id))
                    {
                        LabelStatusMessage.Text = $"Usuario{entitySelected.Nombre} eliminado correctamente";
                        TimerStatusBar.Start(); // Iniciar el temporizador para mostrar el mensaje en la barra de estado
                        await GetAllData();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar al usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario para eliminarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
        private async void CheckVerEliminados_CheckedChanged(object sender, EventArgs e)
        {
            await GetAllData();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
