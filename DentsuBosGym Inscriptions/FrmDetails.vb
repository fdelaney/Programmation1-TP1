Imports WindowsApplication1.frmInscription

Public Class frmDetails
    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        Me.Close()
    End Sub

    Private Sub FrmDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Constantes pour le texte à l'intérieur de la RichTextBox

        Const DETAIL_LIGNE_NOM As String = "Nom: "
        Const DETAIL_LIGNE_ABONNEMENT_TARIF As String = "Abonnement: Tarif "
        Const DETAIL_LIGNE_ACTIVITE As String = "Activité: "
        Const DETAIL_LIGNE_PLUSIEURS_ACTIVITES As String = "Activités: "
        Const DETAIL_LIGNE_DUREE As String = "Durée: "
        Const DETAIL_LIGNE_COUT_ACTIVITE As String = "Coût de l'activité: "
        Const DETAIL_LIGNE_RABAIS_ACTIVITE As String = "Rabais pour l'activité: "
        Const DETAIL_LIGNE_COUT_PLUSIEURS_ACTIVITES As String = "Coût des activités: "
        Const DETAIL_LIGNE_RABAIS_PLUSIEURS_ACTIVITES As String = "Rabais activités: "
        Const DETAIL_LIGNE_SOUS_TOTAL As String = "Sous total: "
        Const DETAIL_LIGNE_RAB_DUREE As String = "Rabais durée: "
        Const DETAIL_LIGNE_TOTAL_ABONNEMENT As String = "Total de l'abonnement: "
        Const DETAIL_LIGNE_TOTAL_INSCRIPTION As String = "Total de l'inscription: "

        'Variables de texte (TVQ et TPS doivent être définis comme étant des variables
        'et non pas des constantes puisque le string change au cours de l'execution du programme.)

        Dim textDetails As String
        Dim detailLigneTps As String = "TPS (" & FormatPercent(TAUX_TPS, 3) & "): "
        Dim detailLigneTvq As String = "TVQ (" & FormatPercent(TAUX_TVQ, 3) & "): "

        'Création de la variable String qui entre dans le frmDetail

        textDetails = DETAIL_LIGNE_NOM & nomClient & Environment.NewLine & DETAIL_LIGNE_ABONNEMENT_TARIF & typeAbonnement & Environment.NewLine

        'Dans le cas où il y a plus d'une activité, la condition ajuste en conséquence la sortie du texte.
        If nbTotalActivites = 1 Then
            textDetails += DETAIL_LIGNE_ACTIVITE & activitesChoisies & Environment.NewLine & DETAIL_LIGNE_DUREE & duree & " mois" & Environment.NewLine & DETAIL_LIGNE_COUT_ACTIVITE & FormatCurrency(montantActivites) & Environment.NewLine & DETAIL_LIGNE_RABAIS_ACTIVITE & FormatCurrency(montantRabaisActivites) & Environment.NewLine
        Else
            textDetails += DETAIL_LIGNE_PLUSIEURS_ACTIVITES & activitesChoisies & Environment.NewLine & DETAIL_LIGNE_DUREE & duree & " mois" & Environment.NewLine & DETAIL_LIGNE_COUT_PLUSIEURS_ACTIVITES & FormatCurrency(montantActivites) & Environment.NewLine & DETAIL_LIGNE_RABAIS_PLUSIEURS_ACTIVITES & FormatCurrency(montantRabaisActivites) & Environment.NewLine
        End If

        textDetails += DETAIL_LIGNE_SOUS_TOTAL & FormatCurrency(sousTotal) & Environment.NewLine & DETAIL_LIGNE_RAB_DUREE & FormatCurrency(montantRabaisduree) & Environment.NewLine & DETAIL_LIGNE_TOTAL_ABONNEMENT & FormatCurrency(totalAbonnement) & Environment.NewLine & Environment.NewLine & detailLigneTps & FormatCurrency(montantTps) & Environment.NewLine & detailLigneTvq & FormatCurrency(montantTvq) & Environment.NewLine & DETAIL_LIGNE_TOTAL_INSCRIPTION & FormatCurrency(montantTotal)

        'Afficher la variable dans un RichTextBox

        rtfFacture.Text = textDetails



    End Sub
End Class