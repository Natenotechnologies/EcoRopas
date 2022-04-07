Public Class Form3

    Dim materialA As Integer
    Dim materialB As Integer
    Dim materialC As Integer
    Dim materialD As Integer
    Dim materialE As Integer
    Dim MaterialT As Integer
    Dim Hilo As Integer
    Dim Costo1 As Integer
    Dim CostoTotal As Integer


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label75.Text = Now.Date



    End Sub
    Private Sub Label74_Click(sender As Object, e As EventArgs) Handles Label74.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        materialA = ((NumericUpDown1.Value * 1000) * 100)
        materialB = ((NumericUpDown2.Value * 1000) * 120)
        materialC = ((NumericUpDown3.Value * 1000) * 130)
        materialD = ((NumericUpDown5.Value * 1000) * 140)
        materialE = ((NumericUpDown6.Value * 1000) * 50)
        MaterialT = (NumericUpDown1.Value + NumericUpDown2.Value + NumericUpDown3.Value + NumericUpDown5.Value + NumericUpDown6.Value)
        Label88.Text = MaterialT
        Costo1 = (materialA + materialB + materialC + materialD + materialE) * 90%
        Label76.Text = Costo1
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        materialA = ((NumericUpDown10.Value * 1000) * 100)
        materialB = ((NumericUpDown9.Value * 1000) * 120)
        materialC = ((NumericUpDown8.Value * 1000) * 130)
        materialD = ((NumericUpDown7.Value * 1000) * 140)
        materialE = ((NumericUpDown4.Value * 1000) * 50)
        MaterialT = (NumericUpDown10.Value + NumericUpDown9.Value + NumericUpDown8.Value + NumericUpDown7.Value + NumericUpDown4.Value)
        Label89.Text = MaterialT
        Costo1 = (materialA + materialB + materialC + materialD + materialE) * 90%
        Label77.Text = Costo1
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        materialA = ((NumericUpDown15.Value * 1000) * 100)
        materialB = ((NumericUpDown14.Value * 1000) * 120)
        materialC = ((NumericUpDown13.Value * 1000) * 130)
        materialD = ((NumericUpDown12.Value * 1000) * 140)
        materialE = ((NumericUpDown11.Value * 1000) * 50)
        MaterialT = (NumericUpDown15.Value + NumericUpDown14.Value + NumericUpDown13.Value + NumericUpDown12.Value + NumericUpDown11.Value)
        Label90.Text = MaterialT
        Costo1 = (materialA + materialB + materialC + materialD + materialE) * 90%
        Label78.Text = Costo1
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        materialA = ((NumericUpDown20.Value * 1000) * 100)
        materialB = ((NumericUpDown19.Value * 1000) * 120)
        materialC = ((NumericUpDown18.Value * 1000) * 130)
        materialD = ((NumericUpDown17.Value * 1000) * 140)
        materialE = ((NumericUpDown16.Value * 1000) * 50)
        MaterialT = (NumericUpDown20.Value + NumericUpDown19.Value + NumericUpDown18.Value + NumericUpDown17.Value + NumericUpDown16.Value)
        Label91.Text = MaterialT
        Costo1 = (materialA + materialB + materialC + materialD + materialE) * 90%
        Label79.Text = Costo1
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        materialA = ((NumericUpDown25.Value * 1000) * 100)
        materialB = ((NumericUpDown24.Value * 1000) * 120)
        materialC = ((NumericUpDown23.Value * 1000) * 130)
        materialD = ((NumericUpDown22.Value * 1000) * 140)
        materialE = ((NumericUpDown21.Value * 1000) * 50)
        MaterialT = (NumericUpDown25.Value + NumericUpDown24.Value + NumericUpDown23.Value + NumericUpDown22.Value + NumericUpDown21.Value)
        Label92.Text = MaterialT
        Costo1 = (materialA + materialB + materialC + materialD + materialE) * 90%
        Label80.Text = Costo1
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        materialA = ((NumericUpDown30.Value * 1000) * 100)
        materialB = ((NumericUpDown29.Value * 1000) * 120)
        materialC = ((NumericUpDown28.Value * 1000) * 130)
        materialD = ((NumericUpDown27.Value * 1000) * 140)
        materialE = ((NumericUpDown26.Value * 1000) * 50)
        MaterialT = (NumericUpDown30.Value + NumericUpDown29.Value + NumericUpDown28.Value + NumericUpDown27.Value + NumericUpDown26.Value)
        Label93.Text = MaterialT
        Costo1 = (materialA + materialB + materialC + materialD + materialE) * 90%
        Label81.Text = Costo1
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        materialA = ((NumericUpDown35.Value * 1000) * 100)
        materialB = ((NumericUpDown34.Value * 1000) * 120)
        materialC = ((NumericUpDown33.Value * 1000) * 130)
        materialD = ((NumericUpDown32.Value * 1000) * 140)
        materialE = ((NumericUpDown31.Value * 1000) * 50)
        MaterialT = (NumericUpDown35.Value + NumericUpDown34.Value + NumericUpDown33.Value + NumericUpDown32.Value + NumericUpDown31.Value)
        Label94.Text = MaterialT
        Costo1 = (materialA + materialB + materialC + materialD + materialE) * 90%
        Label82.Text = Costo1
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        materialA = ((NumericUpDown40.Value * 1000) * 100)
        materialB = ((NumericUpDown39.Value * 1000) * 120)
        materialC = ((NumericUpDown38.Value * 1000) * 130)
        materialD = ((NumericUpDown37.Value * 1000) * 140)
        materialE = ((NumericUpDown36.Value * 1000) * 50)
        MaterialT = (NumericUpDown40.Value + NumericUpDown39.Value + NumericUpDown38.Value + NumericUpDown37.Value + NumericUpDown36.Value)
        Label95.Text = MaterialT
        Costo1 = (materialA + materialB + materialC + materialD + materialE) * 90%
        Label83.Text = Costo1
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        materialA = ((NumericUpDown45.Value * 1000) * 100)
        materialB = ((NumericUpDown44.Value * 1000) * 120)
        materialC = ((NumericUpDown43.Value * 1000) * 130)
        materialD = ((NumericUpDown42.Value * 1000) * 140)
        materialE = ((NumericUpDown41.Value * 1000) * 50)
        MaterialT = (NumericUpDown45.Value + NumericUpDown44.Value + NumericUpDown43.Value + NumericUpDown42.Value + NumericUpDown41.Value)
        Label96.Text = MaterialT
        Costo1 = (materialA + materialB + materialC + materialD + materialE) * 90%
        Label84.Text = Costo1
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        materialA = ((NumericUpDown50.Value * 1000) * 100)
        materialB = ((NumericUpDown49.Value * 1000) * 120)
        materialC = ((NumericUpDown48.Value * 1000) * 130)
        materialD = ((NumericUpDown47.Value * 1000) * 140)
        materialE = ((NumericUpDown46.Value * 1000) * 50)
        MaterialT = (NumericUpDown50.Value + NumericUpDown49.Value + NumericUpDown48.Value + NumericUpDown47.Value + NumericUpDown46.Value)
        Label97.Text = MaterialT
        Costo1 = (materialA + materialB + materialC + materialD + materialE) * 90%
        Label85.Text = Costo1
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        materialA = ((NumericUpDown55.Value * 1000) * 100)
        materialB = ((NumericUpDown54.Value * 1000) * 120)
        materialC = ((NumericUpDown53.Value * 1000) * 130)
        materialD = ((NumericUpDown52.Value * 1000) * 140)
        materialE = ((NumericUpDown51.Value * 1000) * 50)
        MaterialT = (NumericUpDown55.Value + NumericUpDown54.Value + NumericUpDown53.Value + NumericUpDown52.Value + NumericUpDown51.Value)
        Label98.Text = MaterialT
        Costo1 = (materialA + materialB + materialC + materialD + materialE) * 90%
        Label86.Text = Costo1
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        materialA = ((NumericUpDown60.Value * 1000) * 100)
        materialB = ((NumericUpDown59.Value * 1000) * 120)
        materialC = ((NumericUpDown58.Value * 1000) * 130)
        materialD = ((NumericUpDown57.Value * 1000) * 140)
        materialE = ((NumericUpDown56.Value * 1000) * 50)
        MaterialT = (NumericUpDown60.Value + NumericUpDown59.Value + NumericUpDown58.Value + NumericUpDown57.Value + NumericUpDown56.Value)
        Label99.Text = MaterialT
        Costo1 = (materialA + materialB + materialC + materialD + materialE) * 90%
        Label87.Text = Costo1
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If (ComboBox1.SelectedIndex = 0) Then
            Hilo = NumericUpDown1.Value + NumericUpDown2.Value + NumericUpDown3.Value + NumericUpDown5.Value
        ElseIf (ComboBox1.SelectedIndex = 1) Then
            Hilo = NumericUpDown10.Value + NumericUpDown9.Value + NumericUpDown8.Value + NumericUpDown7.Value
        ElseIf (ComboBox1.SelectedIndex = 2) Then
            Hilo = NumericUpDown15.Value + NumericUpDown14.Value + NumericUpDown13.Value + NumericUpDown12.Value
        ElseIf (ComboBox1.SelectedIndex = 3) Then
            Hilo = NumericUpDown20.Value + NumericUpDown19.Value + NumericUpDown18.Value + NumericUpDown17.Value
        ElseIf (ComboBox1.SelectedIndex = 4) Then
            Hilo = NumericUpDown25.Value + NumericUpDown24.Value + NumericUpDown23.Value + NumericUpDown22.Value
        ElseIf (ComboBox1.SelectedIndex = 5) Then
            Hilo = NumericUpDown30.Value + NumericUpDown29.Value + NumericUpDown28.Value + NumericUpDown7.Value
        ElseIf (ComboBox1.SelectedIndex = 6) Then
            Hilo = NumericUpDown35.Value + NumericUpDown34.Value + NumericUpDown33.Value + NumericUpDown32.Value
        ElseIf (ComboBox1.SelectedIndex = 7) Then
            Hilo = NumericUpDown40.Value + NumericUpDown39.Value + NumericUpDown38.Value + NumericUpDown37.Value
        ElseIf (ComboBox1.SelectedIndex = 8) Then
            Hilo = NumericUpDown45.Value + NumericUpDown44.Value + NumericUpDown43.Value + NumericUpDown42.Value
        ElseIf (ComboBox1.SelectedIndex = 9) Then
            Hilo = NumericUpDown50.Value + NumericUpDown49.Value + NumericUpDown48.Value + NumericUpDown47.Value
        ElseIf (ComboBox1.SelectedIndex = 10) Then
            Hilo = NumericUpDown55.Value + NumericUpDown54.Value + NumericUpDown53.Value + NumericUpDown52.Value
        ElseIf (ComboBox1.SelectedIndex = 11) Then
            Hilo = NumericUpDown60.Value + NumericUpDown59.Value + NumericUpDown58.Value + NumericUpDown57.Value
        End If

        Label103.Text = ((Hilo * 10) * 100) & " cm"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click


        Dim q, w, r, t, y, u, i, o, p, a, s, d As Integer


        q = CInt(Label76.Text)
        w = CInt(Label77.Text)
        r = CInt(Label78.Text)
        t = CInt(Label79.Text)
        y = CInt(Label80.Text)
        u = CInt(Label81.Text)
        i = CInt(Label82.Text)
        o = CInt(Label83.Text)
        p = CInt(Label84.Text)
        a = CInt(Label85.Text)
        s = CInt(Label86.Text)
        d = CInt(Label87.Text)
        CostoTotal = (q + w + r + t + y + u + i + o + p + a + s + d)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        CostoTotal = Label107.Text * (1 / 9)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim box = New Form4()
        box.Show()
        Me.Hide()

    End Sub
End Class