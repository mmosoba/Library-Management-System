<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnAdd = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        btnClear = New Button()
        txtTitle = New TextBox()
        txtAuthor = New TextBox()
        txtYearPublished = New TextBox()
        txtGenre = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        dgvBooks = New DataGridView()
        Label5 = New Label()
        CType(dgvBooks, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.Location = New Point(39, 246)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 0
        btnAdd.Text = "btnAdd"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.Location = New Point(39, 302)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(75, 23)
        btnUpdate.TabIndex = 1
        btnUpdate.Text = "btnUpdate"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.Location = New Point(148, 246)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 2
        btnDelete.Text = "btnDelete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(148, 302)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 3
        btnClear.Text = "btnClear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' txtTitle
        ' 
        txtTitle.Location = New Point(162, 40)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(172, 23)
        txtTitle.TabIndex = 5
        ' 
        ' txtAuthor
        ' 
        txtAuthor.Location = New Point(162, 86)
        txtAuthor.Name = "txtAuthor"
        txtAuthor.Size = New Size(172, 23)
        txtAuthor.TabIndex = 6
        ' 
        ' txtYearPublished
        ' 
        txtYearPublished.Location = New Point(162, 133)
        txtYearPublished.Name = "txtYearPublished"
        txtYearPublished.Size = New Size(172, 23)
        txtYearPublished.TabIndex = 7
        ' 
        ' txtGenre
        ' 
        txtGenre.Location = New Point(162, 184)
        txtGenre.Name = "txtGenre"
        txtGenre.Size = New Size(172, 23)
        txtGenre.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(39, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 19)
        Label1.TabIndex = 9
        Label1.Text = "Tittle"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(39, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 19)
        Label2.TabIndex = 10
        Label2.Text = "Author"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(39, 141)
        Label3.Name = "Label3"
        Label3.Size = New Size(107, 19)
        Label3.TabIndex = 11
        Label3.Text = "Year Published"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(39, 192)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 19)
        Label4.TabIndex = 12
        Label4.Text = "Genre"
        ' 
        ' dgvBooks
        ' 
        dgvBooks.BackgroundColor = SystemColors.AppWorkspace
        dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBooks.Location = New Point(340, 40)
        dgvBooks.Name = "dgvBooks"
        dgvBooks.Size = New Size(448, 297)
        dgvBooks.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(136, 11)
        Label5.Name = "Label5"
        Label5.Size = New Size(407, 26)
        Label5.TabIndex = 14
        Label5.Text = "LIBRARY MANAGEMENT SYSTEM"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Goldenrod
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(dgvBooks)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtGenre)
        Controls.Add(txtYearPublished)
        Controls.Add(txtAuthor)
        Controls.Add(txtTitle)
        Controls.Add(btnClear)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnAdd)
        Name = "Form1"
        Text = "Form1"
        CType(dgvBooks, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtYearPublished As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvBooks As DataGridView
    Friend WithEvents Label5 As Label

End Class
