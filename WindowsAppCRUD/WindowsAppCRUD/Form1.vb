Public Class Form1

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Try
            Create("INSERT INTO Utilizadores(nome, utilizador, senha, nivel) VALUES ('" & TxtNome.Text & "','" & txtUtilizador.Text & "','" & TxtSenha.Text & "'," & CbNivel.SelectedIndex + 1 & ")")
        Catch ex As Exception
            MessageBox.Show("ERRO" & ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnReload_Click(sender As Object, e As EventArgs) Handles BtnReload.Click
        Try
            Reload("SELECT * FROM Utilizadores ORDER BY ID ASC", DgLista)
        Catch ex As Exception
            MessageBox.Show("ERRO" & ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try
            Updates("UPDATE Utilizadores SET nome='" & TxtNome.Text & "', " & "utilizador='" & txtUtilizador.Text & "', " & "senha='" & TxtSenha.Text & "', " & "nivel=" & CbNivel.SelectedIndex & "WHERE ID =" & LbID.Text)
        Catch ex As Exception
            MessageBox.Show("ERRO" & ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            Delete("DELETE FROM Utilizadores WHERE ID=" & LbID.Text)
        Catch ex As Exception
            MessageBox.Show("ERRO" & ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DgLista_DoubleClick(sender As Object, e As EventArgs) Handles DgLista.DoubleClick
        LbID.Text = DgLista.CurrentRow.Cells(0).Value
        TxtNome.Text = DgLista.CurrentRow.Cells(1).Value
        txtUtilizador.Text = DgLista.CurrentRow.Cells(2).Value
        TxtSenha.Text = DgLista.CurrentRow.Cells(3).Value
        CbNivel.SelectedIndex = DgLista.CurrentRow.Cells(4).Value
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtNome.Select()
        Me.BtnReload.PerformClick()
    End Sub
End Class
