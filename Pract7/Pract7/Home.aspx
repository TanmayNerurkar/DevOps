﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Pract7.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DemoDBConnectionString %>" SelectCommand="sp_GetEmployeeById" SelectCommandType="StoredProcedure">
                <SelectParameters>
                    <asp:Parameter Name="EmpID" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:Label ID="lblEmpID" runat="server" Text="Enter Employee ID:" />
            <asp:TextBox ID="txtEmpID" runat="server" />
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
            <br />
            <br />
            <asp:GridView ID="gvEmployee" runat="server" AutoGenerateColumns="true" />
        </div>

    </form>
</body>
</html>
