namespace SQLITE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtnombre = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btninsertar = new Button();
            btnactualizar = new Button();
            btneliminar = new Button();
            titulo = new Label();
            dataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            ID = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtnombre
            // 
            txtnombre.AutoSize = true;
            txtnombre.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnombre.Location = new Point(37, 72);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(67, 20);
            txtnombre.TabIndex = 0;
            txtnombre.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 130);
            label2.Name = "label2";
            label2.Size = new Size(27, 20);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(111, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(111, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(134, 23);
            textBox2.TabIndex = 3;
            // 
            // btninsertar
            // 
            btninsertar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btninsertar.Location = new Point(145, 188);
            btninsertar.Name = "btninsertar";
            btninsertar.Size = new Size(75, 30);
            btninsertar.TabIndex = 4;
            btninsertar.Text = "Insertar";
            btninsertar.UseVisualStyleBackColor = true;
            btninsertar.Click += btninsertar_Click;
            // 
            // btnactualizar
            // 
            btnactualizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnactualizar.Location = new Point(145, 241);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(75, 28);
            btnactualizar.TabIndex = 5;
            btnactualizar.Text = "Actualizar";
            btnactualizar.UseVisualStyleBackColor = true;
            btnactualizar.Click += btnactualizar_Click;
            // 
            // btneliminar
            // 
            btneliminar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btneliminar.Location = new Point(145, 299);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(75, 28);
            btneliminar.TabIndex = 6;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click;
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titulo.Location = new Point(240, 24);
            titulo.Name = "titulo";
            titulo.Size = new Size(266, 25);
            titulo.TabIndex = 7;
            titulo.Text = "Base de Datos en SQLite";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, ID });
            dataGridView1.Location = new Point(271, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(507, 369);
            dataGridView1.TabIndex = 8;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(titulo);
            Controls.Add(btneliminar);
            Controls.Add(btnactualizar);
            Controls.Add(btninsertar);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(txtnombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtnombre;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btninsertar;
        private Button btnactualizar;
        private Button btneliminar;
        private Label titulo;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn ID;
    }
}
