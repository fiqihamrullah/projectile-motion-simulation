Public Class Form1
    Dim hasil() As Double
    Dim vx As Double, vy As Double
    Dim tmax As Double
    Dim G As Double
    Dim hambatan As Double
    Dim sudut As Double
    Dim x0 As Integer, y0 As Integer
    Dim possbx As Integer
    Dim envheightpx As Integer = 480
    Dim envwidthpx As Integer = 480
    Dim envrealheightm As Double
    Dim envrealwidthm As Double
    Dim pcurve() As PointF
    Dim lblpcurve() As Point
    Dim pcurvedetail() As PointF
    Dim bstart As Boolean
    Dim bstartAnimation As Boolean
    Dim currentPoint As Integer
    Dim stepms As Double
    Dim v0 As Integer

    Private Function ConvertMHeighttoPx(ByVal m As Double) As Double
        Dim hasil As Integer
        hasil = m * (envheightpx / envrealheightm)
        Return hasil
    End Function
    Private Function ConvertMWidthtoPx(ByVal m As Double) As Double
        Dim hasil As Integer
        hasil = m * (envwidthpx / envrealwidthm)
        Return hasil
    End Function
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        possbx = pbSimulasi.Height - 20
        y0 = possbx - 10
        x0 = 10
        envheightpx = pbSimulasi.Height - 20
        envwidthpx = pbSimulasi.Width - x0
        System.Diagnostics.Trace.WriteLine("EnvHeightPx : " + envheightpx.ToString() + ", EnvWidthPx : " + envwidthpx.ToString())
        bstart = False
        bstartAnimation = False
        ' G = 10
    End Sub
    Public Function DegreeToRad(ByVal degree As Double) As Double
        Return degree * Math.PI / 180
    End Function
    Public Function RadToDegree(ByVal rad As Double) As Double
        Return rad * 180 / Math.PI
    End Function
    '--------------------------------------------------------
    'Fungsi Gerak Peluru Tanpa Hambatan Udara
    '--------------------------------------------------------
    Public Function CountVx(ByVal v0 As Double, ByVal sudut As Double) As Double
        Dim hasil As Double = 0.0
        Dim rad As Double = DegreeToRad(sudut)
        hasil = v0 * Math.Cos(rad)
        Return hasil
    End Function
    Public Function CountVy(ByVal v0 As Double, ByVal sudut As Double, ByVal t As Integer) As Double
        Dim hasil As Double = 0.0
        Dim rad As Double = DegreeToRad(sudut)
        hasil = v0 * Math.Sin(rad) - G * t
        Return hasil
    End Function
    Public Function GetX(ByVal t As Double) As Double
        Return vx * t
    End Function
    Public Function GetY(ByVal t As Double) As Double
        Return (vy * t) - (0.5 * G * Math.Pow(t, 2))
    End Function
    Public Function GetXMax(ByVal v0 As Double, ByVal derajat As Double) As Double
        Dim rad As Double = DegreeToRad(derajat)
        'Return (Math.Pow(v0, 2) * Math.Sin(2 * rad)) / G
        Return v0 * Math.Cos(rad) * (2 * v0 * Math.Sin(rad) / G)
    End Function
    Public Function GetYMax(ByVal v0 As Double, ByVal derajat As Double, ByVal tmax As Integer) As Double
        Dim rad As Double = DegreeToRad(derajat)
        'Return v0 * Math.Sin(rad) * (tmax / 2) - 0.5 * G * Math.Pow((tmax / 2), 2)
        Return (Math.Pow(v0, 2) * Math.Pow(Math.Sin(rad), 2)) / (2 * G)
        'Return 0.5 * G * Math.Pow(tmax, 2)
    End Function
    Public Function GetTMax(ByVal v0 As Double, ByVal derajat As Double) As Double
        Dim rad As Double = DegreeToRad(derajat)
        Return (2 * v0 * Math.Sin(rad)) / G
    End Function
    '--------------------------------------------------------
    'Fungsi Gerak Peluru Dengan Hambatan Udara
    '--------------------------------------------------------
    Public Function GetXh(ByVal v0 As Double, ByVal t As Integer) As Double
        Dim rad As Double = DegreeToRad(sudut)
        Return (v0 * Math.Cos(rad) / hambatan) * (1 - Math.Exp(-hambatan * t))
    End Function
    Public Function GetYh(ByVal v0 As Double, ByVal t As Integer) As Double
        Dim rad As Double = DegreeToRad(sudut)
        Return (1 / hambatan) * (v0 * Math.Sin(rad) + (G / hambatan)) * (1 - Math.Exp(-hambatan * t)) - ((G / hambatan) * t)
    End Function
    Public Function CountVxh(ByVal v0 As Double, ByVal sudut As Double, ByVal t As Integer) As Double
        Dim rad As Double = DegreeToRad(sudut)
        Return (v0 * Math.Cos(rad)) - Math.Exp(-hambatan * t)
    End Function
    Public Function CountVyh(ByVal v0 As Double, ByVal sudut As Double, ByVal t As Integer) As Double
        Dim rad As Double = DegreeToRad(sudut)
        Return v0 * Math.Sin(rad) * Math.Exp(-hambatan * t) - (G / hambatan) * (1 - Math.Exp(-hambatan * t))
    End Function
    Public Function GetTMaxH(ByVal v0 As Double, ByVal derajat As Double) As Double
        Dim rad As Double
        ' Return 2 * ((G / Math.Pow(hambatan, 2) - (v0 * Math.Sin(rad) + (G / hambatan))))
        Return 2 * (1 / hambatan) * Math.Log10((hambatan * v0 * Math.Sin(rad) / G) + 1)
    End Function
    Public Function GetXMaxH(ByVal v0 As Double, ByVal derajat As Double) As Double
        Dim rad As Double = DegreeToRad(derajat)
        Return (v0 * Math.Cos(rad) / hambatan) * (1 - Math.Exp(-hambatan * GetXh(v0, derajat)))
    End Function
    Public Function GetYMaxH(ByVal v0 As Double, ByVal derajat As Double, ByVal tmax As Integer) As Double
        Dim rad As Double = DegreeToRad(derajat)
        Return (1 / hambatan) * (v0 * Math.Sin(rad) + G / hambatan) * (1 - Math.Exp(-hambatan * tmax)) - 2 * G / hambatan * (G / Math.Pow(hambatan, 2) - (v0 * Math.Sin(rad) + (G / hambatan)))
    End Function
    Public Sub generateGraph(ByVal g As Graphics, ByVal iterasi As Integer, ByVal hasil() As Double)
        'int possbx = pbSimulasi.Height - 20;
        Dim i As Integer, x As Integer, y As Integer
        g.Clear(Color.White)

        'Dim possby As Integer = pbSimulasi.Width - (pbSimulasi.Width - 300)
        'Dim p(iterasi + 1) As PointF
        'Dim bbtiterasi As Single = (pbSimulasi.Width - 20) / (iterasi + 1)
        'Dim i As Integer = 0

        'Dim y As Single
        ''Membuat  Grid Sumbu X
        'For y = 0 To pbSimulasi.Height Step (possbx / (iterasi + 1))
        '    'g.DrawLine(new Pen(Color.FromArgb(0, 50, 0)), 0, y, pbSimulasi.Width, y);
        'Next

        ''Membuat Sumbu X
        g.DrawLine(New Pen(Color.FromArgb(0, 0, 0), 2), 0, possbx, pbSimulasi.Width, possbx)

        ''Membuat Grid Sumbu y
        'Dim x As Single
        'i = 0
        'For x = 130 To pbSimulasi.Width Step ((pbSimulasi.Width - 20) / (iterasi + 1))
        '    g.DrawLine(New Pen(Color.FromArgb(0, 50, 0), 0.05F), x, 0, x, pbSimulasi.Height)
        '    g.DrawString(i.ToString(), New Font("verdana", 10), New SolidBrush(Color.RoyalBlue), x, possbx)
        '    'System.Threading.Thread.Sleep(100)
        '    ' Application.DoEvents()
        '    '   MessageBox.Show(x.ToString());
        '    i += 1
        'Next


        ''Membuat Sumbu Y
        'g.DrawLine(New Pen(Color.FromArgb(0, 0, 0)), 0, possbx, pbSimulasi.Width, possbx)

        '' g.DrawLine(new Pen(Color.FromArgb(0, 255, 0)), possby, 0, possby, pbGraph.Height);

        ''Membuat Titik Persamaan
        'Dim fx, sfx, posLI, yMax, sposLI As Single

        'fx = 0.0F
        'sfx = 0.0F
        'posLI = 0.0F : sposLI = 0.0F
        'yMax = 0.0F

        'Dim it As Integer
        'For it = 0 To iterasi - 1
        '    If (yMax <= hasil(it)) Then
        '        yMax = hasil(it)
        '    End If
        'Next
        ''mencari nilai tertinggi dari hasil fungsi

        'For it = 0 To iterasi - 1
        '    fx = (possbx - (hasil(it) * possbx / (yMax + 0.5))) ' //proyeksi hasil pembagian fungsi f(x) dan turunan ke dalam Cartesius
        '    posLI = 130 + (bbtiterasi * (it + 1))

        '    If (it = 0) Then
        '        sfx = fx
        '        sposLI = posLI
        '    End If

        '    'System.Threading.Thread.Sleep(200)
        '    ' Application.DoEvents()
        '    p(it).X = sposLI
        '    p(it).Y = sfx

        '    g.DrawLine(New Pen(Color.Yellow), sposLI, sfx, posLI, fx)
        '    Dim nilai As Double = Math.Round(hasil(it), 3)
        '    g.DrawString(nilai.ToString(), New Font("verdana", 8), New SolidBrush(Color.DodgerBlue), posLI, fx)
        '    g.FillEllipse(New SolidBrush(Color.Blue), sposLI - 4, sfx - 4, 8.0F, 8.0F)
        '    If (it <> 0) Then
        '        sfx = fx
        '        sposLI = posLI
        '    End If
        'Next

        'p(iterasi).X = sposLI
        'p(iterasi).Y = sfx
        If (bstart) Then
            g.DrawCurve(New Pen(Color.Red), pcurve)
            For i = 0 To lblpcurve.Length - 1
                x = ConvertMWidthtoPx(lblpcurve(i).X)
                y = possbx - ConvertMHeighttoPx(lblpcurve(i).Y)
                If (i <> lblpcurve.Length - 1) Then
                    g.DrawString("(" + (lblpcurve(i).X.ToString() + "," + lblpcurve(i).Y.ToString() + ")"), New Font("verdana", 10, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Red, x, y - 30)
                Else
                    g.DrawString("(" + (lblpcurve(i).X.ToString() + "," + lblpcurve(i).Y.ToString() + ")"), New Font("verdana", 10, FontStyle.Bold, GraphicsUnit.Pixel), Brushes.Red, x - 50, y - 30)
                End If
                g.DrawLine(New Pen(Color.BlueViolet, 2), x, y, x, y0 + 10)
                g.FillEllipse(Brushes.Firebrick, x - 5, y - 5, 10, 10)
            Next i
        End If
        If bstartAnimation Then
            g.DrawEllipse(New Pen(Color.Blue, 2), pcurve(currentPoint).X - 5, pcurve(currentPoint).Y - 5, 10, 10)
            g.FillEllipse(Brushes.Blue, pcurve(currentPoint).X - 5, pcurve(currentPoint).Y - 5, 10, 10)
        End If
    End Sub
    Private Sub addData(ByVal x As Double, ByVal y As Double, ByVal t As Integer)
        Dim obj(3) As Object
        obj(0) = t / 1000.0
        obj(1) = x.ToString()
        obj(2) = y.ToString
        dgvData.Rows.Add(obj)

    End Sub
    Private Sub animatePeluru()
        Dim i As Integer
        For i = 0 To pcurve.Length - 1
            ' g.DrawEllipse(New Pen(Color.Blue, 2), pcurve(i).X, pcurve(i).Y, 10, 10)
            currentPoint = i
            Application.DoEvents()
            pbSimulasi.Invalidate()
            System.Threading.Thread.Sleep(stepms)
        Next
    End Sub
    Private Sub pbSimulasi_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pbSimulasi.Paint
        generateGraph(e.Graphics, 9, hasil)

    End Sub
    Private Sub GenerateParabolicPoint()
        Dim maxms As Integer = tmax * 1000
        stepms = maxms / 100.0
        Dim istep As Double = 0
        Dim x As Double, y As Double
        Dim i As Integer = 0, ii As Integer = 0
        ReDim pcurve(99)
        ReDim lblpcurve(5)
        ReDim pcurvedetail(maxms - 1)
        bstart = True
        currentPoint = 0
        While (istep <= maxms + 10)
            If (chkhambatanudara.Checked = False) Then
                x = GetX(istep / 1000.0)
                y = GetY(istep / 1000.0)
            Else
                x = GetXh(v0, istep / 1000.0)
                y = GetYh(v0, istep / 1000.0)
            End If

            addData(Math.Round(x), Math.Round(y), istep)
            ' System.Diagnostics.Trace.WriteLine((istep / 1000.0).ToString() + "---> X : " + x.ToString() + ",Y:" + y.ToString())
            System.Diagnostics.Trace.WriteLine((i).ToString() + "." + (istep / 1000.0).ToString() + "---> X : " + ConvertMWidthtoPx(x).ToString() + ",Y:" + ConvertMHeighttoPx(y).ToString())
            'System.Diagnostics.Trace.WriteLine("TES : " + istep.ToString())
            istep += stepms
            If (i >= 100) Then
                ReDim Preserve pcurve(i)
            End If
            pcurve(i) = New PointF()
            pcurve(i).X = ConvertMWidthtoPx(x)
            pcurve(i).Y = possbx - ConvertMHeighttoPx(y)
            If (i Mod 20 = 0) Then
                'If (ii < 6) Then
                lblpcurve(ii) = New Point()
                lblpcurve(ii).X = Math.Round(x)
                lblpcurve(ii).Y = Math.Round(y)
                ii += 1
                'End If
            End If
            pbSimulasi.Invalidate()
            i += 1
        End While
        bstartAnimation = True
        animatePeluru()

    End Sub
    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Dim v0 As Double
        If (txtV0.Text <> "") And (txtG.Text <> "") And (txtSudut.Text <> "") Then
            v0 = Double.Parse(txtV0.Text)
            G = Double.Parse(txtG.Text)
            sudut = Double.Parse(txtSudut.Text)
            hambatan = Double.Parse(txtKoefHambatan.Text)

           
            ' envrealheightm = GetYMax(v0, sudut, tmax)
            'envrealwidthm = GetXMax(v0, sudut)
            envrealheightm = 150 ' GetYMax(v0, sudut, tmax)
            envrealwidthm = 200 'GetXMax(v0, sudut)
            While (envrealheightm < GetYMax(v0, sudut, tmax) Or envrealwidthm < GetXMax(v0, sudut))
                envrealheightm += 100
                envrealwidthm += 100
            End While
            System.Diagnostics.Trace.WriteLine("EnvRealHeightM : " + envrealheightm.ToString() + ", EnvRealWidthM : " + envrealwidthm.ToString())
            If (chkhambatanudara.Checked = False) Then
                vx = CountVx(v0, sudut)
                vy = CountVy(v0, sudut, 0)
                tmax = GetTMax(v0, sudut)
                lblXMax.Text = Math.Round(GetXMax(v0, sudut), 2)
                lblYMax.Text = Math.Round(GetYMax(v0, sudut, tmax), 2)
                lblVx.Text = Math.Round(CountVx(v0, sudut), 2)
                lblVy.Text = Math.Round(CountVy(v0, sudut, 0), 2)
                lblT.Text = Math.Round(GetTMax(v0, sudut), 2)
            Else
                Me.v0 = v0
                vx = CountVxh(v0, sudut, 0)
                vy = CountVyh(v0, sudut, 0)
                tmax = GetTMaxH(v0, sudut)
                lblXMax.Text = Math.Round(GetXMaxH(v0, sudut), 2)
                lblYMax.Text = Math.Round(GetYMaxH(v0, sudut, tmax), 2)
                lblVx.Text = Math.Round(CountVxh(v0, sudut, 0), 2)
                lblVy.Text = Math.Round(CountVyh(v0, sudut, 0), 2)
                lblT.Text = Math.Round(GetTMaxH(v0, sudut), 2)
            End If
            btnClear_Click(sender, e)
            GenerateParabolicPoint()
        Else
            MessageBox.Show("Parameter Input Belum Lengkap diisi..!!", "Belum Lengkap", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If


    End Sub

    Private Sub btnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        dgvData.Rows.Clear()
    End Sub
End Class
