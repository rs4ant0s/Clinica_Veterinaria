<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nova_consulta
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
        ComboBox1 = New ComboBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        txtTratamento = New TextBox()
        txtSintomas = New TextBox()
        txtIDConsulta = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = SystemColors.InactiveCaption
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(92, 78)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(243, 23)
        ComboBox1.TabIndex = 27
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(9, 189)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 15)
        Label4.TabIndex = 26
        Label4.Text = "Tratamento:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(9, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 15)
        Label3.TabIndex = 25
        Label3.Text = "Sintomas:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(9, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 15)
        Label2.TabIndex = 24
        Label2.Text = "ID_Chip_Pet:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(9, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 15)
        Label1.TabIndex = 23
        Label1.Text = "ID_Consulta:"
        ' 
        ' txtTratamento
        ' 
        txtTratamento.BackColor = SystemColors.InactiveCaption
        txtTratamento.Location = New Point(94, 181)
        txtTratamento.Name = "txtTratamento"
        txtTratamento.Size = New Size(241, 23)
        txtTratamento.TabIndex = 22
        ' 
        ' txtSintomas
        ' 
        txtSintomas.BackColor = SystemColors.InactiveCaption
        txtSintomas.Location = New Point(93, 126)
        txtSintomas.Name = "txtSintomas"
        txtSintomas.Size = New Size(242, 23)
        txtSintomas.TabIndex = 21
        ' 
        ' txtIDConsulta
        ' 
        txtIDConsulta.BackColor = SystemColors.InactiveCaption
        txtIDConsulta.Location = New Point(95, 27)
        txtIDConsulta.Name = "txtIDConsulta"
        txtIDConsulta.Size = New Size(247, 23)
        txtIDConsulta.TabIndex = 20
        ' 
        ' Button1
        ' 
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.Location = New Point(139, 221)
        Button1.Name = "Button1"
        Button1.Size = New Size(118, 32)
        Button1.TabIndex = 19
        Button1.Text = "Inserir "
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Nova_consulta
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.NavajoWhite
        ClientSize = New Size(401, 294)
        Controls.Add(ComboBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtTratamento)
        Controls.Add(txtSintomas)
        Controls.Add(txtIDConsulta)
        Controls.Add(Button1)
        Name = "Nova_consulta"
        Text = "Nova_consulta"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTratamento As TextBox
    Friend WithEvents txtSintomas As TextBox
    Friend WithEvents txtIDConsulta As TextBox
    Friend WithEvents Button1 As Button
End Class
