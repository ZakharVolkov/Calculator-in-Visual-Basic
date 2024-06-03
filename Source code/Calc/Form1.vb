Imports System.Drawing.Text

Public Class Form1
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If String.IsNullOrEmpty(TextBox1.Text) AndAlso String.IsNullOrEmpty(Label1.Text) Then
            TextBox1.Text = "0,"
        Else
            TextBox1.Text = TextBox1.Text + "0"
        End If

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text + "1"

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text + "2"

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text + "3"

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text + "4"

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text + "5"

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text + "6"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text + "7"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text + "8"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text + "9"

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text = TextBox1.Text + ","
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If String.IsNullOrEmpty(TextBox1.Text) Then
            TextBox1.Text = ""
        Else
            TextBox1.Text = TextBox1.Text * (-1)
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Label1.Text = TextBox1.Text
        Label2.Text = "+"
        TextBox1.Text = ""
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Label1.Text = TextBox1.Text
        Label2.Text = "-"
        TextBox1.Text = ""
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Label1.Text = TextBox1.Text
        Label2.Text = "x"
        TextBox1.Text = ""
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Label1.Text = TextBox1.Text
        Label2.Text = "÷"
        TextBox1.Text = ""
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TextBox1.Text = Math.Sqrt(TextBox1.Text)

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox1.Text = TextBox1.Text * TextBox1.Text
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim number1 As Decimal
        Dim number2 As Decimal

        If Decimal.TryParse(Label1.Text, number1) AndAlso Decimal.TryParse(TextBox1.Text, number2) Then
            If Label2.Text = "+" Then
                TextBox1.Text = (number1 + number2).ToString()
                Label1.Text = ""
                Label2.Text = "="
            ElseIf Label2.Text = "-" Then
                TextBox1.Text = (number1 - number2).ToString()
                Label1.Text = ""
                Label2.Text = "="
            ElseIf Label2.Text = "x" Then
                TextBox1.Text = (number1 * number2).ToString()
                Label1.Text = ""
                Label2.Text = "="
            ElseIf Label2.Text = "÷" Then
                If number2 <> 0 Then
                    TextBox1.Text = (number1 / number2).ToString()
                    Label1.Text = ""
                    Label2.Text = "="
                Else
                    TextBox1.Text = "Error"
                    Label1.Text = ""
                    Label2.Text = ""
                End If
            End If
        Else
            TextBox1.Text = "Error"
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Label1.Text = ""
        Label2.Text = ""
        TextBox1.Text = ""
    End Sub

End Class
