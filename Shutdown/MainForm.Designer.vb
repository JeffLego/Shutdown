<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.txtMinutes = New System.Windows.Forms.TextBox()
        Me.txtSeconds = New System.Windows.Forms.TextBox()
        Me.lblSep1 = New System.Windows.Forms.Label()
        Me.lblSep2 = New System.Windows.Forms.Label()
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblMinutes = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me._timer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'txtHours
        '
        Me.txtHours.BackColor = System.Drawing.SystemColors.Window
        Me.txtHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHours.Location = New System.Drawing.Point(21, 80)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.ReadOnly = True
        Me.txtHours.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtHours.Size = New System.Drawing.Size(74, 80)
        Me.txtHours.TabIndex = 2
        Me.txtHours.TabStop = False
        Me.txtHours.Text = "00"
        '
        'txtMinutes
        '
        Me.txtMinutes.BackColor = System.Drawing.SystemColors.Window
        Me.txtMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinutes.Location = New System.Drawing.Point(182, 80)
        Me.txtMinutes.Name = "txtMinutes"
        Me.txtMinutes.ReadOnly = True
        Me.txtMinutes.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMinutes.Size = New System.Drawing.Size(74, 80)
        Me.txtMinutes.TabIndex = 1
        Me.txtMinutes.TabStop = False
        Me.txtMinutes.Text = "00"
        '
        'txtSeconds
        '
        Me.txtSeconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeconds.Location = New System.Drawing.Point(344, 80)
        Me.txtSeconds.Name = "txtSeconds"
        Me.txtSeconds.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSeconds.Size = New System.Drawing.Size(74, 80)
        Me.txtSeconds.TabIndex = 0
        Me.txtSeconds.Text = "00"
        '
        'lblSep1
        '
        Me.lblSep1.AutoSize = True
        Me.lblSep1.BackColor = System.Drawing.SystemColors.Control
        Me.lblSep1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSep1.Location = New System.Drawing.Point(118, 80)
        Me.lblSep1.Name = "lblSep1"
        Me.lblSep1.Size = New System.Drawing.Size(50, 73)
        Me.lblSep1.TabIndex = 10
        Me.lblSep1.Text = ":"
        Me.lblSep1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSep2
        '
        Me.lblSep2.AutoSize = True
        Me.lblSep2.BackColor = System.Drawing.SystemColors.Control
        Me.lblSep2.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSep2.Location = New System.Drawing.Point(280, 80)
        Me.lblSep2.Name = "lblSep2"
        Me.lblSep2.Size = New System.Drawing.Size(50, 73)
        Me.lblSep2.TabIndex = 10
        Me.lblSep2.Text = ","
        Me.lblSep2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSeconds
        '
        Me.lblSeconds.AutoSize = True
        Me.lblSeconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeconds.Location = New System.Drawing.Point(340, 35)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(96, 25)
        Me.lblSeconds.TabIndex = 5
        Me.lblSeconds.Text = "Seconds"
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHours.Location = New System.Drawing.Point(16, 35)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(69, 25)
        Me.lblHours.TabIndex = 6
        Me.lblHours.Text = "Hours"
        '
        'lblMinutes
        '
        Me.lblMinutes.AutoSize = True
        Me.lblMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinutes.Location = New System.Drawing.Point(177, 35)
        Me.lblMinutes.Name = "lblMinutes"
        Me.lblMinutes.Size = New System.Drawing.Size(88, 25)
        Me.lblMinutes.TabIndex = 7
        Me.lblMinutes.Text = "Minutes"
        '
        'btnCancel
        '
        Me.btnCancel.AutoSize = True
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(114, 175)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(79, 34)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.AutoSize = True
        Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(255, 175)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 34)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.ForeColor = System.Drawing.Color.Red
        Me.lblStatus.Location = New System.Drawing.Point(5, 212)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(251, 13)
        Me.lblStatus.TabIndex = 11
        Me.lblStatus.Text = "Shutdown in 88 Hours, 88 Minutes and 88 Seconds"
        Me.lblStatus.Visible = False
        '
        '_timer
        '
        Me._timer.Interval = 1000
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 226)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblMinutes)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.lblSeconds)
        Me.Controls.Add(Me.lblSep2)
        Me.Controls.Add(Me.lblSep1)
        Me.Controls.Add(Me.txtSeconds)
        Me.Controls.Add(Me.txtMinutes)
        Me.Controls.Add(Me.txtHours)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Shutdown"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtHours As System.Windows.Forms.TextBox
    Friend WithEvents txtMinutes As System.Windows.Forms.TextBox
    Friend WithEvents txtSeconds As System.Windows.Forms.TextBox
    Friend WithEvents lblSep1 As System.Windows.Forms.Label
    Friend WithEvents lblSep2 As System.Windows.Forms.Label
    Friend WithEvents lblSeconds As System.Windows.Forms.Label
    Friend WithEvents lblHours As System.Windows.Forms.Label
    Friend WithEvents lblMinutes As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents _timer As System.Windows.Forms.Timer

End Class
