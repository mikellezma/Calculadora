Public Class Form1
    Dim operador1 As Double
    Dim operador2 As Double
    Dim respuesta As Double
    Dim op As Char
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        operador2 = TextPantalla.Text()
        TextPantalla.Clear()
        Select Case op
            Case "+"
                respuesta = operador1 + operador2
            Case "-"
                respuesta = operador1 - operador2
            Case "x"
                respuesta = operador1 * operador2
            Case "/"
                respuesta = operador1 / operador2
            Case Else
                respuesta = 0
        End Select
        TextPantalla.Text = respuesta
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextPantalla.Text = TextPantalla.Text & "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextPantalla.Text = TextPantalla.Text & "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextPantalla.Text = TextPantalla.Text & "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextPantalla.Text = TextPantalla.Text & "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextPantalla.Text = TextPantalla.Text & "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextPantalla.Text = TextPantalla.Text & "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextPantalla.Text = TextPantalla.Text & "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextPantalla.Text = TextPantalla.Text & "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextPantalla.Text = TextPantalla.Text & "9"
    End Sub

    Private Sub btnPunto_Click(sender As Object, e As EventArgs) Handles btnPunto.Click

        Dim texto As String = TextPantalla.Text
        If texto.IndexOf(".") > 0 Then
        Else
            TextPantalla.Text = TextPantalla.Text & "."
        End If



    End Sub

    Private Sub btnCero_Click(sender As Object, e As EventArgs) Handles btnCero.Click
        TextPantalla.Text = TextPantalla.Text & "0"
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        op = "/"
        operador1 = TextPantalla.Text()
        TextPantalla.Clear()
    End Sub

    Private Sub btnMultiplicacion_Click(sender As Object, e As EventArgs) Handles btnMultiplicacion.Click
        op = "x"
        operador1 = TextPantalla.Text()
        TextPantalla.Clear()
    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        op = "-"
        operador1 = TextPantalla.Text()
        TextPantalla.Clear()
    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        op = "+"
        operador1 = TextPantalla.Text()
        TextPantalla.Clear()
    End Sub

    Private Sub TextPantalla_TextChanged(sender As Object, e As EventArgs) Handles TextPantalla.TextChanged

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles control.Click
        For Each control As Control In Controls
            If TypeOf control Is TextBox Then
                control.Text = "" 'eliminar el texto 
            End If
        Next
    End Sub
End Class
