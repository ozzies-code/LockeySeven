# LockeySeven

# Descripcion

 Este proyecto consiste en el desarrollo de una aplicacion que emplea
 la invisibilidad del objeto PictureBox del formulario siempre que 
 al hacer click sobre el boton Spin la combinacion de numeros que 
 apareceran a traves de las etiquetas que los contendran en un 
 proceso Aletorio con la funcion Random() de como resultado que ninguno 
 de los numeros que aparezcan en las etiquetas contenga al numero 7.
 Cuando el numero 7 aparezca, entonces la imagen del objeto PictureBox
 sera visible al usuario.
 
 # Actualizacion: 03/01/2025
 # Hora: 12:42

 Detalles técnicos del proyecto:
Idioma: Visual Basic.NET
Versión del framework: 4.7.2

 # LockeySeven

# Description

This project consists of the development of an application that uses
the invisibility of the form's PictureBox object whenever
clicking on the Spin button, the combination of numbers that
will appear through the labels that will contain them in a
Random process with the Random() function results in none of the
numbers that appear in the labels containing the number 7.
When the number 7 appears, then the image of the PictureBox object
will be visible to the user.

# Update: 01/03/2025
# Time: 12:42

Technical Details of the Project:
Language: Visual Basic.NET
Framework Version: 4.7.2

![imagen](https://github.com/user-attachments/assets/e224c1e8-71df-4a61-b2c2-1ac2662761f7)

Code of the Project:

Imports System.Reflection.Emit

Public Class frmLockeySeven

    Private Sub btnEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnd.Click
        End
    End Sub

    Private Sub btnSpin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpin.Click
        PictureBox1.Visible = False 'ocultar imagen
        lblNum1.Text = CStr(Int(Rnd() * 10)) 'elegir números
        lblNum2.Text = CStr(Int(Rnd() * 10))
        lblNum3.Text = CStr(Int(Rnd() * 10))
        'si algún número es 7 desplegar imagen y hacer un bip
        If (lblNum1.Text = "7") Or (lblNum2.Text = "7") _
    Or (lblNum3.Text = "7") Then
            PictureBox1.Visible = True
            Beep()
        End If
    End Sub
End Class

