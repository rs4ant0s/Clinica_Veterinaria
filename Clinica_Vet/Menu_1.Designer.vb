<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        Button3 = New Button()
        Button4 = New Button()
        PictureBox1 = New PictureBox()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Button9 = New Button()
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
        Button3.Location = New Point(158, 116)
        Button3.Name = "Button3"
        Button3.Size = New Size(140, 23)
        Button3.TabIndex = 3
        Button3.Text = "Inserir Pet"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(12, 116)
        Button4.Name = "Button4"
        Button4.Size = New Size(140, 23)
        Button4.TabIndex = 4
        Button4.Text = "Listar Pet"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.rip
        PictureBox1.Location = New Point(182, 9)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 60)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(115, 279)
        Button5.Name = "Button5"
        Button5.Size = New Size(75, 23)
        Button5.TabIndex = 6
        Button5.Text = "Button5"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(12, 159)
        Button6.Name = "Button6"
        Button6.Size = New Size(140, 23)
        Button6.TabIndex = 8
        Button6.Text = "Listar Consulta"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(158, 159)
        Button7.Name = "Button7"
        Button7.Size = New Size(140, 23)
        Button7.TabIndex = 7
        Button7.Text = "Nova Consulta"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.Location = New Point(12, 197)
        Button8.Name = "Button8"
        Button8.Size = New Size(140, 23)
        Button8.TabIndex = 10
        Button8.Text = "Listar Faturas"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(158, 197)
        Button9.Name = "Button9"
        Button9.Size = New Size(140, 23)
        Button9.TabIndex = 9
        Button9.Text = "Nova Fatura"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Menu_1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.NavajoWhite
        ClientSize = New Size(304, 314)
        Controls.Add(Button8)
        Controls.Add(Button9)
        Controls.Add(Button6)
        Controls.Add(Button7)
        Controls.Add(Button5)
        Controls.Add(PictureBox1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Menu_1"
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
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
End Class
