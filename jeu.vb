Public Class jeu

    Private Sub resolution()
        Select Case mine.getNbCase
            Case 36
                setResolution(650, 400)
            Case 64
                setResolution(750, 500)
            Case 144
                setResolution(950, 700)
        End Select
    End Sub

    Private Sub jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        joueur.enrengistrer(Form1.ComboBoxPseudo.Text)
        resolution()

        For i As Integer = 3 To Math.Sqrt(mine.getNbCase) + 2
            For j As Integer = 1 To Math.Sqrt(mine.getNbCase)
                Dim bouton = New Button
                bouton.Width = 50
                bouton.Height = 50
                bouton.Left = i * 50
                bouton.Top = j * 50
                bouton.BackColor = Color.LightGray

                Me.Controls.Add(bouton)
                mine.enrengistrer(bouton, i - 3, j - 1)

                'AddHandler bouton.Click, AddressOf boutonClick'
                AddHandler bouton.MouseClick, AddressOf boutonClick
            Next
        Next

        TitreJeu.Left = ((Math.Sqrt(mine.getNbCase) + 2) * 50) / 2
        QUITTER.Left = ((Math.Sqrt(mine.getNbCase) + 4) * 50)


        Timer1.Enabled = True
        Timer1.Interval = 1000

        Label2.Text = 60
        Label3.Text = Form1.ComboBoxPseudo.Text


    End Sub

    Private Sub boutonClick(sender As Object, m As MouseEventArgs)
        For i As Integer = 0 To Math.Sqrt(mine.getNbCase) - 1
            For j As Integer = 0 To Math.Sqrt(mine.getNbCase) - 1
                If sender.Equals(getCase(i, j).bouton) Then

                    If getCase(i, j).bombe = True Then

                        getCase(i, j).bouton.BackColor = Color.Red
                        MsgBox("Oh non, tu as perdu ! " & vbCr & "Retente ta chance la prochaine fois...", MsgBoxStyle.Exclamation, " PARTIE PERDUE")
                        finJeu()


                    Else
                        If getCase(i, j).mineProximite > 0 Then
                            getCase(i, j).bouton.Text = getCase(i, j).mineProximite
                        Else
                            recursiveCaseVide(i, j)
                        End If
                        getCase(i, j).bouton.BackColor = Color.White
                    End If

                    getCase(i, j).bouton.Enabled = False
                    joueur.enrengistrerTemps(Form1.ComboBoxPseudo.Text)

                End If
            Next
        Next

    End Sub

    Private Sub finJeu()
        Label2.Visible = False
        joueur.enrengistrerScores(Form1.ComboBoxPseudo.Text)
        MsgBox("Scores : " & joueur.getScoreJoueur(Form1.ComboBoxPseudo.Text) & " cases découvertes" & vbCr & " Temps : " & joueur.getTempsJoueur(Form1.ComboBoxPseudo.Text) & " seconde", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Récapitulatif")
        Me.Close()
        Form1.miseAJour()
        Form1.Show()
        Form1.ComboBoxPseudo.Text = ""

        If Form1.getOn() Then
            My.Computer.Audio.Stop()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles QUITTER.Click
        Dim resultat As MsgBoxResult = MsgBox("Etes vous sur de vouloir quitter ?", MsgBoxStyle.YesNo, "Confirmer votre choix")
        If resultat = MsgBoxResult.Yes Then
            finJeu()

        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Val(Label2.Text) > 0 Then
            Label2.Text = Val(Label2.Text) - 1
        End If

        If Val(Label2.Text) = 0 Then
            finJeu()
        End If

        If mine.partieGagner() Then
            Timer1.Enabled = False
            MsgBox("Bravo champion(ne) ! " & vbCr & "Tu as gagné(e) la partie !", MsgBoxStyle.Information, " PARTIE GAGNÉE")
            finJeu()
        End If
    End Sub

    Private Sub recursiveCaseVide(i As Integer, j As Integer)
        If i >= 0 And i < Math.Sqrt(mine.getNbCase) And j >= 0 AndAlso j < Math.Sqrt(mine.getNbCase) Then

            If getCase(i, j).mineProximite > 0 Then
                getCase(i, j).bouton.Text = getCase(i, j).mineProximite
                getCase(i, j).bouton.BackColor = Color.White
                getCase(i, j).bouton.Enabled = False
            Else
                getCase(i, j).bouton.BackColor = Color.White
                If i + 1 < Math.Sqrt(mine.getNbCase) Then
                    If getCase(i + 1, j).bouton.Enabled Then
                        getCase(i + 1, j).bouton.Enabled = False
                        recursiveCaseVide(i + 1, j)
                    End If
                End If


                If j - 1 >= 0 Then
                    If getCase(i, j - 1).bouton.Enabled Then
                        getCase(i, j - 1).bouton.Enabled = False
                        recursiveCaseVide(i, j - 1)
                    End If
                End If


                If i - 1 >= 0 Then
                    If getCase(i - 1, j).bouton.Enabled Then
                        getCase(i - 1, j).bouton.Enabled = False
                        recursiveCaseVide(i - 1, j)
                    End If
                End If


                If j + 1 < Math.Sqrt(mine.getNbCase) Then
                    If getCase(i, j + 1).bouton.Enabled Then
                        getCase(i, j + 1).bouton.Enabled = False
                        recursiveCaseVide(i, j + 1)
                    End If
                End If


            End If

        End If

    End Sub

    Public Sub setResolution(i As Integer, y As Integer)
        Me.Width = i
        Me.Height = y
    End Sub


End Class