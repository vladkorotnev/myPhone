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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.telefon = New AxMSCommLib.AxMSComm
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.screen = New System.Windows.Forms.TextBox
        Me.bklTimer = New System.Windows.Forms.Timer(Me.components)
        Me.digits = New System.Windows.Forms.Panel
        Me.N2 = New System.Windows.Forms.Button
        Me.pound = New System.Windows.Forms.Button
        Me.n9 = New System.Windows.Forms.Button
        Me.n5 = New System.Windows.Forms.Button
        Me.star = New System.Windows.Forms.Button
        Me.n0 = New System.Windows.Forms.Button
        Me.n4 = New System.Windows.Forms.Button
        Me.n6 = New System.Windows.Forms.Button
        Me.n7 = New System.Windows.Forms.Button
        Me.n8 = New System.Windows.Forms.Button
        Me.N3 = New System.Windows.Forms.Button
        Me.N1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Setting = New System.Windows.Forms.ToolStripButton
        Me.answ = New System.Windows.Forms.Button
        Me.hangup = New System.Windows.Forms.Button
        CType(Me.telefon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.digits.SuspendLayout()
        Me.SuspendLayout()
        '
        'telefon
        '
        Me.telefon.Enabled = True
        Me.telefon.Location = New System.Drawing.Point(243, 268)
        Me.telefon.Name = "telefon"
        Me.telefon.OcxState = CType(resources.GetObject("telefon.OcxState"), System.Windows.Forms.AxHost.State)
        Me.telefon.Size = New System.Drawing.Size(38, 38)
        Me.telefon.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Setting})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(314, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'screen
        '
        Me.screen.BackColor = System.Drawing.Color.LightGray
        Me.screen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.screen.Font = New System.Drawing.Font("Square721 BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.screen.ForeColor = System.Drawing.Color.DimGray
        Me.screen.Location = New System.Drawing.Point(0, 29)
        Me.screen.Name = "screen"
        Me.screen.Size = New System.Drawing.Size(314, 33)
        Me.screen.TabIndex = 2
        '
        'bklTimer
        '
        Me.bklTimer.Interval = 5000
        '
        'digits
        '
        Me.digits.Controls.Add(Me.pound)
        Me.digits.Controls.Add(Me.n9)
        Me.digits.Controls.Add(Me.star)
        Me.digits.Controls.Add(Me.n5)
        Me.digits.Controls.Add(Me.n0)
        Me.digits.Controls.Add(Me.n4)
        Me.digits.Controls.Add(Me.n6)
        Me.digits.Controls.Add(Me.n7)
        Me.digits.Controls.Add(Me.n8)
        Me.digits.Controls.Add(Me.N1)
        Me.digits.Controls.Add(Me.N2)
        Me.digits.Controls.Add(Me.N3)
        Me.digits.Location = New System.Drawing.Point(70, 140)
        Me.digits.Name = "digits"
        Me.digits.Size = New System.Drawing.Size(167, 230)
        Me.digits.TabIndex = 3
        '
        'N2
        '
        Me.N2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.N2.Location = New System.Drawing.Point(59, 4)
        Me.N2.Name = "N2"
        Me.N2.Size = New System.Drawing.Size(50, 50)
        Me.N2.TabIndex = 11
        Me.N2.Text = "2"
        Me.N2.UseVisualStyleBackColor = True
        '
        'pound
        '
        Me.pound.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.pound.Location = New System.Drawing.Point(114, 172)
        Me.pound.Name = "pound"
        Me.pound.Size = New System.Drawing.Size(50, 50)
        Me.pound.TabIndex = 10
        Me.pound.Text = "#"
        Me.pound.UseVisualStyleBackColor = True
        '
        'n9
        '
        Me.n9.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.n9.Location = New System.Drawing.Point(114, 116)
        Me.n9.Name = "n9"
        Me.n9.Size = New System.Drawing.Size(50, 50)
        Me.n9.TabIndex = 9
        Me.n9.Text = "9"
        Me.n9.UseVisualStyleBackColor = True
        '
        'n5
        '
        Me.n5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.n5.Location = New System.Drawing.Point(59, 60)
        Me.n5.Name = "n5"
        Me.n5.Size = New System.Drawing.Size(50, 50)
        Me.n5.TabIndex = 8
        Me.n5.Text = "5"
        Me.n5.UseVisualStyleBackColor = True
        '
        'star
        '
        Me.star.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.star.Location = New System.Drawing.Point(3, 172)
        Me.star.Name = "star"
        Me.star.Size = New System.Drawing.Size(50, 50)
        Me.star.TabIndex = 7
        Me.star.Text = "*"
        Me.star.UseVisualStyleBackColor = True
        '
        'n0
        '
        Me.n0.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.n0.Location = New System.Drawing.Point(59, 172)
        Me.n0.Name = "n0"
        Me.n0.Size = New System.Drawing.Size(50, 50)
        Me.n0.TabIndex = 6
        Me.n0.Text = "0"
        Me.n0.UseVisualStyleBackColor = True
        '
        'n4
        '
        Me.n4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.n4.Location = New System.Drawing.Point(3, 60)
        Me.n4.Name = "n4"
        Me.n4.Size = New System.Drawing.Size(50, 50)
        Me.n4.TabIndex = 5
        Me.n4.Text = "4"
        Me.n4.UseVisualStyleBackColor = True
        '
        'n6
        '
        Me.n6.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.n6.Location = New System.Drawing.Point(114, 60)
        Me.n6.Name = "n6"
        Me.n6.Size = New System.Drawing.Size(50, 50)
        Me.n6.TabIndex = 4
        Me.n6.Text = "6"
        Me.n6.UseVisualStyleBackColor = True
        '
        'n7
        '
        Me.n7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.n7.Location = New System.Drawing.Point(3, 116)
        Me.n7.Name = "n7"
        Me.n7.Size = New System.Drawing.Size(50, 50)
        Me.n7.TabIndex = 3
        Me.n7.Text = "7"
        Me.n7.UseVisualStyleBackColor = True
        '
        'n8
        '
        Me.n8.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.n8.Location = New System.Drawing.Point(59, 116)
        Me.n8.Name = "n8"
        Me.n8.Size = New System.Drawing.Size(50, 50)
        Me.n8.TabIndex = 2
        Me.n8.Text = "8"
        Me.n8.UseVisualStyleBackColor = True
        '
        'N3
        '
        Me.N3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.N3.Location = New System.Drawing.Point(115, 4)
        Me.N3.Name = "N3"
        Me.N3.Size = New System.Drawing.Size(50, 50)
        Me.N3.TabIndex = 1
        Me.N3.Text = "3"
        Me.N3.UseVisualStyleBackColor = True
        '
        'N1
        '
        Me.N1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.N1.Location = New System.Drawing.Point(3, 4)
        Me.N1.Name = "N1"
        Me.N1.Size = New System.Drawing.Size(50, 50)
        Me.N1.TabIndex = 0
        Me.N1.Text = "1"
        Me.N1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Yellow
        Me.Button2.Location = New System.Drawing.Point(157, 66)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(28, 56)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "C"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(129, 66)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(30, 56)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Bksp"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Setting
        '
        Me.Setting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Setting.Image = CType(resources.GetObject("Setting.Image"), System.Drawing.Image)
        Me.Setting.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Setting.Name = "Setting"
        Me.Setting.Size = New System.Drawing.Size(50, 22)
        Me.Setting.Text = "Settings"
        '
        'answ
        '
        Me.answ.BackColor = System.Drawing.Color.Lime
        Me.answ.Image = Global.WindowsApplication1.My.Resources.Resources.answer
        Me.answ.Location = New System.Drawing.Point(0, 65)
        Me.answ.Name = "answ"
        Me.answ.Size = New System.Drawing.Size(130, 57)
        Me.answ.TabIndex = 4
        Me.answ.UseVisualStyleBackColor = False
        '
        'hangup
        '
        Me.hangup.BackColor = System.Drawing.Color.Red
        Me.hangup.Enabled = False
        Me.hangup.Image = Global.WindowsApplication1.My.Resources.Resources.hangup
        Me.hangup.Location = New System.Drawing.Point(185, 65)
        Me.hangup.Name = "hangup"
        Me.hangup.Size = New System.Drawing.Size(130, 57)
        Me.hangup.TabIndex = 5
        Me.hangup.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 392)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.digits)
        Me.Controls.Add(Me.screen)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.telefon)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.answ)
        Me.Controls.Add(Me.hangup)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Phone"
        CType(Me.telefon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.digits.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents telefon As AxMSCommLib.AxMSComm
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Setting As System.Windows.Forms.ToolStripButton
    Friend WithEvents screen As System.Windows.Forms.TextBox
    Friend WithEvents bklTimer As System.Windows.Forms.Timer
    Friend WithEvents digits As System.Windows.Forms.Panel
    Friend WithEvents N2 As System.Windows.Forms.Button
    Friend WithEvents pound As System.Windows.Forms.Button
    Friend WithEvents n9 As System.Windows.Forms.Button
    Friend WithEvents n5 As System.Windows.Forms.Button
    Friend WithEvents star As System.Windows.Forms.Button
    Friend WithEvents n0 As System.Windows.Forms.Button
    Friend WithEvents n4 As System.Windows.Forms.Button
    Friend WithEvents n6 As System.Windows.Forms.Button
    Friend WithEvents n7 As System.Windows.Forms.Button
    Friend WithEvents n8 As System.Windows.Forms.Button
    Friend WithEvents N3 As System.Windows.Forms.Button
    Friend WithEvents N1 As System.Windows.Forms.Button
    Friend WithEvents answ As System.Windows.Forms.Button
    Friend WithEvents hangup As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
