<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InformeStock
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
        Me.DSInformeStock = New TPV.DSInformeStock()
        Me.Informe_stockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Informe_stockTableAdapter = New TPV.DSInformeStockTableAdapters.informe_stockTableAdapter()
        Me.TableAdapterManager = New TPV.DSInformeStockTableAdapters.TableAdapterManager()
        Me.CRViewerInformeStock = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        CType(Me.DSInformeStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Informe_stockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DSInformeStock
        '
        Me.DSInformeStock.DataSetName = "DSInformeStock"
        Me.DSInformeStock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Informe_stockBindingSource
        '
        Me.Informe_stockBindingSource.DataMember = "informe_stock"
        Me.Informe_stockBindingSource.DataSource = Me.DSInformeStock
        '
        'Informe_stockTableAdapter
        '
        Me.Informe_stockTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = TPV.DSInformeStockTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CRViewerInformeStock
        '
        Me.CRViewerInformeStock.ActiveViewIndex = -1
        Me.CRViewerInformeStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CRViewerInformeStock.Cursor = System.Windows.Forms.Cursors.Default
        Me.CRViewerInformeStock.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CRViewerInformeStock.Location = New System.Drawing.Point(0, 0)
        Me.CRViewerInformeStock.Name = "CRViewerInformeStock"
        Me.CRViewerInformeStock.Size = New System.Drawing.Size(463, 334)
        Me.CRViewerInformeStock.TabIndex = 0
        '
        'InformeStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 334)
        Me.Controls.Add(Me.CRViewerInformeStock)
        Me.Name = "InformeStock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "InformeStock"
        CType(Me.DSInformeStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Informe_stockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DSInformeStock As DSInformeStock
    Friend WithEvents Informe_stockBindingSource As BindingSource
    Friend WithEvents Informe_stockTableAdapter As DSInformeStockTableAdapters.informe_stockTableAdapter
    Friend WithEvents TableAdapterManager As DSInformeStockTableAdapters.TableAdapterManager
    Friend WithEvents CRViewerInformeStock As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
