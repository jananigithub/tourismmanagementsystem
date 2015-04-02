Public Class Form2

    Private Sub Table2BindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Table2BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Table2BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database5DataSet)

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database5DataSet.Table2' table. You can move, or remove it, as needed.
        Me.Table2TableAdapter.Fill(Me.Database5DataSet.Table2)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Table2BindingSource.AddNew()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        pass.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        package.Show()
    End Sub
End Class