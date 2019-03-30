Public Class Encryption ' Nils
    Private cryptoServiceProvider As System.Security.Cryptography.RNGCryptoServiceProvider  'Using RNGCrypto SP to generate real random results. 

    ' Function to share HashString value
    Public Shared Function HashString(str As String) As String
        Return EncryptString(str)
    End Function

    'Function for generating a random salt. Returnerer string. 
    Public Shared Function GenerateSalt() As String
        Using cryptoServiceProvider As New System.Security.Cryptography.RNGCryptoServiceProvider
            Dim sb As New System.Text.StringBuilder()
            Dim data As Byte() = New Byte(4) {}
            For i = 0 To 5
                cryptoServiceProvider.GetBytes(data)
                Dim value As String = BitConverter.ToString(data, 0)
                sb.Append(value)
            Next
            Return EncryptString(sb.ToString())  'Returns a true random string, encrypted by the EncryptString function once more. 
        End Using
    End Function

    'Function that encrypts a string 
    Private Shared Function EncryptString(str As String) As String
        Dim bytes As Byte() = System.Text.Encoding.ASCII.GetBytes(str)
        Dim hashed = System.Security.Cryptography.SHA256.Create().ComputeHash(bytes)
        Return Convert.ToBase64String(hashed)
    End Function
End Class

' This class could be exported to a DLL-file if AS SykkelUtleie want to use it in other applications they build. 
