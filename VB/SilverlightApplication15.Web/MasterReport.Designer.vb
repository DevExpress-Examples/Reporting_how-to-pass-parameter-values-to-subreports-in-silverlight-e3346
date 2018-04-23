Imports Microsoft.VisualBasic
Imports System
Namespace SilverlightApplication15.Web
	Partial Public Class MasterReport
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
			Me.xrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.detailReport1 = New SilverlightApplication15.Web.DetailReport()
			CType(Me.detailReport1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLine1, Me.xrSubreport1, Me.xrLabel1})
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLine1
			' 
			Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 36.99999F)
			Me.xrLine1.Name = "xrLine1"
			Me.xrLine1.SizeF = New System.Drawing.SizeF(649.9999F, 10.5F)
			' 
			' xrSubreport1
			' 
			Me.xrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 54.12499F)
			Me.xrSubreport1.Name = "xrSubreport1"
			Me.xrSubreport1.ReportSource = Me.detailReport1
			Me.xrSubreport1.SizeF = New System.Drawing.SizeF(100F, 23F)
			' 
			' xrLabel1
			' 
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(100F, 23F)
			Me.xrLabel1.Text = "Master"
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' MasterReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin})
			Me.Version = "11.1"
			CType(Me.detailReport1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private xrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
		Private xrLine1 As DevExpress.XtraReports.UI.XRLine
		Private detailReport1 As DetailReport
	End Class
End Namespace
