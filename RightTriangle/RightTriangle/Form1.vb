Public Class Form1
    Sub calcSideC(ByVal Aside As Double, ByVal Bside As Double)
        Dim Cside As Double
        Cside = Math.Sqrt(Aside * Aside + Bside * Bside)
        txtSideC.Text = Cside.ToString("n2")
    End Sub
    Sub calcSideA(ByVal Cside As Double, ByVal Bside As Double)
        Dim Aside As Double
        Aside = Math.Sqrt(Cside * Cside - Bside * Bside)
        txtSideA.Text = Aside.ToString("n2")
    End Sub
    Sub calcSideB(ByVal Cside As Double, ByVal Aside As Double)
        Dim Bside As Double
        Bside = Math.Sqrt(Aside * Aside - Cside * Cside)
        txtSideB.Text = Bside.ToString("n2")
    End Sub
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Dim result As Double
        If radioC.Checked = True Then
            calcSideC(CDbl(txtSideA.Text), CDbl(txtSideB.Text))
        ElseIf radioA.Checked = True Then
            calcSideA(CDbl(txtSideC.Text), CDbl(txtSideB.Text))
        ElseIf radioB.Checked = True Then
            calcSideB(CDbl(txtSideA.Text), CDbl(txtSideC.Text))
        End If
    End Sub
End Class
