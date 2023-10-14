namespace pbo_gui_task
{
    public partial class dataPertanian : Form
    {
        List<DataTanaman> listTanaman = new List<DataTanaman>();
        public dataPertanian()
        {
            InitializeComponent();
            listTanaman.Add(new DataTanaman()
            {
                NamaTanaman = "Padi",
                LuasLahan = 10,
                HasilPanen = 30,
                HargaJual = 5_000_000,
            });

            dataGridView1.DataSource = listTanaman;

            dataGridView1.Columns[0].HeaderText = "Nama Tanaman";
            dataGridView1.Columns[1].HeaderText = "Luas Lahan (Hektar)";
            dataGridView1.Columns[2].HeaderText = "Hasil Panen (Ton)";
            dataGridView1.Columns[3].HeaderText = "Harga Jual / Ton";
        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            using (FormDialogInput formInput = new FormDialogInput())
            {
                if (formInput.ShowDialog() == DialogResult.OK)
                {
                    DataTanaman newTanaman = formInput.GetDataTanaman();
                    listTanaman.Add(newTanaman);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = listTanaman;



                }
            }
        }
    }
}