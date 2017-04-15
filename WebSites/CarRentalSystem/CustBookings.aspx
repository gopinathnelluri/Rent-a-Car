<%@ Page Title="Customer Booking Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="CustBookings.aspx.cs" Inherits="CustBookings" Async="true" %>


 <asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
     <center>
     <div style="position:relative;width:100%;height:40px;float:left;"></div>
     <div style="position:relative;width:1024px;float:left;margin:5px;">
            <h1>Your Booking Details</h1>


     <table border="1">
                    <tr>
                        <th>Car Image</th>
                        <th>Car</th>
                        <th>PickUp Date</th>
                        <th>Rent Period</th>
                        <th>Amount Payed</th>
                        <th>card used</th>
                    </tr>
                

 <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
                    <tr>
                        <td><img src="../images/cars/<%#Eval("bid") %>-<%#Eval("carid")%>.png" width:"100px" style="width:100px;"/></td>
                        <td><%#Eval("carname") %></td>
                        <td><%#Eval("date") %></td>
                        <td><%#Eval("time") %>/months</td>
                        <td>$<%#Eval("amount") %></td>
                        <td><%#Eval("card") %></td>
                    </tr>
        </ItemTemplate>        
 </asp:Repeater>
       </table>
     </div>
            
     


     </center>


     </asp:Content>

