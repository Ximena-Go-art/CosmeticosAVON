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
        Usuario _currentUsuario;
        List<Usuario>? _usuarios;
        public UsuariosListaView()
        {
            InitializeComponent();
            _ = GetAllData();
            CheckVerEliminados.CheckedChanged += DisplayHideControslRestoreButton;
            CargarRoles();
        }
        private void DisplayHideControslRestoreButton(object? sender, EventArgs e)
        {
            BtnRestaurar.Visible = CheckVerEliminados.Checked;
            TxtBuscar.Enabled = !CheckVerEliminados.Checked;//!Marca la inversa de los datos eliminados
            BtnBuscar.Enabled = !CheckVerEliminados.Checked;
            BtnModificar.Enabled = !CheckVerEliminados.Checked;
            BtnAgregar.Enabled = !CheckVerEliminados.Checked;
            BtnEliminar.Enabled = !CheckVerEliminados.Checked;
        }
        private void CargarRoles()
        {
            CbRol.DataSource = Enum.GetValues(typeof(RolEnum));//cargamos los roles a la combobox
        }
        private async Task GetAllData()
        {
            if (CheckVerEliminados.Checked)
            {
                _usuarios = await _usuarioService.GetAllDeletedsAsync("");
            }
            else
            {

                _usuarios = await _usuarioService.GetAllAsync();
            }
            GridUsuarios.DataSource = _usuarios;
            GridUsuarios.Columns["id"].Visible = false;
            GridUsuarios.Columns["IsDeleted"].Visible = false;

        }
        private void GridUsuario_SelectionChanged_1(object sender, EventArgs e)
        {
            if (GridUsuarios.RowCount > 0 && GridUsuarios.SelectedRows.Count > 0)
            {
                //Capacitacion capacitacionSeleccionada = (Capacitacion)GridCapacitaciones.SelectedRows[0].DataBoundItem;
                //FilmPicture.ImageLocation = peliSeleccionada.portada;
            }
        }
        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            //checheamos que haya peliculas seleccionadas
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
            }
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LimpiarControlesAgregarEditar()
        {
            TxtNombre.Clear();
            TxtEmail.Clear();
            TxtPassword.Clear();
            CbRol.SelectedIndex = 0;
        }
        private void TimerStatusBar_Tick(object sender, EventArgs e)
        {
            LabelStatusMessage.Text = string.Empty;
            TimerStatusBar.Stop(); // Detener el temporizador después de mostrar el mensaje
        }
        private async void BtnRestaurar_Click(object sender, EventArgs e)
        {

            if (!CheckVerEliminados.Checked) return;

            if (GridUsuarios.RowCount > 0 && GridUsuarios.SelectedRows.Count > 0) //que haya algo seleccionado
            {
                Usuario entitySelected = (Usuario)GridUsuarios.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Seguro que desea restaurar el usuario {entitySelected.Nombre}?", "Confirmar Restauración", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)//en lo posible poner dentro de un try/catch
                {
                    if (await _usuarioService.RestoreAsync(entitySelected.id))
                    {
                        LabelStatusMessage.Text = $"Usuario {entitySelected.Nombre} restaurado correctamente";
                        TimerStatusBar.Start(); // Iniciar el temporizador para mostrar el mensaje en la barra de estado
                        await GetAllData();
                    }
                    else
                    {
                        MessageBox.Show("Error al restaurar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una capacitación para restaurarla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async void CheckVerEliminados_CheckedChanged_1(object sender, EventArgs e)
        {
            await GetAllData();
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            LimpiarControlesAgregarEditar();
            TabControl.SelectedTab = AgregarEditarUsuarios;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //checheamos que haya una capacitacion seleccionadas
            if (GridUsuarios.RowCount > 0 && GridUsuarios.SelectedRows.Count > 0)
            {
                _currentUsuario = (Usuario)GridUsuarios.SelectedRows[0].DataBoundItem;
                TxtNombre.Text = _currentUsuario.Nombre;
                TxtEmail.Text = _currentUsuario.Email;
                TxtPassword.Text = _currentUsuario.Password;
                CbRol.SelectedItem = _currentUsuario.Rol;// selecciona el rol actual del usuario

                TabControl.SelectedTab = AgregarEditarUsuarios;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una usuario para modificarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            Usuario UsuarioAGuardar = new Usuario
            {
                id = _currentUsuario?.id ?? 0,
                Nombre = TxtNombre.Text,
                Email = TxtEmail.Text,
                Password = TxtPassword.Text,
                Rol = (RolEnum)CbRol.SelectedItem// Convertir el rol seleccionado al tipo RolEnum
            };

            bool response = false;
            if (_currentUsuario != null)
            {
                response = await _usuarioService.UpdateAsync(UsuarioAGuardar);
            }
            else
            {
                var nuevousuario = await _usuarioService.AddAsync(UsuarioAGuardar);
                response = nuevousuario != null;
            }
            if (response)
            {
                _currentUsuario = null; // Reset the modified movie after saving
                LabelStatusMessage.Text = $"Usuario {UsuarioAGuardar.Nombre} guardada correctamente";
                TimerStatusBar.Start(); // Iniciar el temporizador para mostrar el mensaje en la barra de estado
                await GetAllData();
                LimpiarControlesAgregarEditar();
                TabControl.SelectedTab = ListaUsuariosPage;
            }
            else
            {
                MessageBox.Show("Error al guardar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = ListaUsuariosPage;
            LimpiarControlesAgregarEditar();
        }

        private async void BtnBuscar_Click(object sender, EventArgs e) //No funciona
        {
            string filtro = TxtBuscar.Text.Trim();//elimina los espacios de la palabra

            // Intentar parsear el filtro como un RolEnum
            if (Enum.TryParse<RolEnum>(filtro, true, out var rolBuscado))
            //combierte el texto a enum y lo almacena en rolBuscado.
            {
                // Obtener todos los usuarios y filtrar por rol
                var usuarios = await _usuarioService.GetAllAsync();
                
                GridUsuarios.DataSource = usuarios?.Where(u => u.Rol == rolBuscado).ToList();
            }
            else
            {
                // Búsqueda normal por nombre/email
                GridUsuarios.DataSource = await _usuarioService.GetAllAsync(filtro);
            }
        }
    }
    
}
