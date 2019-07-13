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
        Me.pbGambar = New System.Windows.Forms.PictureBox()
        Me.bMulai = New System.Windows.Forms.Button()
        Me.tNilai = New System.Windows.Forms.TextBox()
        Me.bSelanjutnya = New System.Windows.Forms.Button()
        Me.bTidakBerbentuk = New System.Windows.Forms.Button()
        Me.bGaris = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lBenar = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lSalah = New System.Windows.Forms.Label()
        Me.lTanggal = New System.Windows.Forms.Label()
        Me.bTambah = New System.Windows.Forms.Button()
        Me.bKurang = New System.Windows.Forms.Button()
        Me.tIntensitas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bReset = New System.Windows.Forms.Button()
        CType(Me.pbGambar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbGambar
        '
        Me.pbGambar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbGambar.Location = New System.Drawing.Point(12, 12)
        Me.pbGambar.Name = "pbGambar"
        Me.pbGambar.Size = New System.Drawing.Size(387, 401)
        Me.pbGambar.TabIndex = 0
        Me.pbGambar.TabStop = False
        '
        'bMulai
        '
        Me.bMulai.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bMulai.Location = New System.Drawing.Point(405, 12)
        Me.bMulai.Name = "bMulai"
        Me.bMulai.Size = New System.Drawing.Size(75, 49)
        Me.bMulai.TabIndex = 1
        Me.bMulai.Text = "Mulai"
        Me.bMulai.UseVisualStyleBackColor = True
        '
        'tNilai
        '
        Me.tNilai.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tNilai.Location = New System.Drawing.Point(405, 88)
        Me.tNilai.MaxLength = 2
        Me.tNilai.Name = "tNilai"
        Me.tNilai.Size = New System.Drawing.Size(75, 44)
        Me.tNilai.TabIndex = 2
        Me.tNilai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bSelanjutnya
        '
        Me.bSelanjutnya.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bSelanjutnya.Location = New System.Drawing.Point(575, 87)
        Me.bSelanjutnya.Name = "bSelanjutnya"
        Me.bSelanjutnya.Size = New System.Drawing.Size(125, 105)
        Me.bSelanjutnya.TabIndex = 3
        Me.bSelanjutnya.Text = "Selanjutnya"
        Me.bSelanjutnya.UseVisualStyleBackColor = True
        '
        'bTidakBerbentuk
        '
        Me.bTidakBerbentuk.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bTidakBerbentuk.Location = New System.Drawing.Point(405, 143)
        Me.bTidakBerbentuk.Name = "bTidakBerbentuk"
        Me.bTidakBerbentuk.Size = New System.Drawing.Size(164, 49)
        Me.bTidakBerbentuk.TabIndex = 4
        Me.bTidakBerbentuk.Text = "Tidak Berbentuk"
        Me.bTidakBerbentuk.UseVisualStyleBackColor = True
        '
        'bGaris
        '
        Me.bGaris.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bGaris.Location = New System.Drawing.Point(494, 88)
        Me.bGaris.Name = "bGaris"
        Me.bGaris.Size = New System.Drawing.Size(75, 49)
        Me.bGaris.TabIndex = 5
        Me.bGaris.Text = "Garis"
        Me.bGaris.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(405, 231)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 31)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Benar"
        '
        'lBenar
        '
        Me.lBenar.AutoSize = True
        Me.lBenar.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lBenar.Location = New System.Drawing.Point(530, 231)
        Me.lBenar.Name = "lBenar"
        Me.lBenar.Size = New System.Drawing.Size(26, 31)
        Me.lBenar.TabIndex = 7
        Me.lBenar.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(405, 282)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 31)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Salah"
        '
        'lSalah
        '
        Me.lSalah.AutoSize = True
        Me.lSalah.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lSalah.Location = New System.Drawing.Point(530, 282)
        Me.lSalah.Name = "lSalah"
        Me.lSalah.Size = New System.Drawing.Size(26, 31)
        Me.lSalah.TabIndex = 9
        Me.lSalah.Text = "0"
        '
        'lTanggal
        '
        Me.lTanggal.AutoSize = True
        Me.lTanggal.Location = New System.Drawing.Point(408, 400)
        Me.lTanggal.Name = "lTanggal"
        Me.lTanggal.Size = New System.Drawing.Size(242, 13)
        Me.lTanggal.TabIndex = 10
        Me.lTanggal.Text = "© Ana Nurdiana - 2014 | ananurdiana@gmail.com"
        '
        'bTambah
        '
        Me.bTambah.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bTambah.Location = New System.Drawing.Point(413, 343)
        Me.bTambah.Name = "bTambah"
        Me.bTambah.Size = New System.Drawing.Size(53, 40)
        Me.bTambah.TabIndex = 11
        Me.bTambah.Text = "+"
        Me.bTambah.UseVisualStyleBackColor = True
        '
        'bKurang
        '
        Me.bKurang.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bKurang.Location = New System.Drawing.Point(494, 343)
        Me.bKurang.Name = "bKurang"
        Me.bKurang.Size = New System.Drawing.Size(53, 40)
        Me.bKurang.TabIndex = 12
        Me.bKurang.Text = "-"
        Me.bKurang.UseVisualStyleBackColor = True
        '
        'tIntensitas
        '
        Me.tIntensitas.Location = New System.Drawing.Point(553, 363)
        Me.tIntensitas.MaxLength = 3
        Me.tIntensitas.Name = "tIntensitas"
        Me.tIntensitas.Size = New System.Drawing.Size(52, 20)
        Me.tIntensitas.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(553, 347)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Intensitas"
        '
        'bReset
        '
        Me.bReset.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bReset.Location = New System.Drawing.Point(611, 343)
        Me.bReset.Name = "bReset"
        Me.bReset.Size = New System.Drawing.Size(89, 40)
        Me.bReset.TabIndex = 15
        Me.bReset.Text = "Reset"
        Me.bReset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 422)
        Me.Controls.Add(Me.bReset)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tIntensitas)
        Me.Controls.Add(Me.bKurang)
        Me.Controls.Add(Me.bTambah)
        Me.Controls.Add(Me.lTanggal)
        Me.Controls.Add(Me.lSalah)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lBenar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bGaris)
        Me.Controls.Add(Me.bTidakBerbentuk)
        Me.Controls.Add(Me.bSelanjutnya)
        Me.Controls.Add(Me.tNilai)
        Me.Controls.Add(Me.bMulai)
        Me.Controls.Add(Me.pbGambar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tes Ishihara - Ishihara 38 Plate "
        CType(Me.pbGambar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbGambar As System.Windows.Forms.PictureBox
    Friend WithEvents bMulai As System.Windows.Forms.Button
    Friend WithEvents tNilai As System.Windows.Forms.TextBox
    Friend WithEvents bSelanjutnya As System.Windows.Forms.Button
    Friend WithEvents bTidakBerbentuk As System.Windows.Forms.Button
    Friend WithEvents bGaris As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lBenar As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lSalah As System.Windows.Forms.Label
    Friend WithEvents lTanggal As System.Windows.Forms.Label
    Friend WithEvents bTambah As System.Windows.Forms.Button
    Friend WithEvents bKurang As System.Windows.Forms.Button
    Friend WithEvents tIntensitas As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bReset As System.Windows.Forms.Button

End Class
