using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Little_Paw.Forme
{
    public partial class PopisLijekovaForma : Form
    {
        private int selectedId;
        private string vrstaKorisnika;
        private VeterinarMDIForma veterinarMDIForma;
        private TehnicarMDIForma tehnicarMDIForma;
        private TajnicaMDIForma tajnicaMDIForma;

       

        public PopisLijekovaForma(VeterinarMDIForma veterinarMDIForma, string vrstaKorisnika)
        {
            this.veterinarMDIForma = veterinarMDIForma;
            InitializeComponent();
            this.selectedId = 0;
            this.vrstaKorisnika = vrstaKorisnika;
        }

        public PopisLijekovaForma(TehnicarMDIForma tehnicarMDIForma, string vrstaKorisnika)
        {
            this.tehnicarMDIForma = tehnicarMDIForma;
            InitializeComponent();
            this.selectedId = 0;
            this.vrstaKorisnika = vrstaKorisnika;
        }

        public PopisLijekovaForma(TajnicaMDIForma tajnicaMDIForma, string vrstaKorisnika)
        {
            this.tajnicaMDIForma = tajnicaMDIForma;
            InitializeComponent();
            this.selectedId = 0;
            Uredi.Visible = false;
            this.vrstaKorisnika = vrstaKorisnika;
        }

        private void popis_lijekovaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.popis_lijekovaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._16045_DBDataSet);

        }

        private void PopisLijekovaForma_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            // TODO: This line of code loads data into the '_16045_DBDataSet.popis_lijekova' table. You can move, or remove it, as needed.
            this.popis_lijekovaTableAdapter.Fill(this._16045_DBDataSet.popis_lijekova);

            if (vrstaKorisnika == "veterinar")
            {
                bindingNavigatorDeleteItem.Visible = true;
            }
        }

        private void popis_lijekovaDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (popis_lijekovaDataGridView.SelectedCells.Count > 0)
            {
                this.selectedId = int.Parse(popis_lijekovaDataGridView.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if(selectedId > 0)
            {
                NoviLijekForma forma = new NoviLijekForma(selectedId, vrstaKorisnika);
                if (this.veterinarMDIForma != null)
                {
                    forma.MdiParent = this.veterinarMDIForma;
                }
                else if (this.tehnicarMDIForma != null)
                {
                    forma.MdiParent = this.tehnicarMDIForma; ;
                }
                forma.Show();
            }
            
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
          //  popis_lijekovaDataGridView.Refresh();
            this.popis_lijekovaTableAdapter.Fill(this._16045_DBDataSet.popis_lijekova);
        }

        private void popis_lijekovaDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (vrstaKorisnika == "tajnica")
            {
                foreach (DataGridViewRow row in popis_lijekovaDataGridView.Rows)
                {
                    if (Convert.ToInt32(row.Cells[6].Value) < 5)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.tableAdapterManager.UpdateAll(this._16045_DBDataSet);
        }
    }
}
