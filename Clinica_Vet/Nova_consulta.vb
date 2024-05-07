Imports MySqlConnector

Public Class Nova_consulta
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim paocomchourico As New MySqlConnection("Server=127.0.0.1;User ID=root;Port=3306;Database=clinicaveterinaria")
        Try

            Dim idconsulta As String
            Dim idchip As String
            Dim sintomas As String
            Dim tratamento As String

            idconsulta = txtIDConsulta.Text
            idchip = ComboBox1.Text.Split("|")(0)
            sintomas = txtSintomas.Text
            tratamento = txtTratamento.Text

            paocomchourico.Open()
            Dim Command As New MySqlCommand("INSERT INTO consultas(IDConsulta, IDChipPet, Sintomas, Tratamento) VALUES (" + idconsulta + ",'" + idchip + "','" + sintomas + "','" + tratamento + "')", paocomchourico)
            Dim reader As MySqlDataReader
            reader = Command.ExecuteReader()
            MsgBox("inserido")
        Catch ex As Exception
            MsgBox("nao deu" + ex.ToString)
        End Try
    End Sub

    Private Sub Nova_consulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim paocomchourico As New MySqlConnection("Server=127.0.0.1;User ID=root;Port=3306;Database=clinicaveterinaria")
        Try
            paocomchourico.Open()
            Dim Command As New MySqlCommand("SELECT * FROM pets", paocomchourico)
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