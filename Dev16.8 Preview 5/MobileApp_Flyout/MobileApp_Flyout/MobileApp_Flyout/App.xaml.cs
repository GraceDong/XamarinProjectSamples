﻿using MobileApp_Flyout.Services;
using MobileApp_Flyout.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp_Flyout
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
