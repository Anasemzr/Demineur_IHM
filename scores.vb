Public Class scores
    Private Typetrie As String = "croissant"

    Private Sub Quitter_Click(sender As Object, e As EventArgs) Handles Quitter.Click
        Dim resultat As MsgBoxResult = MsgBox("Etes vous sur de vouloir quitter ?", MsgBoxStyle.YesNo, "Confirmer votre choix")
        If resultat = MsgBoxResult.Yes Then

            Me.Close()
        End If
        Form1.Show()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        For i As Integer = 0 To getNbJoueur() - 1
            If getJoueur(i).nom = ListBox1.SelectedItem.ToString() Then
                minute.Text = getJoueur(i).temps & " seconde"
                point.Text = getJoueur(i).caseDecouverte
            End If
        Next
        ComboBoxScore.SelectedItem = ListBox1.SelectedItem.ToString

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not IsNothing(ComboBoxScore.SelectedItem) Then
            joueur.recapJoueur(ComboBoxScore.SelectedItem.ToString)
        End If
    End Sub

    Public Sub trie(ordre As String)
        Dim tabTrie(getNbJoueur) As joueur.Joueur

        For i As Integer = 0 To getNbJoueur() - 1
            tabTrie(i) = getJoueur(i)
        Next

        For one As Integer = 0 To getNbJoueur() - 1
            For two As Integer = 0 To getNbJoueur() - 1
                If ordre = "croissant" Then
                    If tabTrie(one).caseDecouverte < tabTrie(two).caseDecouverte Then
                        Dim jugador As joueur.Joueur = tabTrie(one)
                        tabTrie(one) = tabTrie(two)
                        tabTrie(two) = jugador
                    ElseIf tabTrie(one).caseDecouverte = tabTrie(two).caseDecouverte Then

                        If tabTrie(one).temps < tabTrie(two).temps Then
                            Dim jugador As joueur.Joueur = tabTrie(one)
                            tabTrie(one) = tabTrie(two)
                            tabTrie(two) = jugador
                        End If
                    End If
                Else
                    If tabTrie(one).caseDecouverte > tabTrie(two).caseDecouverte Then
                        Dim jugador As joueur.Joueur = tabTrie(one)
                        tabTrie(one) = tabTrie(two)
                        tabTrie(two) = jugador
                    ElseIf tabTrie(one).caseDecouverte = tabTrie(two).caseDecouverte Then

                        If tabTrie(one).temps < tabTrie(two).temps Then
                            Dim jugador As joueur.Joueur = tabTrie(one)
                            tabTrie(one) = tabTrie(two)
                            tabTrie(two) = jugador
                        End If
                    End If

                End If



            Next
        Next

        ListBox1.Items.Clear()


        For i As Integer = 0 To getNbJoueur() - 1
            ListBox1.Items.Add(tabTrie(i).nom)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Typetrie = "croissant" Then
            Typetrie = "décroissant"
            trie("décroissant")
        Else
            Typetrie = "croissant"
            trie("croissant")
        End If

    End Sub

End Class