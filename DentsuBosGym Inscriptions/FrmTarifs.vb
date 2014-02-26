Imports WindowsApplication1.frmInscription

Public Class frmTarifs

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub

    Private Sub FrmTarifs_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Affichage des variables du programme dans des labels

        lblChestIndiv.Text = Convert.ToString(TARIF_CHEST_INDIV) + "$"
        lblBrasIndiv.Text = Convert.ToString(TARIF_BRAS_INDIV) + "$"
        lblDosIndiv.Text = Convert.ToString(TARIF_DOS_INDIV) + "$"
        lblChestFam.Text = Convert.ToString(TARIF_CHEST_FAM) + "$"
        lblBrasFam.Text = Convert.ToString(TARIF_BRAS_FAM) + "$"
        lblDosFam.Text = Convert.ToString(TARIF_DOS_FAM) + "$"
        lblRabais2ActIndiv.Text = Convert.ToString(FormatPercent(RAB_2_ACT_INDV))
        lblRabais3ActIndiv.Text = Convert.ToString(FormatPercent(RAB_3_ACT_INDV))
        lblRabais3ActFam.Text = Convert.ToString(FormatPercent(RAB_3_ACT_FAM))

        'Dans le cas où la variable RAB_2_ACT_FAM est égale à 0, le texte qui affiche dans le label pour cette variable est N/A

        If RAB_2_ACT_FAM = 0 Then
            lblRabais2ActFam.Text = "N/A"
        Else
            lblRabais2ActFam.Text = Convert.ToString(FormatPercent(RAB_2_ACT_FAM))
        End If

        lblRabais9MoisIndiv.Text = Convert.ToString(FormatPercent(RAB_9_MOIS_INDIV))
        lblRabais12MoisIndiv.Text = Convert.ToString(FormatPercent(RAB_12_MOIS_INDIV))
        lblRabais9MoisFam.Text = Convert.ToString(FormatPercent(RAB_9_MOIS_FAM))
        lblRabais12MoisFam.Text = Convert.ToString(FormatPercent(RAB_12_MOIS_FAM))
    End Sub
End Class