<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Panel1 = New Panel()
        Button3 = New Button()
        ComboBox1 = New ComboBox()
        Button2 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Panel3 = New Panel()
        Button8 = New Button()
        Button1 = New Button()
        ListView1 = New ListView()
        Button7 = New Button()
        Button4 = New Button()
        Panel2 = New Panel()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Button8 = New Button()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(TextBox1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(978, 585)
        Panel1.TabIndex = 8
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.White
        Button3.Font = New Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(74, 485)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(368, 46)
        Button3.TabIndex = 22
        Button3.Text = "Need help?"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(74, 320)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(196, 23)
        ComboBox1.TabIndex = 26
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.White
        Button2.Font = New Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(74, 410)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(368, 46)
        Button2.TabIndex = 21
        Button2.Text = "Buy a bag"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.White
        Button5.Font = New Font("Century Gothic", 14.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(291, 313)
        Button5.Margin = New Padding(3, 2, 3, 2)
        Button5.Name = "Button5"
        Button5.Size = New Size(192, 30)
        Button5.TabIndex = 24
        Button5.Text = "add item to cart"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.Location = New Point(371, 214)
        Button6.Name = "Button6"
        Button6.Size = New Size(90, 32)
        Button6.TabIndex = 25
        Button6.Text = "Search"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Panel3.Controls.Add(Button8)
        Panel3.Controls.Add(Button1)
        Panel3.Controls.Add(ListView1)
        Panel3.Controls.Add(Button7)
        Panel3.Controls.Add(Button4)
        Panel3.Location = New Point(508, -2)
        Panel3.Margin = New Padding(3, 2, 3, 22)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(468, 585)
        Panel3.TabIndex = 19
        ' 
        ' Button8
        ' 
        Button8.Font = New Font("Century Gothic", 15.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button8.Location = New Point(405, 19)
        Button8.Name = "Button8"
        Button8.Size = New Size(51, 37)
        Button8.TabIndex = 30
        Button8.Text = "X"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Century Gothic", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(263, 435)
        Button1.Name = "Button1"
        Button1.Size = New Size(119, 23)
        Button1.TabIndex = 29
        Button1.Text = "see items"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(30, 12)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(352, 367)
        ListView1.TabIndex = 28
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' Button7
        ' 
        Button7.Font = New Font("Century Gothic", 15.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button7.Location = New Point(82, 510)
        Button7.Name = "Button7"
        Button7.Size = New Size(75, 32)
        Button7.TabIndex = 27
        Button7.Text = "cart"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.White
        Button4.Font = New Font("Century Gothic", 14.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(334, 512)
        Button4.Margin = New Padding(3, 2, 3, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(90, 30)
        Button4.TabIndex = 22
        Button4.Text = "next"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.BackgroundImage = My.Resources.Resources.african_print_fabric_seamless_tribal_pattern_vector_39871065
        Panel2.Location = New Point(-35, 0)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(65, 596)
        Panel2.TabIndex = 18
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label1.Location = New Point(121, 91)
        Label1.Name = "Label1"
        Label1.Size = New Size(242, 37)
        Label1.TabIndex = 0
        Label1.Text = "SELF CHECKOUT"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 14.0F)
        TextBox1.Location = New Point(53, 212)
        TextBox1.Margin = New Padding(3, 2, 3, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "enter product name"
        TextBox1.Size = New Size(298, 32)
        TextBox1.TabIndex = 21
        ' 
        ' Button8
        ' 
        Button8.Font = New Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button8.Location = New Point(407, 12)
        Button8.Name = "Button8"
        Button8.Size = New Size(39, 30)
        Button8.TabIndex = 30
        Button8.Text = "X"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(978, 585)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button7 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button8 As Button

End Class
