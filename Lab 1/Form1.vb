Imports System.Diagnostics.CodeAnalysis
Imports System.Drawing.Printing
Imports System.Runtime.InteropServices
Imports System.Runtime.InteropServices.Marshalling
Imports System.Windows.Forms.VisualStyles
Imports System.Xml

Public Class Form1
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        PictureBox1.Visible = True
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        TextBox3.Text = "Truck"


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        PictureBox2.Visible = True
        PictureBox1.Visible = False
        PictureBox3.Visible = False
        TextBox3.Text = "Auto"

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        '

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Resetting the various text and mask boxes 
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        MaskedTextBox3.Text = ""

    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        'Setting the Gray Color 
        Me.BackColor = Color.Gray
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        'Setting the Yellow Color 
        Me.BackColor = Color.Yellow
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        'Setting the Green color 
        Me.BackColor = Color.Green
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        Me.BackColor = Color.Blue
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RichTextBox1.Text = "Hi, Customer! 20 % off now!"
        RichTextBox1.Text = "Hi, Customer! 20 % off now!"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        PictureBox3.Visible = True
        PictureBox2.Visible = False
        PictureBox1.Visible = False
        TextBox3.Text = "Commercial "

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class

