Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Windows.Input
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Core.Commands
Imports DevExpress.Xpf.Mvvm
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
        ReportPreviewModel = New ReportPreviewModel("../ReportService1.svc") With {
            .ReportName = "SilverlightApplication15.Web.MasterReport, SilverlightApplication15.Web"
        }
        RecreateDocument = New DelegateCommand(AddressOf ReportPreviewModel.CreateDocument)
    End Sub
End Class
