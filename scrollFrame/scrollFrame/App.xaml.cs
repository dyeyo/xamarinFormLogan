﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace scrollFrame
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FormularioPage();
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