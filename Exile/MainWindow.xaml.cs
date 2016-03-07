using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MahApps.Metro.Controls;

namespace Exile
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow

    {
        public MainWindow()
        {
            InitializeComponent();
            ExtendedStatusStripMain.ButtonError.PreviewMouseDown += ButtonError_MouseDown;
            ExtendedStatusStripMain.ButtonExpand.PreviewMouseDown += ButtonExpand_MouseDown;
            ExtendedStatusStripMain.Timestamps = true;
            ExtendedStatusStripMain.AddStatus($"Welcome back, {Environment.UserName}");
        }

        private void ButtonExpand_MouseDown(object sender, MouseButtonEventArgs e)
        {
            RowStatusStrip.Height = RowStatusStrip.ActualHeight >= 151 ? new GridLength(22) : new GridLength(151);
            var listBox = ExtendedStatusStripMain.ListBoxStatus;
            listBox.ScrollIntoView(listBox.Items[listBox.Items.Count-1]);
            MenuMain.Focus();
        }

        private void ButtonError_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MenuMain.Focus();
        }

        private void MenuItemExit_OnClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MenuItemNewBot_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonLogin_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TabControlMain_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (e.Source is TabControl)
            {
                if (((TabItem) e.AddedItems[0]).Header == "test")
                {
                    //this.ShowMessageAsync(, "Hello, world");
                    ///TODO dialog using templates
                    ///http://stackoverflow.com/questions/30751663/how-to-change-mahapps-metro-dialog-content-template-width/30797630#30797630
                }
            }
        }
    }
}
