Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.Devices


Public Class Form1

    Private origen As Bitmap
    Private intermedia As Bitmap
    Private destino As Bitmap
    Private _patron As Bitmap


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _patron = convertirBinario(My.Resources.ResourceManager.GetObject("patron"))
    End Sub

    Private Sub btnCargarImagen_Click(sender As Object, e As EventArgs) Handles btnCargarImagen.Click
        Label1.Text = "Imagen de entrada"
        intermedia = My.Resources.ResourceManager.GetObject("paso2")
        imgIntermedia.Image = intermedia
        destino = My.Resources.ResourceManager.GetObject("paso3")
        'imgSalida.Image = destino
        Dim openFD As New OpenFileDialog()
        With openFD
            .Title = "Seleccionar imagen"
            .Filter = "Archivos de imagen (png, jpg|*.jpg;*.png|Todos los archivos(*.*)|*.*"
            .Multiselect = False
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
            If .ShowDialog = DialogResult.OK Then
                Try
                    origen = New Bitmap(.FileName)
                    imgEntrada.Image = origen
                    Label1.Text = "Imagen de entrada (" & origen.Width & "x" & origen.Height & " pixeles)"
                Catch ex As Exception
                    MsgBox("No se pudo cargar la imagen " & ex.ToString)
                End Try
            End If
        End With

        Dim imagenBinario As Bitmap = convertirBinario(origen)
        Dim imagenLimpia As Bitmap = limpiarImagen(imagenBinario)
        intermedia = imagenLimpia
        imgIntermedia.Image = intermedia
        ProgressBar1.Value = 0
    End Sub




    Private Sub btnCargarPatron_click(sender As Object, e As EventArgs) Handles btnCargarPatron.Click
        btnDetectarPatron.Text = "Detectar patron"
        _patron = intermedia
        imgPatron.Image = intermedia
    End Sub

    Private Sub btnDetectarPatron_click(sender As Object, e As EventArgs) Handles btnDetectarPatron.Click
        Try
            Dim anchoPatron As Integer = _patron.Width
            Dim altopatron As Integer = _patron.Height
            Dim offsetX As Integer = 0
            Dim offsetY As Integer = 0
            Dim maxX As Integer = 0
            Dim maxY As Integer = 0

            Dim saltoX As Integer = CInt(anchoPatron / 10)
            Dim saltoy As Integer = CInt(altopatron / 10)

            If saltoX < 1 Then
                saltoX = 1
            End If

            If saltoy < 1 Then
                saltoy = 1
            End If



            Dim procesar As Bitmap = intermedia

            Dim patron As List(Of Integer) = imagenToMatriz(_patron, 0, 0, anchoPatron, altopatron)

            Dim redNeuronal As New Hopfield(patron.Count)


            redNeuronal.entrenar(patron)


            lblPeso.Text = "Tamaño del patrón:  " & anchoPatron & " x " & altopatron & " pixeles."



            If intermedia.Width > anchoPatron Then
                maxX = intermedia.Width - anchoPatron - 1

            ElseIf intermedia.width = anchoPatron Then
                maxX = 0
            Else
                maxX = 0
                '      procesar = New Bitmap(intermedia, New Size(anchoPatron, altopatron))
            End If


            If intermedia.Height > altopatron Or maxX = 0 Then
                maxY = intermedia.Height - altopatron

            ElseIf intermedia.Height = altopatron Then
                maxY = 0
            Else
                '    maxY = 0
                '   procesar = New Bitmap(intermedia, New Size(anchoPatron, altopatron))
            End If


            Dim patronPrueba As List(Of Integer)
            Dim reconocimiento As List(Of Integer)


            ProgressBar1.Maximum = maxX

            Debug.Print("ancho patron " & anchoPatron)
            Debug.Print("alto patron " & altopatron)

            Debug.Print("ancho origen " & procesar.Width)
            Debug.Print("alto origen " & procesar.Height)


            Debug.Print("maxX " & maxX)
            Debug.Print("maxy " & maxY)


            Dim mejorX As Integer = -1
            Dim mejory As Integer = -1
            Dim proximidad As Double = 20
            Dim mejorProximidad As Double = 0

            ProgressBar1.Maximum = maxX
            For x = offsetX To maxX Step saltoX
                lblResultadoPeso.Text = "Buscando en X " & x & " -> mejor proximidad: " & CInt(mejorProximidad * 100) & " % "
                ProgressBar1.Value = x
                ProgressBar1.Invalidate()

                For y = offsetY To maxY Step saltoy
                    patronPrueba = imagenToMatriz(intermedia, x, y, anchoPatron, altopatron)
                    If chkmostrar.Checked Then
                        imgSalida.Image = matrizToImagen(patronPrueba, anchoPatron, altopatron)
                        imgSalida.Invalidate()
                    End If
                    Application.DoEvents()
                    Try
                        System.Threading.Thread.Sleep(1)
                    Catch ex As Exception
                    End Try
                    reconocimiento = redNeuronal.reconocer(patronPrueba)
                    proximidad = calcularProximidad(patron, patronPrueba)
                    If mejorProximidad < proximidad Then
                        'aproximacion
                        mejorProximidad = proximidad
                        mejorX = x
                        mejory = y
                    End If
                    If mejorProximidad > 0.78 Then
                        x = maxX
                        y = maxY
                    End If

                Next

                lblResultadoPeso.Text = "Buscando en X " & x & " -> mejor proximidad: " & CInt(mejorProximidad * 1000) / 10 & " % "

            Next

            If mejorProximidad > 0.78 Then
                'mayor al 90% de presicion
                Dim distancia As Integer = marcarCentro(patron, mejorX, mejory, anchoPatron, altopatron)
                Debug.Print("Encontrado presicion " & mejorProximidad)


                ProgressBar1.Value = ProgressBar1.Maximum
                Dim str As String
                If distancia > 0 Then
                    str = " Encontrado a " & distancia & " pixeles a la derecha del centro"
                Else
                    str = " Encontrado a " & Math.Abs(distancia) & " pixeles a la izquierda del centro"
                End If

                lblResultadoPeso.Text = str
                MsgBox(str, vbInformation)
            Else
                imgSalida.Image = My.Resources.ResourceManager.GetObject("paso3")
                MsgBox("no se pudo encontrar el patron presicion " & CInt(mejorProximidad * 1000) / 10, vbCritical)
            End If
        Catch
        End Try

    End Sub


    Private Function marcarCentro(matriz As List(Of Integer), posx As Integer, posy As Integer, ancho As Integer, alto As Integer) As Integer

        Dim imagen As Bitmap = intermedia
        posx += 4
        Debug.Print("posicion x " & posx & " posicion y " & posy)

        For y As Integer = 0 To alto - 1
            For x As Integer = 0 To ancho - 1
                Dim index As Integer = y * ancho + x
                If index < matriz.Count Then
                    If matriz(index) = 1 Then
                        If posx + x < imagen.Width And posy + y < imagen.Height Then
                            imagen.SetPixel(posx + x, posy + y, Color.Yellow)
                        End If
                    End If
                End If

            Next
        Next

        For x = 0 To imagen.Width
            Try
                imagen.SetPixel(x, posy + alto / 2, Color.Yellow)
            Catch
            End Try
        Next

        For y = 0 To imagen.Height
            Try
                imagen.SetPixel(posx + (ancho / 2), y, Color.Yellow)
            Catch
            End Try
        Next



        destino = imagen
        imgSalida.Image = destino
        Return posx + (ancho / 2) - (imagen.Width / 2)
    End Function


    Private Function calcularProximidad(patronA As List(Of Integer), patronB As List(Of Integer)) As Double
        Dim patternLength = patronB.Count
        Dim aciertos As Double = 0

        For i As Integer = 0 To patternLength - 1
            If patronA(i Mod patronA.Count) = patronB(i) Then
                aciertos += 1
            End If
        Next

        Return aciertos / patternLength
    End Function

End Class

