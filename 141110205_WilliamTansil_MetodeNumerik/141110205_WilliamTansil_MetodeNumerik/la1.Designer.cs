namespace _141110205_WilliamTansil_MetodeNumerik
{
    partial class la1
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
            this.N = new System.Windows.Forms.TextBox();
            this.hasil = new System.Windows.Forms.DataGridView();
            this.Iterasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Tracehold = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.Show = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SAwal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hasil)).BeginInit();
            this.SuspendLayout();
            // 
            // N
            // 
            this.N.Location = new System.Drawing.Point(47, 14);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(65, 20);
            this.N.TabIndex = 0;
            // 
            // hasil
            // 
            this.hasil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hasil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Iterasi,
            this.S,
            this.T,
            this.Error});
            this.hasil.Location = new System.Drawing.Point(12, 63);
            this.hasil.Name = "hasil";
            this.hasil.Size = new System.Drawing.Size(385, 183);
            this.hasil.TabIndex = 2;
            // 
            // Iterasi
            // 
            this.Iterasi.FillWeight = 10F;
            this.Iterasi.HeaderText = "Iterasi";
            this.Iterasi.Name = "Iterasi";
            this.Iterasi.Width = 40;
            // 
            // S
            // 
            this.S.HeaderText = "S";
            this.S.Name = "S";
            // 
            // T
            // 
            this.T.HeaderText = "T";
            this.T.Name = "T";
            // 
            // Error
            // 
            this.Error.HeaderText = "T-S";
            this.Error.Name = "Error";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "N";
            // 
            // Tracehold
            // 
            this.Tracehold.Location = new System.Drawing.Point(178, 14);
            this.Tracehold.Name = "Tracehold";
            this.Tracehold.Size = new System.Drawing.Size(63, 20);
            this.Tracehold.TabIndex = 0;
            this.Tracehold.Text = "0.00000001";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tracehold";
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(264, 12);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(133, 44);
            this.submit.TabIndex = 4;
            this.submit.Text = "Hasil";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(178, 36);
            this.Show.Name = "Show";
            this.Show.ReadOnly = true;
            this.Show.Size = new System.Drawing.Size(63, 20);
            this.Show.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hasil";
            // 
            // SAwal
            // 
            this.SAwal.Location = new System.Drawing.Point(47, 36);
            this.SAwal.Name = "SAwal";
            this.SAwal.Size = new System.Drawing.Size(65, 20);
            this.SAwal.TabIndex = 0;
            this.SAwal.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "S awal";
            // 
            // la1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 256);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hasil);
            this.Controls.Add(this.SAwal);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.Tracehold);
            this.Controls.Add(this.N);
            this.Name = "la1";
            this.Text = "latihan a1";
            this.Load += new System.EventHandler(this.la1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hasil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox N;
        private System.Windows.Forms.DataGridView hasil;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iterasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn S;
        private System.Windows.Forms.DataGridViewTextBoxColumn T;
        private System.Windows.Forms.DataGridViewTextBoxColumn Error;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tracehold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox Show;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SAwal;
        private System.Windows.Forms.Label label4;
    }
}

