<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WinForm
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WinForm))
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextChange = New System.Windows.Forms.Timer(Me.components)
        Me.Retry = New System.Windows.Forms.Button
        Me.QuitButton = New System.Windows.Forms.Button
        Me.musicTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightGreen
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(40, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(518, 76)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Congratulations!"
        '
        'TextChange
        '
        Me.TextChange.Enabled = True
        Me.TextChange.Interval = 1300
        '
        'Retry
        '
        Me.Retry.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Retry.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Retry.ForeColor = System.Drawing.Color.Green
        Me.Retry.Location = New System.Drawing.Point(477, 94)
        Me.Retry.Name = "Retry"
        Me.Retry.Size = New System.Drawing.Size(126, 345)
        Me.Retry.TabIndex = 2
        Me.Retry.Text = "I'm gonna beat the game again!"
        Me.Retry.UseVisualStyleBackColor = False
        '
        'QuitButton
        '
        Me.QuitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.QuitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitButton.ForeColor = System.Drawing.Color.Green
        Me.QuitButton.Location = New System.Drawing.Point(17, 100)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(130, 338)
        Me.QuitButton.TabIndex = 3
        Me.QuitButton.Text = "I'm tired. I'll play again another day."
        Me.QuitButton.UseVisualStyleBackColor = False
        '
        'musicTimer
        '
        Me.musicTimer.Interval = 2200
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Frogger.My.Resources.Resources.froggerimage
        Me.PictureBox1.Location = New System.Drawing.Point(158, 93)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(307, 347)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'WinForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(619, 452)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.Retry)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "WinForm"
        Me.Text = "You win!!!"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextChange As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Retry As System.Windows.Forms.Button
    Friend WithEvents QuitButton As System.Windows.Forms.Button
    Friend WithEvents musicTimer As System.Windows.Forms.Timer
End Class
