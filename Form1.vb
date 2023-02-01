Public Class Form1
    Private aleatoire As Boolean = True
    Private listeMusic As New List(Of String)({"Fun.wav", "fun2.wav", "fun3.wav", "fun4.wav", "Joyeuse.wav", "rock.wav", "rock_electro.wav"})
    Private musicOn As Boolean = True
    Public Sub setMode(mode As Boolean)
        aleatoire = mode
    End Sub

    Public Sub setOn(OnOff As Boolean)
        musicOn = OnOff
    End Sub

    Public Function getOn() As Boolean
        Return musicOn
    End Function

    Private Function music() As String
        If aleatoire Then
            Dim rnd = New Random()
            Return listeMusic(rnd.Next(0, listeMusic.Count))
        Else
            Return parametre.ComboboxMusic.Text
        End If
    End Function

    Private Sub Quitter_Click(sender As Object, e As EventArgs) Handles Quitter.Click
        Dim resultat As MsgBoxResult = MsgBox("Etes vous sur de vouloir quitter ?", MsgBoxStyle.YesNo, "Confirmer votre choix")
        If resultat = MsgBoxResult.Yes Then
            enrengistrerSauvegarde(getCheminSauvegarde())
            Me.Close()
        End If

    End Sub

    Private Sub enrengistrerSauvegarde(nom As String)
        Dim num As Integer = FreeFile()
        FileOpen(num, nom, OpenMode.Output)


        For i As Integer = 0 To getNbJoueur() - 1
            Write(num, getJoueur(i).nom)
            Write(num, getJoueur(i).totalPartie)
            Write(num, getJoueur(i).NbTempsDeJeu)
            Write(num, getJoueur(i).caseDecouverte)
            Write(num, getJoueur(i).temps)
        Next

        FileClose(num)
    End Sub

    Private Sub initialisationPseudo()
        Pseudo.ForeColor = Color.Black
        ComboBoxPseudo.Text = ""
    End Sub

    Private Sub Jouer_Click(sender As Object, e As EventArgs) Handles Jouer.Click

        If ComboBoxPseudo.Text.Length < 3 Then
            Pseudo.ForeColor = Color.Red
        Else

            Me.Hide()
            mine.restart()


            jeu.Show()
            If musicOn Then
                My.Computer.Audio.Play(music(), AudioPlayMode.BackgroundLoop)
            End If

        End If

    End Sub

    Public Sub miseAJour()

        scores.ListBox1.Items.Clear()
        scores.ComboBoxScore.Items.Clear()
        ComboBoxPseudo.Items.Clear()

        For i As Integer = 0 To getNbJoueur() - 1
            scores.ListBox1.Items.Add(getJoueur(i).nom)
            ComboBoxPseudo.Items.Add(getJoueur(i).nom)
            scores.ComboBoxScore.Items.Add(getJoueur(i).nom)
        Next
        scores.trie("decroissant")
    End Sub

    Private Sub Score_Click(sender As Object, e As EventArgs) Handles Score.Click
        miseAJour()
        Me.Hide()

        scores.Show()
    End Sub

    Private Sub parametre_Click(sender As Object, e As EventArgs) Handles parametrebtn.Click
        Me.Hide()
        parametre.ComboboxMusic.Items.AddRange(listeMusic.ToArray())
        parametre.ShowDialog()


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
