Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Xml
Imports System.Drawing.Drawing2D
Imports CefSharp

Public Class Form1
    Private filePath As String = ""
    Private IsLoaded As Boolean = False
    Private login As String = ""
    Private password As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Logo Tempus !!!
        Dim base64Pixel As String = "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"
        PictureBoxTempus.Image = ResizeImageFloat(Base64ToImage(base64Pixel), 30, 30)

        LinkLabel1.Text = "Buy a Coffee for PipBoy2024"
        LinkLabel1.Links.Add(0, LinkLabel1.Text.Length, "https://ko-fi.com/pipboy2024")

        TextBoxMessage.Text = "Hello, Can you translate the following text into French for me in the style of the video game FALLOUT."

        ChromiumWebBrowser1.Load("https://chat.openai.com/")

        accesChatGPT()
    End Sub

    ' Gérer l'événement lorsque l'état de chargement de la page change
    Private Sub ChromiumBrowser_LoadingStateChanged(sender As Object, e As CefSharp.LoadingStateChangedEventArgs) Handles ChromiumWebBrowser1.LoadingStateChanged

        ' Vérifier si la page est complètement chargée
        If Not e.IsLoading Then
            ' La page a été complètement chargée, faire une action
            Dim script As String = "document.addEventListener('copy', function() {});" &
                                   "document.addEventListener('paste', function() {});"
            ChromiumWebBrowser1.ExecuteScriptAsync(script)
            IsLoaded = True
        Else
            IsLoaded = False
        End If
    End Sub

    Private Sub accesChatGPT()
        ' Chemin d'accès au fichier XML
        Dim cheminFichier As String = Application.StartupPath & "\accesChatGPT.xml"

        ' Créer un objet XmlDocument
        Dim xmlDoc As New XmlDocument()

        ' Charger le fichier XML
        xmlDoc.Load(cheminFichier)

        ' Accéder aux éléments "login" et "password"
        Dim loginNode As XmlNode = xmlDoc.SelectSingleNode("/acces/login")
        Dim passwordNode As XmlNode = xmlDoc.SelectSingleNode("/acces/password")

        ' Vérifier si les nœuds existent
        If loginNode IsNot Nothing AndAlso passwordNode IsNot Nothing Then
            ' Obtenir les valeurs de login et de mot de passe
            login = loginNode.InnerText
            TextBoxLogin.Text = login
            password = passwordNode.InnerText
            TextBoxPassword.Text = password
        End If
    End Sub

    Private Sub ButtonOpenFile_Click(sender As Object, e As EventArgs) Handles ButtonOpenFile.Click
        ListView1.Items.Clear()
        RichTextTrad.Clear()

        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "MSG Files (*.msg)|*.msg|Text Files (*.txt)|*.txt"
        openFileDialog.InitialDirectory = Application.StartupPath ' Définit le répertoire initial sur le répertoire de l'application

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            TextBox1.Text = openFileDialog.FileName

            filePath = openFileDialog.FileName
            Dim lines As List(Of String) = File.ReadAllLines(filePath).ToList()

            For i As Integer = 0 To lines.Count - 1
                Dim currentLine As String = lines(i)

                If currentLine.TrimStart().StartsWith("{") Then

                    Dim ligneFormated As String = ""
                    Dim regex As New Regex("\{([^{}]*?)\}")

                    Dim matchesCount As MatchCollection = regex.Matches(currentLine)

                    ' Mets le texte sur une seule ligne
                    If matchesCount.Count = 2 Then
                        For j As Integer = i + 1 To lines.Count - 1
                            currentLine &= lines(j)
                            If currentLine.EndsWith("}") Then
                                i = j
                                Exit For
                            End If
                        Next
                    End If

                    Dim MatchCollection As MatchCollection = regex.Matches(currentLine)

                    If MatchCollection.Count = 3 Then
                        Dim firstMatch As String = MatchCollection(0).Groups(1).Value
                        Dim secondMatch As String = MatchCollection(1).Groups(1).Value
                        Dim thirdMatch As String = MatchCollection(2).Groups(1).Value

                        ligneFormated = "{" & firstMatch & "}" & "{" & secondMatch & "}" & "{" & thirdMatch & "}"

                        Dim item As New ListViewItem(ligneFormated)
                        item.ForeColor = Color.Blue
                        item.Checked = True
                        ListView1.Items.Add(item)
                    Else
                        ' Ligne en erreur
                        Dim item As New ListViewItem(ligneFormated)
                        item.ForeColor = Color.Red
                        ListView1.Items.Add(item)
                    End If
                Else
                    ' Pas de ligne à traduire
                    Dim item As New ListViewItem(currentLine)
                    item.ForeColor = Color.Black
                    ListView1.Items.Add(item)
                End If
            Next

            ' Ajuster automatiquement la largeur de la colonne pour qu'elle occupe tout l'espace disponible
            ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent)

            ' Initialise les checkBox
            CopyCheckedItemsToListView(ListView1)
        End If
    End Sub

    Private Sub CopyCheckedItemsToListView(listView As ListView)
        ' Créer une chaîne pour stocker les éléments cochés
        Dim checkedItemsText As New StringBuilder()

        ' Parcourir tous les éléments de la ListView
        For Each item As ListViewItem In listView.Items
            ' Vérifier si la case à cocher de l'élément est cochée
            If item.Checked Then
                ' Ajouter le texte de l'élément à la chaîne
                checkedItemsText.AppendLine(item.Text)
            End If
        Next

        ' Copier la chaîne dans le presse-papiers
        If checkedItemsText.ToString() <> "" Then
            Clipboard.SetText(checkedItemsText.ToString())
        Else
            MsgBox("Translation of the finished file." & Environment.NewLine & "Please save the file.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonTransale.Click
        RichTextTrad.Clear()

        If Clipboard.ContainsText() Then
            ' Récupère le texte du presse-papiers
            Dim text As String = Clipboard.GetText()

            ' Affiche le texte récupéré dans une boîte de message
            RichTextTrad.AppendText(text & vbCrLf)

            For i As Integer = 0 To RichTextTrad.Lines.Length - 1
                Dim currentLineTrad As String = RichTextTrad.Lines(i)

                If Trim(currentLineTrad) <> "" And currentLineTrad.TrimStart().StartsWith("{") Then
                    Dim ligneTradFormated As String = ""
                    Dim ligneTradSearch As String = ""
                    Dim RichTextBoxContentLinesLength As Integer = 0

                    Dim regex As New Regex("\{([^{}]*?)\}")
                    Dim MatchCollection As MatchCollection = regex.Matches(currentLineTrad)

                    If MatchCollection.Count = 3 Then
                        Dim firstMatch As String = MatchCollection(0).Groups(1).Value
                        Dim secondMatch As String = MatchCollection(1).Groups(1).Value
                        Dim thirdMatch As String = MatchCollection(2).Groups(1).Value

                        ligneTradFormated = "{" & firstMatch & "}" & "{" & secondMatch & "}" & "{" & thirdMatch & "}"
                        ligneTradSearch = "{" & firstMatch & "}" & "{" & secondMatch & "}"


                        AddLineAfterItem(ListView1, ligneTradSearch, ligneTradFormated)
                    Else
                        AddLineAfterItem(ListView1, ligneTradSearch, "")
                    End If
                End If
            Next

            ' Initialise les checkBox
            CopyCheckedItemsToListView(ListView1)
        Else
            MessageBox.Show("The clipboard does not contain any text.")
        End If

    End Sub

    Private Sub AddLineAfterItem(listView As ListView, textToFind As String, textToAdd As String)

        ' Parcourir chaque élément de la ListView
        For Each item As ListViewItem In listView.Items
            ' Vérifier si le texte de l'élément correspond au texte recherché
            If item.Text.Contains(textToFind) And textToAdd <> "" Then
                item.Text = "#" & item.Text
                item.Checked = False

                ' Ajouter une nouvelle ligne après l'élément trouvé
                Dim newItem As New ListViewItem(textToAdd)
                newItem.ForeColor = Color.DarkGreen
                listView.Items.Insert(item.Index + 1, newItem)
                Exit For ' Sortir de la boucle après avoir ajouté la ligne
            End If
        Next
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click

        ' La page a été complètement chargée, faire une action
        If IsLoaded = True Then
            Dim script As String = "if (document.getElementById('email-input')) {
                                        document.getElementById('email-input').value = '" & login & "'
                                    }
                                    if (document.getElementById('username')) {
                                        document.getElementById('username').value = '" & login & "'
                                    }"
            ChromiumWebBrowser1.ExecuteScriptAsync(script)
        End If
    End Sub

    Private Sub ButtonPassWord_Click(sender As Object, e As EventArgs) Handles ButtonPassWord.Click

        ' La page a été complètement chargée, faire une action
        If IsLoaded = True Then
            Dim script As String = "if (document.getElementById('password')) {
                                        document.getElementById('password').value = '" & password & "'
                                    }"
            ChromiumWebBrowser1.ExecuteScriptAsync(script)
        End If
    End Sub

    Private Sub ButtonMessageChat_Click(sender As Object, e As EventArgs) Handles ButtonMessageChat.Click

        ' La page a été complètement chargée, faire une action
        If IsLoaded = True Then
            Dim script As String = "if (document.getElementById('prompt-textarea')) {document.getElementById('prompt-textarea').focus();document.getElementById('prompt-textarea').value = '" & TextBoxMessage.Text & "' }"
            ChromiumWebBrowser1.ExecuteScriptAsync(script)
        End If
    End Sub

    Private Sub ButtonSaveTrad_Click(sender As Object, e As EventArgs) Handles ButtonSaveTrad.Click

        ' Chemin du fichier de sortie
        Dim cheminFichier As String = TextBox1.Text

        If cheminFichier <> "" Then
            ' Créer un objet StreamWriter avec un encodage ANSI, en écrasant le fichier existant s'il existe déjà
            Using writer As New StreamWriter(cheminFichier, False, System.Text.Encoding.UTF8)
                ' Parcourir chaque élément de la ListView
                For Each item As ListViewItem In ListView1.Items
                    ' Écrire le texte de chaque élément dans le fichier
                    writer.WriteLine(item.Text)
                Next
            End Using

            MsgBox("Save the file OK.")
        End If
    End Sub

    Private Sub ButtonSaveProfil_Click(sender As Object, e As EventArgs) Handles ButtonSaveProfil.Click
        ' Chemin d'accès au fichier XML
        Dim cheminFichier As String = Application.StartupPath & "\accesChatGPT.xml"

        ' XML en chaîne de caractères
        Dim xmlString As String = "<?xml version=""1.0"" encoding=""utf-8""?>" & vbCrLf &
                                  "<acces>" & vbCrLf &
                                  "    <login>" & TextBoxLogin.Text & "</login>" & vbCrLf &
                                  "    <password>" & TextBoxPassword.Text & "</password>" & vbCrLf &
                                  "</acces>"


        ' Enregistrer la chaîne de caractères dans un fichier
        File.WriteAllText(cheminFichier, xmlString)

        login = TextBoxLogin.Text
        password = TextBoxPassword.Text

    End Sub

    Private Function Base64ToImage(base64String As String) As Image

        ' Convertir la base64 en tableau d'octets
        Dim bytes As Byte() = Convert.FromBase64String(base64String)

        ' Créer un MemoryStream à partir du tableau d'octets
        Using memoryStream As New MemoryStream(bytes)
            ' Créer l'objet Image à partir du MemoryStream
            Dim image As Image = Image.FromStream(memoryStream)
            Return image
        End Using

    End Function

    Private Function ResizeImageFloat(image As Image, width As Integer, height As Integer) As Image
        Dim newImage As New Bitmap(width, height)

        Using g As Graphics = Graphics.FromImage(newImage)
            ' Rendre l'arrière-plan transparent
            newImage.MakeTransparent()

            ' Redimensionner l'image à la nouvelle taille
            g.InterpolationMode = InterpolationMode.HighQualityBicubic
            g.DrawImage(image, 0, 0, width, height)
        End Using

        Return newImage
    End Function

    Private Sub PictureBoxTempus_Click(sender As Object, e As EventArgs) Handles PictureBoxTempus.Click
        CustomMessageBox.Show("Tempus Production.", "https://ko-fi.com/pipboy2024")
    End Sub

    Private Sub TextBoxLogin_Click(sender As Object, e As EventArgs) Handles TextBoxLogin.Click
        If TextBoxLogin.Text = "Insert Your Login ChatGPT" Then
            TextBoxLogin.Text = ""
        End If
    End Sub
    Private Sub TextBoxLogin_Leave(sender As Object, e As EventArgs) Handles TextBoxLogin.Leave
        If TextBoxLogin.Text = "" Then
            TextBoxLogin.Text = "Insert Your Login ChatGPT"
        End If
    End Sub

    Private Sub TextBoxPassword_Click(sender As Object, e As EventArgs) Handles TextBoxPassword.Click
        If TextBoxPassword.Text = "Insert Your PassWord ChatGPT" Then
            TextBoxPassword.Text = ""
        End If
    End Sub

    Private Sub TextBoxPassword_Leave(sender As Object, e As EventArgs) Handles TextBoxPassword.Leave
        If TextBoxPassword.Text = "" Then
            TextBoxPassword.Text = "Insert Your PassWord ChatGPT"
        End If
    End Sub

    Private Sub Btn_copy_Click(sender As Object, e As EventArgs) Handles Btn_copy.Click
        ' Initialise les checkBox
        CopyCheckedItemsToListView(ListView1)
    End Sub


    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim target As String = CStr(e.Link.LinkData)
        Try
            Process.Start(New ProcessStartInfo(target) With {.UseShellExecute = True})
        Catch ex As Exception
            MessageBox.Show("Unable to open link. " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Utiliser une liste temporaire pour stocker les éléments à supprimer
        Dim itemsToRemove As New List(Of ListViewItem)()

        ' Parcourir tous les éléments de la ListView
        For Each item As ListViewItem In ListView1.Items
            ' Vérifier si l'élément commence par "#{"
            If item.Text.StartsWith("#{") Then
                ' Ajouter l'élément à la liste des éléments à supprimer
                itemsToRemove.Add(item)
            End If
        Next

        ' Supprimer les éléments identifiés de la ListView
        For Each itemToRemove As ListViewItem In itemsToRemove
            ListView1.Items.Remove(itemToRemove)
        Next
    End Sub
End Class
