Public Class Form1
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim Res As Integer
        If (Op.Text = "+") Then
            Res = CUInt(Num1.Text) + CUInt(Num2.Text)
            Result.Text = Res
        End If
        If (Op.Text = "-") Then
            Res = CUInt(Num1.Text) - CUInt(Num2.Text)
            Result.Text = Res
        End If
        If (Op.Text = "/") Then
            Res = CUInt(Num1.Text) / CUInt(Num2.Text)
            Result.Text = Res
        End If
        If (Op.Text = "*") Then
            Res = CUInt(Num1.Text) * CUInt(Num2.Text)
            Result.Text = Res
        End If
        If (Op.Text = "%") Then
            Res = CUInt(Num1.Text) Mod CUInt(Num2.Text)
            Result.Text = Res
        End If
        If (Op.Text = "") Then
            MessageBox.Show("Selecione uma operação")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Creditos.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        His.Items.Add("+--------------------------------------------------+")
        His.Items.Add(" |           Total de calc:" + Cap.Text + "          |")
        His.Items.Add("+--------------------------------------------------+")
        MessageBox.Show("Imprimido com sucesso!!!")
    End Sub

    Private Sub His_TextChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub His_SelectedIndexChanged(sender As Object, e As EventArgs) Handles His.SelectedIndexChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim c As Integer
        c = CUInt(TextBox1.Text)
        If (c > 0) Then
            c = c - 1
            TextBox1.Text = c
            If (c = 1) Then
                Cap.Text = CStr(c) + " Linha"
                His.Items.Add(Num1.Text + " " + Op.Text + " " + Num2.Text + " = " + Result.Text)
            End If

            If (c > 1) Then
                Cap.Text = CStr(c) + " Linhas"
                His.Items.Add(Num1.Text + " " + Op.Text + " " + Num2.Text + " = " + Result.Text)
            End If
        End If
        If (c = 0) Then
            If (c = 0) Then
                MessageBox.Show("Tu precisa excluir linhas")
            End If
        End If



    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        His.Items.RemoveAt(3)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        His.Items.Clear()
        His.Items.Add("+--------------------------------------------------+")
        His.Items.Add(" |           Extrato da memória          |")
        His.Items.Add("+--------------------------------------------------+")

    End Sub
End Class
