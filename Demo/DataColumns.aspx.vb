Imports Telerik.Reporting

Public Class DataColumns
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' Resharper fails to resolve the type 'DataColumn'.
        ' These use DataColumn from System.Data namespace. `Imports System` is done implicitly and works fine in VB.NET
        ' Using Data.SomeType is same as System.Data.SomeType
        Dim id As New Data.DataColumn("ID", Type.GetType("System.Int32"))
        Dim name As New Data.DataColumn("Name", Type.GetType("System.String"))
        Dim age As New Data.DataColumn("Age", Type.GetType("System.Int32"))
        Dim salary As New Data.DataColumn("Salary", Type.GetType("System.Double"))


        ' Fully qualified namespace works fine. But triggers IDE0001: Name can be simplified.
        Dim fullyQualifiedNsDataColumn As New System.Data.DataColumn("ID", Type.GetType("System.Int32"))


        ' Using DataColumn type from Telerik.Reporting namespace works fine.
        Dim dcFromTelerikReporting As New DataColumn("ID", SimpleType.Integer)

    End Sub

End Class