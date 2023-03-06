<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class SettingsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Private mainMenu1 As System.Windows.Forms.MainMenu

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.SkuChk = New System.Windows.Forms.CheckBox
        Me.UpcChk = New System.Windows.Forms.CheckBox
        Me.NetChk = New System.Windows.Forms.CheckBox
        Me.IndexBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ProgBar = New System.Windows.Forms.ProgressBar
        Me.UpdateBtn = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.RefreshBtn = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        Me.mainMenu1.MenuItems.Add(Me.MenuItem2)
        '
        'MenuItem1
        '
        Me.MenuItem1.Text = "Cancel"
        '
        'MenuItem2
        '
        Me.MenuItem2.Text = "Save"
        '
        'SkuChk
        '
        Me.SkuChk.Location = New System.Drawing.Point(4, 4)
        Me.SkuChk.Name = "SkuChk"
        Me.SkuChk.Size = New System.Drawing.Size(100, 20)
        Me.SkuChk.TabIndex = 0
        Me.SkuChk.Text = "Search SKUs"
        '
        'UpcChk
        '
        Me.UpcChk.Location = New System.Drawing.Point(4, 30)
        Me.UpcChk.Name = "UpcChk"
        Me.UpcChk.Size = New System.Drawing.Size(100, 20)
        Me.UpcChk.TabIndex = 1
        Me.UpcChk.Text = "Search UPCs"
        '
        'NetChk
        '
        Me.NetChk.Location = New System.Drawing.Point(4, 57)
        Me.NetChk.Name = "NetChk"
        Me.NetChk.Size = New System.Drawing.Size(115, 20)
        Me.NetChk.TabIndex = 2
        Me.NetChk.Text = "Search Internet"
        '
        'IndexBox
        '
        Me.IndexBox.Location = New System.Drawing.Point(3, 121)
        Me.IndexBox.Name = "IndexBox"
        Me.IndexBox.Size = New System.Drawing.Size(100, 21)
        Me.IndexBox.TabIndex = 3
        Me.IndexBox.Text = "http://192.168.1.163/upctest/upcf.txt"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.Text = "Index File Url:"
        '
        'ProgBar
        '
        Me.ProgBar.Location = New System.Drawing.Point(4, 245)
        Me.ProgBar.Name = "ProgBar"
        Me.ProgBar.Size = New System.Drawing.Size(233, 20)
        '
        'UpdateBtn
        '
        Me.UpdateBtn.Location = New System.Drawing.Point(165, 219)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(72, 20)
        Me.UpdateBtn.TabIndex = 8
        Me.UpdateBtn.Text = "Update..."
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(4, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.Text = "v10.7, 2023"
        '
        'RefreshBtn
        '
        Me.RefreshBtn.Location = New System.Drawing.Point(109, 121)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(72, 20)
        Me.RefreshBtn.TabIndex = 11
        Me.RefreshBtn.Text = "Refresh"
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.RefreshBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UpdateBtn)
        Me.Controls.Add(Me.ProgBar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IndexBox)
        Me.Controls.Add(Me.NetChk)
        Me.Controls.Add(Me.UpcChk)
        Me.Controls.Add(Me.SkuChk)
        Me.Menu = Me.mainMenu1
        Me.Name = "SettingsForm"
        Me.Text = "ITracker Settings"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SkuChk As System.Windows.Forms.CheckBox
    Friend WithEvents UpcChk As System.Windows.Forms.CheckBox
    Friend WithEvents NetChk As System.Windows.Forms.CheckBox
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents IndexBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProgBar As System.Windows.Forms.ProgressBar
    Friend WithEvents UpdateBtn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RefreshBtn As System.Windows.Forms.Button
End Class
