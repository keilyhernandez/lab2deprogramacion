Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim numero As Operaciones = New Operaciones()
        Dim num As Integer = cboNumeros.SelectedItem : Dim result As Integer

        If (rbSuma.Checked) Then
            For index = 1 To 10 Step 1
                result = num + num
            Next
            lsbNumeros.Items.Add(num & " + " & num & " = " & result)
        ElseIf (rbResta.Checked) Then
            result = num - num
            lsbNumeros.Items.Add(num & " - " & num & " = " & result)
        ElseIf (rbMult.Checked) Then
            For i = 1 To 10 Step 1
                result = num * i
                lsbNumeros.Items.Add(num & " X " & i & " = " & result)
            Next
        End If


    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        lsbNumeros.Items.Clear()
    End Sub

End Class
