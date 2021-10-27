Imports System.Windows

Namespace DXCharts_Lesson3

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
            chartControl1.DataSource = New gspDataSetTableAdapters.GSPTableAdapter().GetData()
        End Sub
    End Class
End Namespace
