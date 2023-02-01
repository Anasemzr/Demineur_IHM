Module joueur
    Public Structure Joueur
        Dim nom As String

        Dim caseDecouverte As Integer
        Dim newCaseDecouverte As Integer
        Dim temps As Integer
        Dim newTemps As Integer

        Dim totalPartie As Integer
        Dim NbTempsDeJeu As Integer
    End Structure

    Private Const ALLONGEMENT_TABLEAU As Integer = 10
    Private tabJoueur() As Joueur
    Private nbJoueur As Integer = 0
    Private chemin As String = "sauvegarde.txt"

    Public Sub enrengistrer(nom As String)
        If nbJoueur > UBound(tabJoueur) Then
            ReDim Preserve tabJoueur(nbJoueur + ALLONGEMENT_TABLEAU)
        End If

        Dim joueurExistant As Boolean = False

        For i As Integer = 0 To nbJoueur
            If tabJoueur(i).nom = nom Then
                joueurExistant = True
                tabJoueur(i).totalPartie += 1
            End If
        Next

        If Not joueurExistant Then
            Dim j As Joueur
            j.nom = nom
            j.totalPartie = 1
            j.NbTempsDeJeu = 0
            j.caseDecouverte = 0
            j.temps = 0
            j.newTemps = 0

            tabJoueur(nbJoueur) = j
            nbJoueur += 1
        End If


    End Sub

    Public Sub enrengistrerTemps(nom As String)
        For i As Integer = 0 To nbJoueur
            If tabJoueur(i).nom = nom Then
                tabJoueur(i).newTemps = 60 - Val(jeu.Label2.Text) + 1
            End If
        Next
    End Sub

    Public Sub enrengistrerScores(nom As String)
        Dim scoreCase As Integer = 0
        For x As Integer = 0 To Math.Sqrt(mine.getNbCase()) - 1
            For y As Integer = 0 To Math.Sqrt(mine.getNbCase()) - 1

                If Not getCase(x, y).bouton.Enabled Then
                    scoreCase += 1
                End If
            Next
        Next

        For i As Integer = 0 To nbJoueur
            If tabJoueur(i).nom = nom Then
                If tabJoueur(i).caseDecouverte < scoreCase Then
                    tabJoueur(i).caseDecouverte = scoreCase
                    tabJoueur(i).temps = tabJoueur(i).newTemps
                End If
                tabJoueur(i).newCaseDecouverte = scoreCase
                tabJoueur(i).NbTempsDeJeu += tabJoueur(i).newTemps
            End If
        Next
    End Sub

    Public Function getJoueur(i As Integer) As Joueur
        Debug.Assert(i >= 0 AndAlso i < nbJoueur)
        Return tabJoueur(i)
    End Function

    Public Function getNbJoueur() As Integer
        Return nbJoueur
    End Function

    Public Function getScoreJoueur(nom As String) As Integer
        For i As Integer = 0 To nbJoueur
            If tabJoueur(i).nom = nom Then
                Return tabJoueur(i).newCaseDecouverte
            End If
        Next
    End Function

    Public Function getTempsJoueur(nom As String) As Integer
        For i As Integer = 0 To nbJoueur
            If tabJoueur(i).nom = nom Then
                Return tabJoueur(i).newTemps
            End If
        Next

    End Function

    Public Sub recapJoueur(nom As String)
        For i As Integer = 0 To nbJoueur
            If tabJoueur(i).nom = nom Then
                With tabJoueur(i)
                    MsgBox("Pseudo : " & .nom & vbCr & "Meilleurs partie : " & .caseDecouverte & " cases découvertes en " & .temps & " seconde" & vbCr & "Total du temps de Jeu : " & .NbTempsDeJeu & vbCr & "Nombre total de Partie : " & .totalPartie, MsgBoxStyle.DefaultButton3)
                End With


            End If
        Next
    End Sub

    Public Sub enrengistrerSauvegarde(nom As String)
        If nbJoueur > UBound(tabJoueur) Then
            ReDim Preserve tabJoueur(nbJoueur + ALLONGEMENT_TABLEAU)
        End If

        Dim num As Integer = FreeFile()
        FileOpen(num, nom, OpenMode.Input)

        Do Until EOF(num)
            Dim j As Joueur

            Input(num, j.nom)
            Input(num, j.totalPartie)
            Input(num, j.NbTempsDeJeu)
            Input(num, j.caseDecouverte)
            Input(num, j.temps)

            j.newTemps = 0

            tabJoueur(nbJoueur) = j
            nbJoueur += 1
        Loop




        FileClose(num)

    End Sub

    Public Function getCheminSauvegarde() As String
        Return chemin
    End Function

    Public Sub setCheminSauvegarde(newChemin As String)
        chemin = newChemin
    End Sub

    Sub main()
        ReDim tabJoueur(ALLONGEMENT_TABLEAU)
        enrengistrerSauvegarde(chemin)
        mine.creerBombe()
        Application.Run(Form1)
    End Sub
End Module
