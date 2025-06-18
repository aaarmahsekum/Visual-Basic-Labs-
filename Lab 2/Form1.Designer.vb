<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.ForeColor = SystemColors.HotTrack
        GroupBox1.Location = New Point(13, 25)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(611, 150)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Part Information "
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(226, 91)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(346, 31)
        TextBox2.TabIndex = 3
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(226, 40)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(346, 31)
        TextBox1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = SystemColors.Desktop
        Label2.Location = New Point(6, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(146, 25)
        Label2.TabIndex = 1
        Label2.Text = "Part Description :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(4, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 25)
        Label1.TabIndex = 0
        Label1.Text = "Part Identifier :"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(TextBox8)
        GroupBox2.Controls.Add(TextBox7)
        GroupBox2.Controls.Add(TextBox6)
        GroupBox2.Controls.Add(TextBox5)
        GroupBox2.Controls.Add(TextBox4)
        GroupBox2.Controls.Add(TextBox3)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.ForeColor = SystemColors.HotTrack
        GroupBox2.Location = New Point(13, 181)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(394, 309)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Price, Cost, Storage, Profit "
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = SystemColors.ControlText
        Label8.Location = New Point(16, 272)
        Label8.Name = "Label8"
        Label8.Size = New Size(97, 25)
        Label8.TabIndex = 6
        Label8.Text = "Net Profit :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = SystemColors.ControlText
        Label7.Location = New Point(16, 221)
        Label7.Name = "Label7"
        Label7.Size = New Size(151, 25)
        Label7.TabIndex = 5
        Label7.Text = "Storage Charges :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = SystemColors.ControlText
        Label6.Location = New Point(16, 171)
        Label6.Name = "Label6"
        Label6.Size = New Size(114, 25)
        Label6.TabIndex = 4
        Label6.Text = "Gross Profit :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = SystemColors.ControlText
        Label5.Location = New Point(16, 122)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 25)
        Label5.TabIndex = 3
        Label5.Text = "Quantity :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = SystemColors.ControlText
        Label4.Location = New Point(16, 73)
        Label4.Name = "Label4"
        Label4.Size = New Size(143, 25)
        Label4.TabIndex = 2
        Label4.Text = "Wholesale Cost :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.ControlText
        Label3.Location = New Point(16, 27)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 25)
        Label3.TabIndex = 1
        Label3.Text = "Retail Price :"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(480, 195)
        Button1.Name = "Button1"
        Button1.Size = New Size(127, 62)
        Button1.TabIndex = 2
        Button1.Text = "Compute "
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(480, 278)
        Button2.Name = "Button2"
        Button2.Size = New Size(127, 56)
        Button2.TabIndex = 3
        Button2.Text = "Reset Form "
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(480, 352)
        Button3.Name = "Button3"
        Button3.Size = New Size(127, 68)
        Button3.TabIndex = 4
        Button3.Text = "Total Net Profit "
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(480, 432)
        Button4.Name = "Button4"
        Button4.Size = New Size(127, 52)
        Button4.TabIndex = 5
        Button4.Text = "Exit"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(217, 30)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(150, 31)
        TextBox3.TabIndex = 7
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(217, 122)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(150, 31)
        TextBox4.TabIndex = 8
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(217, 171)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(150, 31)
        TextBox5.TabIndex = 9
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(217, 221)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(150, 31)
        TextBox6.TabIndex = 10
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(217, 272)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(150, 31)
        TextBox7.TabIndex = 11
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(217, 73)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(150, 31)
        TextBox8.TabIndex = 12
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(668, 502)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Repair Part Profit Estimator - Angela Aya Armah-Sekum "
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox

End Class
