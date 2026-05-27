using System.Windows;

namespace SurveyApp
{
    public partial class ResultWindow : Window
    {
        private string wyniki;

        public ResultWindow(string wyniki)
        {
            InitializeComponent();
            this.wyniki = wyniki;
            TbWyniki.Text = wyniki;
        }

        private void BtnKopiuj_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(wyniki);
            MessageBox.Show("Wyniki skopiowane do schowka!", "Sukces", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnZamknij_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}