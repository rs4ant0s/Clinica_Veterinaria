<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inserir_cliente
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
        Button1 = New Button()
        txtNif = New TextBox()
        txtNome = New TextBox()
        txtMorada = New TextBox()
        txtContacto = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.Location = New Point(104, 261)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "Inserir "
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtNif
        ' 
        txtNif.BackColor = SystemColors.InactiveCaption
        txtNif.Location = New Point(88, 47)
        txtNif.Name = "txtNif"
        txtNif.Size = New Size(143, 23)
        txtNif.TabIndex = 1
        ' 
        ' txtNome
        ' 
        txtNome.BackColor = SystemColors.InactiveCaption
        txtNome.Location = New Point(88, 93)
        txtNome.Name = "txtNome"
        txtNome.Size = New Size(143, 23)
        txtNome.TabIndex = 2
        ' 
        ' txtMorada
        ' 
        txtMorada.BackColor = SystemColors.InactiveCaption
        txtMorada.Location = New Point(88, 160)
        txtMorada.Name = "txtMorada"
        txtMorada.Size = New Size(143, 23)
        txtMorada.TabIndex = 3
        ' 
        ' txtContacto
        ' 
        txtContacto.BackColor = SystemColors.InactiveCaption
        txtContacto.Location = New Point(88, 215)
        txtContacto.Name = "txtContacto"
        txtContacto.Size = New Size(143, 23)
        txtContacto.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(23, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(25, 15)
        Label1.TabIndex = 5
        Label1.Text = "NIF"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(23, 96)
        Label2.Name = "Label2"
        Label2.Size = New Size(40, 15)
        Label2.TabIndex = 6
        Label2.Text = "Nome"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(23, 160)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 15)
        Label3.TabIndex = 7
        Label3.Text = "Morada"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(23, 215)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 15)
        Label4.TabIndex = 8
        Label4.Text = "Contacto"
        ' 
        ' Inserir_cliente
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.NavajoWhite
        ClientSize = New Size(303, 314)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtContacto)
        Controls.Add(txtMorada)
        Controls.Add(txtNome)
        Controls.Add(txtNif)
        Controls.Add(Button1)
        Name = "Inserir_cliente"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txtNif As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtMorada As TextBox
    Friend WithEvents txtContacto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label

End Class
