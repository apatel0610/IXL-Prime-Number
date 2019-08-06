<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblSelection = New System.Windows.Forms.Label()
        Me.btn100 = New System.Windows.Forms.Button()
        Me.btn20 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Yellow
        Me.GroupBox1.Location = New System.Drawing.Point(20, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 70)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(97, 13)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(204, 45)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'lblSelection
        '
        Me.lblSelection.AutoSize = True
        Me.lblSelection.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelection.ForeColor = System.Drawing.Color.White
        Me.lblSelection.Location = New System.Drawing.Point(92, 135)
        Me.lblSelection.Name = "lblSelection"
        Me.lblSelection.Size = New System.Drawing.Size(172, 25)
        Me.lblSelection.TabIndex = 1
        Me.lblSelection.Text = "Make a selection:"
        '
        'btn100
        '
        Me.btn100.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn100.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn100.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn100.ForeColor = System.Drawing.Color.White
        Me.btn100.Location = New System.Drawing.Point(342, 211)
        Me.btn100.Name = "btn100"
        Me.btn100.Size = New System.Drawing.Size(138, 90)
        Me.btn100.TabIndex = 3
        Me.btn100.Text = "Up to &100"
        Me.btn100.UseVisualStyleBackColor = False
        '
        'btn20
        '
        Me.btn20.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btn20.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn20.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn20.ForeColor = System.Drawing.Color.White
        Me.btn20.Location = New System.Drawing.Point(150, 211)
        Me.btn20.Name = "btn20"
        Me.btn20.Size = New System.Drawing.Size(138, 90)
        Me.btn20.TabIndex = 2
        Me.btn20.Text = "Up to &20"
        Me.btn20.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(581, 455)
        Me.Controls.Add(Me.lblSelection)
        Me.Controls.Add(Me.btn100)
        Me.Controls.Add(Me.btn20)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMain"
        Me.Text = "IXL Prime Number"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblSelection As Label
    Friend WithEvents btn100 As Button
    Friend WithEvents btn20 As Button
End Class
