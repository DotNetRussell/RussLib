using BasecodeLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using static BasecodeLibrary.Utilities.ApplicationServices;

namespace RussLib.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AboutPage : Page
    {
        public static bool DisableBackButton { get; set; }

        public AboutPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = Windows.UI.Xaml.Navigation.NavigationCacheMode.Enabled;
            Loaded += OnAboutPageLoaded;
            SystemNavigationManager.GetForCurrentView().BackRequested += OnBackButtonClicked;    
        }

        private void OnAboutPageLoaded(object sender, RoutedEventArgs e)
        {
            DeviceType device = ApplicationServices.CurrentDevice;

            switch (device)
            {
                case (DeviceType.Phablet):
                case (DeviceType.Desktop):
                    PART_Content.Content = new AboutPageDesktop();
                    break;
                case (DeviceType.Mobile):
                    PART_Content.Content = new AboutPageMobile();
                    PART_NavigationPanel.Visibility = Visibility.Collapsed;
                    break;
            }

            if(DisableBackButton)
            {
                BackButton.Visibility = Visibility.Collapsed;
            }
        }

        private void OnBackButtonClicked(object sender, BackRequestedEventArgs e)
        {
            SystemNavigationManager.GetForCurrentView().BackRequested -= OnBackButtonClicked;
            e.Handled = true;

            OnBackButtonClicked(sender, new RoutedEventArgs());
        }

        private void OnBackButtonClicked(object sender, RoutedEventArgs e)
        {
            if(Frame.BackStack.Count > 0)
                Frame.GoBack();
        }
    }
}
