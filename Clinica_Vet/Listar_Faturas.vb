Imports MySqlConnector

Public Class Listar_Faturas
    Private Sub Listar_Faturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim paocomchourico As New MySqlConnection("Server=127.0.0.1;User ID=root;Port=3306;Database=clinicaveterinaria")
        Try
            paocomchourico.Open()
            Dim Command As New MySqlCommand("SELECT * FROM faturas", paocomchourico)
            Dim reader As MySqlDataReader
            reader = Command.ExecuteReader()
            ListBox1.Items.Clear()
            While (reader.Read)
                ListBox1.Items.Add(reader.GetValue(0).ToString + "|" + reader.GetValue(1).ToString + "|" + reader.GetValue(2).ToString)
            End While
        Catch ex As Exception
            MsgBox("nao deu" + ex.ToString)
        End Try
    End Sub
End Class