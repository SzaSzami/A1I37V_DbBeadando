using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PresentsWinForm.Models.Manager;
using PresentsWinForm.Models.Records;

namespace PresentsWinForm
{
    public partial class AjandekokForm : Form
    {
        PresentsTable tablemanager;
        List<Ajandekok> records_presentlist;
        BackgroundWorker bgWorker;

        public AjandekokForm()
        {
            InitializeComponent();
            tablemanager = new PresentsTable();
            records_presentlist = new List<Ajandekok>();
            bgWorker = new BackgroundWorker();
        }

        private void btn_addpresent_Click(object sender, EventArgs e)
        {
            Ajandekok aji = new Ajandekok()
            {
                Present_id = txt_presentid.Text,
                Present_name = txt_presentname.Text,
                Manufacturer_id = int.Parse(txt_manuid.Text),
                Present_color = txt_color.Text,
                Present_size = cmb_size.SelectedItem.ToString(),
                Present_price = int.Parse(txt_price.Text),
                Present_weight = int.Parse(txt_weight.Text)
            };
            tablemanager.Insert(aji);
            bgWorker.RunWorkerAsync();

            MessageBox.Show("Present successfully added!");
            txt_presentid.Clear();
            txt_presentname.Clear();
            txt_manuid.Clear();
            txt_color.Clear();
            txt_price.Clear();
            txt_weight.Clear();
        }

        private void btn_updatepresent_Click(object sender, EventArgs e)
        {

        }

        private void btn_deletepresent_Click(object sender, EventArgs e)
        {
            int ToroltSorok = 0;
            foreach (DataGridViewRow selectedRows in dgv_Presents.SelectedRows)
            {
                Ajandekok TorlendoRekord = new Ajandekok();
                TorlendoRekord.Present_id = selectedRows.Cells["PRESENT_ID"].Value.ToString();

                ToroltSorok += tablemanager.Delete(TorlendoRekord);
            }

            MessageBox.Show(string.Format("{0} Row(s) successfully deleted!", ToroltSorok));
            if (ToroltSorok != 0)
            {
                bgWorker.RunWorkerAsync();
            }
        }

        private void AjandekokForm_Load(object sender, EventArgs e)
        {
            bgWorker.WorkerSupportsCancellation = true;
            cmb_size.DataSource = Enum.GetValues(typeof(Present_size));

            InitDataGridView();
        }

        private void AjandekokForm_Show(object sender, EventArgs e)
        {
            bgWorker.RunWorkerAsync();
        }

        private void InitDataGridView()
        {
            dgv_Presents.Rows.Clear();
            dgv_Presents.Columns.Clear();

            DataGridViewColumn IdColumn = new DataGridViewColumn()
            {
                Name = "Present_id",
                HeaderText = "Present id",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            };
            dgv_Presents.Columns.Add(IdColumn);

            DataGridViewColumn NameColumn = new DataGridViewColumn()
            {
                Name = "Present_name",
                HeaderText = "Present name",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            };
            dgv_Presents.Columns.Add(NameColumn);

            DataGridViewColumn ManuIdColumn = new DataGridViewColumn()
            {
                Name = "Manufacturer_id",
                HeaderText = "Manufacturer id",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            };
            dgv_Presents.Columns.Add(ManuIdColumn);

            DataGridViewColumn ColorColumn = new DataGridViewColumn()
            {
                Name = "Present_color",
                HeaderText = "Present color",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            };
            dgv_Presents.Columns.Add(ColorColumn);

            DataGridViewColumn SizeColumn = new DataGridViewColumn()
            {
                Name = "Present_size",
                HeaderText = "Present size",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            };
            dgv_Presents.Columns.Add(SizeColumn);

            DataGridViewColumn PriceColumn = new DataGridViewColumn()
            {
                Name = "Present_price",
                HeaderText = "Present price",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            };
            dgv_Presents.Columns.Add(PriceColumn);

            DataGridViewColumn WeightColumn = new DataGridViewColumn()
            {
                Name = "Present_weight",
                HeaderText = "Present weight",
                Visible = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            };
            dgv_Presents.Columns.Add(WeightColumn);
        }

        private void BgWorker_RunWorkerComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            FillDataGridView();
        }



        private void FillDataGridView()
        {
            DataGridViewRow[] dataGridViewRows = new DataGridViewRow[records_presentlist.Count];
            for (int i = 0; i < records_presentlist.Count; i++)
            {
                DataGridViewRow dataGridViewRow = new DataGridViewRow();

                DataGridViewCell Present_IdCell = new DataGridViewTextBoxCell();
                Present_IdCell.Value = records_presentlist[i].Present_id;
                dataGridViewRow.Cells.Add(Present_IdCell);

                DataGridViewCell Present_NameCell = new DataGridViewTextBoxCell();
                Present_IdCell.Value = records_presentlist[i].Present_name;
                dataGridViewRow.Cells.Add(Present_NameCell);

                DataGridViewCell Manufacturer_IdCell = new DataGridViewTextBoxCell();
                Present_IdCell.Value = records_presentlist[i].Manufacturer_id;
                dataGridViewRow.Cells.Add(Manufacturer_IdCell);

                DataGridViewCell Present_ColorCell = new DataGridViewTextBoxCell();
                Present_IdCell.Value = records_presentlist[i].Present_color;
                dataGridViewRow.Cells.Add(Present_ColorCell);

                DataGridViewCell Present_SizeCell = new DataGridViewTextBoxCell();
                Present_IdCell.Value = records_presentlist[i].Present_size;
                dataGridViewRow.Cells.Add(Present_SizeCell);

                DataGridViewCell Present_PriceCell = new DataGridViewTextBoxCell();
                Present_IdCell.Value = records_presentlist[i].Present_price;
                dataGridViewRow.Cells.Add(Present_PriceCell);

                DataGridViewCell Present_WeightCell = new DataGridViewTextBoxCell();
                Present_IdCell.Value = records_presentlist[i].Present_weight;
                dataGridViewRow.Cells.Add(Present_WeightCell);

                dataGridViewRows[i] = dataGridViewRow;

            }

            dgv_Presents.Rows.Clear();
            dgv_Presents.Rows.AddRange(dataGridViewRows);

        }
        private void BgWorekr_DoWork(object sender, DoWorkEventArgs e)
        {
            records_presentlist = tablemanager.Select();
        }

        
        private void txt_presentid_Leave(object sender, EventArgs e)
        {
            string actual = txt_presentid.Text;
            bool Correct = tablemanager.CheckPresentId(actual);
            txt_presentid.BackColor = Correct ? Color.White : Color.Yellow;
        }








    }
}
