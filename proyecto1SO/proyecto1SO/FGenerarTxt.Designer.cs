namespace proyecto1SO
{
    partial class FGenerarTxt
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbSRP = new System.Windows.Forms.RadioButton();
            this.rbSRNB = new System.Windows.Forms.RadioButton();
            this.rbSRB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnSincr = new System.Windows.Forms.Panel();
            this.rbSSNB = new System.Windows.Forms.RadioButton();
            this.rbSSB = new System.Windows.Forms.RadioButton();
            this.lbSincr = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbD2 = new System.Windows.Forms.RadioButton();
            this.rbD1 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.rbDD = new System.Windows.Forms.RadioButton();
            this.pnColas = new System.Windows.Forms.Panel();
            this.rbDisPrioridad = new System.Windows.Forms.RadioButton();
            this.rbDisFIFO = new System.Windows.Forms.RadioButton();
            this.npTamColaMen = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lbColas = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.npProcesos = new System.Windows.Forms.NumericUpDown();
            this.lbNHilos = new System.Windows.Forms.Label();
            this.pnPuerto = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.nuPuertos = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rbFCA = new System.Windows.Forms.RadioButton();
            this.rbFCT = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.rbFCM = new System.Windows.Forms.RadioButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.rbFLV = new System.Windows.Forms.RadioButton();
            this.rbFLF = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.npFNmax = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnSincr.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnColas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npTamColaMen)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npProcesos)).BeginInit();
            this.pnPuerto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuPuertos)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npFNmax)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.pnSincr);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sincronización";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbSRP);
            this.panel1.Controls.Add(this.rbSRNB);
            this.panel1.Controls.Add(this.rbSRB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(18, 114);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 91);
            this.panel1.TabIndex = 3;
            // 
            // rbSRP
            // 
            this.rbSRP.AutoSize = true;
            this.rbSRP.Location = new System.Drawing.Point(82, 64);
            this.rbSRP.Name = "rbSRP";
            this.rbSRP.Size = new System.Drawing.Size(145, 21);
            this.rbSRP.TabIndex = 3;
            this.rbSRP.Text = "Prueba de llegada";
            this.rbSRP.UseVisualStyleBackColor = true;
            // 
            // rbSRNB
            // 
            this.rbSRNB.AutoSize = true;
            this.rbSRNB.Location = new System.Drawing.Point(82, 39);
            this.rbSRNB.Name = "rbSRNB";
            this.rbSRNB.Size = new System.Drawing.Size(101, 21);
            this.rbSRNB.TabIndex = 2;
            this.rbSRNB.Text = "no blocking";
            this.rbSRNB.UseVisualStyleBackColor = true;
            // 
            // rbSRB
            // 
            this.rbSRB.AutoSize = true;
            this.rbSRB.Checked = true;
            this.rbSRB.Location = new System.Drawing.Point(82, 14);
            this.rbSRB.Name = "rbSRB";
            this.rbSRB.Size = new System.Drawing.Size(81, 21);
            this.rbSRB.TabIndex = 1;
            this.rbSRB.TabStop = true;
            this.rbSRB.Text = "blocking";
            this.rbSRB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Receive";
            // 
            // pnSincr
            // 
            this.pnSincr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnSincr.Controls.Add(this.rbSSNB);
            this.pnSincr.Controls.Add(this.rbSSB);
            this.pnSincr.Controls.Add(this.lbSincr);
            this.pnSincr.Location = new System.Drawing.Point(18, 35);
            this.pnSincr.Margin = new System.Windows.Forms.Padding(4);
            this.pnSincr.Name = "pnSincr";
            this.pnSincr.Size = new System.Drawing.Size(229, 71);
            this.pnSincr.TabIndex = 2;
            // 
            // rbSSNB
            // 
            this.rbSSNB.AutoSize = true;
            this.rbSSNB.Location = new System.Drawing.Point(82, 41);
            this.rbSSNB.Name = "rbSSNB";
            this.rbSSNB.Size = new System.Drawing.Size(101, 21);
            this.rbSSNB.TabIndex = 2;
            this.rbSSNB.Text = "no blocking";
            this.rbSSNB.UseVisualStyleBackColor = true;
            // 
            // rbSSB
            // 
            this.rbSSB.AutoSize = true;
            this.rbSSB.Checked = true;
            this.rbSSB.Location = new System.Drawing.Point(82, 14);
            this.rbSSB.Name = "rbSSB";
            this.rbSSB.Size = new System.Drawing.Size(81, 21);
            this.rbSSB.TabIndex = 1;
            this.rbSSB.TabStop = true;
            this.rbSSB.Text = "blocking";
            this.rbSSB.UseVisualStyleBackColor = true;
            this.rbSSB.CheckedChanged += new System.EventHandler(this.rbSSB_CheckedChanged);
            // 
            // lbSincr
            // 
            this.lbSincr.AutoSize = true;
            this.lbSincr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSincr.Location = new System.Drawing.Point(17, 14);
            this.lbSincr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSincr.Name = "lbSincr";
            this.lbSincr.Size = new System.Drawing.Size(45, 17);
            this.lbSincr.TabIndex = 0;
            this.lbSincr.Text = "Send";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Location = new System.Drawing.Point(261, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 135);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Direccionamiento";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.radioButton9);
            this.panel3.Controls.Add(this.rbDD);
            this.panel3.Location = new System.Drawing.Point(18, 35);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 89);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rbD2);
            this.panel2.Controls.Add(this.rbD1);
            this.panel2.Location = new System.Drawing.Point(110, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(112, 79);
            this.panel2.TabIndex = 3;
            // 
            // rbD2
            // 
            this.rbD2.AutoSize = true;
            this.rbD2.Location = new System.Drawing.Point(7, 41);
            this.rbD2.Name = "rbD2";
            this.rbD2.Size = new System.Drawing.Size(79, 21);
            this.rbD2.TabIndex = 2;
            this.rbD2.Text = "implicito";
            this.rbD2.UseVisualStyleBackColor = true;
            // 
            // rbD1
            // 
            this.rbD1.AutoSize = true;
            this.rbD1.Checked = true;
            this.rbD1.Location = new System.Drawing.Point(7, 16);
            this.rbD1.Name = "rbD1";
            this.rbD1.Size = new System.Drawing.Size(79, 21);
            this.rbD1.TabIndex = 1;
            this.rbD1.TabStop = true;
            this.rbD1.Text = "explicito";
            this.rbD1.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(20, 41);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(83, 21);
            this.radioButton9.TabIndex = 2;
            this.radioButton9.Text = "Indirecto";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.radioButton9_CheckedChanged);
            // 
            // rbDD
            // 
            this.rbDD.AutoSize = true;
            this.rbDD.Checked = true;
            this.rbDD.Location = new System.Drawing.Point(20, 14);
            this.rbDD.Name = "rbDD";
            this.rbDD.Size = new System.Drawing.Size(74, 21);
            this.rbDD.TabIndex = 1;
            this.rbDD.TabStop = true;
            this.rbDD.Text = "Directo";
            this.rbDD.UseVisualStyleBackColor = true;
            this.rbDD.CheckedChanged += new System.EventHandler(this.radioButton10_CheckedChanged);
            // 
            // pnColas
            // 
            this.pnColas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnColas.Controls.Add(this.rbDisPrioridad);
            this.pnColas.Controls.Add(this.rbDisFIFO);
            this.pnColas.Controls.Add(this.npTamColaMen);
            this.pnColas.Controls.Add(this.label3);
            this.pnColas.Controls.Add(this.lbColas);
            this.pnColas.Location = new System.Drawing.Point(262, 163);
            this.pnColas.Margin = new System.Windows.Forms.Padding(4);
            this.pnColas.Name = "pnColas";
            this.pnColas.Size = new System.Drawing.Size(270, 107);
            this.pnColas.TabIndex = 5;
            // 
            // rbDisPrioridad
            // 
            this.rbDisPrioridad.AutoSize = true;
            this.rbDisPrioridad.Location = new System.Drawing.Point(105, 37);
            this.rbDisPrioridad.Name = "rbDisPrioridad";
            this.rbDisPrioridad.Size = new System.Drawing.Size(86, 21);
            this.rbDisPrioridad.TabIndex = 13;
            this.rbDisPrioridad.Text = "Prioridad";
            this.rbDisPrioridad.UseVisualStyleBackColor = true;
            // 
            // rbDisFIFO
            // 
            this.rbDisFIFO.AutoSize = true;
            this.rbDisFIFO.Checked = true;
            this.rbDisFIFO.Location = new System.Drawing.Point(30, 37);
            this.rbDisFIFO.Name = "rbDisFIFO";
            this.rbDisFIFO.Size = new System.Drawing.Size(59, 21);
            this.rbDisFIFO.TabIndex = 12;
            this.rbDisFIFO.TabStop = true;
            this.rbDisFIFO.Text = "FIFO";
            this.rbDisFIFO.UseVisualStyleBackColor = true;
            // 
            // npTamColaMen
            // 
            this.npTamColaMen.Location = new System.Drawing.Point(188, 73);
            this.npTamColaMen.Margin = new System.Windows.Forms.Padding(4);
            this.npTamColaMen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.npTamColaMen.Name = "npTamColaMen";
            this.npTamColaMen.Size = new System.Drawing.Size(48, 22);
            this.npTamColaMen.TabIndex = 11;
            this.npTamColaMen.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tamaño cola de mensajes:";
            // 
            // lbColas
            // 
            this.lbColas.AutoSize = true;
            this.lbColas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbColas.Location = new System.Drawing.Point(4, 6);
            this.lbColas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbColas.Name = "lbColas";
            this.lbColas.Size = new System.Drawing.Size(224, 17);
            this.lbColas.TabIndex = 1;
            this.lbColas.Text = "Disciplina de manejo de colas";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.npProcesos);
            this.panel4.Controls.Add(this.lbNHilos);
            this.panel4.Location = new System.Drawing.Point(539, 31);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(136, 243);
            this.panel4.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 6);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Procesos";
            // 
            // npProcesos
            // 
            this.npProcesos.Location = new System.Drawing.Point(62, 65);
            this.npProcesos.Margin = new System.Windows.Forms.Padding(4);
            this.npProcesos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.npProcesos.Name = "npProcesos";
            this.npProcesos.Size = new System.Drawing.Size(48, 22);
            this.npProcesos.TabIndex = 9;
            this.npProcesos.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lbNHilos
            // 
            this.lbNHilos.AutoSize = true;
            this.lbNHilos.Location = new System.Drawing.Point(3, 32);
            this.lbNHilos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNHilos.Name = "lbNHilos";
            this.lbNHilos.Size = new System.Drawing.Size(107, 17);
            this.lbNHilos.TabIndex = 5;
            this.lbNHilos.Text = "Num. procesos:";
            // 
            // pnPuerto
            // 
            this.pnPuerto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnPuerto.Controls.Add(this.dataGridView1);
            this.pnPuerto.Controls.Add(this.label6);
            this.pnPuerto.Controls.Add(this.nuPuertos);
            this.pnPuerto.Controls.Add(this.label7);
            this.pnPuerto.Location = new System.Drawing.Point(13, 282);
            this.pnPuerto.Margin = new System.Windows.Forms.Padding(4);
            this.pnPuerto.Name = "pnPuerto";
            this.pnPuerto.Size = new System.Drawing.Size(349, 257);
            this.pnPuerto.TabIndex = 14;
            this.pnPuerto.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(129, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(202, 228);
            this.dataGridView1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Puertos";
            // 
            // nuPuertos
            // 
            this.nuPuertos.Location = new System.Drawing.Point(67, 64);
            this.nuPuertos.Margin = new System.Windows.Forms.Padding(4);
            this.nuPuertos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuPuertos.Name = "nuPuertos";
            this.nuPuertos.Size = new System.Drawing.Size(48, 22);
            this.nuPuertos.TabIndex = 9;
            this.nuPuertos.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 43);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Num. puertos:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(683, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.rbFCM);
            this.panel5.Controls.Add(this.rbFCA);
            this.panel5.Controls.Add(this.rbFCT);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(41, 32);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(229, 100);
            this.panel5.TabIndex = 16;
            // 
            // rbFCA
            // 
            this.rbFCA.AutoSize = true;
            this.rbFCA.Location = new System.Drawing.Point(82, 41);
            this.rbFCA.Name = "rbFCA";
            this.rbFCA.Size = new System.Drawing.Size(75, 21);
            this.rbFCA.TabIndex = 2;
            this.rbFCA.Text = "archivo";
            this.rbFCA.UseVisualStyleBackColor = true;
            // 
            // rbFCT
            // 
            this.rbFCT.AutoSize = true;
            this.rbFCT.Checked = true;
            this.rbFCT.Location = new System.Drawing.Point(82, 14);
            this.rbFCT.Name = "rbFCT";
            this.rbFCT.Size = new System.Drawing.Size(59, 21);
            this.rbFCT.TabIndex = 1;
            this.rbFCT.TabStop = true;
            this.rbFCT.Text = "texto";
            this.rbFCT.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Contenido";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.npFNmax);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Location = new System.Drawing.Point(390, 282);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(285, 257);
            this.panel6.TabIndex = 13;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Formato";
            // 
            // rbFCM
            // 
            this.rbFCM.AutoSize = true;
            this.rbFCM.Location = new System.Drawing.Point(82, 68);
            this.rbFCM.Name = "rbFCM";
            this.rbFCM.Size = new System.Drawing.Size(96, 21);
            this.rbFCM.TabIndex = 3;
            this.rbFCM.Text = "multimedia";
            this.rbFCM.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.rbFLV);
            this.panel7.Controls.Add(this.rbFLF);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(41, 141);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(229, 71);
            this.panel7.TabIndex = 3;
            // 
            // rbFLV
            // 
            this.rbFLV.AutoSize = true;
            this.rbFLV.Location = new System.Drawing.Point(82, 41);
            this.rbFLV.Name = "rbFLV";
            this.rbFLV.Size = new System.Drawing.Size(79, 21);
            this.rbFLV.TabIndex = 2;
            this.rbFLV.Text = "variable";
            this.rbFLV.UseVisualStyleBackColor = true;
            // 
            // rbFLF
            // 
            this.rbFLF.AutoSize = true;
            this.rbFLF.Checked = true;
            this.rbFLF.Location = new System.Drawing.Point(82, 14);
            this.rbFLF.Name = "rbFLF";
            this.rbFLF.Size = new System.Drawing.Size(47, 21);
            this.rbFLF.TabIndex = 1;
            this.rbFLF.TabStop = true;
            this.rbFLF.Text = "fijo";
            this.rbFLF.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Largo";
            // 
            // npFNmax
            // 
            this.npFNmax.Location = new System.Drawing.Point(222, 224);
            this.npFNmax.Margin = new System.Windows.Forms.Padding(4);
            this.npFNmax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.npFNmax.Name = "npFNmax";
            this.npFNmax.Size = new System.Drawing.Size(48, 22);
            this.npFNmax.TabIndex = 11;
            this.npFNmax.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 227);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Tamaño cola de mensajes:";
            // 
            // FGenerarTxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 556);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnPuerto);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnColas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FGenerarTxt";
            this.Text = "FGenerarTxt";
            this.Load += new System.EventHandler(this.FGenerarTxt_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnSincr.ResumeLayout(false);
            this.pnSincr.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnColas.ResumeLayout(false);
            this.pnColas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npTamColaMen)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npProcesos)).EndInit();
            this.pnPuerto.ResumeLayout(false);
            this.pnPuerto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuPuertos)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npFNmax)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnSincr;
        private System.Windows.Forms.Label lbSincr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbSRP;
        private System.Windows.Forms.RadioButton rbSRNB;
        private System.Windows.Forms.RadioButton rbSRB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbSSNB;
        private System.Windows.Forms.RadioButton rbSSB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbD2;
        private System.Windows.Forms.RadioButton rbD1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton rbDD;
        private System.Windows.Forms.Panel pnColas;
        private System.Windows.Forms.RadioButton rbDisPrioridad;
        private System.Windows.Forms.RadioButton rbDisFIFO;
        private System.Windows.Forms.NumericUpDown npTamColaMen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbColas;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown npProcesos;
        private System.Windows.Forms.Label lbNHilos;
        private System.Windows.Forms.Panel pnPuerto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nuPuertos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rbFCM;
        private System.Windows.Forms.RadioButton rbFCA;
        private System.Windows.Forms.RadioButton rbFCT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.NumericUpDown npFNmax;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RadioButton rbFLV;
        private System.Windows.Forms.RadioButton rbFLF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
    }
}