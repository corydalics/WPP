using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;
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

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            _viewModel.Initialize();
        }

        private void EditServer(object sender, EventArgs e)
        {
        }

        private void ListOnTap(object sender, GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Views/FolderListView.xaml", UriKind.Relative));
        }
    }
}