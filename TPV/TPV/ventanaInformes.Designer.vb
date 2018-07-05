<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventanaInformes
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnInformeStock = New System.Windows.Forms.Button()
        Me.btnInfEntradaFecha = New System.Windows.Forms.Button()
        Me.dtpFechaInicio = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.dtpFechaFin = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Line1 = New DevComponents.DotNetBar.Controls.Line()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 540)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(568, 24)
        Me.Panel2.TabIndex = 11
        '
        'btnInformeStock
        '
        Me.btnInformeStock.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnInformeStock.FlatAppearance.BorderSize = 0
        Me.btnInformeStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInformeStock.Font = New System.Drawing.Font("Raleway SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInformeStock.ForeColor = System.Drawing.Color.White
        Me.btnInformeStock.Location = New System.Drawing.Point(194, 167)
        Me.btnInformeStock.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnInformeStock.Name = "btnInformeStock"
        Me.btnInformeStock.Size = New System.Drawing.Size(177, 75)
        Me.btnInformeStock.TabIndex = 13
        Me.btnInformeStock.Text = "Informe Stock actual"
        Me.btnInformeStock.UseVisualStyleBackColor = False
        '
        'btnInfEntradaFecha
        '
        Me.btnInfEntradaFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnInfEntradaFecha.FlatAppearance.BorderSize = 0
        Me.btnInfEntradaFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInfEntradaFecha.Font = New System.Drawing.Font("Raleway SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInfEntradaFecha.ForeColor = System.Drawing.Color.White
        Me.btnInfEntradaFecha.Location = New System.Drawing.Point(32, 383)
        Me.btnInfEntradaFecha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnInfEntradaFecha.Name = "btnInfEntradaFecha"
        Me.btnInfEntradaFecha.Size = New System.Drawing.Size(177, 67)
        Me.btnInfEntradaFecha.TabIndex = 14
        Me.btnInfEntradaFecha.Text = "Informe por fecha"
        Me.btnInfEntradaFecha.UseVisualStyleBackColor = False
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dtpFechaInicio.BorderRadius = 0
        Me.dtpFechaInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFechaInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpFechaInicio.FormatCustom = Nothing
        Me.dtpFechaInicio.Location = New System.Drawing.Point(234, 383)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(304, 25)
        Me.dtpFechaInicio.TabIndex = 17
        Me.dtpFechaInicio.Value = New Date(2018, 1, 23, 10, 24, 46, 992)
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dtpFechaFin.BorderRadius = 0
        Me.dtpFechaFin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dtpFechaFin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpFechaFin.FormatCustom = Nothing
        Me.dtpFechaFin.Location = New System.Drawing.Point(234, 425)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(304, 25)
        Me.dtpFechaFin.TabIndex = 18
        Me.dtpFechaFin.Value = New Date(2018, 1, 23, 10, 24, 46, 992)
        '
        'Line1
        '
        Me.Line1.Location = New System.Drawing.Point(86, 308)
        Me.Line1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Line1.Name = "Line1"
        Me.Line1.Size = New System.Drawing.Size(396, 8)
        Me.Line1.TabIndex = 19
        Me.Line1.Text = "Line1"
        '
        'ventanaInformes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(568, 564)
        Me.Controls.Add(Me.Line1)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.btnInfEntradaFecha)
        Me.Controls.Add(Me.btnInformeStock)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "ventanaInformes"
        Me.Text = "ventanaInformes"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnInformeStock As Button
    Friend WithEvents btnInfEntradaFecha As Button
    Friend WithEvents dtpFechaInicio As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents dtpFechaFin As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Line1 As DevComponents.DotNetBar.Controls.Line
End Class
