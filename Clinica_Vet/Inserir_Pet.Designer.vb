<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inserir_Pet
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtEspecieRaca = New TextBox()
        txtNome = New TextBox()
        txtIDChip = New TextBox()
        Button1 = New Button()
        ComboBox1 = New ComboBox()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(3, 200)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 15)
        Label4.TabIndex = 17
        Label4.Text = "Espécie/Raça:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(3, 145)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 15)
        Label3.TabIndex = 16
        Label3.Text = "Nif Dono:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(3, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 15)
        Label2.TabIndex = 15
        Label2.Text = "Nome:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(3, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 15)
        Label1.TabIndex = 14
        Label1.Text = "ID_Chip:"
        ' 
        ' txtEspecieRaca
        ' 
        txtEspecieRaca.BackColor = SystemColors.InactiveCaption
        txtEspecieRaca.Location = New Point(88, 192)
        txtEspecieRaca.Name = "txtEspecieRaca"
        txtEspecieRaca.Size = New Size(241, 23)
        txtEspecieRaca.TabIndex = 13
        ' 
        ' txtNome
        ' 
        txtNome.BackColor = SystemColors.InactiveCaption
        txtNome.Location = New Point(89, 89)
        txtNome.Name = "txtNome"
        txtNome.Size = New Size(242, 23)
        txtNome.TabIndex = 11
        ' 
        ' txtIDChip
        ' 
        txtIDChip.BackColor = SystemColors.InactiveCaption
        txtIDChip.Location = New Point(89, 38)
        txtIDChip.Name = "txtIDChip"
        txtIDChip.Size = New Size(247, 23)
        txtIDChip.TabIndex = 10
        ' 
        ' Button1
        ' 
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.Location = New Point(133, 232)
        Button1.Name = "Button1"
        Button1.Size = New Size(118, 32)
        Button1.TabIndex = 9
        Button1.Text = "Inserir "
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = SystemColors.InactiveCaption
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(88, 142)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(243, 23)
        ComboBox1.TabIndex = 18
        ' 
        ' Inserir_Pet
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.NavajoWhite
        ClientSize = New Size(376, 276)
        Controls.Add(ComboBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtEspecieRaca)
        Controls.Add(txtNome)
        Controls.Add(txtIDChip)
        Controls.Add(Button1)
        Name = "Inserir_Pet"
        Text = "Inserir_Pet"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEspecieRaca As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtIDChip As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
