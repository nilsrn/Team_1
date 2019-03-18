Module Module1
    Sub Main()

        Dim username As String = "Administrator"
        Dim password = Encryption.HashString("Tastatur123")
        Dim salt = Encryption.GenerateSalt
        Dim hashedAndSalted = Encryption.HashString(String.Format("{0}{1}", password, salt))

        'Console.WriteLine(password)
        'Console.WriteLine(salt)
        'Console.WriteLine(hashedAndSalted)


        DbManager.insertNewUser(username, hashedAndSalted, salt)
        DbManager.Login(username, "Tastatur123")
    End Sub
End Module
