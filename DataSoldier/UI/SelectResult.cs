namespace DataSoldier.UI
{
    public enum SelectType
    {
        NoSelect,
        Selected,
        Cancel
    }

    public class SelectResult
    {
        public static readonly SelectResult NO_SELECT = new SelectResult(SelectType.NoSelect, string.Empty);
        public static readonly SelectResult CANCEL = new SelectResult(SelectType.Cancel, string.Empty);

        private readonly SelectType _selectType;
        private readonly string _selectedText;

        public SelectType SelectType { get { return _selectType; } }
        public string SelectedText { get { return _selectedText; } }

        public SelectResult(SelectType selectType, string selectedText)
        {
            _selectType = selectType;
            _selectedText = selectedText;
        }
    }
}
