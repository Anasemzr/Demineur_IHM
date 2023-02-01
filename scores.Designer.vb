<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class scores
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
        Me.Quitter = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Score = New System.Windows.Forms.Label()
        Me.minute = New System.Windows.Forms.Label()
        Me.point = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxScore = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Quitter
        '
        Me.Quitter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Quitter.Location = New System.Drawing.Point(577, 415)
        Me.Quitter.Name = "Quitter"
        Me.Quitter.Size = New System.Drawing.Size(211, 23)
        Me.Quitter.TabIndex = 1
        Me.Quitter.Text = "Revenir au menu principal"
        Me.Quitter.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListBox1.Font = New System.Drawing.Font("MV Boli", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 44
        Me.ListBox1.Location = New System.Drawing.Point(35, 126)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(142, 264)
        Me.ListBox1.TabIndex = 2
        '
        'Score
        '
        Me.Score.AutoSize = True
        Me.Score.Font = New System.Drawing.Font("MV Boli", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score.Location = New System.Drawing.Point(374, 30)
        Me.Score.Name = "Score"
        Me.Score.Size = New System.Drawing.Size(210, 79)
        Me.Score.TabIndex = 3
        Me.Score.Text = "Scores"
        '
        'minute
        '
        Me.minute.AutoSize = True
        Me.minute.Font = New System.Drawing.Font("MV Boli", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minute.Location = New System.Drawing.Point(293, 244)
        Me.minute.Name = "minute"
        Me.minute.Size = New System.Drawing.Size(0, 37)
        Me.minute.TabIndex = 4
        '
        'point
        '
        Me.point.AutoSize = True
        Me.point.Font = New System.Drawing.Font("MV Boli", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.point.Location = New System.Drawing.Point(635, 244)
        Me.point.Name = "point"
        Me.point.Size = New System.Drawing.Size(0, 37)
        Me.point.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MV Boli", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(279, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Temps"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(622, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Points"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 26)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Click sur ton pseudo :"
        '
        'ComboBoxScore
        '
        Me.ComboBoxScore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBoxScore.FormattingEnabled = True
        Me.ComboBoxScore.Location = New System.Drawing.Point(35, 414)
        Me.ComboBoxScore.Name = "ComboBoxScore"
        Me.ComboBoxScore.Size = New System.Drawing.Size(142, 24)
        Me.ComboBoxScore.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(193, 415)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Voir plus"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(81, 97)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(37, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "<>"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'scores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBoxScore)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.point)
        Me.Controls.Add(Me.minute)
        Me.Controls.Add(Me.Score)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Quitter)
        Me.Name = "scores"
        Me.Text = "scores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Quitter As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Score As Label
    Friend WithEvents minute As Label
    Friend WithEvents point As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBoxScore As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
