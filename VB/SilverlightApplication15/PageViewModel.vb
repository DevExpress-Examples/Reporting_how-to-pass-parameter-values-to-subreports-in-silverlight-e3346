Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Linq.Expressions
Imports System.Windows.Input
Imports DevExpress.Xpf.Bars
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Printing
' ...

Namespace SilverlightApplication15
	Public Class PageViewModel
		Implements INotifyPropertyChanged
		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
		Private privateReportPreviewModel As ReportPreviewModel
		Public Property ReportPreviewModel() As ReportPreviewModel
			Get
				Return privateReportPreviewModel
			End Get
			Private Set(ByVal value As ReportPreviewModel)
				privateReportPreviewModel = value
			End Set
		End Property
		Public Property SubreportParameter() As String
			Get
				Dim param = ReportPreviewModel.Parameters("xrSubreport1.parameter1")
				Return If(param IsNot Nothing, CStr(param.Value), Nothing)
			End Get
			Set(ByVal value As String)
				ReportPreviewModel.Parameters("xrSubreport1.parameter1").Value = value
				RaiseSubreportParameterPropertyChanged()
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

		Public Sub New()
			RecreateDocument = New DelegateCommand(AddressOf DoRecreateDocument, Function() True)
			ReportPreviewModel = New ReportPreviewModel("../ReportService1.svc") With {.ReportName = "SilverlightApplication15.Web.MasterReport"}
			AddHandler ReportPreviewModel.RequestDefaultParameterValues, AddressOf ReportPreviewModel_RequestDefaultParameterValues
		End Sub

		Private Sub ReportPreviewModel_RequestDefaultParameterValues(ByVal sender As Object, ByVal e As EventArgs)
			RaiseSubreportParameterPropertyChanged()
		End Sub

		Private Sub DoRecreateDocument()
			ReportPreviewModel.CreateDocument()
		End Sub

		Private Sub RaisePropertyChanged(Of T)(ByVal [property] As Expression(Of Func(Of T)))
			PropertyExtensions.RaisePropertyChanged(Me, PropertyChangedEvent, [property])
		End Sub

		Private Sub RaiseSubreportParameterPropertyChanged()
			RaisePropertyChanged(Function() SubreportParameter)
		End Sub
	End Class
End Namespace
