<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LbID = New System.Windows.Forms.Label()
        Me.LbNome = New System.Windows.Forms.Label()
        Me.LbUtilizador = New System.Windows.Forms.Label()
        Me.LbSenha = New System.Windows.Forms.Label()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.txtUtilizador = New System.Windows.Forms.TextBox()
        Me.TxtSenha = New System.Windows.Forms.TextBox()
        Me.CbNivel = New System.Windows.Forms.ComboBox()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.LbNivel = New System.Windows.Forms.Label()
        Me.BtnReload = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.DgLista = New System.Windows.Forms.DataGridView()
        CType(Me.DgLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LbID
        '
        Me.LbID.AutoSize = True
        Me.LbID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbID.Location = New System.Drawing.Point(36, 51)
        Me.LbID.Name = "LbID"
        Me.LbID.Size = New System.Drawing.Size(28, 20)
        Me.LbID.TabIndex = 0
        Me.LbID.Text = "ID"
        '
        'LbNome
        '
        Me.LbNome.AutoSize = True
        Me.LbNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNome.Location = New System.Drawing.Point(36, 77)
        Me.LbNome.Name = "LbNome"
        Me.LbNome.Size = New System.Drawing.Size(55, 20)
        Me.LbNome.TabIndex = 1
        Me.LbNome.Text = "Nome"
        '
        'LbUtilizador
        '
        Me.LbUtilizador.AutoSize = True
        Me.LbUtilizador.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbUtilizador.Location = New System.Drawing.Point(36, 108)
        Me.LbUtilizador.Name = "LbUtilizador"
        Me.LbUtilizador.Size = New System.Drawing.Size(85, 20)
        Me.LbUtilizador.TabIndex = 2
        Me.LbUtilizador.Text = "Utilizador"
        '
        'LbSenha
        '
        Me.LbSenha.AutoSize = True
        Me.LbSenha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbSenha.Location = New System.Drawing.Point(36, 142)
        Me.LbSenha.Name = "LbSenha"
        Me.LbSenha.Size = New System.Drawing.Size(61, 20)
        Me.LbSenha.TabIndex = 3
        Me.LbSenha.Text = "Senha"
        '
        'TxtNome
        '
        Me.TxtNome.Location = New System.Drawing.Point(190, 77)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(227, 20)
        Me.TxtNome.TabIndex = 4
        '
        'txtUtilizador
        '
        Me.txtUtilizador.Location = New System.Drawing.Point(189, 110)
        Me.txtUtilizador.Name = "txtUtilizador"
        Me.txtUtilizador.Size = New System.Drawing.Size(227, 20)
        Me.txtUtilizador.TabIndex = 5
        '
        'TxtSenha
        '
        Me.TxtSenha.Location = New System.Drawing.Point(189, 144)
        Me.TxtSenha.Name = "TxtSenha"
        Me.TxtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtSenha.Size = New System.Drawing.Size(227, 20)
        Me.TxtSenha.TabIndex = 6
        '
        'CbNivel
        '
        Me.CbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbNivel.FormattingEnabled = True
        Me.CbNivel.Items.AddRange(New Object() {"Equipa ", "Administrador"})
        Me.CbNivel.Location = New System.Drawing.Point(189, 182)
        Me.CbNivel.Name = "CbNivel"
        Me.CbNivel.Size = New System.Drawing.Size(227, 21)
        Me.CbNivel.TabIndex = 7
        '
        'BtnCreate
        '
        Me.BtnCreate.Location = New System.Drawing.Point(425, 73)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(85, 28)
        Me.BtnCreate.TabIndex = 8
        Me.BtnCreate.Text = "Create"
        Me.BtnCreate.UseVisualStyleBackColor = True
        '
        'LbNivel
        '
        Me.LbNivel.AutoSize = True
        Me.LbNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbNivel.Location = New System.Drawing.Point(36, 180)
        Me.LbNivel.Name = "LbNivel"
        Me.LbNivel.Size = New System.Drawing.Size(134, 20)
        Me.LbNivel.TabIndex = 9
        Me.LbNivel.Text = "Nivel de acesso"
        '
        'BtnReload
        '
        Me.BtnReload.Location = New System.Drawing.Point(425, 106)
        Me.BtnReload.Name = "BtnReload"
        Me.BtnReload.Size = New System.Drawing.Size(85, 28)
        Me.BtnReload.TabIndex = 10
        Me.BtnReload.Text = "Reload"
        Me.BtnReload.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(425, 140)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(85, 28)
        Me.BtnUpdate.TabIndex = 11
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(425, 178)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(85, 28)
        Me.BtnDelete.TabIndex = 12
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'DgLista
        '
        Me.DgLista.AllowUserToAddRows = False
        Me.DgLista.AllowUserToDeleteRows = False
        Me.DgLista.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgLista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DgLista.Location = New System.Drawing.Point(12, 237)
        Me.DgLista.Name = "DgLista"
        Me.DgLista.ReadOnly = True
        Me.DgLista.RowHeadersVisible = False
        Me.DgLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgLista.Size = New System.Drawing.Size(543, 201)
        Me.DgLista.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(566, 450)
        Me.Controls.Add(Me.DgLista)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnReload)
        Me.Controls.Add(Me.LbNivel)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.CbNivel)
        Me.Controls.Add(Me.TxtSenha)
        Me.Controls.Add(Me.txtUtilizador)
        Me.Controls.Add(Me.TxtNome)
        Me.Controls.Add(Me.LbSenha)
        Me.Controls.Add(Me.LbUtilizador)
        Me.Controls.Add(Me.LbNome)
        Me.Controls.Add(Me.LbID)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CRUD - Utilizadores"
        CType(Me.DgLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbID As Label
    Friend WithEvents LbNome As Label
    Friend WithEvents LbUtilizador As Label
    Friend WithEvents LbSenha As Label
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents txtUtilizador As TextBox
    Friend WithEvents TxtSenha As TextBox
    Friend WithEvents CbNivel As ComboBox
    Friend WithEvents BtnCreate As Button
    Friend WithEvents LbNivel As Label
    Friend WithEvents BtnReload As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents DgLista As DataGridView
End Class
