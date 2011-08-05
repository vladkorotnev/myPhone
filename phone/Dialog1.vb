Imports System.Windows.Forms

Public Class Dialog1

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Dialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Settings.Reload()
        NumericUpDown1.Value = My.Settings.ComNO
        Select Case My.Settings.Type
            Case "T"
                RadioButton1.Checked = True
                RadioButton2.Checked = False
            Case "P"
                RadioButton1.Checked = False
                RadioButton2.Checked = True
        End Select
    End Sub


    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged
        My.Settings.ComNO = NumericUpDown1.Value
        My.Settings.Save()
        My.Settings.Reload()

    End Sub



    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        My.Settings.Type = "T"
        My.Settings.Save()
        My.Settings.Reload()
        Select Case My.Settings.Type
            Case "T"
                RadioButton1.Checked = True
                RadioButton2.Checked = False
            Case "P"
                RadioButton1.Checked = False
                RadioButton2.Checked = True
        End Select
    End Sub

    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        My.Settings.Type = "P"
        My.Settings.Save()
        My.Settings.Reload()
        Select Case My.Settings.Type
            Case "T"
                RadioButton1.Checked = True
                RadioButton2.Checked = False
            Case "P"
                RadioButton1.Checked = False
                RadioButton2.Checked = True
        End Select
    End Sub
End Class
