using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MathIS.UI
{
    public class DataGridViewEx : DataGridView
    {
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                //base.ProcessTabKey(Keys.Tab);
                if (CurrentCell != null && CurrentCell.OwningRow.Index == (Rows.Count - 1) && CurrentCell.OwningColumn.Index == (Columns.Count - 1))
                {
                    //base.ProcessDialogKey(Keys.Tab);
                    base.OnKeyDown(new KeyEventArgs(Keys.Enter));
                }
                else
                {
                    base.ProcessDialogKey(Keys.Tab);    
                }
                
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        protected override bool ProcessDataGridViewKey(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                base.ProcessTabKey(Keys.Tab);
                return true;
            }
            return base.ProcessDataGridViewKey(e);
        }

        
    }

    public static class DataGridHelper
    {
        public static DataGridViewCell GetCellFromPropertyName(this DataGridViewCellCollection CellCollection, string dataPropertyName)
        {
            return CellCollection.Cast<DataGridViewCell>().FirstOrDefault(c => c.OwningColumn.DataPropertyName == dataPropertyName);
        }
        public static DataGridViewColumn GetColumnFromPropertyName(this DataGridViewColumnCollection ColumnCollection, string dataPropertyName)
        {
            return ColumnCollection.Cast<DataGridViewColumn>().FirstOrDefault(c => c.DataPropertyName == dataPropertyName);
        }
        public static void ClearErrorText(this DataGridView dg)
        {
            foreach (DataGridViewRow row in dg.Rows)
            {
                row.ErrorText = "";
                foreach (DataGridViewCell cell in row.Cells)
                    cell.ErrorText = "";
            }
        }
    }
}
