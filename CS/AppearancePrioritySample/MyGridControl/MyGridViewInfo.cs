using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Diagnostics;

namespace GridControlDescendant
{
    public class MyGridViewInfo : GridViewInfo
    {
        public MyGridViewInfo(DevExpress.XtraGrid.Views.Grid.GridView gridView) : base(gridView) { }

        protected override DevExpress.Utils.AppearanceObject[] GetRowMixAppearances(GridCellInfo cellInfo, 
            GridRowCellState state, 
            GridRowInfo bi, 
            DevExpress.Utils.AppearanceObjectEx column, 
            DevExpress.Utils.AppearanceObject focusedCell, 
            DevExpress.Utils.AppearanceObjectEx conditionCell)
        {
            DevExpress.Utils.AppearanceObject[] apps = base.GetRowMixAppearances(cellInfo, state, bi, column, focusedCell, conditionCell);

            if ((state & GridRowCellState.Selected) != 0)
                apps.SetValue(PaintAppearance.SelectedRow, 0);

            return apps;
        }
    }
}
