
Public Class Form1
    Dim kBacklitColor As System.Drawing.Color
    Dim kNotBacklitColor As System.Drawing.Color

    '-------------------------------------------
    '           My cool stuff                   
    '-------------------------------------------

    Sub TurnBklOn()
        screen.SelectionStart = Len(screen.Text)
        screen.SelectionLength = 0
        screen.BackColor = kBacklitColor
        bklTimer.Enabled = False
        bklTimer.Enabled = True
    End Sub

    Sub TurnBklOff()
        screen.SelectionStart = Len(screen.Text)
        screen.SelectionLength = 0
        screen.BackColor = kNotBacklitColor
        bklTimer.Enabled = False
    End Sub

    Sub TypeIn(ByVal Str As String)
        screen.SelectionStart = Len(screen.Text)
        screen.SelectionLength = 0
        TurnBklOn()
        screen.Text = screen.Text + Str
    End Sub

    Sub TypeInNo(ByVal No As Integer)
        screen.SelectionStart = Len(screen.Text)
        screen.SelectionLength = 0
        TurnBklOn()
        screen.Text = screen.Text + CStr(No)
    End Sub

    Sub SetScreen(ByVal Str As String)
        screen.SelectionStart = Len(screen.Text)
        screen.SelectionLength = 0
        TurnBklOn()
        screen.Text = Str
    End Sub

    Sub BkSpOnScreen()
        screen.SelectionStart = 0
        On Error GoTo errka
        screen.SelectionLength = Len(screen.Text) - 1
        Dim temp
        temp = screen.SelectedText
        SetScreen(temp)
errka:

    End Sub

    '-------------------------------------------
    '           UI stuff                        
    '-------------------------------------------

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        kBacklitColor = Color.Cyan
        kNotBacklitColor = Color.LightGray
        TurnBklOn()
        telefon.CommPort = My.Settings.ComNO
        telefon.Settings = "9600,N,8,1"
        telefon.PortOpen = True
 
    End Sub

    Private Sub Setting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Setting.Click
        Dialog1.ShowDialog()
    End Sub

    Private Sub bklTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bklTimer.Tick
        TurnBklOff()
    End Sub

    '-----------------------------------------------
    '               Numbers                         
    '-----------------------------------------------

    Private Sub N1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N1.Click
        TypeInNo(1)
    End Sub

    Private Sub N2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N2.Click
        TypeInNo(2)
    End Sub

    Private Sub N3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles N3.Click
        TypeInNo(3)
    End Sub

    Private Sub n4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles n4.Click
        TypeInNo(4)
    End Sub

    Private Sub n5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles n5.Click
        TypeInNo(5)
    End Sub

    Private Sub n6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles n6.Click
        TypeInNo(6)
    End Sub

    Private Sub n7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles n7.Click
        TypeInNo(7)
    End Sub

    Private Sub n8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles n8.Click
        TypeInNo(8)
    End Sub

    Private Sub n9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles n9.Click
        TypeInNo(9)
    End Sub

    Private Sub star_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles star.Click
        TypeIn("*")
    End Sub

    Private Sub n0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles n0.Click
        TypeInNo(0)
    End Sub

    Private Sub pound_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pound.Click
        TypeIn("#")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SetScreen("")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        BkSpOnScreen()
    End Sub

    Private Sub answ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles answ.Click
        Dim OUT As String
        TurnBklOn()
        OUT = "atd"
        If screen.Text <> "" Then
            If My.Settings.Type = "T" Then
                OUT = OUT + "t" + screen.Text
            Else
                OUT = OUT + "p" + screen.Text
            End If
        Else
            OUT = "ata"
        End If
        telefon.Output = OUT + vbCrLf
        answ.Enabled = False
        hangup.Enabled = True
        digits.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False

    End Sub

    Private Sub hangup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hangup.Click
        telefon.Output = "ata" + vbCrLf
        Button2.Enabled = True
        Button3.Enabled = True
        TurnBklOn()
        answ.Enabled = True
        hangup.Enabled = False
        digits.Enabled = True
    End Sub

    Private Sub telefon_OnComm(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles telefon.OnComm
        MsgBox("Oncomm " + telefon.Input)
    End Sub
End Class
