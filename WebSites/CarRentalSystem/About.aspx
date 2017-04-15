<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    
    <p>This application provide users with flexible search of different cars for rental purpose. </p>
    <p>The user can search for different models of cars and choose the period of renting a particular car. </p>
    <p>Every user can search for cars but a registered user can only book a car and rent. </p>
    <p>User can register by providing some details like first name, last name, identification number like passport number or driver's licence number or social security number. </p>
    <p>Using login credentials like username and password a user can login and rent a car for a required period of time. By using different payment methods he/she can pay the amount. </p>
</asp:Content>
