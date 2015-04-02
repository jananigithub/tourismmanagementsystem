Public Class user
    Dim I As Integer = 1
    Private Sub user_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub nationtb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub checkcb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkcb.CheckedChanged
        package.Show()
    End Sub

    Private Sub newbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newbtn.Click
        Dim a As Control

        ' For Each a In Me.Controls

        '  If TypeOf a Is NumericUpDown Then

        'a.Text = 0

        '        End If
        '       Next

        For Each a In Me.Controls

            If TypeOf a Is ComboBox Then

                a.Text = Nothing

            End If

        Next
        For Each a In Me.Controls

            If TypeOf a Is TextBox Then

                a.Text = Nothing

            End If

        Next
        For Each a In Me.Controls

            If TypeOf a Is RichTextBox Then

                a.Text = Nothing

            End If

        Next
        entrytb.Text = I
        I = I + 1
        numnb.Value = 0
        childnb.Value = 0
        adultnb.Value = 0
        seniornb.Value = 0
    End Sub

    Private Sub addlab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addlab.Click

    End Sub

    Private Sub addtb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addtb.TextChanged

    End Sub

    Private Sub childlab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles childlab.Click

    End Sub

    Private Sub adultlab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adultlab.Click

    End Sub

    Private Sub seniorlab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles seniorlab.Click

    End Sub

    Private Sub childnb_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles childnb.ValueChanged

    End Sub

    Private Sub adultnb_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles adultnb.ValueChanged

    End Sub

    Private Sub seniornb_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles seniornb.ValueChanged

    End Sub

    Private Sub numnb_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numnb.ValueChanged

    End Sub

    Private Sub numlab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numlab.Click

    End Sub

    Private Sub entrytb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles entrytb.TextChanged

    End Sub

    Private Sub entrylab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles entrylab.Click

    End Sub

    Private Sub titlab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles titlab.Click

    End Sub

    Private Sub checkgb_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkgb.Enter

    End Sub
End Class