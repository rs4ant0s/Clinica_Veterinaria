Imports MySqlConnector
Public Class Inserir_Pet
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim paocomchourico As New MySqlConnection("Server=127.0.0.1;User ID=root;Port=3306;Database=clinicaveterinaria")
        Try

            Dim idChip As String
            Dim nome As String
            Dim nifDono As String
            Dim especieRaca As String

            idChip = txtIDChip.Text
            nome = txtNome.Text
            nifDono = ComboBox1.Text.Split("|")(0)
            especieRaca = txtEspecieRaca.Text

            paocomchourico.Open()
            Dim Command As New MySqlCommand("INSERT INTO pets(id_chip,nome,nif_dono,Especie_Raca) VALUES (" + idChip + ",'" + nome + "','" + nifDono + "','" + especieRaca + "')", paocomchourico)
            Dim reader As MySqlDataReader
            reader = Command.ExecuteReader()
            MsgBox("inserido")
        Catch ex As Exception
            MsgBox("nao deu" + ex.ToString)
        End Try

    End Sub

    Private Sub Inserir_Pet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim paocomchourico As New MySqlConnection("Server=127.0.0.1;User ID=root;Port=3306;Database=clinicaveterinaria")
        Try
            paocomchourico.Open()
            Dim Command As New MySqlCommand("SELECT * FROM clientes", paocomchourico)
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