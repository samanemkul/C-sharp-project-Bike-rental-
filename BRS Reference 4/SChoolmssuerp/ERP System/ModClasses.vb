Imports System.Data.SqlClient
Module ModClasses
    Public con As SqlConnection = Nothing
    Public cmd As SqlCommand = Nothing
    Public rdr As SqlDataReader = Nothing
    Public ds As DataSet
    Public adp As SqlDataAdapter
    Public dtable As DataTable
    Public TempFileNames2 As String
End Module
