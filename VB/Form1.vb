Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace RichEditLoadingSpeed
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			System.Threading.Thread.Sleep(5000) ' Emulate initialization delay
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim editForm As New EditForm()
			editForm.ShowDialog()
		End Sub
	End Class
End Namespace