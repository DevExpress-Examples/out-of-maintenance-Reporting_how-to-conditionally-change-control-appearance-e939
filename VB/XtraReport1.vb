Imports Microsoft.VisualBasic
Imports System.Drawing
Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI
' ...

Namespace ConditionallyChangeAppearance
	Partial Public Class XtraReport1
		Inherits XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub XtraReport1_BeforePrint(ByVal sender As Object, ByVal e As PrintEventArgs) Handles MyBase.BeforePrint
			' Create a new rule and add it to a report.
			Dim rule As New FormattingRule()
			Me.FormattingRuleSheet.Add(rule)

			' Specify the rule's properties.
			rule.DataSource = Me.DataSource
			rule.DataMember = Me.DataMember
			rule.Condition = "[UnitPrice] >= 30"
			rule.Formatting.BackColor = Color.WhiteSmoke
			rule.Formatting.ForeColor = Color.IndianRed
			rule.Formatting.Font = New Font("Arial", 10, FontStyle.Bold)

			' Apply this rule to the detail band.
			Me.Detail.FormattingRules.Add(rule)
		End Sub

	End Class
End Namespace
