Public Class FrmTitre

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrTitre.Start()
    End Sub

    Private Sub tmrTitre_Tick(sender As Object, e As EventArgs) Handles tmrTitre.Tick
        Me.Close()
    End Sub
End Class