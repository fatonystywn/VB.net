Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        TextBox1.Text = " "
        TextBox2.Text = " "
        TextBox4.Text = " "
        TextBox5.Text = " "
        TextBox6.Text = " "
        TextBox7.Text = " "
        TextBox8.Text = " "
        TextBox9.Text = " "
        TextBox10.Text = " "
        TextBox11.Text = " "
        TextBox12.Text = " "
        ComboBox1.Text = " "


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnhitung.Click
        Dim nama = TextBox1.Text
        Dim npm = TextBox2.Text
        Dim prodi = ComboBox1.Text()
        Dim ntugas = TextBox4.Text
        Dim nuts = TextBox5.Text
        Dim nuas = TextBox6.Text
        Dim sks = TextBox7.Text
        Dim nbobot = TextBox8.Text
        Dim tsem = TextBox9.Text
        Dim ips = TextBox10.Text
        Dim ipk = TextBox11.Text
        TextBox8.Text = (((TextBox12.Text / 16) * 0.1)) + (TextBox4.Text * 0.2) + (TextBox5.Text * 0.3) + (TextBox6.Text * 0.4)
        TextBox10.Text = (TextBox8.Text / TextBox7.Text)
        TextBox11.Text = ((TextBox8.Text * TextBox9.Text) / (TextBox7.Text * TextBox9.Text))
        TextBox10.Text = TextBox10.Text.Substring(0, 3)
        TextBox11.Text = TextBox11.Text.Substring(0, 3)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
