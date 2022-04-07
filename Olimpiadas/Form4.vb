Public Class Form4
    Dim OBJ1 As New Form1
    Dim OBJ2 As New Form2
    Dim OBJ3 As New Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Label9.Text = OBJ1.BotellaAF1 + OBJ2.BotellaAF2



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Label14.Text = (OBJ1.NumericUpDown1.Value + OBJ1.NumericUpDown2.Value + OBJ1.NumericUpDown3.Value + OBJ1.NumericUpDown5.Value
        'OBJ1.NumericUpDown10.Value +OBJ1.NumericUpDown9.Value + OBJ1.NumericUpDown8.Value + OBJ1.NumericUpDown7.Value
        'NumericUpDown15.Value +NumericUpDown14.Value + NumericUpDown13.Value + NumericUpDown12.Value
        'ENumericUpDown20.Value +NumericUpDown19.Value + NumericUpDown18.Value + NumericUpDown17.Value
        'NumericUpDown25.Value +NumericUpDown24.Value + NumericUpDown23.Value + NumericUpDown22.Value
        'NumericUpDown30.Value +NumericUpDown29.Value + NumericUpDown28.Value + NumericUpDown7.Value
        'NumericUpDown35.Value +NumericUpDown34.Value + NumericUpDown33.Value + NumericUpDown32.Value
        'NumericUpDown40.Value +NumericUpDown39.Value + NumericUpDown38.Value + NumericUpDown37.Value
        'NumericUpDown45.Value +NumericUpDown44.Value + NumericUpDown43.Value + NumericUpDown42.Value
        'NumericUpDown50.Value +NumericUpDown49.Value + NumericUpDown48.Value + NumericUpDown47.Value
        'NumericUpDown55.Value +NumericUpDown54.Value + NumericUpDown53.Value + NumericUpDown52.Value
        ' NumericUpDown60.Value +NumericUpDown59.Value + NumericUpDown58.Value + NumericUpDown57.Value)'
    End Sub

    Private Sub Label74_Click(sender As Object, e As EventArgs) Handles Label74.Click
        Me.Close()
    End Sub
End Class