Imports System.IO

Imports System.Net

Public Class Form1

    Public FileReader As StreamReader

    Dim About_Dialog As Integer

    Dim results As DialogResult

    Dim lineTracker As Integer

    Public fileOpen As Boolean = False

    Dim peeker As String = "NF"

    Dim endOfReport As Boolean = False

    Dim skipRead As Integer = 0

    Dim updateHT As Boolean = False

    Dim IndexLoadSuccess As Boolean = True

    Dim wa As Stream

    Dim ws As System.Net.WebResponse

    Dim SkuVerify As Boolean = False






    Private Sub Form1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click
        
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode = System.Windows.Forms.Keys.Up) Then
            'Up
            Label1.Text = "FFFF"
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.Down) Then
            'Down
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.Left) Then
            'Left
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.Right) Then
            'Right
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.Enter) Then
            'Enter
            If File.Exists("\upcf.txt") Then
                If fileOpen Then
                    FileReader = New StreamReader("\upcf.txt")
                    lineTracker = 0
                    Dim nextStep As Boolean = True
                    If SettingsForm.UpcFill Then
                        While TextBox1.Text <> FileReader.ReadLine
                            peeker = FileReader.ReadLine()
                            If peeker <> "<END>" Then
                                lineTracker += 1
                                If peeker = "<PAGE>" Then
                                    Label4.Text = FileReader.ReadLine()
                                    skipRead += 1
                                End If
                            Else
                                endOfReport = True
                                Exit While
                            End If
                        End While
                        If endOfReport Then
                            Label2.Text = "Item Not Found."

                        Else
                            Label2.Text = FileReader.ReadLine()
                            nextStep = False
                        End If
                    End If
                    FileReader.Close()
                    'MsgBox("UPC " + CStr(nextStep), 0, "Message")
                    If SettingsForm.SkuFill Then
                        If nextStep Then
                            endOfReport = False
                            FileReader = New StreamReader("\upcf.txt")
                            Dim SkuVerify As Boolean = False
                            Dim poker As String = "NF"
                            FileReader.ReadLine()
                            While Not SkuVerify
                                poker = FileReader.ReadLine()
                                If poker.Length() > 9 Then
                                    'MsgBox(":" + poker.Chars(4) + poker.Chars(5) + poker.Chars(6) + poker.Chars(7) + poker.Chars(8) + poker.Chars(9) + ":", 0, "Message")
                                    Dim ka As Integer = 0
                                    'While ka < 5
                                    If TextBox1.Text.Length() = 6 Then
                                        If poker.Chars(4) + poker.Chars(5) + poker.Chars(6) + poker.Chars(7) + poker.Chars(8) + poker.Chars(9) = TextBox1.Text Then
                                            Label2.Text = poker
                                            SkuVerify = True
                                        End If
                                    End If
                                    If TextBox1.Text.Length() = 5 Then
                                        If poker.Chars(4) + poker.Chars(5) + poker.Chars(6) + poker.Chars(7) + poker.Chars(8) = TextBox1.Text Then
                                            Label2.Text = poker
                                            SkuVerify = True
                                        End If
                                    End If
                                    If TextBox1.Text.Length() = 4 Then
                                        If poker.Chars(4) + poker.Chars(5) + poker.Chars(6) + poker.Chars(7) = TextBox1.Text Then
                                            Label2.Text = poker
                                            SkuVerify = True
                                        End If
                                    End If
                                    'ka += 1
                                    'End While
                                End If
                                'peeker = FileReader.ReadLine()
                                If poker <> "<END>" Then
                                    'lineTracker += 1
                                    If poker = "<PAGE>" Then
                                        Label4.Text = FileReader.ReadLine()
                                        'skipRead += 1
                                    End If
                                Else
                                    endOfReport = True
                                    Exit While
                                End If
                                FileReader.ReadLine()
                            End While
                            If endOfReport Then
                                Label2.Text = "Item Not Found."
                                endOfReport = False
                            End If
                        End If
                    End If
                    FileReader.Close()
                Else
                    MsgBox("Open Index File First!", 0, "Message")
                End If
            Else
                MsgBox("Index File Does Not Exist.", 0, "Message")
            End If
            If SettingsForm.NetFill Then
            End If
            TextBox1.Text = ""
        End If
        If (e.KeyCode = System.Windows.Forms.Keys.F1) Then
            Label2.Text = "FFFF"
        End If

    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        Dim fl As Integer = 6
        Dim ert As String
        If fileOpen Then
            'FileReader.Close()
        End If
        While fl = 6
            ert = InputBox("Password:", "Security Manager")
            If ert = "2504" Then
                fl = 0
                Application.Exit()
            Else
                If ert = "" Then
                    fl = 0
                Else
                    fl = MsgBox("Incorrect Password, Retry?" + ert, 3, "Security Manager")
                End If
                End If
        End While
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        MsgBox("Developed February 2023 by Orchard", 1, "About")
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub



    Private Sub OpenIndexBtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OpenIndexBtn.Click
        'OpenFileDialog1.CheckFileExists = True
        results = OpenFileDialog1.ShowDialog
        If results = DialogResult.OK Then
            'FileReader = New StreamReader(OpenFileDialog1.FileName)
            fileOpen = True
            'TextBox1.Text = FileReader.ReadToEnd()
            'MsgBox(OpenFileDialog1.FileName, 0, "Debug")
        End If
    End Sub

    Private Sub SettingsBtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SettingsBtn.Click
        SettingsForm.Show()
    End Sub

    '    Private Sub WebChk_DocumentCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebChk.DocumentCompleted
    '       If updateHT Then
    '          If fileOpen Then
    '             FileReader.Close()
    '        End If
    '       System.Windows.Forms.Application.Exit()
    '  End If
    '       updateHT = True
    '        Label4.Text = updateHT
    '  End Sub

    '   Private Sub WebChk_Navigated(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles WebChk.Navigated


    '  End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        If File.Exists("\upcf.txt") Then
            fileOpen = True
        End If
        If Not File.Exists("\upcf.txt") Then
            Dim count As Integer = 1
            fileOpen = True
            Dim fileStream As FileStream = New FileStream("\upcf.txt", FileMode.Create, FileAccess.ReadWrite)
            Dim buffer As Byte() = {0, 0, 0, 0, 0, 0, 0, 0}
            Dim wr As WebRequest = WebRequest.Create(SettingsForm.IndexBox.Text)
            Try
                Dim ws As WebResponse = wr.GetResponse()
                Dim wa As Stream = ws.GetResponseStream()
                While count <> 0
                    count = wa.Read(buffer, 0, buffer.Length)
                    fileStream.Write(buffer, 0, count)
                End While
            Catch wex As WebException
                MsgBox("Can't Connect to Server." + Chr(13) + "File: /upctest/upcf.txt", 0, "Message")
                fileOpen = False
            End Try
            fileStream.Close()
        End If
    End Sub
End Class
