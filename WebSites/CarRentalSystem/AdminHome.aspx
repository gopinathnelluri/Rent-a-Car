<%@ Page Title="Admin Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="AdminHome.aspx.cs" Inherits="Account_AdminHome" Async="true" %>


 <asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
     <center>
    <div style="width:1024px;height:100px;float:left;"></div>
         <h1>Welcome, Admin</h1>
         Your Options:
    <div style="position:relative;top:20px">
        <a href="../ManageBrands"><div style="width:300px;background-color:#2980b9;color:white;padding:10px;margin:10px;"><p><b> Manage Brands</b></p></div></a>
        <a href="../ManageCars"><div style="width:300px;background-color:#2980b9;color:white;padding:10px;margin:10px;"><p><b> Manage Cars</b></p></div></a>
        <a href="../ViewBookings"><div style="width:300px;background-color:#2980b9;color:white;padding:10px;margin:10px;"><p><b> View Bookings</b></p></div></a>

    </div>
     </center>
</asp:Content>
