namespace SimuladorProcesos
{
    partial class MainForm
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
            this.dataGridViewProcesos = new System.Windows.Forms.DataGridView();
            this.buttonEjecutar = new System.Windows.Forms.Button();
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.stripMAcerca = new System.Windows.Forms.ToolStripMenuItem();
            this.refernciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMCreditos = new System.Windows.Forms.ToolStripMenuItem();
            this.materiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblQuantum = new System.Windows.Forms.Label();
            this.lblValueQuantum = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.id = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcesos)).BeginInit();
            this.mnsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProcesos
            // 
            this.dataGridViewProcesos.AllowUserToAddRows = false;
            this.dataGridViewProcesos.AllowUserToDeleteRows = false;
            this.dataGridViewProcesos.AllowUserToResizeColumns = false;
            this.dataGridViewProcesos.AllowUserToResizeRows = false;
            this.dataGridViewProcesos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewProcesos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProcesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcesos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.estado,
            this.tiempo,
            this.Column1});
            this.dataGridViewProcesos.Location = new System.Drawing.Point(25, 36);
            this.dataGridViewProcesos.MultiSelect = false;
            this.dataGridViewProcesos.Name = "dataGridViewProcesos";
            this.dataGridViewProcesos.ReadOnly = true;
            this.dataGridViewProcesos.RowHeadersVisible = false;
            this.dataGridViewProcesos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewProcesos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProcesos.Size = new System.Drawing.Size(454, 230);
            this.dataGridViewProcesos.TabIndex = 0;
            // 
            // buttonEjecutar
            // 
            this.buttonEjecutar.BackColor = System.Drawing.SystemColors.Control;
            this.buttonEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEjecutar.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEjecutar.Location = new System.Drawing.Point(34, 182);
            this.buttonEjecutar.Name = "buttonEjecutar";
            this.buttonEjecutar.Size = new System.Drawing.Size(116, 30);
            this.buttonEjecutar.TabIndex = 1;
            this.buttonEjecutar.Text = "Ejecutar";
            this.buttonEjecutar.UseVisualStyleBackColor = false;
            this.buttonEjecutar.Click += new System.EventHandler(this.buttonCorrer_Click);
            // 
            // mnsMain
            // 
            this.mnsMain.BackColor = System.Drawing.SystemColors.Control;
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripMAcerca,
            this.stripMCreditos});
            this.mnsMain.Location = new System.Drawing.Point(0, 0);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Size = new System.Drawing.Size(717, 24);
            this.mnsMain.TabIndex = 4;
            this.mnsMain.Text = "menuStrip1";
            // 
            // stripMAcerca
            // 
            this.stripMAcerca.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refernciaToolStripMenuItem,
            this.reseñaToolStripMenuItem});
            this.stripMAcerca.Name = "stripMAcerca";
            this.stripMAcerca.Size = new System.Drawing.Size(72, 20);
            this.stripMAcerca.Text = "Acerda de";
            // 
            // refernciaToolStripMenuItem
            // 
            this.refernciaToolStripMenuItem.Name = "refernciaToolStripMenuItem";
            this.refernciaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.refernciaToolStripMenuItem.Text = "Referencia";
            this.refernciaToolStripMenuItem.Click += new System.EventHandler(this.refernciaToolStripMenuItem_Click);
            // 
            // reseñaToolStripMenuItem
            // 
            this.reseñaToolStripMenuItem.Name = "reseñaToolStripMenuItem";
            this.reseñaToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.reseñaToolStripMenuItem.Text = "Reseña";
            this.reseñaToolStripMenuItem.Click += new System.EventHandler(this.reseñaToolStripMenuItem_Click);
            // 
            // stripMCreditos
            // 
            this.stripMCreditos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materiaToolStripMenuItem});
            this.stripMCreditos.Name = "stripMCreditos";
            this.stripMCreditos.Size = new System.Drawing.Size(63, 20);
            this.stripMCreditos.Text = "Creditos";
            // 
            // materiaToolStripMenuItem
            // 
            this.materiaToolStripMenuItem.Name = "materiaToolStripMenuItem";
            this.materiaToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.materiaToolStripMenuItem.Text = "Materia";
            this.materiaToolStripMenuItem.Click += new System.EventHandler(this.materiaToolStripMenuItem_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(21, 53);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(153, 45);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblQuantum
            // 
            this.lblQuantum.AutoSize = true;
            this.lblQuantum.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantum.Location = new System.Drawing.Point(31, 34);
            this.lblQuantum.Name = "lblQuantum";
            this.lblQuantum.Size = new System.Drawing.Size(68, 17);
            this.lblQuantum.TabIndex = 6;
            this.lblQuantum.Text = "Quantum :";
            // 
            // lblValueQuantum
            // 
            this.lblValueQuantum.AutoSize = true;
            this.lblValueQuantum.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueQuantum.Location = new System.Drawing.Point(105, 33);
            this.lblValueQuantum.Name = "lblValueQuantum";
            this.lblValueQuantum.Size = new System.Drawing.Size(18, 23);
            this.lblValueQuantum.TabIndex = 7;
            this.lblValueQuantum.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.lblValueQuantum);
            this.groupBox1.Controls.Add(this.buttonEjecutar);
            this.groupBox1.Controls.Add(this.lblQuantum);
            this.groupBox1.Location = new System.Drawing.Point(522, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 233);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Width = 60;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nombre.Width = 150;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.estado.Width = 80;
            // 
            // tiempo
            // 
            this.tiempo.HeaderText = "Tiempo";
            this.tiempo.Name = "tiempo";
            this.tiempo.ReadOnly = true;
            this.tiempo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tiempo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tiempo.Width = 50;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Prioridad";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column1.Width = 110;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(717, 297);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mnsMain);
            this.Controls.Add(this.dataGridViewProcesos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Round Robin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcesos)).EndInit();
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProcesos;
        private System.Windows.Forms.Button buttonEjecutar;
        private System.Windows.Forms.MenuStrip mnsMain;
        private System.Windows.Forms.ToolStripMenuItem stripMAcerca;
        private System.Windows.Forms.ToolStripMenuItem refernciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stripMCreditos;
        private System.Windows.Forms.ToolStripMenuItem materiaToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lblQuantum;
        private System.Windows.Forms.Label lblValueQuantum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewButtonColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

