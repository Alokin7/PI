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
    public partial class DnevniTerminForma : Form
    {
        private int selectedId;
        private string vrstaKorisnika;
        private VeterinarMDIForma veterinarMDIForma;
        private TehnicarMDIForma tehnicarMDIForma;
        private TajnicaMDIForma tajnicaMDIForma;

        public DnevniTerminForma(VeterinarMDIForma veterinarMDIForma, string vrstaKorisnika)
        {
            this.veterinarMDIForma = veterinarMDIForma;
            InitializeComponent();
            this.selectedId = 0;
            this.vrstaKorisnika = vrstaKorisnika;
        }

        public DnevniTerminForma(TehnicarMDIForma tehnicarMDIForma, string vrstaKorisnika)
        {
            this.tehnicarMDIForma = tehnicarMDIForma;
            InitializeComponent();
            this.selectedId = 0;
            this.vrstaKorisnika = vrstaKorisnika;
        }

        public DnevniTerminForma(TajnicaMDIForma tajnicaMDIForma, string vrstaKorisnika)
        {
            this.tajnicaMDIForma = tajnicaMDIForma;
            InitializeComponent();
            this.selectedId = 0;
            this.vrstaKorisnika = vrstaKorisnika;
        }

        private void terminBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.terminBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._16045_DBDataSet);

        }

        private void DnevniTerminForma_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            // TODO: This line of code loads data into the '_16045_DBDataSet.vrsta_zahvata' table. You can move, or remove it, as needed.
            this.vrsta_zahvataTableAdapter.Fill(this._16045_DBDataSet.vrsta_zahvata);
            // TODO: This line of code loads data into the '_16045_DBDataSet.korisnik' table. You can move, or remove it, as needed.
            this.korisnikTableAdapter.Fill(this._16045_DBDataSet.korisnik);
            // TODO: This line of code loads data into the '_16045_DBDataSet.termin' table. You can move, or remove it, as needed.
            this.terminTableAdapter.Fill(this._16045_DBDataSet.termin);

            disableInput(vrstaKorisnika);

            if (vrstaKorisnika != "tajnica")
            {
                bindingNavigatorAddNewItem.Visible = false;
                bindingNavigatorDeleteItem.Visible = false;
            }
        }

        private void terminDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (terminDataGridView.SelectedCells.Count > 0)
            {
                this.selectedId = int.Parse(terminDataGridView.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void disableInput(string vrstaKorisnika)
        {
            if (vrstaKorisnika != "tajnica")
            {
                //    this.terminDataGridView.Columns
                foreach (DataGridViewColumn column in this.terminDataGridView.Columns)
                {
                    if (!(column.Index.Equals(2) || column.Index.Equals(4)))
                    {
                        column.ReadOnly = true;
                        column.DefaultCellStyle.BackColor = Color.LightGray;
                    }
                    else
                    {
                        column.ReadOnly = false;
                    }
                }
            }
            else
            {
                foreach (DataGridViewColumn column in this.terminDataGridView.Columns)
                {
                    if (column.Index.Equals(2) || column.Index.Equals(4))
                    {
                        column.ReadOnly = true;
                        column.DefaultCellStyle.BackColor = Color.LightGray;
                    }
                }
            }
        }
    }
}
