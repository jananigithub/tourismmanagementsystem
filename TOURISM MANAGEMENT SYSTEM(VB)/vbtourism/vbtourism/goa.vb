Public Class GOA

    Private Sub day2lab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles day2lab.Click

    End Sub

    Private Sub VIEWSCHEDULEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VIEWSCHEDULEToolStripMenuItem.Click
        daylab.Text = a
        schgb.Visible = True
        MAPGB.Visible = False
        IMAGESSB.Visible = False
        Select Case package.domcb.SelectedIndex
            Case 0
                day1pb.Image = Nothing
            Case 1
                day1pb.Image = My.Resources.GOA1
                day2pb.Image = My.Resources.images__8_
                day1rb.Text = "DAY 1: CASTLE ROCK , MAHALASA TEMPLE"
                day2rb.Text = "DAY 2: NANAZ FORT  ,MORJIM BEACH"


            Case 2
                day1pb.Image = My.Resources.KERELA1
                day2pb.Image = My.Resources.KERELA2
                day1rb.Text = "DAY 1: IDUKKI WILDLIFE SANCTUARY , ALAPPUZHA BEACH"
                day2rb.Text = "DAY 2: THIRUNALI TEMPLE , KAPPIL BEACH "
        End Select
        Select Case package.pilgricb.SelectedIndex
            Case 0
                day1pb.Image = Nothing
            Case 1
                day1pb.Image = My.Resources.H1
                day2pb.Image = My.Resources.H2
                day1rb.Text = "DAY 1: MEENAKSHI AMMAN TEMPLE ,TANJORE PERIYA KOVIL"
                day2rb.Text = "DAY 2: KAMAKSHI AMMAN TEMPLE, TIRUPATI "

            Case 2
                day1pb.Image = My.Resources.C1
                day2pb.Image = My.Resources.C2
                day1rb.Text = "DAY 1: INFANT JESUS CHURCH , HOLY TRINITY CHURCH"
                day2rb.Text = "DAY 2: ST.GEORGE CHURCH,ST.THOMAS CHURCH "

        End Select
        Select Case package.hiscb.SelectedIndex
            Case 0
                day1pb.Image = Nothing
            Case 1
                day1pb.Image = My.Resources.D1
                day2pb.Image = My.Resources.D2
                day1rb.Text = "DAY 1: INDIA GATE , TAJ MAHAL ,RASHTRAPATI BHAVAN"

                day2rb.Text = " DAY 2: RED FORT,QUTUB MINAR,LOTUS TEMPLE"

            Case 2
                day1pb.Image = My.Resources.M1
                day2pb.Image = My.Resources.M2
                day1rb.Text = " DAY 1: MYSORE PALACE,LALITHA MAHAL,MYSORE ZOO"

                day2rb.Text = "DAY 2:WAX MUSEUM,BRINDAVAN GARDEN"

        End Select

    End Sub

    Private Sub GOA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        schgb.Visible = False
        MAPGB.Visible = False
        IMAGESSB.Visible = False
    End Sub

    Private Sub IMAGESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IMAGESToolStripMenuItem.Click
        Select Case package.domcb.SelectedIndex
            Case 0
                GOAPB1.Image = Nothing
                PB2.Image = Nothing
                PB3.Image = Nothing
            Case 1
                GOAPB1.Image = My.Resources.G1
                PB2.Image = My.Resources.G2
                PB3.Image = My.Resources.G3
            Case 2
                GOAPB1.Image = My.Resources.K1
                PB2.Image = My.Resources.K2
                PB3.Image = My.Resources.K3

        End Select
        Select Case package.pilgricb.SelectedIndex
            Case 0
                GOAPB1.Image = Nothing
                PB2.Image = Nothing
                PB3.Image = Nothing
            Case 1
                GOAPB1.Image = My.Resources.HH1
                PB2.Image = My.Resources.HH2
                PB3.Image = My.Resources.HH3
            Case 2
                GOAPB1.Image = My.Resources.CC1
                PB2.Image = My.Resources.CC2
                PB3.Image = My.Resources.CC3

        End Select
        Select Case package.hiscb.SelectedIndex
            Case 0
                GOAPB1.Image = Nothing
                PB2.Image = Nothing
                PB3.Image = Nothing
            Case 1
                GOAPB1.Image = My.Resources.DD1
                PB2.Image = My.Resources.DD2
                PB3.Image = My.Resources.DD3
            Case 2
                GOAPB1.Image = My.Resources.MM1
                PB2.Image = My.Resources.MM2
                PB3.Image = My.Resources.MM3

        End Select
        IMAGESSB.Visible = True
        schgb.Visible = False
        MAPGB.Visible = False
    End Sub

    Private Sub MAPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MAPToolStripMenuItem.Click
        MAPGB.Visible = True
        IMAGESSB.Visible = False
        schgb.Visible = False
        Form3.Show()
        Select Case package.domcb.SelectedIndex
            Case 0
                Form3.GOAMAP.Image = Nothing

            Case 1
                Form3.GOAMAP.Image = My.Resources.AAAG
            Case 2
                Form3.GOAMAP.Image = My.Resources.AAAK
        End Select
       
        Select Case package.hiscb.SelectedIndex
            Case 0
                Form3.GOAMAP.Image = Nothing

            Case 1
                Form3.GOAMAP.Image = My.Resources.AAA
            Case 2
                Form3.GOAMAP.Image = My.Resources.A2
        End Select
        Select Case package.pilgricb.SelectedIndex
            Case 0
                Form3.GOAMAP.Image = Nothing

            Case 1
                Form3.GOAMAP.Image = My.Resources.A1

            Case 2
                Form3.GOAMAP.Image = My.Resources.A1
        End Select


    End Sub

    Private Sub TRANSPORTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TRANSPORTToolStripMenuItem.Click
        transport.Show()
    End Sub

    Private Sub PICBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ACCOMODATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ACCOMODATIONToolStripMenuItem.Click
        accom.Show()
    End Sub

    Private Sub SHOWBILLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FOODToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Private Sub daylab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles daylab.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        package.Show()
    End Sub
End Class