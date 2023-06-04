
Module funciones
    Public Function imagenToMatriz(imagen As Bitmap, offsetX As Integer, offsety As Integer, ancho As Integer, alto As Integer) As List(Of Integer)
        Dim pat As New List(Of Integer)()



        For y As Integer = offsety To offsety + alto - 1
            For x As Integer = offsetX To offsetX + ancho - 1
                If x <= imagen.Width And y <= imagen.Height Then

                    Dim pixel As Color = imagen.GetPixel(x, y)
                    pat.Add(If(pixel.GetBrightness() < 0.5, -1, 1))
                End If

            Next
        Next
        Return pat
    End Function


    '  Public Function obtenerPeso(mat As List(Of Integer)) As Long
    '  Dim res As Long
    '  For i As Integer = 0 To mat.Count - 1
    '          res += If(mat(i) > 0, 1, 0)
    '  Next
    '  Return res
    '  End Function

    Public Function convertirBinario(image As Bitmap) As Bitmap
            Dim binaryImage As New Bitmap(image.Width, image.Height)
            Dim pixel As Color
            Dim grayscale As Integer
            Dim binaryColor As Color
            For y As Integer = 0 To image.Height - 1
                For x As Integer = 0 To image.Width - 1
                    pixel = image.GetPixel(x, y)
                    grayscale = (CInt(pixel.R) + CInt(pixel.G) + CInt(pixel.B)) / 3
                    binaryColor = If(grayscale < 128, Color.White, Color.Black)
                    binaryImage.SetPixel(x, y, binaryColor)
                Next
            Next
            Return binaryImage
        End Function


        Public Function limpiarImagen(image As Bitmap) As Bitmap
            Dim imagenLimpia As New Bitmap(image.Width, image.Height)
            For y As Integer = 0 To image.Height - 1
                For x As Integer = 0 To image.Width - 1
                    Dim pixel As Color = image.GetPixel(x, y)
                    Dim cleanedColor As Color = If(pixel.GetBrightness() < 0.5, Color.White, Color.Black)
                    imagenLimpia.SetPixel(x, y, cleanedColor)
                Next
            Next
            Return imagenLimpia
        End Function


    Public Function matrizToImagen(matriz As List(Of Integer), ancho As Integer, alto As Integer) As Bitmap
        Dim imagen As New Bitmap(ancho, alto)

        For y As Integer = 0 To alto - 1
            For x As Integer = 0 To ancho - 1
                'Try
                Dim index As Integer = y * ancho + x
                If index < matriz.Count Then
                    Dim color As Color = If(matriz(index) = -1, Color.White, Color.LightCoral)
                    imagen.SetPixel(x, y, color)
                End If

                ' Catch ex As Exception
                '     Debug.Print("error en matriz to imagen")
                ' End Try
            Next
        Next




        Return imagen
    End Function

End Module
