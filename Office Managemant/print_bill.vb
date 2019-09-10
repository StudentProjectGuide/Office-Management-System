Imports System.Data
Imports System.Data.SqlClient

Public Class print_bill

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub print_bill_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        da = New SqlDataAdapter("select * from bill_print order by billno", con)
        ds.Clear()
        da.Fill(ds, "bill_print")
        Dim mt As New CrystalReport1
        mt.SetDataSource(ds)

        CrystalReportViewer1.ReportSource = mt
        mt.Refresh()
        CrystalReportViewer1.Show()
    End Sub
End Class
