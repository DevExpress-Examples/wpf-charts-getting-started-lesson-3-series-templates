Imports Microsoft.VisualBasic
Imports System.Windows

Namespace DXCharts_Lesson3

	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()

			chartControl.DataSource = New gspDataSetTableAdapters.GSPTableAdapter().GetData()
		End Sub
	End Class
End Namespace
