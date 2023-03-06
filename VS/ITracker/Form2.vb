Imports System.IO
Imports System.Net


Public Class SettingsForm
    Dim msg As Integer
    Public UpcFill As Boolean = True
    Public SkuFill As Boolean
    Public NetFill As Boolean
    Public UrlHead As String = "http://192.168.1.163/upctest/upcf.txt"
    Dim abortUpdate As Boolean = False

    Private Sub MenuItem1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        msg = MsgBox("Save Changes?", 3, "Message")
        If msg = 6 Then
            UpcFill = UpcChk.Checked()
            SkuFill = SkuChk.Checked()
            NetFill = NetChk.Checked()
            UrlHead = IndexBox.Text()
            Form1.Show()
        End If
        If msg = 7 Then
            UpcChk.Checked = UpcFill
            SkuChk.Checked = SkuFill
            NetChk.Checked = NetFill
            IndexBox.Text = UrlHead
            Form1.Show()
        End If
    End Sub
    Private Sub MenuItem2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        UpcFill = UpcChk.Checked()
        ProgBar.Value += 25
        SkuFill = SkuChk.Checked()
        ProgBar.Value += 25
        NetFill = NetChk.Checked()
        ProgBar.Value += 25
        UrlHead = IndexBox.Text()
        ProgBar.Value += 25
        Form1.Show()
        ProgBar.Value = 0
    End Sub

    Private Sub UpdateBtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles UpdateBtn.Click
        Dim buffer As Byte() = {0, 0, 0, 0, 0, 0, 0, 0}
        Dim count As Integer = 1
        Dim fileStream As FileStream = New FileStream("\SmartDeviceProject2.exe", FileMode.Create, FileAccess.ReadWrite)
        Dim wr As WebRequest = WebRequest.Create("http://192.168.1.163/release/SmartDeviceProject1.exe")
        Try
            Dim ws As WebResponse = wr.GetResponse()
            Dim wa As Stream = ws.GetResponseStream()
            While count <> 0
                count = wa.Read(buffer, 0, buffer.Length)
                fileStream.Write(buffer, 0, count)
            End While
        Catch wex As WebException
            MsgBox("Can't Connect to Server." + Chr(13) + "File: /release/SmartDeviceProject1.exe", 0, "Message")
            If File.Exists("SmartDeviceProject2.exe") Then
                File.Delete("SmartDeviceProject2.exe")
            End If
            abortUpdate = True
        End Try
        fileStream.Close()
        fileStream = New FileStream("\ITUpdate2.exe", FileMode.Create, FileAccess.ReadWrite)
        Dim wii As WebRequest = WebRequest.Create("http://192.168.1.163/updater/ITUpdate.exe")
        count = 1
        Dim buffage As Byte() = {0, 0, 0, 0, 0, 0, 0, 0}
        Try
            Dim ws As WebResponse = wii.GetResponse()
            Dim wa As Stream = ws.GetResponseStream()
            While count <> 0
                count = wa.Read(buffage, 0, buffer.Length)
                fileStream.Write(buffage, 0, count)
            End While
        Catch wox As WebException
            MsgBox("Can't Connect to Server." + Chr(13) + "File: /updater/ITUpdate.exe", 0, "Message")
            If File.Exists("ITUpdate2.exe") Then
                File.Delete("ITUpdate2.exe")
            End If
            abortUpdate = True
        End Try
        fileStream.Close()
        If Not abortUpdate Then
            If File.Exists("ITUpdate.exe") Then
                File.Delete("ITUpdate.exe")
            End If
            File.Move("ITUpdate2.exe", "ITUpdate.exe")
            If Form1.fileOpen Then
                'Form1.FileReader.Close()
            End If
            Shell("ITUpdate.exe")
            'Me.Close()
            Application.Exit()
            Application.DoEvents()
        End If
    End Sub

    Private Sub RefreshBtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RefreshBtn.Click
        Dim count As Integer = 1
        If File.Exists("\upcf.txt") Then
            File.Delete("\upcf.txt")
        End If
        Dim fileStream As FileStream = New FileStream("\upcf.txt", FileMode.Create, FileAccess.ReadWrite)
        Dim buffer As Byte() = {0, 0, 0, 0, 0, 0, 0, 0}
        Dim wr As WebRequest = WebRequest.Create(IndexBox.Text)
        Try
            Dim ws As WebResponse = wr.GetResponse()
            Dim wa As Stream = ws.GetResponseStream()
            While count <> 0
                count = wa.Read(buffer, 0, buffer.Length)
                fileStream.Write(buffer, 0, count)
            End While
        Catch wex As WebException
            MsgBox("Can't Connect to Server." + Chr(13) + "File: /upctest/upcf.txt", 0, "Message")
        End Try
        fileStream.Close()
    End Sub

    Private Sub SettingsForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        UpcChk.Checked = UpcFill
        SkuChk.Checked = SkuFill
        NetChk.Checked = NetFill
    End Sub
End Class