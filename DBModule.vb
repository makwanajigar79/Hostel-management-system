Imports System.Data.SqlClient
Imports System.Data
Module DBModule
    ' change the path  using Connection string
    Public con As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Client\HMS\HMS\HMS_DB.mdf;Integrated Security=True;User Instance=True")
    Public cmd As SqlCommand
    Public dr As SqlDataReader
    Public da As SqlDataAdapter
    Public ds As DataSet
    Public BookId As Integer
End Module
