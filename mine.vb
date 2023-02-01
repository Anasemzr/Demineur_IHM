Module mine
    Public Structure caseBouton
        Dim bouton As Button
        Dim x As Integer
        Dim y As Integer
        Dim mineProximite As Integer
        Dim bombe As Boolean
        Dim CaseSurvoler As Boolean
    End Structure

    Public Structure Bombe
        Dim x As Integer
        Dim y As Integer
    End Structure

    Private nbCase As Integer = 64
    Private tabCase(nbCase) As caseBouton
    Private compteurCase As Integer = 0
    Private nbBombe As Integer = 10
    Private tabBombe(nbBombe) As Bombe


    Public Sub enrengistrer(b As Button, i As Integer, j As Integer)
        Dim c As caseBouton
        c.bouton = b
        c.x = i
        c.y = j

        If bombeOuiNon(i, j) Then
            c.bombe = True
        Else
            c.bombe = False
        End If

        c.mineProximite = bombeProximi(i, j)
        c.CaseSurvoler = False

        tabCase(compteurCase) = c
        compteurCase += 1
    End Sub

    Public Function getCase(x As Integer, y As Integer) As caseBouton
        For i As Integer = 0 To nbCase - 1
            If tabCase(i).x = x And tabCase(i).y = y Then
                Return tabCase(i)
            End If
        Next
    End Function

    Public Sub restart()
        ReDim tabCase(nbCase)
        ReDim tabBombe(nbBombe)
        compteurCase = 0
        creerBombe()
    End Sub

    Public Sub creerBombe()
        For i As Integer = 0 To nbBombe
            Dim b As Bombe
            Randomize()
            b.x = CInt(Int((Math.Sqrt(nbCase) * Rnd()) + 1))
            b.y = CInt(Int(((Math.Sqrt(nbCase) * Rnd()) + 1)))
            tabBombe(i) = b
        Next
    End Sub

    Public Function bombeOuiNon(x As Integer, y As Integer) As Boolean
        For i As Integer = 0 To nbBombe
            If tabBombe(i).x = x And tabBombe(i).y = y Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function bombeProximi(x As Integer, y As Integer) As Integer
        Dim compteur As Integer = 0

        If bombeOuiNon(x + 1, y) And (x + 1 < Math.Sqrt(nbCase)) Then
            compteur += 1
        End If

        If bombeOuiNon(x - 1, y) And (x - 1 > 0) Then
            compteur += 1
        End If

        If bombeOuiNon(x + 1, y + 1) And (x + 1 < Math.Sqrt(nbCase)) AndAlso (y + 1 < Math.Sqrt(nbCase)) Then
            compteur += 1
        End If

        If bombeOuiNon(x - 1, y + 1) And (x - 1 > 0) AndAlso (y + 1 < Math.Sqrt(nbCase)) Then
            compteur += 1
        End If

        If bombeOuiNon(x + 1, y - 1) And (x + 1 < Math.Sqrt(nbCase)) AndAlso (y - 1 > 0) Then
            compteur += 1
        End If

        If bombeOuiNon(x - 1, y - 1) And (x - 1 > 0) AndAlso (y - 1 > 0) Then
            compteur += 1
        End If

        If bombeOuiNon(x, y + 1) And (y + 1 < Math.Sqrt(nbCase)) Then
            compteur += 1
        End If

        If bombeOuiNon(x, y - 1) And (y - 1 > 0) Then
            compteur += 1
        End If

        Return compteur
    End Function

    Public Function getNbCase() As Integer
        Return nbCase
    End Function

    Public Sub setNbCase(nb As Integer)
        nbCase = nb
    End Sub

    Public Sub setNbBombe(nb As Integer)
        nbBombe = nb
    End Sub


    Public Function partieGagner() As Boolean
        Dim partie As Boolean = True
        For i As Integer = 0 To nbCase - 1
            If tabCase(i).bouton.Enabled Then
                If tabCase(i).bombe = False Then
                    partie = False
                End If

            End If
        Next
        Return partie
    End Function

End Module
