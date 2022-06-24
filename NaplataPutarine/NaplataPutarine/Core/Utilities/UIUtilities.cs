namespace NaplataPutarine.Core.Utilities
{
    internal class UIUtilities
    {
        public static bool Confirm(string message)
        {
            var result = MessageBoxUtilities.ShowConfirmationMessage(message);
            if (result == DialogResult.Yes) return true;
            return false;
        }
    }
}
