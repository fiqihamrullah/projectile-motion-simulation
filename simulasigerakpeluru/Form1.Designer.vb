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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnStart = New System.Windows.Forms.Button
        Me.chkhambatanudara = New System.Windows.Forms.CheckBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtDeltaT = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtKoefHambatan = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtSudut = New System.Windows.Forms.TextBox
        Me.txtG = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtV0 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblT = New System.Windows.Forms.Label
        Me.lblVy = New System.Windows.Forms.Label
        Me.lblVx = New System.Windows.Forms.Label
        Me.lblYMax = New System.Windows.Forms.Label
        Me.lblXMax = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.pbSimulasi = New System.Windows.Forms.PictureBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.btnClear = New System.Windows.Forms.Button
        Me.dgvData = New System.Windows.Forms.DataGridView
        Me.ColT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColX = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ColY = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnTutup = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.pbSimulasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Yellow
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(841, 33)
        Me.Panel1.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, -2)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(214, 29)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "> Parameter Input"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnStart)
        Me.GroupBox1.Controls.Add(Me.chkhambatanudara)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtDeltaT)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtKoefHambatan)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtSudut)
        Me.GroupBox1.Controls.Add(Me.txtG)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtV0)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(831, 60)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btnStart
        '
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Location = New System.Drawing.Point(748, 12)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(74, 38)
        Me.btnStart.TabIndex = 8
        Me.btnStart.Text = "<< Start >>"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'chkhambatanudara
        '
        Me.chkhambatanudara.AutoSize = True
        Me.chkhambatanudara.Location = New System.Drawing.Point(635, 26)
        Me.chkhambatanudara.Name = "chkhambatanudara"
        Me.chkhambatanudara.Size = New System.Drawing.Size(107, 17)
        Me.chkhambatanudara.TabIndex = 7
        Me.chkhambatanudara.Text = "Hambatan Udara"
        Me.chkhambatanudara.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(211, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 16)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "m/s"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(89, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "m/s"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(617, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(12, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "s"
        '
        'txtDeltaT
        '
        Me.txtDeltaT.Location = New System.Drawing.Point(550, 24)
        Me.txtDeltaT.Name = "txtDeltaT"
        Me.txtDeltaT.Size = New System.Drawing.Size(61, 20)
        Me.txtDeltaT.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(506, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Delta t"
        '
        'txtKoefHambatan
        '
        Me.txtKoefHambatan.Location = New System.Drawing.Point(438, 24)
        Me.txtKoefHambatan.Name = "txtKoefHambatan"
        Me.txtKoefHambatan.Size = New System.Drawing.Size(61, 20)
        Me.txtKoefHambatan.TabIndex = 4
        Me.txtKoefHambatan.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(360, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Koef Hambatan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(251, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sudut"
        '
        'txtSudut
        '
        Me.txtSudut.Location = New System.Drawing.Point(292, 24)
        Me.txtSudut.Name = "txtSudut"
        Me.txtSudut.Size = New System.Drawing.Size(56, 20)
        Me.txtSudut.TabIndex = 1
        Me.txtSudut.Text = "45"
        '
        'txtG
        '
        Me.txtG.Location = New System.Drawing.Point(154, 23)
        Me.txtG.Name = "txtG"
        Me.txtG.Size = New System.Drawing.Size(56, 20)
        Me.txtG.TabIndex = 1
        Me.txtG.Text = "10"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(135, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "g"
        '
        'txtV0
        '
        Me.txtV0.Location = New System.Drawing.Point(29, 22)
        Me.txtV0.Name = "txtV0"
        Me.txtV0.Size = New System.Drawing.Size(56, 20)
        Me.txtV0.TabIndex = 1
        Me.txtV0.Text = "10"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "V0"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Yellow
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblT)
        Me.Panel2.Controls.Add(Me.lblVy)
        Me.Panel2.Controls.Add(Me.lblVx)
        Me.Panel2.Controls.Add(Me.lblYMax)
        Me.Panel2.Controls.Add(Me.lblXMax)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Location = New System.Drawing.Point(1, 102)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(841, 33)
        Me.Panel2.TabIndex = 0
        '
        'lblT
        '
        Me.lblT.AutoSize = True
        Me.lblT.BackColor = System.Drawing.Color.Black
        Me.lblT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblT.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblT.Location = New System.Drawing.Point(693, 4)
        Me.lblT.Name = "lblT"
        Me.lblT.Padding = New System.Windows.Forms.Padding(2)
        Me.lblT.Size = New System.Drawing.Size(34, 22)
        Me.lblT.TabIndex = 3
        Me.lblT.Text = "0.0"
        '
        'lblVy
        '
        Me.lblVy.AutoSize = True
        Me.lblVy.BackColor = System.Drawing.Color.Black
        Me.lblVy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVy.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblVy.Location = New System.Drawing.Point(542, 4)
        Me.lblVy.Name = "lblVy"
        Me.lblVy.Padding = New System.Windows.Forms.Padding(2)
        Me.lblVy.Size = New System.Drawing.Size(34, 22)
        Me.lblVy.TabIndex = 3
        Me.lblVy.Text = "0.0"
        '
        'lblVx
        '
        Me.lblVx.AutoSize = True
        Me.lblVx.BackColor = System.Drawing.Color.Black
        Me.lblVx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVx.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVx.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblVx.Location = New System.Drawing.Point(407, 4)
        Me.lblVx.Name = "lblVx"
        Me.lblVx.Padding = New System.Windows.Forms.Padding(2)
        Me.lblVx.Size = New System.Drawing.Size(34, 22)
        Me.lblVx.TabIndex = 3
        Me.lblVx.Text = "0.0"
        '
        'lblYMax
        '
        Me.lblYMax.AutoSize = True
        Me.lblYMax.BackColor = System.Drawing.Color.Black
        Me.lblYMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblYMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYMax.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblYMax.Location = New System.Drawing.Point(303, 4)
        Me.lblYMax.Name = "lblYMax"
        Me.lblYMax.Padding = New System.Windows.Forms.Padding(2)
        Me.lblYMax.Size = New System.Drawing.Size(34, 22)
        Me.lblYMax.TabIndex = 3
        Me.lblYMax.Text = "0.0"
        '
        'lblXMax
        '
        Me.lblXMax.AutoSize = True
        Me.lblXMax.BackColor = System.Drawing.Color.Black
        Me.lblXMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblXMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXMax.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblXMax.Location = New System.Drawing.Point(197, 4)
        Me.lblXMax.Name = "lblXMax"
        Me.lblXMax.Padding = New System.Windows.Forms.Padding(2)
        Me.lblXMax.Size = New System.Drawing.Size(34, 22)
        Me.lblXMax.TabIndex = 3
        Me.lblXMax.Text = "0.0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(648, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(14, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "T"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(511, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(25, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Vy :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(376, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Vx :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(257, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "YMax :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(154, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "XMax :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, -1)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(135, 29)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "> Simulasi "
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(4, 141)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(838, 399)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.pbSimulasi)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(830, 373)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Grafik Simulasi"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'pbSimulasi
        '
        Me.pbSimulasi.BackColor = System.Drawing.Color.White
        Me.pbSimulasi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbSimulasi.Location = New System.Drawing.Point(3, 3)
        Me.pbSimulasi.Name = "pbSimulasi"
        Me.pbSimulasi.Size = New System.Drawing.Size(824, 367)
        Me.pbSimulasi.TabIndex = 0
        Me.pbSimulasi.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnClear)
        Me.TabPage2.Controls.Add(Me.dgvData)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(830, 373)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Data"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(743, 6)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(78, 27)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Maroon
        Me.dgvData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColT, Me.ColX, Me.ColY})
        Me.dgvData.Location = New System.Drawing.Point(3, 37)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(824, 330)
        Me.dgvData.TabIndex = 0
        '
        'ColT
        '
        Me.ColT.HeaderText = "T (S)"
        Me.ColT.Name = "ColT"
        '
        'ColX
        '
        Me.ColX.HeaderText = "X(m)"
        Me.ColX.Name = "ColX"
        '
        'ColY
        '
        Me.ColY.HeaderText = "Y(m)"
        Me.ColY.Name = "ColY"
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(723, 543)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(99, 36)
        Me.btnTutup.TabIndex = 3
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.ClientSize = New System.Drawing.Size(844, 583)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simulasi Gerak Peluru"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.pbSimulasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents pbSimulasi As System.Windows.Forms.PictureBox
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSudut As System.Windows.Forms.TextBox
    Friend WithEvents txtG As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtV0 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKoefHambatan As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDeltaT As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents chkhambatanudara As System.Windows.Forms.CheckBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnTutup As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblXMax As System.Windows.Forms.Label
    Friend WithEvents lblT As System.Windows.Forms.Label
    Friend WithEvents lblVy As System.Windows.Forms.Label
    Friend WithEvents lblVx As System.Windows.Forms.Label
    Friend WithEvents lblYMax As System.Windows.Forms.Label
    Friend WithEvents ColT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColX As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColY As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
