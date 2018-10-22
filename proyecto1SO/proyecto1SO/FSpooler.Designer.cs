namespace proyecto1SO
{
    partial class FSpooler
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
            this.cbApps = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbImps = new System.Windows.Forms.ComboBox();
            this.btAddApp = new System.Windows.Forms.Button();
            this.btAddImp = new System.Windows.Forms.Button();
            this.btEstado = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbModo = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rbBatch = new System.Windows.Forms.RadioButton();
            this.rbInter = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btImprimir = new System.Windows.Forms.Button();
            this.pnMain = new System.Windows.Forms.Panel();
            this.lbArch = new System.Windows.Forms.Label();
            this.tbRutaArch = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.tbPrio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.gbEstImp = new System.Windows.Forms.GroupBox();
            this.rbEstS = new System.Windows.Forms.RadioButton();
            this.rbEstA = new System.Windows.Forms.RadioButton();
            this.btBusArch = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.gbModo.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.gbEstImp.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbApps
            // 
            this.cbApps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbApps.FormattingEnabled = true;
            this.cbApps.Location = new System.Drawing.Point(24, 34);
            this.cbApps.Name = "cbApps";
            this.cbApps.Size = new System.Drawing.Size(170, 21);
            this.cbApps.TabIndex = 1;
            this.cbApps.SelectedIndexChanged += new System.EventHandler(this.cbApps_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aplicaciones:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Impresoras:";
            // 
            // cbImps
            // 
            this.cbImps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbImps.FormattingEnabled = true;
            this.cbImps.Location = new System.Drawing.Point(24, 153);
            this.cbImps.Name = "cbImps";
            this.cbImps.Size = new System.Drawing.Size(170, 21);
            this.cbImps.TabIndex = 3;
            this.cbImps.SelectedIndexChanged += new System.EventHandler(this.cbImps_SelectedIndexChanged);
            // 
            // btAddApp
            // 
            this.btAddApp.Location = new System.Drawing.Point(24, 61);
            this.btAddApp.Name = "btAddApp";
            this.btAddApp.Size = new System.Drawing.Size(67, 23);
            this.btAddApp.TabIndex = 5;
            this.btAddApp.Text = "Agregar";
            this.btAddApp.UseVisualStyleBackColor = true;
            this.btAddApp.Click += new System.EventHandler(this.btAddApp_Click);
            // 
            // btAddImp
            // 
            this.btAddImp.Location = new System.Drawing.Point(24, 180);
            this.btAddImp.Name = "btAddImp";
            this.btAddImp.Size = new System.Drawing.Size(85, 23);
            this.btAddImp.TabIndex = 6;
            this.btAddImp.Text = "Agregar";
            this.btAddImp.UseVisualStyleBackColor = true;
            // 
            // btEstado
            // 
            this.btEstado.Location = new System.Drawing.Point(112, 180);
            this.btEstado.Name = "btEstado";
            this.btEstado.Size = new System.Drawing.Size(85, 23);
            this.btEstado.TabIndex = 7;
            this.btEstado.Text = "Historial";
            this.btEstado.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gbModo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 63);
            this.panel2.TabIndex = 10;
            // 
            // gbModo
            // 
            this.gbModo.Controls.Add(this.label6);
            this.gbModo.Controls.Add(this.rbBatch);
            this.gbModo.Controls.Add(this.rbInter);
            this.gbModo.Location = new System.Drawing.Point(139, 11);
            this.gbModo.Margin = new System.Windows.Forms.Padding(2);
            this.gbModo.Name = "gbModo";
            this.gbModo.Padding = new System.Windows.Forms.Padding(2);
            this.gbModo.Size = new System.Drawing.Size(178, 46);
            this.gbModo.TabIndex = 9;
            this.gbModo.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Modo: ";
            // 
            // rbBatch
            // 
            this.rbBatch.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbBatch.AutoSize = true;
            this.rbBatch.BackColor = System.Drawing.SystemColors.Control;
            this.rbBatch.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbBatch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbBatch.Location = new System.Drawing.Point(126, 12);
            this.rbBatch.Margin = new System.Windows.Forms.Padding(2);
            this.rbBatch.Name = "rbBatch";
            this.rbBatch.Size = new System.Drawing.Size(45, 23);
            this.rbBatch.TabIndex = 1;
            this.rbBatch.Text = "Batch";
            this.rbBatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbBatch.UseVisualStyleBackColor = false;
            this.rbBatch.Click += new System.EventHandler(this.rbInter_Click);
            // 
            // rbInter
            // 
            this.rbInter.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbInter.AutoSize = true;
            this.rbInter.BackColor = System.Drawing.SystemColors.Control;
            this.rbInter.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbInter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbInter.Location = new System.Drawing.Point(59, 12);
            this.rbInter.Margin = new System.Windows.Forms.Padding(2);
            this.rbInter.Name = "rbInter";
            this.rbInter.Size = new System.Drawing.Size(67, 23);
            this.rbInter.TabIndex = 0;
            this.rbInter.Text = "Interactivo";
            this.rbInter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbInter.UseVisualStyleBackColor = false;
            this.rbInter.Click += new System.EventHandler(this.rbInter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Spooler";
            // 
            // btImprimir
            // 
            this.btImprimir.Location = new System.Drawing.Point(24, 219);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(170, 23);
            this.btImprimir.TabIndex = 11;
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.UseVisualStyleBackColor = true;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.gbEstImp);
            this.pnMain.Controls.Add(this.lbEstado);
            this.pnMain.Controls.Add(this.label4);
            this.pnMain.Controls.Add(this.tbPrio);
            this.pnMain.Controls.Add(this.btBusArch);
            this.pnMain.Controls.Add(this.lbArch);
            this.pnMain.Controls.Add(this.tbRutaArch);
            this.pnMain.Controls.Add(this.cbImps);
            this.pnMain.Controls.Add(this.btImprimir);
            this.pnMain.Controls.Add(this.cbApps);
            this.pnMain.Controls.Add(this.label1);
            this.pnMain.Controls.Add(this.btEstado);
            this.pnMain.Controls.Add(this.label2);
            this.pnMain.Controls.Add(this.btAddImp);
            this.pnMain.Controls.Add(this.btAddApp);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMain.Location = new System.Drawing.Point(0, 63);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(352, 305);
            this.pnMain.TabIndex = 12;
            this.pnMain.Visible = false;
            this.pnMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnMain_MouseMove);
            // 
            // lbArch
            // 
            this.lbArch.AutoSize = true;
            this.lbArch.Location = new System.Drawing.Point(24, 87);
            this.lbArch.Name = "lbArch";
            this.lbArch.Size = new System.Drawing.Size(120, 13);
            this.lbArch.TabIndex = 13;
            this.lbArch.Text = "Archivo de la aplicación";
            // 
            // tbRutaArch
            // 
            this.tbRutaArch.Location = new System.Drawing.Point(24, 103);
            this.tbRutaArch.Name = "tbRutaArch";
            this.tbRutaArch.Size = new System.Drawing.Size(154, 20);
            this.tbRutaArch.TabIndex = 12;
            this.tbRutaArch.Validating += new System.ComponentModel.CancelEventHandler(this.tbRutaArch_Validating);
            // 
            // openFile
            // 
            this.openFile.ReadOnlyChecked = true;
            this.openFile.ShowReadOnly = true;
            this.openFile.Title = "Seleccione el archivo de la aplicación:";
            // 
            // tbPrio
            // 
            this.tbPrio.BackColor = System.Drawing.Color.Gainsboro;
            this.tbPrio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPrio.Location = new System.Drawing.Point(203, 35);
            this.tbPrio.Name = "tbPrio";
            this.tbPrio.ReadOnly = true;
            this.tbPrio.Size = new System.Drawing.Size(48, 20);
            this.tbPrio.TabIndex = 15;
            this.tbPrio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Prioridad";
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Location = new System.Drawing.Point(200, 137);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(40, 13);
            this.lbEstado.TabIndex = 18;
            this.lbEstado.Text = "Estado";
            // 
            // gbEstImp
            // 
            this.gbEstImp.Controls.Add(this.rbEstS);
            this.gbEstImp.Controls.Add(this.rbEstA);
            this.gbEstImp.Location = new System.Drawing.Point(203, 153);
            this.gbEstImp.Margin = new System.Windows.Forms.Padding(2);
            this.gbEstImp.Name = "gbEstImp";
            this.gbEstImp.Padding = new System.Windows.Forms.Padding(2);
            this.gbEstImp.Size = new System.Drawing.Size(147, 21);
            this.gbEstImp.TabIndex = 19;
            this.gbEstImp.TabStop = false;
            // 
            // rbEstS
            // 
            this.rbEstS.AutoSize = true;
            this.rbEstS.BackColor = System.Drawing.SystemColors.Control;
            this.rbEstS.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbEstS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbEstS.Location = new System.Drawing.Point(62, 4);
            this.rbEstS.Margin = new System.Windows.Forms.Padding(2);
            this.rbEstS.Name = "rbEstS";
            this.rbEstS.Size = new System.Drawing.Size(80, 17);
            this.rbEstS.TabIndex = 1;
            this.rbEstS.Text = "Suspendido";
            this.rbEstS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbEstS.UseVisualStyleBackColor = false;
            this.rbEstS.Click += new System.EventHandler(this.rbEstA_Click);
            // 
            // rbEstA
            // 
            this.rbEstA.AutoSize = true;
            this.rbEstA.BackColor = System.Drawing.SystemColors.Control;
            this.rbEstA.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbEstA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rbEstA.Location = new System.Drawing.Point(0, 4);
            this.rbEstA.Margin = new System.Windows.Forms.Padding(2);
            this.rbEstA.Name = "rbEstA";
            this.rbEstA.Size = new System.Drawing.Size(54, 17);
            this.rbEstA.TabIndex = 0;
            this.rbEstA.Text = "Activo";
            this.rbEstA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbEstA.UseVisualStyleBackColor = false;
            this.rbEstA.Click += new System.EventHandler(this.rbEstA_Click);
            // 
            // btBusArch
            // 
            this.btBusArch.AutoEllipsis = true;
            this.btBusArch.BackgroundImage = global::proyecto1SO.Properties.Resources._142336;
            this.btBusArch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btBusArch.Location = new System.Drawing.Point(174, 100);
            this.btBusArch.Name = "btBusArch";
            this.btBusArch.Size = new System.Drawing.Size(23, 23);
            this.btBusArch.TabIndex = 14;
            this.btBusArch.UseVisualStyleBackColor = true;
            this.btBusArch.Click += new System.EventHandler(this.btBusArch_Click);
            // 
            // FSpooler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 380);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.panel2);
            this.Name = "FSpooler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto 2: Spooler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FSpooler_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbModo.ResumeLayout(false);
            this.gbModo.PerformLayout();
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            this.gbEstImp.ResumeLayout(false);
            this.gbEstImp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbApps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbImps;
        private System.Windows.Forms.Button btAddApp;
        private System.Windows.Forms.Button btAddImp;
        private System.Windows.Forms.Button btEstado;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbModo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbBatch;
        private System.Windows.Forms.RadioButton rbInter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btImprimir;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Label lbArch;
        private System.Windows.Forms.TextBox tbRutaArch;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button btBusArch;
        private System.Windows.Forms.TextBox tbPrio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbEstImp;
        private System.Windows.Forms.RadioButton rbEstS;
        private System.Windows.Forms.RadioButton rbEstA;
        private System.Windows.Forms.Label lbEstado;
    }
}