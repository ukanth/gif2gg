
Public Class Form2
    Inherits System.Windows.Forms.Form
    Public authorName As String
    Public authorMail As String
    Public authorSite As String
    Public authorVersion As String
    Public authorDesc As String
    Public authorAbout As String





#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Description As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents aboutText As System.Windows.Forms.RichTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Description = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.aboutText = New System.Windows.Forms.RichTextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(88, 120)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(72, 21)
        Me.TextBox4.TabIndex = 4
        Me.TextBox4.Text = "1.0.0.0"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(88, 160)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(224, 21)
        Me.TextBox5.TabIndex = 5
        Me.TextBox5.Text = ""
        '
        'Description
        '
        Me.Description.BackColor = System.Drawing.Color.Transparent
        Me.Description.Location = New System.Drawing.Point(8, 160)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(64, 16)
        Me.Description.TabIndex = 3
        Me.Description.Text = "Description"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(8, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Version"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(8, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Author Name"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(88, 56)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(224, 21)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = ""
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(8, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "EMail"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(8, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Website"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 312)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 32)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "OK"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(88, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(224, 21)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = ""
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(88, 88)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(224, 21)
        Me.TextBox3.TabIndex = 3
        Me.TextBox3.Text = ""
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(192, 312)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 32)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "SKIP"
        '
        'aboutText
        '
        Me.aboutText.Location = New System.Drawing.Point(88, 192)
        Me.aboutText.Name = "aboutText"
        Me.aboutText.Size = New System.Drawing.Size(224, 104)
        Me.aboutText.TabIndex = 13
        Me.aboutText.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(16, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 24)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "About "
        '
        'Form2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(330, 354)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.aboutText)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Description)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gadget Settings"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'If TextBoxIsEmpty(TextBox1) Then Exit Sub
        'If TextBoxIsEmpty(TextBox2) Then Exit Sub
        'If TextBoxIsEmpty(TextBox3) Then Exit Sub
        'If TextBoxIsEmpty(TextBox4) Then Exit Sub
        'If TextBoxIsEmpty(TextBox5) Then Exit Sub
        If (TextBox1.Text.Length > 0 And TextBox2.Text.Length > 0 And TextBox3.Text.Length > 0 And TextBox4.Text.Length > 0 And TextBox5.Text.Length > 0 And aboutText.Text.Length > 0) Then
            authorName = Me.TextBox1.Text
            authorMail = Me.TextBox2.Text
            authorSite = Me.TextBox3.Text
            authorVersion = Me.TextBox4.Text
            authorDesc = Me.TextBox5.Text
            authorAbout = Me.aboutText.Text
            Me.DialogResult = DialogResult.OK

        ElseIf (TextBox1.Text.Length <= 0 Or TextBox2.Text.Length <= 0 Or TextBox3.Text.Length <= 0 Or TextBox4.Text.Length <= 0 Or TextBox5.Text.Length <= 0 Or aboutText.Text.Length <= 0) Then
            MessageBox.Show("Please Enter The Values", "Enter Values", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub
    Private Function TextBoxIsEmpty(ByVal text_box As TextBox) As Boolean
        If text_box.Text.Length = 0 Then
            ' Display the tab containing the TextBox.
            ' Set focus to the TextBox.
            text_box.Focus()
            Dim field_name As String = AddSpacesBeforeCaps(text_box.Name.Substring(3))
            MessageBox.Show("The " & field_name & _
                           " must not be blank.", "Enter Value", _
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Display an error message.
        End If

        Return False
    End Function
    ' Insert spaces before the string's capital letters.
    Private Function AddSpacesBeforeCaps(ByVal txt As String) As String
        Dim txt_chars() As Char = txt.ToCharArray
        Dim result As String = txt_chars(0)

        For i As Integer = 1 To txt.Length - 1
            If (txt_chars(i) >= "A"c) And (txt_chars(i) <= "Z"c) Then
                result &= " "
            End If
            result &= txt_chars(i)
        Next i

        Return result
    End Function


    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'MessageBox.Show("You Must fill these fields", "Google Desktop Gadget", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
