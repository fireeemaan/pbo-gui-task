using System.ComponentModel;

namespace pbo_gui_task_1
{
    public partial class dataPertanian : Form
    {

        List<DataTanaman> listTanaman = new List<DataTanaman>();

        public dataPertanian()
        {
            InitializeComponent();

            dataGridView1.Columns.Add("Nama Tanaman", "Nama Tanaman");
            dataGridView1.Columns.Add("Luas Lahan", "Luas Lahan(Hektar)");
            dataGridView1.Columns.Add("Hasil Panen", "Hasil Panen(Ton)");
            dataGridView1.Columns.Add("Harga Jual", "Harga Jual / Ton");

            dataGridView1.Rows.Add(new object[] { "Padi", 5, 10, 2500000});

        }

        private void btnAddData_Click(object sender, EventArgs e)
        {
            using (FormDialogInput formInput = new FormDialogInput())
            {
                if (formInput.ShowDialog() == DialogResult.OK)
                {
                    DataTanaman newTanaman = formInput.GetDataTanaman();
                    
                    dataGridView1.Rows.Add(new object[]
                    {
                        newTanaman.NamaTanaman,
                        newTanaman.LuasLahan,
                        newTanaman.HasilPanen,
                        newTanaman.HargaJual
                    });
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}