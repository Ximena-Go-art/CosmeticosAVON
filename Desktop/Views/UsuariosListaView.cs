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
        //RolEnum RolEnum = RolEnum.Administrador;
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
                GridUsuarios.Columns["Password"].Visible = false;


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
        private async void CheckVerEliminados_CheckedChanged(object sender, EventArgs e)
        {
            await GetAllData();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            LimpiarControlesAgregarEditar();
            //TabControl.SelectedTab = TabPageAgregarEditar;
        }

        private void LimpiarControlesAgregarEditar()
        {
            /*TxtNombre.Clear();
            TxtDetalle.Clear();
            NumericCupo.Value = 0;
            TxtPonente.Clear();
            DateTimeFechaHora.Value = DateTime.Now;
            CheckInscripcionAbierta.Checked = false;*/
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
           // TabControl.SelectedTab = TabPageLista;

        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            /*Capacitacion CapacitacionAGuardar = new Capacitacion
            {
                Id = _currentCapacitacion?.Id ?? 0,
                Nombre = TxtNombre.Text,
                Detalle = TxtDetalle.Text,
                Ponente = TxtPonente.Text,
                FechaHora = DateTimeFechaHora.Value,
                Cupo = (int)NumericCupo.Value,//El int estaria realizando una "conversión de tipo".
                InscripcionAbierta = CheckInscripcionAbierta.Checked
            };*/

            /*bool response = false;
            if (_currentCapacitacion != null)
            {
                response = await _capacitacionService.UpdateAsync(CapacitacionAGuardar);
            }
            else
            {
                var nuevacapacitacion = await _capacitacionService.AddAsync(CapacitacionAGuardar);
                response = nuevacapacitacion != null;
            }
            if (response)
            {
                _currentCapacitacion = null; // Reset the modified movie after saving
                LabelStatusMessage.Text = $"Capacitación {CapacitacionAGuardar.Nombre} guardada correctamente";
                TimerStatusBar.Start(); // Iniciar el temporizador para mostrar el mensaje en la barra de estado
                await GetAllData();
                LimpiarControlesAgregarEditar();
                TabControl.SelectedTab = TabPageLista;
            }
            else
            {
                MessageBox.Show("Error al guardar la capacitacón", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
           /* //checheamos que haya una capacitacion seleccionadas
            if (GridCapacitaciones.RowCount > 0 && GridCapacitaciones.SelectedRows.Count > 0)
            {
                _currentCapacitacion = (Capacitacion)GridCapacitaciones.SelectedRows[0].DataBoundItem;
                TxtNombre.Text = _currentCapacitacion.Nombre;
                NumericCupo.Value = _currentCapacitacion.Cupo;
                TxtDetalle.Text = _currentCapacitacion.Detalle;
                TxtPonente.Text = _currentCapacitacion.Ponente;
                DateTimeFechaHora.Value = _currentCapacitacion.FechaHora;
                CheckInscripcionAbierta.Checked = _currentCapacitacion.InscripcionAbierta;

                TabControl.SelectedTab = TabPageAgregarEditar;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una capacitación para modificarla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            //GridCapacitaciones.DataSource = await _capacitacionService.GetAllAsync(TxtBuscar.Text);
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            // BtnBuscar.PerformClick();// Llamar al evento de búsqueda al cambiar el texto
        }

        private void TimerStatusBar_Tick(object sender, EventArgs e)
        {
            LabelStatusMessage.Text = string.Empty;
            TimerStatusBar.Stop(); // Detener el temporizador después de mostrar el mensaje
        }

        private async void checkVerEliminados_CheckedChanged(object sender, EventArgs e)
        {
            await GetAllData();
        }

        private async void BtnRestaurar_Click(object sender, EventArgs e)

        {
            /*if (!checkVerEliminados.Checked) return;

            if (GridCapacitaciones.RowCount > 0 && GridCapacitaciones.SelectedRows.Count > 0)
            {
                Capacitacion entitySelected = (Capacitacion)GridCapacitaciones.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Seguro que desea restaurar la capacitacion {entitySelected.Nombre}?", "Confirmar Restauración", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)//en lo posible poner dentro de un try/catch
                {
                    if (await _capacitacionService.RestoreAsync(entitySelected.Id))
                    {
                        LabelStatusMessage.Text = $"Capacitación {entitySelected.Nombre} restaurada correctamente";
                        TimerStatusBar.Start(); // Iniciar el temporizador para mostrar el mensaje en la barra de estado
                        await GetAllData();
                    }
                    else
                    {
                        MessageBox.Show("Error al restaurar la capcitación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una capacitación para restaurarla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

        }
    }

}
