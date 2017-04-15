<%@ Page Title="Booking Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="ViewBookings.aspx.cs" Inherits="ViewBookings" Async="true" %>


 <asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">



     <center>
         <h2><u>Booking Details</u></h2>
     <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Id" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" AllowPaging="True">
         <AlternatingRowStyle BackColor="White" />
         <Columns>
             <asp:BoundField DataField="Id" HeaderText="Booking Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" >
             <HeaderStyle HorizontalAlign="Center" />
             <ItemStyle HorizontalAlign="Center" />
             </asp:BoundField>
             <asp:BoundField DataField="uid" HeaderText="User Id" SortExpression="uid" >
             <HeaderStyle HorizontalAlign="Center" />
             <ItemStyle HorizontalAlign="Center" />
             </asp:BoundField>
             <asp:BoundField DataField="carid" HeaderText="Car Id" SortExpression="carid" >
             <HeaderStyle HorizontalAlign="Center" />
             <ItemStyle HorizontalAlign="Center" />
             </asp:BoundField>
             <asp:BoundField DataField="date" HeaderText="Date" SortExpression="date" >
             <HeaderStyle HorizontalAlign="Center" />
             <ItemStyle HorizontalAlign="Center" />
             </asp:BoundField>
             <asp:BoundField DataField="amount" HeaderText="Amount" SortExpression="amount" >
             <HeaderStyle HorizontalAlign="Center" />
             <ItemStyle HorizontalAlign="Center" />
             </asp:BoundField>
             <asp:BoundField DataField="time" HeaderText="Time" SortExpression="time" >
             <HeaderStyle HorizontalAlign="Center" />
             <ItemStyle HorizontalAlign="Center" />
             </asp:BoundField>
             <asp:BoundField DataField="card" HeaderText="Card" SortExpression="card" >
             <HeaderStyle HorizontalAlign="Center" />
             <ItemStyle HorizontalAlign="Center" />
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
         </center>
     <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=dcm.uhcl.edu;Initial Catalog=c563315fa02g3;Persist Security Info=True;User ID=c563315fa02g3;Password=5989040" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Bookings]"></asp:SqlDataSource>




     </asp:Content>