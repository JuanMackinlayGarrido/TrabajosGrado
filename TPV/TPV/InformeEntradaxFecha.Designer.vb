<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InformeEntradaxFecha
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
        Me.DsInformeEntradaFecha = New TPV.dsInformeEntradaFecha()
        Me.Informe_entrada_por_fechaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Informe_entrada_por_fechaTableAdapter = New TPV.dsInformeEntradaFechaTableAdapters.informe_entrada_por_fechaTableAdapter()
        Me.TableAdapterManager = New TPV.dsInformeEntradaFechaTableAdapters.TableAdapterManager()
        Me.CRWInformeEntradaFecha = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.DsInformeEntradaFecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Informe_entrada_por_fechaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsInformeEntradaFecha
        '
        Me.DsInformeEntradaFecha.DataSetName = "dsInformeEntradaFecha"
        Me.DsInformeEntradaFecha.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Informe_entrada_por_fechaBindingSource
        '
        Me.Informe_entrada_por_fechaBindingSource.DataMember = "informe_entrada_por_fecha"
        Me.Informe_entrada_por_fechaBindingSource.DataSource = Me.DsInformeEntradaFecha
        '
        'Informe_entrada_por_fechaTableAdapter
        '
        Me.Informe_entrada_por_fechaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = TPV.dsInformeEntradaFechaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CRWInformeEntradaFecha
        '
        Me.CRWInformeEntradaFecha.ActiveViewIndex = -1
        Me.CRWInformeEntradaFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRWInformeEntradaFecha.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRWInformeEntradaFecha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRWInformeEntradaFecha.Location = New System.Drawing.Point(0, 0)
        Me.CRWInformeEntradaFecha.Name = "CRWInformeEntradaFecha"
        Me.CRWInformeEntradaFecha.Size = New System.Drawing.Size(408, 350)
        Me.CRWInformeEntradaFecha.TabIndex = 0
        '
        'InformeEntradaxFecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 350)
        Me.Controls.Add(Me.CRWInformeEntradaFecha)
        Me.Name = "InformeEntradaxFecha"
        Me.Text = "InformeEntradaxFecha"
        CType(Me.DsInformeEntradaFecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Informe_entrada_por_fechaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DsInformeEntradaFecha As dsInformeEntradaFecha
    Friend WithEvents Informe_entrada_por_fechaBindingSource As BindingSource
    Friend WithEvents Informe_entrada_por_fechaTableAdapter As dsInformeEntradaFechaTableAdapters.informe_entrada_por_fechaTableAdapter
    Friend WithEvents TableAdapterManager As dsInformeEntradaFechaTableAdapters.TableAdapterManager
    Friend WithEvents CRWInformeEntradaFecha As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
