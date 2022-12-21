using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AuthTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Wpf.Ui.Appearance.Theme.Apply(
            Wpf.Ui.Appearance.ThemeType.Dark,     // Theme type
              Wpf.Ui.Appearance.BackgroundType.Mica, // Background type
              true                                   // Whether to change accents automatically
            );
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }
        private void Proceed(object sender, RoutedEventArgs e)
        {
            if (PasswordField.Text.Length > 0 && LoginField.Text.Length > 0)
            {
                System.Environment.Exit(0);

            }
            else
            {
                SnackBar.Show("You did not enter your login information");
            }
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}
