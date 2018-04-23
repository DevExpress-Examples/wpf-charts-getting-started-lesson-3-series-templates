using System.Windows;

namespace WpfApplication1 {

    public partial class MainWindow : Window {
        public MainWindow () {
            InitializeComponent();
            chartControl1.DataSource = 
                new gspDataSetTableAdapters.GSPTableAdapter().GetData();

        }
    }
}
