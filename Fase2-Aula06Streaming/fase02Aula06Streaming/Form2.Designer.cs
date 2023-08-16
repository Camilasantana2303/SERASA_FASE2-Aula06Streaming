
namespace Fase2_Aula06Streaming
{
    partial class Form2
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
            this.btnAssistir = new System.Windows.Forms.Button();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.wvVideo = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.imgFundo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.wvVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFundo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAssistir
            // 
            this.btnAssistir.BackColor = System.Drawing.Color.White;
            this.btnAssistir.Location = new System.Drawing.Point(46, 279);
            this.btnAssistir.Name = "btnAssistir";
            this.btnAssistir.Size = new System.Drawing.Size(80, 26);
            this.btnAssistir.TabIndex = 2;
            this.btnAssistir.Text = "Assistir";
            this.btnAssistir.UseVisualStyleBackColor = false;
            this.btnAssistir.Click += new System.EventHandler(this.btnAssistir_Click);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(58, 335);
            this.lblDescricao.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(138, 13);
            this.lblDescricao.TabIndex = 3;
            this.lblDescricao.Text = "DESCRIÇÃO LONGA AQUI";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(43, 247);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(64, 17);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "TÍTULO";
            // 
            // wvVideo
            // 
            this.wvVideo.AllowExternalDrop = true;
            this.wvVideo.CreationProperties = null;
            this.wvVideo.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wvVideo.Location = new System.Drawing.Point(2, 0);
            this.wvVideo.Name = "wvVideo";
            this.wvVideo.Size = new System.Drawing.Size(825, 523);
            this.wvVideo.TabIndex = 5;
            this.wvVideo.Visible = false;
            this.wvVideo.ZoomFactor = 1D;
            // 
            // imgFundo
            // 
            this.imgFundo.Location = new System.Drawing.Point(12, 12);
            this.imgFundo.Name = "imgFundo";
            this.imgFundo.Size = new System.Drawing.Size(790, 453);
            this.imgFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFundo.TabIndex = 0;
            this.imgFundo.TabStop = false;
            this.imgFundo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 525);
            this.Controls.Add(this.wvVideo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.btnAssistir);
            this.Controls.Add(this.imgFundo);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wvVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFundo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgFundo;
        private System.Windows.Forms.Button btnAssistir;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblTitulo;
        private Microsoft.Web.WebView2.WinForms.WebView2 wvVideo;
    }
}