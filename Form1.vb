Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Column, Row As Integer
        Column = Integer.Parse(TextBox1.Text)
        Row = Integer.Parse(TextBox2.Text)

        Generate_Multiplication_Table(Column, Row)
    End Sub

    Private Sub Generate_Multiplication_Table(Column As Integer, Row As Integer)
        TextBox3.Text = ""
        For count_1 = 1 To Row
            For count_2 = 1 To Column

                TextBox3.AppendText(Convert.ToString(count_1 * count_2))
            Next
            TextBox3.AppendText(Constants.vbNewLine)
        Next
    End Sub


End Class
