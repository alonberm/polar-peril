<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class YouWon
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
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.PlayAgain = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'QuitButton
        '
        Me.QuitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.QuitButton.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.QuitButton.FlatAppearance.BorderSize = 2
        Me.QuitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.QuitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.QuitButton.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitButton.Location = New System.Drawing.Point(159, 359)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(160, 51)
        Me.QuitButton.TabIndex = 5
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'PlayAgain
        '
        Me.PlayAgain.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PlayAgain.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.PlayAgain.FlatAppearance.BorderSize = 2
        Me.PlayAgain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PlayAgain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua
        Me.PlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PlayAgain.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayAgain.Location = New System.Drawing.Point(159, 250)
        Me.PlayAgain.Name = "PlayAgain"
        Me.PlayAgain.Size = New System.Drawing.Size(160, 51)
        Me.PlayAgain.TabIndex = 4
        Me.PlayAgain.Text = "Play Again"
        Me.PlayAgain.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 74.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(413, 121)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "YOU WON"
        Me.Label1.UseMnemonic = False
        '
        'YouWon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.PlayAgain)
        Me.Controls.Add(Me.Label1)
        Me.Name = "YouWon"
        Me.Text = "YouWon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents QuitButton As Button
    Friend WithEvents PlayAgain As Button
    Friend WithEvents Label1 As Label
End Class
