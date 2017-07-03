﻿using System;

using Xamarin.Forms;
using Plugin.Connectivity;
using Plugin.Connectivity.Abstractions;

namespace LetsWork
{
    public class App : Application
    {

		public static bool IsUserLoggedIn { get; set; }
		public static string Username { get; set; }


		public App()
        {

			if (!IsUserLoggedIn)
			{
				//MainPage = new NavigationPage(new LoginPage());
				MainPage = CrossConnectivity.Current.IsConnected
				? (Page)new NavigationPage(new LoginPage())
				: new NoNetworkPage();

			}
			else
			{
				MainPage = CrossConnectivity.Current.IsConnected
				? (Page)new NavigationPage(new TaskListPage())
				: new NoNetworkPage();

                //MainPage = new NavigationPage(new LoginNavigation.MainPage());
			}

			//MainPage = new NavigationPage(content);
			//MainPage = CrossConnectivity.Current.IsConnected
				//? (Page) new NavigationPage(new TaskListPage())
				//: new NoNetworkPage();

		}

        protected override void OnStart()
        {
			// Handle when your app starts
			CrossConnectivity.Current.ConnectivityChanged += HandleConnectivityChanged;
        }


		void HandleConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
		{
			Type currentPage = this.MainPage.GetType();
            if (e.IsConnected && currentPage != typeof(TaskListPage))
                //this.MainPage = new NavigationPage(new TaskListPage());
			    this.MainPage = new TaskListPage();
			else if (!e.IsConnected && currentPage != typeof(NoNetworkPage))
				this.MainPage = new NoNetworkPage();
		}

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
