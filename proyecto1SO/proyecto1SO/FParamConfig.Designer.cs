namespace proyecto1SO
{
    partial class FParamConfig
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnColas = new System.Windows.Forms.Panel();
            this.nuHilos = new System.Windows.Forms.NumericUpDown();
            this.lbNHilos = new System.Windows.Forms.Label();
            this.cbColas = new System.Windows.Forms.ComboBox();
            this.lbColas = new System.Windows.Forms.Label();
            this.pnFormt = new System.Windows.Forms.Panel();
            this.pnTamFijo = new System.Windows.Forms.Panel();
            this.nuTamMax = new System.Windows.Forms.NumericUpDown();
            this.lbMaxTam = new System.Windows.Forms.Label();
            this.cbFomtL = new System.Windows.Forms.ComboBox();
            this.cbFomtC = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbFormt = new System.Windows.Forms.Label();
            this.pnDirec = new System.Windows.Forms.Panel();
            this.cbDirec = new System.Windows.Forms.ComboBox();
            this.lbDire2 = new System.Windows.Forms.Label();
            this.rgDirec = new System.Windows.Forms.GroupBox();
            this.rbDirDi = new System.Windows.Forms.RadioButton();
            this.rbDirIn = new System.Windows.Forms.RadioButton();
            this.lbDirec = new System.Windows.Forms.Label();
            this.pnSincr = new System.Windows.Forms.Panel();
            this.cbSincR = new System.Windows.Forms.ComboBox();
            this.cbSincS = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSincr = new System.Windows.Forms.Label();
            this.btAplicar = new System.Windows.Forms.Button();
            this.nuTamColaMen = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.cNuProc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPuertoE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPuertoR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.pnColas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuHilos)).BeginInit();
            this.pnFormt.SuspendLayout();
            this.pnTamFijo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuTamMax)).BeginInit();
            this.pnDirec.SuspendLayout();
            this.rgDirec.SuspendLayout();
            this.pnSincr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuTamColaMen)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Grid);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnColas);
            this.panel1.Controls.Add(this.pnFormt);
            this.panel1.Controls.Add(this.pnDirec);
            this.panel1.Controls.Add(this.pnSincr);
            this.panel1.Controls.Add(this.btAplicar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 315);
            this.panel1.TabIndex = 0;
            // 
            // pnColas
            // 
            this.pnColas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnColas.Controls.Add(this.nuTamColaMen);
            this.pnColas.Controls.Add(this.label3);
            this.pnColas.Controls.Add(this.cbColas);
            this.pnColas.Controls.Add(this.lbColas);
            this.pnColas.Location = new System.Drawing.Point(239, 142);
            this.pnColas.Name = "pnColas";
            this.pnColas.Size = new System.Drawing.Size(218, 124);
            this.pnColas.TabIndex = 4;
            // 
            // nuHilos
            // 
            this.nuHilos.Location = new System.Drawing.Point(104, 35);
            this.nuHilos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuHilos.Name = "nuHilos";
            this.nuHilos.Size = new System.Drawing.Size(36, 20);
            this.nuHilos.TabIndex = 9;
            this.nuHilos.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nuHilos.ValueChanged += new System.EventHandler(this.nuHilos_ValueChanged);
            // 
            // lbNHilos
            // 
            this.lbNHilos.AutoSize = true;
            this.lbNHilos.Location = new System.Drawing.Point(20, 35);
            this.lbNHilos.Name = "lbNHilos";
            this.lbNHilos.Size = new System.Drawing.Size(78, 13);
            this.lbNHilos.TabIndex = 5;
            this.lbNHilos.Text = "Num. procesos";
            // 
            // cbColas
            // 
            this.cbColas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColas.FormattingEnabled = true;
            this.cbColas.Items.AddRange(new object[] {
            "FIFO",
            "Prioridad"});
            this.cbColas.Location = new System.Drawing.Point(21, 29);
            this.cbColas.Name = "cbColas";
            this.cbColas.Size = new System.Drawing.Size(173, 21);
            this.cbColas.TabIndex = 8;
            // 
            // lbColas
            // 
            this.lbColas.AutoSize = true;
            this.lbColas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColas.Location = new System.Drawing.Point(18, 13);
            this.lbColas.Name = "lbColas";
            this.lbColas.Size = new System.Drawing.Size(176, 13);
            this.lbColas.TabIndex = 1;
            this.lbColas.Text = "Disciplina de manejo de colas";
            // 
            // pnFormt
            // 
            this.pnFormt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnFormt.Controls.Add(this.pnTamFijo);
            this.pnFormt.Controls.Add(this.cbFomtL);
            this.pnFormt.Controls.Add(this.cbFomtC);
            this.pnFormt.Controls.Add(this.label5);
            this.pnFormt.Controls.Add(this.label4);
            this.pnFormt.Controls.Add(this.lbFormt);
            this.pnFormt.Location = new System.Drawing.Point(239, 12);
            this.pnFormt.Name = "pnFormt";
            this.pnFormt.Size = new System.Drawing.Size(218, 124);
            this.pnFormt.TabIndex = 3;
            // 
            // pnTamFijo
            // 
            this.pnTamFijo.Controls.Add(this.nuTamMax);
            this.pnTamFijo.Controls.Add(this.lbMaxTam);
            this.pnTamFijo.Location = new System.Drawing.Point(2, 92);
            this.pnTamFijo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnTamFijo.Name = "pnTamFijo";
            this.pnTamFijo.Size = new System.Drawing.Size(212, 24);
            this.pnTamFijo.TabIndex = 12;
            // 
            // nuTamMax
            // 
            this.nuTamMax.Location = new System.Drawing.Point(72, 3);
            this.nuTamMax.Name = "nuTamMax";
            this.nuTamMax.Size = new System.Drawing.Size(36, 20);
            this.nuTamMax.TabIndex = 13;
            this.nuTamMax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lbMaxTam
            // 
            this.lbMaxTam.AutoSize = true;
            this.lbMaxTam.Location = new System.Drawing.Point(16, 5);
            this.lbMaxTam.Name = "lbMaxTam";
            this.lbMaxTam.Size = new System.Drawing.Size(46, 13);
            this.lbMaxTam.TabIndex = 12;
            this.lbMaxTam.Text = "Máximo:";
            // 
            // cbFomtL
            // 
            this.cbFomtL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFomtL.FormattingEnabled = true;
            this.cbFomtL.Items.AddRange(new object[] {
            "Fijo",
            "Variable"});
            this.cbFomtL.Location = new System.Drawing.Point(74, 68);
            this.cbFomtL.Name = "cbFomtL";
            this.cbFomtL.Size = new System.Drawing.Size(121, 21);
            this.cbFomtL.TabIndex = 7;
            this.cbFomtL.SelectedIndexChanged += new System.EventHandler(this.cbFomtL_SelectedIndexChanged);
            // 
            // cbFomtC
            // 
            this.cbFomtC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFomtC.FormattingEnabled = true;
            this.cbFomtC.Items.AddRange(new object[] {
            "Texto",
            "Archivo",
            "Multimedia"});
            this.cbFomtC.Location = new System.Drawing.Point(74, 34);
            this.cbFomtC.Name = "cbFomtC";
            this.cbFomtC.Size = new System.Drawing.Size(121, 21);
            this.cbFomtC.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Largo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Contenido:";
            // 
            // lbFormt
            // 
            this.lbFormt.AutoSize = true;
            this.lbFormt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFormt.Location = new System.Drawing.Point(18, 11);
            this.lbFormt.Name = "lbFormt";
            this.lbFormt.Size = new System.Drawing.Size(52, 13);
            this.lbFormt.TabIndex = 1;
            this.lbFormt.Text = "Formato";
            // 
            // pnDirec
            // 
            this.pnDirec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnDirec.Controls.Add(this.cbDirec);
            this.pnDirec.Controls.Add(this.lbDire2);
            this.pnDirec.Controls.Add(this.rgDirec);
            this.pnDirec.Controls.Add(this.lbDirec);
            this.pnDirec.Location = new System.Drawing.Point(15, 142);
            this.pnDirec.Name = "pnDirec";
            this.pnDirec.Size = new System.Drawing.Size(218, 124);
            this.pnDirec.TabIndex = 2;
            // 
            // cbDirec
            // 
            this.cbDirec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDirec.FormattingEnabled = true;
            this.cbDirec.Location = new System.Drawing.Point(74, 82);
            this.cbDirec.Name = "cbDirec";
            this.cbDirec.Size = new System.Drawing.Size(121, 21);
            this.cbDirec.TabIndex = 5;
            this.cbDirec.SelectedIndexChanged += new System.EventHandler(this.cbDirec_SelectedIndexChanged);
            // 
            // lbDire2
            // 
            this.lbDire2.AutoSize = true;
            this.lbDire2.Location = new System.Drawing.Point(16, 82);
            this.lbDire2.Name = "lbDire2";
            this.lbDire2.Size = new System.Drawing.Size(35, 13);
            this.lbDire2.TabIndex = 3;
            this.lbDire2.Text = "label3";
            // 
            // rgDirec
            // 
            this.rgDirec.Controls.Add(this.rbDirDi);
            this.rgDirec.Controls.Add(this.rbDirIn);
            this.rgDirec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rgDirec.Location = new System.Drawing.Point(16, 29);
            this.rgDirec.Name = "rgDirec";
            this.rgDirec.Size = new System.Drawing.Size(192, 38);
            this.rgDirec.TabIndex = 2;
            this.rgDirec.TabStop = false;
            // 
            // rbDirDi
            // 
            this.rbDirDi.AutoSize = true;
            this.rbDirDi.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbDirDi.Location = new System.Drawing.Point(3, 16);
            this.rbDirDi.Name = "rbDirDi";
            this.rbDirDi.Size = new System.Drawing.Size(59, 19);
            this.rbDirDi.TabIndex = 3;
            this.rbDirDi.TabStop = true;
            this.rbDirDi.Text = "Directo";
            this.rbDirDi.UseVisualStyleBackColor = true;
            this.rbDirDi.Click += new System.EventHandler(this.rbDirDi_Click);
            // 
            // rbDirIn
            // 
            this.rbDirIn.AutoSize = true;
            this.rbDirIn.Dock = System.Windows.Forms.DockStyle.Right;
            this.rbDirIn.Location = new System.Drawing.Point(123, 16);
            this.rbDirIn.Name = "rbDirIn";
            this.rbDirIn.Size = new System.Drawing.Size(66, 19);
            this.rbDirIn.TabIndex = 4;
            this.rbDirIn.TabStop = true;
            this.rbDirIn.Text = "Indirecto";
            this.rbDirIn.UseVisualStyleBackColor = true;
            this.rbDirIn.Click += new System.EventHandler(this.rbDirIn_Click);
            // 
            // lbDirec
            // 
            this.lbDirec.AutoSize = true;
            this.lbDirec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDirec.Location = new System.Drawing.Point(13, 13);
            this.lbDirec.Name = "lbDirec";
            this.lbDirec.Size = new System.Drawing.Size(109, 13);
            this.lbDirec.TabIndex = 1;
            this.lbDirec.Text = "Direccionamiento ";
            // 
            // pnSincr
            // 
            this.pnSincr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnSincr.Controls.Add(this.cbSincR);
            this.pnSincr.Controls.Add(this.cbSincS);
            this.pnSincr.Controls.Add(this.label2);
            this.pnSincr.Controls.Add(this.label1);
            this.pnSincr.Controls.Add(this.lbSincr);
            this.pnSincr.Location = new System.Drawing.Point(15, 12);
            this.pnSincr.Name = "pnSincr";
            this.pnSincr.Size = new System.Drawing.Size(218, 124);
            this.pnSincr.TabIndex = 1;
            // 
            // cbSincR
            // 
            this.cbSincR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSincR.FormattingEnabled = true;
            this.cbSincR.Items.AddRange(new object[] {
            "Blocking",
            "Nonblocking",
            "Prueba de llegada"});
            this.cbSincR.Location = new System.Drawing.Point(74, 68);
            this.cbSincR.Name = "cbSincR";
            this.cbSincR.Size = new System.Drawing.Size(121, 21);
            this.cbSincR.TabIndex = 2;
            // 
            // cbSincS
            // 
            this.cbSincS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSincS.FormattingEnabled = true;
            this.cbSincS.Items.AddRange(new object[] {
            "Blocking",
            "Nonblocking"});
            this.cbSincS.Location = new System.Drawing.Point(74, 34);
            this.cbSincS.Name = "cbSincS";
            this.cbSincS.Size = new System.Drawing.Size(121, 21);
            this.cbSincS.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Receive:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Send:";
            // 
            // lbSincr
            // 
            this.lbSincr.AutoSize = true;
            this.lbSincr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSincr.Location = new System.Drawing.Point(13, 11);
            this.lbSincr.Name = "lbSincr";
            this.lbSincr.Size = new System.Drawing.Size(90, 13);
            this.lbSincr.TabIndex = 0;
            this.lbSincr.Text = "Sincronización";
            // 
            // btAplicar
            // 
            this.btAplicar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btAplicar.Location = new System.Drawing.Point(0, 283);
            this.btAplicar.Name = "btAplicar";
            this.btAplicar.Size = new System.Drawing.Size(690, 28);
            this.btAplicar.TabIndex = 10;
            this.btAplicar.Text = "Aplicar";
            this.btAplicar.UseVisualStyleBackColor = true;
            this.btAplicar.Click += new System.EventHandler(this.btAplicar_Click);
            // 
            // nuTamColaMen
            // 
            this.nuTamColaMen.Location = new System.Drawing.Point(159, 80);
            this.nuTamColaMen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuTamColaMen.Name = "nuTamColaMen";
            this.nuTamColaMen.Size = new System.Drawing.Size(36, 20);
            this.nuTamColaMen.TabIndex = 11;
            this.nuTamColaMen.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tamaño cola de mensajes";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.nuHilos);
            this.panel2.Controls.Add(this.lbNHilos);
            this.panel2.Location = new System.Drawing.Point(463, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 124);
            this.panel2.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Procesos";
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AllowUserToResizeColumns = false;
            this.Grid.AllowUserToResizeRows = false;
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = "0";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNuProc,
            this.cPuertoE,
            this.cPuertoR});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Grid.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Grid.Location = new System.Drawing.Point(463, 142);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "0";
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gray;
            this.Grid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Grid.ShowCellToolTips = false;
            this.Grid.Size = new System.Drawing.Size(207, 124);
            this.Grid.TabIndex = 12;
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
            this.cPuertoE.HeaderText = "Puerto emisor";
            this.cPuertoE.Name = "cPuertoE";
            this.cPuertoE.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cPuertoE.Width = 50;
            // 
            // cPuertoR
            // 
            this.cPuertoR.HeaderText = "Puerto receptor";
            this.cPuertoR.Name = "cPuertoR";
            this.cPuertoR.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cPuertoR.Width = 50;
            // 
            // FParamConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 335);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FParamConfig";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuración";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.pnColas.ResumeLayout(false);
            this.pnColas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuHilos)).EndInit();
            this.pnFormt.ResumeLayout(false);
            this.pnFormt.PerformLayout();
            this.pnTamFijo.ResumeLayout(false);
            this.pnTamFijo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuTamMax)).EndInit();
            this.pnDirec.ResumeLayout(false);
            this.pnDirec.PerformLayout();
            this.rgDirec.ResumeLayout(false);
            this.rgDirec.PerformLayout();
            this.pnSincr.ResumeLayout(false);
            this.pnSincr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuTamColaMen)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnColas;
        private System.Windows.Forms.Panel pnFormt;
        private System.Windows.Forms.Panel pnDirec;
        private System.Windows.Forms.Panel pnSincr;
        private System.Windows.Forms.Button btAplicar;
        private System.Windows.Forms.ComboBox cbColas;
        private System.Windows.Forms.Label lbColas;
        private System.Windows.Forms.ComboBox cbFomtL;
        private System.Windows.Forms.ComboBox cbFomtC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbFormt;
        private System.Windows.Forms.ComboBox cbDirec;
        private System.Windows.Forms.Label lbDire2;
        private System.Windows.Forms.GroupBox rgDirec;
        private System.Windows.Forms.RadioButton rbDirDi;
        private System.Windows.Forms.RadioButton rbDirIn;
        private System.Windows.Forms.Label lbDirec;
        private System.Windows.Forms.ComboBox cbSincR;
        private System.Windows.Forms.ComboBox cbSincS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSincr;
        private System.Windows.Forms.Label lbNHilos;
        private System.Windows.Forms.NumericUpDown nuHilos;
        private System.Windows.Forms.Panel pnTamFijo;
        private System.Windows.Forms.NumericUpDown nuTamMax;
        private System.Windows.Forms.Label lbMaxTam;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nuTamColaMen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNuProc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPuertoE;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPuertoR;
    }
}