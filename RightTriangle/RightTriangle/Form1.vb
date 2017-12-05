Public Class Form1
    Sub calcSideC(ByVal Aside As Double, ByVal Bside As Double)
        Dim Cside As Double
        Cside = Math.Sqrt(Aside * Aside + Bside * Bside)
        txtSideC.Text = Cside.ToString
    End Sub
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Dim result As Double
        If radioC.Checked = True Then
            calcSideC(CDbl(txtSideA.Text), CDbl(txtSideB.Text))
        End If
    End Sub
End Class
