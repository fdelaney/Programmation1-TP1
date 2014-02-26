Imports WindowsApplication1.VariableModule
Imports System.Text.RegularExpressions
Public Class frmInscription

    Public varDict As New Dictionary(Of String, Single)

    Private Sub btnTarifs_Click(sender As Object, e As EventArgs) Handles btnTarifs.Click

        frmTarifs.ShowDialog()

    End Sub

    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles BtnQuitter.Click

        Me.Close()

    End Sub

    Private Sub frmInscription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmTitre.ShowDialog()
        btnDetails.Enabled = False

        'Fonction Regex qui permet d'aller chercher dans un fichier texte les valeurs pour les varibles/constantes

        Dim cacheText As String
        cacheText = My.Computer.FileSystem.ReadAllText("../../tarification.txt")

        Dim VarPattern As String = "([A-Z0-9_]+) = ([0-9]+([,][0-9]+)?)"
        For Each m As Match In Regex.Matches(cacheText, VarPattern)

            'Si la requête se déroule bien, les valeurs sont ajoutées au dictionnaire Variable

            If (m.Success) Then
                Dim varKey As String = m.Groups(1).Value
                Dim varValue As Single = Convert.ToSingle(m.Groups(2).Value)
                varDict.Add(varKey, varValue)
            End If

        Next

        'Déclaration des variables à partir des valeurs du fichier texte

        TAUX_TPS = varDict.Item("TAUX_TPS")
        TAUX_TVQ = varDict.Item("TAUX_TVQ")

        RAB_9_MOIS_INDIV = varDict.Item("RAB_9_MOIS_INDIV")
        RAB_12_MOIS_INDIV = varDict.Item("RAB_12_MOIS_INDIV")
        RAB_9_MOIS_FAM = varDict.Item("RAB_9_MOIS_FAM")
        RAB_12_MOIS_FAM = varDict.Item("RAB_12_MOIS_FAM")

        RAB_2_ACT_INDV = varDict.Item("RAB_2_ACT_INDV")
        RAB_3_ACT_INDV = varDict.Item("RAB_3_ACT_INDV")
        RAB_3_ACT_FAM = varDict.Item("RAB_3_ACT_FAM")
        RAB_2_ACT_FAM = varDict.Item("RAB_2_ACT_FAM")

        TARIF_CHEST_INDIV = varDict.Item("TARIF_CHEST_INDIV")
        TARIF_BRAS_INDIV = varDict.Item("TARIF_BRAS_INDIV")
        TARIF_DOS_INDIV = varDict.Item("TARIF_DOS_INDIV")

        TARIF_CHEST_FAM = varDict.Item("TARIF_CHEST_FAM")
        TARIF_BRAS_FAM = varDict.Item("TARIF_BRAS_FAM")
        TARIF_DOS_FAM = varDict.Item("TARIF_DOS_FAM")
    End Sub

    Private Sub btnCalculer_Click(sender As Object, e As EventArgs) Handles btnCalculer.Click

        'Initialiser ou réinitialiser les varibles avec la valeur 0

        montantActivites = 0
        nbTotalActivites = 0
        montantRabaisActivites = 0
        montantRabaisduree = 0
        activitesChoisies = ""

        Const MESSAGE_TITRE_ERREUR As String = "Erreur"
        Const MESSAGE_AUCUN_NOM As String = "Vous devez entrer votre nom."
        Const MESSAGE_NOM_INVALIDE As String = "Le nom entré doit être valide."
        Const MESSAGE_PAS_ACTIVITÉ As String = "Vous devez sélectionner au moins une activité."
        Dim formulaireValide As Boolean
        nomClient = txtNomClient.Text

        'Entrées

        If txtNomClient.Text = "" Then
            MessageBox.Show(MESSAGE_AUCUN_NOM, MESSAGE_TITRE_ERREUR, MessageBoxButtons.OK, MessageBoxIcon.Error)
            formulaireValide = False
        ElseIf IsNumeric(txtNomClient.Text) Then
            MessageBox.Show(MESSAGE_NOM_INVALIDE, MESSAGE_TITRE_ERREUR, MessageBoxButtons.OK, MessageBoxIcon.Error)
            formulaireValide = False
        ElseIf Not chkChest.Checked And Not chkBras.Checked And Not chkDos.Checked Then
            MessageBox.Show(MESSAGE_PAS_ACTIVITÉ, MESSAGE_TITRE_ERREUR, MessageBoxButtons.OK, MessageBoxIcon.Error)
            formulaireValide = False
        Else
            formulaireValide = True
        End If

        'Traitements

        If formulaireValide Then
            If optIndividuel.Checked Then
                typeAbonnement = "Individuel"
                tarifChest = TARIF_CHEST_INDIV
                tarifBras = TARIF_BRAS_INDIV
                tarifDos = TARIF_DOS_INDIV
                rabais2Acti = RAB_2_ACT_INDV
                rabais3Acti = RAB_3_ACT_INDV
                rabais9Mois = RAB_9_MOIS_INDIV
                rabais12Mois = RAB_12_MOIS_INDIV
            Else
                typeAbonnement = "Familial"
                tarifChest = TARIF_CHEST_FAM
                tarifBras = TARIF_BRAS_FAM
                tarifDos = TARIF_DOS_FAM
                rabais2Acti = RAB_2_ACT_FAM
                rabais3Acti = RAB_3_ACT_FAM
                rabais9Mois = RAB_9_MOIS_FAM
                rabais12Mois = RAB_12_MOIS_FAM
            End If

            If opt3Mois.Checked Then
                duree = 3
            ElseIf opt6Mois.Checked Then
                duree = 6
            ElseIf opt9Mois.Checked Then
                duree = 9
            Else
                duree = 12
            End If

            If chkChest.Checked Then
                montantActivites += ((tarifChest * duree) / 3)
                nbTotalActivites = nbTotalActivites + 1
                activitesChoisies += " Chest"
            End If

            If chkBras.Checked Then
                montantActivites += ((tarifBras * duree) / 3)
                nbTotalActivites = nbTotalActivites + 1
                activitesChoisies += " Bras"
            End If

            If chkDos.Checked Then
                montantActivites += ((tarifDos * duree) / 3)
                nbTotalActivites = nbTotalActivites + 1
                activitesChoisies += " Dos"
            End If

            If nbTotalActivites = 2 Then
                montantRabaisActivites = montantActivites * rabais2Acti
            ElseIf nbTotalActivites = 3 Then
                montantRabaisActivites = montantActivites * rabais3Acti
            End If

            If duree = 9 Then
                montantRabaisduree = (montantActivites - montantRabaisActivites) * rabais9Mois
            End If

            If duree = 12 Then
                montantRabaisduree = (montantActivites - montantRabaisActivites) * rabais12Mois
            End If

            sousTotal = montantActivites - montantRabaisActivites
            totalAbonnement = montantActivites - montantRabaisActivites - montantRabaisduree
            montantTps = totalAbonnement * TAUX_TPS
            montantTvq = totalAbonnement * TAUX_TVQ
            montantTotal = totalAbonnement + montantTps + montantTvq

            btnDetails.Enabled = True

            'Sorties

            lblTotal.Text = FormatCurrency(CStr(montantTotal))
        Else
            btnDetails.Enabled = False
        End If

    End Sub

    Private Sub btnDetails_Click(sender As Object, e As EventArgs) Handles btnDetails.Click
        frmDetails.ShowDialog()
    End Sub

    Private Sub BtnAnnuler_Click(sender As Object, e As EventArgs) Handles BtnAnnuler.Click

        'Le bouton Annuler restaure les paramètres par défaut du programme

        txtNomClient.Text = ""
        opt3Mois.Checked = True
        optIndividuel.Checked = True
        chkChest.Checked = False
        chkBras.Checked = False
        chkDos.Checked = False
        lblTotal.Text = ""
        btnDetails.Enabled = False

    End Sub

End Class
