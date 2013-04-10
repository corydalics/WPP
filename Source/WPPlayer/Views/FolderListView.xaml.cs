using Microsoft.Phone.Controls;
using WPPlayer.Utils;
using WPPlayer.ViewModels;

namespace WPPlayer.Views
{
    public partial class FolderListView
    {
        private readonly FolderListViewModel _viewModel;

        public FolderListView()
        {
            InitializeComponent();

            _viewModel = UnityContainer.Instance.Resolve<FolderListViewModel>();
            DataContext = _viewModel;
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            _viewModel.Initialize();
        }
    }
}