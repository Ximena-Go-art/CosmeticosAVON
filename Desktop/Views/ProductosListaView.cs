
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
    public partial class ProductosListaView : Form

    {
        GenericServices<Producto> _productoService = new GenericServices<Producto>();
        Producto? _currentProducto;
        List<Producto>? _productos;

        GenericServices<Categoria> _categoriaService = new GenericServices<Categoria>();
        Categoria? _currentCategoria;
        List<Categoria>? _categoria;

        public ProductosListaView()
        {
            InitializeComponent();
            _ = GetAllData();
            CheckVerEliminados.CheckedChanged += DisplayHideControslRestoreButton;
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
        private async Task GetAllData() 
        {
            if (CheckVerEliminados.Checked)
            {
                _productos = await _productoService.GetAllDeletedsAsync("") ?? new List<Producto>();
                _categoria = await _categoriaService.GetAllDeletedsAsync("")?? new List<Categoria>();
            }
            else
            {

                _productos = await _productoService.GetAllAsync()?? new List<Producto>();
                _categoria = await _categoriaService.GetAllAsync() ?? new List<Categoria>();
            }
            ActualizarGridView();
            GridProductos.Columns["Nombre"].Visible = true;
            GridProductos.Columns["Categoria"].Visible = true;
            GridProductos.Columns["Precio"].Visible = true;
            GridProductos.Columns["Stock"].Visible = true;

        }
        private void ActualizarGridView()
        {
            var datosAMostrar = _productos?.Select(p => new
            {
                p.Id,
                p.Nombre,
                Categoria = p.Categoria?.Nombre,
                p.Precio,
                p.Stock
            }).ToList();
            GridProductos.DataSource = datosAMostrar;


        }
        private void GridProductos_SelectionChanged_1(object sender, EventArgs e)
        {
            if (GridProductos.RowCount > 0 && GridProductos.SelectedRows.Count > 0)
            {
                //Capacitacion capacitacionSeleccionada = (Capacitacion)GridCapacitaciones.SelectedRows[0].DataBoundItem;
                //FilmPicture.ImageLocation = peliSeleccionada.portada;
            }
        }
        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            //checheamos que haya peliculas seleccionadas
            if (GridProductos.RowCount > 0 && GridProductos.SelectedRows.Count > 0)
            {
                Producto entitySelected = (Producto)GridProductos.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Seguro que desea eliminar el producto {entitySelected.Nombre}?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)//en lo posible poner dentro de un try/catch
                {
                    if (await _productoService.DeleteAsync(entitySelected.Id))
                    {
                        LabelStatusMessage.Text = $"Producto{entitySelected.Nombre} eliminado correctamente";
                        TimerStatusBar.Start(); // Iniciar el temporizador para mostrar el mensaje en la barra de estado
                        await GetAllData();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            CbCategorias.AccessibleName = null;
            NumPrecio.Value = 0;
            NumStock.Value = 0;
            
        }
        private void TimerStatusBar_Tick(object sender, EventArgs e)
        {
            LabelStatusMessage.Text = string.Empty;
            TimerStatusBar.Stop(); // Detener el temporizador después de mostrar el mensaje
        }
        private async void BtnRestaurar_Click(object sender, EventArgs e)
        {

            if (!CheckVerEliminados.Checked) return;

            if (GridProductos.RowCount > 0 && GridProductos.SelectedRows.Count > 0) //que haya algo seleccionado
            {
                Producto entitySelected = (Producto)GridProductos.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Seguro que desea restaurar el producto {entitySelected.Nombre}?", "Confirmar Restauración", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)//en lo posible poner dentro de un try/catch
                {
                    if (await _productoService.RestoreAsync(entitySelected.Id))
                    {
                        LabelStatusMessage.Text = $"Producto {entitySelected.Nombre} restaurado correctamente";
                        TimerStatusBar.Start(); // Iniciar el temporizador para mostrar el mensaje en la barra de estado
                        await GetAllData();
                    }
                    else
                    {
                        MessageBox.Show("Error al restaurar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (GridProductos.RowCount > 0 && GridProductos.SelectedRows.Count > 0)
            {
                if ((Producto)GridProductos.SelectedRows[0].DataBoundItem)
                {
                    _currentProducto = _productos.FirstOrDefault(p => p.Id == IdProducto);
                    TxtNombre.Text = _currentProducto.Nombre;
                    CbCategorias.SelectedItem = _currentCategoria.Nombre;
                    NumPrecio.Value = _currentProducto.Precio;
                    NumStock.Value = _currentProducto.Stock;
                }
                // selecciona el rol actual del usuario

                TabControl.SelectedTab = AgregarEditarUsuarios;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una usuario para modificarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            Producto ProductoAGuardar = new Producto
            {
                Id = _currentProducto?.Id ?? 0,
                Nombre = TxtNombre.Text,
                Categoria = CbCategorias.SelectedItem as Categoria,
                Precio = NumPrecio.Value,//Ya es decimal
                Stock = (int)NumStock.Value,//Decimal a int para el stock

            };

            bool response = false;
            if (_currentProducto != null)
            {
                response = await _productoService.UpdateAsync(ProductoAGuardar);
            }
            else
            {
                var nuevousuario = await _productoService.AddAsync(ProductoAGuardar);
                response = nuevousuario != null;
            }
            if (response)
            {
                _currentProducto = null; // Reset the modified movie after saving
                LabelStatusMessage.Text = $"Producto {ProductoAGuardar.Nombre} guardado correctamente";
                TimerStatusBar.Start(); // Iniciar el temporizador para mostrar el mensaje en la barra de estado
                await GetAllData();
                LimpiarControlesAgregarEditar();
                TabControl.SelectedTab = ListaUsuariosPage;
            }
            else
            {
                MessageBox.Show("Error al guardar el Producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TabControl.SelectedTab = ListaUsuariosPage;
            LimpiarControlesAgregarEditar();
        }

        private async void BtnBuscar_Click(object sender, EventArgs e) //No funciona
        {
            GridProductos.DataSource = await _productoService.GetAllAsync();
        }
    }
    
}
