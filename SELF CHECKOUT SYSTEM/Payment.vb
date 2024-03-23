Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Payment
    Public Sub New(prices As List(Of String))
        InitializeComponent()
        DisplayPrices(prices)
        CalculateTotal(prices)
    End Sub

    Public Sub DisplayPrices(prices As List(Of String))
        TextBox1.Text = String.Join(Environment.NewLine, prices)
    End Sub
    Public Sub CalculateTotal(prices As List(Of String))
        Dim total As Decimal = 0
        For Each price As String In prices
            Dim itemPrice As Decimal
            If Decimal.TryParse(price, itemPrice) Then
                total += itemPrice
            End If
        Next
        TextBox2.Text = "ksh" & total.ToString("N2") ' Display total price as currency
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form1.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class