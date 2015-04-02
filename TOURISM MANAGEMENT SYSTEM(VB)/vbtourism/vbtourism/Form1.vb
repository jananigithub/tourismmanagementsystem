Public Class Form1
    Dim A, B As Integer
    Dim X As Integer
    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        A = Val(transport.Label7.Text)
        Label9.Text = transport.Label7.Text
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        B = Val(accom.Label8.Text)
        Label10.Text = B
        Label10.Text = accom.Label8.Text
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Label2.Text = package.numnb.Value
        Label4.Text = package.entrytb.Text
        ' Label6.Text = user.conttb.Text
        Label8.Text = package.addtb.Text
        Label6.Text = package.domcb.SelectedItem

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
        GOA.Show()
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Label15.Text = (Val(Label9.Text) + Val(Label10.Text)) * package.numnb.Value
       
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Label13.Text = Val(Label15.Text) - Val(Label12.Text)
        '  X = Label13.Text

        '  MsgBox("GRAND TOTAL IS ", X)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Select Case Label15.Text
            Case Is < 60000
                Label12.Text = 5000
                MsgBox("discount amount-rs.5000")
            Case Is > 60000
                Label12.Text = 10000
                MsgBox("discount amount-rs.10000")
        End Select
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
        pass.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
        transport.Show()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.Close()
        pass.Close()
        package.Close()
        transport.Close()
        accom.Close()

        Form2.Close()
        GOA.Close()

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        If RichTextBox1.Text <> " " Then
            MsgBox("THANK YOU FOR THE FEEDBACK !! ")
        Else
            MsgBox("SKIP FEEDBACK: ENTER CLOSE ")
        End If
    End Sub
End Class