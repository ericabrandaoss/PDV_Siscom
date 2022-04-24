
namespace PDV.Siscom
{
    partial class frmVendaPdv
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.pnlRodape = new System.Windows.Forms.Panel();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.pnlComponentes = new System.Windows.Forms.Panel();
            this.pnbBotoes = new System.Windows.Forms.Panel();
            this.pnlOperacao = new System.Windows.Forms.Panel();
            this.pnlDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.Navy;
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 43);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(1008, 583);
            this.pnlGrid.TabIndex = 0;
            // 
            // pnlRodape
            // 
            this.pnlRodape.BackColor = System.Drawing.Color.Yellow;
            this.pnlRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlRodape.Location = new System.Drawing.Point(0, 626);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new System.Drawing.Size(1008, 103);
            this.pnlRodape.TabIndex = 1;
            // 
            // pnlDados
            // 
            this.pnlDados.BackColor = System.Drawing.Color.Lime;
            this.pnlDados.Controls.Add(this.pnlComponentes);
            this.pnlDados.Controls.Add(this.pnbBotoes);
            this.pnlDados.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDados.Location = new System.Drawing.Point(313, 43);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(695, 583);
            this.pnlDados.TabIndex = 1;
            // 
            // pnlComponentes
            // 
            this.pnlComponentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlComponentes.Location = new System.Drawing.Point(0, 0);
            this.pnlComponentes.Name = "pnlComponentes";
            this.pnlComponentes.Size = new System.Drawing.Size(695, 303);
            this.pnlComponentes.TabIndex = 0;
            // 
            // pnbBotoes
            // 
            this.pnbBotoes.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pnbBotoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnbBotoes.Location = new System.Drawing.Point(0, 303);
            this.pnbBotoes.Name = "pnbBotoes";
            this.pnbBotoes.Size = new System.Drawing.Size(695, 280);
            this.pnbBotoes.TabIndex = 1;
            // 
            // pnlOperacao
            // 
            this.pnlOperacao.BackColor = System.Drawing.Color.Red;
            this.pnlOperacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperacao.Location = new System.Drawing.Point(0, 0);
            this.pnlOperacao.Name = "pnlOperacao";
            this.pnlOperacao.Size = new System.Drawing.Size(1008, 43);
            this.pnlOperacao.TabIndex = 1;
            // 
            // frmVendaPdv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.pnlDados);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlRodape);
            this.Controls.Add(this.pnlOperacao);
            this.Name = "frmVendaPdv";
            this.Text = "Venda Rápida";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlDados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.Panel pnlRodape;
        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.Panel pnlOperacao;
        private System.Windows.Forms.Panel pnbBotoes;
        private System.Windows.Forms.Panel pnlComponentes;
    }
}

