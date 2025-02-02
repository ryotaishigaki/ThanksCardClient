using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using ThanksCardClient.Models;
using ThanksCardClient.Services;

namespace ThanksCardClient.ViewModels
{
    public class OverallCardListViewModel : BindableBase, INavigationAware
    {
        private IRegionManager regionManager;

        IRestService service = new RestService();

        #region ThanksCardsProperty
        private List<ThanksCard> _ThanksCards;
        public List<ThanksCard> ThanksCards
        {
            get { return _ThanksCards; }
            set { SetProperty(ref _ThanksCards, value); }
        }
        #endregion

        #region ThanksCardsRanksProperty
        private List<ThanksCard> _ThanksCardsRank;
        public List<ThanksCard> ThanksCardsRank
        {
            get { return _ThanksCardsRank; }
            set { SetProperty(ref _ThanksCardsRank, value);}
        }
        #endregion


        public OverallCardListViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }


        public async void OnNavigatedTo(NavigationContext navigationContext)
        {
            ThanksCard thanksCard = new ThanksCard();
            this.ThanksCards = await thanksCard.GetThanksCardsAsync();
            this.ThanksCardsRank = await service.GetThanksCardsAsync();
            ThanksCardsRank = ThanksCardsRank.Where(x => x.ThanksRank > 4).ToList();
            //ThanksCardsRank = ThanksCardsRank.OrderByDescending(x => x.ThanksRank).FirstOrDefault();
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
            //throw new NotImplementedException();
        }

        #region ShowOverallCardListDetailCommand
        private DelegateCommand<ThanksCard> _ShowOverallCardListDetailCommand;
        public DelegateCommand<ThanksCard> ShowOverallCardListDetailCommand =>
            _ShowOverallCardListDetailCommand ?? (_ShowOverallCardListDetailCommand = new DelegateCommand<ThanksCard>(ExecuteShowOverallCardListDetailCommand));

        void ExecuteShowOverallCardListDetailCommand(ThanksCard SelectedOverallCardListDetail)
        {

            // 対象のThanksCardをパラメーターとして画面遷移先に渡す。
            var parameters = new NavigationParameters();
            parameters.Add("SelectedOverallCardListDetail", SelectedOverallCardListDetail);
            this.regionManager.RequestNavigate("ContentRegion", nameof(Views.OverallCardListDetail), parameters);
        }
        #endregion
    }
}
