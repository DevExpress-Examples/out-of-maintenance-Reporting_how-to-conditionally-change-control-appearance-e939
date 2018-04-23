Imports Microsoft.VisualBasic
Imports System
Namespace ConditionallyChangeAppearance
	Partial Public Class XtraReport1
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
			Me.nwindDataSet1 = New ConditionallyChangeAppearance.nwindDataSet()
			Me.productsTableAdapter = New ConditionallyChangeAppearance.nwindDataSetTableAdapters.ProductsTableAdapter()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2, Me.xrLabel1})
			Me.Detail.Font = New System.Drawing.Font("Arial", 9.75F)
			Me.Detail.Height = 33
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.StylePriority.UseFont = False
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "nwindDataSet"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' xrLabel1
			' 
			Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.ProductName", "")})
			Me.xrLabel1.Location = New System.Drawing.Point(8, 8)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrLabel1.Size = New System.Drawing.Size(242, 25)
			Me.xrLabel1.Text = "xrLabel1"
			' 
			' xrLabel2
			' 
			Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitPrice", "{0:$0.00}")})
			Me.xrLabel2.Location = New System.Drawing.Point(258, 8)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 10, 0, 0, 100F)
			Me.xrLabel2.Size = New System.Drawing.Size(100, 25)
			Me.xrLabel2.StylePriority.UsePadding = False
			Me.xrLabel2.StylePriority.UseTextAlignment = False
			Me.xrLabel2.Text = "xrLabel2"
			Me.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail})
			Me.DataAdapter = Me.productsTableAdapter
			Me.DataMember = "Products"
			Me.DataSource = Me.nwindDataSet1
			Me.Version = "8.3"
'			Me.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.XtraReport1_BeforePrint);
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private nwindDataSet1 As nwindDataSet
		Private productsTableAdapter As ConditionallyChangeAppearance.nwindDataSetTableAdapters.ProductsTableAdapter
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
	End Class
End Namespace
