using System;
using WPPlayer.Utils;
using WPPlayer.ViewModels;

namespace WPPlayer.Views
{
    public partial class ServerEditView
    {
        private readonly ServerEditViewModel _viewModel;

        public ServerEditView()
        {
            _viewModel = UnityContainer.Instance.Resolve<ServerEditViewModel>();
            DataContext = _viewModel;

            InitializeComponent();
        }

        private void SaveDetails(object sender, EventArgs e)
        {
            _viewModel.SaveDetails();
            NavigationService.Navigate(new Uri("/Views/MainPageView.xaml", UriKind.Relative));
        }
    }
}