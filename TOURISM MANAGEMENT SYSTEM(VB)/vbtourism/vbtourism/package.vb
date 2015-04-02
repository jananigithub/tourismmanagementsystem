Public Class package
    Dim I As Integer = 1
    Dim B As Control
    Dim a As Integer
    Dim msg As String
    Private Sub studrb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub check1cb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles check1cb.CheckedChanged
        If packcb.SelectedIndex = "1" Then
            domgb.Visible = True
            pilgrigb.Visible = False
            hisgb.Visible = False
        ElseIf packcb.SelectedIndex = "2" Then
            pilgrigb.Visible = True
            domgb.Visible = False
            hisgb.Visible = False
        Else : packcb.SelectedIndex = "3"
            hisgb.Visible = True
            domgb.Visible = False
            pilgrigb.Visible = False
        End If
    End Sub

    Private Sub package_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        domgb.Visible = False
        pilgrigb.Visible = False
        hisgb.Visible = False
    End Sub

    Private Sub proceedcb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub nextbtn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nextbtn1.Click
        If domcb.SelectedIndex = "0" Then
            MsgBox("PLEASE FILL THE DETAILS")
        ElseIf domcb.SelectedIndex = "1" Then
            '  msg = "no of days"
            a = 2
            GOA.Show()
        ElseIf domcb.SelectedIndex = "2" Then
            a = 2
            GOA.Show()
        ElseIf pilgricb.SelectedIndex = "0" Then

            MsgBox("PLEASE FILL THE DETAILS")
        ElseIf pilgricb.SelectedIndex = "1" Then
            GOA.Show()
        ElseIf pilgricb.SelectedIndex = "2" Then
            GOA.Show()
        ElseIf hiscb.SelectedIndex = "0" Then
            MsgBox("PLEASE FILL THE DETAILS")
        ElseIf hiscb.SelectedIndex = "1" Then
            GOA.Show()
        Else : hiscb.SelectedIndex = "2"
            GOA.Show()





        End If
    End Sub

    Private Sub spclrb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub famrb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub pilgricb_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pilgricb.SelectedIndexChanged

    End Sub

    Private Sub addtb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addtb.TextChanged

    End Sub

    Private Sub checkcb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkcb.CheckedChanged
        If numnb.Value = childnb.Value + adultnb.Value + seniornb.Value Then
            MsgBox("DETAILS VALID")
        Else
            MsgBox("DETAILS INVALID:PLEASE CHECK")
        End If
        ' packcb.Items.Add("select")
        ' packcb.Items.Add("domestic")
        ' packcb.Items.Add("pilgrimage")
        ' packcb.Items.Add("historical")
    End Sub

    Private Sub newbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newbtn.Click
        Dim B As Control

        For Each B In Me.Controls

            If TypeOf B Is ComboBox Then

                B.Text = Nothing

            End If

        Next
        For Each B In Me.Controls

            If TypeOf B Is TextBox Then

                B.Text = Nothing

            End If

        Next
        For Each B In Me.Controls

            If TypeOf B Is RichTextBox Then

                B.Text = Nothing

            End If

        Next
        entrytb.Text = I
        I = I + 1
        numnb.Value = 0
        childnb.Value = 0
        adultnb.Value = 0
        seniornb.Value = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        pass.Show()
    End Sub
End Class