Imports Microsoft.VisualBasic
Imports System
Namespace RegisterCustomEditor
	Partial Public Class Form1

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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.myButtonEdit1 = New RegisterCustomEditor.MyButtonEdit
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl
            Me.dataTable1 = New System.Data.DataTable
            Me.dataColumn1 = New System.Data.DataColumn
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
            Me.colColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
            Me.repositoryItemMyButtonEdit1 = New RegisterCustomEditor.RepositoryItemMyButtonEdit
            Me.repositoryItemMyButtonEdit2 = New RegisterCustomEditor.RepositoryItemMyButtonEdit
            Me.dataSet1 = New System.Data.DataSet
            CType(Me.myButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemMyButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemMyButtonEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'myButtonEdit1
            '
            Me.myButtonEdit1.EditValue = "myButtonEdit1"
            Me.myButtonEdit1.Location = New System.Drawing.Point(13, 7)
            Me.myButtonEdit1.Name = "myButtonEdit1"
            Me.myButtonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.myButtonEdit1.Size = New System.Drawing.Size(120, 20)
            Me.myButtonEdit1.TabIndex = 0
            '
            'gridControl1
            '
            Me.gridControl1.DataSource = Me.dataTable1
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.gridControl1.Location = New System.Drawing.Point(0, 52)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemMyButtonEdit1, Me.repositoryItemMyButtonEdit2})
            Me.gridControl1.Size = New System.Drawing.Size(402, 208)
            Me.gridControl1.TabIndex = 1
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            '
            'dataTable1
            '
            Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.dataColumn1})
            Me.dataTable1.TableName = "Table1"
            '
            'dataColumn1
            '
            Me.dataColumn1.ColumnName = "Column1"
            '
            'gridView1
            '
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colColumn1})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
            '
            'colColumn1
            '
            Me.colColumn1.Caption = "Column1"
            Me.colColumn1.ColumnEdit = Me.repositoryItemMyButtonEdit1
            Me.colColumn1.FieldName = "Column1"
            Me.colColumn1.Name = "colColumn1"
            Me.colColumn1.Visible = True
            Me.colColumn1.VisibleIndex = 0
            '
            'repositoryItemMyButtonEdit1
            '
            Me.repositoryItemMyButtonEdit1.AutoHeight = False
            Me.repositoryItemMyButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.repositoryItemMyButtonEdit1.Name = "repositoryItemMyButtonEdit1"
            '
            'repositoryItemMyButtonEdit2
            '
            Me.repositoryItemMyButtonEdit2.AutoHeight = False
            Me.repositoryItemMyButtonEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
            Me.repositoryItemMyButtonEdit2.Name = "repositoryItemMyButtonEdit2"
            '
            'dataSet1
            '
            Me.dataSet1.DataSetName = "NewDataSet"
            Me.dataSet1.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dataSet1.Tables.AddRange(New System.Data.DataTable() {Me.dataTable1})
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(402, 260)
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.myButtonEdit1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.myButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemMyButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemMyButtonEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub


		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private dataSet1 As System.Data.DataSet
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private colColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemMyButtonEdit1 As RegisterCustomEditor.RepositoryItemMyButtonEdit
		Private myButtonEdit1 As RegisterCustomEditor.MyButtonEdit
		Private repositoryItemMyButtonEdit2 As RepositoryItemMyButtonEdit
	End Class
End Namespace
