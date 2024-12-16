Public Class Form1
    Dim f As Double
    Dim s As Double
    Dim a As Double
    Dim op As String
    Dim n As Int32
    Private Sub RoundButton_Click(sender As Object, e As EventArgs) Handles RoundButton22.Click, RoundButton23.Click, RoundButton24.Click, RoundButton17.Click, RoundButton18.Click, RoundButton19.Click, RoundButton12.Click, RoundButton13.Click, RoundButton14.Click, RoundButton28.Click, RoundButton29.Click, RoundButton36.Click
        Dim b As Button = sender
        If Label1.Text = "0" Then
            Label1.Text = b.Text
        Else
            Label1.Text = Label1.Text + b.Text
        End If
    End Sub

    Private Sub RoundButton4_Click(sender As Object, e As EventArgs) Handles RoundButton4.Click
        Label1.Text = "0"
        Label2.Text = ""
    End Sub

    Private Sub RoundButton37_Click(sender As Object, e As EventArgs) Handles RoundButton37.Click
        Label1.Text = "0"
        Label2.Text = ""
    End Sub

    Private Sub Arithmetic_function(sender As Object, e As EventArgs) Handles RoundButton25.Click, RoundButton20.Click, RoundButton15.Click, RoundButton10.Click, RoundButton32.Click, RoundButton26.Click
        Dim ops As Button = sender
        f = Label1.Text
        Label2.Text = Label1.Text
        Label1.Text = ""
        op = ops.Text
        Label2.Text = Label2.Text + " " + op
    End Sub

    Private Sub RoundButton30_Click(sender As Object, e As EventArgs) Handles RoundButton30.Click
        s = Label1.Text
        If op = "+" Then
            a = f + s
            Label1.Text = a
            Label2.Text = ""
        ElseIf op = "-" Then
            a = f - s
            Label1.Text = a
            Label2.Text = ""
        ElseIf op = "*" Then
            a = f * s
            Label1.Text = a
            Label2.Text = ""
        ElseIf op = "÷" Then
            a = f / s
            Label1.Text = a
            Label2.Text = ""
        ElseIf op = "Mod" Then
            a = f Mod s
            Label1.Text = a
            Label2.Text = ""
        ElseIf op = "Exp" Then
            a = f ^ s
            Label1.Text = a
            Label2.Text = ""

        End If
    End Sub

    Private Sub RoundButton33_Click(sender As Object, e As EventArgs) Handles RoundButton33.Click
        If Int32.TryParse(Label1.Text, n) Then
            Label1.Text = Convert.ToString(n, 2)
        Else
            Label1.Text = ""
        End If
    End Sub

    Private Sub RoundButton31_Click(sender As Object, e As EventArgs) Handles RoundButton31.Click
        a = Math.Sin(Label1.Text)
        Label1.Text = a
        Label2.Text = ""
    End Sub

    Private Sub RoundButton2_Click(sender As Object, e As EventArgs) Handles RoundButton2.Click
        a = Math.Cos(Label1.Text)
        Label1.Text = a
        Label2.Text = ""
    End Sub

    Private Sub RoundButton3_Click(sender As Object, e As EventArgs) Handles RoundButton3.Click
        a = Math.Tan(Label1.Text)
        Label1.Text = a
        Label2.Text = ""
    End Sub

    Private Sub RoundButton5_Click(sender As Object, e As EventArgs) Handles RoundButton5.Click
        a = Math.Log(Label1.Text)
        Label1.Text = a
        Label2.Text = ""
    End Sub

    Private Sub RoundButton16_Click(sender As Object, e As EventArgs) Handles RoundButton16.Click
        a = Math.Sqrt(Label1.Text)
        Label1.Text = a
        Label2.Text = ""
    End Sub

    Private Sub RoundButton21_Click(sender As Object, e As EventArgs) Handles RoundButton21.Click
        Label1.Text = "3.14"

    End Sub

    Private Sub RoundButton35_Click(sender As Object, e As EventArgs) Handles RoundButton35.Click
        a = Convert.ToDouble(Label1.Text) * Convert.ToDouble(Label1.Text).ToString
        Label1.Text = a
        Label2.Text = ""
    End Sub

    Private Sub RoundButton34_Click(sender As Object, e As EventArgs) Handles RoundButton34.Click
        a = Convert.ToDouble(Label1.Text) * Convert.ToDouble(Label1.Text) * Convert.ToDouble(Label1.Text).ToString
        Label1.Text = a
        Label2.Text = ""
    End Sub

    Private Sub RoundButton9_Click(sender As Object, e As EventArgs) Handles RoundButton9.Click
        If Not Label1.Text.Length <= 0 Then
            Label1.Text = Label1.Text.Remove(Label1.Text.Length - 1, 1)
        End If

    End Sub

    Private Sub RoundButton6_Click(sender As Object, e As EventArgs) Handles RoundButton6.Click
        Label1.Text += "("
    End Sub

    Private Sub RoundButton7_Click(sender As Object, e As EventArgs) Handles RoundButton7.Click
        Label1.Text += ")"
    End Sub

    Private Sub RoundButton27_Click(sender As Object, e As EventArgs) Handles RoundButton27.Click
        a = Label1.Text
        Dim i1, i2 As Integer
        i1 = Convert.ToInt32(a)
        i2 = CInt(a)
        Label1.Text = i2.ToString()
    End Sub

    Private Sub RoundButton11_Click(sender As Object, e As EventArgs) Handles RoundButton11.Click
        If Int32.TryParse(Label1.Text, n) Then
            Label1.Text = Convert.ToString(n, 16)
        Else
            Label1.Text = ""
        End If
    End Sub

    Private Sub RoundButton8_Click(sender As Object, e As EventArgs) Handles RoundButton8.Click
        a = Convert.ToDouble(Label1.Text) * Convert.ToDouble(100)
        Label1.Text = Convert.ToString(a)
    End Sub
End Class
