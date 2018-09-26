namespace proyecto1SO
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btConfig = new System.Windows.Forms.Button();
            this.listPids = new System.Windows.Forms.ListBox();
            this.lbPids = new System.Windows.Forms.Label();
            this.pninteractivo = new System.Windows.Forms.Panel();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.cNuProc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPuertoE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPuertoR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnMen = new System.Windows.Forms.Panel();
            this.tbTamanio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMens = new System.Windows.Forms.RichTextBox();
            this.lbMens = new System.Windows.Forms.Label();
            this.rgOperaciones = new System.Windows.Forms.GroupBox();
            this.rbSend = new System.Windows.Forms.RadioButton();
            this.rbReceive = new System.Windows.Forms.RadioButton();
            this.cnRece = new System.Windows.Forms.Panel();
            this.tbRece = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cnEmis = new System.Windows.Forms.Panel();
            this.tbEmis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnPrio = new System.Windows.Forms.Panel();
            this.nuPrio = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btProcesar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btDisplay = new System.Windows.Forms.Button();
            this.pninteractivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnMen.SuspendLayout();
            this.rgOperaciones.SuspendLayout();
            this.cnRece.SuspendLayout();
            this.cnEmis.SuspendLayout();
            this.pnPrio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuPrio)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btConfig
            // 
            this.btConfig.BackgroundImage = global::proyecto1SO.Properties.Resources.config2;
            this.btConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btConfig.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btConfig.Location = new System.Drawing.Point(610, 13);
            this.btConfig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btConfig.Name = "btConfig";
            this.btConfig.Size = new System.Drawing.Size(121, 49);
            this.btConfig.TabIndex = 0;
            this.btConfig.Text = "Configurar";
            this.btConfig.UseVisualStyleBackColor = true;
            this.btConfig.Click += new System.EventHandler(this.btConfig_Click);
            // 
            // listPids
            // 
            this.listPids.FormattingEnabled = true;
            this.listPids.ItemHeight = 16;
            this.listPids.Location = new System.Drawing.Point(589, 27);
            this.listPids.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listPids.Name = "listPids";
            this.listPids.ScrollAlwaysVisible = true;
            this.listPids.Size = new System.Drawing.Size(159, 132);
            this.listPids.TabIndex = 1;
            // 
            // lbPids
            // 
            this.lbPids.AutoSize = true;
            this.lbPids.Location = new System.Drawing.Point(681, 10);
            this.lbPids.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPids.Name = "lbPids";
            this.lbPids.Size = new System.Drawing.Size(67, 17);
            this.lbPids.TabIndex = 2;
            this.lbPids.Text = "Procesos";
            // 
            // pninteractivo
            // 
            this.pninteractivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pninteractivo.Controls.Add(this.listPids);
            this.pninteractivo.Controls.Add(this.Grid);
            this.pninteractivo.Controls.Add(this.panel1);
            this.pninteractivo.Controls.Add(this.btProcesar);
            this.pninteractivo.Controls.Add(this.lbPids);
            this.pninteractivo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pninteractivo.Location = new System.Drawing.Point(0, 77);
            this.pninteractivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pninteractivo.Name = "pninteractivo";
            this.pninteractivo.Size = new System.Drawing.Size(760, 320);
            this.pninteractivo.TabIndex = 7;
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AllowUserToResizeColumns = false;
            this.Grid.AllowUserToResizeRows = false;
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = "0";
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNuProc,
            this.cPuertoE,
            this.cPuertoR});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Format = "N0";
            dataGridViewCellStyle8.NullValue = "0";
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.DefaultCellStyle = dataGridViewCellStyle8;
            this.Grid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Grid.Location = new System.Drawing.Point(473, 27);
            this.Grid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = "0";
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Gray;
            this.Grid.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.Grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Grid.ShowCellToolTips = false;
            this.Grid.Size = new System.Drawing.Size(276, 153);
            this.Grid.TabIndex = 15;
            this.Grid.Visible = false;
            // 
            // cNuProc
            // 
            this.cNuProc.Frozen = true;
            this.cNuProc.HeaderText = "Num. Proc";
            this.cNuProc.Name = "cNuProc";
            this.cNuProc.ReadOnly = true;
            this.cNuProc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cNuProc.Width = 50;
            // 
            // cPuertoE
            // 
            this.cPuertoE.Frozen = true;
            this.cPuertoE.HeaderText = "Puerto emisor";
            this.cPuertoE.Name = "cPuertoE";
            this.cPuertoE.ReadOnly = true;
            this.cPuertoE.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cPuertoE.Width = 50;
            // 
            // cPuertoR
            // 
            this.cPuertoR.Frozen = true;
            this.cPuertoR.HeaderText = "Puerto receptor";
            this.cPuertoR.Name = "cPuertoR";
            this.cPuertoR.ReadOnly = true;
            this.cPuertoR.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cPuertoR.Width = 50;
            // 
            // btSalir
            // 
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(610, 14);
            this.btSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(121, 49);
            this.btSalir.TabIndex = 13;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pnMen);
            this.panel1.Controls.Add(this.rgOperaciones);
            this.panel1.Controls.Add(this.cnRece);
            this.panel1.Controls.Add(this.cnEmis);
            this.panel1.Controls.Add(this.pnPrio);
            this.panel1.Location = new System.Drawing.Point(12, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 232);
            this.panel1.TabIndex = 11;
            // 
            // pnMen
            // 
            this.pnMen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMen.Controls.Add(this.tbTamanio);
            this.pnMen.Controls.Add(this.label4);
            this.pnMen.Controls.Add(this.tbMens);
            this.pnMen.Controls.Add(this.lbMens);
            this.pnMen.Location = new System.Drawing.Point(9, 129);
            this.pnMen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnMen.Name = "pnMen";
            this.pnMen.Size = new System.Drawing.Size(401, 92);
            this.pnMen.TabIndex = 15;
            // 
            // tbTamanio
            // 
            this.tbTamanio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTamanio.Location = new System.Drawing.Point(308, 32);
            this.tbTamanio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTamanio.Name = "tbTamanio";
            this.tbTamanio.ReadOnly = true;
            this.tbTamanio.Size = new System.Drawing.Size(78, 22);
            this.tbTamanio.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tamaño";
            // 
            // tbMens
            // 
            this.tbMens.Location = new System.Drawing.Point(4, 32);
            this.tbMens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMens.Name = "tbMens";
            this.tbMens.Size = new System.Drawing.Size(296, 47);
            this.tbMens.TabIndex = 12;
            this.tbMens.Text = "";
            this.tbMens.TextChanged += new System.EventHandler(this.tbMens_TextChanged);
            // 
            // lbMens
            // 
            this.lbMens.AutoSize = true;
            this.lbMens.Location = new System.Drawing.Point(4, 14);
            this.lbMens.Name = "lbMens";
            this.lbMens.Size = new System.Drawing.Size(61, 17);
            this.lbMens.TabIndex = 11;
            this.lbMens.Text = "Mensaje";
            // 
            // rgOperaciones
            // 
            this.rgOperaciones.Controls.Add(this.rbSend);
            this.rgOperaciones.Controls.Add(this.rbReceive);
            this.rgOperaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rgOperaciones.Location = new System.Drawing.Point(20, 7);
            this.rgOperaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rgOperaciones.Name = "rgOperaciones";
            this.rgOperaciones.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rgOperaciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgOperaciones.Size = new System.Drawing.Size(221, 47);
            this.rgOperaciones.TabIndex = 14;
            this.rgOperaciones.TabStop = false;
            // 
            // rbSend
            // 
            this.rbSend.AutoSize = true;
            this.rbSend.Checked = true;
            this.rbSend.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbSend.Location = new System.Drawing.Point(4, 19);
            this.rbSend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbSend.Name = "rbSend";
            this.rbSend.Size = new System.Drawing.Size(62, 24);
            this.rbSend.TabIndex = 1;
            this.rbSend.TabStop = true;
            this.rbSend.Text = "Send";
            this.rbSend.UseVisualStyleBackColor = true;
            // 
            // rbReceive
            // 
            this.rbReceive.AutoSize = true;
            this.rbReceive.Dock = System.Windows.Forms.DockStyle.Right;
            this.rbReceive.Location = new System.Drawing.Point(137, 19);
            this.rbReceive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbReceive.Name = "rbReceive";
            this.rbReceive.Size = new System.Drawing.Size(80, 24);
            this.rbReceive.TabIndex = 2;
            this.rbReceive.Text = "Receive";
            this.rbReceive.UseVisualStyleBackColor = true;
            // 
            // cnRece
            // 
            this.cnRece.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cnRece.Controls.Add(this.tbRece);
            this.cnRece.Controls.Add(this.label2);
            this.cnRece.Location = new System.Drawing.Point(217, 60);
            this.cnRece.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cnRece.Name = "cnRece";
            this.cnRece.Size = new System.Drawing.Size(193, 65);
            this.cnRece.TabIndex = 13;
            // 
            // tbRece
            // 
            this.tbRece.Location = new System.Drawing.Point(3, 32);
            this.tbRece.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRece.Name = "tbRece";
            this.tbRece.Size = new System.Drawing.Size(159, 22);
            this.tbRece.TabIndex = 5;
            this.tbRece.Validating += new System.ComponentModel.CancelEventHandler(this.tbRece_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Receptor";
            // 
            // cnEmis
            // 
            this.cnEmis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cnEmis.Controls.Add(this.tbEmis);
            this.cnEmis.Controls.Add(this.label1);
            this.cnEmis.Location = new System.Drawing.Point(9, 60);
            this.cnEmis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cnEmis.Name = "cnEmis";
            this.cnEmis.Size = new System.Drawing.Size(193, 65);
            this.cnEmis.TabIndex = 12;
            // 
            // tbEmis
            // 
            this.tbEmis.Location = new System.Drawing.Point(3, 32);
            this.tbEmis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmis.Name = "tbEmis";
            this.tbEmis.Size = new System.Drawing.Size(159, 22);
            this.tbEmis.TabIndex = 5;
            this.tbEmis.Validating += new System.ComponentModel.CancelEventHandler(this.tbRece_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Emisor";
            // 
            // pnPrio
            // 
            this.pnPrio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnPrio.Controls.Add(this.nuPrio);
            this.pnPrio.Controls.Add(this.label5);
            this.pnPrio.Location = new System.Drawing.Point(275, 18);
            this.pnPrio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnPrio.Name = "pnPrio";
            this.pnPrio.Size = new System.Drawing.Size(137, 38);
            this.pnPrio.TabIndex = 11;
            // 
            // nuPrio
            // 
            this.nuPrio.Location = new System.Drawing.Point(77, 7);
            this.nuPrio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nuPrio.Name = "nuPrio";
            this.nuPrio.Size = new System.Drawing.Size(48, 22);
            this.nuPrio.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Prioridad";
            // 
            // btProcesar
            // 
            this.btProcesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcesar.Location = new System.Drawing.Point(12, 258);
            this.btProcesar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btProcesar.Name = "btProcesar";
            this.btProcesar.Size = new System.Drawing.Size(121, 49);
            this.btProcesar.TabIndex = 3;
            this.btProcesar.Text = "Procesar";
            this.btProcesar.UseVisualStyleBackColor = true;
            this.btProcesar.Click += new System.EventHandler(this.btProcesar_Click);
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(760, 77);
            this.label3.TabIndex = 8;
            this.label3.Text = "MESSAGE PASSING";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btDisplay);
            this.panel2.Controls.Add(this.btSalir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 397);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 76);
            this.panel2.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btConfig);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(760, 77);
            this.panel4.TabIndex = 10;
            // 
            // btDisplay
            // 
            this.btDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDisplay.Location = new System.Drawing.Point(14, 14);
            this.btDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btDisplay.Name = "btDisplay";
            this.btDisplay.Size = new System.Drawing.Size(121, 49);
            this.btDisplay.TabIndex = 14;
            this.btDisplay.Text = "Display";
            this.btDisplay.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 489);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pninteractivo);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SO_Pr1_MESSAGE PASSING";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pninteractivo.ResumeLayout(false);
            this.pninteractivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnMen.ResumeLayout(false);
            this.pnMen.PerformLayout();
            this.rgOperaciones.ResumeLayout(false);
            this.rgOperaciones.PerformLayout();
            this.cnRece.ResumeLayout(false);
            this.cnRece.PerformLayout();
            this.cnEmis.ResumeLayout(false);
            this.cnEmis.PerformLayout();
            this.pnPrio.ResumeLayout(false);
            this.pnPrio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuPrio)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btConfig;
        private System.Windows.Forms.ListBox listPids;
        private System.Windows.Forms.Label lbPids;
        private System.Windows.Forms.Panel pninteractivo;
        private System.Windows.Forms.Button btProcesar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnMen;
        private System.Windows.Forms.TextBox tbTamanio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox tbMens;
        private System.Windows.Forms.Label lbMens;
        private System.Windows.Forms.GroupBox rgOperaciones;
        private System.Windows.Forms.RadioButton rbSend;
        private System.Windows.Forms.RadioButton rbReceive;
        private System.Windows.Forms.Panel cnRece;
        private System.Windows.Forms.TextBox tbRece;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel cnEmis;
        private System.Windows.Forms.TextBox tbEmis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnPrio;
        private System.Windows.Forms.NumericUpDown nuPrio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNuProc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPuertoE;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPuertoR;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btDisplay;
        private System.Windows.Forms.Panel panel4;
    }
}

