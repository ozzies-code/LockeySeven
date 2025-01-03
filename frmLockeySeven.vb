Imports System.Reflection.Emit

Public Class frmLockeySeven

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        End
    End Sub

    Private Sub btnSpin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpin.Click
        PictureBox1.Visible = False 'ocultar imagen
        lblNum1.Text = CStr(Int(Rnd() * 10)) 'elegir números
        lblNum2.Text = CStr(Int(Rnd() * 10))
        lblNum3.Text = CStr(Int(Rnd() * 10))
        'si algún número es 7 desplegar imagen y hacer un bip
        If (lblNum1.Text = "7") Or (lblNum2.Text = "7") _
    Or (lblNum3.Text = "7") Then
            PictureBox1.Visible = True
            Beep()
        End If
    End Sub
End Class

