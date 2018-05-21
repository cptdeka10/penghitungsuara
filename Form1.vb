Public Class formPenghitungSuara
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnReset.Click
        lblPersen1.Text = "0.00%"
        lblPersen2.Text = "0.00%"
        lblPersen3.Text = "0.00%"
        lblSuara1.Text = "0"
        lblSuara2.Text = "0"
        lblSuara3.Text = "0"
        lblSuaraMasuk.Text = "0"
        lblSuaraSah.Text = "0"
        lblSuaraTidakSah.Text = "0"
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btn1.Click
        Dim a As Decimal
        a = lblSuaraMasuk.Text
        a = a + 1
        lblSuaraMasuk.Text = a.ToString
        a = lblSuaraSah.Text
        a = a + 1
        lblSuaraSah.Text = a.ToString

        a = lblSuara1.Text
        a = a + 1
        lblSuara1.Text = a.ToString

        Dim b As Double
        Dim c As Double
        Dim d As Double
        c = lblSuaraSah.Text
        b = lblSuara1.Text
        d = b * 100 / c
        lblPersen1.Text = String.Format("{0:F2}", d) + "%"
        b = lblSuara2.Text
        d = b * 100 / c
        lblPersen2.Text = String.Format("{0:F2}", d) + "%"
        b = lblSuara3.Text
        d = b * 100 / c
        lblPersen3.Text = String.Format("{0:F2}", d) + "%"
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btn2.Click
        Dim a As Decimal
        a = lblSuaraMasuk.Text
        a = a + 1
        lblSuaraMasuk.Text = a.ToString
        a = lblSuaraSah.Text
        a = a + 1
        lblSuaraSah.Text = a.ToString

        a = lblSuara2.Text
        a = a + 1
        lblSuara2.Text = a.ToString

        Dim b As Double
        Dim c As Double
        Dim d As Double
        c = lblSuaraSah.Text
        b = lblSuara1.Text
        d = b * 100 / c
        lblPersen1.Text = String.Format("{0:F2}", d) + "%"
        b = lblSuara2.Text
        d = b * 100 / c
        lblPersen2.Text = String.Format("{0:F2}", d) + "%"
        b = lblSuara3.Text
        d = b * 100 / c
        lblPersen3.Text = String.Format("{0:F2}", d) + "%"
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btn3.Click
        Dim a As Decimal
        a = lblSuaraMasuk.Text
        a = a + 1
        lblSuaraMasuk.Text = a.ToString
        a = lblSuaraSah.Text
        a = a + 1
        lblSuaraSah.Text = a.ToString

        a = lblSuara3.Text
        a = a + 1
        lblSuara3.Text = a.ToString

        Dim b As Double
        Dim c As Double
        Dim d As Double
        c = lblSuaraSah.Text
        b = lblSuara1.Text
        d = b * 100 / c
        lblPersen1.Text = String.Format("{0:F2}", d) + "%"
        b = lblSuara2.Text
        d = b * 100 / c
        lblPersen2.Text = String.Format("{0:F2}", d) + "%"
        b = lblSuara3.Text
        d = b * 100 / c
        lblPersen3.Text = String.Format("{0:F2}", d) + "%"
    End Sub

    Private Sub btnTidakSah_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnTidakSah.Click
        Dim a As Decimal
        a = lblSuaraTidakSah.Text
        a = a + 1
        lblSuaraTidakSah.Text = a.ToString
        a = lblSuaraMasuk.Text
        a = a + 1
        lblSuaraMasuk.Text = a.ToString
    End Sub

    Private Sub btnMin1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnMin1.Click
        Dim a As Decimal
        a = lblSuaraMasuk.Text
        a = a - 1
        lblSuaraMasuk.Text = a.ToString
        a = lblSuaraSah.Text
        a = a - 1
        lblSuaraSah.Text = a.ToString

        a = lblSuara1.Text
        a = a - 1
        lblSuara1.Text = a.ToString

        Dim b As Double
        Dim c As Double
        Dim d As Double
        c = lblSuaraSah.Text
        b = lblSuara1.Text
        d = b * 100 / c
        lblPersen1.Text = String.Format("{0:F2}", d) + "%"
        b = lblSuara2.Text
        d = b * 100 / c
        lblPersen2.Text = String.Format("{0:F2}", d) + "%"
        b = lblSuara3.Text
        d = b * 100 / c
        lblPersen3.Text = String.Format("{0:F2}", d) + "%"
    End Sub

    Private Sub btnMin2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnMin2.Click
        Dim a As Decimal
        a = lblSuaraMasuk.Text
        a = a - 1
        lblSuaraMasuk.Text = a.ToString
        a = lblSuaraSah.Text
        a = a - 1
        lblSuaraSah.Text = a.ToString

        a = lblSuara2.Text
        a = a - 1
        lblSuara2.Text = a.ToString

        Dim b As Double
        Dim c As Double
        Dim d As Double
        c = lblSuaraSah.Text
        b = lblSuara1.Text
        d = b * 100 / c
        lblPersen1.Text = String.Format("{0:F2}", d) + "%"
        b = lblSuara2.Text
        d = b * 100 / c
        lblPersen2.Text = String.Format("{0:F2}", d) + "%"
        b = lblSuara3.Text
        d = b * 100 / c
        lblPersen3.Text = String.Format("{0:F2}", d) + "%"
    End Sub

    Private Sub btnMin3_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnMin3.Click
        Dim a As Decimal
        a = lblSuaraMasuk.Text
        a = a - 1
        lblSuaraMasuk.Text = a.ToString
        a = lblSuaraSah.Text
        a = a - 1
        lblSuaraSah.Text = a.ToString

        a = lblSuara3.Text
        a = a - 1
        lblSuara3.Text = a.ToString

        Dim b As Double
        Dim c As Double
        Dim d As Double
        c = lblSuaraSah.Text
        b = lblSuara1.Text
        d = b * 100 / c
        lblPersen1.Text = String.Format("{0:F2}", d) + "%"
        b = lblSuara2.Text
        d = b * 100 / c
        lblPersen2.Text = String.Format("{0:F2}", d) + "%"
        b = lblSuara3.Text
        d = b * 100 / c
        lblPersen3.Text = String.Format("{0:F2}", d) + "%"
    End Sub

    Private Sub btnMinTidakSah_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles btnMinTidakSah.Click
        Dim a As Decimal
        a = lblSuaraTidakSah.Text
        a = a - 1
        lblSuaraTidakSah.Text = a.ToString
        a = lblSuaraMasuk.Text
        a = a - 1
        lblSuaraMasuk.Text = a.ToString
    End Sub

End Class
