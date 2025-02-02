﻿using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using ThanksCardClient.Models;
using ThanksCardClient.Services;

namespace ThanksCardClient.ViewModels
{
    public class FooterViewModel : BindableBase
    {
        private readonly IRegionManager regionManager;

        private User _AuthorizedUser;
        public User AuthorizedUser
        {
            get { return _AuthorizedUser; }
            set { SetProperty(ref _AuthorizedUser, value); }
        }

        public FooterViewModel(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
            this.AuthorizedUser = SessionService.Instance.AuthorizedUser;
        }

        #region ShowThanksCardCreateCommand
        private DelegateCommand _ShowThanksCardCreateCommand;
        public DelegateCommand ShowThanksCardCreateCommand =>
            _ShowThanksCardCreateCommand ?? (_ShowThanksCardCreateCommand = new DelegateCommand(ExecuteShowThanksCardCreateCommand));

        void ExecuteShowThanksCardCreateCommand()
        {
            this.regionManager.RequestNavigate("ContentRegion", nameof(Views.ThanksCardCreate));
        }
        #endregion

        #region ShowThanksCardListCommand
        private DelegateCommand _ShowThanksCardListCommand;
        public DelegateCommand ShowThanksCardListCommand =>
            _ShowThanksCardListCommand ?? (_ShowThanksCardListCommand = new DelegateCommand(ExecuteShowThanksCardListCommand));

        void ExecuteShowThanksCardListCommand()
        {
            this.regionManager.RequestNavigate("ContentRegion", nameof(Views.ThanksCardList));
        }
        #endregion

        #region ShowUserMstCommand
        private DelegateCommand _ShowUserMstCommand;
        public DelegateCommand ShowUserMstCommand =>
            _ShowUserMstCommand ?? (_ShowUserMstCommand = new DelegateCommand(ExecuteShowUserMstCommand));

        void ExecuteShowUserMstCommand()
        {
            this.regionManager.RequestNavigate("ContentRegion", nameof(Views.UserMst));
        }
        #endregion

        #region ShowDepartmentMstCommand
        private DelegateCommand _ShowDepartmentMstCommand;
        public DelegateCommand ShowDepartmentMstCommand =>
            _ShowDepartmentMstCommand ?? (_ShowDepartmentMstCommand = new DelegateCommand(ExecuteShowDepartmentMstCommand));

        void ExecuteShowDepartmentMstCommand()
        {
            this.regionManager.RequestNavigate("ContentRegion", nameof(Views.DepartmentMst));
        }
        #endregion

        #region ShowTagMstCommand
        private DelegateCommand _ShowTagMstCommand;
        public DelegateCommand ShowTagMstCommand =>
            _ShowTagMstCommand ?? (_ShowTagMstCommand = new DelegateCommand(ExecuteShowTagMstCommand));

        void ExecuteShowTagMstCommand()
        {
            this.regionManager.RequestNavigate("ContentRegion", nameof(Views.TagMst));
        }
        #endregion

        #region LogoffCommand
        private DelegateCommand _logoffCommand;
        public DelegateCommand LogoffCommand =>
            _logoffCommand ?? (_logoffCommand = new DelegateCommand(ExecuteLogoffCommand));

        void ExecuteLogoffCommand()
        {
            SessionService.Instance.AuthorizedUser = null;
            SessionService.Instance.IsAuthorized = false;

            // HeaderRegion, FooterRegion を破棄して、ContentRegion をログオン画面に遷移させる。
            this.regionManager.Regions["HeaderRegion"].RemoveAll();
            this.regionManager.RequestNavigate("ContentRegion", nameof(Views.Logon));
            this.regionManager.Regions["FooterRegion"].RemoveAll();
        }
        #endregion

        #region ShowProcessCommand
        private DelegateCommand _ShowProcessCommand;
        public DelegateCommand ShowProcessCommand =>
            _ShowProcessCommand ?? (_ShowProcessCommand = new DelegateCommand(ExecuteShowProcessCommand));

        void ExecuteShowProcessCommand()
        {
            this.regionManager.RequestNavigate("ContentRegion", nameof(Views.Process));
        }
        #endregion

        #region ShowDepartmentLinkCommand
        private DelegateCommand _ShowDepartmentLinkCommand;
        public DelegateCommand ShowDepartmentLinkCommand =>
            _ShowDepartmentLinkCommand ?? (_ShowDepartmentLinkCommand = new DelegateCommand(ExecuteShowDepartmentLinkCommand));

        void ExecuteShowDepartmentLinkCommand()
        {
            this.regionManager.RequestNavigate("ContentRegion", nameof(Views.DepartmentLink));
        }
        #endregion

        #region ShowUserLinkCommand
        private DelegateCommand _ShowUserLinkCommand;
        public DelegateCommand ShowUserLinkCommand =>
            _ShowUserLinkCommand ?? (_ShowUserLinkCommand = new DelegateCommand(ExecuteShowUserLinkCommand));

        void ExecuteShowUserLinkCommand()
        {
            this.regionManager.RequestNavigate("ContentRegion", nameof(Views.UserLink));
        }
        #endregion

        #region ShowCardDeleteCommand
        private DelegateCommand _ShowCardDeleteCommand;
        public DelegateCommand ShowCardDeleteCommand =>
            _ShowCardDeleteCommand ?? (_ShowCardDeleteCommand = new DelegateCommand(ExecuteShowCardDeleteCommand));

        void ExecuteShowCardDeleteCommand()
        {
            this.regionManager.RequestNavigate("ContentRegion", nameof(Views.CardDelete));
        }
        #endregion
    }
}
