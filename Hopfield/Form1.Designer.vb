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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        imgEntrada = New PictureBox()
        imgIntermedia = New PictureBox()
        imgSalida = New PictureBox()
        btnCargarImagen = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnDetectarPatron = New Button()
        btnCargarPatron = New Button()
        buscarArchivo = New FolderBrowserDialog()
        imgPatron = New PictureBox()
        lblPeso = New Label()
        lblResultadoPeso = New Label()
        ProgressBar1 = New ProgressBar()
        chkmostrar = New CheckBox()
        CType(imgEntrada, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgIntermedia, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgSalida, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgPatron, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' imgEntrada
        ' 
        imgEntrada.Image = My.Resources.Resources.paso1
        imgEntrada.Location = New Point(12, 63)
        imgEntrada.Name = "imgEntrada"
        imgEntrada.Size = New Size(281, 295)
        imgEntrada.SizeMode = PictureBoxSizeMode.Zoom
        imgEntrada.TabIndex = 0
        imgEntrada.TabStop = False
        ' 
        ' imgIntermedia
        ' 
        imgIntermedia.Image = CType(resources.GetObject("imgIntermedia.Image"), Image)
        imgIntermedia.Location = New Point(314, 63)
        imgIntermedia.Name = "imgIntermedia"
        imgIntermedia.Size = New Size(281, 295)
        imgIntermedia.SizeMode = PictureBoxSizeMode.Zoom
        imgIntermedia.TabIndex = 1
        imgIntermedia.TabStop = False
        ' 
        ' imgSalida
        ' 
        imgSalida.Image = CType(resources.GetObject("imgSalida.Image"), Image)
        imgSalida.Location = New Point(614, 63)
        imgSalida.Name = "imgSalida"
        imgSalida.Size = New Size(281, 295)
        imgSalida.SizeMode = PictureBoxSizeMode.Zoom
        imgSalida.TabIndex = 2
        imgSalida.TabStop = False
        ' 
        ' btnCargarImagen
        ' 
        btnCargarImagen.Location = New Point(168, 364)
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
        Label2.Location = New Point(314, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 15)
        Label2.TabIndex = 5
        Label2.Text = "Preprocesamiento"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(614, 45)
        Label3.Name = "Label3"
        Label3.Size = New Size(125, 15)
        Label3.TabIndex = 6
        Label3.Text = "Detección de patrones"
        ' 
        ' btnDetectarPatron
        ' 
        btnDetectarPatron.Location = New Point(638, 390)
        btnDetectarPatron.Name = "btnDetectarPatron"
        btnDetectarPatron.Size = New Size(219, 23)
        btnDetectarPatron.TabIndex = 12
        btnDetectarPatron.Text = "Detectar patron (precargado)"
        btnDetectarPatron.UseVisualStyleBackColor = True
        ' 
        ' btnCargarPatron
        ' 
        btnCargarPatron.Location = New Point(12, 399)
        btnCargarPatron.Name = "btnCargarPatron"
        btnCargarPatron.Size = New Size(281, 23)
        btnCargarPatron.TabIndex = 13
        btnCargarPatron.Text = "Usar imagen como patron de entrenamiento"
        btnCargarPatron.UseVisualStyleBackColor = True
        ' 
        ' imgPatron
        ' 
        imgPatron.BorderStyle = BorderStyle.Fixed3D
        imgPatron.Location = New Point(850, 12)
        imgPatron.Name = "imgPatron"
        imgPatron.Size = New Size(45, 48)
        imgPatron.SizeMode = PictureBoxSizeMode.StretchImage
        imgPatron.TabIndex = 16
        imgPatron.TabStop = False
        ' 
        ' lblPeso
        ' 
        lblPeso.Location = New Point(679, 12)
        lblPeso.Name = "lblPeso"
        lblPeso.Size = New Size(165, 20)
        lblPeso.TabIndex = 17
        lblPeso.Text = "Peso"
        lblPeso.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblResultadoPeso
        ' 
        lblResultadoPeso.Location = New Point(614, 413)
        lblResultadoPeso.Name = "lblResultadoPeso"
        lblResultadoPeso.Size = New Size(318, 54)
        lblResultadoPeso.TabIndex = 18
        lblResultadoPeso.Text = "Resultado Peso:"
        lblResultadoPeso.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(614, 359)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(281, 10)
        ProgressBar1.TabIndex = 19
        ' 
        ' chkmostrar
        ' 
        chkmostrar.AutoSize = True
        chkmostrar.Checked = True
        chkmostrar.CheckState = CheckState.Checked
        chkmostrar.Location = New Point(614, 370)
        chkmostrar.Name = "chkmostrar"
        chkmostrar.Size = New Size(275, 19)
        chkmostrar.TabIndex = 20
        chkmostrar.Text = "Mostrar Imagen en proceso (mucho más lento)"
        chkmostrar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(966, 476)
        Controls.Add(chkmostrar)
        Controls.Add(ProgressBar1)
        Controls.Add(lblResultadoPeso)
        Controls.Add(lblPeso)
        Controls.Add(imgPatron)
        Controls.Add(btnCargarPatron)
        Controls.Add(btnDetectarPatron)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnCargarImagen)
        Controls.Add(imgSalida)
        Controls.Add(imgIntermedia)
        Controls.Add(imgEntrada)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Siglo 21 - Software de reconocimiento de patrones por IA con red de hopfield"
        CType(imgEntrada, ComponentModel.ISupportInitialize).EndInit()
        CType(imgIntermedia, ComponentModel.ISupportInitialize).EndInit()
        CType(imgSalida, ComponentModel.ISupportInitialize).EndInit()
        CType(imgPatron, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnDetectarPatron As Button
    Friend WithEvents btnCargarPatron As Button
    Friend WithEvents buscarArchivo As FolderBrowserDialog
    Friend WithEvents imgPatron As PictureBox
    Friend WithEvents lblPeso As Label
    Friend WithEvents lblResultadoPeso As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents chkmostrar As CheckBox
End Class
