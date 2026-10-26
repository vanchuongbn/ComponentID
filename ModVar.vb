Imports System.Data.SqlClient
Module ModVar
    Public TenMayChu As String
    Public Ten_Acc As String = ""
    Public Pass As String = ""
    Public Strconn_ITDB_70 As String = "SERVER=172.16.1.70;database=UHAN_Web_ITDB;uid=sa;pwd=p@ssw0rd"
    Public Strconn As String = "SERVER=172.16.1.26\ughnsql1;database=WI;uid=sa;pwd=p@ssw0rd"
    Public Strconn_66 As String = "SERVER=172.16.1.66;database=UnigenTrax;uid=sa;pwd=p@ssw0rd"
    Public Strconn_NCRSystem As String = "SERVER=172.16.1.70;database=NCRSYSTEMS;uid=qa;pwd=Uhan@123"
    Public Strconn1 As String = "SERVER=172.16.1.70;database=UnigenDataCollection1;uid=Production;pwd=Ughn2012"
    Public StrconnQA As String = "SERVER=172.16.1.70;database=PQMS;uid=qa;pwd=Uhan@123"
    Public ngay As String
    Public thang As String
    Public nam As String
    Public str_path As String = Application.ExecutablePath
    Public Username As String = "None"
    Public Username_Public As String
    Public Flash As Boolean = False
    Public ModelID As String = ""
    Public PlanID_Public As String = ""
    Public LineID_Public As String = "01"
    Public ShiftID_Public As String = ""
    Public ModelID_Public As String = ""
    Public conn As SqlConnection

    Public Return_Product As String = ""
   Public Area_Printed As String = ""


      Public UGPN_Origin As String = ""
    Public MFG_Origin As String = ""

End Module
