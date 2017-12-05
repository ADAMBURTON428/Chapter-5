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
        Me.txtSideC = New System.Windows.Forms.TextBox()
        Me.txtSideB = New System.Windows.Forms.TextBox()
        Me.txtSideA = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radioC = New System.Windows.Forms.RadioButton()
        Me.radioB = New System.Windows.Forms.RadioButton()
        Me.radioA = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSideC
        '
        Me.txtSideC.Location = New System.Drawing.Point(240, 205)
        Me.txtSideC.Name = "txtSideC"
        Me.txtSideC.Size = New System.Drawing.Size(100, 20)
        Me.txtSideC.TabIndex = 9
        '
        'txtSideB
        '
        Me.txtSideB.Location = New System.Drawing.Point(240, 164)
        Me.txtSideB.Name = "txtSideB"
        Me.txtSideB.Size = New System.Drawing.Size(100, 20)
        Me.txtSideB.TabIndex = 8
        '
        'txtSideA
        '
        Me.txtSideA.Location = New System.Drawing.Point(240, 118)
        Me.txtSideA.Name = "txtSideA"
        Me.txtSideA.Size = New System.Drawing.Size(100, 20)
        Me.txtSideA.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radioC)
        Me.GroupBox1.Controls.Add(Me.radioB)
        Me.GroupBox1.Controls.Add(Me.radioA)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(156, 163)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'radioC
        '
        Me.radioC.AutoSize = True
        Me.radioC.Location = New System.Drawing.Point(24, 122)
        Me.radioC.Name = "radioC"
        Me.radioC.Size = New System.Drawing.Size(99, 17)
        Me.radioC.TabIndex = 2
        Me.radioC.TabStop = True
        Me.radioC.Text = "Solve for C side"
        Me.radioC.UseVisualStyleBackColor = True
        '
        'radioB
        '
        Me.radioB.AutoSize = True
        Me.radioB.Location = New System.Drawing.Point(24, 82)
        Me.radioB.Name = "radioB"
        Me.radioB.Size = New System.Drawing.Size(99, 17)
        Me.radioB.TabIndex = 1
        Me.radioB.TabStop = True
        Me.radioB.Text = "Solve for B side"
        Me.radioB.UseVisualStyleBackColor = True
        '
        'radioA
        '
        Me.radioA.AutoSize = True
        Me.radioA.Location = New System.Drawing.Point(24, 38)
        Me.radioA.Name = "radioA"
        Me.radioA.Size = New System.Drawing.Size(104, 17)
        Me.radioA.TabIndex = 0
        Me.radioA.TabStop = True
        Me.radioA.Text = "Solve For A Side"
        Me.radioA.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(194, 291)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 400)
        Me.Controls.Add(Me.txtSideC)
        Me.Controls.Add(Me.txtSideB)
        Me.Controls.Add(Me.txtSideA)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSideC As System.Windows.Forms.TextBox
    Friend WithEvents txtSideB As System.Windows.Forms.TextBox
    Friend WithEvents txtSideA As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radioC As System.Windows.Forms.RadioButton
    Friend WithEvents radioB As System.Windows.Forms.RadioButton
    Friend WithEvents radioA As System.Windows.Forms.RadioButton
    Friend WithEvents btnCalculate As System.Windows.Forms.Button

End Class
