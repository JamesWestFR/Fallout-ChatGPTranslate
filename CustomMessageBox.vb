Imports System.Diagnostics

Public Class CustomMessageBox
    Public Shared Sub Show(message As String, url As String)
        Dim form As New Form()
        Dim label As New Label()
        Dim labelTiPeee As New Label()
        Dim linkLabel As New LinkLabel()

        form.Text = "Fallout ChatGPTranslate"
        form.Size = New Size(350, 150)
        form.StartPosition = FormStartPosition.CenterScreen

        label.Text = message
        label.Location = New Point(20, 20)
        label.AutoSize = True

        labelTiPeee.Text = "Buy a Coffee for PipBoy2024 : "
        labelTiPeee.Location = New Point(20, 50)
        labelTiPeee.AutoSize = True

        linkLabel.Text = url
        linkLabel.Location = New Point(170, 50)
        linkLabel.AutoSize = True
        AddHandler linkLabel.LinkClicked, Sub(sender, e) Process.Start(url)

        form.Controls.Add(label)
        form.Controls.Add(labelTiPeee)
        form.Controls.Add(linkLabel)

        form.ShowDialog()
    End Sub
End Class
