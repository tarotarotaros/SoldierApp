namespace DataSoldier.UI
{


    public class SelectorPresenter
    {
        private readonly ISelectorView _view;

        public SelectResult SelectResult { get; private set; }

        public SelectorPresenter(ISelectorView selectorView)
        {
            _view = selectorView;
            _view.OKClicked += OnOKClicked;
            _view.CancelClicked += OnCancelClicked;

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
