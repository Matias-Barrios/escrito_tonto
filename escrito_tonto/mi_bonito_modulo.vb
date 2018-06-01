Module mi_bonito_modulo
    Public Sub Limpiar_Feo()
        frmEstructurasWhile.txtResultadoMayor.Text = ""
        frmEstructurasWhile.txtResultadoMenor.Text = ""
    End Sub

    Public Sub Limpiar_Bien(ventana As Form)
        For Each control In ventana.Controls
            If TypeOf control Is TextBox Then
                control.Text = ""
            End If
        Next
    End Sub
End Module
