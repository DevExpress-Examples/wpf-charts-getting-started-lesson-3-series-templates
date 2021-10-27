using System.Windows;

namespace DXCharts_Lesson3 {
    
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            chartControl.DataSource =
                new gspDataSetTableAdapters.GSPTableAdapter().GetData();
        }
    }
}
