namespace NomesDosMeses
{
    partial class NomesDosMeses
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
            this.label1 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.proximo = new System.Windows.Forms.Button();
            this.voltar = new System.Windows.Forms.Button();
            this.lblMonth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 54);
            this.label1.TabIndex = 18;
            this.label1.Text = "Meses";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // reset
            // 
            this.reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.Location = new System.Drawing.Point(695, 84);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(156, 30);
            this.reset.TabIndex = 17;
            this.reset.Text = "RESETAR";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // proximo
            // 
            this.proximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.05F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proximo.Location = new System.Drawing.Point(776, 40);
            this.proximo.Name = "proximo";
            this.proximo.Size = new System.Drawing.Size(75, 30);
            this.proximo.TabIndex = 15;
            this.proximo.Text = "Próximo ";
            this.proximo.UseVisualStyleBackColor = true;
            this.proximo.Click += new System.EventHandler(this.proximo_Click);
            // 
            // voltar
            // 
            this.voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar.Location = new System.Drawing.Point(695, 40);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(75, 30);
            this.voltar.TabIndex = 15;
            this.voltar.Text = "Anterior";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Document, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(207, 60);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(0, 37);
            this.lblMonth.TabIndex = 14;
            this.lblMonth.Tag = "";
            this.lblMonth.Click += new System.EventHandler(this.lblDays_Click);
            // 
            // NomesDosMeses
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.RowHeader;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(892, 141);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.proximo);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.lblMonth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(908, 180);
            this.MinimizeBox = false;
            this.Name = "NomesDosMeses";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nomes dos Meses - Lucas P";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NamesOfMonths_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button proximo;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Label lblMonth;
    }
}

