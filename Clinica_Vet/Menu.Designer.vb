<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Button3 = New Button()
        Button4 = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 75)
        Button1.Name = "Button1"
        Button1.Size = New Size(140, 23)
        Button1.TabIndex = 0
        Button1.Text = "Listar Clientes"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(158, 75)
        Button2.Name = "Button2"
        Button2.Size = New Size(140, 23)
        Button2.TabIndex = 1
        Button2.Text = "Inserir Clientes"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15F, FontStyle.Bold)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(164, 28)
        Label1.TabIndex = 2
        Label1.Text = "Vet-Mata Bicho "
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(158, 115)
        Button3.Name = "Button3"
        Button3.Size = New Size(140, 23)
        Button3.TabIndex = 3
        Button3.Text = "Inserir Pet"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(12, 115)
        Button4.Name = "Button4"
        Button4.Size = New Size(140, 23)
        Button4.TabIndex = 4
        Button4.Text = "Listar Pet"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 

        PictureBox1.Location = New Point(182, 9)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 60)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.NavajoWhite
        ClientSize = New Size(318, 164)
        Controls.Add(PictureBox1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Menu"
        Text = "Menu"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim f1 = New Inserir_cliente
        f1.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim f2 = New Listar_Clientes
        f2.Show()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim f3 = New Inserir_Pet
        f3.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim f4 = New Listar_Pet
        f4.Show()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
End Class
