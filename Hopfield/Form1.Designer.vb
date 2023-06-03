<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        imgEntrada = New PictureBox()
        imgIntermedia = New PictureBox()
        imgSalida = New PictureBox()
        btnCargarImagen = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        bArriba = New Button()
        dDerecha = New Button()
        bIzquierda = New Button()
        bAbajo = New Button()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        buscarArchivo = New FolderBrowserDialog()
        Label4 = New Label()
        CType(imgEntrada, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgIntermedia, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgSalida, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' imgEntrada
        ' 
        imgEntrada.Image = My.Resources.Resources.paso1
        imgEntrada.Location = New Point(12, 63)
        imgEntrada.Name = "imgEntrada"
        imgEntrada.Size = New Size(294, 295)
        imgEntrada.TabIndex = 0
        imgEntrada.TabStop = False
        ' 
        ' imgIntermedia
        ' 
        imgIntermedia.Image = My.Resources.Resources.paso2
        imgIntermedia.Location = New Point(343, 63)
        imgIntermedia.Name = "imgIntermedia"
        imgIntermedia.Size = New Size(281, 295)
        imgIntermedia.SizeMode = PictureBoxSizeMode.StretchImage
        imgIntermedia.TabIndex = 1
        imgIntermedia.TabStop = False
        ' 
        ' imgSalida
        ' 
        imgSalida.Image = My.Resources.Resources.paso3
        imgSalida.Location = New Point(661, 63)
        imgSalida.Name = "imgSalida"
        imgSalida.Size = New Size(281, 295)
        imgSalida.SizeMode = PictureBoxSizeMode.StretchImage
        imgSalida.TabIndex = 2
        imgSalida.TabStop = False
        ' 
        ' btnCargarImagen
        ' 
        btnCargarImagen.Location = New Point(181, 364)
        btnCargarImagen.Name = "btnCargarImagen"
        btnCargarImagen.Size = New Size(125, 23)
        btnCargarImagen.TabIndex = 3
        btnCargarImagen.Text = "Cargar Imagen..."
        btnCargarImagen.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 15)
        Label1.TabIndex = 4
        Label1.Text = "Imagen de Entrada"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(343, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 15)
        Label2.TabIndex = 5
        Label2.Text = "Preprocesamiento"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(661, 45)
        Label3.Name = "Label3"
        Label3.Size = New Size(125, 15)
        Label3.TabIndex = 6
        Label3.Text = "Detección de patrones"
        ' 
        ' bArriba
        ' 
        bArriba.Location = New Point(59, 360)
        bArriba.Name = "bArriba"
        bArriba.Size = New Size(22, 23)
        bArriba.TabIndex = 7
        bArriba.UseVisualStyleBackColor = True
        ' 
        ' dDerecha
        ' 
        dDerecha.Location = New Point(79, 380)
        dDerecha.Name = "dDerecha"
        dDerecha.Size = New Size(22, 23)
        dDerecha.TabIndex = 8
        dDerecha.UseVisualStyleBackColor = True
        ' 
        ' bIzquierda
        ' 
        bIzquierda.Location = New Point(39, 380)
        bIzquierda.Name = "bIzquierda"
        bIzquierda.Size = New Size(22, 23)
        bIzquierda.TabIndex = 9
        bIzquierda.UseVisualStyleBackColor = True
        ' 
        ' bAbajo
        ' 
        bAbajo.Location = New Point(59, 400)
        bAbajo.Name = "bAbajo"
        bAbajo.Size = New Size(22, 23)
        bAbajo.TabIndex = 10
        bAbajo.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(445, 364)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 11
        Button1.Text = "Limpieza"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(691, 364)
        Button2.Name = "Button2"
        Button2.Size = New Size(219, 23)
        Button2.TabIndex = 12
        Button2.Text = "Procesar con entrenamiento previo"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(771, 393)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 23)
        Button3.TabIndex = 13
        Button3.Text = "Entrenar"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 364)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 15)
        Label4.TabIndex = 14
        Label4.Text = "Mover"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(952, 436)
        Controls.Add(Label4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(bAbajo)
        Controls.Add(bIzquierda)
        Controls.Add(dDerecha)
        Controls.Add(bArriba)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnCargarImagen)
        Controls.Add(imgSalida)
        Controls.Add(imgIntermedia)
        Controls.Add(imgEntrada)
        Name = "Form1"
        Text = "Siglo 21 - Software de reconocimiento de patrones por IA con red de hopfield"
        CType(imgEntrada, ComponentModel.ISupportInitialize).EndInit()
        CType(imgIntermedia, ComponentModel.ISupportInitialize).EndInit()
        CType(imgSalida, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents imgEntrada As PictureBox
    Friend WithEvents imgIntermedia As PictureBox
    Friend WithEvents imgSalida As PictureBox
    Friend WithEvents btnCargarImagen As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents bArriba As Button
    Friend WithEvents dDerecha As Button
    Friend WithEvents bIzquierda As Button
    Friend WithEvents bAbajo As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents buscarArchivo As FolderBrowserDialog
    Friend WithEvents Label4 As Label
End Class
