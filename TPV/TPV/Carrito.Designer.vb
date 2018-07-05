<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Carrito
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
        Me.DataGridCarrito = New System.Windows.Forms.DataGridView()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.btnEntrada = New System.Windows.Forms.Button()
        Me.btnSalida = New System.Windows.Forms.Button()
        CType(Me.DataGridCarrito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridCarrito
        '
        Me.DataGridCarrito.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridCarrito.Location = New System.Drawing.Point(41, 70)
        Me.DataGridCarrito.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridCarrito.Name = "DataGridCarrito"
        Me.DataGridCarrito.Size = New System.Drawing.Size(192, 475)
        Me.DataGridCarrito.TabIndex = 7
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(143, 25)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(92, 24)
        Me.lblCantidad.TabIndex = 6
        Me.lblCantidad.Text = "Cantidad"
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducto.Location = New System.Drawing.Point(39, 25)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(94, 24)
        Me.lblProducto.TabIndex = 5
        Me.lblProducto.Text = "Producto"
        '
        'btnEntrada
        '
        Me.btnEntrada.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnEntrada.FlatAppearance.BorderSize = 0
        Me.btnEntrada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnEntrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntrada.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntrada.ForeColor = System.Drawing.Color.White
        Me.btnEntrada.Location = New System.Drawing.Point(30, 568)
        Me.btnEntrada.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEntrada.Name = "btnEntrada"
        Me.btnEntrada.Size = New System.Drawing.Size(100, 55)
        Me.btnEntrada.TabIndex = 8
        Me.btnEntrada.Text = "Entrada"
        Me.btnEntrada.UseVisualStyleBackColor = False
        '
        'btnSalida
        '
        Me.btnSalida.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnSalida.FlatAppearance.BorderSize = 0
        Me.btnSalida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnSalida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.btnSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalida.Font = New System.Drawing.Font("Raleway", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalida.ForeColor = System.Drawing.Color.White
        Me.btnSalida.Location = New System.Drawing.Point(144, 568)
        Me.btnSalida.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalida.Name = "btnSalida"
        Me.btnSalida.Size = New System.Drawing.Size(100, 55)
        Me.btnSalida.TabIndex = 9
        Me.btnSalida.Text = "Salida"
        Me.btnSalida.UseVisualStyleBackColor = False
        '
        'Carrito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(275, 665)
        Me.Controls.Add(Me.btnSalida)
        Me.Controls.Add(Me.btnEntrada)
        Me.Controls.Add(Me.DataGridCarrito)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.lblProducto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Carrito"
        Me.Text = "Carrito"
        CType(Me.DataGridCarrito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridCarrito As DataGridView
    Friend WithEvents lblCantidad As Label
    Friend WithEvents lblProducto As Label
    Friend WithEvents btnEntrada As Button
    Friend WithEvents btnSalida As Button
End Class
