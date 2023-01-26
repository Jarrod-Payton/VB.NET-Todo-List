<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TodoList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.inputField = New System.Windows.Forms.TextBox()
        Me.List = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'addBtn
        '
        Me.addBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.addBtn.Location = New System.Drawing.Point(12, 12)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(250, 37)
        Me.addBtn.TabIndex = 0
        Me.addBtn.Text = "Add Item"
        Me.addBtn.UseVisualStyleBackColor = False
        '
        'inputField
        '
        Me.inputField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.inputField.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputField.Location = New System.Drawing.Point(12, 55)
        Me.inputField.Name = "inputField"
        Me.inputField.Size = New System.Drawing.Size(250, 26)
        Me.inputField.TabIndex = 1
        Me.inputField.Text = "Add an Item...."
        '
        'List
        '
        Me.List.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.List.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.List.FormattingEnabled = True
        Me.List.ItemHeight = 19
        Me.List.Location = New System.Drawing.Point(12, 85)
        Me.List.Name = "List"
        Me.List.Size = New System.Drawing.Size(250, 363)
        Me.List.TabIndex = 3
        '
        'TodoList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(284, 461)
        Me.Controls.Add(Me.List)
        Me.Controls.Add(Me.inputField)
        Me.Controls.Add(Me.addBtn)
        Me.Name = "TodoList"
        Me.Text = "Todo List"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents addBtn As Button
    Friend WithEvents inputField As TextBox
    Friend WithEvents List As ListBox
End Class
