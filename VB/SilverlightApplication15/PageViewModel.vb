Imports Microsoft.VisualBasic
Imports System.ComponentModel
Imports System.Windows.Input
Imports DevExpress.Mvvm
Imports DevExpress.Xpf.Printing
' ...

Namespace SilverlightApplication15
	Partial Public Class PageViewModel
		Implements INotifyPropertyChanged
		Private privateReportPreviewModel As ReportServicePreviewModel
		Public Property ReportPreviewModel() As ReportServicePreviewModel
			Get
				Return privateReportPreviewModel
			End Get
			Private Set(ByVal value As ReportServicePreviewModel)
				privateReportPreviewModel = value
			End Set
		End Property
		Private privateRecreateDocument As ICommand
		Public Property RecreateDocument() As ICommand
			Get
				Return privateRecreateDocument
			End Get
			Private Set(ByVal value As ICommand)
				privateRecreateDocument = value
			End Set
		End Property

		Public Property SubreportParameter() As String
			Get
				Dim param = ReportPreviewModel.Parameters("xrSubreport1.parameter1")
				Return If(param IsNot Nothing, CStr(param.Value), String.Empty)
			End Get
			Set(ByVal value As String)
				ReportPreviewModel.Parameters("xrSubreport1.parameter1").Value = value
				RaisePropertyChanged("SubreportParameter")
			End Set
		End Property

		Public Sub New()
			ReportPreviewModel = New ReportServicePreviewModel("../ReportService1.svc") With {.ReportName = "SilverlightApplication15.Web.MasterReport, SilverlightApplication15.Web"}
            RecreateDocument = New DelegateCommand(AddressOf ReportPreviewModel.CreateDocument)
		End Sub
	End Class
End Namespace
