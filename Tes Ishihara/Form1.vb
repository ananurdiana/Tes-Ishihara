Public Class Form1
    Dim jawab() As String = {"12", "8", "29", "6", "57", "5", "15", "3", "74", "2", "6", "97", "45", "5", "7", "16", "73", "tidak ada", "tidak ada", "tidak ada", "26", "tidak ada", "42", "35", "96", "garis", "garis", "tidak ada", "tidak ada", "garis", "garis", "garis", "garis", "garis", "garis", "garis", "garis", "garis", "garis"}
    Dim i As Integer = 1
    Dim benar As Integer = 0
    Dim salah As Integer = 0
    Dim isi As String
    Dim mulaiTes As Boolean = False
    Dim bMap As Bitmap
    Dim penambahanPixel As Integer = 0

    Private Sub bMulai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bMulai.Click
        If i = 1 Then
            mulai(True)
            mulaiTes = True
            tNilai.Focus()
            lBenar.Text = "0"
            lSalah.Text = "0"
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._1
        Else
            MsgBox("Anda sedang melaksanakan tes yang ke " & i & "." & vbNewLine & "Silahkan selesaikan terlebih dahulu tes anda.", vbInformation)
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mulai(False)
    End Sub

    Sub mulai(ByVal Kondisi As Boolean)
        Me.tNilai.Enabled = Kondisi
        Me.bSelanjutnya.Enabled = Kondisi
        Me.bGaris.Enabled = Kondisi
        Me.bTidakBerbentuk.Enabled = Kondisi
    End Sub

    Private Sub tNilai_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tNilai.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            bSelanjutnya.Focus()
        End If

        If Not (e.KeyChar >= "0" And e.KeyChar <= "9" Or e.KeyChar = Convert.ToChar(Keys.Back)) Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub tNilai_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tNilai.TextChanged
        isi = tNilai.Text
    End Sub

    Private Sub bSelanjutnya_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bSelanjutnya.Click
        If isi = "" Then
            MsgBox("Jawab dulu!", vbExclamation)
            Exit Sub
        End If

        If i = 1 Then
            prosesPenilaian()
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._2
        ElseIf i = 2 Then
            prosesPenilaian()
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._3
        ElseIf i = 3 Then
            prosesPenilaian()
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._4
        ElseIf i = 4 Then
            prosesPenilaian()
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._5
        ElseIf i = 5 Then
            prosesPenilaian()
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._6
        ElseIf i = 6 Then
            prosesPenilaian()
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._7
        ElseIf i = 7 Then
            prosesPenilaian()
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._8
        ElseIf i = 8 Then
            prosesPenilaian()
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._9
        ElseIf i = 9 Then
            prosesPenilaian()
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._10
        ElseIf i = 10 Then
            prosesPenilaian()
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._11
        ElseIf i = 11 Then
            prosesPenilaian()
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._12
        ElseIf i = 12 Then
            prosesPenilaian()
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._13
        ElseIf i = 13 Then
            prosesPenilaian()
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._14
        ElseIf i = 14 Then
            prosesPenilaian()
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._15
        ElseIf i = 15 Then
            prosesPenilaian()
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._16
        ElseIf i = 16 Then
            prosesPenilaian()
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._17
        ElseIf i = 17 Then
            prosesPenilaian()
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._18
        ElseIf i = 18 Then
            prosesPenilaian()
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._19
        ElseIf i = 19 Then
            prosesPenilaian()
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._20
        ElseIf i = 20 Then
            prosesPenilaian()
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._21
        ElseIf i = 21 Then
            prosesPenilaian()
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._22
        ElseIf i = 22 Then
            prosesPenilaian()
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._23
        ElseIf i = 23 Then
            prosesPenilaian()
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._24
        ElseIf i = 24 Then
            prosesPenilaian()
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._25
        ElseIf i = 25 Then
            prosesPenilaian()
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._26
        ElseIf i = 26 Then
            prosesPenilaian()
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._27
        ElseIf i = 27 Then
            prosesPenilaian()
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._28
        ElseIf i = 28 Then
            prosesPenilaian()
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._29
        ElseIf i = 29 Then
            prosesPenilaian()
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._30
        ElseIf i = 30 Then
            prosesPenilaian()
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._31
        ElseIf i = 31 Then
            prosesPenilaian()
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._32
        ElseIf i = 32 Then
            prosesPenilaian()
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._33
        ElseIf i = 33 Then
            prosesPenilaian()
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._34
        ElseIf i = 34 Then
            prosesPenilaian()
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._35
        ElseIf i = 35 Then
            prosesPenilaian()
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._36
        ElseIf i = 36 Then
            prosesPenilaian()
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._37
        ElseIf i = 37 Then
            prosesPenilaian()
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._38
        ElseIf i = 38 Then
            prosesPenilaian()

        End If

        tNilai.Text = ""
        tNilai.Focus()

        If i = 38 Then
            If benar = 38 Then
                MsgBox("Proses tes telah selesai." & vbNewLine & "Mata kamu normal", vbInformation)
            ElseIf benar < 38 And benar > 15 Then
                MsgBox("Proses tes telah selesai." & vbNewLine & "Kamu berhasil menyelesaikan " & (benar / 38) * 100 & "% tes.", vbInformation)
            Else
                MsgBox("Proses tes telah selesai." & vbNewLine & "Kamu menyelesaikan " & (benar / 38) * 100 & "%, sebaiknya kamu cari mata baru.", vbIgnore)
            End If
            mulai(False)
            i = 1
            benar = 0
            salah = 0
            Me.pbGambar.Image = Nothing
            mulaiTes = False
            'MsgBox(i)
            Exit Sub
        End If

        i = i + 1
        isi = ""
    End Sub

    Sub prosesPenilaian()
        If isi = jawab(i - 1) Then
            benar = benar + 1
            lBenar.Text = benar
        ElseIf isi <> jawab(i - 1) Then
            salah = salah + 1
            lSalah.Text = salah
            MsgBox("Jawaban yang benar adalah " & jawab(i - 1))
        End If
    End Sub

    Private Sub bGaris_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bGaris.Click
        isi = "garis"
    End Sub

    Private Sub bTidakBerbentuk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bTidakBerbentuk.Click
        isi = "tidak ada"
    End Sub

    Private Sub bTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bTambah.Click
        If mulaiTes = False Then
            MsgBox("Silahkan mulai tes.", vbInformation)
            tNilai.Focus()
            Exit Sub
        End If

        If tIntensitas.Text = "" Then
            tIntensitas.Text = "0"
        Else
            penambahanPixel = tIntensitas.Text
        End If

        bMap = New Bitmap(pbGambar.Image)
        pbGambar.Image = bMap
        Dim tempBmp As New Bitmap(pbGambar.Image)
        Dim dX = 1, dY = 1, x, y As Integer
        Dim red, green, blue As Integer

        With tempBmp
            For x = dX To .Height - dX - 1
                For y = dY To .Width - dY - 1
                    red = CInt(.GetPixel(y, x).R)
                    green = CInt(.GetPixel(y, x).G)
                    blue = CInt(.GetPixel(y, x).B)

                    green = green - penambahanPixel
                    blue = blue - penambahanPixel
                    
                    If green <= 0 Or blue <= 0 Then
                        green = 0
                        blue = 0
                    End If
                    bMap.SetPixel(y, x, Color.FromArgb(red, green, blue))
                Next
                If x Mod 10 = 0 Then
                    pbGambar.Refresh()
                End If
                'MsgBox("tinggi: " & .Height - dX - 1 & vbNewLine & "lebar: " & .Width - dY - 1)
                tIntensitas.Focus()
            Next
        End With
    End Sub

    Private Sub bKurang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bKurang.Click
        If mulaiTes = False Then
            MsgBox("Silahkan mulai tes.", vbInformation)
            tNilai.Focus()
            Exit Sub
        End If

        If tIntensitas.Text = "" Then
            tIntensitas.Text = "0"
        Else
            penambahanPixel = tIntensitas.Text
        End If


        bMap = New Bitmap(pbGambar.Image)
        pbGambar.Image = bMap
        Dim tempBmp As New Bitmap(pbGambar.Image)
        Dim dX = 1, dY = 1, x, y As Integer
        Dim red, green, blue As Integer

        With tempBmp
            For x = dX To .Height - dX - 1
                For y = dY To .Width - dY - 1
                    red = CInt(.GetPixel(y, x).R)
                    green = CInt(.GetPixel(y, x).G)
                    blue = CInt(.GetPixel(y, x).B)

                    green = green + penambahanPixel
                    blue = blue + penambahanPixel

                    If green >= 255 Or blue >= 255 Then
                        green = 255
                        blue = 255
                    End If
                    bMap.SetPixel(y, x, Color.FromArgb(red, green, blue))
                Next
                If x Mod 10 = 0 Then
                    pbGambar.Refresh()
                End If
                'MsgBox("tinggi: " & .Height - dX - 1 & vbNewLine & "lebar: " & .Width - dY - 1)
                tIntensitas.Focus()
            Next
        End With
    End Sub

    Private Sub tIntensitas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tIntensitas.TextChanged
        Try
            If tIntensitas.Text >= 255 Then
                MsgBox("Nilai yang dimasukan tidak boleh lebih dari 255", vbInformation)
                tIntensitas.Text = "0"
                Exit Sub
            ElseIf tIntensitas.Text <= 0 Then
                MsgBox("Nilai yang dimasukan tidak boleh kurang dari 0", vbInformation)
                tIntensitas.Text = "0"
                Exit Sub
            ElseIf tIntensitas.Text = "" Then
                tIntensitas.Text = "0"
                Exit Sub
            End If
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub bReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bReset.Click
        If mulaiTes = False Then
            MsgBox("Silahkan mulai terlebih dahulu", vbInformation)
            Exit Sub
        End If

        Dim noTes As Integer = 0
        noTes = i - 1
        'MsgBox("No Tes: " & noTes & vbNewLine & "i : " & i)
        Me.pbGambar.Image = Nothing

        If noTes = 0 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._1
        ElseIf noTes = 1 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._2
        ElseIf noTes = 2 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._3
        ElseIf noTes = 3 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._4
        ElseIf noTes = 4 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._5
        ElseIf noTes = 5 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._6
        ElseIf noTes = 6 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._7
        ElseIf noTes = 7 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._8
        ElseIf noTes = 8 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._9
        ElseIf noTes = 9 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._10
        ElseIf noTes = 10 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._11
        ElseIf noTes = 11 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._12
        ElseIf noTes = 12 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._13
        ElseIf noTes = 13 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._14
        ElseIf noTes = 14 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._15
        ElseIf noTes = 15 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._16
        ElseIf noTes = 16 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._17
        ElseIf noTes = 17 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._18
        ElseIf noTes = 18 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._19
        ElseIf noTes = 19 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._20
        ElseIf noTes = 20 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._21
        ElseIf noTes = 21 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._22
        ElseIf noTes = 22 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._23
        ElseIf noTes = 23 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._24
        ElseIf noTes = 24 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._25
        ElseIf noTes = 25 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._26
        ElseIf noTes = 26 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._27
        ElseIf noTes = 27 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._28
        ElseIf noTes = 28 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._29
        ElseIf noTes = 29 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._30
        ElseIf noTes = 30 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._31
        ElseIf noTes = 31 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._32
        ElseIf noTes = 32 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._33
        ElseIf noTes = 33 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._34
        ElseIf noTes = 34 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._35
        ElseIf noTes = 35 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._36
        ElseIf noTes = 36 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._37
        ElseIf noTes = 37 Then
            Me.pbGambar.Image = Global.Tes_Ishihara.My.Resources.Resources._38
        ElseIf noTes = 38 Then
            MsgBox("Proses tes selesai", vbInformation)
        End If

        tNilai.Focus()
    End Sub
End Class
