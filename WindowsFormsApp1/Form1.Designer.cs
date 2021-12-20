namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonara1 = new System.Windows.Forms.Button();
            this.buttongüncelle1 = new System.Windows.Forms.Button();
            this.buttonsil1 = new System.Windows.Forms.Button();
            this.buttonekle1 = new System.Windows.Forms.Button();
            this.textkategoriadı = new System.Windows.Forms.TextBox();
            this.kategoriadı = new System.Windows.Forms.Label();
            this.buttonlistele2 = new System.Windows.Forms.Button();
            this.textkategorino = new System.Windows.Forms.TextBox();
            this.kategorino = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonara1
            // 
            this.buttonara1.Location = new System.Drawing.Point(823, 265);
            this.buttonara1.Name = "buttonara1";
            this.buttonara1.Size = new System.Drawing.Size(143, 50);
            this.buttonara1.TabIndex = 36;
            this.buttonara1.Text = "ara";
            this.buttonara1.UseVisualStyleBackColor = true;
            // 
            // buttongüncelle1
            // 
            this.buttongüncelle1.Location = new System.Drawing.Point(823, 214);
            this.buttongüncelle1.Name = "buttongüncelle1";
            this.buttongüncelle1.Size = new System.Drawing.Size(143, 50);
            this.buttongüncelle1.TabIndex = 35;
            this.buttongüncelle1.Text = "güncelle";
            this.buttongüncelle1.UseVisualStyleBackColor = true;
            // 
            // buttonsil1
            // 
            this.buttonsil1.Location = new System.Drawing.Point(823, 163);
            this.buttonsil1.Name = "buttonsil1";
            this.buttonsil1.Size = new System.Drawing.Size(143, 50);
            this.buttonsil1.TabIndex = 34;
            this.buttonsil1.Text = "sil";
            this.buttonsil1.UseVisualStyleBackColor = true;
            // 
            // buttonekle1
            // 
            this.buttonekle1.Location = new System.Drawing.Point(823, 114);
            this.buttonekle1.Name = "buttonekle1";
            this.buttonekle1.Size = new System.Drawing.Size(143, 50);
            this.buttonekle1.TabIndex = 33;
            this.buttonekle1.Text = "ekle";
            this.buttonekle1.UseVisualStyleBackColor = true;
            this.buttonekle1.Click += new System.EventHandler(this.buttonekle1_Click);
            // 
            // textkategoriadı
            // 
            this.textkategoriadı.Location = new System.Drawing.Point(639, 100);
            this.textkategoriadı.Name = "textkategoriadı";
            this.textkategoriadı.Size = new System.Drawing.Size(161, 22);
            this.textkategoriadı.TabIndex = 32;
            this.textkategoriadı.TextChanged += new System.EventHandler(this.textkategoriadı_TextChanged);
            // 
            // kategoriadı
            // 
            this.kategoriadı.AutoSize = true;
            this.kategoriadı.Location = new System.Drawing.Point(556, 104);
            this.kategoriadı.Name = "kategoriadı";
            this.kategoriadı.Size = new System.Drawing.Size(78, 16);
            this.kategoriadı.TabIndex = 31;
            this.kategoriadı.Text = "kategori adı";
            // 
            // buttonlistele2
            // 
            this.buttonlistele2.Location = new System.Drawing.Point(823, 64);
            this.buttonlistele2.Name = "buttonlistele2";
            this.buttonlistele2.Size = new System.Drawing.Size(143, 50);
            this.buttonlistele2.TabIndex = 30;
            this.buttonlistele2.Text = "listele";
            this.buttonlistele2.UseVisualStyleBackColor = true;
            this.buttonlistele2.Click += new System.EventHandler(this.buttonlistele1_Click);
            // 
            // textkategorino
            // 
            this.textkategorino.Location = new System.Drawing.Point(639, 63);
            this.textkategorino.Name = "textkategorino";
            this.textkategorino.Size = new System.Drawing.Size(161, 22);
            this.textkategorino.TabIndex = 29;
            // 
            // kategorino
            // 
            this.kategorino.AutoSize = true;
            this.kategorino.Location = new System.Drawing.Point(556, 66);
            this.kategorino.Name = "kategorino";
            this.kategorino.Size = new System.Drawing.Size(77, 16);
            this.kategorino.TabIndex = 28;
            this.kategorino.Text = "kategori no:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(538, 409);
            this.dataGridView1.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 564);
            this.Controls.Add(this.buttonara1);
            this.Controls.Add(this.buttongüncelle1);
            this.Controls.Add(this.buttonsil1);
            this.Controls.Add(this.buttonekle1);
            this.Controls.Add(this.textkategoriadı);
            this.Controls.Add(this.kategoriadı);
            this.Controls.Add(this.buttonlistele2);
            this.Controls.Add(this.textkategorino);
            this.Controls.Add(this.kategorino);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonara1;
        private System.Windows.Forms.Button buttongüncelle1;
        private System.Windows.Forms.Button buttonsil1;
        private System.Windows.Forms.Button buttonekle1;
        private System.Windows.Forms.TextBox textkategoriadı;
        private System.Windows.Forms.Label kategoriadı;
        private System.Windows.Forms.Button buttonlistele2;
        private System.Windows.Forms.TextBox textkategorino;
        private System.Windows.Forms.Label kategorino;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

