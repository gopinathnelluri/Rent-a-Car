<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" EnableEventValidation="false"  AutoEventWireup="true" CodeFile="car.aspx.cs" Inherits="car" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <center>
    <div style="position:relative;width:1024px;height:40px;">

    </div>
        <asp:TextBox ID="search" placeholder="Search by Brand Name, Car Name.." runat="server" Height="60px" style="max-width:800px;padding-left:10px;padding-right:10px;font-size:30px;" Width="800px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="search" onclick="Button1_Click" style="position:relative;height:60px;width:200px;top:-6px;"></asp:Button>
         <div style="position:relative;width:1024px;padding:8px;">

             <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
        
            <div style="width:1000px;height:400px;background-color:red;float:left;margin:5px;">
                <div style="width:400px;height:400px;float:left;background-color:white;">
                    <img src="images/cars/<%#Eval("bid")%>-<%#Eval("carid")%>.png" width="400px">
                </div>
                <div style="width:600px;height:400px;float:left;text-align:left;padding:10px;background-color:aqua;">
                    <p><b>Car Name: </b><a href="Search?name=<%#Eval("carname") %>"><%#Eval("carname") %></a></p>
                    <p><b>Brand Name: </b><a href="Search?name=<%#Eval("bname") %>"><%#Eval("bname") %></a></p>
                    <p><b>Mileage: </b><a href="Search?name=<%#Eval("mileage") %>"><%#Eval("mileage") %></a></p>
                    <p><b>Rent: $</b><%#Eval("rent")%>/month</p>
                    <p><b>Available: </b><%#Eval("availability")%></p>
             
                    <p><b>Book for: </b><input ID="months" type="number" name="months" min="1" max="24"> months.</p>
                    <input type="hidden" name="carid" value='<%#Eval("carId")%>'>
                    <input type="hidden" name="carname" value='<%#Eval("carname")%>'>
                    <input type="hidden" name="bname" value='<%#Eval("bname")%>'>
                    <input type="hidden" name="bid" value='<%#Eval("bid")%>'>
                    <input type="hidden" name="rent" value='<%#Eval("rent")%>'>
                    <asp:Button ID="Button2" runat="server" Text="Checkout" OnClick="Checkout"></asp:Button>
           
                </div>
            </div>
            
               </ItemTemplate>
            </asp:Repeater>
        
        </div>
        

    </div>
    </center>
</asp:Content>

