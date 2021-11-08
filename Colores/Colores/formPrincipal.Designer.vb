<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.vsbR = New System.Windows.Forms.VScrollBar()
        Me.vsbG = New System.Windows.Forms.VScrollBar()
        Me.vsbB = New System.Windows.Forms.VScrollBar()
        Me.lblR = New System.Windows.Forms.Label()
        Me.lblG = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtR = New System.Windows.Forms.TextBox()
        Me.txtG = New System.Windows.Forms.TextBox()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'vsbR
        '
        Me.vsbR.Location = New System.Drawing.Point(32, 50)
        Me.vsbR.Maximum = 264
        Me.vsbR.Name = "vsbR"
        Me.vsbR.Size = New System.Drawing.Size(27, 192)
        Me.vsbR.TabIndex = 0
        '
        'vsbG
        '
        Me.vsbG.Location = New System.Drawing.Point(113, 50)
        Me.vsbG.Maximum = 264
        Me.vsbG.Name = "vsbG"
        Me.vsbG.Size = New System.Drawing.Size(27, 192)
        Me.vsbG.TabIndex = 1
        '
        'vsbB
        '
        Me.vsbB.Location = New System.Drawing.Point(195, 50)
        Me.vsbB.Maximum = 264
        Me.vsbB.Name = "vsbB"
        Me.vsbB.Size = New System.Drawing.Size(27, 192)
        Me.vsbB.TabIndex = 2
        '
        'lblR
        '
        Me.lblR.AutoSize = True
        Me.lblR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblR.Location = New System.Drawing.Point(36, 266)
        Me.lblR.Name = "lblR"
        Me.lblR.Size = New System.Drawing.Size(18, 20)
        Me.lblR.TabIndex = 3
        Me.lblR.Text = "1"
        '
        'lblG
        '
        Me.lblG.AutoSize = True
        Me.lblG.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblG.Location = New System.Drawing.Point(118, 266)
        Me.lblG.Name = "lblG"
        Me.lblG.Size = New System.Drawing.Size(18, 20)
        Me.lblG.TabIndex = 4
        Me.lblG.Text = "2"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB.Location = New System.Drawing.Point(200, 266)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(18, 20)
        Me.lblB.TabIndex = 5
        Me.lblB.Text = "3"
        '
        'lblColor
        '
        Me.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblColor.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblColor.Location = New System.Drawing.Point(291, 65)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(163, 192)
        Me.lblColor.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(284, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 210)
        Me.Label1.TabIndex = 7
        '
        'txtR
        '
        Me.txtR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtR.Location = New System.Drawing.Point(28, 317)
        Me.txtR.MaxLength = 264
        Me.txtR.Name = "txtR"
        Me.txtR.ReadOnly = True
        Me.txtR.Size = New System.Drawing.Size(41, 26)
        Me.txtR.TabIndex = 8
        '
        'txtG
        '
        Me.txtG.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtG.Location = New System.Drawing.Point(107, 317)
        Me.txtG.MaxLength = 264
        Me.txtG.Name = "txtG"
        Me.txtG.ReadOnly = True
        Me.txtG.Size = New System.Drawing.Size(41, 26)
        Me.txtG.TabIndex = 9
        '
        'txtB
        '
        Me.txtB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtB.Location = New System.Drawing.Point(190, 317)
        Me.txtB.MaxLength = 264
        Me.txtB.Name = "txtB"
        Me.txtB.ReadOnly = True
        Me.txtB.Size = New System.Drawing.Size(41, 26)
        Me.txtB.TabIndex = 10
        '
        'formPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(483, 355)
        Me.Controls.Add(Me.txtB)
        Me.Controls.Add(Me.txtG)
        Me.Controls.Add(Me.txtR)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.lblG)
        Me.Controls.Add(Me.lblR)
        Me.Controls.Add(Me.vsbB)
        Me.Controls.Add(Me.vsbG)
        Me.Controls.Add(Me.vsbR)
        Me.Name = "formPrincipal"
        Me.Text = "Colores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents vsbR As VScrollBar
    Friend WithEvents vsbG As VScrollBar
    Friend WithEvents vsbB As VScrollBar
    Friend WithEvents lblR As Label
    Friend WithEvents lblG As Label
    Friend WithEvents lblB As Label
    Friend WithEvents lblColor As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtR As TextBox
    Friend WithEvents txtG As TextBox
    Friend WithEvents txtB As TextBox
End Class
