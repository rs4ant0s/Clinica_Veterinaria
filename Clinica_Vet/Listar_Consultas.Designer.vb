﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listar_Consultas
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
        Label1 = New Label()
        ListBox1 = New ListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.Location = New Point(51, 94)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 21)
        Label1.TabIndex = 4
        Label1.Text = "Lista de Faturas:"
        ' 
        ' ListBox1
        ' 
        ListBox1.BackColor = SystemColors.InactiveCaption
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(51, 124)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(318, 79)
        ListBox1.TabIndex = 3
        ' 
        ' Listar_Consultas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.NavajoWhite
        ClientSize = New Size(420, 296)
        Controls.Add(Label1)
        Controls.Add(ListBox1)
        Name = "Listar_Consultas"
        Text = "Listar_Consultas"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
End Class
