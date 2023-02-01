<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class jeu
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.QUITTER = New System.Windows.Forms.Button()
        Me.TitreJeu = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 16)
        Me.Label1.TabIndex = 0
        '
        'QUITTER
        '
        Me.QUITTER.Cursor = System.Windows.Forms.Cursors.Hand
        Me.QUITTER.Location = New System.Drawing.Point(758, 30)
        Me.QUITTER.Name = "QUITTER"
        Me.QUITTER.Size = New System.Drawing.Size(139, 42)
        Me.QUITTER.TabIndex = 1
        Me.QUITTER.Text = "Abandonner"
        Me.QUITTER.UseVisualStyleBackColor = True
        '
        'TitreJeu
        '
        Me.TitreJeu.AutoSize = True
        Me.TitreJeu.Font = New System.Drawing.Font("jabjai", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitreJeu.Location = New System.Drawing.Point(329, 2)
        Me.TitreJeu.Name = "TitreJeu"
        Me.TitreJeu.Size = New System.Drawing.Size(258, 46)
        Me.TitreJeu.TabIndex = 5
        Me.TitreJeu.Text = "DEMINEUR"
        '
        'Timer1
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 26)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MV Boli", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 44)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Label3"
        '
        'jeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(922, 570)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TitreJeu)
        Me.Controls.Add(Me.QUITTER)
        Me.Controls.Add(Me.Label1)
        Me.Name = "jeu"
        Me.Text = "w"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents QUITTER As Button
    Friend WithEvents TitreJeu As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
