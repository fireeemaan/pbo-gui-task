namespace pbo_gui_task
{
    public partial class dataPertanian : Form
    {
        List<DataTanaman> listTanaman = new List<DataTanaman>();
        public dataPertanian()
        {
            InitializeComponent();
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