<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.panelFijo = New System.Windows.Forms.Panel()
        Me.btnAsociacion = New System.Windows.Forms.Button()
        Me.btnPrincipal = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.panelPrincipal = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.panelCarrito = New System.Windows.Forms.Panel()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.panelFijo.SuspendLayout()
        Me.panelPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelFijo
        '
        Me.panelFijo.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.panelFijo.Controls.Add(Me.btnAsociacion)
        Me.panelFijo.Controls.Add(Me.btnPrincipal)
        Me.panelFijo.Controls.Add(Me.Panel1)
        Me.panelFijo.Controls.Add(Me.btnConfirmar)
        Me.panelFijo.Controls.Add(Me.btnAdmin)
        Me.panelFijo.Controls.Add(Me.btnModificar)
        Me.panelFijo.Controls.Add(Me.btnEliminar)
        Me.panelFijo.Controls.Add(Me.btnAgregar)
        Me.panelFijo.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelFijo.Location = New System.Drawing.Point(0, 0)
        Me.panelFijo.Name = "panelFijo"
        Me.panelFijo.Size = New System.Drawing.Size(272, 695)
        Me.panelFijo.TabIndex = 0
        '
        'btnAsociacion
        '
        Me.btnAsociacion.BackColor = System.Drawing.Color.Transparent
        Me.btnAsociacion.FlatAppearance.BorderSize = 0
        Me.btnAsociacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnAsociacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnAsociacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAsociacion.Font = New System.Drawing.Font("Raleway Medium", 9.6!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsociacion.ForeColor = System.Drawing.Color.White
        Me.btnAsociacion.Image = CType(resources.GetObject("btnAsociacion.Image"), System.Drawing.Image)
        Me.btnAsociacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAsociacion.Location = New System.Drawing.Point(0, 359)
        Me.btnAsociacion.Name = "btnAsociacion"
        Me.btnAsociacion.Size = New System.Drawing.Size(272, 71)
        Me.btnAsociacion.TabIndex = 8
        Me.btnAsociacion.Text = "Asociaciones"
        Me.btnAsociacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAsociacion.UseVisualStyleBackColor = False
        '
        'btnPrincipal
        '
        Me.btnPrincipal.BackColor = System.Drawing.Color.Transparent
        Me.btnPrincipal.FlatAppearance.BorderSize = 0
        Me.btnPrincipal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnPrincipal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrincipal.Font = New System.Drawing.Font("Raleway Medium", 9.6!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrincipal.ForeColor = System.Drawing.Color.White
        Me.btnPrincipal.Image = CType(resources.GetObject("btnPrincipal.Image"), System.Drawing.Image)
        Me.btnPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrincipal.Location = New System.Drawing.Point(0, 39)
        Me.btnPrincipal.Name = "btnPrincipal"
        Me.btnPrincipal.Size = New System.Drawing.Size(272, 75)
        Me.btnPrincipal.TabIndex = 7
        Me.btnPrincipal.Text = "Página principal"
        Me.btnPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrincipal.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(270, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1022, 27)
        Me.Panel1.TabIndex = 6
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.Color.Transparent
        Me.btnConfirmar.FlatAppearance.BorderSize = 0
        Me.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmar.Font = New System.Drawing.Font("Raleway Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.ForeColor = System.Drawing.Color.White
        Me.btnConfirmar.Image = CType(resources.GetObject("btnConfirmar.Image"), System.Drawing.Image)
        Me.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfirmar.Location = New System.Drawing.Point(-2, 613)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(272, 53)
        Me.btnConfirmar.TabIndex = 6
        Me.btnConfirmar.Text = "Salir"
        Me.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'btnAdmin
        '
        Me.btnAdmin.BackColor = System.Drawing.Color.Transparent
        Me.btnAdmin.FlatAppearance.BorderSize = 0
        Me.btnAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdmin.Font = New System.Drawing.Font("Raleway Medium", 9.6!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmin.ForeColor = System.Drawing.Color.White
        Me.btnAdmin.Image = CType(resources.GetObject("btnAdmin.Image"), System.Drawing.Image)
        Me.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdmin.Location = New System.Drawing.Point(0, 436)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(272, 75)
        Me.btnAdmin.TabIndex = 5
        Me.btnAdmin.Text = "Informes"
        Me.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdmin.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.Transparent
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Raleway Medium", 9.6!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(0, 282)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(272, 71)
        Me.btnModificar.TabIndex = 4
        Me.btnModificar.Text = "Modificar Producto"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Raleway Medium", 9.6!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(0, 201)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(272, 75)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar Producto"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Raleway Medium", 9.6!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(0, 120)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(272, 75)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "Agregar Producto"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'panelPrincipal
        '
        Me.panelPrincipal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelPrincipal.Controls.Add(Me.Panel2)
        Me.panelPrincipal.Location = New System.Drawing.Point(270, 0)
        Me.panelPrincipal.Name = "panelPrincipal"
        Me.panelPrincipal.Size = New System.Drawing.Size(758, 695)
        Me.panelPrincipal.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 665)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(758, 30)
        Me.Panel2.TabIndex = 6
        '
        'panelCarrito
        '
        Me.panelCarrito.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelCarrito.Location = New System.Drawing.Point(1027, 0)
        Me.panelCarrito.Name = "panelCarrito"
        Me.panelCarrito.Size = New System.Drawing.Size(275, 665)
        Me.panelCarrito.TabIndex = 2
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 45
        Me.BunifuElipse1.TargetControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1294, 695)
        Me.Controls.Add(Me.panelCarrito)
        Me.Controls.Add(Me.panelPrincipal)
        Me.Controls.Add(Me.panelFijo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TPV Banco de alimentos"
        Me.panelFijo.ResumeLayout(False)
        Me.panelPrincipal.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelFijo As Panel
    Friend WithEvents panelPrincipal As Panel
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnPrincipal As Button
    Friend WithEvents btnAsociacion As Button
    Friend WithEvents panelCarrito As Panel
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
End Class
