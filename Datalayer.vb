Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.Data.OleDb
Imports System
Imports Oracle.DataAccess.Client
Imports Oracle.DataAccess.Types

Imports System.Net
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.IO

 

Public Class Datalayer
    

    'Public Shared Function GetConnection() As SqlConnection
    '    Dim ConnectionStr As String = "Data Source =192.168.1.48; Initial Catalog=UnigenTrax;User ID=sa;Password=p@ssw0rd;"
    '    Return New SqlConnection(ConnectionStr)

    'End Function

    Public Shared Function GetConnection() As SqlConnection
        ' Dim connectionString As String = "Data Source=192.168.1.70;Initial Catalog=UnigenTrax;User ID=UnigenTrax;Password=Trax123; " 'providerName = System.Data.SqlClient"
        Dim connectionString As String = "Data Source=172.16.1.66;Initial Catalog=UnigenTrax;User ID=philip;Password=philipp@n2004; " 'providerName = System.Data.SqlClient"
        Dim connectionString_26 As String = "Data Source=UGHNSQL1\UGHNSQL1;Initial Catalog=WI;User ID=sa;Password=p@ssw0rd; " 'providerName = System.Data.SqlClient"
        'Dim connectionString As String = "Data Source=10.0.0.12;Initial Catalog=UnigenTrax;User ID=UnigenTrax;Password=Trax123; " 'providerName = System.Data.SqlClient"



        '' Dim connectionString As String = "Data Source=192.168.1.41;Initial Catalog=UnigenTrax;User ID=sa;Password=p@ssw0rd; " 'providerName = System.Data.SqlClient"

        'Dim connectionString As String _
        ' = "Data Source=(local);Initial Catalog=UnigenTrax;Persist Security Info=True;User ID=sa;Password=p@ssw0rd"
        ' ''    = "Data Source=192.168.1.70;Initial Catalog=UnigenTrax;User ID=UnigenTrax;Password=Trax123; " 'providerName = System.Data.SqlClient"
        Return New SqlConnection(connectionString)
    End Function

     Public Username As String = "None"

    Public Shared Function getDataset(ByVal [select] As String) As DataSet
        Using conn As SqlConnection = New SqlConnection(GetConnection.ConnectionString)
            Dim da As SqlDataAdapter = New SqlDataAdapter([select], conn)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds)
            Return ds
        End Using
    End Function

    Public Shared Function DataTable_Sql(ByVal sql As String) As DataTable
        Try

            Using conn As SqlConnection = New SqlConnection(GetConnection.ConnectionString)

                Using dap As SqlDataAdapter = New SqlDataAdapter(sql, conn)

                    Using ds As DataSet = New DataSet()
                        dap.Fill(ds)
                        conn.Close()
                        conn.Dispose()
                        Return ds.Tables(0)
                    End Using
                End Using
            End Using

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function


    Public Function PopulateForm(ByVal Ten_Thu_tuc As String) As SqlDataReader
        Dim SqlDr As SqlDataReader
        Try
            Dim SqlConn As SqlConnection = New SqlConnection

            SqlConn.ConnectionString = Strconn_66
            SqlConn.Open()
            Dim Sqlcmd As SqlCommand = New SqlCommand("" & Ten_Thu_tuc & "", SqlConn)
            SqlDr = Sqlcmd.ExecuteReader
            'SqlConn.Close()
            'SqlConn.Dispose()

        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try
        Return SqlDr
        'SqlDr.Close()

    End Function

    Public Shared Function GetConnection1() As SqlConnection
        ' Dim connectionString As String = "Data Source=192.168.1.70;Initial Catalog=UnigenTrax;User ID=UnigenTrax;Password=Trax123; " 'providerName = System.Data.SqlClient"
        'Dim connectionString As String = "Data Source=172.16.1.66;Initial Catalog=UnigenTrax;User ID=philip;Password=philipp@n2004; " 'providerName = System.Data.SqlClient"
        Dim connectionString_26 As String = "Data Source=UGHNSQL1\UGHNSQL1;Initial Catalog=WI;User ID=sa;Password=p@ssw0rd; " 'providerName = System.Data.SqlClient"
        'Dim connectionString As String = "Data Source=10.0.0.12;Initial Catalog=UnigenTrax;User ID=UnigenTrax;Password=Trax123; " 'providerName = System.Data.SqlClient"



        '' Dim connectionString As String = "Data Source=192.168.1.41;Initial Catalog=UnigenTrax;User ID=sa;Password=p@ssw0rd; " 'providerName = System.Data.SqlClient"

        'Dim connectionString As String _
        ' = "Data Source=(local);Initial Catalog=UnigenTrax;Persist Security Info=True;User ID=sa;Password=p@ssw0rd"
        ' ''    = "Data Source=192.168.1.70;Initial Catalog=UnigenTrax;User ID=UnigenTrax;Password=Trax123; " 'providerName = System.Data.SqlClient"
        Return New SqlConnection(connectionString_26)
    End Function

    Public Shared Function GetConnectionUS() As SqlConnection
        Dim connectionString_us As String = "Data Source=192.168.7.70;Initial Catalog=MSL;User ID=sa;Password=p@ssw0rd; " 'providerName = System.Data.SqlClient"
        Return New SqlConnection(connectionString_us)
    End Function



    'Public Shared Function GetOracleConnection() As OracleConnection
    '    Dim connectionString As String = "User ID=apps;password=apps4unigen;Data Source=192.168.1.71:1521/PROD;Persist Security Info=False"
    '    Return New OracleConnection(connectionString)
    'End Function

    Public Shared Function GetOracleConnection() As OracleConnection
        Dim connectionString As String = "User ID=appsr;password=Unigen123;Data Source=192.168.1.21:1541/PROD;Persist Security Info=False"
        Return New OracleConnection(connectionString)
    End Function

    ' Philip modify 6/1/2022

    '<DataObjectMethod(DataObjectMethodType.Fill)> _
    'Public Function dsGetFromOracle(ByVal RECEIPT_NUM As String, ByVal SHIPMENT_LINE_ID As String) As DataSet
    '    ' Dim sConnectionString As String _
    '    '= "User ID=apps;password=apps4unigen;Data Source=192.168.1.71:1521/PROD;Persist Security Info=False"
    '    ' ''= "Provider=MSDAORA.1;User ID=apps;password=apps4unigen;Data Source=192.168.1.71:1521/PROD;Persist Security Info=False"
    '    '' for testing : 
    '    '  Dim sConnectionString As String = "Provider=MSDAORA.1;User ID=apps;password=apps4unigen;Data Source=192.168.1.50:1521/Test;Persist Security Info=False"



    '    Dim myConnection As OracleConnection = GetOracleConnection()
    '    Dim mySelectQuery As String

    '    If SHIPMENT_LINE_ID <> "" Then
    '        ''   mySelectQuery = "select * from apps.ug_label_printing1 Where SHIPMENT_LINE_ID = '" & SHIPMENT_LINE_ID & "'"

    '        mySelectQuery = "SELECT rsh.receipt_num, rt.shipment_line_id, pha.segment1 po_number, msi.segment1  unigen_item_code, " & _
    '                              "pla.attribute11 mfg_part_number, pla.attribute10 manufacturer, " & _
    '                              "rt.attribute3 mfr_lot_code, rt.attribute4 mfr_date_code,  " & _
    '                              "rt.quantity, rt.attribute5 ug_locator, 1 as  num_of_copies, 1 as num_of_Serial_lbl,  " & _
    '                              "pla.item_Description description, " & _
    '                              "NVL(PO_V.Attribute3,'N/A')  as tier " & _
    '                             " FROM rcv_transactions rt,  " & _
    '                              "rcv_shipment_headers rsh, " & _
    '                              "po_headers_all pha, " & _
    '                              "po_lines_all pla, " & _
    '                             " mtl_system_items_b msi, " & _
    '                             " PO_VENDORS  PO_V " & _
    '                             " WHERE rt.shipment_header_id = rsh.shipment_header_id  " & _
    '                             " AND rt.po_header_id = pha.po_header_id " & _
    '                             " AND rt.po_line_id = pla.po_line_id " & _
    '                             " AND pha.po_header_id = pla.po_header_id " & _
    '                             " AND pla.item_id = msi.inventory_item_id  " & _
    '                             " AND rt.organization_id = msi.organization_id " & _
    '                              "and pha.VENDOR_ID=PO_V.VENDOR_ID " & _
    '                             " AND rt.transaction_type = 'RECEIVE' " & _
    '                             " AND  msi.ORGANIZATION_ID='142' " & _
    '                              "and rsh.receipt_num='" & RECEIPT_NUM & "'"

    '    ElseIf RECEIPT_NUM <> "" Then
    '        '  mySelectQuery = "select * from apps.ug_label_printing1 Where RECEIPT_NUM = '" & RECEIPT_NUM & "'"
    '        'mySelectQuery = "SELECT rsh.receipt_num, rt.shipment_line_id, pha.segment1 po_number, msi.segment1  unigen_item_code, " & _
    '        '                   " pla.attribute3 mfg_part_number, pla.attribute2 manufacturer, " & _
    '        '        " rt.attribute3 mfr_lot_code, rt.attribute4 mfr_date_code, " & _
    '        '        " rt.quantity, rt.attribute5 ug_locator, 1 as  num_of_copies, 1 as num_of_Serial_lbl " & _
    '        '          " FROM rcv_transactions rt, " & _
    '        '        " rcv_shipment_headers rsh, " & _
    '        '        " po_headers_all pha, " & _
    '        '        " po_lines_all pla, " & _
    '        '          " mtl_system_items_b(msi) " & _
    '        '          " WHERE(rt.shipment_header_id = rsh.shipment_header_id) " & _
    '        '       " AND rt.po_header_id = pha.po_header_id " & _
    '        '       " AND rt.po_line_id = pla.po_line_id " & _
    '        '      " AND pha.po_header_id = pla.po_header_id " & _
    '        '      " AND pla.item_id = msi.inventory_item_id " & _
    '        '      " AND rt.organization_id = msi.organization_id " & _
    '        '       " AND rt.transaction_type = 'RECEIVE' " & _
    '        '       " and rsh.receipt_num= '" & RECEIPT_NUM & "'"



    '        mySelectQuery = ""
    '        mySelectQuery = "SELECT rsh.receipt_num, rt.shipment_line_id, pha.segment1 po_number, msi.segment1  unigen_item_code, " & _
    '                                "pla.attribute11 mfg_part_number, pla.attribute10 manufacturer, " & _
    '                                "rt.attribute3 mfr_lot_code, rt.attribute4 mfr_date_code,  " & _
    '                                "rt.quantity, rt.attribute5 ug_locator, 1 as  num_of_copies, 1 as num_of_Serial_lbl,  " & _
    '                                "pla.item_Description description, " & _
    '                                "NVL(PO_V.Attribute3,'N/A')  as tier " & _
    '                               " FROM rcv_transactions rt,  " & _
    '                                "rcv_shipment_headers rsh, " & _
    '                                "po_headers_all pha, " & _
    '                                "po_lines_all pla, " & _
    '                               " mtl_system_items_b msi, " & _
    '                               " PO_VENDORS  PO_V " & _
    '                               " WHERE rt.shipment_header_id = rsh.shipment_header_id  " & _
    '                               " AND rt.po_header_id = pha.po_header_id " & _
    '                               " AND rt.po_line_id = pla.po_line_id " & _
    '                               " AND pha.po_header_id = pla.po_header_id " & _
    '                               " AND pla.item_id = msi.inventory_item_id  " & _
    '                               " AND rt.organization_id = msi.organization_id " & _
    '                                "and pha.VENDOR_ID=PO_V.VENDOR_ID " & _
    '                               " AND rt.transaction_type = 'RECEIVE' " & _
    '                               " AND  msi.ORGANIZATION_ID='142' " & _
    '                                "and rsh.receipt_num='" & RECEIPT_NUM & "'"


    '    Else
    '        'mySelectQuery = "select * from apps.ug_label_printing1 Where 1=2"
    '        mySelectQuery = "SELECT rsh.receipt_num, rt.shipment_line_id, pha.segment1 po_number, msi.segment1  unigen_item_code, " & _
    '                               "pla.attribute11 mfg_part_number, pla.attribute10 manufacturer, " & _
    '                               "rt.attribute3 mfr_lot_code, rt.attribute4 mfr_date_code,  " & _
    '                               "rt.quantity, rt.attribute5 ug_locator, 1 as  num_of_copies, 1 as num_of_Serial_lbl,  " & _
    '                               "pla.item_Description description, " & _
    '                               "NVL(PO_V.Attribute3,'N/A')  as tier " & _
    '                              " FROM rcv_transactions rt,  " & _
    '                               "rcv_shipment_headers rsh, " & _
    '                               "po_headers_all pha, " & _
    '                               "po_lines_all pla, " & _
    '                              " mtl_system_items_b msi, " & _
    '                              " PO_VENDORS  PO_V " & _
    '                              " WHERE rt.shipment_header_id = rsh.shipment_header_id  " & _
    '                              " AND rt.po_header_id = pha.po_header_id " & _
    '                              " AND rt.po_line_id = pla.po_line_id " & _
    '                              " AND pha.po_header_id = pla.po_header_id " & _
    '                              " AND pla.item_id = msi.inventory_item_id  " & _
    '                              " AND rt.organization_id = msi.organization_id " & _
    '                               "and pha.VENDOR_ID=PO_V.VENDOR_ID " & _
    '                              " AND rt.transaction_type = 'RECEIVE' " & _
    '                              " AND  msi.ORGANIZATION_ID='142' " & _
    '                               "and rsh.receipt_num='" & RECEIPT_NUM & "'"


    '    End If

    '    Dim da As New OracleDataAdapter()

    '    da.SelectCommand = New OracleCommand(mySelectQuery, myConnection)

    '    Dim ds As New DataSet

    '    Try
    '        myConnection.Open()
    '        da.Fill(ds, "OracleLabel")
    '        myConnection.Close()
    '    Catch ex As OracleException
    '        ' Throw
    '        MessageBox.Show(ex.Message)
    '    Finally
    '        myConnection.Close()
    '    End Try
    '    Return ds

    'End Function


    'end

    <DataObjectMethod(DataObjectMethodType.Fill)> _
    Public Function dsGetFromOracle(ByVal RECEIPT_NUM As String, ByVal SHIPMENT_LINE_ID As String) As DataSet


        Dim myConnection As OracleConnection = GetOracleConnection()
        Dim mySelectQuery As String

        If SHIPMENT_LINE_ID <> "" Then

            mySelectQuery = "SELECT rsh.receipt_num, rt.shipment_line_id, pha.segment1 po_number, msi.segment1  unigen_item_code, " & _
                    "UPPER(NVL(rt.attribute8, pla.attribute11))  mfg_part_number, pla.attribute10 manufacturer, " & _
                    "rt.attribute3 mfr_lot_code, rt.attribute4 mfr_date_code,  " & _
                    "rt.quantity, rt.attribute5 ug_locator, 1 as  num_of_copies, 1 as num_of_Serial_lbl,  " & _
                    "pla.item_Description description, " & _
                    "NVL(PO_V.Attribute3,'N/A')  as tier, " & _
                    "PO_V.VENDOR_NAME " & _
                   " FROM rcv_transactions rt,  " & _
                    "rcv_shipment_headers rsh, " & _
                    "po_headers_all pha, " & _
                    "po_lines_all pla, " & _
                   " mtl_system_items_b msi, " & _
                   " PO_VENDORS  PO_V " & _
                   " WHERE rt.shipment_header_id = rsh.shipment_header_id  " & _
                   " AND rt.po_header_id = pha.po_header_id " & _
                   " AND rt.po_line_id = pla.po_line_id " & _
                   " AND pha.po_header_id = pla.po_header_id " & _
                   " AND pla.item_id = msi.inventory_item_id  " & _
                   " AND rt.organization_id = msi.organization_id " & _
                    "and pha.VENDOR_ID=PO_V.VENDOR_ID " & _
                   " AND rt.transaction_type = 'RECEIVE' " & _
                   " AND  msi.ORGANIZATION_ID='142' " & _
                    "and rsh.receipt_num='" & RECEIPT_NUM & "'"

        ElseIf RECEIPT_NUM <> "" Then

            mySelectQuery = "SELECT rsh.receipt_num, rt.shipment_line_id, pha.segment1 po_number, msi.segment1  unigen_item_code, " & _
                    "UPPER(NVL(rt.attribute8, pla.attribute11)) mfg_part_number, pla.attribute10 manufacturer, " & _
                    "rt.attribute3 mfr_lot_code, rt.attribute4 mfr_date_code,  " & _
                    "rt.quantity, rt.attribute5 ug_locator, 1 as  num_of_copies, 1 as num_of_Serial_lbl,  " & _
                    "pla.item_Description description, " & _
                    "NVL(PO_V.Attribute3,'N/A')  as tier, " & _
                    "PO_V.VENDOR_NAME " & _
                    "FROM rcv_transactions rt,  " & _
                    "rcv_shipment_headers rsh, " & _
                    "po_headers_all pha, " & _
                    "po_lines_all pla, " & _
                   " mtl_system_items_b msi, " & _
                   " PO_VENDORS  PO_V " & _
                   " WHERE rt.shipment_header_id = rsh.shipment_header_id  " & _
                   " AND rt.po_header_id = pha.po_header_id " & _
                   " AND rt.po_line_id = pla.po_line_id " & _
                   " AND pha.po_header_id = pla.po_header_id " & _
                   " AND pla.item_id = msi.inventory_item_id  " & _
                   " AND rt.organization_id = msi.organization_id " & _
                    "and pha.VENDOR_ID=PO_V.VENDOR_ID " & _
                   " AND rt.transaction_type = 'RECEIVE' " & _
                   " AND  msi.ORGANIZATION_ID='142' " & _
                   "and rsh.receipt_num='" & RECEIPT_NUM & "'"

        Else
            mySelectQuery = "SELECT rsh.receipt_num, rt.shipment_line_id, pha.segment1 po_number, msi.segment1  unigen_item_code, " & _
                    "UPPER(NVL(rt.attribute8, pla.attribute11)) mfg_part_number, pla.attribute10 manufacturer, " & _
                    "rt.attribute3 mfr_lot_code, rt.attribute4 mfr_date_code,  " & _
                    "rt.quantity, rt.attribute5 ug_locator, 1 as  num_of_copies, 1 as num_of_Serial_lbl,  " & _
                    "pla.item_Description description, " & _
                    "NVL(PO_V.Attribute3,'N/A')  as tier, " & _
                    "PO_V.VENDOR_NAME " & _
                   " FROM rcv_transactions rt,  " & _
                    "rcv_shipment_headers rsh, " & _
                    "po_headers_all pha, " & _
                    "po_lines_all pla, " & _
                   " mtl_system_items_b msi, " & _
                   " PO_VENDORS  PO_V " & _
                   " WHERE rt.shipment_header_id = rsh.shipment_header_id  " & _
                   " AND rt.po_header_id = pha.po_header_id " & _
                   " AND rt.po_line_id = pla.po_line_id " & _
                   " AND pha.po_header_id = pla.po_header_id " & _
                   " AND pla.item_id = msi.inventory_item_id  " & _
                   " AND rt.organization_id = msi.organization_id " & _
                    "and pha.VENDOR_ID=PO_V.VENDOR_ID " & _
                   " AND rt.transaction_type = 'RECEIVE' " & _
                   " AND  msi.ORGANIZATION_ID='142' " & _
                   "and rsh.receipt_num='" & RECEIPT_NUM & "'"

        End If


        Dim da As New OracleDataAdapter()

        da.SelectCommand = New OracleCommand(mySelectQuery, myConnection)

        Dim ds As New DataSet

        Try
            myConnection.Open()
            da.Fill(ds, "OracleLabel")
            myConnection.Close()
        Catch ex As OracleException
            ' Throw
            MessageBox.Show(ex.Message)
        Finally
            myConnection.Close()
        End Try
        Return ds

    End Function



    <DataObjectMethod(DataObjectMethodType.Fill)> _
       Public Function GetdsUser(ByVal UserID As String) As DataSet
        Dim sqlcon As SqlConnection = GetConnection()
        Dim cmd As New SqlCommand("p_selectuser", sqlcon)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "p_selectuser"
        Dim daDB As New SqlClient.SqlDataAdapter
        Dim ds As New DataSet


        Dim pmtemp As SqlParameter

        pmtemp = cmd.Parameters.Add(New SqlParameter("@UserID", SqlDbType.NVarChar, 20))
        If UserID = Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = UserID
        End If
        Try
            daDB = New SqlDataAdapter(cmd)
            daDB.Fill(ds, "UserID")
            Return ds

        Catch ex As Exception
            Throw
        Finally
            With cmd.Connection
                If .State = ConnectionState.Open Then
                    .Close()
                End If
            End With
        End Try
    End Function


    <DataObjectMethod(DataObjectMethodType.Fill)> _
              Public Function GetdsReprintLabel(ByVal ComponentID As String) As DataSet
        'Dim sqlcon As SqlConnection = Conn.GetConnection
        Dim cmd As New SqlCommand("p_SelectReprintLabel", GetConnection)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "p_SelectReprintLabel"
        Dim daDB As New SqlClient.SqlDataAdapter
        Dim ds As New DataSet
        Dim pmtemp As SqlParameter
        pmtemp = cmd.Parameters.Add(New SqlParameter("@ComponentID", SqlDbType.NVarChar, 50))
        If ComponentID = Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = ComponentID
        End If
        Try
            daDB = New SqlDataAdapter(cmd)
            daDB.Fill(ds, "Compontlabel")
            Return ds

        Catch ex As Exception
            Throw
        Finally
            With cmd.Connection
                If .State = ConnectionState.Open Then
                    .Close()
                End If
            End With
        End Try
    End Function


    <DataObjectMethod(DataObjectMethodType.Fill)> _
         Public Function GetdsComponentinfoByComponentID(ByVal ComponentID As String) As DataSet
        'Dim sqlcon As SqlConnection = Conn.GetConnection
        Dim cmd As New SqlCommand("p_SelectComponentinfoByComponentID1", GetConnection)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "p_SelectComponentinfoByComponentID1"
        Dim daDB As New SqlClient.SqlDataAdapter
        Dim ds As New DataSet
        Dim pmtemp As SqlParameter
        pmtemp = cmd.Parameters.Add(New SqlParameter("@ComponentID", SqlDbType.NVarChar, 50))
        If ComponentID = Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = ComponentID
        End If
        Try
            daDB = New SqlDataAdapter(cmd)
            daDB.Fill(ds, "ComponentInfo")
            Return ds

        Catch ex As Exception
            Throw
        Finally
            With cmd.Connection
                If .State = ConnectionState.Open Then
                    .Close()
                End If
            End With
        End Try
    End Function
    <DataObjectMethod(DataObjectMethodType.Fill)> _
         Public Function GetdsComponentinfoByComponentID_Product(ByVal ComponentID As String) As DataSet
        'Dim sqlcon As SqlConnection = Conn.GetConnection
        Dim cmd As New SqlCommand("p_SelectComponentinfoByComponentID_", GetConnection) 'new
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "p_SelectComponentinfoByComponentID_"
        Dim daDB As New SqlClient.SqlDataAdapter
        Dim ds As New DataSet
        Dim pmtemp As SqlParameter
        pmtemp = cmd.Parameters.Add(New SqlParameter("@ComponentID", SqlDbType.NVarChar, 50))
        If ComponentID = Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = ComponentID
        End If
        Try
            daDB = New SqlDataAdapter(cmd)
            daDB.Fill(ds, "ComponentInfo")
            Return ds

        Catch ex As Exception
            Throw
        Finally
            With cmd.Connection
                If .State = ConnectionState.Open Then
                    .Close()
                End If
            End With
        End Try
    End Function
    <DataObjectMethod(DataObjectMethodType.Fill)> _
        Public Function GetdsDateCode_FIFO(ByVal ComponentID As String, ByVal UGPN As String) As DataSet
        'Dim sqlcon As SqlConnection = Conn.GetConnection
        Dim cmd As New SqlCommand("p_CheckFIFO_DATECODE", GetConnection) 'new
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "p_CheckFIFO_DATECODE"
        Dim daDB As New SqlClient.SqlDataAdapter
        Dim ds As New DataSet
        Dim pmtemp As SqlParameter
        pmtemp = cmd.Parameters.Add(New SqlParameter("@ComponentID", SqlDbType.NVarChar, 50))
        If ComponentID = Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = ComponentID
        End If
        pmtemp.Direction = ParameterDirection.Input


        pmtemp = cmd.Parameters.Add(New SqlParameter("@UGPN", SqlDbType.NVarChar, 40))
        If UGPN = Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = UGPN
        End If
        pmtemp.Direction = ParameterDirection.Input

     
        Try
            daDB = New SqlDataAdapter(cmd)
            daDB.Fill(ds, "ComponentInfo")
            Return ds

        Catch ex As Exception
            Throw
        Finally
            With cmd.Connection
                If .State = ConnectionState.Open Then
                    .Close()
                End If
            End With
        End Try
    End Function
    <DataObjectMethod(DataObjectMethodType.Fill)> _
        Public Function GetdsComponentinfoByComponentID_Reprint(ByVal ComponentID As String) As DataSet 'old
        'Dim sqlcon As SqlConnection = Conn.GetConnection
        Dim cmd As New SqlCommand("p_SelectComponentinfoByComponentID_1", GetConnection)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "p_SelectComponentinfoByComponentID_1"
        Dim daDB As New SqlClient.SqlDataAdapter
        Dim ds As New DataSet
        Dim pmtemp As SqlParameter
        pmtemp = cmd.Parameters.Add(New SqlParameter("@ComponentID", SqlDbType.NVarChar, 50))
        If ComponentID = Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = ComponentID
        End If
        Try
            daDB = New SqlDataAdapter(cmd)
            daDB.Fill(ds, "ComponentInfo")
            Return ds

        Catch ex As Exception
            Throw
        Finally
            With cmd.Connection
                If .State = ConnectionState.Open Then
                    .Close()
                End If
            End With
        End Try
    End Function

    'jerry add new for origin qty
    <DataObjectMethod(DataObjectMethodType.Fill)> _
         Public Function GetdsComponentinfoByComponentID_(ByVal ComponentID As String) As DataSet
        'Dim sqlcon As SqlConnection = Conn.GetConnection
        Dim cmd As New SqlCommand("p_SelectComponentinfoByComponentID1_New", GetConnection)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "p_SelectComponentinfoByComponentID1_New"
        Dim daDB As New SqlClient.SqlDataAdapter
        Dim ds As New DataSet
        Dim pmtemp As SqlParameter
        pmtemp = cmd.Parameters.Add(New SqlParameter("@ComponentID", SqlDbType.NVarChar, 50))
        If ComponentID = Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = ComponentID
        End If
        Try
            daDB = New SqlDataAdapter(cmd)
            daDB.Fill(ds, "ComponentInfo")
            Return ds

        Catch ex As Exception
            Throw
        Finally
            With cmd.Connection
                If .State = ConnectionState.Open Then
                    .Close()
                End If
            End With
        End Try
    End Function

    <DataObjectMethod(DataObjectMethodType.Fill)> _
          Public Function GetdsCompontByPO(ByVal PO As String) As DataSet
        'Dim sqlcon As SqlConnection = Conn.GetConnection
        Dim cmd As New SqlCommand("p_SelectCompontByPO", GetConnection)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "p_SelectCompontByPO"
        Dim daDB As New SqlClient.SqlDataAdapter
        Dim ds As New DataSet
        Dim pmtemp As SqlParameter
        pmtemp = cmd.Parameters.Add(New SqlParameter("@PO", SqlDbType.NVarChar, 20))
        If PO = Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = PO
        End If
        Try
            daDB = New SqlDataAdapter(cmd)
            daDB.Fill(ds, "Compont")
            Return ds

        Catch ex As Exception
            Throw
        Finally
            With cmd.Connection
                If .State = ConnectionState.Open Then
                    .Close()
                End If
            End With
        End Try
    End Function


    <DataObjectMethod(DataObjectMethodType.Fill)> _
      Public Function GetdsCompontByPN(ByVal PN As String) As DataSet
        'Dim sqlcon As SqlConnection = Conn.GetConnection
        Dim cmd As New SqlCommand("p_SelectCompontByPN", GetConnection)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "p_SelectCompontByPN"
        Dim daDB As New SqlClient.SqlDataAdapter
        Dim ds As New DataSet
        Dim pmtemp As SqlParameter
        pmtemp = cmd.Parameters.Add(New SqlParameter("@PN", SqlDbType.NVarChar, 50))
        If PN = Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = PN
        End If
        Try
            daDB = New SqlDataAdapter(cmd)
            daDB.Fill(ds, "Compont")
            Return ds

        Catch ex As Exception
            Throw
        Finally
            With cmd.Connection
                If .State = ConnectionState.Open Then
                    .Close()
                End If
            End With
        End Try
    End Function


    <DataObjectMethod(DataObjectMethodType.Fill)> _
    Public Function GetdsCompontByID(ByVal CompontID As String) As DataSet
        'Dim sqlcon As SqlConnection = Conn.GetConnection
        Dim cmd As New SqlCommand("p_SelectCompontByID", GetConnection)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "p_SelectCompontByID"
        Dim daDB As New SqlClient.SqlDataAdapter
        Dim ds As New DataSet


        Dim pmtemp As SqlParameter

        pmtemp = cmd.Parameters.Add(New SqlParameter("@ComponentID", SqlDbType.NVarChar, 50))
        If CompontID = Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = CompontID
        End If
        Try
            daDB = New SqlDataAdapter(cmd)
            daDB.Fill(ds, "Component")
            Return ds

        Catch ex As Exception
            Throw
        Finally
            With cmd.Connection
                If .State = ConnectionState.Open Then
                    .Close()
                End If
            End With
        End Try
    End Function


    '-- jerry add new get Unigen PN-------------
    <DataObjectMethod(DataObjectMethodType.Fill)> _
    Public Function GetdsUnigenPN(ByVal UGPN As String) As DataSet
        'Dim sqlcon As SqlConnection = Conn.GetConnection
        Dim cmd As New SqlCommand("Sp_GetUnigenPN", GetConnection)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Sp_GetUnigenPN"
        Dim daDB As New SqlClient.SqlDataAdapter
        Dim ds As New DataSet


        Dim pmtemp As SqlParameter

        pmtemp = cmd.Parameters.Add(New SqlParameter("@ugpn", SqlDbType.NVarChar, 50))
        If UGPN = Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = UGPN
        End If
        Try
            daDB = New SqlDataAdapter(cmd)
            daDB.Fill(ds, "UnigenPN")
            Return ds

        Catch ex As Exception
            Throw
        Finally
            With cmd.Connection
                If .State = ConnectionState.Open Then
                    .Close()
                End If
            End With
        End Try
    End Function

    '-- jerry add new get date_exchange -------------
    <DataObjectMethod(DataObjectMethodType.Fill)> _
    Public Function GetdsdateTime_Exchange(ByVal UGPN As String) As DataSet
        'Dim sqlcon As SqlConnection = Conn.GetConnection
        Dim cmd As New SqlCommand("Sp_GetDate_Exchage", GetConnection)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "Sp_GetDate_Exchage"
        Dim daDB As New SqlClient.SqlDataAdapter
        Dim ds As New DataSet


        Dim pmtemp As SqlParameter

        pmtemp = cmd.Parameters.Add(New SqlParameter("@ugpn", SqlDbType.NVarChar, 50))
        If UGPN = Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = UGPN
        End If
        Try
            daDB = New SqlDataAdapter(cmd)
            daDB.Fill(ds, "DateExchange")
            Return ds

        Catch ex As Exception
            Throw
        Finally
            With cmd.Connection
                If .State = ConnectionState.Open Then
                    .Close()
                End If
            End With
        End Try
    End Function


    'ALTER proc [dbo].[p_updateComponentinfo]
    '@NoOfPackages int, 
    '@QtyPerPackage int,
    '@PO NVARCHAR(20), 
    '@UGPN NVARCHAR(20), 
    '@MfgPN NVARCHAR(20), 
    '@Mfger NVARCHAR(20), 
    '@LotCode NVARCHAR(20), 
    '@DateCode NVARCHAR(20), 
    '@FirmWareVersion NVARCHAR(20), 
    '@UserName NVARCHAR(20), 
    '@Loc NVARCHAR(20), 
    '@ControlID int


    Public Sub UpdateComponentInfo(ByVal QtyPerPackage As Integer, _
    ByVal PO As String, _
    ByVal UGPN As String, _
    ByVal MfgPN As String, _
    ByVal Mfger As String, _
    ByVal LotCode As String, _
    ByVal DateCode As String, _
    ByVal FirmWare As String, _
    ByVal User As String, _
    ByVal Loc As String, _
    ByVal ControlID As Integer)


        Dim sqlcon As SqlConnection = GetConnection()
        Dim cmd As New SqlCommand("p_updateComponentinfo", sqlcon)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "p_updateComponentinfo"

        Dim pmtemp As SqlParameter
        'pmtemp = cmd.Parameters.Add(New SqlParameter("@NoOfPackages", SqlDbType.Int))
        'pmtemp.Value = NoOfPackages
        'pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@QtyPerPackage", SqlDbType.Int))
        If QtyPerPackage = 0 Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = QtyPerPackage
        End If
        pmtemp.Direction = ParameterDirection.Input


        pmtemp = cmd.Parameters.Add(New SqlParameter("@PO", SqlDbType.NVarChar, 20))
        pmtemp.Value = PO
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@UGPN", SqlDbType.NVarChar, 40))
        pmtemp.Value = UGPN
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@MfgPN", SqlDbType.NVarChar, 40))
        pmtemp.Value = MfgPN
        pmtemp.Direction = ParameterDirection.Input


        pmtemp = cmd.Parameters.Add(New SqlParameter("@Mfger", SqlDbType.NVarChar, 50))
        If Mfger Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = Mfger
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@LotCode", SqlDbType.NVarChar, 40))
        If LotCode Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = LotCode
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@DateCode", SqlDbType.NVarChar, 40))
        If DateCode Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = DateCode
        End If
        pmtemp.Direction = ParameterDirection.Input



        pmtemp = cmd.Parameters.Add(New SqlParameter("@FirmWareVersion", SqlDbType.NVarChar, 30))
        If FirmWare = "" Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = FirmWare
        End If
        pmtemp.Direction = ParameterDirection.Input




        pmtemp = cmd.Parameters.Add(New SqlParameter("@UserName", SqlDbType.NVarChar, 20))
        If User Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = User
        End If
        pmtemp.Direction = ParameterDirection.Input



        pmtemp = cmd.Parameters.Add(New SqlParameter("@Loc", SqlDbType.NVarChar, 40))
        If Loc Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = Loc
        End If
        pmtemp.Direction = ParameterDirection.Input



        pmtemp = cmd.Parameters.Add(New SqlParameter("@ControlID", SqlDbType.Int))
        If ControlID = Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = ControlID
        End If
        pmtemp.Direction = ParameterDirection.Input


        Try
            sqlcon.Open()
            cmd.ExecuteNonQuery()
            sqlcon.Close()

        Catch err As SqlClient.SqlException
            Throw
        Finally
            If sqlcon.State = ConnectionState.Open Then
                sqlcon.Close()
            End If

        End Try
    End Sub




    'jerry add new
    ' NoOfPackages=@NoOfPackages,PO=@PO,MfgPN=@MfgPN,UGPN=@UGPN,Mfger=@Mfger,LotCode=@LotCode, DateCode=@DateCode,  QtyPerPackage=@QtyPerPackage, StorageLoc = @StoLocation,UserName=@UserName 
    Public Function updateComponent_j(ByVal NoOfPackages As Integer, _
    ByVal PO As String, _
    ByVal MfgPN As String, _
    ByVal UGPN As String, _
    ByVal Mfger As String, _
    ByVal LotCode As String, _
    ByVal DateCode As String, _
    ByVal QtyPerPackage As Integer, _
    ByVal QtyOrigin As Integer, _
    ByVal StorageLoc As String, _
    ByVal User As String, ByVal ControlID As String) As DataSet



        Dim sqlcon As SqlConnection = GetConnection()
        ''ResetConnString()
        Dim cmd As New SqlCommand("p_updateComponent_j", sqlcon)
        Dim daDB As SqlClient.SqlDataAdapter
        Dim dsDB As New DataSet
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "p_updateComponent_j"



        Dim pmtemp As SqlParameter
        pmtemp = cmd.Parameters.Add(New SqlParameter("@NoOfPackages", SqlDbType.Int))
        pmtemp.Value = NoOfPackages
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@PO", SqlDbType.NVarChar, 20))
        If PO Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = PO
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@UGPN", SqlDbType.NVarChar, 20))
        If UGPN Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = UGPN
        End If
        pmtemp.Direction = ParameterDirection.Input


        pmtemp = cmd.Parameters.Add(New SqlParameter("@Mfger", SqlDbType.NVarChar, 20))
        If Mfger Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = Mfger
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@StoLocation", SqlDbType.NVarChar, 20))
        If StorageLoc Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = StorageLoc
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@QtyPerPackage", SqlDbType.Int))

        If QtyPerPackage = 0 Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = QtyPerPackage
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@QtyOrigin", SqlDbType.Int))

        If QtyOrigin = 0 Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = QtyOrigin
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@LotCode", SqlDbType.NVarChar, 40))
        If LotCode Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = LotCode
        End If
        pmtemp.Direction = ParameterDirection.Input


        pmtemp = cmd.Parameters.Add(New SqlParameter("@MfgPN", SqlDbType.NVarChar, 50))
        If MfgPN Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = MfgPN
        End If
        pmtemp.Direction = ParameterDirection.Input


        pmtemp = cmd.Parameters.Add(New SqlParameter("@DateCode", SqlDbType.NVarChar, 40))
        If DateCode Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = DateCode
        End If
        pmtemp.Direction = ParameterDirection.Input



        pmtemp = cmd.Parameters.Add(New SqlParameter("@UserName", SqlDbType.NVarChar, 20))
        If User Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = User
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@ControlID", SqlDbType.NVarChar, 20))
        If ControlID Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = ControlID
        End If
        pmtemp.Direction = ParameterDirection.Input



        Try
            daDB = New SqlClient.SqlDataAdapter(cmd)
            daDB.Fill(dsDB, "ProcessStation")
            Return dsDB
        Catch err As SqlClient.SqlException
            Throw
        Finally
            With cmd.Connection
                If .State = ConnectionState.Open Then
                    .Close()
                End If
            End With
        End Try
    End Function

    'jerry add new 
    Public Function Update_OriginQty(ByVal QtyPerPackage As Integer, _
    ByVal User As String, ByVal ControlID As String) As DataSet


        Dim sqlcon As SqlConnection = GetConnection()
        ''ResetConnString()
        Dim cmd As New SqlCommand("p_updateOriginQty", sqlcon)
        Dim daDB As SqlClient.SqlDataAdapter
        Dim dsDB As New DataSet
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "p_updateOriginQty"

        Dim pmtemp As SqlParameter

        pmtemp = cmd.Parameters.Add(New SqlParameter("@UserName", SqlDbType.NVarChar, 20))
        If User Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = User
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@ControlID", SqlDbType.NVarChar, 20))
        If ControlID Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = ControlID
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@QtyPerPackage", SqlDbType.Int))

        If QtyPerPackage = 0 Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = QtyPerPackage
        End If
        pmtemp.Direction = ParameterDirection.Input

        Try
            daDB = New SqlClient.SqlDataAdapter(cmd)
            daDB.Fill(dsDB, "ProcessStation")
            Return dsDB
        Catch err As SqlClient.SqlException
            Throw
        Finally
            With cmd.Connection
                If .State = ConnectionState.Open Then
                    .Close()
                End If
            End With
        End Try
    End Function
    'jerry add new 
    Public Function Update_Qty_reduce_new(ByVal QtyPerPackage As Integer, ByVal QtyOrigin As Integer, _
    ByVal User As String, ByVal ControlID As String) As DataSet


        Dim sqlcon As SqlConnection = GetConnection()
        ''ResetConnString()
        Dim cmd As New SqlCommand("p_updateQty_reduce", sqlcon)
        Dim daDB As SqlClient.SqlDataAdapter
        Dim dsDB As New DataSet
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "p_updateQty_reduce"

        Dim pmtemp As SqlParameter

        pmtemp = cmd.Parameters.Add(New SqlParameter("@UserName", SqlDbType.NVarChar, 20))
        If User Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = User
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@ControlID", SqlDbType.NVarChar, 20))
        If ControlID Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = ControlID
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@QtyPerPackage", SqlDbType.Int))

        If QtyPerPackage = 0 Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = QtyPerPackage
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@QtyOrigin", SqlDbType.Int))

        If QtyOrigin = 0 Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = QtyOrigin
        End If
        pmtemp.Direction = ParameterDirection.Input

        Try
            daDB = New SqlClient.SqlDataAdapter(cmd)
            daDB.Fill(dsDB, "ProcessStation")
            Return dsDB
        Catch err As SqlClient.SqlException
            Throw
        Finally
            With cmd.Connection
                If .State = ConnectionState.Open Then
                    .Close()
                End If
            End With
        End Try
    End Function
    Public Function Update_Qty_reduce_old(ByVal QtyPerPackage As Integer, _
  ByVal User As String, ByVal ControlID As String) As DataSet


        Dim sqlcon As SqlConnection = GetConnection()
        ''ResetConnString()
        Dim cmd As New SqlCommand("p_updateQty_reduce", sqlcon)
        Dim daDB As SqlClient.SqlDataAdapter
        Dim dsDB As New DataSet
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "p_updateQty_reduce"

        Dim pmtemp As SqlParameter

        pmtemp = cmd.Parameters.Add(New SqlParameter("@UserName", SqlDbType.NVarChar, 20))
        If User Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = User
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@ControlID", SqlDbType.NVarChar, 20))
        If ControlID Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = ControlID
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@QtyPerPackage", SqlDbType.Int))

        If QtyPerPackage = 0 Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = QtyPerPackage
        End If
        pmtemp.Direction = ParameterDirection.Input

     

        Try
            daDB = New SqlClient.SqlDataAdapter(cmd)
            daDB.Fill(dsDB, "ProcessStation")
            Return dsDB
        Catch err As SqlClient.SqlException
            Throw
        Finally
            With cmd.Connection
                If .State = ConnectionState.Open Then
                    .Close()
                End If
            End With
        End Try
    End Function
    Public Function Update_infor_componentid_New(ByVal Loc As String, ByVal PN As String, ByVal MfgPN As String, ByVal MyTier As String, ByVal LotCode As String, ByVal DateCode As String, _
   ByVal ControlID As Integer) As DataSet


        Dim sqlcon As SqlConnection = GetConnection()
        ''ResetConnString()
        Dim cmd As New SqlCommand("p_updateLoc_new", sqlcon)
        Dim daDB As SqlClient.SqlDataAdapter
        Dim dsDB As New DataSet
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "p_updateLoc_new"

        Dim pmtemp As SqlParameter
        pmtemp = cmd.Parameters.Add(New SqlParameter("@ControlID", SqlDbType.Int))
        If ControlID = 0 Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = ControlID
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@Loc", SqlDbType.NVarChar, 40))

        If Loc Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = Loc
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@PN", SqlDbType.NVarChar, 40))

        If PN Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = PN
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@MfgPN", SqlDbType.NVarChar, 40))

        If MfgPN Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = MfgPN
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@MyTier", SqlDbType.NVarChar, 50))

        If MyTier Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = MyTier
        End If
        pmtemp.Direction = ParameterDirection.Input
        'pmtemp = cmd.Parameters.Add(New SqlParameter("@QtyPerPack", SqlDbType.Int))

        'If QtyPerPack = 0 Then
        '    pmtemp.Value = System.DBNull.Value
        'Else
        '    pmtemp.Value = QtyPerPack
        'End If
        'pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@LotCode", SqlDbType.NVarChar, 40))

        If LotCode Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = LotCode
        End If
        pmtemp.Direction = ParameterDirection.Input
        pmtemp = cmd.Parameters.Add(New SqlParameter("@DateCode", SqlDbType.NVarChar, 40))

        If DateCode Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = DateCode
        End If
        pmtemp.Direction = ParameterDirection.Input

        Try
            daDB = New SqlClient.SqlDataAdapter(cmd)
            daDB.Fill(dsDB, "ProcessStation")
            Return dsDB
        Catch err As SqlClient.SqlException
            Throw
        Finally
            With cmd.Connection
                If .State = ConnectionState.Open Then
                    .Close()
                End If
            End With
        End Try
    End Function
    Public Function Update_infor_componentid_Old(ByVal Loc As String, ByVal PN As String, ByVal MfgPN As String, ByVal MyTier As String, ByVal LotCode As String, ByVal DateCode As String, _
  ByVal ControlID As Integer) As DataSet


        Dim sqlcon As SqlConnection = GetConnection()
        ''ResetConnString()
        Dim cmd As New SqlCommand("p_updateLoc_old", sqlcon)
        Dim daDB As SqlClient.SqlDataAdapter
        Dim dsDB As New DataSet
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "p_updateLoc_old"

        Dim pmtemp As SqlParameter
        pmtemp = cmd.Parameters.Add(New SqlParameter("@ControlID", SqlDbType.Int))

        If ControlID = 0 Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = ControlID
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@Loc", SqlDbType.NVarChar, 40))

        If Loc Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = Loc
        End If
        pmtemp.Direction = ParameterDirection.Input


        pmtemp = cmd.Parameters.Add(New SqlParameter("@PN", SqlDbType.NVarChar, 40))

        If PN Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = PN
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@MfgPN", SqlDbType.NVarChar, 40))

        If MfgPN Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = MfgPN
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@MyTier", SqlDbType.NVarChar, 50))

        If MyTier Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = MyTier
        End If
        pmtemp.Direction = ParameterDirection.Input
        'pmtemp = cmd.Parameters.Add(New SqlParameter("@QtyPerPack", SqlDbType.Int))

        'If QtyPerPack = 0 Then
        '    pmtemp.Value = System.DBNull.Value
        'Else
        '    pmtemp.Value = QtyPerPack
        'End If
        'pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@LotCode", SqlDbType.NVarChar, 40))

        If LotCode Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = LotCode
        End If
        pmtemp.Direction = ParameterDirection.Input
        pmtemp = cmd.Parameters.Add(New SqlParameter("@DateCode", SqlDbType.NVarChar, 40))

        If DateCode Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = DateCode
        End If
        pmtemp.Direction = ParameterDirection.Input

        Try
            daDB = New SqlClient.SqlDataAdapter(cmd)
            daDB.Fill(dsDB, "ProcessStation")
            Return dsDB
        Catch err As SqlClient.SqlException
            Throw
        Finally
            With cmd.Connection
                If .State = ConnectionState.Open Then
                    .Close()
                End If
            End With
        End Try
    End Function
    'jerry add new delete old componentid already convert all
    Public Function Dalete_Componetid_Convert_material(ByVal ControlID As String) As DataSet


        Dim sqlcon As SqlConnection = GetConnection()
        ''ResetConnString()
        Dim cmd As New SqlCommand("p_delete_convert_material", sqlcon)
        Dim daDB As SqlClient.SqlDataAdapter
        Dim dsDB As New DataSet
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "p_delete_convert_material"

        Dim pmtemp As SqlParameter
        pmtemp = cmd.Parameters.Add(New SqlParameter("@ControlID", SqlDbType.NVarChar, 20))
        If ControlID Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = ControlID
        End If
        pmtemp.Direction = ParameterDirection.Input

        Try
            daDB = New SqlClient.SqlDataAdapter(cmd)
            daDB.Fill(dsDB, "ProcessStation")
            Return dsDB
        Catch err As SqlClient.SqlException
            Throw
        Finally
            With cmd.Connection
                If .State = ConnectionState.Open Then
                    .Close()
                End If
            End With
        End Try
    End Function
    'jerry add new
    Public Function Update_Qtypackage_Convert_material(ByVal QtyPerPackage As Integer, _
    ByVal User As String, ByVal ControlID As String, ByVal OriginQty As Integer) As DataSet


        Dim sqlcon As SqlConnection = GetConnection()
        ''ResetConnString()
        Dim cmd As New SqlCommand("p_updateQtyPackage", sqlcon)
        Dim daDB As SqlClient.SqlDataAdapter
        Dim dsDB As New DataSet
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "p_updateQtyPackage"

        Dim pmtemp As SqlParameter

        pmtemp = cmd.Parameters.Add(New SqlParameter("@UserName", SqlDbType.NVarChar, 20))
        If User Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = User
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@ControlID", SqlDbType.NVarChar, 20))
        If ControlID Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = ControlID
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@QtyPerPackage", SqlDbType.Int))

        If QtyPerPackage = 0 Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = QtyPerPackage
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@OriginQty", SqlDbType.Int))

        If OriginQty = 0 Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = OriginQty
        End If

        pmtemp.Direction = ParameterDirection.Input

        Try
            daDB = New SqlClient.SqlDataAdapter(cmd)
            daDB.Fill(dsDB, "ProcessStation")
            Return dsDB
        Catch err As SqlClient.SqlException
            Throw
        Finally
            With cmd.Connection
                If .State = ConnectionState.Open Then
                    .Close()
                End If
            End With
        End Try
    End Function


    'jerry addd new
    Public Function InsertComponent_reduce(ByVal ComponentID_reduce As String, ByVal componentID_Increase As String, _
     ByVal UGPN As String, _
     ByVal MfgPN As String, _
     ByVal Mfger As String, _
     ByVal Qty_reduce As Integer, ByVal Qty_Oregin_reduce As Integer) As DataSet

        Dim sqlcon As SqlConnection = GetConnection()
        ''ResetConnString()
        Dim cmd As New SqlCommand("p_InsertComponetID_reduce", sqlcon)
        Dim daDB As SqlClient.SqlDataAdapter
        Dim dsDB As New DataSet
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "p_InsertComponetID_reduce"

        Dim pmtemp As SqlParameter

        pmtemp = cmd.Parameters.Add(New SqlParameter("@UGPN", SqlDbType.NVarChar, 40))
        pmtemp.Value = UGPN
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@MfgPN", SqlDbType.NVarChar, 40))
        pmtemp.Value = MfgPN
        pmtemp.Direction = ParameterDirection.Input


        pmtemp = cmd.Parameters.Add(New SqlParameter("@Mfger", SqlDbType.NVarChar, 50))
        If Mfger Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = Mfger
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@ComID_reduce", SqlDbType.NVarChar, 40))
        If ComponentID_reduce Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = ComponentID_reduce
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@ComID_Increase", SqlDbType.NVarChar, 40))
        If componentID_Increase Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = componentID_Increase
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@Qty_reduce", SqlDbType.Int))
        If Qty_reduce = 0 Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = Qty_reduce
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@Qty_Origin_reduce", SqlDbType.Int))
        If Qty_Oregin_reduce = 0 Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = Qty_Oregin_reduce
        End If
        pmtemp.Direction = ParameterDirection.Input


        Try
            daDB = New SqlClient.SqlDataAdapter(cmd)
            daDB.Fill(dsDB, "ProcessStation")
            Return dsDB
        Catch err As SqlClient.SqlException
            Throw
        Finally
            With cmd.Connection
                If .State = ConnectionState.Open Then
                    .Close()
                End If
            End With
        End Try
    End Function
    Public Function GetMSLfromCloud(ByVal PN As String) As String
        Dim MSL As String = ""
        Try
            Dim URL As String = "http://192.168.1.51:3001/api/oracleplm/item/" & PN
            Dim fr As System.Net.HttpWebRequest
            Dim targetURI As New Uri(URL)
            Dim Jstring As String = ""

            fr = DirectCast(HttpWebRequest.Create(targetURI), System.Net.HttpWebRequest)
            If (fr.GetResponse().ContentLength > 0) Then
                Dim str As New System.IO.StreamReader(fr.GetResponse().GetResponseStream())
                Jstring = str.ReadToEnd()
                str.Close()
            End If
            Dim jsonstr As JObject = JObject.Parse(Jstring)

            Try
                MSL = IIf(jsonstr("Attributes")("GeneralDetails")(0)("moistureSensitivityLevelMsl") Is Nothing, "", jsonstr("Attributes")("GeneralDetails")(0)("moistureSensitivityLevelMsl")).ToString

            Catch ex As Exception
                '  Throw

                Try
                    MSL = IIf(jsonstr("Attributes")("ElectricalComponentsMGeneralDe")(0)("moistureSensitivityLevelMsl") Is Nothing, "", jsonstr("Attributes")("ElectricalComponentsMGeneralDe")(0)("moistureSensitivityLevelMsl")).ToString

                Catch ex1 As Exception
                    Throw

                End Try
            End Try




            ' Dim pPackageTemp As String = IIf(jsonstr("Attributes")("GeneralDetails")(0)("peakPackageBodyTemperature") Is Nothing, "", jsonstr("Attributes")("GeneralDetails")(0)("peakPackageBodyTemperature")).ToString


        Catch ex As System.Net.WebException
            Throw
            ''  MessageBox.Show(ex.Message)
        Catch ex As Exception
            Throw
            ''   MessageBox.Show(ex.Message)


        End Try

        Return MSL


    End Function
    Public Function InsertNewComponent(ByVal DEV As Integer, _
    ByVal NoOfPackages As Integer, _
    ByVal QtyPerPackage As Integer, _
    ByVal PO As String, _
    ByVal UGPN As String, _
    ByVal MfgPN As String, _
    ByVal Mfger As String, _
    ByVal LotCode As String, _
    ByVal DateCode As String, _
    ByVal FirmWare As String, _
    ByVal User As String, _
    ByVal Loc As String, Optional ByVal ParentComponentID As String = "", Optional ByVal COO As String = "", Optional ByVal Tier As String = "", Optional ByVal Receipt_num As String = "", Optional ByVal MSL As String = "", Optional ByVal DESC As String = "", Optional ByVal Vendor As String = "") As DataSet


        Dim sqlcon As SqlConnection = GetConnection()



        ''ResetConnString()
        Dim cmd As New SqlCommand("p_InsertNewComponent1_", sqlcon)
        Dim daDB As SqlClient.SqlDataAdapter
        Dim dsDB As New DataSet
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "p_InsertNewComponent1"



        Dim pmtemp As SqlParameter
        pmtemp = cmd.Parameters.Add(New SqlParameter("@NoOfPackages", SqlDbType.Int))
        pmtemp.Value = NoOfPackages
        pmtemp.Direction = ParameterDirection.Input




        pmtemp = cmd.Parameters.Add(New SqlParameter("@QtyPerPackage", SqlDbType.Int))

        If QtyPerPackage = 0 Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = QtyPerPackage
        End If
        pmtemp.Direction = ParameterDirection.Input



        pmtemp = cmd.Parameters.Add(New SqlParameter("@PO", SqlDbType.NVarChar, 20))
        pmtemp.Value = PO
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@UGPN", SqlDbType.NVarChar, 40))
        pmtemp.Value = UGPN
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@MfgPN", SqlDbType.NVarChar, 40))
        pmtemp.Value = MfgPN
        pmtemp.Direction = ParameterDirection.Input


        pmtemp = cmd.Parameters.Add(New SqlParameter("@Mfger", SqlDbType.NVarChar, 50))
        If Mfger Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = Mfger
        End If
        pmtemp.Direction = ParameterDirection.Input




        pmtemp = cmd.Parameters.Add(New SqlParameter("@LotCode", SqlDbType.NVarChar, 40))
        If LotCode Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = LotCode
        End If
        pmtemp.Direction = ParameterDirection.Input






        pmtemp = cmd.Parameters.Add(New SqlParameter("@DateCode", SqlDbType.NVarChar, 40))
        If DateCode Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = DateCode
        End If
        pmtemp.Direction = ParameterDirection.Input



        pmtemp = cmd.Parameters.Add(New SqlParameter("@FirmWareVersion", SqlDbType.NVarChar, 30))
        If FirmWare = "" Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = FirmWare
        End If
        pmtemp.Direction = ParameterDirection.Input




        pmtemp = cmd.Parameters.Add(New SqlParameter("@UserName", SqlDbType.NVarChar, 20))
        If User Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = User
        End If
        pmtemp.Direction = ParameterDirection.Input



        pmtemp = cmd.Parameters.Add(New SqlParameter("@Loc", SqlDbType.NVarChar, 40))
        If Loc Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = Loc
        End If
        pmtemp.Direction = ParameterDirection.Input




        pmtemp = cmd.Parameters.Add(New SqlParameter("@ParentComponentID", SqlDbType.NVarChar, 50))
        If ParentComponentID = "" Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = ParentComponentID
        End If
        pmtemp.Direction = ParameterDirection.Input





        pmtemp = cmd.Parameters.Add(New SqlParameter("@COO", SqlDbType.NVarChar, 50))
        If COO = "" Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = COO
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@TIER", SqlDbType.NVarChar, 50))
        If Tier = "" Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = Tier
        End If
        pmtemp.Direction = ParameterDirection.Input


        pmtemp = cmd.Parameters.Add(New SqlParameter("@Receipt_num", SqlDbType.NVarChar, 50))
        If Receipt_num = "" Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = Receipt_num
        End If
        pmtemp.Direction = ParameterDirection.Input



        pmtemp = cmd.Parameters.Add(New SqlParameter("@MSL", SqlDbType.NVarChar, 50))
        If MSL = "" Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = MSL
        End If
        pmtemp.Direction = ParameterDirection.Input







        pmtemp = cmd.Parameters.Add(New SqlParameter("@DESC", SqlDbType.NVarChar, 50))
        If DESC = "" Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = DESC
        End If
        pmtemp.Direction = ParameterDirection.Input





        pmtemp = cmd.Parameters.Add(New SqlParameter("@Vendor", SqlDbType.NVarChar, 500))
        If Vendor = "" Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = Vendor
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@DEV", SqlDbType.Int))
        pmtemp.Value = DEV
        pmtemp.Direction = ParameterDirection.Input





        Try
            daDB = New SqlClient.SqlDataAdapter(cmd)
            daDB.Fill(dsDB, "ProcessStation")
            Return dsDB
        Catch err As SqlClient.SqlException
            Throw
        Finally
            With cmd.Connection
                If .State = ConnectionState.Open Then
                    .Close()
                End If
            End With
        End Try
    End Function


    Public Function InsertNewComponent2(ByVal NoOfPackages As Integer, _
    ByVal QtyPerPackage As Integer, _
    ByVal PO As String, _
    ByVal UGPN As String, _
    ByVal MfgPN As String, _
    ByVal Mfger As String, _
    ByVal LotCode As String, _
    ByVal DateCode As String, _
    ByVal FirmWare As String, _
    ByVal User As String, _
    ByVal Loc As String, Optional ByVal ParentComponentID As String = "", Optional ByVal COO As String = "", Optional ByVal Tier As String = "", Optional ByVal Receipt_num As String = "", Optional ByVal MSL As String = "", Optional ByVal DESC As String = "", Optional ByVal Vendor As String = "") As DataSet


        Dim sqlcon As SqlConnection = GetConnection()



        ''ResetConnString()
        Dim cmd As New SqlCommand("p_InsertNewComponent2", sqlcon)
        Dim daDB As SqlClient.SqlDataAdapter
        Dim dsDB As New DataSet
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "p_InsertNewComponent2"



        Dim pmtemp As SqlParameter
        pmtemp = cmd.Parameters.Add(New SqlParameter("@NoOfPackages", SqlDbType.Int))
        pmtemp.Value = NoOfPackages
        pmtemp.Direction = ParameterDirection.Input




        pmtemp = cmd.Parameters.Add(New SqlParameter("@QtyPerPackage", SqlDbType.Int))

        If QtyPerPackage = 0 Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = QtyPerPackage
        End If
        pmtemp.Direction = ParameterDirection.Input



        pmtemp = cmd.Parameters.Add(New SqlParameter("@PO", SqlDbType.NVarChar, 20))
        pmtemp.Value = PO
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@UGPN", SqlDbType.NVarChar, 40))
        pmtemp.Value = UGPN
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@MfgPN", SqlDbType.NVarChar, 40))
        pmtemp.Value = MfgPN
        pmtemp.Direction = ParameterDirection.Input


        pmtemp = cmd.Parameters.Add(New SqlParameter("@Mfger", SqlDbType.NVarChar, 50))
        If Mfger Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = Mfger
        End If
        pmtemp.Direction = ParameterDirection.Input




        pmtemp = cmd.Parameters.Add(New SqlParameter("@LotCode", SqlDbType.NVarChar, 40))
        If LotCode Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = LotCode
        End If
        pmtemp.Direction = ParameterDirection.Input






        pmtemp = cmd.Parameters.Add(New SqlParameter("@DateCode", SqlDbType.NVarChar, 40))
        If DateCode Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = DateCode
        End If
        pmtemp.Direction = ParameterDirection.Input



        pmtemp = cmd.Parameters.Add(New SqlParameter("@FirmWareVersion", SqlDbType.NVarChar, 30))
        If FirmWare = "" Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = FirmWare
        End If
        pmtemp.Direction = ParameterDirection.Input




        pmtemp = cmd.Parameters.Add(New SqlParameter("@UserName", SqlDbType.NVarChar, 20))
        If User Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = User
        End If
        pmtemp.Direction = ParameterDirection.Input



        pmtemp = cmd.Parameters.Add(New SqlParameter("@Loc", SqlDbType.NVarChar, 40))
        If Loc Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = Loc
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@ParentComponentID", SqlDbType.NVarChar, 50))
        If ParentComponentID = "" Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = ParentComponentID
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@COO", SqlDbType.NVarChar, 50))
        If COO = "" Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = COO
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@TIER", SqlDbType.NVarChar, 50))
        If Tier = "" Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = Tier
        End If
        pmtemp.Direction = ParameterDirection.Input


        pmtemp = cmd.Parameters.Add(New SqlParameter("@Receipt_num", SqlDbType.NVarChar, 50))
        If Receipt_num = "" Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = Receipt_num
        End If
        pmtemp.Direction = ParameterDirection.Input





        pmtemp = cmd.Parameters.Add(New SqlParameter("@MSL", SqlDbType.NVarChar, 50))
        If MSL = "" Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = MSL
        End If
        pmtemp.Direction = ParameterDirection.Input







        pmtemp = cmd.Parameters.Add(New SqlParameter("@DESC", SqlDbType.NVarChar, 50))
        If DESC = "" Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = DESC
        End If
        pmtemp.Direction = ParameterDirection.Input





        pmtemp = cmd.Parameters.Add(New SqlParameter("@Vendor", SqlDbType.NVarChar, 50))
        If Vendor = "" Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = Vendor
        End If
        pmtemp.Direction = ParameterDirection.Input

        Try
            daDB = New SqlClient.SqlDataAdapter(cmd)
            daDB.Fill(dsDB, "ProcessStation")
            Return dsDB
        Catch err As SqlClient.SqlException
            Throw
        Finally
            With cmd.Connection
                If .State = ConnectionState.Open Then
                    .Close()
                End If
            End With
        End Try
    End Function


    Public Function InsertNewComponent2_fromproduct(ByVal DEV As Integer, _
       ByVal NoOfPackages As Integer, _
       ByVal QtyPerPackage As Integer, _
       ByVal PO As String, _
       ByVal UGPN As String, _
       ByVal MfgPN As String, _
       ByVal Mfger As String, _
       ByVal LotCode As String, _
       ByVal DateCode As String, _
       ByVal FirmWare As String, _
       ByVal User As String, _
       ByVal Loc As String, Optional ByVal ParentComponentID As String = "", Optional ByVal COO As String = "", Optional ByVal Tier As String = "", Optional ByVal Receipt_num As String = "", Optional ByVal MSL As String = "", Optional ByVal DESC As String = "", Optional ByVal Vendor As String = "") As DataSet


        Dim sqlcon As SqlConnection = GetConnection()



        ''ResetConnString()
        Dim cmd As New SqlCommand("p_InsertNewComponent1", sqlcon)
        Dim daDB As SqlClient.SqlDataAdapter
        Dim dsDB As New DataSet
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "p_InsertNewComponent1"



        Dim pmtemp As SqlParameter
        pmtemp = cmd.Parameters.Add(New SqlParameter("@NoOfPackages", SqlDbType.Int))
        pmtemp.Value = NoOfPackages
        pmtemp.Direction = ParameterDirection.Input




        pmtemp = cmd.Parameters.Add(New SqlParameter("@QtyPerPackage", SqlDbType.Int))

        If QtyPerPackage = 0 Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = QtyPerPackage
        End If
        pmtemp.Direction = ParameterDirection.Input



        pmtemp = cmd.Parameters.Add(New SqlParameter("@PO", SqlDbType.NVarChar, 20))
        pmtemp.Value = PO
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@UGPN", SqlDbType.NVarChar, 40))
        pmtemp.Value = UGPN
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@MfgPN", SqlDbType.NVarChar, 40))
        pmtemp.Value = MfgPN
        pmtemp.Direction = ParameterDirection.Input


        pmtemp = cmd.Parameters.Add(New SqlParameter("@Mfger", SqlDbType.NVarChar, 50))
        If Mfger Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = Mfger
        End If
        pmtemp.Direction = ParameterDirection.Input




        pmtemp = cmd.Parameters.Add(New SqlParameter("@LotCode", SqlDbType.NVarChar, 40))
        If LotCode Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = LotCode
        End If
        pmtemp.Direction = ParameterDirection.Input






        pmtemp = cmd.Parameters.Add(New SqlParameter("@DateCode", SqlDbType.NVarChar, 40))
        If DateCode Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = DateCode
        End If
        pmtemp.Direction = ParameterDirection.Input



        pmtemp = cmd.Parameters.Add(New SqlParameter("@FirmWareVersion", SqlDbType.NVarChar, 30))
        If FirmWare = "" Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = FirmWare
        End If
        pmtemp.Direction = ParameterDirection.Input




        pmtemp = cmd.Parameters.Add(New SqlParameter("@UserName", SqlDbType.NVarChar, 30))
        If User Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = User
        End If
        pmtemp.Direction = ParameterDirection.Input



        pmtemp = cmd.Parameters.Add(New SqlParameter("@Loc", SqlDbType.NVarChar, 40))
        If Loc Is Nothing Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = Loc
        End If
        pmtemp.Direction = ParameterDirection.Input
        pmtemp = cmd.Parameters.Add(New SqlParameter("@ParentComponentID", SqlDbType.NVarChar, 50))
        If ParentComponentID = "" Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = ParentComponentID
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@COO", SqlDbType.NVarChar, 50))
        If COO = "" Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = COO
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@TIER", SqlDbType.NVarChar, 50))
        If Tier = "" Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = Tier
        End If
        pmtemp.Direction = ParameterDirection.Input


        pmtemp = cmd.Parameters.Add(New SqlParameter("@Receipt_num", SqlDbType.NVarChar, 50))
        If Receipt_num = "" Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = Receipt_num
        End If
        pmtemp.Direction = ParameterDirection.Input



        pmtemp = cmd.Parameters.Add(New SqlParameter("@MSL", SqlDbType.NVarChar, 50))
        If MSL = "" Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = MSL
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@DESC", SqlDbType.NVarChar, 50))
        If DESC = "" Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = DESC
        End If
        pmtemp.Direction = ParameterDirection.Input

        pmtemp = cmd.Parameters.Add(New SqlParameter("@Vendor", SqlDbType.NVarChar, 50))
        If Vendor = "" Then
            pmtemp.Value = System.DBNull.Value
        Else
            pmtemp.Value = Vendor
        End If
        pmtemp.Direction = ParameterDirection.Input


        pmtemp = cmd.Parameters.Add(New SqlParameter("@DEV", SqlDbType.Int))
        pmtemp.Value = DEV
        pmtemp.Direction = ParameterDirection.Input

        Try
            daDB = New SqlClient.SqlDataAdapter(cmd)
            daDB.Fill(dsDB, "ProcessStation")
            Return dsDB
        Catch err As SqlClient.SqlException
            Throw
        Finally
            With cmd.Connection
                If .State = ConnectionState.Open Then
                    .Close()
                End If
            End With
        End Try
    End Function

   

    Private Shared _LoginName As String
    Private Shared _Level As String


    Public Shared Property LoginName() As String
        Get
            Return _LoginName
        End Get
        Set(ByVal value As String)
            _LoginName = value
        End Set
    End Property

    Public Shared Property Level() As String 'Jerry Add new
        Get
            Return _Level
        End Get
        Set(ByVal value As String)
            _Level = value
        End Set
    End Property
End Class
