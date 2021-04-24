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
        Me.gpbOperacion = New System.Windows.Forms.GroupBox()
        Me.rbMult = New System.Windows.Forms.RadioButton()
        Me.rbResta = New System.Windows.Forms.RadioButton()
        Me.rbSuma = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboNumeros = New System.Windows.Forms.ComboBox()
        Me.lsbNumeros = New System.Windows.Forms.ListBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.gpbOperacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpbOperacion
        '
        Me.gpbOperacion.Controls.Add(Me.rbMult)
        Me.gpbOperacion.Controls.Add(Me.rbResta)
        Me.gpbOperacion.Controls.Add(Me.rbSuma)
        Me.gpbOperacion.Location = New System.Drawing.Point(28, 43)
        Me.gpbOperacion.Name = "gpbOperacion"
        Me.gpbOperacion.Size = New System.Drawing.Size(153, 155)
        Me.gpbOperacion.TabIndex = 0
        Me.gpbOperacion.TabStop = False
        Me.gpbOperacion.Text = "Operación"
        '
        'rbMult
        '
        Me.rbMult.AutoSize = True
        Me.rbMult.Location = New System.Drawing.Point(19, 117)
        Me.rbMult.Name = "rbMult"
        Me.rbMult.Size = New System.Drawing.Size(101, 19)
        Me.rbMult.TabIndex = 2
        Me.rbMult.TabStop = True
        Me.rbMult.Text = "Multiplicación"
        Me.rbMult.UseVisualStyleBackColor = True
        '
        'rbResta
        '
        Me.rbResta.AutoSize = True
        Me.rbResta.Location = New System.Drawing.Point(19, 74)
        Me.rbResta.Name = "rbResta"
        Me.rbResta.Size = New System.Drawing.Size(53, 19)
        Me.rbResta.TabIndex = 1
        Me.rbResta.TabStop = True
        Me.rbResta.Text = "Resta"
        Me.rbResta.UseVisualStyleBackColor = True
        '
        'rbSuma
        '
        Me.rbSuma.AutoSize = True
        Me.rbSuma.Location = New System.Drawing.Point(19, 31)
        Me.rbSuma.Name = "rbSuma"
        Me.rbSuma.Size = New System.Drawing.Size(55, 19)
        Me.rbSuma.TabIndex = 0
        Me.rbSuma.TabStop = True
        Me.rbSuma.Text = "Suma"
        Me.rbSuma.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(231, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tabla"
        '
        'cboNumeros
        '
        Me.cboNumeros.FormattingEnabled = True
        Me.cboNumeros.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cboNumeros.Location = New System.Drawing.Point(231, 70)
        Me.cboNumeros.Name = "cboNumeros"
        Me.cboNumeros.Size = New System.Drawing.Size(121, 23)
        Me.cboNumeros.TabIndex = 2
        '
        'lsbNumeros
        '
        Me.lsbNumeros.FormattingEnabled = True
        Me.lsbNumeros.ItemHeight = 15
        Me.lsbNumeros.Location = New System.Drawing.Point(231, 117)
        Me.lsbNumeros.Name = "lsbNumeros"
        Me.lsbNumeros.Size = New System.Drawing.Size(120, 199)
        Me.lsbNumeros.TabIndex = 3
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(28, 215)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(153, 26)
        Me.btnCalcular.TabIndex = 4
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(28, 264)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(153, 23)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 339)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.lsbNumeros)
        Me.Controls.Add(Me.cboNumeros)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gpbOperacion)
        Me.Name = "Form1"
        Me.Text = "Operaciones"
        Me.gpbOperacion.ResumeLayout(False)
        Me.gpbOperacion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gpbOperacion As GroupBox
    Friend WithEvents rbMult As RadioButton
    Friend WithEvents rbResta As RadioButton
    Friend WithEvents rbSuma As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents cboNumeros As ComboBox
    Friend WithEvents lsbNumeros As ListBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
End Class
