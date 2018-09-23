namespace proyecto1SO
{
    partial class Form1
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
            this.btConfig = new System.Windows.Forms.Button();
            this.listPids = new System.Windows.Forms.ListBox();
            this.lbPids = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btProcesar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
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
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnMen.SuspendLayout();
            this.rgOperaciones.SuspendLayout();
            this.cnRece.SuspendLayout();
            this.cnEmis.SuspendLayout();
            this.pnPrio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuPrio)).BeginInit();
            this.SuspendLayout();
            // 
            // btConfig
            // 
            this.btConfig.BackgroundImage = global::proyecto1SO.Properties.Resources.config2;
            this.btConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btConfig.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btConfig.Location = new System.Drawing.Point(659, 14);
            this.btConfig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btConfig.Name = "btConfig";
            this.btConfig.Size = new System.Drawing.Size(108, 52);
            this.btConfig.TabIndex = 0;
            this.btConfig.Text = "Configurar";
            this.btConfig.UseVisualStyleBackColor = true;
            this.btConfig.Click += new System.EventHandler(this.btConfig_Click);
            // 
            // listPids
            // 
            this.listPids.FormattingEnabled = true;
            this.listPids.ItemHeight = 20;
            this.listPids.Location = new System.Drawing.Point(537, 35);
            this.listPids.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listPids.Name = "listPids";
            this.listPids.ScrollAlwaysVisible = true;
            this.listPids.Size = new System.Drawing.Size(178, 164);
            this.listPids.TabIndex = 1;
            // 
            // lbPids
            // 
            this.lbPids.AutoSize = true;
            this.lbPids.Location = new System.Drawing.Point(533, 10);
            this.lbPids.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPids.Name = "lbPids";
            this.lbPids.Size = new System.Drawing.Size(75, 20);
            this.lbPids.TabIndex = 2;
            this.lbPids.Text = "Procesos";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.btProcesar);
            this.panel3.Controls.Add(this.listPids);
            this.panel3.Controls.Add(this.lbPids);
            this.panel3.Location = new System.Drawing.Point(12, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(755, 400);
            this.panel3.TabIndex = 7;
            // 
            // btProcesar
            // 
            this.btProcesar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcesar.Location = new System.Drawing.Point(13, 323);
            this.btProcesar.Name = "btProcesar";
            this.btProcesar.Size = new System.Drawing.Size(136, 61);
            this.btProcesar.TabIndex = 3;
            this.btProcesar.Text = "Procesar";
            this.btProcesar.UseVisualStyleBackColor = true;
            this.btProcesar.Click += new System.EventHandler(this.btProcesar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "MESSAGE PASSING";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pnMen);
            this.panel1.Controls.Add(this.rgOperaciones);
            this.panel1.Controls.Add(this.cnRece);
            this.panel1.Controls.Add(this.cnEmis);
            this.panel1.Controls.Add(this.pnPrio);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 288);
            this.panel1.TabIndex = 11;
            // 
            // pnMen
            // 
            this.pnMen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMen.Controls.Add(this.tbTamanio);
            this.pnMen.Controls.Add(this.label4);
            this.pnMen.Controls.Add(this.tbMens);
            this.pnMen.Controls.Add(this.lbMens);
            this.pnMen.Location = new System.Drawing.Point(11, 162);
            this.pnMen.Name = "pnMen";
            this.pnMen.Size = new System.Drawing.Size(451, 114);
            this.pnMen.TabIndex = 15;
            // 
            // tbTamanio
            // 
            this.tbTamanio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTamanio.Location = new System.Drawing.Point(347, 40);
            this.tbTamanio.Name = "tbTamanio";
            this.tbTamanio.ReadOnly = true;
            this.tbTamanio.Size = new System.Drawing.Size(88, 26);
            this.tbTamanio.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tamaño";
            // 
            // tbMens
            // 
            this.tbMens.Location = new System.Drawing.Point(4, 40);
            this.tbMens.Name = "tbMens";
            this.tbMens.Size = new System.Drawing.Size(332, 58);
            this.tbMens.TabIndex = 12;
            this.tbMens.Text = "";
            this.tbMens.TextChanged += new System.EventHandler(this.tbMens_TextChanged);
            // 
            // lbMens
            // 
            this.lbMens.AutoSize = true;
            this.lbMens.Location = new System.Drawing.Point(4, 17);
            this.lbMens.Name = "lbMens";
            this.lbMens.Size = new System.Drawing.Size(69, 20);
            this.lbMens.TabIndex = 11;
            this.lbMens.Text = "Mensaje";
            // 
            // rgOperaciones
            // 
            this.rgOperaciones.Controls.Add(this.rbSend);
            this.rgOperaciones.Controls.Add(this.rbReceive);
            this.rgOperaciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rgOperaciones.Location = new System.Drawing.Point(23, 9);
            this.rgOperaciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rgOperaciones.Name = "rgOperaciones";
            this.rgOperaciones.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rgOperaciones.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rgOperaciones.Size = new System.Drawing.Size(249, 58);
            this.rgOperaciones.TabIndex = 14;
            this.rgOperaciones.TabStop = false;
            // 
            // rbSend
            // 
            this.rbSend.AutoSize = true;
            this.rbSend.Checked = true;
            this.rbSend.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbSend.Location = new System.Drawing.Point(4, 24);
            this.rbSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbSend.Name = "rbSend";
            this.rbSend.Size = new System.Drawing.Size(72, 29);
            this.rbSend.TabIndex = 1;
            this.rbSend.TabStop = true;
            this.rbSend.Text = "Send";
            this.rbSend.UseVisualStyleBackColor = true;
            // 
            // rbReceive
            // 
            this.rbReceive.AutoSize = true;
            this.rbReceive.Dock = System.Windows.Forms.DockStyle.Right;
            this.rbReceive.Location = new System.Drawing.Point(154, 24);
            this.rbReceive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbReceive.Name = "rbReceive";
            this.rbReceive.Size = new System.Drawing.Size(91, 29);
            this.rbReceive.TabIndex = 2;
            this.rbReceive.Text = "Receive";
            this.rbReceive.UseVisualStyleBackColor = true;
            // 
            // cnRece
            // 
            this.cnRece.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cnRece.Controls.Add(this.tbRece);
            this.cnRece.Controls.Add(this.label2);
            this.cnRece.Location = new System.Drawing.Point(245, 75);
            this.cnRece.Name = "cnRece";
            this.cnRece.Size = new System.Drawing.Size(217, 81);
            this.cnRece.TabIndex = 13;
            // 
            // tbRece
            // 
            this.tbRece.Location = new System.Drawing.Point(3, 40);
            this.tbRece.Name = "tbRece";
            this.tbRece.Size = new System.Drawing.Size(178, 26);
            this.tbRece.TabIndex = 5;
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Receptor";
            // 
            // cnEmis
            // 
            this.cnEmis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cnEmis.Controls.Add(this.tbEmis);
            this.cnEmis.Controls.Add(this.label1);
            this.cnEmis.Location = new System.Drawing.Point(11, 75);
            this.cnEmis.Name = "cnEmis";
            this.cnEmis.Size = new System.Drawing.Size(217, 81);
            this.cnEmis.TabIndex = 12;
            // 
            // tbEmis
            // 
            this.tbEmis.Location = new System.Drawing.Point(3, 40);
            this.tbEmis.Name = "tbEmis";
            this.tbEmis.Size = new System.Drawing.Size(178, 26);
            this.tbEmis.TabIndex = 5;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Emisor";
            // 
            // pnPrio
            // 
            this.pnPrio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnPrio.Controls.Add(this.nuPrio);
            this.pnPrio.Controls.Add(this.label5);
            this.pnPrio.Location = new System.Drawing.Point(309, 23);
            this.pnPrio.Name = "pnPrio";
            this.pnPrio.Size = new System.Drawing.Size(153, 46);
            this.pnPrio.TabIndex = 11;
            // 
            // nuPrio
            // 
            this.nuPrio.Location = new System.Drawing.Point(87, 9);
            this.nuPrio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nuPrio.Name = "nuPrio";
            this.nuPrio.Size = new System.Drawing.Size(54, 26);
            this.nuPrio.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Prioridad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 498);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btConfig);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "git";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConfig;
        private System.Windows.Forms.ListBox listPids;
        private System.Windows.Forms.Label lbPids;
        private System.Windows.Forms.Panel panel3;
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
    }
}

