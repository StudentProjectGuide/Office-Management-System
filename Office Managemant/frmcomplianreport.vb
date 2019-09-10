Imports System.Data
Imports System.Data.SqlClient
Public Class FRMcOMPLIANrEPORT

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            Dim da As New SqlDataAdapter
            Dim ds As New DataSet
            da = New SqlDataAdapter("select * from compliant where status='Solved'", con)
            ds.Clear()
            da.Fill(ds, "compliant")
            Dim mt As New CrystalReport2
            mt.SetDataSource(ds)

            CrystalReportViewer1.ReportSource = mt
            mt.Refresh()
            CrystalReportViewer1.Show()
        Else
            Dim da As New SqlDataAdapter
            Dim ds As New DataSet
            da = New SqlDataAdapter("select * from compliant where status='Not Solved'", con)
            ds.Clear()
            da.Fill(ds, "compliant")
            Dim mt As New CrystalReport2
            mt.SetDataSource(ds)

            CrystalReportViewer1.ReportSource = mt
            mt.Refresh()
            CrystalReportViewer1.Show()
        End If

    End Sub

    Private Sub FRMcOMPLIANrEPORT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        da = New SqlDataAdapter("select * from compliant", con)
        ds.Clear()
        da.Fill(ds, "compliant")
        Dim mt As New CrystalReport2
        mt.SetDataSource(ds)

        CrystalReportViewer1.ReportSource = mt
        mt.Refresh()
        CrystalReportViewer1.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        CheckBox2.Checked = False
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        CheckBox1.Checked = False
    End Sub
End Class