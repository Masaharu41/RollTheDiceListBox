<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RollTheDiceListBox
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
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.RollButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.WriteCheckBox = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'DisplayListBox
        '
        Me.DisplayListBox.Font = New System.Drawing.Font("Consolas", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.ItemHeight = 24
        Me.DisplayListBox.Location = New System.Drawing.Point(34, 22)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(609, 220)
        Me.DisplayListBox.TabIndex = 0
        '
        'RollButton
        '
        Me.RollButton.Location = New System.Drawing.Point(34, 248)
        Me.RollButton.Name = "RollButton"
        Me.RollButton.Size = New System.Drawing.Size(143, 97)
        Me.RollButton.TabIndex = 1
        Me.RollButton.Text = "&Roll"
        Me.RollButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(183, 248)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(145, 97)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'WriteCheckBox
        '
        Me.WriteCheckBox.AutoSize = True
        Me.WriteCheckBox.Location = New System.Drawing.Point(483, 248)
        Me.WriteCheckBox.Name = "WriteCheckBox"
        Me.WriteCheckBox.Size = New System.Drawing.Size(166, 29)
        Me.WriteCheckBox.TabIndex = 4
        Me.WriteCheckBox.Text = "Write To File"
        Me.WriteCheckBox.UseVisualStyleBackColor = True
        '
        'RollTheDiceListBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.WriteCheckBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.RollButton)
        Me.Controls.Add(Me.DisplayListBox)
        Me.Name = "RollTheDiceListBox"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DisplayListBox As ListBox
    Friend WithEvents RollButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents WriteCheckBox As CheckBox
End Class
