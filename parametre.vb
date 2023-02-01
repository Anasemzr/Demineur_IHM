
Public Class parametre

    Private NiveauFacileCase As Integer = 36
    Private NiveauFacileBtn As Integer = 5

    Private NiveauIntermediareCase As Integer = 64
    Private NiveauIntermediareBtn As Integer = 10

    Private NiveauDifficileCase As Integer = 144
    Private NiveauDifficileBtn As Integer = 20


    Private Sub Quitter_Click(sender As Object, e As EventArgs) Handles Quitter.Click
        Dim resultat As MsgBoxResult = MsgBox("Etes vous sur de vouloir quitter ?", MsgBoxStyle.YesNo, "Confirmer votre choix")
        If resultat = MsgBoxResult.Yes Then
            Me.Close()
        End If
        Form1.Show()
    End Sub


    Private Sub TrackBar1_ValueChanged(sender As Object, e As EventArgs) Handles TrackBar1.ValueChanged
        Dim Newcolor As Color = Color.FromArgb(176 - TrackBar1.Value, 196 - TrackBar1.Value, 222 - TrackBar1.Value)

        Me.BackColor = Newcolor
        jeu.BackColor = Newcolor
        Form1.BackColor = Newcolor
        scores.BackColor = Newcolor


    End Sub

    Private Sub parametre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If BtnFacile.BackColor = Color.LightSteelBlue And BtnDifficile.BackColor = Color.LightSteelBlue And BtnIntermediare.BackColor = Color.LightSteelBlue Then
            BtnIntermediare.BackColor = Color.SteelBlue
        End If

        CheminTextBox.Text = getCheminSauvegarde()
    End Sub

    Private Sub BtnFacile_Click(sender As Object, e As EventArgs) Handles BtnFacile.Click
        mine.setNbCase(NiveauFacileCase)
        mine.setNbBombe(NiveauFacileBtn)

        restart()


        BtnFacile.BackColor = Color.SteelBlue
        BtnDifficile.BackColor = Color.LightSteelBlue
        BtnIntermediare.BackColor = Color.LightSteelBlue


    End Sub

    Private Sub BtnIntermediare_Click(sender As Object, e As EventArgs) Handles BtnIntermediare.Click
        mine.setNbCase(NiveauIntermediareCase)
        mine.setNbBombe(NiveauIntermediareBtn)

        restart()

        BtnIntermediare.BackColor = Color.SteelBlue
        BtnFacile.BackColor = Color.LightSteelBlue
        BtnDifficile.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub BtnDifficile_Click(sender As Object, e As EventArgs) Handles BtnDifficile.Click
        mine.setNbCase(NiveauDifficileCase)
        mine.setNbBombe(NiveauDifficileBtn)

        restart()

        BtnDifficile.BackColor = Color.SteelBlue
        BtnIntermediare.BackColor = Color.LightSteelBlue
        BtnFacile.BackColor = Color.LightSteelBlue
    End Sub

    Private Sub validerCheminSauvegarde_Click(sender As Object, e As EventArgs) Handles validerCheminSauvegarde.Click
        setCheminSauvegarde(CheminTextBox.Text)
    End Sub

    Private Sub BtnMusicAleatoire_Click(sender As Object, e As EventArgs) Handles BtnMusicAleatoire.Click
        Form1.setMode(True)
    End Sub

    Private Sub MusiqueBtn_Click(sender As Object, e As EventArgs) Handles MusiqueBtn.Click
        Form1.setMode(False)
    End Sub

    Private Sub LabelOnOff_Click(sender As Object, e As EventArgs) Handles LabelOnOff.Click
        If Form1.getOn() Then
            LabelOnOff.Text = "OFF"
            LabelOnOff.BackColor = Color.Red
            Form1.setOn(False)
        Else
            LabelOnOff.Text = "ON"
            LabelOnOff.BackColor = Color.Green
            Form1.setOn(True)
        End If
    End Sub
End Class