Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.ComponentModel
Imports DevExpress.XtraEditors
Imports System.Windows.Forms
Imports System.Drawing
Imports DevExpress.XtraEditors.Registrator
Imports DevExpress.XtraEditors.Repository

Namespace RegisterCustomEditor
	<UserRepositoryItem("Register")> _
	Public Class RepositoryItemMyButtonEdit
		Inherits RepositoryItemButtonEdit
		Shared Sub New()
			Register()
		End Sub
		Public Sub New()
		End Sub

		Friend Const EditorName As String = "MyButtonEdit"

		Public Shared Sub Register()
            EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(EditorName, GetType(MyButtonEdit), GetType(RepositoryItemMyButtonEdit), GetType(DevExpress.XtraEditors.ViewInfo.ButtonEditViewInfo), New DevExpress.XtraEditors.Drawing.ButtonEditPainter(), True, EditImageIndexes.ButtonEdit))
		End Sub
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return EditorName
			End Get
		End Property
	End Class

	''' <summary>
	''' MyButtonEdit is a descendant from ButtonEdit.
	''' It displays a dialog form below the text box when the edit button is clicked.
	''' </summary>
	Public Class MyButtonEdit
		Inherits ButtonEdit
		Shared Sub New()
			RepositoryItemMyButtonEdit.Register()
		End Sub
		Public Sub New()
		End Sub

		Protected Overrides Sub OnKeyDown(ByVal e As KeyEventArgs)
			MyBase.OnKeyDown(e)
			Console.WriteLine("d")
		End Sub
		Protected Overrides Sub OnEnter(ByVal e As EventArgs)
			MyBase.OnEnter(e)
			Console.WriteLine("e")
		End Sub
		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemMyButtonEdit.EditorName
			End Get
		End Property
		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemMyButtonEdit
			Get
				Return TryCast(MyBase.Properties, RepositoryItemMyButtonEdit)
			End Get
		End Property

		Protected Overrides Sub OnClickButton(ByVal buttonInfo As DevExpress.XtraEditors.Drawing.EditorButtonObjectInfoArgs)
			ShowPopupForm()
			MyBase.OnClickButton(buttonInfo)
		End Sub
		Protected Overridable Sub ShowPopupForm()
			Using form As New Form()
				form.StartPosition = FormStartPosition.Manual
				form.Location = Me.PointToScreen(New Point(0, Height))
				form.ShowDialog()
			End Using
		End Sub
	End Class
End Namespace
