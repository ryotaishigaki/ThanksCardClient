using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThanksCardClient.Models;
using ThanksCardClient.Services;

namespace ThanksCardClient.ViewModels
{
    public class UserLinkViewModel : BindableBase, INavigationAware
    {
        IRestService service = new RestService();

        private List<Rank> _Ranks;
        public List<Rank> Ranks
        {
            get { return _Ranks; }
            set { SetProperty(ref _Ranks, value); }
        }

        private IRegionManager regionManager;

        public UserLinkViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public async void OnNavigatedTo(NavigationContext navigationContext)
        {
            Rank ranks = new Rank();
            this.Ranks = await service.GetRanksAsync();
            
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            //throw new NotImplementedException();
        }
    }
}
