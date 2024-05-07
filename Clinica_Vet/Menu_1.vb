Imports MySqlConnector

Public Class Menu_1
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim paocomchourico As New MySqlConnection("Server=192.168.1.151;User ID=ricardo;Password=214868850Rs!;Port=3306;Database=BDSinistros")
        Try
            paocomchourico.Open()
            Dim Command As New MySqlCommand("INSERT INTO Agencias VALUES (23, 'Agencia' )", paocomchourico)
            Dim reader As MySqlDataReader
            reader = Command.ExecuteReader()
            MsgBox("inserido")
        Catch ex As Exception
            MsgBox("nao deu" + ex.ToString)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim f2 = New Nova_consulta
        f2.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim f2 = New Listar_Consultas
        f2.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim f2 = New nova_fatura
        f2.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim f2 = New Listar_Faturas

        f2.Show()
    End Sub
End Class