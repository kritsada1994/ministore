Public Class Frm_Sale
    Private Sub Frm_Sale_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mdiform As New Frm_Order
        mdiform.IsMdiContainer = True
        mdiform.Show()
    End Sub
End Class