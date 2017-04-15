<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <center>
    
    <div style="position:relative;top:30px;width:1024px;">
    <div style="position:relative;width:800px;padding-right:112px;margin-top:20px;margin-bottom:20px;">
        <img src="images/rentacar.png" width="800px">
    </div>
    <asp:TextBox ID="search" placeholder="Search by Brand Name, Car Name.." runat="server" Height="60px" style="max-width:800px;padding-left:10px;padding-right:10px;font-size:30px;" Width="800px"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="search" onclick="Button1_Click" style="position:relative;height:60px;width:200px;top:-6px;"></asp:Button>
    </div>
     </center>
    <center>
        
   <div style="position:relative;top:30px;">
       <h1>Brands</h1> 
       <div style="position:relative;width:1024px;background:yellow;">
            
        <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <a href="search.aspx?name=<%#Eval("bname") %>">
            <div style="position:relative;width:240px;float:left;margin:5px;color:white;">
            
                <div style="position:relative;width:160px;height:160px;float:left;margin:40px;">
                    <img src="images/<%#Eval("bid") %>.png" width="160px" height="160px">
                </div>
                <div style="position:relative;width:240px;height:40px;padding:10px;background-color:#3498db;float:left;">
                   <b> <%#Eval("bname") %> </b>
                </div>
            </div>
            </a>
        </ItemTemplate>
        
        </asp:Repeater>
        </div>
       </center>
       </div>
</asp:Content>
