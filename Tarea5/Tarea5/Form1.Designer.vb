<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lbl_01 = New System.Windows.Forms.Label()
        Me.lbl_02 = New System.Windows.Forms.Label()
        Me.lbl_03 = New System.Windows.Forms.Label()
        Me.lbl_fct = New System.Windows.Forms.Label()
        Me.lbl_mult = New System.Windows.Forms.Label()
        Me.txt_num = New System.Windows.Forms.TextBox()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_01
        '
        Me.lbl_01.AutoSize = True
        Me.lbl_01.Font = New System.Drawing.Font("Acumin Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_01.Location = New System.Drawing.Point(12, 9)
        Me.lbl_01.Name = "lbl_01"
        Me.lbl_01.Size = New System.Drawing.Size(279, 25)
        Me.lbl_01.TabIndex = 0
        Me.lbl_01.Text = "Ingrese un numero para iniciar:"
        '
        'lbl_02
        '
        Me.lbl_02.AutoSize = True
        Me.lbl_02.Font = New System.Drawing.Font("Acumin Pro", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_02.Location = New System.Drawing.Point(23, 167)
        Me.lbl_02.Name = "lbl_02"
        Me.lbl_02.Size = New System.Drawing.Size(310, 21)
        Me.lbl_02.TabIndex = 1
        Me.lbl_02.Text = "Los multiplos de 4 dentro del factorial son:"
        '
        'lbl_03
        '
        Me.lbl_03.AutoSize = True
        Me.lbl_03.Font = New System.Drawing.Font("Acumin Pro", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_03.Location = New System.Drawing.Point(37, 91)
        Me.lbl_03.Name = "lbl_03"
        Me.lbl_03.Size = New System.Drawing.Size(130, 25)
        Me.lbl_03.TabIndex = 2
        Me.lbl_03.Text = "El factorial es:"
        '
        'lbl_fct
        '
        Me.lbl_fct.AutoSize = True
        Me.lbl_fct.Font = New System.Drawing.Font("Acumin Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_fct.ForeColor = System.Drawing.Color.Navy
        Me.lbl_fct.Location = New System.Drawing.Point(167, 130)
        Me.lbl_fct.Name = "lbl_fct"
        Me.lbl_fct.Size = New System.Drawing.Size(0, 25)
        Me.lbl_fct.TabIndex = 3
        Me.lbl_fct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_mult
        '
        Me.lbl_mult.AutoSize = True
        Me.lbl_mult.Font = New System.Drawing.Font("Acumin Pro", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_mult.ForeColor = System.Drawing.Color.Navy
        Me.lbl_mult.Location = New System.Drawing.Point(167, 208)
        Me.lbl_mult.Name = "lbl_mult"
        Me.lbl_mult.Size = New System.Drawing.Size(0, 25)
        Me.lbl_mult.TabIndex = 4
        Me.lbl_mult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_num
        '
        Me.txt_num.Font = New System.Drawing.Font("Acumin Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.txt_num.Location = New System.Drawing.Point(27, 44)
        Me.txt_num.Name = "txt_num"
        Me.txt_num.Size = New System.Drawing.Size(140, 27)
        Me.txt_num.TabIndex = 5
        Me.txt_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_calcular
        '
        Me.btn_calcular.Font = New System.Drawing.Font("Acumin Pro", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.btn_calcular.Location = New System.Drawing.Point(236, 44)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(97, 28)
        Me.btn_calcular.TabIndex = 6
        Me.btn_calcular.Text = "Calcular !"
        Me.btn_calcular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 261)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.txt_num)
        Me.Controls.Add(Me.lbl_mult)
        Me.Controls.Add(Me.lbl_fct)
        Me.Controls.Add(Me.lbl_03)
        Me.Controls.Add(Me.lbl_02)
        Me.Controls.Add(Me.lbl_01)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "201314707 - Edgar Leiva"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_01 As Label
    Friend WithEvents lbl_02 As Label
    Friend WithEvents lbl_03 As Label
    Friend WithEvents lbl_fct As Label
    Friend WithEvents lbl_mult As Label
    Friend WithEvents txt_num As TextBox
    Friend WithEvents btn_calcular As Button
End Class
