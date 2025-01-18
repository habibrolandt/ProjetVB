Public Class Form1
    Dim etudiants As New List(Of String)

    ' Cette fonction est exécutée lorsque le formulaire est chargé
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ajouter les options à la ComboBox
        sexe.Items.Add("Homme")
        sexe.Items.Add("Femme")
        ' Ajouter les options de niveau d'étude à la ComboBox
        Niveau.Items.Add("Licence 1")
        Niveau.Items.Add("Licence 2")
        Niveau.Items.Add("Licence 3")
        Niveau.Items.Add("Master 1")
        Niveau.Items.Add("Master 2")
        ' Ajouter les options de département à la ComboBox
        Département.Items.Add("Mathématique")
        Département.Items.Add("Physique")
        Département.Items.Add("Informatique")
        Département.Items.Add("Bioscience")
        ' Ajouter les options de filière à la ComboBox
        filière.Items.Add("SRIT")
        filière.Items.Add("SIGL")
        filière.Items.Add("RTEL")
        filière.Items.Add("INFO")
        filière.Items.Add("SITW")
        filière.Items.Add("BIHAR")

        ' Initialisation des champs avec la valeur "obligatoire"
        nom.Text = "obligatoire"
        prenom.Text = "obligatoire"
        lieu.Text = "obligatoire"
        mail.Text = "obligatoire"
    End Sub

    ' Fonction pour vérifier si un champ est obligatoire
    Private Function EstObligatoire(champ As String) As Boolean
        Return String.IsNullOrWhiteSpace(champ) OrElse champ = "obligatoire"
    End Function

    ' Fonction exécutée lors de l'événement Click du bouton "Valider"
    Private Sub Valider_Click(sender As Object, e As EventArgs) Handles Valider.Click
        ' Vérification des champs obligatoires
        If EstObligatoire(nom.Text) Then
            MessageBox.Show("Le nom est obligatoire.")
        ElseIf EstObligatoire(prenom.Text) Then
            MessageBox.Show("Le prénom est obligatoire.")
        ElseIf EstObligatoire(lieu.Text) Then
            MessageBox.Show("Le lieu de naissance est obligatoire.")
        ElseIf EstObligatoire(mail.Text) Then
            MessageBox.Show("L'email est obligatoire.")
        ElseIf DateTimePicker1.Value > Date.Now Then
            MessageBox.Show("La date de naissance ne peut pas être dans le futur.")
        ElseIf Not IsValidEmail(mail.Text) Then
            MessageBox.Show("L'email n'est pas valide.")
        Else
            ' Créer la chaîne d'informations
            Dim informations As String = "Nom: " & nom.Text & vbCrLf & _
                                         "Prénom: " & prenom.Text & vbCrLf & _
                                         "Lieu de naissance: " & lieu.Text & vbCrLf & _
                                         "Email: " & mail.Text & vbCrLf & _
                                         "Date de naissance: " & DateTimePicker1.Value.ToString("dd/MM/yyyy") & vbCrLf & _
                                         "Niveau: " & Niveau.SelectedItem.ToString() & vbCrLf & _
                                         "Département: " & Département.SelectedItem.ToString() & vbCrLf & _
                                         "Filière: " & filière.SelectedItem.ToString()

            ' Vérifier si l'étudiant existe déjà
            If etudiants.Contains(informations) Then
                MessageBox.Show("Cet étudiant est déjà enregistré.")
            Else
                ' Ajouter les informations dans la liste
                etudiants.Add(informations)

                ' Ajouter les informations dans ListBox1
                ListBox1.Items.Add(informations)

                ' Afficher un message de confirmation
                MessageBox.Show("Les informations ont été enregistrées avec succès!")

                ' Optionnel : Réinitialiser les champs après l'enregistrement
                nom.Clear()
                prenom.Clear()
                lieu.Clear()
                mail.Clear()
                DateTimePicker1.Value = Date.Now
                Niveau.SelectedIndex = -1
                Département.SelectedIndex = -1
                filière.SelectedIndex = -1
            End If
        End If
    End Sub

    ' Fonction pour valider le format de l'email
    Private Function IsValidEmail(email As String) As Boolean
        Try
            ' Utilisation d'une expression régulière pour valider le format de l'email
            Dim emailRegex As New System.Text.RegularExpressions.Regex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")
            Return emailRegex.IsMatch(email)
        Catch ex As Exception
            Return False
        End Try
    End Function

    ' Fonction exécutée lors de l'événement TextChanged du champ nom
    Private Sub nom_TextChanged(sender As Object, e As EventArgs) Handles nom.TextChanged
        If nom.Text <> "obligatoire" Then
            nom.ForeColor = Color.Black  ' Change la couleur pour indiquer que le champ est renseigné
        End If
    End Sub

    ' Suppression des alertes sur le TextChanged des autres champs
    Private Sub prenom_TextChanged(sender As Object, e As EventArgs) Handles prenom.TextChanged
        If prenom.Text <> "obligatoire" Then
            prenom.ForeColor = Color.Black
        End If
    End Sub

    Private Sub lieu_TextChanged(sender As Object, e As EventArgs) Handles lieu.TextChanged
        If lieu.Text <> "obligatoire" Then
            lieu.ForeColor = Color.Black
        End If
    End Sub

    Private Sub mail_TextChanged(sender As Object, e As EventArgs) Handles mail.TextChanged
        If mail.Text <> "obligatoire" Then
            mail.ForeColor = Color.Black
        End If
    End Sub

    ' Fonction exécutée lors de la sélection dans ListBox1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex >= 0 Then
            Dim selectedStudent As String = ListBox1.SelectedItem.ToString()
            MessageBox.Show("Vous avez sélectionné : " & vbCrLf & selectedStudent)
        End If
    End Sub

    ' Fonction de réinitialisation des champs
    Private Sub Nouveau_Click(sender As Object, e As EventArgs) Handles Nouveau.Click
        nom.Clear()
        prenom.Clear()
        lieu.Clear()
        mail.Clear()
        DateTimePicker1.Value = Date.Now
        Niveau.SelectedIndex = -1
        Département.SelectedIndex = -1
        filière.SelectedIndex = -1
        MessageBox.Show("Vous pouvez maintenant entrer de nouvelles informations.")
    End Sub

    ' Fermer le formulaire
    Private Sub Quitter_Click(sender As Object, e As EventArgs) Handles Quitter.Click
        Me.Close()
    End Sub
End Class
