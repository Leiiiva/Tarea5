Public Class Form1
    Private Sub lbl_mult_Click(sender As Object, e As EventArgs) Handles lbl_mult.Click

    End Sub

    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        Dim num, x, i As Integer
        x = 1
        num = txt_num.Text
        For y = 1 To num
            x = x * y
        Next
        lbl_fct.Text = x.ToString()
    End Sub
End Class
