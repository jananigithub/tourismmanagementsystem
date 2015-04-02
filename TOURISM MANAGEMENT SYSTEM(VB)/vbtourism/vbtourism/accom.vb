Public Class accom
    Dim A, B, C, D, E, F As Integer
    Dim P, Q, R, S, T, U As Integer
    Dim X As Integer
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            MsgBox("INVALID SELECTION")
        ElseIf ComboBox1.SelectedIndex = 1 Then
            ComboBox2.Items.Add("TAJ EXOTICA")
            ComboBox2.Items.Add("LEELA PALACE")
        ElseIf ComboBox1.SelectedIndex = 2 Then
            ComboBox2.Items.Add("NANU RESORT")
            ComboBox2.Items.Add("COCONUT GROVE")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Select Case package.domcb.SelectedIndex
            Case 1
                Select Case ComboBox1.SelectedIndex
                    Case 1
                        Select Case ComboBox2.SelectedIndex
                            Case 0
                                RATING.Text = "GOOD"
                                PictureBox1.Image = My.Resources.images__1_
                                RichTextBox1.Text = "20/322 ,CHETPET STREET,BALI"

                            Case 1
                                RATING.Text = "VGOOD"
                                PictureBox1.Image = My.Resources.images__10_

                                RichTextBox1.Text = "12 A ,SOUTH CAVE STREET,MAJORDA"
                        End Select
                    Case 2
                        Select Case ComboBox2.SelectedIndex
                            Case 0
                                RATING.Text = "GOOD"
                                PictureBox1.Image = My.Resources.images__11_

                                RichTextBox1.Text = "13 B ,GANDHI STREET,MARGAO"

                            Case 1
                                RATING.Text = "VGOOD"
                                PictureBox1.Image = My.Resources.images__10_

                                RichTextBox1.Text = "87 M ,NORTH CAVE STREET,BICHOLIM"
                        End Select
                End Select
            Case 2
                Select Case ComboBox1.SelectedIndex
                    Case 1
                        Select Case ComboBox2.SelectedIndex
                            Case 0
                                RATING.Text = "GOOD"
                                PictureBox1.Image = My.Resources.images__12_

                                RichTextBox1.Text = "67 F ,CHETPET STREET,ALAPPUZHA"

                            Case 1
                                RATING.Text = "VGOOD"
                                PictureBox1.Image = My.Resources.images__13_


                                RichTextBox1.Text = "20 G ,SOUTH CAVE STREET,ERNAKULAM"
                        End Select
                    Case 2
                        Select Case ComboBox2.SelectedIndex
                            Case 0
                                RATING.Text = "GOOD"
                                PictureBox1.Image = My.Resources.images__14_


                                RichTextBox1.Text = "56 E ,GANDHI STREET,MUNNAR"

                            Case 1
                                RATING.Text = "VGOOD"
                                PictureBox1.Image = My.Resources.images__15_


                                RichTextBox1.Text = "34 A ,NORTH CAVE STREET,THEKKADY"
                        End Select
                End Select
        End Select
        Select Case package.hiscb.SelectedIndex
            Case 1
                Select Case ComboBox1.SelectedIndex
                    Case 1
                        Select Case ComboBox2.SelectedIndex
                            Case 0
                                RATING.Text = "GOOD"
                                PictureBox1.Image = My.Resources.images__1_
                                RichTextBox1.Text = "90 J ,PATEL NAGAR,DELHI"

                            Case 1
                                RATING.Text = "VGOOD"
                                PictureBox1.Image = My.Resources.images__10_

                                RichTextBox1.Text = "322 A ,ANAND VIHAR,DELHI"
                        End Select
                    Case 2
                        Select Case ComboBox2.SelectedIndex
                            Case 0
                                RATING.Text = "GOOD"
                                PictureBox1.Image = My.Resources.images__11_

                                RichTextBox1.Text = "56 R ,KAILASH COLONY,DELHI"

                            Case 1
                                RATING.Text = "VGOOD"
                                PictureBox1.Image = My.Resources.images__10_

                                RichTextBox1.Text = "21 S ,NORTH CAVE STREET,DELHI"
                        End Select
                End Select
            Case 2
                Select Case ComboBox1.SelectedIndex
                    Case 1
                        Select Case ComboBox2.SelectedIndex
                            Case 0
                                RATING.Text = "GOOD"
                                PictureBox1.Image = My.Resources.images__12_

                                RichTextBox1.Text = "2 T,VIJAY NAGAR,MYSORE"

                            Case 1
                                RATING.Text = "VGOOD"
                                PictureBox1.Image = My.Resources.images__13_


                                RichTextBox1.Text = "23 D ,SOUTH CAVE STREET,MYSORE"
                        End Select
                    Case 2
                        Select Case ComboBox2.SelectedIndex
                            Case 0
                                RATING.Text = "GOOD"
                                PictureBox1.Image = My.Resources.images__14_


                                RichTextBox1.Text = "62 H ,GANDHI STREET,MYSORE"

                            Case 1
                                RATING.Text = "VGOOD"
                                PictureBox1.Image = My.Resources.images__15_


                                RichTextBox1.Text = "21 A ,NORTH CAVE STREET,MYSORE"
                        End Select
                End Select
        End Select

        Select Case package.pilgricb.SelectedIndex
            Case 1
                Select Case ComboBox1.SelectedIndex
                    Case 1
                        Select Case ComboBox2.SelectedIndex
                            Case 0
                                RATING.Text = "GOOD"
                                PictureBox1.Image = My.Resources.images__16_

                                RichTextBox1.Text = "12V ,CHETPET STREET,KANCHIPURAM"

                            Case 1
                                RATING.Text = "VGOOD"
                                PictureBox1.Image = My.Resources.images__3_


                                RichTextBox1.Text = "54 D ,SOUTH CAVE STREET,TIRUPATI"
                        End Select
                    Case 2
                        Select Case ComboBox2.SelectedIndex
                            Case 0
                                RATING.Text = "GOOD"
                                PictureBox1.Image = My.Resources.images__4_


                                RichTextBox1.Text = "22E ,GANDHI STREET,MADURAI"

                            Case 1
                                RATING.Text = "VGOOD"
                                PictureBox1.Image = My.Resources.images__5_


                                RichTextBox1.Text = "78 S ,NORTH CAVE STREET,SALEM"
                        End Select
                End Select
            Case 2
                Select Case ComboBox1.SelectedIndex
                    Case 1
                        Select Case ComboBox2.SelectedIndex
                            Case 0
                                RATING.Text = "GOOD"
                                PictureBox1.Image = My.Resources.images__6_


                                RichTextBox1.Text = "76 F ,CHETPET STREET,VELANKANI"

                            Case 1
                                RATING.Text = "VGOOD"
                                PictureBox1.Image = My.Resources.images__7_



                                RichTextBox1.Text = "98 G ,SOUTH CAVE STREET,TIRUCHY"
                        End Select
                    Case 2
                        Select Case ComboBox2.SelectedIndex
                            Case 0
                                RATING.Text = "GOOD"
                                PictureBox1.Image = My.Resources.images__8_



                                RichTextBox1.Text = "54 F ,GANDHI STREET,MADURAI"

                            Case 1
                                RATING.Text = "VGOOD"
                                PictureBox1.Image = My.Resources.images__9_



                                RichTextBox1.Text = "82G ,NORTH CAVE STREET,SALEM"
                        End Select
                End Select
        End Select
    End Sub

    Private Sub RATING_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RATING.Click

    End Sub

    Private Sub ROOMCB1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ROOMCB1.CheckedChanged

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub accom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub ROOMCB2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ROOMCB2.CheckedChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ROOMCB1.Checked = True Then
            A = 1000
        ElseIf ROOMCB1.Checked = False Then
            A = 0
        End If
        If ROOMCB2.Checked = True Then
            B = 5000
        ElseIf ROOMCB2.Checked = False Then
            B = 0
        End If
        If ROOMCB3.Checked = True Then
            C = 500
        ElseIf ROOMCB3.Checked = False Then
            C = 0
        End If
        If ROOMCB4.Checked = True Then
            D = 200
        ElseIf ROOMCB4.Checked = False Then
            D = 0
        End If
        If ROOMCB5.Checked = True Then
            F = 2000
        ElseIf ROOMCB5.Checked = False Then
            F = 0
        End If
        Label5.Text = A + B + C + D + F
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If SERVICECB2.Checked = True Then
            P = 3000
        ElseIf SERVICECB2.Checked = False Then
            P = 0
        End If
        If SERVICECB3.Checked = True Then
            Q = 2000
        ElseIf SERVICECB3.Checked = False Then
            Q = 0
        End If
        If SERVICECB4.Checked = True Then
            R = 4000
        ElseIf SERVICECB4.Checked = False Then
            R = 0
        End If
        If SERVICECB5.Checked = True Then
            S = 6000
        ElseIf SERVICECB5.Checked = False Then
            S = 0
        End If
        If SERVICECB6.Checked = True Then
            T = 5000
        ElseIf SERVICECB2.Checked = False Then
            T = 0
        End If
        If CheckBox2.Checked = True Then
            U = 10000
        ElseIf CheckBox2.Checked = True Then
            U = 0
        End If
        Label6.Text = P + Q + R + S + T + U





    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Select Case package.domcb.SelectedIndex
            Case 1
                Select Case ComboBox1.SelectedIndex
                    Case 1
                        Select Case ComboBox2.SelectedIndex
                            Case 0
                                Label7.Text = "20000"
                            Case 1
                                Label7.Text = "15000"
                        End Select
                    Case 2
                        Select Case ComboBox2.SelectedIndex
                            Case 0
                                Label7.Text = "30000"
                            Case 1
                                Label7.Text = "25000"
                        End Select
                End Select
            Case 2
                Select Case ComboBox1.SelectedIndex
                    Case 1
                        Select Case ComboBox2.SelectedIndex
                            Case 0
                               
                                Label7.Text = " 10000"
                            Case 1
                                Label7.Text = "15000"
                        End Select
                    Case 2
                        Select Case ComboBox2.SelectedIndex
                            Case 0
                                Label7.Text = " 19000"
                            Case 1
                                Label7.Text = " 15000"
                        End Select
                End Select
        End Select
        Select Case package.domcb.SelectedIndex
            Case 1
                Select Case ComboBox1.SelectedIndex
                    Case 1
                        Select Case ComboBox2.SelectedIndex
                            Case 0
                                Label7.Text = "30000"
                            Case 1
                                Label7.Text = "20000"
                        End Select
                    Case 2
                        Select Case ComboBox2.SelectedIndex
                            Case 0
                                Label7.Text = " 10000"
                            Case 1
                                Label7.Text = "17000"
                        End Select
                End Select
            Case 2
                Select Case ComboBox1.SelectedIndex
                    Case 1
                        Select Case ComboBox2.SelectedIndex
                            Case 0
                                Label7.Text = "23000"
                            Case 1
                                Label7.Text = " 20000"
                        End Select
                    Case 2
                        Select Case ComboBox2.SelectedIndex
                            Case 0
                               
                                Label7.Text = "24000"
                            Case 1
                                Label7.Text = "15000"
                        End Select
                End Select
        End Select

        Select Case package.hiscb.SelectedIndex
            Case 1
                Select Case ComboBox1.SelectedIndex
                    Case 1
                        Select Case ComboBox2.SelectedIndex
                            Case 0
                               
                                Label7.Text = " 17000"
                            Case 1
                                Label7.Text = "19000"
                        End Select
                    Case 2
                        Select Case ComboBox2.SelectedIndex
                            Case 0
                                Label7.Text = " 25000"
                            Case 1
                                Label7.Text = " 27000"
                        End Select
                End Select
            Case 2
                Select Case ComboBox1.SelectedIndex
                    Case 1
                        Select Case ComboBox2.SelectedIndex
                            Case 0
                                Label7.Text = "20000"

                            Case 1
                                Label7.Text = " 21000"
                        End Select
                    Case 2
                        Select Case ComboBox2.SelectedIndex
                            Case 0
                                Label7.Text = "22000"
                            Case 1
                                Label7.Text = "25000"

                        End Select
                End Select
        End Select
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        '  X = Val(Label5.Text) + Val(Label6.Text) + Val(Label7.Text)
        ' Label8.Text = X
        X = Label7.Text
        Label8.Text = A + B + C + D + F + P + Q + R + S + T + U + X

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        ' Label8.Text = Form1.Label10.Text
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
        GOA.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
















        transport.Show()
        ' transport.Label2.Text = A
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()
        pass.Show()
    End Sub
End Class