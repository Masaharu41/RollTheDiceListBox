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
        Me.components = New System.ComponentModel.Container()
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.RollButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.WriteCheckBox = New System.Windows.Forms.CheckBox()
        Me.DisplayToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'DisplayListBox
        '
        Me.DisplayListBox.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.ItemHeight = 32
        Me.DisplayListBox.Location = New System.Drawing.Point(34, 22)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(871, 324)
        Me.DisplayListBox.TabIndex = 0
        Me.DisplayToolTip.SetToolTip(Me.DisplayListBox, "Displays Dice Rolls")
        '
        'RollButton
        '
        Me.RollButton.Location = New System.Drawing.Point(34, 368)
        Me.RollButton.Name = "RollButton"
        Me.RollButton.Size = New System.Drawing.Size(257, 139)
        Me.RollButton.TabIndex = 1
        Me.RollButton.Text = "&Roll"
        Me.DisplayToolTip.SetToolTip(Me.RollButton, "Generates 1000 Dice Rolls")
        Me.RollButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(297, 368)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(273, 139)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "E&xit"
        Me.DisplayToolTip.SetToolTip(Me.ExitButton, "Exits Program" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'WriteCheckBox
        '
        Me.WriteCheckBox.AutoSize = True
        Me.WriteCheckBox.Location = New System.Drawing.Point(589, 368)
        Me.WriteCheckBox.Name = "WriteCheckBox"
        Me.WriteCheckBox.Size = New System.Drawing.Size(166, 29)
        Me.WriteCheckBox.TabIndex = 3
        Me.WriteCheckBox.Text = "Write To File"
        Me.DisplayToolTip.SetToolTip(Me.WriteCheckBox, "Writes the ListBox output to a .TXT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Find RollTheDice.txt")
        Me.WriteCheckBox.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'RollTheDiceListBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 620)
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
    Friend WithEvents DisplayToolTip As ToolTip
    Friend WithEvents ToolTip1 As ToolTip
End Class
