using PathPal.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace PathPal
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public BrushType SelectedBrush { get; set; }
        public Size BrushSize { get; set; }

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void SelectWallButton_Click(object sender, RoutedEventArgs e)
        {
            SelectedBrush = BrushType.Wall;
        }

        private void SelectHeroButton_Click(object sender, RoutedEventArgs e)
        {
            SelectedBrush = BrushType.Hero;
        }

        private void SelectMonsterButton_Click(object sender, RoutedEventArgs e)
        {
            SelectedBrush = BrushType.Monster;
        }
    }
}
