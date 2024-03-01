namespace DataSoldier.UI
{


    public class SelectorPresenter
    {
        private readonly ISelectorView _view;

        public SelectResult SelectResult { get; private set; }

        public SelectorPresenter(ISelectorView selectorView, string title, Dictionary<string, string> selectDict)
        {
            _view = selectorView;
            _view.OKClicked += OnOKClicked;
            _view.CancelClicked += OnCancelClicked;

            _view.Title = title;
            _view.SelectItems = selectDict;

            SelectResult = SelectResult.NO_SELECT;



        }

        private void OnOKClicked(object sender, EventArgs e)
        {
            SelectResult = new SelectResult(SelectType.Selected, "TEST");
            _view.CloseView();
        }

        private void OnCancelClicked(object sender, EventArgs e)
        {
            SelectResult = SelectResult.CANCEL;
            _view.CloseView();
        }

    }
}
