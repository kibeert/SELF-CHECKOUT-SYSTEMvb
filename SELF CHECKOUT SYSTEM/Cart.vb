Imports MySql.Data.MySqlClient

Public Class Cart

    Private connectionString As String = "Server=localhost;Port=3306;Database=supermarket_db;Uid=root;"
    Public Sub AddItemToList(item As String)
        Dim listItem As New ListViewItem(item)
        Dim itemPrice As String = GetItemPrice(item)

        ' Add the item and price to the ListView
        listItem.SubItems.Add(itemPrice)
        ListView1.Items.Add(listItem)
    End Sub

    Private Function GetItemPrice(itemName As String) As String
        Dim price As String = ""

        ' Query to get the price of the item from the database
        Dim query As String = "SELECT price FROM items WHERE name = @ItemName"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@ItemName", itemName)
                connection.Open()

                Try
                    ' Execute the query to get the price
                    Dim result = command.ExecuteScalar()
                    If result IsNot Nothing Then
                        price = result.ToString()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error fetching price from the database: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using

        Return price
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ' Code for Label1 click event (if any)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Collect prices from items in the ListView
        Dim prices As New List(Of String)
        For Each item As ListViewItem In ListView1.Items
            prices.Add(item.SubItems(1).Text) ' Assuming the price is in the second column
        Next

        ' Open the Payment form and pass the prices
        Dim paymentForm As New Payment(prices)
        paymentForm.Show()
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        ' Code for ListView1 selected index changed event (if any)
    End Sub
End Class
