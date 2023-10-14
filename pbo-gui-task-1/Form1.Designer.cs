namespace pbo_gui_task_1
{
    partial class dataPertanian
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            dataTanamanBindingSource = new BindingSource(components);
            btnAddData = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataTanamanBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(776, 386);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataTanamanBindingSource
            // 
            dataTanamanBindingSource.DataSource = typeof(DataTanaman);
            // 
            // btnAddData
            // 
            btnAddData.Location = new Point(322, 404);
            btnAddData.Name = "btnAddData";
            btnAddData.Size = new Size(186, 34);
            btnAddData.TabIndex = 1;
            btnAddData.Text = "+ Tambah Data";
            btnAddData.UseVisualStyleBackColor = true;
            btnAddData.Click += btnAddData_Click;
            // 
            // dataPertanian
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddData);
            Controls.Add(dataGridView1);
            Name = "dataPertanian";
            Text = "Data Pertanian 2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataTanamanBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAddData;
        private BindingSource dataTanamanBindingSource;
        private DataGridView dataGridView1;
    }
}