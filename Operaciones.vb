Public Class Operaciones
    Public numero As Integer

    'Public Sub Suma(numero As Integer)
    '    Dim result As Integer
    '    For i = 1 To 10 Step 1
    '        result = numero + i
    '    Next

    'End Sub
    'Public Sub New(numero As Integer)
    '    Me.numero = numero
    'End Sub
    Public Function Suma(numero As Integer) As Object
        Dim sumaNum As Integer
        sumaNum = numero + numero

        Return sumaNum
    End Function

    Public Function Resta(numero As Integer) As Object

        Dim restaNum As Integer
        For i = 1 To 10 Step 1
            restaNum = numero - i
        Next
        Return restaNum
    End Function
    Public Function Multiplicacion(numero As Integer) As Object

        Dim mult As Integer
        For i = 1 To 10 Step 1
            mult = numero * i
        Next
        Return mult
    End Function
End Class
