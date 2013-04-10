using System.Collections.Generic;
using System.IO;
using System.Net;
using Microsoft.Phone.Net.NetworkInformation;
using WPPlayer.Models;

namespace WPPlayer.ViewModels
{
    class FolderListViewModel : BaseViewModel
    {
        private readonly IServerProvider _serverProvider;
        private string _folderName;

        public FolderListViewModel(IServerProvider serverProvider)
        {
            _serverProvider = serverProvider;
            FolderName = @"\";
        }

        public string FolderName 
        {
            get
            {
                return _folderName;
            }

            set
            {
                _folderName = value;
                FirePropertyChanged();
            }
        }

        public IEnumerable<FileSystemInfo> FileSystemItems { get; set; }

        public FileSystemInfo SelectedFile { get; set; }

        protected override void Init()
        {
            var address = _serverProvider.SelectedServer.EndPoint.Address.ToString();
            var root = @"\\192.168.1.1\sda2\Movies\" ;
            //var path = Path.Combine(root, FolderName);

            var f = new DirectoryInfo(root);

            NetworkInterfaceList networkInterfaceList = new NetworkInterfaceList();
            foreach (NetworkInterfaceInfo interfaceInfo in networkInterfaceList)
            {
                var rest = interfaceInfo;
            }

            var internetInterface = NetworkInterface.GetInternetInterface();


            DeviceNetworkInformation.ResolveHostNameAsync(
                new DnsEndPoint("192.168.1.1", 21), result
                                                =>
                    {
                        var result2 = result.NetworkErrorCode;
                    }, null);

            var fileSystemEntries = Directory.GetFileSystemEntries(root);
        }
    }
}
