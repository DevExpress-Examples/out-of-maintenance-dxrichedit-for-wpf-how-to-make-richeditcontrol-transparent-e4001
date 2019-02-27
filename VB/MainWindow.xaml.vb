Imports System.Drawing
Imports System.Windows
Imports DevExpress.XtraRichEdit
Imports DevExpress.Office.Utils
Imports DevExpress.XtraRichEdit.API.Native

Namespace RichEditTransparentWpf
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub richEditControl1_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			richEditControl1.ApplyTemplate()
			richEditControl1.Views.SimpleView.BackColor = Color.Transparent
			richEditControl1.Views.DraftView.BackColor = Color.Transparent
			richEditControl1.Options.HorizontalRuler.Visibility = RichEditRulerVisibility.Hidden
			richEditControl1.Options.VerticalRuler.Visibility = RichEditRulerVisibility.Hidden

			Dim firstSection As Section = richEditControl1.Document.Sections(0)
			firstSection.Margins.Left = 0
			firstSection.Margins.Top = 0
			firstSection.Margins.Right = 0
			firstSection.Margins.Bottom = 0
			firstSection.Page.Width = Units.InchesToDocumentsF(2.3F)
			firstSection.Page.Height = Units.InchesToDocumentsF(3F)
		End Sub
	End Class
End Namespace
