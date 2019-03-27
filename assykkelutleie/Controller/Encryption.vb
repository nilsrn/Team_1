Public Class Encryption
    Private cryptoServiceProvider As System.Security.Cryptography.RNGCryptoServiceProvider

    ' Funksjon for å dele HashString verdi
    Public Shared Function HashString(str As String) As String
        Return EncryptString(str)
    End Function

    'Funksjon for å generere tilfeldig salt 
    Public Shared Function GenerateSalt() As String
        Using cryptoServiceProvider As New System.Security.Cryptography.RNGCryptoServiceProvider
            Dim sb As New System.Text.StringBuilder()
            Dim data As Byte() = New Byte(4) {}
            For i = 0 To 5
                cryptoServiceProvider.GetBytes(data)
                Dim value As String = BitConverter.ToString(data, 0)
                sb.Append(value)
            Next
            Return EncryptString(sb.ToString())
        End Using
    End Function

    'Funksjon for å kryptere string 
    Private Shared Function EncryptString(str As String) As String
        Dim bytes As Byte() = System.Text.Encoding.ASCII.GetBytes(str)
        Dim hashed = System.Security.Cryptography.SHA256.Create().ComputeHash(bytes)
        Return Convert.ToBase64String(hashed)
    End Function
End Class

' Denne koden kan eventuelt legges i en egen DLL for gjenbruk. 
