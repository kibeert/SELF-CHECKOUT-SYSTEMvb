<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        TextBox1 = New TextBox()
        Label4 = New Label()
        Button8 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        TextBox2 = New TextBox()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Button8)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(978, 585)
        Panel1.TabIndex = 10
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(165, 185)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 60
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(74, 181)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 23)
        Label4.TabIndex = 59
        Label4.Text = "total"
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Button8.Font = New Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button8.ForeColor = Color.White
        Button8.Location = New Point(156, 434)
        Button8.Margin = New Padding(3, 2, 3, 2)
        Button8.Name = "Button8"
        Button8.Size = New Size(90, 41)
        Button8.TabIndex = 58
        Button8.Text = "home"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Button5.Font = New Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.White
        Button5.Location = New Point(792, 434)
        Button5.Margin = New Padding(3, 2, 3, 2)
        Button5.Name = "Button5"
        Button5.Size = New Size(102, 41)
        Button5.TabIndex = 57
        Button5.Text = "cancel"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.White
        Button4.Font = New Font("Century Gothic", 15F, FontStyle.Bold)
        Button4.Location = New Point(732, 235)
        Button4.Margin = New Padding(3, 2, 3, 2)
        Button4.Name = "Button4"
        Button4.Size = New Size(220, 126)
        Button4.TabIndex = 56
        Button4.Text = "CASH"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.White
        Button3.Font = New Font("Century Gothic", 15F, FontStyle.Bold)
        Button3.Location = New Point(507, 235)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(220, 126)
        Button3.TabIndex = 55
        Button3.Text = "MPESA"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.White
        Button2.Font = New Font("Century Gothic", 15F, FontStyle.Bold)
        Button2.Location = New Point(282, 235)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(220, 126)
        Button2.TabIndex = 54
        Button2.Text = "Debit Card"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Font = New Font("Century Gothic", 15F, FontStyle.Bold)
        Button1.Location = New Point(57, 235)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(220, 126)
        Button1.TabIndex = 53
        Button1.Text = "Credit Card"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label3.Location = New Point(900, 20)
        Label3.Name = "Label3"
        Label3.Size = New Size(34, 37)
        Label3.TabIndex = 52
        Label3.Text = "x"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label2.Location = New Point(355, 134)
        Label2.Name = "Label2"
        Label2.Size = New Size(238, 23)
        Label2.TabIndex = 50
        Label2.Text = "swipe debit/credit card"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        Label1.Location = New Point(406, 82)
        Label1.Name = "Label1"
        Label1.Size = New Size(153, 37)
        Label1.TabIndex = 48
        Label1.Text = "PAYMENT"
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
        ' TextBox2
        ' 
        TextBox2.Location = New Point(318, 185)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(104, 23)
        TextBox2.TabIndex = 61
        ' 
        ' Payment
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(978, 585)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(3, 2, 3, 2)
        Name = "Payment"
        Text = "Payment"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
End Class
