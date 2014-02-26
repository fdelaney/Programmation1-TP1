<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTitre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTitre))
        Me.picTitre = New System.Windows.Forms.PictureBox()
        Me.lblTitreDentsu = New System.Windows.Forms.Label()
        Me.tmrTitre = New System.Windows.Forms.Timer(Me.components)
        Me.lblTritreEntrainement = New System.Windows.Forms.Label()
        Me.lblInscriptions = New System.Windows.Forms.Label()
        CType(Me.picTitre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picTitre
        '
        Me.picTitre.Image = CType(resources.GetObject("picTitre.Image"), System.Drawing.Image)
        Me.picTitre.Location = New System.Drawing.Point(12, 12)
        Me.picTitre.Name = "picTitre"
        Me.picTitre.Size = New System.Drawing.Size(602, 361)
        Me.picTitre.TabIndex = 0
        Me.picTitre.TabStop = False
        '
        'lblTitreDentsu
        '
        Me.lblTitreDentsu.AutoSize = True
        Me.lblTitreDentsu.BackColor = System.Drawing.Color.Transparent
        Me.lblTitreDentsu.Font = New System.Drawing.Font("Stencil Std", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitreDentsu.ForeColor = System.Drawing.Color.Red
        Me.lblTitreDentsu.Location = New System.Drawing.Point(148, 402)
        Me.lblTitreDentsu.Name = "lblTitreDentsu"
        Me.lblTitreDentsu.Size = New System.Drawing.Size(316, 46)
        Me.lblTitreDentsu.TabIndex = 1
        Me.lblTitreDentsu.Text = "DentsuBosGym"
        '
        'tmrTitre
        '
        Me.tmrTitre.Interval = 3000
        '
        'lblTritreEntrainement
        '
        Me.lblTritreEntrainement.AutoSize = True
        Me.lblTritreEntrainement.BackColor = System.Drawing.Color.Transparent
        Me.lblTritreEntrainement.Font = New System.Drawing.Font("Stencil Std", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTritreEntrainement.Location = New System.Drawing.Point(143, 384)
        Me.lblTritreEntrainement.Name = "lblTritreEntrainement"
        Me.lblTritreEntrainement.Size = New System.Drawing.Size(260, 26)
        Me.lblTritreEntrainement.TabIndex = 2
        Me.lblTritreEntrainement.Text = "Club d'entrainement"
        '
        'lblInscriptions
        '
        Me.lblInscriptions.AutoSize = True
        Me.lblInscriptions.BackColor = System.Drawing.Color.Transparent
        Me.lblInscriptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblInscriptions.Font = New System.Drawing.Font("Stencil Std", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInscriptions.Location = New System.Drawing.Point(299, 433)
        Me.lblInscriptions.Margin = New System.Windows.Forms.Padding(0)
        Me.lblInscriptions.Name = "lblInscriptions"
        Me.lblInscriptions.Size = New System.Drawing.Size(167, 28)
        Me.lblInscriptions.TabIndex = 3
        Me.lblInscriptions.Text = "Inscriptions"
        '
        'FrmTitre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 473)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblInscriptions)
        Me.Controls.Add(Me.lblTritreEntrainement)
        Me.Controls.Add(Me.lblTitreDentsu)
        Me.Controls.Add(Me.picTitre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmTitre"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.picTitre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picTitre As System.Windows.Forms.PictureBox
    Friend WithEvents lblTitreDentsu As System.Windows.Forms.Label
    Friend WithEvents tmrTitre As System.Windows.Forms.Timer
    Friend WithEvents lblTritreEntrainement As System.Windows.Forms.Label
    Friend WithEvents lblInscriptions As System.Windows.Forms.Label
End Class
