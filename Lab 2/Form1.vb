Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub MaskedTextBox3_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox3.MaskInputRejected

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        MaskedTextBox1.Text = " "
        MaskedTextBox2.Text = " "
        MaskedTextBox3.Text = " "
        MaskedTextBox4.Text = " "
        MaskedTextBox5.Text = " "
        MaskedTextBox6.Text = " "

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub MaskedTextBox2_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox2.MaskInputRejected

    End Sub

    Private Sub MaskedTextBox4_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox4.MaskInputRejected

    End Sub

    Private Sub MaskedTextBox5_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox5.MaskInputRejected

    End Sub

    Private Sub MaskedTextBox6_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox6.MaskInputRejected

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Lab2 As DialogResult = MessageBox.Show(" Do you want the close the form?", "Quit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button4)
        If Lab2 = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub
End Class
