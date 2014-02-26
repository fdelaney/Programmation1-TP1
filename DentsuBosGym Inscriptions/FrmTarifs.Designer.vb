<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTarifs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTarifs))
        Me.lblAbonnement = New System.Windows.Forms.Label()
        Me.lblIndividuel = New System.Windows.Forms.Label()
        Me.lblFamilial = New System.Windows.Forms.Label()
        Me.lblTrimestriel = New System.Windows.Forms.Label()
        Me.lblChest = New System.Windows.Forms.Label()
        Me.lblBras = New System.Windows.Forms.Label()
        Me.lblDos = New System.Windows.Forms.Label()
        Me.lblRabaisActivites = New System.Windows.Forms.Label()
        Me.lbl2Activites = New System.Windows.Forms.Label()
        Me.lbl3Activites = New System.Windows.Forms.Label()
        Me.lblRabaisDuree = New System.Windows.Forms.Label()
        Me.lbl9Mois = New System.Windows.Forms.Label()
        Me.lbl12Mois = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.lblChestIndiv = New System.Windows.Forms.Label()
        Me.lblBrasIndiv = New System.Windows.Forms.Label()
        Me.lblDosIndiv = New System.Windows.Forms.Label()
        Me.lblChestFam = New System.Windows.Forms.Label()
        Me.lblBrasFam = New System.Windows.Forms.Label()
        Me.lblDosFam = New System.Windows.Forms.Label()
        Me.lblRabais2ActIndiv = New System.Windows.Forms.Label()
        Me.lblRabais3ActIndiv = New System.Windows.Forms.Label()
        Me.lblRabais2ActFam = New System.Windows.Forms.Label()
        Me.lblRabais3ActFam = New System.Windows.Forms.Label()
        Me.lblRabais9MoisIndiv = New System.Windows.Forms.Label()
        Me.lblRabais12MoisIndiv = New System.Windows.Forms.Label()
        Me.lblRabais9MoisFam = New System.Windows.Forms.Label()
        Me.lblRabais12MoisFam = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAbonnement
        '
        Me.lblAbonnement.AutoSize = True
        Me.lblAbonnement.Location = New System.Drawing.Point(28, 32)
        Me.lblAbonnement.Name = "lblAbonnement"
        Me.lblAbonnement.Size = New System.Drawing.Size(67, 13)
        Me.lblAbonnement.TabIndex = 0
        Me.lblAbonnement.Text = "Abonnement"
        '
        'lblIndividuel
        '
        Me.lblIndividuel.AutoSize = True
        Me.lblIndividuel.Location = New System.Drawing.Point(174, 32)
        Me.lblIndividuel.Name = "lblIndividuel"
        Me.lblIndividuel.Size = New System.Drawing.Size(52, 13)
        Me.lblIndividuel.TabIndex = 1
        Me.lblIndividuel.Text = "Individuel"
        '
        'lblFamilial
        '
        Me.lblFamilial.AutoSize = True
        Me.lblFamilial.Location = New System.Drawing.Point(282, 32)
        Me.lblFamilial.Name = "lblFamilial"
        Me.lblFamilial.Size = New System.Drawing.Size(41, 13)
        Me.lblFamilial.TabIndex = 2
        Me.lblFamilial.Text = "Familial"
        '
        'lblTrimestriel
        '
        Me.lblTrimestriel.AutoSize = True
        Me.lblTrimestriel.Location = New System.Drawing.Point(28, 71)
        Me.lblTrimestriel.Name = "lblTrimestriel"
        Me.lblTrimestriel.Size = New System.Drawing.Size(136, 13)
        Me.lblTrimestriel.TabIndex = 3
        Me.lblTrimestriel.Text = "Tarif trimestriel des activités"
        '
        'lblChest
        '
        Me.lblChest.AutoSize = True
        Me.lblChest.Location = New System.Drawing.Point(70, 97)
        Me.lblChest.Name = "lblChest"
        Me.lblChest.Size = New System.Drawing.Size(34, 13)
        Me.lblChest.TabIndex = 4
        Me.lblChest.Text = "Chest"
        '
        'lblBras
        '
        Me.lblBras.AutoSize = True
        Me.lblBras.Location = New System.Drawing.Point(70, 110)
        Me.lblBras.Name = "lblBras"
        Me.lblBras.Size = New System.Drawing.Size(28, 13)
        Me.lblBras.TabIndex = 5
        Me.lblBras.Text = "Bras"
        '
        'lblDos
        '
        Me.lblDos.AutoSize = True
        Me.lblDos.Location = New System.Drawing.Point(70, 123)
        Me.lblDos.Name = "lblDos"
        Me.lblDos.Size = New System.Drawing.Size(26, 13)
        Me.lblDos.TabIndex = 6
        Me.lblDos.Text = "Dos"
        '
        'lblRabaisActivites
        '
        Me.lblRabaisActivites.AutoSize = True
        Me.lblRabaisActivites.Location = New System.Drawing.Point(28, 148)
        Me.lblRabaisActivites.Name = "lblRabaisActivites"
        Me.lblRabaisActivites.Size = New System.Drawing.Size(115, 13)
        Me.lblRabaisActivites.TabIndex = 7
        Me.lblRabaisActivites.Text = "Rabais sur les activités"
        '
        'lbl2Activites
        '
        Me.lbl2Activites.AutoSize = True
        Me.lbl2Activites.Location = New System.Drawing.Point(70, 170)
        Me.lbl2Activites.Name = "lbl2Activites"
        Me.lbl2Activites.Size = New System.Drawing.Size(55, 13)
        Me.lbl2Activites.TabIndex = 8
        Me.lbl2Activites.Text = "2 activités"
        '
        'lbl3Activites
        '
        Me.lbl3Activites.AutoSize = True
        Me.lbl3Activites.Location = New System.Drawing.Point(70, 183)
        Me.lbl3Activites.Name = "lbl3Activites"
        Me.lbl3Activites.Size = New System.Drawing.Size(55, 13)
        Me.lbl3Activites.TabIndex = 9
        Me.lbl3Activites.Text = "3 activités"
        '
        'lblRabaisDuree
        '
        Me.lblRabaisDuree.AutoSize = True
        Me.lblRabaisDuree.Location = New System.Drawing.Point(28, 222)
        Me.lblRabaisDuree.Name = "lblRabaisDuree"
        Me.lblRabaisDuree.Size = New System.Drawing.Size(105, 13)
        Me.lblRabaisDuree.TabIndex = 10
        Me.lblRabaisDuree.Text = "Rabais pour la durée"
        '
        'lbl9Mois
        '
        Me.lbl9Mois.AutoSize = True
        Me.lbl9Mois.Location = New System.Drawing.Point(70, 246)
        Me.lbl9Mois.Name = "lbl9Mois"
        Me.lbl9Mois.Size = New System.Drawing.Size(37, 13)
        Me.lbl9Mois.TabIndex = 11
        Me.lbl9Mois.Text = "9 mois"
        '
        'lbl12Mois
        '
        Me.lbl12Mois.AutoSize = True
        Me.lbl12Mois.Location = New System.Drawing.Point(70, 259)
        Me.lbl12Mois.Name = "lbl12Mois"
        Me.lbl12Mois.Size = New System.Drawing.Size(43, 13)
        Me.lbl12Mois.TabIndex = 12
        Me.lbl12Mois.Text = "12 mois"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(177, 318)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 13
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'lblChestIndiv
        '
        Me.lblChestIndiv.AutoSize = True
        Me.lblChestIndiv.Location = New System.Drawing.Point(174, 97)
        Me.lblChestIndiv.Name = "lblChestIndiv"
        Me.lblChestIndiv.Size = New System.Drawing.Size(39, 13)
        Me.lblChestIndiv.TabIndex = 14
        Me.lblChestIndiv.Text = "Label1"
        '
        'lblBrasIndiv
        '
        Me.lblBrasIndiv.AutoSize = True
        Me.lblBrasIndiv.Location = New System.Drawing.Point(174, 110)
        Me.lblBrasIndiv.Name = "lblBrasIndiv"
        Me.lblBrasIndiv.Size = New System.Drawing.Size(39, 13)
        Me.lblBrasIndiv.TabIndex = 15
        Me.lblBrasIndiv.Text = "Label1"
        '
        'lblDosIndiv
        '
        Me.lblDosIndiv.AutoSize = True
        Me.lblDosIndiv.Location = New System.Drawing.Point(174, 123)
        Me.lblDosIndiv.Name = "lblDosIndiv"
        Me.lblDosIndiv.Size = New System.Drawing.Size(39, 13)
        Me.lblDosIndiv.TabIndex = 16
        Me.lblDosIndiv.Text = "Label1"
        '
        'lblChestFam
        '
        Me.lblChestFam.AutoSize = True
        Me.lblChestFam.Location = New System.Drawing.Point(282, 97)
        Me.lblChestFam.Name = "lblChestFam"
        Me.lblChestFam.Size = New System.Drawing.Size(39, 13)
        Me.lblChestFam.TabIndex = 17
        Me.lblChestFam.Text = "Label1"
        '
        'lblBrasFam
        '
        Me.lblBrasFam.AutoSize = True
        Me.lblBrasFam.Location = New System.Drawing.Point(282, 110)
        Me.lblBrasFam.Name = "lblBrasFam"
        Me.lblBrasFam.Size = New System.Drawing.Size(39, 13)
        Me.lblBrasFam.TabIndex = 18
        Me.lblBrasFam.Text = "Label1"
        '
        'lblDosFam
        '
        Me.lblDosFam.AutoSize = True
        Me.lblDosFam.Location = New System.Drawing.Point(282, 123)
        Me.lblDosFam.Name = "lblDosFam"
        Me.lblDosFam.Size = New System.Drawing.Size(39, 13)
        Me.lblDosFam.TabIndex = 19
        Me.lblDosFam.Text = "Label2"
        '
        'lblRabais2ActIndiv
        '
        Me.lblRabais2ActIndiv.AutoSize = True
        Me.lblRabais2ActIndiv.Location = New System.Drawing.Point(174, 170)
        Me.lblRabais2ActIndiv.Name = "lblRabais2ActIndiv"
        Me.lblRabais2ActIndiv.Size = New System.Drawing.Size(39, 13)
        Me.lblRabais2ActIndiv.TabIndex = 20
        Me.lblRabais2ActIndiv.Text = "Label1"
        '
        'lblRabais3ActIndiv
        '
        Me.lblRabais3ActIndiv.AutoSize = True
        Me.lblRabais3ActIndiv.Location = New System.Drawing.Point(174, 183)
        Me.lblRabais3ActIndiv.Name = "lblRabais3ActIndiv"
        Me.lblRabais3ActIndiv.Size = New System.Drawing.Size(39, 13)
        Me.lblRabais3ActIndiv.TabIndex = 21
        Me.lblRabais3ActIndiv.Text = "Label2"
        '
        'lblRabais2ActFam
        '
        Me.lblRabais2ActFam.AutoSize = True
        Me.lblRabais2ActFam.Location = New System.Drawing.Point(282, 170)
        Me.lblRabais2ActFam.Name = "lblRabais2ActFam"
        Me.lblRabais2ActFam.Size = New System.Drawing.Size(39, 13)
        Me.lblRabais2ActFam.TabIndex = 22
        Me.lblRabais2ActFam.Text = "Label1"
        '
        'lblRabais3ActFam
        '
        Me.lblRabais3ActFam.AutoSize = True
        Me.lblRabais3ActFam.Location = New System.Drawing.Point(282, 183)
        Me.lblRabais3ActFam.Name = "lblRabais3ActFam"
        Me.lblRabais3ActFam.Size = New System.Drawing.Size(39, 13)
        Me.lblRabais3ActFam.TabIndex = 23
        Me.lblRabais3ActFam.Text = "Label2"
        '
        'lblRabais9MoisIndiv
        '
        Me.lblRabais9MoisIndiv.AutoSize = True
        Me.lblRabais9MoisIndiv.Location = New System.Drawing.Point(174, 246)
        Me.lblRabais9MoisIndiv.Name = "lblRabais9MoisIndiv"
        Me.lblRabais9MoisIndiv.Size = New System.Drawing.Size(39, 13)
        Me.lblRabais9MoisIndiv.TabIndex = 24
        Me.lblRabais9MoisIndiv.Text = "Label1"
        '
        'lblRabais12MoisIndiv
        '
        Me.lblRabais12MoisIndiv.AutoSize = True
        Me.lblRabais12MoisIndiv.Location = New System.Drawing.Point(174, 259)
        Me.lblRabais12MoisIndiv.Name = "lblRabais12MoisIndiv"
        Me.lblRabais12MoisIndiv.Size = New System.Drawing.Size(39, 13)
        Me.lblRabais12MoisIndiv.TabIndex = 25
        Me.lblRabais12MoisIndiv.Text = "Label2"
        '
        'lblRabais9MoisFam
        '
        Me.lblRabais9MoisFam.AutoSize = True
        Me.lblRabais9MoisFam.Location = New System.Drawing.Point(282, 246)
        Me.lblRabais9MoisFam.Name = "lblRabais9MoisFam"
        Me.lblRabais9MoisFam.Size = New System.Drawing.Size(39, 13)
        Me.lblRabais9MoisFam.TabIndex = 26
        Me.lblRabais9MoisFam.Text = "Label3"
        '
        'lblRabais12MoisFam
        '
        Me.lblRabais12MoisFam.AutoSize = True
        Me.lblRabais12MoisFam.Location = New System.Drawing.Point(282, 259)
        Me.lblRabais12MoisFam.Name = "lblRabais12MoisFam"
        Me.lblRabais12MoisFam.Size = New System.Drawing.Size(39, 13)
        Me.lblRabais12MoisFam.TabIndex = 27
        Me.lblRabais12MoisFam.Text = "Label4"
        '
        'frmTarifs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 367)
        Me.Controls.Add(Me.lblRabais12MoisFam)
        Me.Controls.Add(Me.lblRabais9MoisFam)
        Me.Controls.Add(Me.lblRabais12MoisIndiv)
        Me.Controls.Add(Me.lblRabais9MoisIndiv)
        Me.Controls.Add(Me.lblRabais3ActFam)
        Me.Controls.Add(Me.lblRabais2ActFam)
        Me.Controls.Add(Me.lblRabais3ActIndiv)
        Me.Controls.Add(Me.lblRabais2ActIndiv)
        Me.Controls.Add(Me.lblDosFam)
        Me.Controls.Add(Me.lblBrasFam)
        Me.Controls.Add(Me.lblChestFam)
        Me.Controls.Add(Me.lblDosIndiv)
        Me.Controls.Add(Me.lblBrasIndiv)
        Me.Controls.Add(Me.lblChestIndiv)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lbl12Mois)
        Me.Controls.Add(Me.lbl9Mois)
        Me.Controls.Add(Me.lblRabaisDuree)
        Me.Controls.Add(Me.lbl3Activites)
        Me.Controls.Add(Me.lbl2Activites)
        Me.Controls.Add(Me.lblRabaisActivites)
        Me.Controls.Add(Me.lblDos)
        Me.Controls.Add(Me.lblBras)
        Me.Controls.Add(Me.lblChest)
        Me.Controls.Add(Me.lblTrimestriel)
        Me.Controls.Add(Me.lblFamilial)
        Me.Controls.Add(Me.lblIndividuel)
        Me.Controls.Add(Me.lblAbonnement)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmTarifs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tarifs"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAbonnement As System.Windows.Forms.Label
    Friend WithEvents lblIndividuel As System.Windows.Forms.Label
    Friend WithEvents lblFamilial As System.Windows.Forms.Label
    Friend WithEvents lblTrimestriel As System.Windows.Forms.Label
    Friend WithEvents lblChest As System.Windows.Forms.Label
    Friend WithEvents lblBras As System.Windows.Forms.Label
    Friend WithEvents lblDos As System.Windows.Forms.Label
    Friend WithEvents lblRabaisActivites As System.Windows.Forms.Label
    Friend WithEvents lbl2Activites As System.Windows.Forms.Label
    Friend WithEvents lbl3Activites As System.Windows.Forms.Label
    Friend WithEvents lblRabaisDuree As System.Windows.Forms.Label
    Friend WithEvents lbl9Mois As System.Windows.Forms.Label
    Friend WithEvents lbl12Mois As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents lblChestIndiv As System.Windows.Forms.Label
    Friend WithEvents lblBrasIndiv As System.Windows.Forms.Label
    Friend WithEvents lblDosIndiv As System.Windows.Forms.Label
    Friend WithEvents lblChestFam As System.Windows.Forms.Label
    Friend WithEvents lblBrasFam As System.Windows.Forms.Label
    Friend WithEvents lblDosFam As System.Windows.Forms.Label
    Friend WithEvents lblRabais2ActIndiv As System.Windows.Forms.Label
    Friend WithEvents lblRabais3ActIndiv As System.Windows.Forms.Label
    Friend WithEvents lblRabais2ActFam As System.Windows.Forms.Label
    Friend WithEvents lblRabais3ActFam As System.Windows.Forms.Label
    Friend WithEvents lblRabais9MoisIndiv As System.Windows.Forms.Label
    Friend WithEvents lblRabais12MoisIndiv As System.Windows.Forms.Label
    Friend WithEvents lblRabais9MoisFam As System.Windows.Forms.Label
    Friend WithEvents lblRabais12MoisFam As System.Windows.Forms.Label
End Class
