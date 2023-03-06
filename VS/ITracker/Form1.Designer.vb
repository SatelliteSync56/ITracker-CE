<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form1
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
    private mainMenu1 As System.Windows.Forms.MainMenu

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.OpenIndexBtn = New System.Windows.Forms.Button
        Me.SettingsBtn = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.WebChk = New System.Windows.Forms.WebBrowser
        Me.Label4 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        Me.mainMenu1.MenuItems.Add(Me.MenuItem2)
        '
        'MenuItem1
        '
        Me.MenuItem1.Text = "Exit"
        '
        'MenuItem2
        '
        Me.MenuItem2.Text = "About"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(76, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(161, 21)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 20)
        Me.Label1.Text = "Enter UPC:"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'OpenIndexBtn
        '
        Me.OpenIndexBtn.Location = New System.Drawing.Point(4, 244)
        Me.OpenIndexBtn.Name = "OpenIndexBtn"
        Me.OpenIndexBtn.Size = New System.Drawing.Size(106, 20)
        Me.OpenIndexBtn.TabIndex = 1
        Me.OpenIndexBtn.Text = "Open Index..."
        '
        'SettingsBtn
        '
        Me.SettingsBtn.Location = New System.Drawing.Point(131, 244)
        Me.SettingsBtn.Name = "SettingsBtn"
        Me.SettingsBtn.Size = New System.Drawing.Size(106, 20)
        Me.SettingsBtn.TabIndex = 2
        Me.SettingsBtn.Text = "Settings"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Courier New", 14.0!, System.Drawing.FontStyle.Regular)
        Me.Label2.Location = New System.Drawing.Point(4, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 39)
        Me.Label2.Text = "000 000000 000"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(4, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(233, 18)
        Me.Label3.Text = "Index         SKU         Dept."
        '
        'WebChk
        '
        Me.WebChk.Location = New System.Drawing.Point(4, 108)
        Me.WebChk.Name = "WebChk"
        Me.WebChk.Size = New System.Drawing.Size(233, 130)
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(4, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.Text = "None"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.WebChk)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SettingsBtn)
        Me.Controls.Add(Me.OpenIndexBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.KeyPreview = True
        Me.Menu = Me.mainMenu1
        Me.Name = "Form1"
        Me.Text = "Inventory Tracker"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenIndexBtn As System.Windows.Forms.Button
    Friend WithEvents SettingsBtn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents WebChk As System.Windows.Forms.WebBrowser
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
