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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnColas = new System.Windows.Forms.Panel();
            this.NHilos = new System.Windows.Forms.NumericUpDown();
            this.lbNHilos = new System.Windows.Forms.Label();
            this.cbColas = new System.Windows.Forms.ComboBox();
            this.lbColas = new System.Windows.Forms.Label();
            this.pnFormt = new System.Windows.Forms.Panel();
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
            this.pnTamFijo = new System.Windows.Forms.Panel();
            this.nuTamMax = new System.Windows.Forms.NumericUpDown();
            this.lbMaxTam = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnColas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NHilos)).BeginInit();
            this.pnFormt.SuspendLayout();
            this.pnDirec.SuspendLayout();
            this.rgDirec.SuspendLayout();
            this.pnSincr.SuspendLayout();
            this.pnTamFijo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuTamMax)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pnColas);
            this.panel1.Controls.Add(this.pnFormt);
            this.panel1.Controls.Add(this.pnDirec);
            this.panel1.Controls.Add(this.pnSincr);
            this.panel1.Controls.Add(this.btAplicar);
            this.panel1.Location = new System.Drawing.Point(18, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 495);
            this.panel1.TabIndex = 0;
            // 
            // pnColas
            // 
            this.pnColas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnColas.Controls.Add(this.NHilos);
            this.pnColas.Controls.Add(this.lbNHilos);
            this.pnColas.Controls.Add(this.cbColas);
            this.pnColas.Controls.Add(this.lbColas);
            this.pnColas.Location = new System.Drawing.Point(358, 218);
            this.pnColas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnColas.Name = "pnColas";
            this.pnColas.Size = new System.Drawing.Size(326, 190);
            this.pnColas.TabIndex = 4;
            // 
            // NHilos
            // 
            this.NHilos.Location = new System.Drawing.Point(123, 126);
            this.NHilos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NHilos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NHilos.Name = "NHilos";
            this.NHilos.Size = new System.Drawing.Size(54, 26);
            this.NHilos.TabIndex = 9;
            this.NHilos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbNHilos
            // 
            this.lbNHilos.AutoSize = true;
            this.lbNHilos.Location = new System.Drawing.Point(27, 126);
            this.lbNHilos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNHilos.Name = "lbNHilos";
            this.lbNHilos.Size = new System.Drawing.Size(85, 20);
            this.lbNHilos.TabIndex = 5;
            this.lbNHilos.Text = "Num. Hilos";
            // 
            // cbColas
            // 
            this.cbColas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColas.FormattingEnabled = true;
            this.cbColas.Items.AddRange(new object[] {
            "FIFO",
            "Prioridad"});
            this.cbColas.Location = new System.Drawing.Point(32, 45);
            this.cbColas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbColas.Name = "cbColas";
            this.cbColas.Size = new System.Drawing.Size(258, 28);
            this.cbColas.TabIndex = 8;
            // 
            // lbColas
            // 
            this.lbColas.AutoSize = true;
            this.lbColas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColas.Location = new System.Drawing.Point(27, 20);
            this.lbColas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbColas.Name = "lbColas";
            this.lbColas.Size = new System.Drawing.Size(262, 20);
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
            this.pnFormt.Location = new System.Drawing.Point(358, 18);
            this.pnFormt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnFormt.Name = "pnFormt";
            this.pnFormt.Size = new System.Drawing.Size(326, 190);
            this.pnFormt.TabIndex = 3;
            // 
            // cbFomtL
            // 
            this.cbFomtL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFomtL.FormattingEnabled = true;
            this.cbFomtL.Items.AddRange(new object[] {
            "Fijo",
            "Variable"});
            this.cbFomtL.Location = new System.Drawing.Point(111, 105);
            this.cbFomtL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbFomtL.Name = "cbFomtL";
            this.cbFomtL.Size = new System.Drawing.Size(180, 28);
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
            this.cbFomtC.Location = new System.Drawing.Point(111, 52);
            this.cbFomtC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbFomtC.Name = "cbFomtC";
            this.cbFomtC.Size = new System.Drawing.Size(180, 28);
            this.cbFomtC.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Largo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Contenido:";
            // 
            // lbFormt
            // 
            this.lbFormt.AutoSize = true;
            this.lbFormt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFormt.Location = new System.Drawing.Point(27, 17);
            this.lbFormt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFormt.Name = "lbFormt";
            this.lbFormt.Size = new System.Drawing.Size(78, 20);
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
            this.pnDirec.Location = new System.Drawing.Point(22, 218);
            this.pnDirec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnDirec.Name = "pnDirec";
            this.pnDirec.Size = new System.Drawing.Size(326, 190);
            this.pnDirec.TabIndex = 2;
            // 
            // cbDirec
            // 
            this.cbDirec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDirec.FormattingEnabled = true;
            this.cbDirec.Location = new System.Drawing.Point(111, 126);
            this.cbDirec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDirec.Name = "cbDirec";
            this.cbDirec.Size = new System.Drawing.Size(180, 28);
            this.cbDirec.TabIndex = 5;
            // 
            // lbDire2
            // 
            this.lbDire2.AutoSize = true;
            this.lbDire2.Location = new System.Drawing.Point(24, 126);
            this.lbDire2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDire2.Name = "lbDire2";
            this.lbDire2.Size = new System.Drawing.Size(51, 20);
            this.lbDire2.TabIndex = 3;
            this.lbDire2.Text = "label3";
            // 
            // rgDirec
            // 
            this.rgDirec.Controls.Add(this.rbDirDi);
            this.rgDirec.Controls.Add(this.rbDirIn);
            this.rgDirec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rgDirec.Location = new System.Drawing.Point(24, 45);
            this.rgDirec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rgDirec.Name = "rgDirec";
            this.rgDirec.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rgDirec.Size = new System.Drawing.Size(288, 58);
            this.rgDirec.TabIndex = 2;
            this.rgDirec.TabStop = false;
            // 
            // rbDirDi
            // 
            this.rbDirDi.AutoSize = true;
            this.rbDirDi.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbDirDi.Location = new System.Drawing.Point(4, 24);
            this.rbDirDi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbDirDi.Name = "rbDirDi";
            this.rbDirDi.Size = new System.Drawing.Size(85, 29);
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
            this.rbDirIn.Location = new System.Drawing.Point(188, 24);
            this.rbDirIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbDirIn.Name = "rbDirIn";
            this.rbDirIn.Size = new System.Drawing.Size(96, 29);
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
            this.lbDirec.Location = new System.Drawing.Point(20, 20);
            this.lbDirec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDirec.Name = "lbDirec";
            this.lbDirec.Size = new System.Drawing.Size(162, 20);
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
            this.pnSincr.Location = new System.Drawing.Point(22, 18);
            this.pnSincr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnSincr.Name = "pnSincr";
            this.pnSincr.Size = new System.Drawing.Size(326, 190);
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
            this.cbSincR.Location = new System.Drawing.Point(111, 105);
            this.cbSincR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSincR.Name = "cbSincR";
            this.cbSincR.Size = new System.Drawing.Size(180, 28);
            this.cbSincR.TabIndex = 2;
            // 
            // cbSincS
            // 
            this.cbSincS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSincS.FormattingEnabled = true;
            this.cbSincS.Items.AddRange(new object[] {
            "Blocking",
            "Nonblocking"});
            this.cbSincS.Location = new System.Drawing.Point(111, 52);
            this.cbSincS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSincS.Name = "cbSincS";
            this.cbSincS.Size = new System.Drawing.Size(180, 28);
            this.cbSincS.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Receive:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Send:";
            // 
            // lbSincr
            // 
            this.lbSincr.AutoSize = true;
            this.lbSincr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSincr.Location = new System.Drawing.Point(20, 17);
            this.lbSincr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSincr.Name = "lbSincr";
            this.lbSincr.Size = new System.Drawing.Size(133, 20);
            this.lbSincr.TabIndex = 0;
            this.lbSincr.Text = "Sincronización";
            // 
            // btAplicar
            // 
            this.btAplicar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btAplicar.Location = new System.Drawing.Point(0, 448);
            this.btAplicar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAplicar.Name = "btAplicar";
            this.btAplicar.Size = new System.Drawing.Size(711, 43);
            this.btAplicar.TabIndex = 10;
            this.btAplicar.Text = "Aplicar";
            this.btAplicar.UseVisualStyleBackColor = true;
            this.btAplicar.Click += new System.EventHandler(this.btAplicar_Click);
            // 
            // pnTamFijo
            // 
            this.pnTamFijo.Controls.Add(this.nuTamMax);
            this.pnTamFijo.Controls.Add(this.lbMaxTam);
            this.pnTamFijo.Location = new System.Drawing.Point(3, 141);
            this.pnTamFijo.Name = "pnTamFijo";
            this.pnTamFijo.Size = new System.Drawing.Size(318, 37);
            this.pnTamFijo.TabIndex = 12;
            // 
            // nuTamMax
            // 
            this.nuTamMax.Location = new System.Drawing.Point(108, 5);
            this.nuTamMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nuTamMax.Name = "nuTamMax";
            this.nuTamMax.Size = new System.Drawing.Size(54, 26);
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
            this.lbMaxTam.Location = new System.Drawing.Point(24, 7);
            this.lbMaxTam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaxTam.Name = "lbMaxTam";
            this.lbMaxTam.Size = new System.Drawing.Size(67, 20);
            this.lbMaxTam.TabIndex = 12;
            this.lbMaxTam.Text = "Máximo:";
            // 
            // FParamConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 518);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            ((System.ComponentModel.ISupportInitialize)(this.NHilos)).EndInit();
            this.pnFormt.ResumeLayout(false);
            this.pnFormt.PerformLayout();
            this.pnDirec.ResumeLayout(false);
            this.pnDirec.PerformLayout();
            this.rgDirec.ResumeLayout(false);
            this.rgDirec.PerformLayout();
            this.pnSincr.ResumeLayout(false);
            this.pnSincr.PerformLayout();
            this.pnTamFijo.ResumeLayout(false);
            this.pnTamFijo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuTamMax)).EndInit();
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
        private System.Windows.Forms.NumericUpDown NHilos;
        private System.Windows.Forms.Panel pnTamFijo;
        private System.Windows.Forms.NumericUpDown nuTamMax;
        private System.Windows.Forms.Label lbMaxTam;
    }
}