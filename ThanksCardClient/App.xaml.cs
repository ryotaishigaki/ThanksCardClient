﻿using ThanksCardClient.Views;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;
using ThanksCardClient.ViewModels;

namespace ThanksCardClient
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainWindow>();
            containerRegistry.RegisterForNavigation<Header>();
            containerRegistry.RegisterForNavigation<Logon>();
            containerRegistry.RegisterForNavigation<Footer>();
            containerRegistry.RegisterForNavigation<ThanksCardCreate>();
            containerRegistry.RegisterForNavigation<ThanksCardList>();
            containerRegistry.RegisterForNavigation<UserMst>();
            containerRegistry.RegisterForNavigation<UserCreate>();
            containerRegistry.RegisterForNavigation<UserEdit>();
            containerRegistry.RegisterForNavigation<DepartmentMst>();
            containerRegistry.RegisterForNavigation<DepartmentCreate>();
            containerRegistry.RegisterForNavigation<DepartmentEdit>();
            containerRegistry.RegisterForNavigation<TagMst>();
            containerRegistry.RegisterForNavigation<TagCreate>();
            containerRegistry.RegisterForNavigation<TagEdit>();
            containerRegistry.RegisterForNavigation<Process>();
            containerRegistry.RegisterForNavigation<DepartmentLink>();
            containerRegistry.RegisterForNavigation<UserLink>();
            containerRegistry.RegisterForNavigation<CardDelete>();
            containerRegistry.RegisterForNavigation<OverallCardList>(); 
            containerRegistry.RegisterForNavigation<OverallCardListDetail>();
            containerRegistry.RegisterForNavigation<Detail>();
            containerRegistry.RegisterForNavigation<SendConfirm>(); 
            containerRegistry.RegisterForNavigation<Manual>();
       
        }
    }
}
