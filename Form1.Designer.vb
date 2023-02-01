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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Jouer = New System.Windows.Forms.Button()
        Me.Pseudo = New System.Windows.Forms.Label()
        Me.Quitter = New System.Windows.Forms.Button()
        Me.TitreJeu = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Score = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ComboBoxPseudo = New System.Windows.Forms.ComboBox()
        Me.parametrebtn = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Jouer
        '
        Me.Jouer.BackColor = System.Drawing.Color.White
        Me.Jouer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Jouer.Font = New System.Drawing.Font("MV Boli", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jouer.Location = New System.Drawing.Point(474, 315)
        Me.Jouer.Name = "Jouer"
        Me.Jouer.Size = New System.Drawing.Size(267, 87)
        Me.Jouer.TabIndex = 0
        Me.Jouer.Text = "JOUER"
        Me.Jouer.UseVisualStyleBackColor = False
        '
        'Pseudo
        '
        Me.Pseudo.AutoSize = True
        Me.Pseudo.Font = New System.Drawing.Font("MV Boli", 10.0!)
        Me.Pseudo.Location = New System.Drawing.Point(569, 230)
        Me.Pseudo.Name = "Pseudo"
        Me.Pseudo.Size = New System.Drawing.Size(63, 22)
        Me.Pseudo.TabIndex = 1
        Me.Pseudo.Text = "Pseudo"
        '
        'Quitter
        '
        Me.Quitter.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Quitter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Quitter.Font = New System.Drawing.Font("MV Boli", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quitter.Location = New System.Drawing.Point(1078, 12)
        Me.Quitter.Name = "Quitter"
        Me.Quitter.Size = New System.Drawing.Size(89, 36)
        Me.Quitter.TabIndex = 3
        Me.Quitter.Text = "QUITTER"
        Me.Quitter.UseVisualStyleBackColor = False
        '
        'TitreJeu
        '
        Me.TitreJeu.AutoSize = True
        Me.TitreJeu.Font = New System.Drawing.Font("jabjai", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitreJeu.Location = New System.Drawing.Point(483, 52)
        Me.TitreJeu.Name = "TitreJeu"
        Me.TitreJeu.Size = New System.Drawing.Size(258, 46)
        Me.TitreJeu.TabIndex = 4
        Me.TitreJeu.Text = "DEMINEUR"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 95)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(395, 330)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Score
        '
        Me.Score.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Score.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Score.Location = New System.Drawing.Point(383, 454)
        Me.Score.Name = "Score"
        Me.Score.Size = New System.Drawing.Size(452, 23)
        Me.Score.TabIndex = 6
        Me.Score.Text = "Scores"
        Me.Score.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(821, 95)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(322, 330)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'ComboBoxPseudo
        '
        Me.ComboBoxPseudo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBoxPseudo.FormattingEnabled = True
        Me.ComboBoxPseudo.Location = New System.Drawing.Point(474, 271)
        Me.ComboBoxPseudo.Name = "ComboBoxPseudo"
        Me.ComboBoxPseudo.Size = New System.Drawing.Size(267, 24)
        Me.ComboBoxPseudo.TabIndex = 8
        '
        'parametrebtn
        '
        Me.parametrebtn.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.parametrebtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.parametrebtn.Font = New System.Drawing.Font("MV Boli", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.parametrebtn.Location = New System.Drawing.Point(12, 12)
        Me.parametrebtn.Name = "parametrebtn"
        Me.parametrebtn.Size = New System.Drawing.Size(89, 36)
        Me.parametrebtn.TabIndex = 9
        Me.parametrebtn.Text = "Paramètre"
        Me.parametrebtn.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1179, 500)
        Me.Controls.Add(Me.parametrebtn)
        Me.Controls.Add(Me.ComboBoxPseudo)
        Me.Controls.Add(Me.Jouer)
        Me.Controls.Add(Me.Score)
        Me.Controls.Add(Me.TitreJeu)
        Me.Controls.Add(Me.Quitter)
        Me.Controls.Add(Me.Pseudo)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Jouer As Button
    Friend WithEvents Pseudo As Label
    Friend WithEvents Quitter As Button
    Friend WithEvents TitreJeu As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Score As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ComboBoxPseudo As ComboBox
    Friend WithEvents parametrebtn As Button
End Class
