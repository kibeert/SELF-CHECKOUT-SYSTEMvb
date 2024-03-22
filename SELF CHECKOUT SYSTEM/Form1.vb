Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub



    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Buy_a_bag.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim selectedItem As String = ComboBox1.SelectedItem.ToString()
        If Not String.IsNullOrEmpty(selectedItem) Then
            Cart.AddItemToList(selectedItem)
        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
    Dim connectionString As String = "Server=localhost;Port=3306;Database=supermarket_db;Uid=root;"
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ComboBox1.Items.Clear()
        Dim searchCriteria As String = TextBox1.Text.Trim()
        If searchCriteria <> "" Then
            Dim query As String = "SELECT name FROM items WHERE name LIKE @SearchCriteria"

            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@SearchCriteria", "%" & searchCriteria & "%")
                    connection.Open()

                    Try
                        Using reader As MySqlDataReader = command.ExecuteReader()
                            While reader.Read()
                                ComboBox1.Items.Add(reader("name").ToString()) ' Fixed column name
                            End While
                        End Using
                    Catch ex As Exception
                        MessageBox.Show("Error reading data from the database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End Using
            End Using
        End If
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Cart.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Cart.Show()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        PopulateListView()
    End Sub
    Private Sub PopulateListView()
        ListView1.Items.Clear()
        ListView1.Columns.Clear()

        ListView1.View = View.Details

        ' Add columns to ListView
        ListView1.Columns.Add("Name", 150)
        ListView1.Columns.Add("Price", 100)

        Dim query As String = "SELECT name, price FROM items"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                connection.Open()

                Try
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim itemName As String = reader("name").ToString()
                            Dim itemPrice As String = reader("price").ToString()
                            Dim listViewItem As New ListViewItem({itemName, itemPrice})
                            ListView1.Items.Add(listViewItem)
                        End While
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error reading data from the database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

End Class
