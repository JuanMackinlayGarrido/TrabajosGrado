<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MsgboxPersonalizado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MsgboxPersonalizado))
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.pbAdvertencia = New System.Windows.Forms.PictureBox()
        Me.pbCorrecto = New System.Windows.Forms.PictureBox()
        Me.pbError = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.pbAdvertencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCorrecto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblMensaje
        '
        Me.lblMensaje.AutoSize = True
        Me.lblMensaje.Font = New System.Drawing.Font("Raleway", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.ForeColor = System.Drawing.Color.Black
        Me.lblMensaje.Location = New System.Drawing.Point(6, 56)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(71, 24)
        Me.lblMensaje.TabIndex = 0
        Me.lblMensaje.Text = "Label1"
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnAceptar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Raleway SemiBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Location = New System.Drawing.Point(60, 3)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(79, 33)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'pbAdvertencia
        '
        Me.pbAdvertencia.BackgroundImage = CType(resources.GetObject("pbAdvertencia.BackgroundImage"), System.Drawing.Image)
        Me.pbAdvertencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbAdvertencia.Location = New System.Drawing.Point(4, 6)
        Me.pbAdvertencia.Name = "pbAdvertencia"
        Me.pbAdvertencia.Size = New System.Drawing.Size(34, 30)
        Me.pbAdvertencia.TabIndex = 3
        Me.pbAdvertencia.TabStop = False
        Me.pbAdvertencia.Visible = False
        '
        'pbCorrecto
        '
        Me.pbCorrecto.BackgroundImage = CType(resources.GetObject("pbCorrecto.BackgroundImage"), System.Drawing.Image)
        Me.pbCorrecto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbCorrecto.Location = New System.Drawing.Point(4, 6)
        Me.pbCorrecto.Name = "pbCorrecto"
        Me.pbCorrecto.Size = New System.Drawing.Size(34, 30)
        Me.pbCorrecto.TabIndex = 4
        Me.pbCorrecto.TabStop = False
        Me.pbCorrecto.Visible = False
        '
        'pbError
        '
        Me.pbError.BackgroundImage = CType(resources.GetObject("pbError.BackgroundImage"), System.Drawing.Image)
        Me.pbError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbError.Location = New System.Drawing.Point(4, 6)
        Me.pbError.Name = "pbError"
        Me.pbError.Size = New System.Drawing.Size(34, 30)
        Me.pbError.TabIndex = 5
        Me.pbError.TabStop = False
        Me.pbError.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.57143!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.36453!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.55665!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnAceptar, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 108)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(203, 39)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'MsgboxPersonalizado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(203, 147)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.pbError)
        Me.Controls.Add(Me.pbCorrecto)
        Me.Controls.Add(Me.pbAdvertencia)
        Me.Controls.Add(Me.lblMensaje)
        Me.Font = New System.Drawing.Font("Raleway", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MsgboxPersonalizado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MsgboxPersonalizado"
        CType(Me.pbAdvertencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCorrecto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMensaje As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents pbAdvertencia As PictureBox
    Friend WithEvents pbCorrecto As PictureBox
    Friend WithEvents pbError As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
