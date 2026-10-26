Imports System.Data.SqlClient

Public Class frm_CheckCurrent_MRB

    Private Sub frm_CheckCurrent_MRB_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_Search_Click(sender As Object, e As EventArgs) Handles btn_Search.Click
        Dim str_Query As String = "
            select UGPN, MfgPN, Mfger, PO, LotCode, DateCode, UserName, DateRevc, StorageLoc, ParentComponentID,
            DateExpire, OriginQty as Remain_Qty, MSL, Description, VENDOR, CreatedDate
            from ComponentIDController_WH
            where ComponentIDController_WH.MRB = 1 and ComponentIDController_WH.OriginQty > 0"
        If txt_ComponentID.Text.Trim = "" And txt_ugpn.Text.Trim = "" Then
            str_Query = "
            select UGPN, MfgPN, Mfger, PO, LotCode, DateCode, UserName, DateRevc, StorageLoc, ParentComponentID,
            DateExpire, OriginQty as Remain_Qty, MSL, Description, VENDOR, CreatedDate
            from ComponentIDController_WH
            where ComponentIDController_WH.MRB = 1 and ComponentIDController_WH.OriginQty > 0"
        ElseIf txt_ugpn.Text.Trim <> "" And txt_ComponentID.Text.Trim = "" Then
            str_Query = "
            select UGPN, MfgPN, Mfger, PO, LotCode, DateCode, UserName, DateRevc, StorageLoc, ParentComponentID,
            DateExpire, OriginQty as Remain_Qty, MSL, Description, VENDOR, CreatedDate
            from ComponentIDController_WH
            where ComponentIDController_WH.MRB = 1 and ComponentIDController_WH.OriginQty > 0 and UGPN = @UGPN"
        Else
            str_Query = "
            select  a.UGPN,b.ComponentID,a.MfgPN, Mfger, PO, LotCode, DateCode, UserName, DateRevc, StorageLoc, ParentComponentID,
                DateExpire, OriginQty as Remain_Qty, MSL, Description, VENDOR, a.CreatedDate
                from ComponentIDController_WH as a										--- a: ComponentIDController_WH
                inner join ComponentID_tbl_WH as b										--- b: ComponentID_tbl_WH
	                on a.ControlID = b.ControllID
                where a.MRB = 1 and a.OriginQty > 0
                and a.UGPN = @UGPN
                and b.ComponentID = @ComponentID"
        End If
        Dim conn As New SqlConnection(Datalayer.GetConnection.ConnectionString)
        conn.Open()
        Try
            Dim cmd As New SqlCommand(str_Query, conn)
            cmd.Parameters.Add("@UGPN", SqlDbType.NVarChar).Value = txt_ugpn.Text.Trim().ToString()
            cmd.Parameters.Add("@ComponentID", SqlDbType.NVarChar).Value = txt_ComponentID.Text.Trim().ToString()
            Dim dt As New DataTable()
            Dim adap As New SqlDataAdapter(cmd)
            adap.Fill(dt)
            DataGridView1.DataSource = dt
            lbl_Total.Text = dt.Rows.Count.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally

        End Try

    End Sub
End Class