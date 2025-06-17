<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Lab1
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
        GroupBox2 = New GroupBox()
        GroupBox3 = New GroupBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        CheckBox1 = New CheckBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton4 = New RadioButton()
        RadioButton5 = New RadioButton()
        RadioButton6 = New RadioButton()
        RadioButton7 = New RadioButton()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        RichTextBox1 = New RichTextBox()
        TextBox6 = New TextBox()
        MaskedTextBox1 = New MaskedTextBox()
        MaskedTextBox2 = New MaskedTextBox()
        MaskedTextBox3 = New MaskedTextBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(MaskedTextBox3)
        GroupBox1.Controls.Add(MaskedTextBox2)
        GroupBox1.Controls.Add(MaskedTextBox1)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(GroupBox3)
        GroupBox1.ForeColor = SystemColors.HotTrack
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1133, 226)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Customer Information"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(RadioButton7)
        GroupBox2.Controls.Add(RadioButton6)
        GroupBox2.Controls.Add(RadioButton5)
        GroupBox2.Controls.Add(RadioButton4)
        GroupBox2.ForeColor = SystemColors.HotTrack
        GroupBox2.Location = New Point(1162, 23)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(158, 215)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Select Color "
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(RadioButton3)
        GroupBox3.Controls.Add(RadioButton2)
        GroupBox3.Controls.Add(RadioButton1)
        GroupBox3.ForeColor = SystemColors.HotTrack
        GroupBox3.Location = New Point(862, 19)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(239, 182)
        GroupBox3.TabIndex = 0
        GroupBox3.TabStop = False
        GroupBox3.Text = "Vehicle Type "
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(1060, 342)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 2
        Button1.Text = "Display"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(1196, 342)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 34)
        Button2.TabIndex = 3
        Button2.Text = "Reset"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(1060, 404)
        Button3.Name = "Button3"
        Button3.Size = New Size(112, 34)
        Button3.TabIndex = 4
        Button3.Text = "Print"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(1196, 404)
        Button4.Name = "Button4"
        Button4.Size = New Size(112, 34)
        Button4.TabIndex = 5
        Button4.Text = "Exit"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(1134, 279)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(165, 29)
        CheckBox1.TabIndex = 6
        CheckBox1.Text = "Visible/Invisible "
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(6, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(150, 25)
        Label1.TabIndex = 1
        Label1.Text = "Customer Name: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = SystemColors.ControlText
        Label2.Location = New Point(6, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 25)
        Label2.TabIndex = 2
        Label2.Text = "Address:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.ControlText
        Label3.Location = New Point(6, 168)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 25)
        Label3.TabIndex = 3
        Label3.Text = "City/State/Zip:"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.ForeColor = SystemColors.ControlText
        RadioButton1.Location = New Point(12, 42)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(81, 29)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Auto "
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.ForeColor = SystemColors.ControlText
        RadioButton2.Location = New Point(13, 94)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(77, 29)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "Truck"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.ForeColor = SystemColors.ControlText
        RadioButton3.Location = New Point(15, 146)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(136, 29)
        RadioButton3.TabIndex = 2
        RadioButton3.TabStop = True
        RadioButton3.Text = "Commercial "
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.ForeColor = SystemColors.ControlText
        RadioButton4.Location = New Point(6, 34)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(73, 29)
        RadioButton4.TabIndex = 0
        RadioButton4.TabStop = True
        RadioButton4.Text = "Gray"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.ForeColor = SystemColors.ControlText
        RadioButton5.Location = New Point(6, 82)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(86, 29)
        RadioButton5.TabIndex = 1
        RadioButton5.TabStop = True
        RadioButton5.Text = "Yellow"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' RadioButton6
        ' 
        RadioButton6.AutoSize = True
        RadioButton6.ForeColor = SystemColors.ControlText
        RadioButton6.Location = New Point(7, 129)
        RadioButton6.Name = "RadioButton6"
        RadioButton6.Size = New Size(83, 29)
        RadioButton6.TabIndex = 2
        RadioButton6.TabStop = True
        RadioButton6.Text = "Green"
        RadioButton6.UseVisualStyleBackColor = True
        ' 
        ' RadioButton7
        ' 
        RadioButton7.AutoSize = True
        RadioButton7.ForeColor = SystemColors.ControlText
        RadioButton7.Location = New Point(10, 176)
        RadioButton7.Name = "RadioButton7"
        RadioButton7.Size = New Size(70, 29)
        RadioButton7.TabIndex = 3
        RadioButton7.TabStop = True
        RadioButton7.Text = "Blue"
        RadioButton7.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(180, 50)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(589, 31)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(180, 107)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(589, 31)
        TextBox2.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(343, 255)
        Label4.Name = "Label4"
        Label4.Size = New Size(107, 25)
        Label4.TabIndex = 7
        Label4.Text = "Vehicle Info:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = Lab1.My.Resources.Resources.Sun
        PictureBox1.Location = New Point(18, 252)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(215, 183)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = Lab1.My.Resources.Resources.Snow_ball
        PictureBox2.Location = New Point(18, 255)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(215, 180)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = Lab1.My.Resources.Resources.Vehicle
        PictureBox3.Location = New Point(18, 255)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(223, 186)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 10
        PictureBox3.TabStop = False
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(353, 294)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(631, 144)
        RichTextBox1.TabIndex = 11
        RichTextBox1.Text = ""
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(490, 252)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(403, 31)
        TextBox6.TabIndex = 12
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.Location = New Point(180, 168)
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.Size = New Size(183, 31)
        MaskedTextBox1.TabIndex = 9
        ' 
        ' MaskedTextBox2
        ' 
        MaskedTextBox2.Location = New Point(383, 170)
        MaskedTextBox2.Name = "MaskedTextBox2"
        MaskedTextBox2.Size = New Size(69, 31)
        MaskedTextBox2.TabIndex = 10
        ' 
        ' MaskedTextBox3
        ' 
        MaskedTextBox3.Location = New Point(496, 170)
        MaskedTextBox3.Name = "MaskedTextBox3"
        MaskedTextBox3.Size = New Size(273, 31)
        MaskedTextBox3.TabIndex = 11
        ' 
        ' Lab1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(1344, 450)
        Controls.Add(TextBox6)
        Controls.Add(RichTextBox1)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label4)
        Controls.Add(CheckBox1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Lab1"
        Text = "Block Repair Parts "
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents MaskedTextBox3 As MaskedTextBox

End Class
