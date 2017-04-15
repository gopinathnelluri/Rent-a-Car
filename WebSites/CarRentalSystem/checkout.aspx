<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" EnableEventValidation="true"  AutoEventWireup="true" CodeFile="checkout.aspx.cs" Inherits="Booking" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <center>
        <div style="position:relative;width:1024px;height:40px;">
        </div>
        <div style="position:relative;width:1024px;">
            <div>
                <div style="position:relative;width:400px;float:left;">
                    <img src="images/cars/<%=bid%>-<%=carid%>.png" width="400px">
                </div>
                <div style="position:relative;width:624px;float:left;text-align:left;">
                    <p><b>Car: </b><%=carname%></p>
                    <p><b>Brand: </b><%=bname %></p>
                    <p><b>Amount: </b>$<%=amount %></p>
                    <p><b>PickUp Date: </b><input type="date" name="pickup" required></p>
                    <p><b>Card Number: </b><input type="number" name="card" pattern="[0-9]{16}" size="16" title="invaid card number format" required></p>
                    <p><b>Valid Till: </b><input type="month" name="exp" min="2015-12-02" required></p>
                    <p><b>CVV: </b><input type="number" name="cvv" min="100" max="999" title="invaid CVV format" required ></p>
                    <input type="hidden" name="carid" value="<%=carid%>" required>
                    <input type="hidden" name="months" value="<%=months %>" required>
                    <input type="hidden" name="amount" value="<%=amount %>" required>
                    <asp:Button ID="Button1" width="200px" runat="server" OnClick="Button1_Click" Text="Pay"></asp:Button>
                </div>
            </div>
        </div>
        <div style="width:1024px;height:200px">
        </div>
    </center>

</asp:Content>