<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEstructurasWhile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCapturar10Numeros = New System.Windows.Forms.Button()
        Me.lblMayor = New System.Windows.Forms.Label()
        Me.lblMenor = New System.Windows.Forms.Label()
        Me.txtResultadoMayor = New System.Windows.Forms.TextBox()
        Me.txtResultadoMenor = New System.Windows.Forms.TextBox()
        Me.btnCapturar10Numeros_pero_bien = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCapturar10Numeros
        '
        Me.btnCapturar10Numeros.Location = New System.Drawing.Point(12, 12)
        Me.btnCapturar10Numeros.Name = "btnCapturar10Numeros"
        Me.btnCapturar10Numeros.Size = New System.Drawing.Size(210, 54)
        Me.btnCapturar10Numeros.TabIndex = 0
        Me.btnCapturar10Numeros.Text = "Capturar 10 numeros"
        Me.btnCapturar10Numeros.UseVisualStyleBackColor = True
        '
        'lblMayor
        '
        Me.lblMayor.AutoSize = True
        Me.lblMayor.Location = New System.Drawing.Point(12, 102)
        Me.lblMayor.Name = "lblMayor"
        Me.lblMayor.Size = New System.Drawing.Size(70, 13)
        Me.lblMayor.TabIndex = 1
        Me.lblMayor.Text = "El mayor es : "
        '
        'lblMenor
        '
        Me.lblMenor.AutoSize = True
        Me.lblMenor.Location = New System.Drawing.Point(12, 148)
        Me.lblMenor.Name = "lblMenor"
        Me.lblMenor.Size = New System.Drawing.Size(71, 13)
        Me.lblMenor.TabIndex = 2
        Me.lblMenor.Text = "El menor es : "
        '
        'txtResultadoMayor
        '
        Me.txtResultadoMayor.Location = New System.Drawing.Point(88, 99)
        Me.txtResultadoMayor.Name = "txtResultadoMayor"
        Me.txtResultadoMayor.Size = New System.Drawing.Size(97, 20)
        Me.txtResultadoMayor.TabIndex = 3
        '
        'txtResultadoMenor
        '
        Me.txtResultadoMenor.Location = New System.Drawing.Point(88, 145)
        Me.txtResultadoMenor.Name = "txtResultadoMenor"
        Me.txtResultadoMenor.Size = New System.Drawing.Size(97, 20)
        Me.txtResultadoMenor.TabIndex = 4
        '
        'btnCapturar10Numeros_pero_bien
        '
        Me.btnCapturar10Numeros_pero_bien.Location = New System.Drawing.Point(12, 188)
        Me.btnCapturar10Numeros_pero_bien.Name = "btnCapturar10Numeros_pero_bien"
        Me.btnCapturar10Numeros_pero_bien.Size = New System.Drawing.Size(210, 54)
        Me.btnCapturar10Numeros_pero_bien.TabIndex = 5
        Me.btnCapturar10Numeros_pero_bien.Text = "Capturar 10 numeros (Pero bien)"
        Me.btnCapturar10Numeros_pero_bien.UseVisualStyleBackColor = True
        '
        'frmEstructurasWhile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(235, 273)
        Me.Controls.Add(Me.btnCapturar10Numeros_pero_bien)
        Me.Controls.Add(Me.txtResultadoMenor)
        Me.Controls.Add(Me.txtResultadoMayor)
        Me.Controls.Add(Me.lblMenor)
        Me.Controls.Add(Me.lblMayor)
        Me.Controls.Add(Me.btnCapturar10Numeros)
        Me.Name = "frmEstructurasWhile"
        Me.Text = "Estructuras While"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCapturar10Numeros As Button
    Friend WithEvents lblMayor As Label
    Friend WithEvents lblMenor As Label
    Friend WithEvents txtResultadoMayor As TextBox
    Friend WithEvents txtResultadoMenor As TextBox
    Friend WithEvents btnCapturar10Numeros_pero_bien As Button
End Class
