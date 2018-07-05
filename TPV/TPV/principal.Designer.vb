<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(principal))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnOtros = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnConservas = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnLacteos = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnCereales = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnPasta = New Bunifu.Framework.UI.BunifuTileButton()
        Me.btnLegumbres = New Bunifu.Framework.UI.BunifuTileButton()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 665)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(758, 29)
        Me.Panel2.TabIndex = 11
        '
        'btnOtros
        '
        Me.btnOtros.BackColor = System.Drawing.Color.Transparent
        Me.btnOtros.color = System.Drawing.Color.Transparent
        Me.btnOtros.colorActive = System.Drawing.Color.Transparent
        Me.btnOtros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOtros.Font = New System.Drawing.Font("Raleway", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOtros.ForeColor = System.Drawing.Color.Black
        Me.btnOtros.Image = CType(resources.GetObject("btnOtros.Image"), System.Drawing.Image)
        Me.btnOtros.ImagePosition = 6
        Me.btnOtros.ImageZoom = 45
        Me.btnOtros.LabelPosition = 27
        Me.btnOtros.LabelText = "Otros"
        Me.btnOtros.Location = New System.Drawing.Point(489, 494)
        Me.btnOtros.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnOtros.Name = "btnOtros"
        Me.btnOtros.Size = New System.Drawing.Size(174, 116)
        Me.btnOtros.TabIndex = 17
        '
        'btnConservas
        '
        Me.btnConservas.BackColor = System.Drawing.Color.Transparent
        Me.btnConservas.color = System.Drawing.Color.Transparent
        Me.btnConservas.colorActive = System.Drawing.Color.Transparent
        Me.btnConservas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConservas.Font = New System.Drawing.Font("Raleway", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConservas.ForeColor = System.Drawing.Color.Black
        Me.btnConservas.Image = CType(resources.GetObject("btnConservas.Image"), System.Drawing.Image)
        Me.btnConservas.ImagePosition = 6
        Me.btnConservas.ImageZoom = 45
        Me.btnConservas.LabelPosition = 27
        Me.btnConservas.LabelText = "Conservas"
        Me.btnConservas.Location = New System.Drawing.Point(489, 272)
        Me.btnConservas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnConservas.Name = "btnConservas"
        Me.btnConservas.Size = New System.Drawing.Size(174, 116)
        Me.btnConservas.TabIndex = 16
        '
        'btnLacteos
        '
        Me.btnLacteos.BackColor = System.Drawing.Color.Transparent
        Me.btnLacteos.color = System.Drawing.Color.Transparent
        Me.btnLacteos.colorActive = System.Drawing.Color.Transparent
        Me.btnLacteos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLacteos.Font = New System.Drawing.Font("Raleway", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLacteos.ForeColor = System.Drawing.Color.Black
        Me.btnLacteos.Image = CType(resources.GetObject("btnLacteos.Image"), System.Drawing.Image)
        Me.btnLacteos.ImagePosition = 6
        Me.btnLacteos.ImageZoom = 45
        Me.btnLacteos.LabelPosition = 27
        Me.btnLacteos.LabelText = "Lácteos"
        Me.btnLacteos.Location = New System.Drawing.Point(95, 494)
        Me.btnLacteos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLacteos.Name = "btnLacteos"
        Me.btnLacteos.Size = New System.Drawing.Size(174, 116)
        Me.btnLacteos.TabIndex = 15
        '
        'btnCereales
        '
        Me.btnCereales.BackColor = System.Drawing.Color.Transparent
        Me.btnCereales.color = System.Drawing.Color.Transparent
        Me.btnCereales.colorActive = System.Drawing.Color.Transparent
        Me.btnCereales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCereales.Font = New System.Drawing.Font("Raleway", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCereales.ForeColor = System.Drawing.Color.Black
        Me.btnCereales.Image = CType(resources.GetObject("btnCereales.Image"), System.Drawing.Image)
        Me.btnCereales.ImagePosition = 6
        Me.btnCereales.ImageZoom = 45
        Me.btnCereales.LabelPosition = 27
        Me.btnCereales.LabelText = "Cereales (arroz...)"
        Me.btnCereales.Location = New System.Drawing.Point(489, 54)
        Me.btnCereales.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCereales.Name = "btnCereales"
        Me.btnCereales.Size = New System.Drawing.Size(174, 116)
        Me.btnCereales.TabIndex = 14
        '
        'btnPasta
        '
        Me.btnPasta.BackColor = System.Drawing.Color.Transparent
        Me.btnPasta.color = System.Drawing.Color.Transparent
        Me.btnPasta.colorActive = System.Drawing.Color.Transparent
        Me.btnPasta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPasta.Font = New System.Drawing.Font("Raleway", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPasta.ForeColor = System.Drawing.Color.Black
        Me.btnPasta.Image = CType(resources.GetObject("btnPasta.Image"), System.Drawing.Image)
        Me.btnPasta.ImagePosition = 6
        Me.btnPasta.ImageZoom = 45
        Me.btnPasta.LabelPosition = 27
        Me.btnPasta.LabelText = "Pasta"
        Me.btnPasta.Location = New System.Drawing.Point(95, 272)
        Me.btnPasta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPasta.Name = "btnPasta"
        Me.btnPasta.Size = New System.Drawing.Size(174, 116)
        Me.btnPasta.TabIndex = 13
        '
        'btnLegumbres
        '
        Me.btnLegumbres.BackColor = System.Drawing.Color.Transparent
        Me.btnLegumbres.color = System.Drawing.Color.Transparent
        Me.btnLegumbres.colorActive = System.Drawing.Color.Transparent
        Me.btnLegumbres.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLegumbres.Font = New System.Drawing.Font("Raleway", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLegumbres.ForeColor = System.Drawing.Color.Black
        Me.btnLegumbres.Image = CType(resources.GetObject("btnLegumbres.Image"), System.Drawing.Image)
        Me.btnLegumbres.ImagePosition = 6
        Me.btnLegumbres.ImageZoom = 45
        Me.btnLegumbres.LabelPosition = 27
        Me.btnLegumbres.LabelText = "Legumbres"
        Me.btnLegumbres.Location = New System.Drawing.Point(95, 54)
        Me.btnLegumbres.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLegumbres.Name = "btnLegumbres"
        Me.btnLegumbres.Size = New System.Drawing.Size(174, 116)
        Me.btnLegumbres.TabIndex = 12
        '
        'principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(758, 694)
        Me.Controls.Add(Me.btnOtros)
        Me.Controls.Add(Me.btnConservas)
        Me.Controls.Add(Me.btnLacteos)
        Me.Controls.Add(Me.btnCereales)
        Me.Controls.Add(Me.btnPasta)
        Me.Controls.Add(Me.btnLegumbres)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "principal"
        Me.Text = "principal"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnOtros As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnConservas As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnLacteos As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnCereales As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnPasta As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents btnLegumbres As Bunifu.Framework.UI.BunifuTileButton
End Class
