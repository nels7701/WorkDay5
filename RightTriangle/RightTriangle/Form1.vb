Option Strict On
Public Class Form1


    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim a As Double = CDbl(txtSideOne.Text)
        Dim b As Double = CDbl(txtSideTwo.Text)
        Dim c As Double

        c = calculate(a, b)
        txtHyp.Text = CStr(c)

    End Sub
    Function calculate(ByVal a As Double, ByVal b As Double) As Double

        Dim c As Double = Math.Round(Math.Sqrt(a ^ 2 + b ^ 2), 4)
        Return c
    End Function



End Class
