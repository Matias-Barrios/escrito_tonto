Public Class frmEstructurasWhile
    Dim numeros(9) As Integer

    Dim contador As Integer
    Dim numero_menor As Integer
    Dim numero_mayor As Integer

    Private Sub btnCapturar10Numeros_Click(sender As Object, e As EventArgs) Handles btnCapturar10Numeros.Click
        ' Codigo todo feo, largo e innecesario
        Limpiar_Feo()
        numero_menor = 999999
        numero_mayor = 0
        contador = 0

        While contador < 9
            numeros(contador) = Val(InputBox("Ingrese un numero"))
            contador = contador + 1
        End While

        contador = 0

        While contador < 9
            If numeros(contador) > numero_mayor Then
                numero_mayor = numeros(contador)
            End If
            contador = contador + 1
        End While

        contador = 0

        While contador < 9
            If numeros(contador) < numero_menor Then
                numero_menor = numeros(contador)
            End If
            contador = contador + 1
        End While

        txtResultadoMayor.Text = numero_mayor
        txtResultadoMenor.Text = numero_menor

        txtResultadoMayor.Focus()

        If Not IsNumeric(txtResultadoMayor.Text) Then
            MsgBox("Este resultado no es numerico")
        End If

        If Not IsNumeric(txtResultadoMenor.Text) Then
            MsgBox("Este resultado no es numerico")
        End If
    End Sub


    ' Todo mas prolijo aca abajo
    Private Sub btnCapturar10Numeros_pero_bien_Click(sender As Object, e As EventArgs) Handles btnCapturar10Numeros_pero_bien.Click
        Limpiar_Bien(Me)

        For index As Integer = 0 To numeros.Count - 1
            numeros(index) = Val(InputBox("Ingrese un numero"))
        Next

        txtResultadoMayor.Text = Val(numeros.Max())
        txtResultadoMenor.Text = Val(numeros.Min())

    End Sub
End Class
