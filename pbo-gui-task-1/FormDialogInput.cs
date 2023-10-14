using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbo_gui_task_1
{
    public partial class FormDialogInput : Form
    {
        public FormDialogInput()
        {
            InitializeComponent();
        }

        public DataTanaman GetDataTanaman()
        {
            DataTanaman newTanaman = new DataTanaman();
            newTanaman.NamaTanaman = tbxNamaTanaman.Text;
            newTanaman.LuasLahan = int.Parse(tbxLuasLahan.Text);
            newTanaman.HasilPanen = int.Parse(tbxHasilPanen.Text);
            newTanaman.HargaJual = int.Parse(tbxHargaJual.Text);

            return newTanaman;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
