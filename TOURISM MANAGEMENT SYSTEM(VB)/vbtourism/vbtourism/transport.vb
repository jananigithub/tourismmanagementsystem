Public Class transport
    Dim A As String
    Dim I As Integer
    Private Sub CARCHECK_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CARCHECK.CheckedChanged
        Select Case package.domcb.SelectedIndex
            Case 0
                MsgBox("INVALID SELECTION")
            Case 1

                If CATCARCB.SelectedIndex = "0" Then
                    MsgBox("INVALID SELECTION")
                ElseIf CATCARCB.SelectedIndex = "1" Then
                    TYPECARCB.Items.Add("SELECT")
                    TYPECARCB.Items.Add("TATA INDICA")
                    TYPECARCB.Items.Add("FORD FIGO")
                Else : CATCARCB.SelectedIndex = "2"
                    TYPECARCB.Items.Add("SELECT")
                    TYPECARCB.Items.Add("BMW")
                    TYPECARCB.Items.Add("AUDI")


                End If

            Case 2

                If CATCARCB.SelectedIndex = "0" Then
                    MsgBox("INVALID SELECTION")
                ElseIf CATCARCB.SelectedIndex = "1" Then
                    TYPECARCB.Items.Add("SELECT")

                    TYPECARCB.Items.Add("TATA INDICA")
                    TYPECARCB.Items.Add("FORD FIGO")
                Else : CATCARCB.SelectedIndex = "2"
                    TYPECARCB.Items.Add("SELECT")
                    TYPECARCB.Items.Add("BMW")
                    TYPECARCB.Items.Add("AUDI")


                End If
        End Select
        Select Case package.pilgricb.SELECTEDINDEX
            Case 0
                MsgBox("INVALID SELECTION")
            Case 1

                If CATCARCB.SelectedIndex = "0" Then
                    MsgBox("INVALID SELECTION")
                ElseIf CATCARCB.SelectedIndex = "1" Then
                    TYPECARCB.Items.Add("SELECT")
                    TYPECARCB.Items.Add("TATA INDICA")
                    TYPECARCB.Items.Add("FORD FIGO")
                Else : CATCARCB.SelectedIndex = "2"
                    TYPECARCB.Items.Add("SELECT")
                    TYPECARCB.Items.Add("BMW")
                    TYPECARCB.Items.Add("AUDI")


                End If

            Case 2

                If CATCARCB.SelectedIndex = "0" Then
                    MsgBox("INVALID SELECTION")
                ElseIf CATCARCB.SelectedIndex = "1" Then
                    TYPECARCB.Items.Add("SELECT")

                    TYPECARCB.Items.Add("TATA INDICA")
                    TYPECARCB.Items.Add("FORD FIGO")
                Else : CATCARCB.SelectedIndex = "2"
                    TYPECARCB.Items.Add("SELECT")
                    TYPECARCB.Items.Add("BMW")
                    TYPECARCB.Items.Add("AUDI")


                End If
        End Select
        Select Case package.hiscb.SelectedIndex
            Case 0
                MsgBox("INVALID SELECTION")
            Case 1

                If CATCARCB.SelectedIndex = "0" Then
                    MsgBox("INVALID SELECTION")
                ElseIf CATCARCB.SelectedIndex = "1" Then
                    TYPECARCB.Items.Add("SELECT")
                    TYPECARCB.Items.Add("TATA INDICA")
                    TYPECARCB.Items.Add("FORD FIGO")
                Else : CATCARCB.SelectedIndex = "2"
                    TYPECARCB.Items.Add("SELECT")
                    TYPECARCB.Items.Add("BMW")
                    TYPECARCB.Items.Add("AUDI")


                End If

            Case 2

                If CATCARCB.SelectedIndex = "0" Then
                    MsgBox("INVALID SELECTION")
                ElseIf CATCARCB.SelectedIndex = "1" Then
                    TYPECARCB.Items.Add("SELECT")

                    TYPECARCB.Items.Add("TATA INDICA")
                    TYPECARCB.Items.Add("FORD FIGO")
                Else : CATCARCB.SelectedIndex = "2"
                    TYPECARCB.Items.Add("SELECT")
                    TYPECARCB.Items.Add("BMW")
                    TYPECARCB.Items.Add("AUDI")


                End If
        End Select

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TYPECARCB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TYPECARCB.SelectedIndexChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Select Case CATCARCB.SelectedIndex
            Case 0
                MsgBox("INVALID SELECTION")
            Case 1
                Select Case TYPECARCB.SelectedIndex
                    Case 0
                        MsgBox("INVALID SELECTION")
                    Case 1
                        PictureBox1.Image = My.Resources.TT1
                        PictureBox2.Image = My.Resources.TT2
                        Label8.Text = 10000
                    Case 2
                        PictureBox1.Image = My.Resources.FF1
                        PictureBox2.Image = My.Resources.FF2
                        Label8.Text = 15000
                End Select
            Case 2
                Select Case TYPECARCB.SelectedIndex
                    Case 0
                        MsgBox("INVALID SELECTION")
                    Case 1
                        PictureBox1.Image = My.Resources.BB1
                        PictureBox2.Image = My.Resources.BB2
                        Label8.Text = 25000
                    Case 2
                        PictureBox1.Image = My.Resources.AA1
                        PictureBox2.Image = My.Resources.AA2
                        Label8.Text = 35000
                End Select
        End Select
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub TRAVELCB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TRAVELCB.SelectedIndexChanged
        I = TRAVELCB.SelectedIndex
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If I = 0 Then
            MsgBox("SELECT THE TYPE OF TRAVEL")

        ElseIf I = 1 Then
            Label7.Text = Label8.Text
        ElseIf I = 2 Then
            Label7.Text = 10000 + Label8.Text
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        GOA.Show()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Label2.Text = A
    End Sub

    Private Sub transport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
        pass.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
        accom.Show()
    End Sub
End Class