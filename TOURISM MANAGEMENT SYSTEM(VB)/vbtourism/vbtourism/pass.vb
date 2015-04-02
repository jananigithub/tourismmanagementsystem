Public Class pass

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "JANANI" And TextBox2.Text = "MNOP" Then
            package.Show()
        Else
            MsgBox("INVALID: TRY AGAIN")
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class