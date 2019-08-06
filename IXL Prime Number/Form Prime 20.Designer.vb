<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrime20
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrime20))
        Me.lblNo = New System.Windows.Forms.Label()
        Me.lblYes = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblQues1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblSmartScore = New System.Windows.Forms.Label()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblQues2 = New System.Windows.Forms.Label()
        Me.lblQNum = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RibbonGold = New System.Windows.Forms.PictureBox()
        Me.RibbonSilver = New System.Windows.Forms.PictureBox()
        Me.RibbonBronze = New System.Windows.Forms.PictureBox()
        Me.lblWrong = New System.Windows.Forms.Label()
        Me.lblCorrect = New System.Windows.Forms.Label()
        Me.lblCorrectAns = New System.Windows.Forms.Label()
        Me.grpRemmeber = New System.Windows.Forms.GroupBox()
        Me.lblRemember = New System.Windows.Forms.Label()
        Me.grpSolve = New System.Windows.Forms.GroupBox()
        Me.lblSolve = New System.Windows.Forms.Label()
        Me.btnGotIt = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.RibbonGold, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonSilver, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonBronze, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRemmeber.SuspendLayout()
        Me.grpSolve.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNo
        '
        Me.lblNo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblNo.Font = New System.Drawing.Font("Georgia", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNo.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblNo.Location = New System.Drawing.Point(157, 177)
        Me.lblNo.Name = "lblNo"
        Me.lblNo.Size = New System.Drawing.Size(70, 38)
        Me.lblNo.TabIndex = 5
        Me.lblNo.Text = "&No"
        Me.lblNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblYes
        '
        Me.lblYes.BackColor = System.Drawing.Color.LightSteelBlue
        Me.lblYes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblYes.Font = New System.Drawing.Font("Georgia", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYes.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblYes.Location = New System.Drawing.Point(58, 177)
        Me.lblYes.Name = "lblYes"
        Me.lblYes.Size = New System.Drawing.Size(65, 38)
        Me.lblYes.TabIndex = 4
        Me.lblYes.Text = "&Yes"
        Me.lblYes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.Font = New System.Drawing.Font("Georgia", 12.0!)
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(96, 253)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(80, 39)
        Me.btnSubmit.TabIndex = 6
        Me.btnSubmit.Text = "&Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        Me.btnSubmit.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.LightGray
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "HH  MM  SS"
        '
        'lblQues1
        '
        Me.lblQues1.AutoSize = True
        Me.lblQues1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQues1.ForeColor = System.Drawing.Color.White
        Me.lblQues1.Location = New System.Drawing.Point(34, 127)
        Me.lblQues1.Name = "lblQues1"
        Me.lblQues1.Size = New System.Drawing.Size(22, 20)
        Me.lblQues1.TabIndex = 1
        Me.lblQues1.Text = "Is"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.OrangeRed
        Me.Label6.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(15, 259)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Out of 100"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSmartScore
        '
        Me.lblSmartScore.BackColor = System.Drawing.Color.Gainsboro
        Me.lblSmartScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSmartScore.Location = New System.Drawing.Point(15, 277)
        Me.lblSmartScore.Name = "lblSmartScore"
        Me.lblSmartScore.Size = New System.Drawing.Size(103, 58)
        Me.lblSmartScore.TabIndex = 7
        Me.lblSmartScore.Text = "0"
        Me.lblSmartScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCount
        '
        Me.lblCount.BackColor = System.Drawing.Color.Gainsboro
        Me.lblCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(15, 59)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(103, 62)
        Me.lblCount.TabIndex = 1
        Me.lblCount.Text = "0"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(15, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 38)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Time elapsed"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Green
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Questions Answered"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(98, 14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(204, 45)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(14, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(78, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'lblTimer
        '
        Me.lblTimer.BackColor = System.Drawing.Color.Gainsboro
        Me.lblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblTimer.Location = New System.Drawing.Point(15, 170)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(103, 59)
        Me.lblTimer.TabIndex = 3
        Me.lblTimer.Text = "00:00:00"
        Me.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.OrangeRed
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(15, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "SmartScore"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblQues2
        '
        Me.lblQues2.AutoSize = True
        Me.lblQues2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQues2.ForeColor = System.Drawing.Color.White
        Me.lblQues2.Location = New System.Drawing.Point(79, 126)
        Me.lblQues2.Name = "lblQues2"
        Me.lblQues2.Size = New System.Drawing.Size(129, 20)
        Me.lblQues2.TabIndex = 3
        Me.lblQues2.Text = "a Prime number?"
        '
        'lblQNum
        '
        Me.lblQNum.BackColor = System.Drawing.Color.Transparent
        Me.lblQNum.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQNum.ForeColor = System.Drawing.Color.White
        Me.lblQNum.Location = New System.Drawing.Point(55, 126)
        Me.lblQNum.Name = "lblQNum"
        Me.lblQNum.Size = New System.Drawing.Size(27, 21)
        Me.lblQNum.TabIndex = 2
        Me.lblQNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Yellow
        Me.GroupBox1.Location = New System.Drawing.Point(21, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 70)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RibbonGold)
        Me.GroupBox2.Controls.Add(Me.RibbonSilver)
        Me.GroupBox2.Controls.Add(Me.RibbonBronze)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblSmartScore)
        Me.GroupBox2.Controls.Add(Me.lblCount)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lblTimer)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Location = New System.Drawing.Point(436, 83)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(133, 408)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'RibbonGold
        '
        Me.RibbonGold.BackColor = System.Drawing.Color.Transparent
        Me.RibbonGold.Image = CType(resources.GetObject("RibbonGold.Image"), System.Drawing.Image)
        Me.RibbonGold.Location = New System.Drawing.Point(88, 338)
        Me.RibbonGold.Name = "RibbonGold"
        Me.RibbonGold.Size = New System.Drawing.Size(30, 55)
        Me.RibbonGold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RibbonGold.TabIndex = 47
        Me.RibbonGold.TabStop = False
        Me.RibbonGold.Visible = False
        '
        'RibbonSilver
        '
        Me.RibbonSilver.BackColor = System.Drawing.Color.Transparent
        Me.RibbonSilver.Image = CType(resources.GetObject("RibbonSilver.Image"), System.Drawing.Image)
        Me.RibbonSilver.Location = New System.Drawing.Point(52, 338)
        Me.RibbonSilver.Name = "RibbonSilver"
        Me.RibbonSilver.Size = New System.Drawing.Size(30, 55)
        Me.RibbonSilver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RibbonSilver.TabIndex = 46
        Me.RibbonSilver.TabStop = False
        Me.RibbonSilver.Visible = False
        '
        'RibbonBronze
        '
        Me.RibbonBronze.BackColor = System.Drawing.Color.Transparent
        Me.RibbonBronze.Image = CType(resources.GetObject("RibbonBronze.Image"), System.Drawing.Image)
        Me.RibbonBronze.Location = New System.Drawing.Point(15, 338)
        Me.RibbonBronze.Name = "RibbonBronze"
        Me.RibbonBronze.Size = New System.Drawing.Size(30, 55)
        Me.RibbonBronze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RibbonBronze.TabIndex = 45
        Me.RibbonBronze.TabStop = False
        Me.RibbonBronze.Visible = False
        '
        'lblWrong
        '
        Me.lblWrong.AutoSize = True
        Me.lblWrong.Font = New System.Drawing.Font("Georgia", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWrong.ForeColor = System.Drawing.Color.Red
        Me.lblWrong.Location = New System.Drawing.Point(26, 286)
        Me.lblWrong.Name = "lblWrong"
        Me.lblWrong.Size = New System.Drawing.Size(177, 21)
        Me.lblWrong.TabIndex = 8
        Me.lblWrong.Text = "Incorrect answer!"
        Me.lblWrong.Visible = False
        '
        'lblCorrect
        '
        Me.lblCorrect.AutoSize = True
        Me.lblCorrect.Font = New System.Drawing.Font("Georgia", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrect.ForeColor = System.Drawing.Color.Gold
        Me.lblCorrect.Location = New System.Drawing.Point(49, 321)
        Me.lblCorrect.Name = "lblCorrect"
        Me.lblCorrect.Size = New System.Drawing.Size(115, 18)
        Me.lblCorrect.TabIndex = 9
        Me.lblCorrect.Text = "Right answer is "
        Me.lblCorrect.Visible = False
        '
        'lblCorrectAns
        '
        Me.lblCorrectAns.Font = New System.Drawing.Font("Georgia", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrectAns.ForeColor = System.Drawing.Color.Gold
        Me.lblCorrectAns.Location = New System.Drawing.Point(159, 320)
        Me.lblCorrectAns.Name = "lblCorrectAns"
        Me.lblCorrectAns.Size = New System.Drawing.Size(44, 21)
        Me.lblCorrectAns.TabIndex = 10
        Me.lblCorrectAns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCorrectAns.Visible = False
        '
        'grpRemmeber
        '
        Me.grpRemmeber.Controls.Add(Me.lblRemember)
        Me.grpRemmeber.Font = New System.Drawing.Font("Georgia", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRemmeber.ForeColor = System.Drawing.Color.Gold
        Me.grpRemmeber.Location = New System.Drawing.Point(52, 349)
        Me.grpRemmeber.Name = "grpRemmeber"
        Me.grpRemmeber.Size = New System.Drawing.Size(300, 82)
        Me.grpRemmeber.TabIndex = 11
        Me.grpRemmeber.TabStop = False
        Me.grpRemmeber.Text = "Remember"
        Me.grpRemmeber.Visible = False
        '
        'lblRemember
        '
        Me.lblRemember.Font = New System.Drawing.Font("Georgia", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemember.ForeColor = System.Drawing.Color.White
        Me.lblRemember.Location = New System.Drawing.Point(23, 32)
        Me.lblRemember.Name = "lblRemember"
        Me.lblRemember.Size = New System.Drawing.Size(271, 47)
        Me.lblRemember.TabIndex = 0
        Me.lblRemember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpSolve
        '
        Me.grpSolve.Controls.Add(Me.lblSolve)
        Me.grpSolve.Font = New System.Drawing.Font("Georgia", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSolve.ForeColor = System.Drawing.Color.Gold
        Me.grpSolve.Location = New System.Drawing.Point(52, 437)
        Me.grpSolve.Name = "grpSolve"
        Me.grpSolve.Size = New System.Drawing.Size(300, 78)
        Me.grpSolve.TabIndex = 12
        Me.grpSolve.TabStop = False
        Me.grpSolve.Text = "Solve"
        Me.grpSolve.Visible = False
        '
        'lblSolve
        '
        Me.lblSolve.Font = New System.Drawing.Font("Georgia", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSolve.ForeColor = System.Drawing.Color.White
        Me.lblSolve.Location = New System.Drawing.Point(23, 30)
        Me.lblSolve.Name = "lblSolve"
        Me.lblSolve.Size = New System.Drawing.Size(271, 45)
        Me.lblSolve.TabIndex = 0
        Me.lblSolve.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnGotIt
        '
        Me.btnGotIt.BackColor = System.Drawing.Color.SlateGray
        Me.btnGotIt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGotIt.Font = New System.Drawing.Font("Georgia", 12.0!)
        Me.btnGotIt.ForeColor = System.Drawing.Color.Gold
        Me.btnGotIt.Location = New System.Drawing.Point(30, 532)
        Me.btnGotIt.Name = "btnGotIt"
        Me.btnGotIt.Size = New System.Drawing.Size(80, 39)
        Me.btnGotIt.TabIndex = 13
        Me.btnGotIt.Text = "&Got it"
        Me.btnGotIt.UseVisualStyleBackColor = False
        Me.btnGotIt.Visible = False
        '
        'frmPrime20
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(581, 585)
        Me.Controls.Add(Me.btnGotIt)
        Me.Controls.Add(Me.grpSolve)
        Me.Controls.Add(Me.grpRemmeber)
        Me.Controls.Add(Me.lblCorrectAns)
        Me.Controls.Add(Me.lblCorrect)
        Me.Controls.Add(Me.lblWrong)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblQNum)
        Me.Controls.Add(Me.lblQues2)
        Me.Controls.Add(Me.lblNo)
        Me.Controls.Add(Me.lblYes)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblQues1)
        Me.Name = "frmPrime20"
        Me.Text = "IXL Prime Up to 20"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.RibbonGold, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonSilver, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonBronze, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRemmeber.ResumeLayout(False)
        Me.grpSolve.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNo As Label
    Friend WithEvents lblYes As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblQues1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblSmartScore As Label
    Friend WithEvents lblCount As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblTimer As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblQues2 As Label
    Friend WithEvents lblQNum As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RibbonBronze As PictureBox
    Friend WithEvents RibbonGold As PictureBox
    Friend WithEvents RibbonSilver As PictureBox
    Friend WithEvents lblWrong As Label
    Friend WithEvents lblCorrect As Label
    Friend WithEvents lblCorrectAns As Label
    Friend WithEvents grpRemmeber As GroupBox
    Friend WithEvents lblRemember As Label
    Friend WithEvents grpSolve As GroupBox
    Friend WithEvents lblSolve As Label
    Friend WithEvents btnGotIt As Button
End Class
