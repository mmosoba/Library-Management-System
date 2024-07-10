Imports System.Data.SqlClient
Public Class Form1
    ' Connection string to connect to the SQL Server database
    Dim connectionString As String = "Data Source=DESKTOP-RUT03RK;Initial Catalog=LibraryDB;Integrated Security=True"
    Dim connection As New SqlConnection(connectionString)

    ' Load books when the form loads
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBooks()
    End Sub

    ' Load books from the database into the DataGridView
    Private Sub LoadBooks()
        Dim query As String = "SELECT * FROM Books"
        Dim adapter As New SqlDataAdapter(query, connection)
        Dim table As New DataTable()
        adapter.Fill(table)
        dgvBooks.DataSource = table
    End Sub

    ' Add a new book to the database
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim query As String = "INSERT INTO Books (Title, Author, YearPublished, Genre) VALUES (@Title, @Author, @YearPublished, @Genre)"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@Title", txtTitle.Text)
            command.Parameters.AddWithValue("@Author", txtAuthor.Text)
            command.Parameters.AddWithValue("@YearPublished", txtYearPublished.Text)
            command.Parameters.AddWithValue("@Genre", txtGenre.Text)
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
            LoadBooks()
            MessageBox.Show("Book added successfully!")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Update an existing book in the database
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim query As String = "UPDATE Books SET Title=@Title, Author=@Author, YearPublished=@YearPublished, Genre=@Genre WHERE ID=@ID"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@ID", dgvBooks.CurrentRow.Cells(0).Value)
            command.Parameters.AddWithValue("@Title", txtTitle.Text)
            command.Parameters.AddWithValue("@Author", txtAuthor.Text)
            command.Parameters.AddWithValue("@YearPublished", txtYearPublished.Text)
            command.Parameters.AddWithValue("@Genre", txtGenre.Text)
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
            LoadBooks()
            MessageBox.Show("Book updated successfully!")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Delete a book from the database
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim query As String = "DELETE FROM Books WHERE ID=@ID"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@ID", dgvBooks.CurrentRow.Cells(0).Value)
            connection.Open()
            command.ExecuteNonQuery()
            connection.Close()
            LoadBooks()
            MessageBox.Show("Book deleted successfully!")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Clear text boxes
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTitle.Clear()
        txtAuthor.Clear()
        txtYearPublished.Clear()
        txtGenre.Clear()
    End Sub

    ' Populate text boxes when a row is clicked in the DataGridView
    Private Sub dgvBooks_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBooks.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvBooks.Rows(e.RowIndex)
            txtTitle.Text = row.Cells("Title").Value.ToString()
            txtAuthor.Text = row.Cells("Author").Value.ToString()
            txtYearPublished.Text = row.Cells("YearPublished").Value.ToString()
            txtGenre.Text = row.Cells("Genre").Value.ToString()
        End If
    End Sub
End Class
