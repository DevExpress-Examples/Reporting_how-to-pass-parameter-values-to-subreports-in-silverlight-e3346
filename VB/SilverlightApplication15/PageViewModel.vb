Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Windows.Input
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Core.Commands
Imports DevExpress.Xpf.Printing
' ...

Partial Public Class PageViewModel
    Implements INotifyPropertyChanged

    Public Property ReportPreviewModel() As ReportPreviewModel

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

    Public Property RecreateDocument() As ICommand

    Public Sub New()
        RecreateDocument = New DelegateCommand(Of Object)(AddressOf DoRecreateDocument)
        ReportPreviewModel = New ReportPreviewModel("../ReportService1.svc") With {.ReportName = "SilverlightApplication15.Web.MasterReport, SilverlightApplication15.Web"}
    End Sub

    Private Sub DoRecreateDocument(ByVal parameter As Object)
        ReportPreviewModel.CreateDocument()
    End Sub
End Class
