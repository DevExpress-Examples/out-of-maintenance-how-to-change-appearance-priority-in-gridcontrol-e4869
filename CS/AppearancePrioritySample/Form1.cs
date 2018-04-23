using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid;
using System.Drawing;

namespace GridControlDescendant {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            myGridView1.ShowFindPanel();
            myGridControl1.DataSource = Data.CreateData(10);

            GridRowCellState state = GridRowCellState.Even | GridRowCellState.FocusedAndGridFocused;
            GridRowCellState newState = state & GridRowCellState.FocusedCell;
            newState = state & GridRowCellState.Even;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StyleFormatCondition condition1 = new StyleFormatCondition();
            condition1.Appearance.BackColor = Color.Navy;
            condition1.Appearance.Options.UseBackColor = true;
            condition1.Condition = FormatConditionEnum.Expression;
            condition1.ApplyToRow = false;
            condition1.Expression = "[Value1] > 2";
            condition1.Column = gridColumn3;
            myGridView1.FormatConditions.Add(condition1);
        }
    }
}
