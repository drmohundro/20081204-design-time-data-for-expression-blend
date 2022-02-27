namespace WpfApplication1
{
    public class Presenter
    {
        private readonly IView _view;
        private readonly IService _service;
        private readonly PresenterModel _presenterModel;

        public Presenter(IView view, IService service, PresenterModel presenterModel)
        {
            _view = view;
            _service = service;
            _presenterModel = presenterModel;
        }

        public void Run()
        {
            _view.Model = _presenterModel;
            LoadAccounts();
        }

        private void LoadAccounts()
        {
            foreach (var acct in _service.GetAccounts())
                _presenterModel.Accounts.Add(acct);
        }
    }
}