Public Class Form1
    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        Dim num, x, i, m As Integer
        x = 1
        num = txt_num.Text
        For y = 1 To num
            x = x * y
        Next
        lbl_fct.Text = x.ToString()

        For i = 0 To x
            If (i Mod 4 = 0) Then
                m = m + 1
            End If
        Next
        lbl_mult.Text = m.ToString()
    End Sub
End Class
