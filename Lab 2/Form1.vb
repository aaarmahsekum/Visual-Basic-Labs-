Public Class Form1
    Private RetailPrice As Decimal
    Private WholesalCost As Decimal
    Private Quantity As Integer
    Private GrossProfit As Decimal
    Private StorageCharges As Decimal
    Private NetProfit As Decimal
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub MaskedTextBox3_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Text = " "
        TextBox2.Text = " "
        TextBox3.Text = " "
        TextBox4.Text = " "
        TextBox5.Text = " "
        TextBox6.Text = " "

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub MaskedTextBox2_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub MaskedTextBox4_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub MaskedTextBox5_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub MaskedTextBox6_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Lab2 As DialogResult = MessageBox.Show(" Do you want the close the form?", "Quit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button4)
        If Lab2 = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'Declaring Variables and constants
            Dim RetailPrice, WholesaleCost, GrossProfit, NetProfit As Decimal
            Dim Quantity As Integer
            'Parsing and assigning
            RetailPrice = Decimal.Parse(TextBox1.Text)
            Quantity = Integer.Parse(TextBox2.Text)

            'Computation
            GrossProfit = (RetailPrice - WholesaleCost) * Quantity
            Const StorageCharges = 5.0
            NetProfit = (GrossProfit - StorageCharges)

            'Restore values to Text Boxes
            TextBox1.Text = TextBox1.ToString("C2")
            TextBox2.Text = TextBox2.ToString("C2")

        Catch ex As Exception
            MessageBox.Show("Error in Retail Price, Wholeasale Cost, or Quantity ", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
