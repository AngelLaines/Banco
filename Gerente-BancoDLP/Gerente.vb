Module Gerente
    Public IdEmpActivo As Integer
    Public Acceso As Integer
    Public NomEmpActivo, ApEmpActivo As String

    Public Ruta As String = "PROVIDER=Microsoft.ACE.OLEDB.12.0;Data Source=" & "C:\Users\rober\Documents\Banco.accdb"

    Public cadenaconexion As String = Ruta '"workstation id=BdBancoEquipo1.mssql.somee.com;packet size=4096;user id=morlai_SQLLogin_1;pwd=ehfdk3l7oz;data source=BdBancoEquipo1.mssql.somee.com;persist security info=False;initial catalog=BdBancoEquipo1"
    'Public Ruta As String = Application.StartupPath & "\BancoDLP.accdb"
End Module