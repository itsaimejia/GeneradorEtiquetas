namespace GeneradorEtiquetas
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbCollection = new System.Windows.Forms.ComboBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.txtItem = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnGenEtiquetas = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.btnEliminarTodo = new System.Windows.Forms.Button();
			this.btnBorrarItem = new System.Windows.Forms.Button();
			this.lbItems = new System.Windows.Forms.ListBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.label4 = new System.Windows.Forms.Label();
			this.cbPack = new System.Windows.Forms.ComboBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbPack);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cbCollection);
			this.groupBox1.Controls.Add(this.txtPrice);
			this.groupBox1.Controls.Add(this.txtItem);
			this.groupBox1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(28, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(472, 346);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Datos";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(33, 272);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 22);
			this.label3.TabIndex = 5;
			this.label3.Text = "PRECIO:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(62, 132);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 22);
			this.label2.TabIndex = 4;
			this.label2.Text = "ITEM:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(23, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 22);
			this.label1.TabIndex = 3;
			this.label1.Text = "Colección:";
			// 
			// cbCollection
			// 
			this.cbCollection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCollection.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbCollection.FormattingEnabled = true;
			this.cbCollection.Items.AddRange(new object[] {
            "FALL",
            "HOLIDAY",
            "SUMMER",
            "SPRING",
            "WEEDING"});
			this.cbCollection.Location = new System.Drawing.Point(144, 52);
			this.cbCollection.Name = "cbCollection";
			this.cbCollection.Size = new System.Drawing.Size(246, 32);
			this.cbCollection.TabIndex = 0;
			// 
			// txtPrice
			// 
			this.txtPrice.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrice.Location = new System.Drawing.Point(144, 272);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(246, 32);
			this.txtPrice.TabIndex = 3;
			this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
			// 
			// txtItem
			// 
			this.txtItem.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtItem.Location = new System.Drawing.Point(144, 122);
			this.txtItem.Name = "txtItem";
			this.txtItem.Size = new System.Drawing.Size(246, 32);
			this.txtItem.TabIndex = 1;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnGenEtiquetas);
			this.groupBox2.Controls.Add(this.btnGuardar);
			this.groupBox2.Controls.Add(this.btnLimpiar);
			this.groupBox2.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(28, 390);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(747, 83);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Acciones";
			// 
			// btnGenEtiquetas
			// 
			this.btnGenEtiquetas.Enabled = false;
			this.btnGenEtiquetas.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGenEtiquetas.Location = new System.Drawing.Point(613, 21);
			this.btnGenEtiquetas.Name = "btnGenEtiquetas";
			this.btnGenEtiquetas.Size = new System.Drawing.Size(106, 56);
			this.btnGenEtiquetas.TabIndex = 10;
			this.btnGenEtiquetas.TabStop = false;
			this.btnGenEtiquetas.Text = "Generar etiquetas";
			this.btnGenEtiquetas.UseVisualStyleBackColor = true;
			this.btnGenEtiquetas.Click += new System.EventHandler(this.btnGenEtiquetas_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(257, 31);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(106, 34);
			this.btnGuardar.TabIndex = 4;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(117, 31);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(106, 34);
			this.btnLimpiar.TabIndex = 7;
			this.btnLimpiar.TabStop = false;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.btnEliminarTodo);
			this.groupBox4.Controls.Add(this.btnBorrarItem);
			this.groupBox4.Controls.Add(this.lbItems);
			this.groupBox4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.Location = new System.Drawing.Point(527, 12);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(220, 346);
			this.groupBox4.TabIndex = 2;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "ITEMs guardados";
			this.groupBox4.Leave += new System.EventHandler(this.groupBox4_Leave);
			// 
			// btnEliminarTodo
			// 
			this.btnEliminarTodo.Enabled = false;
			this.btnEliminarTodo.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEliminarTodo.Location = new System.Drawing.Point(103, 293);
			this.btnEliminarTodo.Name = "btnEliminarTodo";
			this.btnEliminarTodo.Size = new System.Drawing.Size(98, 53);
			this.btnEliminarTodo.TabIndex = 2;
			this.btnEliminarTodo.TabStop = false;
			this.btnEliminarTodo.Tag = "sdsadasd";
			this.btnEliminarTodo.Text = "Eliminar etiquetas";
			this.btnEliminarTodo.UseVisualStyleBackColor = true;
			this.btnEliminarTodo.Click += new System.EventHandler(this.btnEliminarTodo_Click);
			// 
			// btnBorrarItem
			// 
			this.btnBorrarItem.Enabled = false;
			this.btnBorrarItem.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBorrarItem.Location = new System.Drawing.Point(15, 293);
			this.btnBorrarItem.Name = "btnBorrarItem";
			this.btnBorrarItem.Size = new System.Drawing.Size(82, 53);
			this.btnBorrarItem.TabIndex = 1;
			this.btnBorrarItem.TabStop = false;
			this.btnBorrarItem.Text = "Eliminar item";
			this.btnBorrarItem.UseVisualStyleBackColor = true;
			this.btnBorrarItem.Click += new System.EventHandler(this.btnBorrarItem_Click);
			this.btnBorrarItem.MouseEnter += new System.EventHandler(this.btnBorrarItem_MouseEnter);
			// 
			// lbItems
			// 
			this.lbItems.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbItems.FormattingEnabled = true;
			this.lbItems.ItemHeight = 18;
			this.lbItems.Location = new System.Drawing.Point(15, 31);
			this.lbItems.Name = "lbItems";
			this.lbItems.Size = new System.Drawing.Size(186, 256);
			this.lbItems.TabIndex = 0;
			this.lbItems.TabStop = false;
			this.toolTip1.SetToolTip(this.lbItems, "Da doble click sobre el item para ver sus detalles");
			this.lbItems.UseTabStops = false;
			this.lbItems.SelectedIndexChanged += new System.EventHandler(this.lbItems_SelectedIndexChanged);
			this.lbItems.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbItems_MouseDoubleClick);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(62, 202);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 22);
			this.label4.TabIndex = 7;
			this.label4.Text = "PACK:";
			// 
			// cbPack
			// 
			this.cbPack.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPack.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbPack.FormattingEnabled = true;
			this.cbPack.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "8"});
			this.cbPack.Location = new System.Drawing.Point(144, 192);
			this.cbPack.Name = "cbPack";
			this.cbPack.Size = new System.Drawing.Size(246, 32);
			this.cbPack.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(809, 505);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Generar etiquetas";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cbCollection;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.TextBox txtItem;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnGenEtiquetas;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.ListBox lbItems;
		private System.Windows.Forms.Button btnBorrarItem;
		private System.Windows.Forms.Button btnEliminarTodo;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.ComboBox cbPack;
		private System.Windows.Forms.Label label4;
	}
}

