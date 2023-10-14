namespace pbo_gui_task
{
    partial class FormDialogInput
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
            tbxNamaTanaman = new TextBox();
            tbxLuasLahan = new TextBox();
            tbxHasilPanen = new TextBox();
            tbxHargaJual = new TextBox();
            lblNamaTanaman = new Label();
            lblLuasLahan = new Label();
            lblHasilPanen = new Label();
            lblHargaJual = new Label();
            btnSimpan = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // tbxNamaTanaman
            // 
            tbxNamaTanaman.Location = new Point(298, 103);
            tbxNamaTanaman.Name = "tbxNamaTanaman";
            tbxNamaTanaman.Size = new Size(260, 31);
            tbxNamaTanaman.TabIndex = 0;
            // 
            // tbxLuasLahan
            // 
            tbxLuasLahan.Location = new Point(298, 149);
            tbxLuasLahan.Name = "tbxLuasLahan";
            tbxLuasLahan.Size = new Size(260, 31);
            tbxLuasLahan.TabIndex = 1;
            // 
            // tbxHasilPanen
            // 
            tbxHasilPanen.Location = new Point(298, 199);
            tbxHasilPanen.Name = "tbxHasilPanen";
            tbxHasilPanen.Size = new Size(260, 31);
            tbxHasilPanen.TabIndex = 2;
            // 
            // tbxHargaJual
            // 
            tbxHargaJual.Location = new Point(298, 251);
            tbxHargaJual.Name = "tbxHargaJual";
            tbxHargaJual.Size = new Size(260, 31);
            tbxHargaJual.TabIndex = 3;
            // 
            // lblNamaTanaman
            // 
            lblNamaTanaman.AutoSize = true;
            lblNamaTanaman.Location = new Point(141, 103);
            lblNamaTanaman.Name = "lblNamaTanaman";
            lblNamaTanaman.Size = new Size(143, 25);
            lblNamaTanaman.TabIndex = 4;
            lblNamaTanaman.Text = "Nama Tanaman :";
            // 
            // lblLuasLahan
            // 
            lblLuasLahan.AutoSize = true;
            lblLuasLahan.Location = new Point(141, 149);
            lblLuasLahan.Name = "lblLuasLahan";
            lblLuasLahan.Size = new Size(135, 25);
            lblLuasLahan.TabIndex = 5;
            lblLuasLahan.Text = "Luas Lahan (H) :";
            // 
            // lblHasilPanen
            // 
            lblHasilPanen.AutoSize = true;
            lblHasilPanen.Location = new Point(141, 199);
            lblHasilPanen.Name = "lblHasilPanen";
            lblHasilPanen.Size = new Size(135, 25);
            lblHasilPanen.TabIndex = 6;
            lblHasilPanen.Text = "Hasil Panen (T) :";
            // 
            // lblHargaJual
            // 
            lblHargaJual.AutoSize = true;
            lblHargaJual.Location = new Point(141, 251);
            lblHargaJual.Name = "lblHargaJual";
            lblHargaJual.Size = new Size(129, 25);
            lblHargaJual.TabIndex = 7;
            lblHargaJual.Text = "Harga Jual / T :";
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(358, 309);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(112, 34);
            btnSimpan.TabIndex = 8;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins SemiBold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(222, 9);
            label1.Name = "label1";
            label1.Size = new Size(366, 50);
            label1.TabIndex = 9;
            label1.Text = "Tambah Data Tanaman";
            // 
            // FormDialogInput
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnSimpan);
            Controls.Add(lblHargaJual);
            Controls.Add(lblHasilPanen);
            Controls.Add(lblLuasLahan);
            Controls.Add(lblNamaTanaman);
            Controls.Add(tbxHargaJual);
            Controls.Add(tbxHasilPanen);
            Controls.Add(tbxLuasLahan);
            Controls.Add(tbxNamaTanaman);
            Name = "FormDialogInput";
            Text = "FormDialogInput";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbxNamaTanaman;
        private TextBox tbxLuasLahan;
        private TextBox tbxHasilPanen;
        private TextBox tbxHargaJual;
        private Label lblNamaTanaman;
        private Label lblLuasLahan;
        private Label lblHasilPanen;
        private Label lblHargaJual;
        private Button btnSimpan;
        private Label label1;
    }
}