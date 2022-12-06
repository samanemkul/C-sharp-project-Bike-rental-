﻿<%@ Page Title="Update Brands" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="ManageBrands.aspx.cs" Inherits="ManageBrands" Async="true" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <center>
        <h2>Car Brands</h2>
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" DataKeyNames="bid" DataSourceID="SqlDataSource1" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
               <asp:BoundField DataField="bId" HeaderText="BRAND ID" InsertVisible="False" ReadOnly="True" SortExpression="bId" >
                 <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" Wrap="True" />
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:BoundField>
                 <asp:BoundField DataField="bname" HeaderText="BRANDS" SortExpression="bname" InsertVisible="True" >
               
                <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                <ItemStyle HorizontalAlign="Justify" VerticalAlign="Middle" />
                </asp:BoundField>
               
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        </br>
        </br>
       <p>Add New Brands : <asp:TextBox ID="BrandName" runat="server"></asp:TextBox> 
           <asp:Button ID="Brand" OnClick="Brand_Insert" runat="server" Text="Insert" /></p>
         
       
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=dcm.uhcl.edu;Initial Catalog=c563315fa02g3;Persist Security Info=True;User ID=c563315fa02g3;Password=5989040" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [bname], [bId] FROM [brands]" UpdateCommand="UPDATE [brands] SET [bname]=@bname where [bId]=@bId" DeleteCommand="DELETE from [brands] where [bId]=@bId"></asp:SqlDataSource>
        
    </div>
         <asp:Label ID="Label11" runat="server" Visible="false" Font-Size="15px" ForeColor="Red" />
        </center>
</asp:Content>