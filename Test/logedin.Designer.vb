<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class logedin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(logedin))
        Me.Button5 = New System.Windows.Forms.Button()
        Me.lblupdate2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblscore = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.AutoSize = True
        Me.Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), System.Drawing.Image)
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(88, 136)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(127, 35)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "Erase file"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'lblupdate2
        '
        Me.lblupdate2.AutoSize = True
        Me.lblupdate2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblupdate2.ForeColor = System.Drawing.Color.White
        Me.lblupdate2.Location = New System.Drawing.Point(82, 9)
        Me.lblupdate2.Name = "lblupdate2"
        Me.lblupdate2.Size = New System.Drawing.Size(136, 31)
        Me.lblupdate2.TabIndex = 17
        Me.lblupdate2.Text = "Best Time"
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(88, 95)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(127, 35)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Start"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lblscore
        '
        Me.lblscore.AutoSize = True
        Me.lblscore.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblscore.ForeColor = System.Drawing.Color.White
        Me.lblscore.Location = New System.Drawing.Point(83, 52)
        Me.lblscore.Name = "lblscore"
        Me.lblscore.Size = New System.Drawing.Size(24, 25)
        Me.lblscore.TabIndex = 18
        Me.lblscore.Text = "0"
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(113, 177)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 35)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'logedin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(311, 224)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.lblupdate2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.lblscore)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "logedin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "logedin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents lblupdate2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents lblscore As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
