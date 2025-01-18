<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Département = New System.Windows.Forms.ComboBox()
        Me.filière = New System.Windows.Forms.ComboBox()
        Me.matricule = New System.Windows.Forms.TextBox()
        Me.nom = New System.Windows.Forms.TextBox()
        Me.prenom = New System.Windows.Forms.TextBox()
        Me.lieu = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.sexe = New System.Windows.Forms.ComboBox()
        Me.mail = New System.Windows.Forms.TextBox()
        Me.btnParcourir = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Nouveau = New System.Windows.Forms.Button()
        Me.Valider = New System.Windows.Forms.Button()
        Me.Quitter = New System.Windows.Forms.Button()
        Me.niveau = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(778, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Gestion des inscriptions - Prise en compte des étudiants"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(27, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Niveau"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(27, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Filière"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(27, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Matricule"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(27, 281)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 25)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nom"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(27, 339)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Prénom"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(27, 404)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 25)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Lieu de naissance"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(23, 455)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(174, 25)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Date de naissance"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(27, 513)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 25)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "E-mail"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(499, 117)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 25)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Département"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(286, 221)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(0, 28)
        Me.ComboBox2.TabIndex = 11
        '
        'Département
        '
        Me.Département.FormattingEnabled = True
        Me.Département.Location = New System.Drawing.Point(630, 115)
        Me.Département.Name = "Département"
        Me.Département.Size = New System.Drawing.Size(196, 28)
        Me.Département.TabIndex = 12
        Me.Département.Text = "Mathématique"
        '
        'filière
        '
        Me.filière.FormattingEnabled = True
        Me.filière.Location = New System.Drawing.Point(286, 171)
        Me.filière.Name = "filière"
        Me.filière.Size = New System.Drawing.Size(540, 28)
        Me.filière.TabIndex = 13
        '
        'matricule
        '
        Me.matricule.Location = New System.Drawing.Point(286, 221)
        Me.matricule.Name = "matricule"
        Me.matricule.Size = New System.Drawing.Size(540, 26)
        Me.matricule.TabIndex = 14
        '
        'nom
        '
        Me.nom.Location = New System.Drawing.Point(286, 280)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(540, 26)
        Me.nom.TabIndex = 15
        Me.nom.Text = "Obligatoire"
        '
        'prenom
        '
        Me.prenom.Location = New System.Drawing.Point(286, 340)
        Me.prenom.Name = "prenom"
        Me.prenom.Size = New System.Drawing.Size(540, 26)
        Me.prenom.TabIndex = 16
        Me.prenom.Text = "Obligatoire"
        '
        'lieu
        '
        Me.lieu.Location = New System.Drawing.Point(286, 404)
        Me.lieu.Name = "lieu"
        Me.lieu.Size = New System.Drawing.Size(540, 26)
        Me.lieu.TabIndex = 17
        Me.lieu.Text = "Obligatoire"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(286, 451)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(327, 26)
        Me.DateTimePicker1.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(664, 451)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 25)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Sexe"
        '
        'sexe
        '
        Me.sexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sexe.FormattingEnabled = True
        Me.sexe.Location = New System.Drawing.Point(765, 448)
        Me.sexe.Name = "sexe"
        Me.sexe.Size = New System.Drawing.Size(61, 28)
        Me.sexe.TabIndex = 21
        '
        'mail
        '
        Me.mail.Location = New System.Drawing.Point(286, 512)
        Me.mail.Name = "mail"
        Me.mail.Size = New System.Drawing.Size(540, 26)
        Me.mail.TabIndex = 22
        Me.mail.Text = "Obligatoire"
        '
        'btnParcourir
        '
        Me.btnParcourir.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnParcourir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnParcourir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnParcourir.Location = New System.Drawing.Point(846, 362)
        Me.btnParcourir.Name = "btnParcourir"
        Me.btnParcourir.Size = New System.Drawing.Size(115, 37)
        Me.btnParcourir.TabIndex = 23
        Me.btnParcourir.Text = "...Parcourir"
        Me.btnParcourir.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(832, 114)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(122, 204)
        Me.ListBox1.TabIndex = 24
        '
        'Nouveau
        '
        Me.Nouveau.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Nouveau.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Nouveau.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Nouveau.Location = New System.Drawing.Point(964, 114)
        Me.Nouveau.Name = "Nouveau"
        Me.Nouveau.Size = New System.Drawing.Size(117, 36)
        Me.Nouveau.TabIndex = 25
        Me.Nouveau.Text = "+ Nouveau"
        Me.Nouveau.UseVisualStyleBackColor = False
        '
        'Valider
        '
        Me.Valider.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Valider.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Valider.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Valider.Location = New System.Drawing.Point(964, 171)
        Me.Valider.Name = "Valider"
        Me.Valider.Size = New System.Drawing.Size(117, 39)
        Me.Valider.TabIndex = 26
        Me.Valider.Text = "Valider"
        Me.Valider.UseVisualStyleBackColor = False
        '
        'Quitter
        '
        Me.Quitter.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Quitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Quitter.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Quitter.Location = New System.Drawing.Point(965, 239)
        Me.Quitter.Name = "Quitter"
        Me.Quitter.Size = New System.Drawing.Size(117, 37)
        Me.Quitter.TabIndex = 27
        Me.Quitter.Text = "X Quitter"
        Me.Quitter.UseVisualStyleBackColor = False
        '
        'niveau
        '
        Me.niveau.FormattingEnabled = True
        Me.niveau.Location = New System.Drawing.Point(286, 114)
        Me.niveau.Name = "niveau"
        Me.niveau.Size = New System.Drawing.Size(207, 28)
        Me.niveau.TabIndex = 28
        Me.niveau.Text = "Sélectionnez le niveau"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 612)
        Me.Controls.Add(Me.niveau)
        Me.Controls.Add(Me.Quitter)
        Me.Controls.Add(Me.Valider)
        Me.Controls.Add(Me.Nouveau)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnParcourir)
        Me.Controls.Add(Me.mail)
        Me.Controls.Add(Me.sexe)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lieu)
        Me.Controls.Add(Me.prenom)
        Me.Controls.Add(Me.nom)
        Me.Controls.Add(Me.matricule)
        Me.Controls.Add(Me.filière)
        Me.Controls.Add(Me.Département)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Département As System.Windows.Forms.ComboBox
    Friend WithEvents filière As System.Windows.Forms.ComboBox
    Friend WithEvents matricule As System.Windows.Forms.TextBox
    Friend WithEvents nom As System.Windows.Forms.TextBox
    Friend WithEvents prenom As System.Windows.Forms.TextBox
    Friend WithEvents lieu As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents sexe As System.Windows.Forms.ComboBox
    Friend WithEvents mail As System.Windows.Forms.TextBox
    Friend WithEvents btnParcourir As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Nouveau As System.Windows.Forms.Button
    Friend WithEvents Valider As System.Windows.Forms.Button
    Friend WithEvents Quitter As System.Windows.Forms.Button
    Friend WithEvents niveau As System.Windows.Forms.ComboBox

End Class
