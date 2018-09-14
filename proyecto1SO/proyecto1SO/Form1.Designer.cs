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
            this.SuspendLayout();
            // 
            // btConfig
            // 
            this.btConfig.BackgroundImage = global::proyecto1SO.Properties.Resources.config2;
            this.btConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btConfig.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btConfig.Location = new System.Drawing.Point(363, 12);
            this.btConfig.Name = "btConfig";
            this.btConfig.Size = new System.Drawing.Size(72, 34);
            this.btConfig.TabIndex = 0;
            this.btConfig.Text = "Configurar";
            this.btConfig.UseVisualStyleBackColor = true;
            this.btConfig.Click += new System.EventHandler(this.btConfig_Click);
            // 
            // listPids
            // 
            this.listPids.FormattingEnabled = true;
            this.listPids.Location = new System.Drawing.Point(15, 25);
            this.listPids.Name = "listPids";
            this.listPids.ScrollAlwaysVisible = true;
            this.listPids.Size = new System.Drawing.Size(120, 95);
            this.listPids.TabIndex = 1;
            // 
            // lbPids
            // 
            this.lbPids.AutoSize = true;
            this.lbPids.Location = new System.Drawing.Point(12, 9);
            this.lbPids.Name = "lbPids";
            this.lbPids.Size = new System.Drawing.Size(51, 13);
            this.lbPids.TabIndex = 2;
            this.lbPids.Text = "Procesos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 272);
            this.Controls.Add(this.lbPids);
            this.Controls.Add(this.listPids);
            this.Controls.Add(this.btConfig);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "git";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConfig;
        private System.Windows.Forms.ListBox listPids;
        private System.Windows.Forms.Label lbPids;
    }
}

