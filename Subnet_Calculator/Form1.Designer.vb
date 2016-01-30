<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtIP = New System.Windows.Forms.TextBox
        Me.txtSubnet = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblIP = New System.Windows.Forms.Label
        Me.lblSubnet = New System.Windows.Forms.Label
        Me.lblNetID = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txtIP
        '
        Me.txtIP.Location = New System.Drawing.Point(12, 12)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(123, 20)
        Me.txtIP.TabIndex = 0
        '
        'txtSubnet
        '
        Me.txtSubnet.Location = New System.Drawing.Point(12, 38)
        Me.txtSubnet.Name = "txtSubnet"
        Me.txtSubnet.Size = New System.Drawing.Size(122, 20)
        Me.txtSubnet.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'lblIP
        '
        Me.lblIP.AutoSize = True
        Me.lblIP.Location = New System.Drawing.Point(12, 61)
        Me.lblIP.Name = "lblIP"
        Me.lblIP.Size = New System.Drawing.Size(49, 13)
        Me.lblIP.TabIndex = 3
        Me.lblIP.Text = "Binary IP"
        '
        'lblSubnet
        '
        Me.lblSubnet.AutoSize = True
        Me.lblSubnet.Location = New System.Drawing.Point(12, 74)
        Me.lblSubnet.Name = "lblSubnet"
        Me.lblSubnet.Size = New System.Drawing.Size(73, 13)
        Me.lblSubnet.TabIndex = 4
        Me.lblSubnet.Text = "Binary Subnet"
        '
        'lblNetID
        '
        Me.lblNetID.AutoSize = True
        Me.lblNetID.Location = New System.Drawing.Point(12, 87)
        Me.lblNetID.Name = "lblNetID"
        Me.lblNetID.Size = New System.Drawing.Size(93, 13)
        Me.lblNetID.TabIndex = 5
        Me.lblNetID.Text = "Binary Network ID"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 145)
        Me.Controls.Add(Me.lblNetID)
        Me.Controls.Add(Me.lblSubnet)
        Me.Controls.Add(Me.lblIP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSubnet)
        Me.Controls.Add(Me.txtIP)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents txtSubnet As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblIP As System.Windows.Forms.Label
    Friend WithEvents lblSubnet As System.Windows.Forms.Label
    Friend WithEvents lblNetID As System.Windows.Forms.Label

End Class
