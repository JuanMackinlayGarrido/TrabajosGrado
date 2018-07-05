<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Albaran
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
        Me.DsAlbaran = New TPV.dsAlbaran()
        Me.AlbaranBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlbaranTableAdapter = New TPV.dsAlbaranTableAdapters.albaranTableAdapter()
        Me.TableAdapterManager = New TPV.dsAlbaranTableAdapters.TableAdapterManager()
        Me.crvAlbaran = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.DsAlbaran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlbaranBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsAlbaran
        '
        Me.DsAlbaran.DataSetName = "dsAlbaran"
        Me.DsAlbaran.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlbaranBindingSource
        '
        Me.AlbaranBindingSource.DataMember = "albaran"
        Me.AlbaranBindingSource.DataSource = Me.DsAlbaran
        '
        'AlbaranTableAdapter
        '
        Me.AlbaranTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = TPV.dsAlbaranTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'crvAlbaran
        '
        Me.crvAlbaran.ActiveViewIndex = -1
        Me.crvAlbaran.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvAlbaran.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvAlbaran.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvAlbaran.Location = New System.Drawing.Point(0, 0)
        Me.crvAlbaran.Name = "crvAlbaran"
        Me.crvAlbaran.Size = New System.Drawing.Size(763, 488)
        Me.crvAlbaran.TabIndex = 0
        '
        'Albaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 488)
        Me.Controls.Add(Me.crvAlbaran)
        Me.Name = "Albaran"
        Me.Text = "Albaran"
        CType(Me.DsAlbaran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlbaranBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DsAlbaran As dsAlbaran
    Friend WithEvents AlbaranBindingSource As BindingSource
    Friend WithEvents AlbaranTableAdapter As dsAlbaranTableAdapters.albaranTableAdapter
    Friend WithEvents TableAdapterManager As dsAlbaranTableAdapters.TableAdapterManager
    Friend WithEvents crvAlbaran As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
