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

namespace laba_2;

public partial class MainWindow : Window
{
    private List<RepairRequest> requests = new List<RepairRequest>();

    public MainWindow()
    {
        InitializeComponent();
        RequestsDataGrid.ItemsSource = requests;
    }

    private void AddRequest_Click(object sender, RoutedEventArgs e)
    {
        var addRequestWindow = new AddRequestWindow();
        if (addRequestWindow.ShowDialog() == true)
        {
            requests.Add(addRequestWindow.NewRequest);
            RequestsDataGrid.Items.Refresh();
        }
    }

    private void EditRequest_Click(object sender, RoutedEventArgs e)
    {
        var selectedRequest = RequestsDataGrid.SelectedItem as RepairRequest;
        if (selectedRequest != null)
        {
            var editRequestWindow = new EditRequestWindow(selectedRequest);
            if (editRequestWindow.ShowDialog() == true)
            {
                RequestsDataGrid.Items.Refresh();
            }
        }
    }
}