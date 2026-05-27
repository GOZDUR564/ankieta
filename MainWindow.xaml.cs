using System;
using System.Windows;
using System.Text;

namespace SurveyApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SliderOcena.ValueChanged += SliderOcena_ValueChanged;
        }

        private void SliderOcena_ValueChanged(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {
            TbOcenaWartość.Text = SliderOcena.Value.ToString("F0");
        }

        private void BtnCzyść_Click(object sender, RoutedEventArgs e)
        {
            // Czyszczenie pól tekstowych
            TbNazwisko.Clear();
            TbEmail.Clear();
            TbRokProdukcji.Clear();
            TbUwagi.Clear();

            // Resetowanie ComboBox
            CbMarka.SelectedIndex = 0;

            // Resetowanie RadioButton
            RbBenzyna.IsChecked = false;
            RbDiesel.IsChecked = false;
            RbElektryczny.IsChecked = false;
            RbHybrid.IsChecked = false;
            RbGaz.IsChecked = false;

            // Resetowanie CheckBox
            ChkABS.IsChecked = false;
            ChkESP.IsChecked = false;
            ChkTempomat.IsChecked = false;
            ChkKamera.IsChecked = false;
            ChkParktronic.IsChecked = false;
            ChkKlimaty.IsChecked = false;

            // Resetowanie Slider
            SliderOcena.Value = 5;

            // Resetowanie DatePicker
            DpPrzegląd.SelectedDate = null;

            MessageBox.Show("Ankieta została wyczyszczona!", "Oczyszczenie", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void BtnZatwierdź_Click(object sender, RoutedEventArgs e)
        {
            // Walidacja pól obowiązkowych
            if (string.IsNullOrWhiteSpace(TbNazwisko.Text))
            {
                MessageBox.Show("Proszę wpisać imię i nazwisko!", "Błąd walidacji", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TbEmail.Text))
            {
                MessageBox.Show("Proszę wpisać email!", "Błąd walidacji", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (CbMarka.SelectedIndex == 0)
            {
                MessageBox.Show("Proszę wybrać markę samochodu!", "Błąd walidacji", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TbRokProdukcji.Text))
            {
                MessageBox.Show("Proszę wpisać rok produkcji!", "Błąd walidacji", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Zebranie wyborów
            StringBuilder wyniki = new StringBuilder();
            wyniki.AppendLine("========== PODSUMOWANIE ANKIETY ==========");
            wyniki.AppendLine();

            wyniki.AppendLine("DANE OSOBOWE:");
            wyniki.AppendLine($"Imię i Nazwisko: {TbNazwisko.Text}");
            wyniki.AppendLine($"Email: {TbEmail.Text}");
            wyniki.AppendLine();

            wyniki.AppendLine("INFORMACJE O SAMOCHODZIE:");
            wyniki.AppendLine($"Marka: {CbMarka.SelectedItem}");
            wyniki.AppendLine($"Rok produkcji: {TbRokProdukcji.Text}");
            wyniki.AppendLine();

            wyniki.AppendLine("TYP PALIWA:");
            if (RbBenzyna.IsChecked == true) wyniki.AppendLine("✓ Benzyna");
            if (RbDiesel.IsChecked == true) wyniki.AppendLine("✓ Diesel");
            if (RbElektryczny.IsChecked == true) wyniki.AppendLine("✓ Elektryczny");
            if (RbHybrid.IsChecked == true) wyniki.AppendLine("✓ Hybrid");
            if (RbGaz.IsChecked == true) wyniki.AppendLine("✓ Gaz (LPG/CNG)");
            wyniki.AppendLine();

            wyniki.AppendLine("WYPOSAŻENIE BEZPIECZEŃSTWA:");
            if (ChkABS.IsChecked == true) wyniki.AppendLine("✓ ABS");
            if (ChkESP.IsChecked == true) wyniki.AppendLine("✓ ESP");
            if (ChkTempomat.IsChecked == true) wyniki.AppendLine("✓ Tempomat");
            if (ChkKamera.IsChecked == true) wyniki.AppendLine("✓ Kamera cofania");
            if (ChkParktronic.IsChecked == true) wyniki.AppendLine("✓ Parktronic");
            if (ChkKlimaty.IsChecked == true) wyniki.AppendLine("✓ Klimatyzacja automatyczna");
            wyniki.AppendLine();

            wyniki.AppendLine($"OCENA ZADOWOLENIA: {SliderOcena.Value:F0}/10");
            wyniki.AppendLine();

            wyniki.AppendLine($"OSTATNI PRZEGLĄD: {(DpPrzegląd.SelectedDate.HasValue ? DpPrzegląd.SelectedDate.Value.ToString("dd.MM.yyyy") : "Nie wybrano")}");
            wyniki.AppendLine();

            if (!string.IsNullOrWhiteSpace(TbUwagi.Text))
            {
                wyniki.AppendLine($"DODATKOWE UWAGI:\n{TbUwagi.Text}");
            }

            wyniki.AppendLine("\n==========================================");

            // Wyświetlenie wyników
            string wynik = wyniki.ToString();
            
            var resultWindow = new ResultWindow(wynik);
            resultWindow.ShowDialog();
        }
    }
}