﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneradorEtiquetas
{
	public partial class Form1 : Form
	{
		Generador Generador = new Generador();
		public Form1()
		{
			InitializeComponent();
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{
		}


		#region Eventos Click
		private void btnGuardar_Click(object sender, EventArgs e)
		{
			Guardar();
			
			
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			Limpiar();
		}

		private void btnBorrarItem_Click(object sender, EventArgs e)
		{
			
			if (lbItems.SelectedIndex != -1)
			{
				DialogResult result = MessageBox.Show("¿Quieres eliminar este item?", "Alerta", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
				if (result == DialogResult.Yes)
				{
					string ItemSel = lbItems.SelectedItem.ToString();
					lbItems.Items.Remove(ItemSel);
					Generador.Eliminar(ItemSel);
					MessageBox.Show("Ha sido borrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
					lbItems.SelectedIndex = -1;
					btnBorrarItem.Enabled = false;
				}
			}
			else
			{
				btnBorrarItem.Enabled = false;
			}
		}
		private void btnBorrarItem_MouseEnter(object sender, EventArgs e)
		{
			if (lbItems.Items.Count <= 0)
			{
				btnBorrarItem.Enabled = false;
			}
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Estás a punto de salir\n¿Deseas continuar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (result == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void btnGenEtiquetas_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("\tHas presionado generar etiquetas\n\t¿Deseas continuar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
			if (result == DialogResult.Yes)
			{
				Generador.EtiquetaPrecio();
				Generador.EtiquetaColeccion();
			}
		}
		#endregion

		#region Otros eventos
		private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
		{

			if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != 46) && (e.KeyChar != (char)Keys.Enter))
			{
				txtPrice.Text = string.Empty;
				e.Handled = true;
				return;
			}
			else
			if (e.KeyChar == (char)Keys.Enter)
			{
				Guardar();
			}
		}

		private void lbItems_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnBorrarItem.Enabled = true;
		}

		private void groupBox4_Leave(object sender, EventArgs e)
		{
			btnBorrarItem.Enabled = false;
			lbItems.SelectedIndex = -1;
		} 
		#endregion

		#region Metodos
		#region Guardar
		private void Guardar()
		{
			if (cbCollection.SelectedIndex.Equals(-1))
			{
				MessageBox.Show("Selecciona una colección");
				cbCollection.Focus();
			}
			else
			if (string.IsNullOrEmpty(txtItem.Text))
			{
				MessageBox.Show("Ingresa el ITEM");
				txtItem.Focus();
			}
			else
			if (cbPack.SelectedIndex.Equals(-1))
			{
				MessageBox.Show("Selecciona un paquete");
				cbPack.Focus();
			}
			else
			
			if (string.IsNullOrEmpty(txtPrice.Text))
			{
				MessageBox.Show("Ingresa el precio");
				txtPrice.Focus();
			}
			else
			{
				var itemTemp = txtItem.Text.ToUpper();
				Modelo NuevoItem = new Modelo
				{
					Collection = cbCollection.Text,
					Item = itemTemp,
					Pack = cbPack.Text,
					Price = double.Parse(txtPrice.Text)
				};
				Generador.ITEMS.Add(NuevoItem);
				lbItems.Items.Add(itemTemp);
				MessageBox.Show("Item guardado");
				btnEliminarTodo.Enabled = true;
				btnGenEtiquetas.Enabled = true;
				cbCollection.Focus();
				Limpiar();
			}
		}
		#endregion

		#region Limpiar
		public void Limpiar()
		{
			txtItem.Text = string.Empty;
			txtPrice.Text = string.Empty;
			cbCollection.SelectedIndex = -1;
			cbPack.SelectedIndex = -1;

		}



		#endregion

		#endregion

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult result = MessageBox.Show("¿Deseas salir?", "Alerta", MessageBoxButtons.YesNo);
			if (result == DialogResult.No)
			{
				e.Cancel = true;
			}
		}

		private void lbItems_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			string ItemSel = lbItems.SelectedItem.ToString();
			Modelo modelo = Generador.DetalleModelo(ItemSel);
			string descripcion = $"Colección: {modelo.Collection}\nITEM: {modelo.Item}\nPack: {modelo.Pack}\nPrecio: {modelo.Price}";
			MessageBox.Show(descripcion, "Detalles");
		}

		private void btnEliminarTodo_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("¿Quieres eliminar todo?", "¡Quieto ahí!", MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
				Generador.ElimiarITEMS();
				lbItems.Items.Clear();
				btnEliminarTodo.Enabled = false;
				btnGenEtiquetas.Enabled = false;
			}
		}
	}
}
