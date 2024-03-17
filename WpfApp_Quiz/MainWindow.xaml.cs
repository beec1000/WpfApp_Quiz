using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_Quiz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            string Name = name.Text;
            string Age = age.Text;
            string Class = @class.Text;

            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Age) || string.IsNullOrWhiteSpace(Class))
            {
                MessageBox.Show("Kérjük, töltse ki a név, kor és osztály mezőket!", "Hiányzó adatok", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            string a1 = ((ListBoxItem)Question1ListBox.SelectedItem)?.Content.ToString() ?? "Nem adott választ";
            string a2 = ((ListBoxItem)Question2ListBox.SelectedItem)?.Content.ToString() ?? "Nem adott választ";
            string a3 = ((ListBoxItem)Question3ListBox.SelectedItem)?.Content.ToString() ?? "Nem adott választ";
            string a4 = ((ListBoxItem)Question4ListBox.SelectedItem)?.Content.ToString() ?? "Nem adott választ";
            string a5 = ((ListBoxItem)Question5ListBox.SelectedItem)?.Content.ToString() ?? "Nem adott választ";

            string m = $"Név: {Name}\nKor: {Age}\nOsztály: {Class}\n\n" +
                             $"1. válasz: {a1}\n2. válasz: {a2}\n3. válasz: {a3}\n4. válasz: {a4}\n5. válasz: {a5}";

            MessageBox.Show(m, "Válaszok", MessageBoxButton.OKCancel, MessageBoxImage.Information);
        }
    }
}