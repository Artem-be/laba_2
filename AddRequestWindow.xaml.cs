using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace laba_2
{
    /// <summary>
    /// Логика взаимодействия для AddRequestWindow.xaml
    /// </summary>
    public partial class AddRequestWindow : Window
    {
        public RepairRequest NewRequest { get; private set; }

        public AddRequestWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            NewRequest = new RepairRequest
            {
                RequestNumber = int.Parse(RequestNumberTextBox.Text),
                DateAdded = DateAddedPicker.SelectedDate.Value,
                CarType = CarTypeTextBox.Text,
                CarModel = CarModelTextBox.Text,
                ProblemDescription = ProblemDescriptionTextBox.Text,
                ClientName = ClientNameTextBox.Text,
                PhoneNumber = PhoneNumberTextBox.Text,
                Status = (StatusComboBox.SelectedItem as ComboBoxItem).Content.ToString()
            };

            DialogResult = true;
        }
    }
}
