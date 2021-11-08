Public Class formPrincipal


    Private Sub VScrollBar_ValueChanged(sender As Object, e As EventArgs) Handles vsbR.ValueChanged, vsbG.ValueChanged, vsbB.ValueChanged

        txtR.Text = CStr(vsbR.Value)
        txtG.Text = CStr(vsbG.Value)
        txtB.Text = CStr(vsbB.Value)

        lblColor.BackColor = System.Drawing.Color.FromArgb(vsbR.Value, vsbG.Value, vsbB.Value)

    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.lblR.Text = "R"
        lblR.ForeColor = Color.Red
        Me.lblG.Text = "G"
        lblG.ForeColor = Color.Green
        Me.lblB.Text = "B"
        lblB.ForeColor = Color.Blue

    End Sub

End Class
