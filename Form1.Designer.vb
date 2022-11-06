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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.absen = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.ipk = New System.Windows.Forms.Label()
        Me.ips = New System.Windows.Forms.Label()
        Me.btnhitung = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.tsem = New System.Windows.Forms.Label()
        Me.nbobot = New System.Windows.Forms.Label()
        Me.sks = New System.Windows.Forms.Label()
        Me.nuas = New System.Windows.Forms.Label()
        Me.nuts = New System.Windows.Forms.Label()
        Me.ntugas = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.prodi = New System.Windows.Forms.Label()
        Me.npm = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Sistem Informasi", "Teknik Informasi", "Akutansi", "Manajemen"})
        Me.ComboBox1.Location = New System.Drawing.Point(168, 186)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(364, 25)
        Me.ComboBox1.TabIndex = 55
        '
        'absen
        '
        Me.absen.AutoSize = True
        Me.absen.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.absen.Location = New System.Drawing.Point(46, 387)
        Me.absen.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.absen.Name = "absen"
        Me.absen.Size = New System.Drawing.Size(46, 17)
        Me.absen.TabIndex = 54
        Me.absen.Text = "Absen"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(168, 388)
        Me.TextBox12.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(241, 25)
        Me.TextBox12.TabIndex = 53
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(168, 492)
        Me.TextBox11.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ReadOnly = True
        Me.TextBox11.Size = New System.Drawing.Size(132, 25)
        Me.TextBox11.TabIndex = 52
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(168, 441)
        Me.TextBox10.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(132, 25)
        Me.TextBox10.TabIndex = 51
        '
        'ipk
        '
        Me.ipk.AutoSize = True
        Me.ipk.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ipk.Location = New System.Drawing.Point(62, 492)
        Me.ipk.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ipk.Name = "ipk"
        Me.ipk.Size = New System.Drawing.Size(33, 17)
        Me.ipk.TabIndex = 50
        Me.ipk.Text = "IPK"
        '
        'ips
        '
        Me.ips.AutoSize = True
        Me.ips.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ips.Location = New System.Drawing.Point(62, 450)
        Me.ips.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ips.Name = "ips"
        Me.ips.Size = New System.Drawing.Size(30, 17)
        Me.ips.TabIndex = 49
        Me.ips.Text = "IPS"
        '
        'btnhitung
        '
        Me.btnhitung.Location = New System.Drawing.Point(710, 387)
        Me.btnhitung.Margin = New System.Windows.Forms.Padding(4)
        Me.btnhitung.Name = "btnhitung"
        Me.btnhitung.Size = New System.Drawing.Size(100, 30)
        Me.btnhitung.TabIndex = 48
        Me.btnhitung.Text = "Hitung"
        Me.btnhitung.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(570, 387)
        Me.btnclear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(100, 30)
        Me.btnclear.TabIndex = 47
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(569, 345)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(241, 25)
        Me.TextBox9.TabIndex = 46
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(569, 299)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(241, 25)
        Me.TextBox8.TabIndex = 45
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(569, 255)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(241, 25)
        Me.TextBox7.TabIndex = 44
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(168, 345)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(241, 25)
        Me.TextBox6.TabIndex = 43
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(168, 296)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(241, 25)
        Me.TextBox5.TabIndex = 42
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(168, 251)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(241, 25)
        Me.TextBox4.TabIndex = 41
        '
        'tsem
        '
        Me.tsem.AutoSize = True
        Me.tsem.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsem.Location = New System.Drawing.Point(437, 349)
        Me.tsem.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tsem.Name = "tsem"
        Me.tsem.Size = New System.Drawing.Size(96, 17)
        Me.tsem.TabIndex = 40
        Me.tsem.Text = "Total Semester"
        '
        'nbobot
        '
        Me.nbobot.AutoSize = True
        Me.nbobot.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nbobot.Location = New System.Drawing.Point(437, 303)
        Me.nbobot.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.nbobot.Name = "nbobot"
        Me.nbobot.Size = New System.Drawing.Size(74, 17)
        Me.nbobot.TabIndex = 39
        Me.nbobot.Text = "Nilai Bobot"
        '
        'sks
        '
        Me.sks.AutoSize = True
        Me.sks.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sks.Location = New System.Drawing.Point(437, 259)
        Me.sks.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sks.Name = "sks"
        Me.sks.Size = New System.Drawing.Size(35, 17)
        Me.sks.TabIndex = 38
        Me.sks.Text = "SKS"
        '
        'nuas
        '
        Me.nuas.AutoSize = True
        Me.nuas.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nuas.Location = New System.Drawing.Point(46, 345)
        Me.nuas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.nuas.Name = "nuas"
        Me.nuas.Size = New System.Drawing.Size(69, 17)
        Me.nuas.TabIndex = 37
        Me.nuas.Text = "Nilai UAS"
        '
        'nuts
        '
        Me.nuts.AutoSize = True
        Me.nuts.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nuts.Location = New System.Drawing.Point(46, 296)
        Me.nuts.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.nuts.Name = "nuts"
        Me.nuts.Size = New System.Drawing.Size(67, 17)
        Me.nuts.TabIndex = 36
        Me.nuts.Text = "Nilai UTS"
        '
        'ntugas
        '
        Me.ntugas.AutoSize = True
        Me.ntugas.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ntugas.Location = New System.Drawing.Point(45, 251)
        Me.ntugas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ntugas.Name = "ntugas"
        Me.ntugas.Size = New System.Drawing.Size(74, 17)
        Me.ntugas.TabIndex = 35
        Me.ntugas.Text = "Nilai Tugas"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(168, 132)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(364, 25)
        Me.TextBox2.TabIndex = 34
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(168, 80)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(364, 25)
        Me.TextBox1.TabIndex = 33
        '
        'prodi
        '
        Me.prodi.AutoSize = True
        Me.prodi.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prodi.Location = New System.Drawing.Point(50, 190)
        Me.prodi.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.prodi.Name = "prodi"
        Me.prodi.Size = New System.Drawing.Size(92, 17)
        Me.prodi.TabIndex = 32
        Me.prodi.Text = "Program Studi"
        '
        'npm
        '
        Me.npm.AutoSize = True
        Me.npm.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.npm.Location = New System.Drawing.Point(50, 136)
        Me.npm.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.npm.Name = "npm"
        Me.npm.Size = New System.Drawing.Size(41, 17)
        Me.npm.TabIndex = 31
        Me.npm.Text = "NPM"
        '
        'nama
        '
        Me.nama.AutoSize = True
        Me.nama.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama.Location = New System.Drawing.Point(46, 84)
        Me.nama.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(46, 19)
        Me.nama.TabIndex = 30
        Me.nama.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Handwriting", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(389, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(412, 36)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "FORM NILAI MAHASISWA"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1218, 633)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.absen)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.ipk)
        Me.Controls.Add(Me.ips)
        Me.Controls.Add(Me.btnhitung)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.tsem)
        Me.Controls.Add(Me.nbobot)
        Me.Controls.Add(Me.sks)
        Me.Controls.Add(Me.nuas)
        Me.Controls.Add(Me.nuts)
        Me.Controls.Add(Me.ntugas)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.prodi)
        Me.Controls.Add(Me.npm)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents absen As System.Windows.Forms.Label
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents ipk As System.Windows.Forms.Label
    Friend WithEvents ips As System.Windows.Forms.Label
    Friend WithEvents btnhitung As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents tsem As System.Windows.Forms.Label
    Friend WithEvents nbobot As System.Windows.Forms.Label
    Friend WithEvents sks As System.Windows.Forms.Label
    Friend WithEvents nuas As System.Windows.Forms.Label
    Friend WithEvents nuts As System.Windows.Forms.Label
    Friend WithEvents ntugas As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents prodi As System.Windows.Forms.Label
    Friend WithEvents npm As System.Windows.Forms.Label
    Friend WithEvents nama As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
