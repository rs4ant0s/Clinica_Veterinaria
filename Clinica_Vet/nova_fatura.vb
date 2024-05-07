Imports System.Runtime.Intrinsics.X86
Imports MySqlConnector

Public Class nova_fatura
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim paocomchourico As New MySqlConnection("Server=127.0.0.1;User ID=root;Port=3306;Database=clinicaveterinaria")
        Try

            Dim nrfatura As String
            Dim nrconsulta As String
            Dim preco As String


            nrfatura = txtNrFatura.Text
            nrconsulta = ComboBox1.Text.Split("|")(0)
            preco = txtpreco.Text

            paocomchourico.Open()
            Dim Command As New MySqlCommand("INSERT INTO faturas(NFatura, NConsulta, Valor) VALUES (" + nrfatura + ",'" + nrconsulta + "','" + preco + "')", paocomchourico)
            Dim reader As MySqlDataReader
            reader = Command.ExecuteReader()
            MsgBox("inserido")
        Catch ex As Exception
            MsgBox("nao deu" + ex.ToString)
        End Try
    End Sub

    Private Sub nova_fatura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim paocomchourico As New MySqlConnection("Server=127.0.0.1;User ID=root;Port=3306;Database=clinicaveterinaria")
        Try
            paocomchourico.Open()
            Dim Command As New MySqlCommand("SELECT * FROM consultas", paocomchourico)
            Dim reader As MySqlDataReader
            reader = Command.ExecuteReader()
            ComboBox1.Items.Clear()
            While (reader.Read)
                ComboBox1.Items.Add(reader.GetValue(0).ToString + " | " + reader.GetValue(1).ToString + " | " + reader.GetValue(2).ToString)
            End While
        Catch ex As Exception
            MsgBox("nao deu" + ex.ToString)
        End Try
    End Sub
End Class