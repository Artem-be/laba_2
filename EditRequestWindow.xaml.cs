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
    /// Логика взаимодействия для EditRequestWindow.xaml
    /// </summary>
    public partial class EditRequestWindow : Window
    {
        private RepairRequest _request;

        public EditRequestWindow(RepairRequest request)
        {
            InitializeComponent();
            _request = request;

            RequestNumberTextBox.Text = _request.RequestNumber.ToString();
            DateAddedPicker.SelectedDate = _request.DateAdded;
            CarTypeTextBox.Text = _request.CarType;
            CarModelTextBox.Text = _request.CarModel;
            ProblemDescriptionTextBox.Text = _request.ProblemDescription;
            ClientNameTextBox.Text = _request.ClientName;
            PhoneNumberTextBox.Text = _request.PhoneNumber;
            StatusComboBox.SelectedItem = StatusComboBox.Items.Cast<ComboBoxItem>().FirstOrDefault(item => item.Content.ToString() == _request.Status);
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            _request.CarType = CarTypeTextBox.Text;
            _request.CarModel = CarModelTextBox.Text;
            _request.ProblemDescription = ProblemDescriptionTextBox.Text;
            _request.ClientName = ClientNameTextBox.Text;
            _request.PhoneNumber = PhoneNumberTextBox.Text;
            _request.Status = (StatusComboBox.SelectedItem as ComboBoxItem).Content.ToString();

            DialogResult = true;
        }
    }
}
