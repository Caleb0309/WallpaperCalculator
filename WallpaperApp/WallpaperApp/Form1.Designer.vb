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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbLength = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbWidth = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbHeight = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbRollCoverage = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSingleRolls = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Length (feet):"
        '
        'cbLength
        '
        Me.cbLength.FormattingEnabled = True
        Me.cbLength.Location = New System.Drawing.Point(26, 72)
        Me.cbLength.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbLength.Name = "cbLength"
        Me.cbLength.Size = New System.Drawing.Size(96, 23)
        Me.cbLength.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 101)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Width (feet): "
        '
        'cbWidth
        '
        Me.cbWidth.FormattingEnabled = True
        Me.cbWidth.Location = New System.Drawing.Point(26, 119)
        Me.cbWidth.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbWidth.Name = "cbWidth"
        Me.cbWidth.Size = New System.Drawing.Size(96, 23)
        Me.cbWidth.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 146)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Height (feet):"
        '
        'cbHeight
        '
        Me.cbHeight.FormattingEnabled = True
        Me.cbHeight.Location = New System.Drawing.Point(26, 164)
        Me.cbHeight.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbHeight.Name = "cbHeight"
        Me.cbHeight.Size = New System.Drawing.Size(96, 23)
        Me.cbHeight.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 197)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Roll coverage (sqFt):"
        '
        'cbRollCoverage
        '
        Me.cbRollCoverage.FormattingEnabled = True
        Me.cbRollCoverage.Location = New System.Drawing.Point(26, 215)
        Me.cbRollCoverage.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cbRollCoverage.Name = "cbRollCoverage"
        Me.cbRollCoverage.Size = New System.Drawing.Size(96, 23)
        Me.cbRollCoverage.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(341, 127)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Single rolls:"
        '
        'lblSingleRolls
        '
        Me.lblSingleRolls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSingleRolls.Location = New System.Drawing.Point(293, 156)
        Me.lblSingleRolls.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSingleRolls.Name = "lblSingleRolls"
        Me.lblSingleRolls.Size = New System.Drawing.Size(158, 31)
        Me.lblSingleRolls.TabIndex = 2
        Me.lblSingleRolls.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(264, 207)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(108, 31)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(380, 207)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(108, 31)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(613, 333)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblSingleRolls)
        Me.Controls.Add(Me.cbRollCoverage)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbHeight)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbWidth)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbLength)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wallpaper App "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbLength As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbWidth As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbHeight As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbRollCoverage As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblSingleRolls As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button


End Class
