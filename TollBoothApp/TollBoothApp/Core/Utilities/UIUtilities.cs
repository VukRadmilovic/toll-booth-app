namespace TollBoothApp.Core.Utilities
{
    internal class UIUtilities
    {
        public static bool Confirm(string message)
        {
            var result = MessageBoxUtilities.ShowConfirmationMessage(message);
            if (result == DialogResult.Yes) return true;
            return false;
        }

        public static object GetCellValue(DataGridView table, string columnName)
        {
            return table.SelectedRows[0].Cells[columnName].Value;
        }
    }
}
