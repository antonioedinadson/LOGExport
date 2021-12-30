
namespace LOGExport {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BTNOpen = new System.Windows.Forms.Button();
            this.BTNLoad = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.Location = new System.Drawing.Point(30, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(666, 32);
            this.textBox1.TabIndex = 1;
            // 
            // BTNOpen
            // 
            this.BTNOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTNOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNOpen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BTNOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNOpen.ForeColor = System.Drawing.SystemColors.GrayText;
            this.BTNOpen.Location = new System.Drawing.Point(401, 106);
            this.BTNOpen.Name = "BTNOpen";
            this.BTNOpen.Padding = new System.Windows.Forms.Padding(5);
            this.BTNOpen.Size = new System.Drawing.Size(133, 35);
            this.BTNOpen.TabIndex = 9999;
            this.BTNOpen.Text = "OPEN FOLDER";
            this.BTNOpen.UseVisualStyleBackColor = true;
            this.BTNOpen.Click += new System.EventHandler(this.BTNOpen_Click);
            // 
            // BTNLoad
            // 
            this.BTNLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BTNLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNLoad.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BTNLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLoad.ForeColor = System.Drawing.SystemColors.GrayText;
            this.BTNLoad.Location = new System.Drawing.Point(563, 106);
            this.BTNLoad.Name = "BTNLoad";
            this.BTNLoad.Padding = new System.Windows.Forms.Padding(5);
            this.BTNLoad.Size = new System.Drawing.Size(133, 35);
            this.BTNLoad.TabIndex = 99999;
            this.BTNLoad.Text = "LOAD LIST";
            this.BTNLoad.UseVisualStyleBackColor = true;
            this.BTNLoad.Click += new System.EventHandler(this.BTNLoad_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 165);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(725, 5);
            this.progressBar1.TabIndex = 100000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(725, 170);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.BTNLoad);
            this.Controls.Add(this.BTNOpen);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGExport";            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BTNOpen;
        private System.Windows.Forms.Button BTNLoad;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

