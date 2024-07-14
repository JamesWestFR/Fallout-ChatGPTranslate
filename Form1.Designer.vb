<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ButtonOpenFile = New System.Windows.Forms.Button()
        Me.ButtonTransale = New System.Windows.Forms.Button()
        Me.ButtonSaveTrad = New System.Windows.Forms.Button()
        Me.ChromiumWebBrowser1 = New CefSharp.WinForms.ChromiumWebBrowser()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RichTextTrad = New System.Windows.Forms.RichTextBox()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.ButtonPassWord = New System.Windows.Forms.Button()
        Me.ButtonMessageChat = New System.Windows.Forms.Button()
        Me.TextBoxLogin = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.TextBoxMessage = New System.Windows.Forms.TextBox()
        Me.ButtonSaveProfil = New System.Windows.Forms.Button()
        Me.PictureBoxTempus = New System.Windows.Forms.PictureBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Btn_copy = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBoxTempus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(490, 20)
        Me.TextBox1.TabIndex = 0
        '
        'ButtonOpenFile
        '
        Me.ButtonOpenFile.Location = New System.Drawing.Point(508, 13)
        Me.ButtonOpenFile.Name = "ButtonOpenFile"
        Me.ButtonOpenFile.Size = New System.Drawing.Size(90, 20)
        Me.ButtonOpenFile.TabIndex = 1
        Me.ButtonOpenFile.Text = "Open File"
        Me.ButtonOpenFile.UseVisualStyleBackColor = True
        '
        'ButtonTransale
        '
        Me.ButtonTransale.Location = New System.Drawing.Point(108, 41)
        Me.ButtonTransale.Name = "ButtonTransale"
        Me.ButtonTransale.Size = New System.Drawing.Size(120, 20)
        Me.ButtonTransale.TabIndex = 2
        Me.ButtonTransale.Text = "Translate"
        Me.ButtonTransale.UseVisualStyleBackColor = True
        '
        'ButtonSaveTrad
        '
        Me.ButtonSaveTrad.Location = New System.Drawing.Point(586, 41)
        Me.ButtonSaveTrad.Name = "ButtonSaveTrad"
        Me.ButtonSaveTrad.Size = New System.Drawing.Size(120, 20)
        Me.ButtonSaveTrad.TabIndex = 3
        Me.ButtonSaveTrad.Text = "Save"
        Me.ButtonSaveTrad.UseVisualStyleBackColor = True
        '
        'ChromiumWebBrowser1
        '
        Me.ChromiumWebBrowser1.ActivateBrowserOnCreation = False
        Me.ChromiumWebBrowser1.Location = New System.Drawing.Point(730, 111)
        Me.ChromiumWebBrowser1.Name = "ChromiumWebBrowser1"
        Me.ChromiumWebBrowser1.Size = New System.Drawing.Size(737, 738)
        Me.ChromiumWebBrowser1.TabIndex = 5
        '
        'ListView1
        '
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 67)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(694, 782)
        Me.ListView1.TabIndex = 7
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Text To Translate"
        Me.ColumnHeader1.Width = 670
        '
        'RichTextTrad
        '
        Me.RichTextTrad.Location = New System.Drawing.Point(1022, 14)
        Me.RichTextTrad.Name = "RichTextTrad"
        Me.RichTextTrad.Size = New System.Drawing.Size(79, 22)
        Me.RichTextTrad.TabIndex = 8
        Me.RichTextTrad.Text = ""
        Me.RichTextTrad.Visible = False
        '
        'ButtonLogin
        '
        Me.ButtonLogin.Location = New System.Drawing.Point(730, 49)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(120, 20)
        Me.ButtonLogin.TabIndex = 9
        Me.ButtonLogin.Text = "Login"
        Me.ButtonLogin.UseVisualStyleBackColor = True
        '
        'ButtonPassWord
        '
        Me.ButtonPassWord.Location = New System.Drawing.Point(1022, 49)
        Me.ButtonPassWord.Name = "ButtonPassWord"
        Me.ButtonPassWord.Size = New System.Drawing.Size(120, 20)
        Me.ButtonPassWord.TabIndex = 10
        Me.ButtonPassWord.Text = "Password"
        Me.ButtonPassWord.UseVisualStyleBackColor = True
        '
        'ButtonMessageChat
        '
        Me.ButtonMessageChat.Location = New System.Drawing.Point(730, 84)
        Me.ButtonMessageChat.Name = "ButtonMessageChat"
        Me.ButtonMessageChat.Size = New System.Drawing.Size(120, 20)
        Me.ButtonMessageChat.TabIndex = 11
        Me.ButtonMessageChat.Text = "First Phrase GPT"
        Me.ButtonMessageChat.UseVisualStyleBackColor = True
        '
        'TextBoxLogin
        '
        Me.TextBoxLogin.Location = New System.Drawing.Point(857, 49)
        Me.TextBoxLogin.Name = "TextBoxLogin"
        Me.TextBoxLogin.Size = New System.Drawing.Size(159, 20)
        Me.TextBoxLogin.TabIndex = 13
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(1149, 49)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(167, 20)
        Me.TextBoxPassword.TabIndex = 14
        '
        'TextBoxMessage
        '
        Me.TextBoxMessage.Location = New System.Drawing.Point(857, 85)
        Me.TextBoxMessage.Name = "TextBoxMessage"
        Me.TextBoxMessage.Size = New System.Drawing.Size(610, 20)
        Me.TextBoxMessage.TabIndex = 15
        '
        'ButtonSaveProfil
        '
        Me.ButtonSaveProfil.Location = New System.Drawing.Point(1347, 48)
        Me.ButtonSaveProfil.Name = "ButtonSaveProfil"
        Me.ButtonSaveProfil.Size = New System.Drawing.Size(120, 20)
        Me.ButtonSaveProfil.TabIndex = 16
        Me.ButtonSaveProfil.Text = "Save Profil"
        Me.ButtonSaveProfil.UseVisualStyleBackColor = True
        '
        'PictureBoxTempus
        '
        Me.PictureBoxTempus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxTempus.Location = New System.Drawing.Point(1437, 2)
        Me.PictureBoxTempus.Name = "PictureBoxTempus"
        Me.PictureBoxTempus.Size = New System.Drawing.Size(30, 30)
        Me.PictureBoxTempus.TabIndex = 17
        Me.PictureBoxTempus.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(1288, 17)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(143, 13)
        Me.LinkLabel1.TabIndex = 18
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Buy a Coffee for PipBoy2024"
        '
        'Btn_copy
        '
        Me.Btn_copy.Location = New System.Drawing.Point(12, 41)
        Me.Btn_copy.Name = "Btn_copy"
        Me.Btn_copy.Size = New System.Drawing.Size(90, 20)
        Me.Btn_copy.TabIndex = 19
        Me.Btn_copy.Text = "Copy"
        Me.Btn_copy.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(460, 41)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 20)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Remove Original Line"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1484, 861)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Btn_copy)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.PictureBoxTempus)
        Me.Controls.Add(Me.ButtonSaveProfil)
        Me.Controls.Add(Me.TextBoxMessage)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.TextBoxLogin)
        Me.Controls.Add(Me.ButtonMessageChat)
        Me.Controls.Add(Me.ButtonPassWord)
        Me.Controls.Add(Me.ButtonLogin)
        Me.Controls.Add(Me.RichTextTrad)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.ChromiumWebBrowser1)
        Me.Controls.Add(Me.ButtonSaveTrad)
        Me.Controls.Add(Me.ButtonTransale)
        Me.Controls.Add(Me.ButtonOpenFile)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.Text = "Fallout ChatGPTrad"
        CType(Me.PictureBoxTempus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ButtonOpenFile As Button
    Friend WithEvents ButtonTransale As Button
    Friend WithEvents ButtonSaveTrad As Button
    Friend WithEvents ChromiumWebBrowser1 As CefSharp.WinForms.ChromiumWebBrowser
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents RichTextTrad As RichTextBox
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents ButtonPassWord As Button
    Friend WithEvents ButtonMessageChat As Button
    Friend WithEvents TextBoxLogin As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents TextBoxMessage As TextBox
    Friend WithEvents ButtonSaveProfil As Button
    Friend WithEvents PictureBoxTempus As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Btn_copy As Button
    Friend WithEvents Button1 As Button
End Class
