
Imports System.Drawing.Drawing2D

Public Class Hopfield
    Private _cantidadNeuronas As Integer
    Private _matrizPesos As Double(,)

    Public _patron As List(Of Integer)



    Public Sub New(count As Integer)
        _cantidadNeuronas = count
        Debug.Print("Cantidad de neuronas ")
        _matrizPesos = New Double(_cantidadNeuronas - 1, _cantidadNeuronas - 1) {}
    End Sub


    Public Sub entrenar(patron As List(Of Integer))
        _patron = patron
        desEntrenar()

        For i As Integer = 0 To _cantidadNeuronas - 1
            For j As Integer = 0 To _cantidadNeuronas - 1
                If i = j Then
                    _matrizPesos(i, j) = 0
                Else
                    _matrizPesos(i, j) += patron(i) * patron(j)
                End If
            Next
        Next
        For i As Integer = 0 To _cantidadNeuronas - 1
            For j As Integer = 0 To _cantidadNeuronas - 1
                _matrizPesos(i, j) /= _cantidadNeuronas
            Next
        Next

    End Sub


    Public Sub desEntrenar()
        For i As Integer = 0 To _cantidadNeuronas - 1
            For j As Integer = 0 To _cantidadNeuronas - 1
                _matrizPesos(i, j) = -1
            Next
        Next
    End Sub


    Public Function reconocer(patronEntrada As List(Of Integer)) As List(Of Integer)
        Dim patronSalida As New List(Of Integer)(patronEntrada)
        Dim str As String = ""

        For i As Integer = 0 To _cantidadNeuronas - 1
            Dim sum As Double = 0
            For j As Integer = 0 To _cantidadNeuronas - 1
                Try
                    If j < patronSalida.Count Then
                        sum += _matrizPesos(i, j) * patronEntrada(j)
                    End If
                Catch

                End Try
                If i >= patronSalida.Count Then
                    i = _cantidadNeuronas
                    j = _cantidadNeuronas
                Else
                    patronSalida(i) = If(sum >= 0, 1, -1)
                End If
            Next
        Next

        Return patronSalida
    End Function

End Class

