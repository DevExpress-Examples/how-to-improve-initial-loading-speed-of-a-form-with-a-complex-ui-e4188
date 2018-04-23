Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports System.Threading

Namespace RichEditLoadingSpeed
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
				'MessageBox.Show("EditForm has been initialized.");
			Dim thread As New Thread(AddressOf AnonymousMethod1)

			thread.SetApartmentState(ApartmentState.STA)
			thread.Priority = ThreadPriority.Highest
			thread.IsBackground = True
			thread.Start()

			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New Form1())
		End Sub
		
		Private Shared Sub AnonymousMethod1()
			Dim editForm As New EditForm()
		End Sub
	End Class
End Namespace