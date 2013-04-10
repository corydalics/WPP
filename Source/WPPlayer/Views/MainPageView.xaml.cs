using System;
using WPPlayer.Models;
using WPPlayer.Utils;
using WPPlayer.ViewModels;

namespace WPPlayer.Views
{
    public partial class MainPageView
    {
        private readonly MainPageViewModel _viewModel;
        // Constructor
        public MainPageView()
        {
            InitializeComponent();

            _viewModel = UnityContainer.Instance.Resolve<MainPageViewModel>();

            DataContext = _viewModel;

        }

        private void AddNewServer(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/ServerEditView.xaml", UriKind.Relative));
        }

    }
}