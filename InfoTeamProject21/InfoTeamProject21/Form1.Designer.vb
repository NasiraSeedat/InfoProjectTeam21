<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDiseases
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grdHIVnAIDS = New UJGrid.UJGrid()
        Me.btnInputInfo = New System.Windows.Forms.Button()
        Me.btnTransSurvRate = New System.Windows.Forms.Button()
        Me.btnSeeDoc = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grdMalaria = New UJGrid.UJGrid()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTransHIVnAIDS = New System.Windows.Forms.TextBox()
        Me.txtTransMalaria = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'grdHIVnAIDS
        '
        Me.grdHIVnAIDS.FixedCols = 1
        Me.grdHIVnAIDS.FixedRows = 1
        Me.grdHIVnAIDS.Location = New System.Drawing.Point(186, 31)
        Me.grdHIVnAIDS.Name = "grdHIVnAIDS"
        Me.grdHIVnAIDS.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdHIVnAIDS.Size = New System.Drawing.Size(434, 150)
        Me.grdHIVnAIDS.TabIndex = 0
        '
        'btnInputInfo
        '
        Me.btnInputInfo.Location = New System.Drawing.Point(23, 31)
        Me.btnInputInfo.Name = "btnInputInfo"
        Me.btnInputInfo.Size = New System.Drawing.Size(122, 46)
        Me.btnInputInfo.TabIndex = 2
        Me.btnInputInfo.Text = "Input Information"
        Me.btnInputInfo.UseVisualStyleBackColor = True
        '
        'btnTransSurvRate
        '
        Me.btnTransSurvRate.Location = New System.Drawing.Point(23, 177)
        Me.btnTransSurvRate.Name = "btnTransSurvRate"
        Me.btnTransSurvRate.Size = New System.Drawing.Size(122, 46)
        Me.btnTransSurvRate.TabIndex = 3
        Me.btnTransSurvRate.Text = "Calculate Transmition Rate"
        Me.btnTransSurvRate.UseVisualStyleBackColor = True
        '
        'btnSeeDoc
        '
        Me.btnSeeDoc.Location = New System.Drawing.Point(23, 103)
        Me.btnSeeDoc.Name = "btnSeeDoc"
        Me.btnSeeDoc.Size = New System.Drawing.Size(122, 46)
        Me.btnSeeDoc.TabIndex = 4
        Me.btnSeeDoc.Text = "See A Doctor"
        Me.btnSeeDoc.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(186, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "HIV and AIDS"
        '
        'grdMalaria
        '
        Me.grdMalaria.FixedCols = 1
        Me.grdMalaria.FixedRows = 1
        Me.grdMalaria.Location = New System.Drawing.Point(189, 242)
        Me.grdMalaria.Name = "grdMalaria"
        Me.grdMalaria.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.grdMalaria.Size = New System.Drawing.Size(431, 150)
        Me.grdMalaria.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(186, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Malaria"
        '
        'txtTransHIVnAIDS
        '
        Me.txtTransHIVnAIDS.Location = New System.Drawing.Point(186, 203)
        Me.txtTransHIVnAIDS.Name = "txtTransHIVnAIDS"
        Me.txtTransHIVnAIDS.Size = New System.Drawing.Size(100, 20)
        Me.txtTransHIVnAIDS.TabIndex = 8
        '
        'txtTransMalaria
        '
        Me.txtTransMalaria.Location = New System.Drawing.Point(186, 415)
        Me.txtTransMalaria.Name = "txtTransMalaria"
        Me.txtTransMalaria.Size = New System.Drawing.Size(100, 20)
        Me.txtTransMalaria.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(183, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Transmition Rate for HIV and AIDS:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(183, 399)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Transmition Rate for Malaria:"
        '
        'frmDiseases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 459)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTransMalaria)
        Me.Controls.Add(Me.txtTransHIVnAIDS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grdMalaria)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSeeDoc)
        Me.Controls.Add(Me.btnTransSurvRate)
        Me.Controls.Add(Me.btnInputInfo)
        Me.Controls.Add(Me.grdHIVnAIDS)
        Me.Name = "frmDiseases"
        Me.Text = "Diseases"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdHIVnAIDS As UJGrid.UJGrid
    Friend WithEvents btnInputInfo As Button
    Friend WithEvents btnTransSurvRate As Button
    Friend WithEvents btnSeeDoc As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents grdMalaria As UJGrid.UJGrid
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTransHIVnAIDS As TextBox
    Friend WithEvents txtTransMalaria As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
