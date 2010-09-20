Imports Gif.Components.GifDecoder
Imports System
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Threading
Imports System.IO
Imports System.Text

Imports ICSharpCode.SharpZipLib.Core
Imports ICSharpCode.SharpZipLib.Zip


Public Class Form1
    Inherits System.Windows.Forms.Form
    Dim gifDecoder As New Gif.Components.GifDecoder
    Dim fileName As String
    Dim i As Integer
    Dim frame As System.Drawing.Image
    Dim path As String
    Dim count
    Dim wiz As New Form2
    Dim dirName As String
    Dim projName As String

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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents projectName As System.Windows.Forms.TextBox
    Friend WithEvents savePath As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox13 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox12 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents heightSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents widthSize As System.Windows.Forms.NumericUpDown
    Friend WithEvents speedVar As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.projectName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.savePath = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.PictureBox13 = New System.Windows.Forms.PictureBox
        Me.PictureBox12 = New System.Windows.Forms.PictureBox
        Me.heightSize = New System.Windows.Forms.NumericUpDown
        Me.widthSize = New System.Windows.Forms.NumericUpDown
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.speedVar = New System.Windows.Forms.NumericUpDown
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.heightSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.widthSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.speedVar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(120, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(168, 144)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'projectName
        '
        Me.projectName.Location = New System.Drawing.Point(120, 32)
        Me.projectName.Name = "projectName"
        Me.projectName.Size = New System.Drawing.Size(304, 21)
        Me.projectName.TabIndex = 1
        Me.projectName.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Project Name"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Select Animated Gif "
        '
        'savePath
        '
        Me.savePath.Location = New System.Drawing.Point(16, 320)
        Me.savePath.Name = "savePath"
        Me.savePath.ReadOnly = True
        Me.savePath.Size = New System.Drawing.Size(376, 21)
        Me.savePath.TabIndex = 4
        Me.savePath.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(400, 320)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 24)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "..."
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(24, 296)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Path to Save"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(88, 352)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(280, 40)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Generate"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.PictureBox13)
        Me.GroupBox1.Controls.Add(Me.PictureBox12)
        Me.GroupBox1.Location = New System.Drawing.Point(296, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(128, 112)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gadget Icon"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(80, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "24x24"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(24, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "32x32"
        '
        'PictureBox13
        '
        Me.PictureBox13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), System.Drawing.Image)
        Me.PictureBox13.Location = New System.Drawing.Point(80, 72)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox13.TabIndex = 35
        Me.PictureBox13.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(24, 64)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox12.TabIndex = 34
        Me.PictureBox12.TabStop = False
        '
        'heightSize
        '
        Me.heightSize.Location = New System.Drawing.Point(120, 224)
        Me.heightSize.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.heightSize.Name = "heightSize"
        Me.heightSize.ReadOnly = True
        Me.heightSize.Size = New System.Drawing.Size(64, 21)
        Me.heightSize.TabIndex = 33
        '
        'widthSize
        '
        Me.widthSize.Location = New System.Drawing.Point(120, 256)
        Me.widthSize.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.widthSize.Name = "widthSize"
        Me.widthSize.ReadOnly = True
        Me.widthSize.Size = New System.Drawing.Size(64, 21)
        Me.widthSize.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(56, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Height"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(56, 256)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 16)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Width"
        '
        'speedVar
        '
        Me.speedVar.Location = New System.Drawing.Point(264, 240)
        Me.speedVar.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.speedVar.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.speedVar.Name = "speedVar"
        Me.speedVar.Size = New System.Drawing.Size(48, 21)
        Me.speedVar.TabIndex = 37
        Me.speedVar.Value = New Decimal(New Integer() {150, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(216, 240)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 16)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Speed"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(136, 400)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(192, 16)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Bugs and Ideas - gif2gg@gmail.com"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.ClientSize = New System.Drawing.Size(440, 423)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.speedVar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.widthSize)
        Me.Controls.Add(Me.heightSize)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.savePath)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.projectName)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Gif2gg v0.1 by Umakanthan"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.heightSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.widthSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.speedVar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim dlg As New OpenFileDialog
        With dlg
            .Filter = "Gif files (*.gif)|*.gif"
            .FilterIndex = 1
            .Title = "Select any image for gadget icon"

        End With
        Dim res As DialogResult = dlg.ShowDialog()

        'dlg.Filter = "Png files (*.png)|*.png"
        If res = Windows.Forms.DialogResult.OK Then
            'Dim objImage As System.Drawing.Image
            'objImage = System.Drawing.Image.FromFile(dlg.FileName)
            'Dim objCallback As System.Drawing.Image.GetThumbnailImageAbort = New System.Drawing.Image.GetThumbnailImageAbort(AddressOf ThumbnailCallback)

            'objImage = objImage.GetThumbnailImage(32, 32, objCallback, IntPtr.Zero)
            Try

                PictureBox1.Image = Image.FromFile(dlg.FileName)
                fileName = dlg.FileName
                Dim m_bmpRepresentation As New Bitmap(dlg.FileName, False)
                heightSize.Value = m_bmpRepresentation.Height
                widthSize.Value = m_bmpRepresentation.Width
            Catch ex As Exception
                MessageBox.Show("Unsupported Gif file", "Unsupported Gif file", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try



            'PictureBox12.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fileName = "-1"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim dir As System.IO.Directory
        Dim folderPath = "C:\Temp\"

        If (projectName.Text.Length > 0 And savePath.Text.Length > 0 And fileName.ToString <> "-1") Then
            If wiz.ShowDialog() = Windows.Forms.DialogResult.OK Then

                folderPath = "C:\Temp\"
                dirName = folderPath + projectName.Text

                projName = projectName.Text
                Directory.CreateDirectory(dirName)

                gifDecoder.Read(fileName)

                ' MAIN FILE 
                Dim file1 As New System.IO.StreamWriter("C:\Temp\" + projectName.Text + "\main.js")
                file1.Write(main_js(gifDecoder.GetFrameCount().ToString, speedVar.Value.ToString))
                file1.Close()

                Dim file2 As New System.IO.StreamWriter("C:\Temp\" + projectName.Text + "\main.xml")
                file2.Write(main_xml((heightSize.Value + 50).ToString, (widthSize.Value + 50).ToString))
                file2.Close()

                Dim file3 As New System.IO.StreamWriter("C:\Temp\" + projectName.Text + "\gadget.gmanifest")
                file3.Write(gadget_gmanifest(projectName.Text))
                file3.Close()


                PictureBox12.Image.Save("C:\Temp\" + projectName.Text + "\icon_large.png")
                PictureBox13.Image.Save("C:\Temp\" + projectName.Text + "\icon_small.png")

                Directory.CreateDirectory(dirName + "\en")
                Dim file4 As New System.IO.StreamWriter("C:\Temp\" + projectName.Text + "\en" + "\strings.xml")
                file4.Write(strings_xml())

                file4.Close()

                For i As Integer = 0 To gifDecoder.GetFrameCount() - 1
                    frame = gifDecoder.GetFrame(i)
                    frame.Save("C:\Temp\" + projectName.Text + "\" + i.ToString() + ".png")
                Next

                Dim fz As New ICSharpCode.SharpZipLib.Zip.FastZip
                fz.CreateZip(savePath.Text + "\" + projName + ".gg", dirName, True, "", "")

                MessageBox.Show("Successfully Generated " + savePath.Text + "\" + projName + ".gg", "Google Desktop Gadget", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                folderPath = "C:\Temp\"
                dirName = folderPath + projectName.Text

                projName = projectName.Text
                Directory.CreateDirectory(dirName)

                gifDecoder.Read(fileName)

                ' MAIN FILE 
                Dim file1 As New System.IO.StreamWriter("C:\Temp\" + projectName.Text + "\main.js")
                file1.Write(main_js(gifDecoder.GetFrameCount().ToString, speedVar.Value.ToString))
                file1.Close()

                Dim file2 As New System.IO.StreamWriter("C:\Temp\" + projectName.Text + "\main.xml")
                file2.Write(main_xml((heightSize.Value + 50).ToString, (widthSize.Value + 50).ToString))
                file2.Close()

                Dim file3 As New System.IO.StreamWriter("C:\Temp\" + projectName.Text + "\gadget.gmanifest")
                file3.Write(gadget_gmanifest1(projectName.Text))
                file3.Close()


                PictureBox12.Image.Save("C:\Temp\" + projectName.Text + "\icon_large.png")
                PictureBox13.Image.Save("C:\Temp\" + projectName.Text + "\icon_small.png")

                Directory.CreateDirectory(dirName + "\en")
                Dim file4 As New System.IO.StreamWriter("C:\Temp\" + projectName.Text + "\en" + "\strings.xml")
                file4.Write(strings_xml1())

                file4.Close()

                For i As Integer = 0 To gifDecoder.GetFrameCount() - 1
                    frame = gifDecoder.GetFrame(i)
                    frame.Save("C:\Temp\" + projectName.Text + "\" + i.ToString() + ".png")
                Next

                Dim fz As New ICSharpCode.SharpZipLib.Zip.FastZip
                fz.CreateZip(savePath.Text + "\" + projName + ".gg", dirName, True, "", "")

                MessageBox.Show("Successfully Generated " + savePath.Text + "\" + projName + ".gg", "Google Desktop Gadget", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If

        Else
            MessageBox.Show("Parameters Missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
    Private Function strings_xml1() As String

        'Create a new StringBuilder object
        Dim sb As New StringBuilder

        sb.Append("<!--" & vbCrLf)
        sb.Append("Copyright (C) 2007 Google Inc." & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("Licensed under the Apache License, Version 2.0 (the ""License"");" & vbCrLf)
        sb.Append("you may not use this file except in compliance with the License." & vbCrLf)
        sb.Append("You may obtain a copy of the License at" & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("     http://www.apache.org/licenses/LICENSE-2.0" & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("Unless required by applicable law or agreed to in writing, software" & vbCrLf)
        sb.Append("distributed under the License is distributed on an ""AS IS"" BASIS," & vbCrLf)
        sb.Append("WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied." & vbCrLf)
        sb.Append("See the License for the specific language governing permissions and" & vbCrLf)
        sb.Append("limitations under the License." & vbCrLf)
        sb.Append("-->" & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("<strings>" & vbCrLf)
        sb.Append("  <GADGET_ABOUT_TEXT>" & vbCrLf)
        sb.Append("  " & vbCrLf)
        sb.Append("YourName")
        sb.Append("  </GADGET_ABOUT_TEXT>" & vbCrLf)
        sb.Append("  " & vbCrLf)
        sb.Append("Copyright 2007 Google Inc." & vbCrLf)
        sb.Append("Licensed under the Apache License, Version 2.0" & vbCrLf)
        sb.Append("http://www.apache.org/licenses/LICENSE-2.0" & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("</strings>" & vbCrLf)

        Return sb.ToString()
    End Function


    Private Function strings_xml() As String

        'Create a new StringBuilder object
        Dim sb As New StringBuilder

        sb.Append("<!--" & vbCrLf)
        sb.Append("Copyright (C) 2007 Google Inc." & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("Licensed under the Apache License, Version 2.0 (the ""License"");" & vbCrLf)
        sb.Append("you may not use this file except in compliance with the License." & vbCrLf)
        sb.Append("You may obtain a copy of the License at" & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("     http://www.apache.org/licenses/LICENSE-2.0" & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("Unless required by applicable law or agreed to in writing, software" & vbCrLf)
        sb.Append("distributed under the License is distributed on an ""AS IS"" BASIS," & vbCrLf)
        sb.Append("WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied." & vbCrLf)
        sb.Append("See the License for the specific language governing permissions and" & vbCrLf)
        sb.Append("limitations under the License." & vbCrLf)
        sb.Append("-->" & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("<strings>" & vbCrLf)
        sb.Append("  <GADGET_ABOUT_TEXT>" & vbCrLf)
        sb.Append("  " & vbCrLf)
        sb.Append(wiz.authorAbout)
        sb.Append("  </GADGET_ABOUT_TEXT>" & vbCrLf)
        sb.Append("  " & vbCrLf)
        sb.Append("Copyright 2007 Google Inc." & vbCrLf)
        sb.Append("Licensed under the Apache License, Version 2.0" & vbCrLf)
        sb.Append("http://www.apache.org/licenses/LICENSE-2.0" & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("  <MIN_AGO>min ago</MIN_AGO>" & vbCrLf)
        sb.Append("  <MINS_AGO>mins ago</MINS_AGO>" & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("  <HR_AGO>hr ago</HR_AGO>" & vbCrLf)
        sb.Append("  <HRS_AGO>hrs ago</HRS_AGO>" & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("  <DAY_AGO>day ago</DAY_AGO>" & vbCrLf)
        sb.Append("  <DAYS_AGO>days ago</DAYS_AGO>" & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("  <TRYING_TO_CONNECT>Trying to connect...</TRYING_TO_CONNECT>" & vbCrLf)
        sb.Append("  " & vbCrLf)
        sb.Append("  <TITLE_TEXT>RSS Demo</TITLE_TEXT>  " & vbCrLf)
        sb.Append("</strings>" & vbCrLf)

        Return sb.ToString()
    End Function


    Private Function main_xml(ByVal h As String, ByVal w As String) As String


        'Create a new StringBuilder object
        Dim sb As New StringBuilder

        sb.Append("<view height=""")
        sb.Append(h)
        sb.Append(""" width=""")
        sb.Append(w)
        sb.Append(""" onopen=""view_onOpen()"">" & vbCrLf)
        sb.Append("  <img name=""img1"" x=""20"" y=""27"" src=""stock_images\image.png""/>" & vbCrLf)
        sb.Append("  <script src=""main.js"" />" & vbCrLf)
        sb.Append("</view>" & vbCrLf)

        Return sb.ToString()
    End Function



    Private Function gadget_gmanifest1(ByVal name As String) As String

        'Create a new StringBuilder object
        Dim sb As New StringBuilder

        sb.Append("<gadget minimumGoogleDesktopVersion=""5.1.0.0"">" & vbCrLf)
        sb.Append("	<about>" & vbCrLf)
        sb.Append("		<name>")
        sb.Append(name)
        sb.Append("</name>" & vbCrLf)
        sb.Append("		<description>")
        sb.Append("Description Here")
        sb.Append("</description>" & vbCrLf)
        sb.Append("    <aboutText>&GADGET_ABOUT_TEXT;</aboutText>" & vbCrLf)
        sb.Append("		<smallIcon>icon_small.png</smallIcon>" & vbCrLf)
        sb.Append("		<icon>icon_large.png</icon>" & vbCrLf)
        sb.Append("		<version>")
        sb.Append("1.0.0.0")
        sb.Append("</version>" & vbCrLf)
        sb.Append("		<author>")
        sb.Append("Generated By Umakanthan")
        sb.Append("</author>" & vbCrLf)
        sb.Append("		<authorWebsite>")
        sb.Append("http://cumakt.googlepages.com")
        sb.Append("</authorWebsite>" & vbCrLf)
        Dim MyGuid As Guid = Guid.NewGuid()
        sb.Append("		<id>")
        sb.Append(MyGuid.ToString)
        sb.Append("</id>" & vbCrLf)
        sb.Append("    <authorEmail>")
        sb.Append("cumakt@gmail.com")
        sb.Append("</authorEmail>" & vbCrLf)
        sb.Append("    <copyright>Copyright (c) 2007 Umakanthan . All Rights Reserved</copyright>" & vbCrLf)
        sb.Append("  </about>" & vbCrLf)
        sb.Append("</gadget>" & vbCrLf)

        Return sb.ToString()

    End Function

    Private Function gadget_gmanifest(ByVal name As String) As String

        'Create a new StringBuilder object
        Dim sb As New StringBuilder

        sb.Append("<gadget minimumGoogleDesktopVersion=""5.1.0.0"">" & vbCrLf)
        sb.Append("	<about>" & vbCrLf)
        sb.Append("		<name>")
        sb.Append(name)
        sb.Append("</name>" & vbCrLf)
        sb.Append("		<description>")
        sb.Append(wiz.authorDesc)
        sb.Append("</description>" & vbCrLf)
        'sb.Append("		<aboutText>")
        'sb.Append("Now Its Under Problem")
        'sb.Append("</aboutText>" & vbCrLf)
        sb.Append("    <aboutText>&GADGET_ABOUT_TEXT;</aboutText>" & vbCrLf)
        sb.Append("		<smallIcon>icon_small.png</smallIcon>" & vbCrLf)
        sb.Append("		<icon>icon_large.png</icon>" & vbCrLf)
        sb.Append("		<version>")
        sb.Append(wiz.authorVersion)
        sb.Append("</version>" & vbCrLf)
        sb.Append("		<author>")
        sb.Append(wiz.authorName)
        sb.Append("</author>" & vbCrLf)
        sb.Append("		<authorWebsite>")
        sb.Append(wiz.authorSite)
        sb.Append("</authorWebsite>" & vbCrLf)
        Dim MyGuid As Guid = Guid.NewGuid()
        sb.Append("		<id>")
        sb.Append(MyGuid.ToString)
        sb.Append("</id>" & vbCrLf)
        sb.Append("    <authorEmail>")
        sb.Append(wiz.authorMail)
        sb.Append("</authorEmail>" & vbCrLf)
        sb.Append("    <copyright>Copyright (c) 2007 Google Inc. All Rights Reserved</copyright>" & vbCrLf)
        sb.Append("  </about>" & vbCrLf)
        sb.Append("</gadget>" & vbCrLf)

        Return sb.ToString()

    End Function

    Private Function main_js(ByVal totalImg As String, ByVal speedNum As String) As String

        'Create a new StringBuilder object
        Dim sb As New StringBuilder

        sb.Append("var selectedIntervalName = """";" & vbCrLf)
        sb.Append("var selectedInterval = ""100000"";" & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("SetDefaultOptions();" & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("var num = ")
        sb.Append(totalImg)
        sb.Append(",  //  number of images" & vbCrLf)
        sb.Append(" speed = ")
        sb.Append(speedNum)
        sb.Append(",  //  initial delay" & vbCrLf)
        sb.Append(" step = 20," & vbCrLf)
        sb.Append(" min = 20," & vbCrLf)
        sb.Append(" max = 500," & vbCrLf)
        sb.Append(" cur = 0," & vbCrLf)
        sb.Append(" imarray = new Array( num );" & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("var intervalNames = new Array(""Dull "",""Slow "",""Normal "",""Fast "",""Fastest "");" & vbCrLf)
        sb.Append("var intervalCodes = new Array(""450"",""350"",""250"",""150"",""50"");" & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("plugin.onShowOptionsDlg = ShowOptionsDlg; // handler for options dialog" & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("function SetDefaultOptions() {" & vbCrLf)
        sb.Append("  if (options.exists(""intervalname"")) " & vbCrLf)
        sb.Append("       selectedIntervalName = options(""intervalname"");" & vbCrLf)
        sb.Append("   else" & vbCrLf)
        sb.Append("       options(""intervalname"")  = selectedIntervalName;" & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("   if (options.exists(""intervalcode"")) " & vbCrLf)
        sb.Append("       selectedInterval = options(""intervalcode"");" & vbCrLf)
        sb.Append("   else" & vbCrLf)
        sb.Append("       options(""intervalcode"")  = selectedInterval;" & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("}" & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("function GetselectedIntervalName() {" & vbCrLf)
        sb.Append("  var ctr = selectedInterval;" & vbCrLf)
        sb.Append("  var i = 0;" & vbCrLf)
        sb.Append("  for(i=0;i<intervalNames.length;i++){" & vbCrLf)
        sb.Append("    if(intervalNames[i]==ctr)" & vbCrLf)
        sb.Append("     break;" & vbCrLf)
        sb.Append("  }" & vbCrLf)
        sb.Append("  return intervalCodes[i];" & vbCrLf)
        sb.Append("}" & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("function ShowOptionsDlg(wnd) {" & vbCrLf)
        sb.Append("  wnd.AddControl(gddWndCtrlClassLabel, 0, """", ""Please Choose Baby !"", 10, 10, 280, 30);" & vbCrLf)
        sb.Append("  var list = wnd.AddControl(gddWndCtrlClassList, gddWndCtrlTypeListDrop, ""intervalcode"", intervalNames, 10, 35, 280, 2000);" & vbCrLf)
        sb.Append("  list.value = selectedInterval;" & vbCrLf)
        sb.Append("  // handlers" & vbCrLf)
        sb.Append("  wnd.onClose = OptionsDlgClosed;" & vbCrLf)
        sb.Append("  " & vbCrLf)
        sb.Append("}" & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("function OptionsDlgClosed(wnd, code) {" & vbCrLf)
        sb.Append("  if (code == gddIdOK) {" & vbCrLf)
        sb.Append("    var list = wnd.GetControl(""intervalcode"");" & vbCrLf)
        sb.Append("    " & vbCrLf)
        sb.Append("    selectedInterval = list.value;" & vbCrLf)
        sb.Append("    selectedIntervalName = GetselectedIntervalName();" & vbCrLf)
        sb.Append("    options(""intervalcodecode"")  = selectedIntervalName;" & vbCrLf)
        sb.Append("    options(""intervalcode"") = selectedInterval;" & vbCrLf)
        sb.Append("    speed =  selectedIntervalName;" & vbCrLf)
        sb.Append("    cur = 0;" & vbCrLf)
        sb.Append("    animate();" & vbCrLf)
        sb.Append("  }" & vbCrLf)
        sb.Append("}" & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("function view_onOpen()" & vbCrLf)
        sb.Append("{" & vbCrLf)
        sb.Append("animate(); " & vbCrLf)
        sb.Append("}" & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("function animate() {" & vbCrLf)
        sb.Append("  cur = ( cur + 1 ) % num;" & vbCrLf)
        sb.Append("  img1.src = imarray[cur].src;  " & vbCrLf)
        sb.Append("  setTimeout( 'animate();', speed );" & vbCrLf)
        sb.Append(" " & vbCrLf)
        sb.Append("}" & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("// preload the required files..." & vbCrLf)
        sb.Append("for( var i = 0; i < num; i++ ) {" & vbCrLf)
        sb.Append("  imarray[i] = new Array();" & vbCrLf)
        sb.Append("  imarray[i].src = i + '.png';" & vbCrLf)
        sb.Append("}" & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("" & vbCrLf)
        sb.Append("" & vbCrLf)

        Return sb.ToString()
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim DirectoryBrowser As System.Windows.Forms.FolderBrowserDialog
        DirectoryBrowser = New System.Windows.Forms.FolderBrowserDialog
        DirectoryBrowser.Description = "Save Gadget in ..."
        If (DirectoryBrowser.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            savePath.Text = DirectoryBrowser.SelectedPath.ToString()
        End If
    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        Dim dlg As New OpenFileDialog
        With dlg
            .Filter = "Png files (*.png)|*.png"
            .FilterIndex = 1
            .Title = "Select any image for gadget icon"

        End With
        Dim res As DialogResult = dlg.ShowDialog()

        'dlg.Filter = "Png files (*.png)|*.png"
        If res = Windows.Forms.DialogResult.OK Then

            Dim objImage As System.Drawing.Image
            objImage = System.Drawing.Image.FromFile(dlg.FileName)
            Dim objCallback As System.Drawing.Image.GetThumbnailImageAbort = New System.Drawing.Image.GetThumbnailImageAbort(AddressOf ThumbnailCallback)

            objImage = objImage.GetThumbnailImage(32, 32, objCallback, IntPtr.Zero)

            PictureBox12.Image = objImage
            'PictureBox12.SizeMode = PictureBoxSizeMode.StretchImage
        End If


    End Sub
    Function ThumbnailCallback() As Boolean
        Return False
    End Function

    Private Sub PictureBox13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox13.Click
        Dim dlg As New OpenFileDialog
        With dlg
            .Filter = "Png files (*.png)|*.png"
            .FilterIndex = 1
            .Title = "Select any image file for gadget icon"
        End With

        Dim res As DialogResult = dlg.ShowDialog()
        dlg.Filter = "Png files (*.png)|*.png"
        If res = Windows.Forms.DialogResult.OK Then
            Dim objImage As System.Drawing.Image
            objImage = System.Drawing.Image.FromFile(dlg.FileName)
            Dim objCallback As System.Drawing.Image.GetThumbnailImageAbort = New System.Drawing.Image.GetThumbnailImageAbort(AddressOf ThumbnailCallback)

            objImage = objImage.GetThumbnailImage(24, 24, objCallback, IntPtr.Zero)

            PictureBox13.Image = objImage
            PictureBox13.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub NumericUpDown3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles speedVar.ValueChanged

    End Sub

    Private Sub heightSize_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles heightSize.ValueChanged

    End Sub
End Class
