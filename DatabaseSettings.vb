

Public NotInheritable Class DatabaseSettings
    Private Sub New()
    End Sub

    ' Sửa Data Source theo tên/IP SQL Server thực tế trước khi chạy.
    Public Const ConnectionString As String = "SERVER=172.16.1.66;database=UnigenTrax;uid=sa;pwd=p@ssw0rd"
End Class
