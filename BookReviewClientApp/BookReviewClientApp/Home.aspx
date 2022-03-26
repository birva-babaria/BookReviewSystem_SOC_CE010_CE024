<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="BookReviewClientApp.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <link href="lib/twitter-bootstrap/css/bootstrap.css" rel="stylesheet" />
    <style>
        .homebtn{
            margin: auto;
            width: 1293px;
            padding-top: 40px;
            padding-bottom: 40px;
        }
        .btn{
            width: 250px;
            margin-left:0px;
            margin-right:20px;
            margin-top: 0px;
        }
        .heading{
            width:900px;
            margin-top:20px;
            margin-bottom:20px;
            margin: auto;
            font-size: 40px;
            font-weight:800;
            text-align: center;
        }
        .centered-table {
   margin-left: auto;
   margin-right: auto;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="heading">
            <asp:Label ID="Label1" runat="server" Text="Book Review System"></asp:Label>
        </div>
        <hr/>
        <div class="homebtn">
            &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;           
            &nbsp;
            &nbsp;
            &nbsp;
            <asp:Button class="btn btn-primary btn-lg btn" ID="addBook" runat="server" Text="Add Book" OnClick="GoToAddBook" />
            <asp:Button class="btn btn-primary btn-lg btn" ID="updateBook" runat="server" Text="Update Book" OnClick="GoToUpdateBook"/>
            <asp:Button class="btn btn-primary btn-lg btn" ID="deleteBook" runat="server" Text="Delete Book" OnClick="GoToDeleteBook"/>
            &nbsp;
            <asp:Button class="btn btn-primary btn-lg btn" ID="reviewBook" runat="server" OnClick="reviewBook_Click" Text="Review Book" Width="193px" />
        </div>
        <hr/>

                <br />
                <br />
         <div style="text-align:center" class="centered-table">
                <asp:GridView ID="GridView1" runat="server" Height="252px" Width="1043px" HorizontalAlign="Center" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
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
             </div>
                <br />
                <br />
                <br />
                <br />
                <br />
       
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
