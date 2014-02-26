<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInscription
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInscription))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblNomClient = New System.Windows.Forms.Label()
        Me.txtNomClient = New System.Windows.Forms.TextBox()
        Me.grbAbonnement = New System.Windows.Forms.GroupBox()
        Me.optFamilial = New System.Windows.Forms.RadioButton()
        Me.optIndividuel = New System.Windows.Forms.RadioButton()
        Me.grbDurée = New System.Windows.Forms.GroupBox()
        Me.opt12Mois = New System.Windows.Forms.RadioButton()
        Me.opt9Mois = New System.Windows.Forms.RadioButton()
        Me.opt6Mois = New System.Windows.Forms.RadioButton()
        Me.opt3Mois = New System.Windows.Forms.RadioButton()
        Me.grbActivites = New System.Windows.Forms.GroupBox()
        Me.chkDos = New System.Windows.Forms.CheckBox()
        Me.chkBras = New System.Windows.Forms.CheckBox()
        Me.chkChest = New System.Windows.Forms.CheckBox()
        Me.grbTarification = New System.Windows.Forms.GroupBox()
        Me.btnTarifs = New System.Windows.Forms.Button()
        Me.btnDetails = New System.Windows.Forms.Button()
        Me.lblPrixTotal = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCalculer = New System.Windows.Forms.Button()
        Me.BtnAnnuler = New System.Windows.Forms.Button()
        Me.BtnQuitter = New System.Windows.Forms.Button()
        Me.tipInscription = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblInscriptionDentsu = New System.Windows.Forms.Label()
        Me.lblTritreEntrainement = New System.Windows.Forms.Label()
        Me.lblInscriptions = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbAbonnement.SuspendLayout()
        Me.grbDurée.SuspendLayout()
        Me.grbActivites.SuspendLayout()
        Me.grbTarification.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.ImageCoin
        Me.PictureBox1.Location = New System.Drawing.Point(356, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(89, 88)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lblNomClient
        '
        Me.lblNomClient.AutoSize = True
        Me.lblNomClient.Location = New System.Drawing.Point(32, 115)
        Me.lblNomClient.Name = "lblNomClient"
        Me.lblNomClient.Size = New System.Drawing.Size(76, 13)
        Me.lblNomClient.TabIndex = 3
        Me.lblNomClient.Text = "Nom du Client:"
        '
        'txtNomClient
        '
        Me.txtNomClient.Location = New System.Drawing.Point(114, 112)
        Me.txtNomClient.Name = "txtNomClient"
        Me.txtNomClient.Size = New System.Drawing.Size(228, 20)
        Me.txtNomClient.TabIndex = 0
        Me.tipInscription.SetToolTip(Me.txtNomClient, "Veuillez entrer votre nom.")
        '
        'grbAbonnement
        '
        Me.grbAbonnement.Controls.Add(Me.optFamilial)
        Me.grbAbonnement.Controls.Add(Me.optIndividuel)
        Me.grbAbonnement.Location = New System.Drawing.Point(42, 153)
        Me.grbAbonnement.Name = "grbAbonnement"
        Me.grbAbonnement.Size = New System.Drawing.Size(118, 132)
        Me.grbAbonnement.TabIndex = 5
        Me.grbAbonnement.TabStop = False
        Me.grbAbonnement.Text = "Abonnement"
        Me.tipInscription.SetToolTip(Me.grbAbonnement, "Sélectionnez votre type d'abonnement.")
        '
        'optFamilial
        '
        Me.optFamilial.AutoSize = True
        Me.optFamilial.Location = New System.Drawing.Point(10, 54)
        Me.optFamilial.Name = "optFamilial"
        Me.optFamilial.Size = New System.Drawing.Size(59, 17)
        Me.optFamilial.TabIndex = 2
        Me.optFamilial.Text = "Familial"
        Me.optFamilial.UseVisualStyleBackColor = True
        '
        'optIndividuel
        '
        Me.optIndividuel.AutoSize = True
        Me.optIndividuel.Checked = True
        Me.optIndividuel.Location = New System.Drawing.Point(10, 20)
        Me.optIndividuel.Name = "optIndividuel"
        Me.optIndividuel.Size = New System.Drawing.Size(70, 17)
        Me.optIndividuel.TabIndex = 1
        Me.optIndividuel.TabStop = True
        Me.optIndividuel.Text = "Individuel"
        Me.optIndividuel.UseVisualStyleBackColor = True
        '
        'grbDurée
        '
        Me.grbDurée.Controls.Add(Me.opt12Mois)
        Me.grbDurée.Controls.Add(Me.opt9Mois)
        Me.grbDurée.Controls.Add(Me.opt6Mois)
        Me.grbDurée.Controls.Add(Me.opt3Mois)
        Me.grbDurée.Location = New System.Drawing.Point(167, 153)
        Me.grbDurée.Name = "grbDurée"
        Me.grbDurée.Size = New System.Drawing.Size(200, 132)
        Me.grbDurée.TabIndex = 6
        Me.grbDurée.TabStop = False
        Me.grbDurée.Text = "Durée"
        Me.tipInscription.SetToolTip(Me.grbDurée, "Sélectionnez la durée de votre abonnement.")
        '
        'opt12Mois
        '
        Me.opt12Mois.AutoSize = True
        Me.opt12Mois.Location = New System.Drawing.Point(7, 92)
        Me.opt12Mois.Name = "opt12Mois"
        Me.opt12Mois.Size = New System.Drawing.Size(61, 17)
        Me.opt12Mois.TabIndex = 6
        Me.opt12Mois.Text = "12 mois"
        Me.opt12Mois.UseVisualStyleBackColor = True
        '
        'opt9Mois
        '
        Me.opt9Mois.AutoSize = True
        Me.opt9Mois.Location = New System.Drawing.Point(7, 68)
        Me.opt9Mois.Name = "opt9Mois"
        Me.opt9Mois.Size = New System.Drawing.Size(55, 17)
        Me.opt9Mois.TabIndex = 5
        Me.opt9Mois.Text = "9 mois"
        Me.opt9Mois.UseVisualStyleBackColor = True
        '
        'opt6Mois
        '
        Me.opt6Mois.AutoSize = True
        Me.opt6Mois.Location = New System.Drawing.Point(7, 44)
        Me.opt6Mois.Name = "opt6Mois"
        Me.opt6Mois.Size = New System.Drawing.Size(55, 17)
        Me.opt6Mois.TabIndex = 4
        Me.opt6Mois.Text = "6 mois"
        Me.opt6Mois.UseVisualStyleBackColor = True
        '
        'opt3Mois
        '
        Me.opt3Mois.AutoSize = True
        Me.opt3Mois.Checked = True
        Me.opt3Mois.Location = New System.Drawing.Point(7, 20)
        Me.opt3Mois.Name = "opt3Mois"
        Me.opt3Mois.Size = New System.Drawing.Size(55, 17)
        Me.opt3Mois.TabIndex = 3
        Me.opt3Mois.TabStop = True
        Me.opt3Mois.Text = "3 mois"
        Me.opt3Mois.UseVisualStyleBackColor = True
        '
        'grbActivites
        '
        Me.grbActivites.Controls.Add(Me.chkDos)
        Me.grbActivites.Controls.Add(Me.chkBras)
        Me.grbActivites.Controls.Add(Me.chkChest)
        Me.grbActivites.Location = New System.Drawing.Point(42, 291)
        Me.grbActivites.Name = "grbActivites"
        Me.grbActivites.Size = New System.Drawing.Size(325, 50)
        Me.grbActivites.TabIndex = 7
        Me.grbActivites.TabStop = False
        Me.grbActivites.Text = "Activités"
        Me.tipInscription.SetToolTip(Me.grbActivites, "Sélectionnez les activités auquelles vous voulez participer.")
        '
        'chkDos
        '
        Me.chkDos.AutoSize = True
        Me.chkDos.Location = New System.Drawing.Point(132, 19)
        Me.chkDos.Name = "chkDos"
        Me.chkDos.Size = New System.Drawing.Size(45, 17)
        Me.chkDos.TabIndex = 9
        Me.chkDos.Text = "Dos"
        Me.chkDos.UseVisualStyleBackColor = True
        '
        'chkBras
        '
        Me.chkBras.AutoSize = True
        Me.chkBras.Location = New System.Drawing.Point(72, 19)
        Me.chkBras.Name = "chkBras"
        Me.chkBras.Size = New System.Drawing.Size(47, 17)
        Me.chkBras.TabIndex = 8
        Me.chkBras.Text = "Bras"
        Me.chkBras.UseVisualStyleBackColor = True
        '
        'chkChest
        '
        Me.chkChest.AutoSize = True
        Me.chkChest.Location = New System.Drawing.Point(7, 19)
        Me.chkChest.Name = "chkChest"
        Me.chkChest.Size = New System.Drawing.Size(53, 17)
        Me.chkChest.TabIndex = 7
        Me.chkChest.Text = "Chest"
        Me.chkChest.UseVisualStyleBackColor = True
        '
        'grbTarification
        '
        Me.grbTarification.Controls.Add(Me.btnTarifs)
        Me.grbTarification.Controls.Add(Me.btnDetails)
        Me.grbTarification.Controls.Add(Me.lblPrixTotal)
        Me.grbTarification.Controls.Add(Me.lblTotal)
        Me.grbTarification.Location = New System.Drawing.Point(42, 347)
        Me.grbTarification.Name = "grbTarification"
        Me.grbTarification.Size = New System.Drawing.Size(358, 59)
        Me.grbTarification.TabIndex = 8
        Me.grbTarification.TabStop = False
        Me.grbTarification.Text = "Tarification"
        '
        'btnTarifs
        '
        Me.btnTarifs.Location = New System.Drawing.Point(288, 16)
        Me.btnTarifs.Name = "btnTarifs"
        Me.btnTarifs.Size = New System.Drawing.Size(50, 32)
        Me.btnTarifs.TabIndex = 11
        Me.btnTarifs.Text = "&Tarifs"
        Me.tipInscription.SetToolTip(Me.btnTarifs, "Pour accéder au tableau complet des tarifs.")
        Me.btnTarifs.UseVisualStyleBackColor = True
        '
        'btnDetails
        '
        Me.btnDetails.Enabled = False
        Me.btnDetails.Location = New System.Drawing.Point(207, 16)
        Me.btnDetails.Name = "btnDetails"
        Me.btnDetails.Size = New System.Drawing.Size(75, 32)
        Me.btnDetails.TabIndex = 10
        Me.btnDetails.Text = "&Details"
        Me.tipInscription.SetToolTip(Me.btnDetails, "Afficher la tarification détaillée pour votre abonnement.")
        Me.btnDetails.UseVisualStyleBackColor = True
        '
        'lblPrixTotal
        '
        Me.lblPrixTotal.AutoSize = True
        Me.lblPrixTotal.Location = New System.Drawing.Point(19, 26)
        Me.lblPrixTotal.Name = "lblPrixTotal"
        Me.lblPrixTotal.Size = New System.Drawing.Size(54, 13)
        Me.lblPrixTotal.TabIndex = 1
        Me.lblPrixTotal.Text = "Prix Total:"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(100, 16)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 28)
        Me.lblTotal.TabIndex = 0
        '
        'btnCalculer
        '
        Me.btnCalculer.Location = New System.Drawing.Point(85, 412)
        Me.btnCalculer.Name = "btnCalculer"
        Me.btnCalculer.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculer.TabIndex = 12
        Me.btnCalculer.Text = "&Calculer"
        Me.tipInscription.SetToolTip(Me.btnCalculer, "Calculer le prix total de votre abonnement.")
        Me.btnCalculer.UseVisualStyleBackColor = True
        '
        'BtnAnnuler
        '
        Me.BtnAnnuler.Location = New System.Drawing.Point(188, 412)
        Me.BtnAnnuler.Name = "BtnAnnuler"
        Me.BtnAnnuler.Size = New System.Drawing.Size(75, 23)
        Me.BtnAnnuler.TabIndex = 13
        Me.BtnAnnuler.Text = "&Annuler"
        Me.tipInscription.SetToolTip(Me.BtnAnnuler, "Pour réinitialiser les contrôles de l'application.")
        Me.BtnAnnuler.UseVisualStyleBackColor = True
        '
        'BtnQuitter
        '
        Me.BtnQuitter.Location = New System.Drawing.Point(288, 412)
        Me.BtnQuitter.Name = "BtnQuitter"
        Me.BtnQuitter.Size = New System.Drawing.Size(75, 23)
        Me.BtnQuitter.TabIndex = 15
        Me.BtnQuitter.Text = "&Quitter"
        Me.BtnQuitter.UseVisualStyleBackColor = True
        '
        'lblInscriptionDentsu
        '
        Me.lblInscriptionDentsu.AutoSize = True
        Me.lblInscriptionDentsu.BackColor = System.Drawing.Color.Transparent
        Me.lblInscriptionDentsu.Font = New System.Drawing.Font("Stencil Std", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInscriptionDentsu.ForeColor = System.Drawing.Color.Red
        Me.lblInscriptionDentsu.Location = New System.Drawing.Point(12, 30)
        Me.lblInscriptionDentsu.Name = "lblInscriptionDentsu"
        Me.lblInscriptionDentsu.Size = New System.Drawing.Size(300, 43)
        Me.lblInscriptionDentsu.TabIndex = 16
        Me.lblInscriptionDentsu.Text = "DentsuBosGym"
        '
        'lblTritreEntrainement
        '
        Me.lblTritreEntrainement.AutoSize = True
        Me.lblTritreEntrainement.BackColor = System.Drawing.Color.Transparent
        Me.lblTritreEntrainement.Font = New System.Drawing.Font("Stencil Std", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTritreEntrainement.Location = New System.Drawing.Point(15, 16)
        Me.lblTritreEntrainement.Name = "lblTritreEntrainement"
        Me.lblTritreEntrainement.Size = New System.Drawing.Size(221, 22)
        Me.lblTritreEntrainement.TabIndex = 17
        Me.lblTritreEntrainement.Text = "Club d'entrainement"
        '
        'lblInscriptions
        '
        Me.lblInscriptions.AutoSize = True
        Me.lblInscriptions.BackColor = System.Drawing.Color.Transparent
        Me.lblInscriptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInscriptions.Font = New System.Drawing.Font("Stencil Std", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInscriptions.Location = New System.Drawing.Point(193, 59)
        Me.lblInscriptions.Name = "lblInscriptions"
        Me.lblInscriptions.Size = New System.Drawing.Size(143, 24)
        Me.lblInscriptions.TabIndex = 18
        Me.lblInscriptions.Text = "Inscriptions"
        '
        'frmInscription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 453)
        Me.Controls.Add(Me.lblInscriptions)
        Me.Controls.Add(Me.lblTritreEntrainement)
        Me.Controls.Add(Me.lblInscriptionDentsu)
        Me.Controls.Add(Me.BtnQuitter)
        Me.Controls.Add(Me.BtnAnnuler)
        Me.Controls.Add(Me.btnCalculer)
        Me.Controls.Add(Me.grbTarification)
        Me.Controls.Add(Me.grbActivites)
        Me.Controls.Add(Me.grbDurée)
        Me.Controls.Add(Me.grbAbonnement)
        Me.Controls.Add(Me.txtNomClient)
        Me.Controls.Add(Me.lblNomClient)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmInscription"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DentsuBosGym Inscription"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbAbonnement.ResumeLayout(False)
        Me.grbAbonnement.PerformLayout()
        Me.grbDurée.ResumeLayout(False)
        Me.grbDurée.PerformLayout()
        Me.grbActivites.ResumeLayout(False)
        Me.grbActivites.PerformLayout()
        Me.grbTarification.ResumeLayout(False)
        Me.grbTarification.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblNomClient As System.Windows.Forms.Label
    Friend WithEvents txtNomClient As System.Windows.Forms.TextBox
    Friend WithEvents grbAbonnement As System.Windows.Forms.GroupBox
    Friend WithEvents optFamilial As System.Windows.Forms.RadioButton
    Friend WithEvents optIndividuel As System.Windows.Forms.RadioButton
    Friend WithEvents grbDurée As System.Windows.Forms.GroupBox
    Friend WithEvents opt12Mois As System.Windows.Forms.RadioButton
    Friend WithEvents opt9Mois As System.Windows.Forms.RadioButton
    Friend WithEvents opt6Mois As System.Windows.Forms.RadioButton
    Friend WithEvents opt3Mois As System.Windows.Forms.RadioButton
    Friend WithEvents grbActivites As System.Windows.Forms.GroupBox
    Friend WithEvents chkDos As System.Windows.Forms.CheckBox
    Friend WithEvents chkBras As System.Windows.Forms.CheckBox
    Friend WithEvents chkChest As System.Windows.Forms.CheckBox
    Friend WithEvents grbTarification As System.Windows.Forms.GroupBox
    Friend WithEvents btnTarifs As System.Windows.Forms.Button
    Friend WithEvents btnDetails As System.Windows.Forms.Button
    Friend WithEvents lblPrixTotal As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents btnCalculer As System.Windows.Forms.Button
    Friend WithEvents BtnAnnuler As System.Windows.Forms.Button
    Friend WithEvents BtnQuitter As System.Windows.Forms.Button
    Friend WithEvents tipInscription As System.Windows.Forms.ToolTip
    Friend WithEvents lblInscriptionDentsu As System.Windows.Forms.Label
    Friend WithEvents lblTritreEntrainement As System.Windows.Forms.Label
    Friend WithEvents lblInscriptions As System.Windows.Forms.Label

End Class
