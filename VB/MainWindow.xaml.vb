Imports Microsoft.VisualBasic
Imports System.Windows

Namespace WpfApplication1

	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
			chartControl1.DataSource = New gspDataSetTableAdapters.GSPTableAdapter().GetData()

		End Sub
	End Class
End Namespace
