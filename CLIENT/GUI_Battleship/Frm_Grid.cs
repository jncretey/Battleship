using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Battleship
{
    public partial class Frm_Grid : Form
    {
        const int GRID_COL = 10;
        const int GRID_ROW = 10;

        public Frm_Grid()
        {
            InitializeComponent();
            gridLoad();
        }

        private void gridLoad()
        {
            gridAdd("Tlp_GridEnemy", 1, 1);
            gridAdd("Tlp_GridPlayer", 3, 1);
        }

        private void gridAdd(String tlpName, int tlpParentRow, int tlpParentCol)
        {
            CTR_Tlp tlp = new CTR_Tlp();
            tlp.Name = tlpName;
            tlp.Dock = DockStyle.Fill;
            tlp.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;

            this.Tlp_Stack.Controls.Add(tlp, tlpParentCol, tlpParentRow);

            gridInit(GRID_COL, GRID_ROW, tlp);
        }

        /// <summary>
        /// Init player grid
        /// </summary>
        /// <param name="gridDim">Grid dimension</param>
        private void gridInit(int gridCol, int gridRow, TableLayoutPanel tlp)
        {
            tlp.RowStyles.Clear();
            tlp.ColumnStyles.Clear();

            gridCol += 1;
            gridRow += 1;

            tlp.ColumnCount = gridCol;
            tlp.RowCount = gridRow;

            for (int i = 0; i < gridCol; i++)
            {
                tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (100 / gridCol)));
            }

            for (int i = 0; i < gridRow + 1; i++)
            {
                tlp.RowStyles.Add(new RowStyle(SizeType.Percent, (100 / gridRow)));
            }

            for (int row = 0; row < tlp.RowCount; row++)
            {
                for (int column = 0; column < tlp.ColumnCount; column++)
                {
                    addLabel(tlp, row, column);
                }
            }
        }

        /// <summary>
        /// Add label in each TableLayoutPanel cell
        /// </summary>
        /// <param name="tlp">TableLayoutPanel</param>
        /// <param name="row">TableLayoutPanel row</param>
        /// <param name="column">TableLayoutPanel column</param>
        private void addLabel(TableLayoutPanel tlp, int row, int column)
        {
            Label label = new Label();
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Dock = DockStyle.Fill;
            label.Name = row.ToString() + ";" + column.ToString();
            label.Tag = false;
            label.MouseClick += new MouseEventHandler(clickOnLabel);
            this.labelProperties(row, column, label);

            tlp.Controls.Add(label, column, row);
        }

        /// <summary>
        /// Label click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void clickOnLabel(object sender, MouseEventArgs e)
        {
            Label label = (Label)sender;
            if (!(label.BackColor == Vars.LABEL_HEADER) && (Boolean)label.Tag == false)
            {
                label.BackColor = Vars.LABEL_TOUCH;
            }
        }

        /// <summary>
        /// Label TableLayoutPanel cell properties
        /// </summary>
        /// <param name="row">TableLayoutPanel row</param>
        /// <param name="column">TableLayoutPanel column</param>
        /// <param name="label">Label object</param>
        private void labelProperties(int row, int column, Label label)
        {
            if (row != 0 || column != 0)
            {
                label.BackColor = Vars.LABEL_UNTOUCH;
            }

            if (row == 0 && column != 0)
            {
                label.Text = column.ToString();
                label.BackColor = Vars.LABEL_HEADER;
            }

            if (row != 0 && column == 0)
            {
                label.Text = row.ToString();
                label.BackColor = Vars.LABEL_HEADER;
            }

            if (row == 0 && column == 0)
            {
                label.BackColor = Vars.LABEL_HEADER;
            }
        }
    }
}
