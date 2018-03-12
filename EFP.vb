Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class EFP
    Public code_efp As Integer
    Public designation As String
    Public ville As String
    Public direction As String
    Public Sub New()

    End Sub
    Public Sub New(ByVal code_efp As Integer, ByVal designation As String, ByVal ville As String, ByVal direction As String)
        Me.code_efp = code_efp
        Me.designation = designation
        Me.ville = ville
        Me.direction = direction
    End Sub
    Public Property Pcode_efp() As Integer
        Get
            Return code_efp
        End Get
        Set(ByVal value As Integer)
            code_efp = value
        End Set
    End Property
    Public Property Pdesignation() As String
        Get
            Return designation
        End Get
        Set(ByVal value As String)
            designation = value
        End Set
    End Property

    Public Property Pville() As String
        Get
            Return ville
        End Get
        Set(ByVal value As String)
            ville = value
        End Set
    End Property
    Public Property Pdirection() As String
        Get
            Return direction
        End Get
        Set(ByVal value As String)
            direction = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return code_efp & " " & designation & " " & ville & " " & direction
    End Function
    Public Sub AddEFP()
        Dim req As String = " insert into EFP values('" & code_efp & "','" & designation & "','" & ville & "', '" & direction & "')"
        com = New SqlCommand(req, con)
        con.Open()
        com.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Sub UpdateEFP()
        Dim req As String = "update efp set code_efp= '" & code_efp & "' , designation='" & designation & "' , ville='" & ville & "' , direction='" & direction & "'"
        com = New SqlCommand(req, con)
        con.Open()
        com.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Sub DeleteEfp()
        Dim req As String = "delete from efp  where code_efp='" & code_efp & "'"
        com = New SqlCommand(req, con)
        con.Open()
        com.ExecuteNonQuery()
        con.Close()
    End Sub
End Class
