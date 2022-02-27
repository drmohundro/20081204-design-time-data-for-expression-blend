using System.Windows;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window, IView
    {
        public Window1()
        {
            InitializeComponent();

            var presenter = new Presenter(this, new RealService(), new PresenterModel());
            presenter.Run();
        }

        #region IView Members

        public object Model
        {
            get { return DataContext; }
            set { DataContext = value; }
        }

        #endregion
    }
}