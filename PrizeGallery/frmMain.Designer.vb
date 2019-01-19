<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblPrizeVal = New System.Windows.Forms.Label()
        Me.lblWinnings = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblForfeit = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.timSpin = New System.Windows.Forms.Timer(Me.components)
        Me.picPrize = New System.Windows.Forms.PictureBox()
        CType(Me.picPrize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(151, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(561, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Panther Prize Gallery - Spin To Win Prizes"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(65, 138)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(122, 46)
        Me.lblResult.TabIndex = 1
        Me.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(62, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Prize Value:"
        '
        'lblPrizeVal
        '
        Me.lblPrizeVal.BackColor = System.Drawing.Color.White
        Me.lblPrizeVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrizeVal.Location = New System.Drawing.Point(65, 235)
        Me.lblPrizeVal.Name = "lblPrizeVal"
        Me.lblPrizeVal.Size = New System.Drawing.Size(122, 39)
        Me.lblPrizeVal.TabIndex = 3
        Me.lblPrizeVal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblWinnings
        '
        Me.lblWinnings.BackColor = System.Drawing.Color.White
        Me.lblWinnings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWinnings.Location = New System.Drawing.Point(65, 332)
        Me.lblWinnings.Name = "lblWinnings"
        Me.lblWinnings.Size = New System.Drawing.Size(122, 39)
        Me.lblWinnings.TabIndex = 5
        Me.lblWinnings.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(62, 305)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Your Total Winnings:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(77, 387)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 6
        '
        'lblForfeit
        '
        Me.lblForfeit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForfeit.ForeColor = System.Drawing.Color.Crimson
        Me.lblForfeit.Location = New System.Drawing.Point(60, 387)
        Me.lblForfeit.Name = "lblForfeit"
        Me.lblForfeit.Size = New System.Drawing.Size(130, 43)
        Me.lblForfeit.TabIndex = 7
        Me.lblForfeit.Text = "You Lose!"
        Me.lblForfeit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblForfeit.Visible = False
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(65, 447)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(122, 41)
        Me.btnStart.TabIndex = 8
        Me.btnStart.Text = "Start the Spin"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(65, 583)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(122, 41)
        Me.btnQuit.TabIndex = 9
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(65, 515)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(122, 41)
        Me.btnStop.TabIndex = 10
        Me.btnStop.Text = "Stop the Spin"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'timSpin
        '
        '
        'picPrize
        '
        Me.picPrize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPrize.Image = Global.PrizeGallery.My.Resources.Resources.prize_1
        Me.picPrize.Location = New System.Drawing.Point(249, 138)
        Me.picPrize.Name = "picPrize"
        Me.picPrize.Size = New System.Drawing.Size(174, 263)
        Me.picPrize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picPrize.TabIndex = 11
        Me.picPrize.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(898, 728)
        Me.Controls.Add(Me.picPrize)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblForfeit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblWinnings)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblPrizeVal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mystery Prizes"
        CType(Me.picPrize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblPrizeVal As Label
    Friend WithEvents lblWinnings As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblForfeit As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents timSpin As Timer
    Friend WithEvents picPrize As PictureBox
End Class
