<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Brands.aspx.cs" Inherits="Brands" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
   <div style="position:relative;top:30px;">
       <center>
       <h1>Brands</h1> 
       <div style="position:relative;width:1024px;background:yellow;">
            
        <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate>
            <a href= <%#"search.aspx?name="+Eval("bname").ToString() %> >
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
    </br>
    
</asp:Content>
