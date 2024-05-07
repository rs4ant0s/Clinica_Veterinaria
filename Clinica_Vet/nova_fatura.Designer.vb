<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nova_fatura
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
        txtNrFatura = New TextBox()
        Button1 = New Button()
        txtpreco = New TextBox()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = SystemColors.InactiveCaption
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(119, 95)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(243, 23)
        ComboBox1.TabIndex = 36
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(36, 206)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 15)
        Label4.TabIndex = 35
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(36, 151)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 15)
        Label3.TabIndex = 34
        Label3.Text = "Valor:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(36, 52)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 15)
        Label2.TabIndex = 33
        Label2.Text = "Nr_fatura:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(33, 103)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 15)
        Label1.TabIndex = 32
        Label1.Text = "ID_Consulta:"
        ' 
        ' txtNrFatura
        ' 
        txtNrFatura.BackColor = SystemColors.InactiveCaption
        txtNrFatura.Location = New Point(122, 44)
        txtNrFatura.Name = "txtNrFatura"
        txtNrFatura.Size = New Size(247, 23)
        txtNrFatura.TabIndex = 29
        ' 
        ' Button1
        ' 
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.Location = New Point(166, 238)
        Button1.Name = "Button1"
        Button1.Size = New Size(118, 32)
        Button1.TabIndex = 28
        Button1.Text = "Inserir "
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtpreco
        ' 
        txtpreco.BackColor = SystemColors.InactiveCaption
        txtpreco.Location = New Point(122, 152)
        txtpreco.Name = "txtpreco"
        txtpreco.Size = New Size(247, 23)
        txtpreco.TabIndex = 37
        ' 
        ' nova_fatura
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.NavajoWhite
        ClientSize = New Size(405, 314)
        Controls.Add(txtpreco)
        Controls.Add(ComboBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtNrFatura)
        Controls.Add(Button1)
        Name = "nova_fatura"
        Text = "nova_fatura"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNrFatura As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtpreco As TextBox
End Class
