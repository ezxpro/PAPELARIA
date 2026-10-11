<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCliente = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFuncionario = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProdutos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDepartamento = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(780, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastrarToolStripMenuItem
        '
        Me.CadastrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCliente, Me.mnuFuncionario, Me.mnuProdutos, Me.mnuDepartamento})
        Me.CadastrarToolStripMenuItem.Name = "CadastrarToolStripMenuItem"
        Me.CadastrarToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.CadastrarToolStripMenuItem.Text = "Cadastrar"
        '
        'mnuCliente
        '
        Me.mnuCliente.Name = "mnuCliente"
        Me.mnuCliente.Size = New System.Drawing.Size(152, 22)
        Me.mnuCliente.Text = "Clientes"
        '
        'mnuFuncionario
        '
        Me.mnuFuncionario.Name = "mnuFuncionario"
        Me.mnuFuncionario.Size = New System.Drawing.Size(152, 22)
        Me.mnuFuncionario.Text = "Funcionários"
        '
        'mnuProdutos
        '
        Me.mnuProdutos.Name = "mnuProdutos"
        Me.mnuProdutos.Size = New System.Drawing.Size(152, 22)
        Me.mnuProdutos.Text = "Produtos"
        '
        'mnuDepartamento
        '
        Me.mnuDepartamento.Name = "mnuDepartamento"
        Me.mnuDepartamento.Size = New System.Drawing.Size(152, 22)
        Me.mnuDepartamento.Text = "Departamento"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 402)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.Text = "Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CadastrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCliente As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFuncionario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuProdutos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDepartamento As System.Windows.Forms.ToolStripMenuItem
End Class
