
namespace orszag
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnHozzaadas = new System.Windows.Forms.Button();
            this.btnBeolvasas = new System.Windows.Forms.Button();
            this.btnKereses = new System.Windows.Forms.Button();
            this.btnRendezes = new System.Windows.Forms.Button();
            this.txtKereses = new System.Windows.Forms.TextBox();
            this.txtLakossag = new System.Windows.Forms.TextBox();
            this.txtFovaros = new System.Windows.Forms.TextBox();
            this.txtOrszag = new System.Windows.Forms.TextBox();
            this.dgvOrszagok = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrszagok)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHozzaadas
            // 
            this.btnHozzaadas.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHozzaadas.Location = new System.Drawing.Point(211, 156);
            this.btnHozzaadas.Name = "btnHozzaadas";
            this.btnHozzaadas.Size = new System.Drawing.Size(139, 36);
            this.btnHozzaadas.TabIndex = 0;
            this.btnHozzaadas.Text = "Hozzáadás";
            this.btnHozzaadas.UseVisualStyleBackColor = true;
            this.btnHozzaadas.Click += new System.EventHandler(this.btnHozzaadas_Click);
            // 
            // btnBeolvasas
            // 
            this.btnBeolvasas.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeolvasas.Location = new System.Drawing.Point(389, 156);
            this.btnBeolvasas.Name = "btnBeolvasas";
            this.btnBeolvasas.Size = new System.Drawing.Size(140, 36);
            this.btnBeolvasas.TabIndex = 1;
            this.btnBeolvasas.Text = "Beolvasás";
            this.btnBeolvasas.UseVisualStyleBackColor = true;
            this.btnBeolvasas.Click += new System.EventHandler(this.btnBeolvasas_Click);
            // 
            // btnKereses
            // 
            this.btnKereses.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKereses.Location = new System.Drawing.Point(569, 156);
            this.btnKereses.Name = "btnKereses";
            this.btnKereses.Size = new System.Drawing.Size(139, 36);
            this.btnKereses.TabIndex = 2;
            this.btnKereses.Text = "Keresés";
            this.btnKereses.UseVisualStyleBackColor = true;
            this.btnKereses.Click += new System.EventHandler(this.btnKereses_Click);
            // 
            // btnRendezes
            // 
            this.btnRendezes.Font = new System.Drawing.Font("Old English Text MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRendezes.Location = new System.Drawing.Point(41, 156);
            this.btnRendezes.Name = "btnRendezes";
            this.btnRendezes.Size = new System.Drawing.Size(140, 36);
            this.btnRendezes.TabIndex = 3;
            this.btnRendezes.Text = "Rendezés";
            this.btnRendezes.UseVisualStyleBackColor = true;
            this.btnRendezes.Click += new System.EventHandler(this.btnRendezes_Click_1);
            // 
            // txtKereses
            // 
            this.txtKereses.Location = new System.Drawing.Point(569, 130);
            this.txtKereses.Name = "txtKereses";
            this.txtKereses.Size = new System.Drawing.Size(139, 20);
            this.txtKereses.TabIndex = 4;
            // 
            // txtLakossag
            // 
            this.txtLakossag.Location = new System.Drawing.Point(389, 130);
            this.txtLakossag.Name = "txtLakossag";
            this.txtLakossag.Size = new System.Drawing.Size(140, 20);
            this.txtLakossag.TabIndex = 5;
            // 
            // txtFovaros
            // 
            this.txtFovaros.Location = new System.Drawing.Point(41, 130);
            this.txtFovaros.Name = "txtFovaros";
            this.txtFovaros.Size = new System.Drawing.Size(140, 20);
            this.txtFovaros.TabIndex = 6;
            // 
            // txtOrszag
            // 
            this.txtOrszag.Location = new System.Drawing.Point(211, 130);
            this.txtOrszag.Name = "txtOrszag";
            this.txtOrszag.Size = new System.Drawing.Size(139, 20);
            this.txtOrszag.TabIndex = 7;
            this.txtOrszag.TextChanged += new System.EventHandler(this.txtOrszag_TextChanged);
            // 
            // dgvOrszagok
            // 
            this.dgvOrszagok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrszagok.Location = new System.Drawing.Point(41, 209);
            this.dgvOrszagok.Name = "dgvOrszagok";
            this.dgvOrszagok.Size = new System.Drawing.Size(667, 208);
            this.dgvOrszagok.TabIndex = 8;
            this.dgvOrszagok.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrszagok_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(61, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ország neve:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gill Sans MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(245, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Főváros:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(408, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Lakosság (fő)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(604, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Keresés:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gill Sans MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label5.Location = new System.Drawing.Point(112, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(539, 67);
            this.label5.TabIndex = 13;
            this.label5.Text = "Országok nyilvántartása";
            this.label5.Click += new System.EventHandler(this.label5_Click_3);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(754, 466);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOrszagok);
            this.Controls.Add(this.txtOrszag);
            this.Controls.Add(this.txtFovaros);
            this.Controls.Add(this.txtLakossag);
            this.Controls.Add(this.txtKereses);
            this.Controls.Add(this.btnRendezes);
            this.Controls.Add(this.btnKereses);
            this.Controls.Add(this.btnBeolvasas);
            this.Controls.Add(this.btnHozzaadas);
            this.Name = "Form1";
            this.Text = "Országok nyilvántartása";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrszagok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnHozzaadas;
        private System.Windows.Forms.Button btnBeolvasas;
        private System.Windows.Forms.Button btnKereses;
        private System.Windows.Forms.Button btnRendezes;
        private System.Windows.Forms.TextBox txtKereses;
        private System.Windows.Forms.TextBox txtLakossag;
        private System.Windows.Forms.TextBox txtFovaros;
        private System.Windows.Forms.TextBox txtOrszag;
        private System.Windows.Forms.DataGridView dgvOrszagok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
