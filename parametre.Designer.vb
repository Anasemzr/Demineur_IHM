<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class parametre
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Score = New System.Windows.Forms.Label()
        Me.Quitter = New System.Windows.Forms.Button()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnFacile = New System.Windows.Forms.Button()
        Me.BtnIntermediare = New System.Windows.Forms.Button()
        Me.BtnDifficile = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.validerCheminSauvegarde = New System.Windows.Forms.Button()
        Me.CheminTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnMusicAleatoire = New System.Windows.Forms.Button()
        Me.ComboboxMusic = New System.Windows.Forms.ComboBox()
        Me.MusiqueBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelOnOff = New System.Windows.Forms.Label()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Score
        '
        Me.Score.AutoSize = True
        Me.Score.Font = New System.Drawing.Font("MV Boli", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score.Location = New System.Drawing.Point(256, 9)
        Me.Score.Name = "Score"
        Me.Score.Size = New System.Drawing.Size(330, 79)
        Me.Score.TabIndex = 4
        Me.Score.Text = "Paramètre"
        '
        'Quitter
        '
        Me.Quitter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Quitter.Location = New System.Drawing.Point(602, 511)
        Me.Quitter.Name = "Quitter"
        Me.Quitter.Size = New System.Drawing.Size(208, 23)
        Me.Quitter.TabIndex = 5
        Me.Quitter.Text = "Revenir au menu principal"
        Me.Quitter.UseVisualStyleBackColor = True
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(229, 120)
        Me.TrackBar1.Maximum = 30
        Me.TrackBar1.Minimum = -30
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(559, 56)
        Me.TrackBar1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 44)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Luminosité"
        '
        'BtnFacile
        '
        Me.BtnFacile.Location = New System.Drawing.Point(147, 233)
        Me.BtnFacile.Name = "BtnFacile"
        Me.BtnFacile.Size = New System.Drawing.Size(97, 29)
        Me.BtnFacile.TabIndex = 8
        Me.BtnFacile.Text = "Facile"
        Me.BtnFacile.UseVisualStyleBackColor = True
        '
        'BtnIntermediare
        '
        Me.BtnIntermediare.Location = New System.Drawing.Point(377, 233)
        Me.BtnIntermediare.Name = "BtnIntermediare"
        Me.BtnIntermediare.Size = New System.Drawing.Size(109, 29)
        Me.BtnIntermediare.TabIndex = 9
        Me.BtnIntermediare.Text = "Intermédiaire"
        Me.BtnIntermediare.UseVisualStyleBackColor = True
        '
        'BtnDifficile
        '
        Me.BtnDifficile.Location = New System.Drawing.Point(621, 233)
        Me.BtnDifficile.Name = "BtnDifficile"
        Me.BtnDifficile.Size = New System.Drawing.Size(95, 29)
        Me.BtnDifficile.TabIndex = 10
        Me.BtnDifficile.Text = "Difficile"
        Me.BtnDifficile.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(354, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 29)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Difficulté"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MV Boli", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(354, 300)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 29)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Sauvegarde"
        '
        'validerCheminSauvegarde
        '
        Me.validerCheminSauvegarde.Location = New System.Drawing.Point(491, 338)
        Me.validerCheminSauvegarde.Name = "validerCheminSauvegarde"
        Me.validerCheminSauvegarde.Size = New System.Drawing.Size(95, 25)
        Me.validerCheminSauvegarde.TabIndex = 13
        Me.validerCheminSauvegarde.Text = "Valider"
        Me.validerCheminSauvegarde.UseVisualStyleBackColor = True
        '
        'CheminTextBox
        '
        Me.CheminTextBox.Location = New System.Drawing.Point(229, 341)
        Me.CheminTextBox.Name = "CheminTextBox"
        Me.CheminTextBox.Size = New System.Drawing.Size(223, 22)
        Me.CheminTextBox.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MV Boli", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(354, 426)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 29)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Musique"
        '
        'BtnMusicAleatoire
        '
        Me.BtnMusicAleatoire.Location = New System.Drawing.Point(270, 469)
        Me.BtnMusicAleatoire.Name = "BtnMusicAleatoire"
        Me.BtnMusicAleatoire.Size = New System.Drawing.Size(93, 34)
        Me.BtnMusicAleatoire.TabIndex = 16
        Me.BtnMusicAleatoire.Text = "Aléatoire"
        Me.BtnMusicAleatoire.UseVisualStyleBackColor = True
        '
        'ComboboxMusic
        '
        Me.ComboboxMusic.FormattingEnabled = True
        Me.ComboboxMusic.Location = New System.Drawing.Point(441, 469)
        Me.ComboboxMusic.Name = "ComboboxMusic"
        Me.ComboboxMusic.Size = New System.Drawing.Size(121, 24)
        Me.ComboboxMusic.TabIndex = 17
        '
        'MusiqueBtn
        '
        Me.MusiqueBtn.Location = New System.Drawing.Point(457, 499)
        Me.MusiqueBtn.Name = "MusiqueBtn"
        Me.MusiqueBtn.Size = New System.Drawing.Size(95, 25)
        Me.MusiqueBtn.TabIndex = 18
        Me.MusiqueBtn.Text = "Valider"
        Me.MusiqueBtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(241, 541)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 25)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Valider"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelOnOff
        '
        Me.LabelOnOff.AutoSize = True
        Me.LabelOnOff.BackColor = System.Drawing.Color.Green
        Me.LabelOnOff.Font = New System.Drawing.Font("MV Boli", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelOnOff.Location = New System.Drawing.Point(138, 468)
        Me.LabelOnOff.Name = "LabelOnOff"
        Me.LabelOnOff.Size = New System.Drawing.Size(49, 29)
        Me.LabelOnOff.TabIndex = 19
        Me.LabelOnOff.Text = "ON"
        '
        'parametre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(800, 532)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabelOnOff)
        Me.Controls.Add(Me.MusiqueBtn)
        Me.Controls.Add(Me.ComboboxMusic)
        Me.Controls.Add(Me.BtnMusicAleatoire)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CheminTextBox)
        Me.Controls.Add(Me.validerCheminSauvegarde)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnDifficile)
        Me.Controls.Add(Me.BtnIntermediare)
        Me.Controls.Add(Me.BtnFacile)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.Quitter)
        Me.Controls.Add(Me.Score)
        Me.Name = "parametre"
        Me.Text = "parametre"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Score As Label
    Friend WithEvents Quitter As Button
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnFacile As Button
    Friend WithEvents BtnIntermediare As Button
    Friend WithEvents BtnDifficile As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents validerCheminSauvegarde As Button
    Friend WithEvents CheminTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnMusicAleatoire As Button
    Friend WithEvents ComboboxMusic As ComboBox
    Friend WithEvents MusiqueBtn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents LabelOnOff As Label
End Class
