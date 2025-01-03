<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLockeySeven
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLockeySeven))
        Me.btnSpin = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.lblNum1 = New System.Windows.Forms.Label()
        Me.lblNum2 = New System.Windows.Forms.Label()
        Me.lblNum3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSpin
        '
        Me.btnSpin.BackColor = System.Drawing.Color.DimGray
        Me.btnSpin.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSpin.Location = New System.Drawing.Point(12, 12)
        Me.btnSpin.Name = "btnSpin"
        Me.btnSpin.Size = New System.Drawing.Size(75, 36)
        Me.btnSpin.TabIndex = 0
        Me.btnSpin.Text = "&Spin"
        Me.btnSpin.UseVisualStyleBackColor = False
        '
        'btnEnd
        '
        Me.btnEnd.BackColor = System.Drawing.Color.DimGray
        Me.btnEnd.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnd.Location = New System.Drawing.Point(12, 54)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 36)
        Me.btnEnd.TabIndex = 1
        Me.btnEnd.Text = "&End"
        Me.btnEnd.UseVisualStyleBackColor = False
        '
        'lblNum1
        '
        Me.lblNum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNum1.Font = New System.Drawing.Font("Cambria", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblNum1.Location = New System.Drawing.Point(107, 12)
        Me.lblNum1.Name = "lblNum1"
        Me.lblNum1.Size = New System.Drawing.Size(100, 78)
        Me.lblNum1.TabIndex = 2
        Me.lblNum1.Text = "0"
        Me.lblNum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNum2
        '
        Me.lblNum2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNum2.Font = New System.Drawing.Font("Cambria", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblNum2.Location = New System.Drawing.Point(230, 12)
        Me.lblNum2.Name = "lblNum2"
        Me.lblNum2.Size = New System.Drawing.Size(100, 78)
        Me.lblNum2.TabIndex = 3
        Me.lblNum2.Text = "0"
        Me.lblNum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNum3
        '
        Me.lblNum3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNum3.Font = New System.Drawing.Font("Cambria", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblNum3.Location = New System.Drawing.Point(351, 12)
        Me.lblNum3.Name = "lblNum3"
        Me.lblNum3.Size = New System.Drawing.Size(100, 78)
        Me.lblNum3.TabIndex = 4
        Me.lblNum3.Text = "0"
        Me.lblNum3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 32)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Luckey Seven"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(218, 118)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(191, 218)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'frmLockeySeven
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Brown
        Me.ClientSize = New System.Drawing.Size(464, 350)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNum3)
        Me.Controls.Add(Me.lblNum2)
        Me.Controls.Add(Me.lblNum1)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnSpin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmLockeySeven"
        Me.Text = "Siete de la Suerte"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSpin As Button
    Friend WithEvents btnEnd As Button
    Friend WithEvents lblNum1 As Label
    Friend WithEvents lblNum2 As Label
    Friend WithEvents lblNum3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
