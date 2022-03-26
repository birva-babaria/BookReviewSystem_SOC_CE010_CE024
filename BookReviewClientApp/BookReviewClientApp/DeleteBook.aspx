<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteBook.aspx.cs" Inherits="BookReviewClientApp.DeleteBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Delete Book</title>
    <link href="lib/twitter-bootstrap/css/bootstrap.css" rel="stylesheet" />
    <style>
        .box{
            width: 500px;
            padding: 40px;
            position: absolute;
            top: 30%;
            left: 50%;
            transform: translate(-50%,-50%);
            background-color: gainsboro;
            text-align: center;
            height:250px;
            border-radius:15px;
        }
        .diff{
            margin-bottom:20px;
        }
        .submitbtn{
            width: 100%;
            margin-bottom: 20px;
        }
        .msg{
            width:900px;
            padding-top: 20px;
            margin: auto;
            font-size: 22px;
            font-weight:700;
            text-align: center;
        }
    </style>
</head>
<body>
    <div class="msg">
         <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
    </div>
    <form class="box" id="form1" runat="server">
         <div>
              <div class="form-group diff">
                  <asp:Label ID="Label1" runat="server" Text="Book ID:"></asp:Label>
                  <asp:TextBox class="form-control" ID="id" runat="server" placeholder="Enter Book's ID to delete"></asp:TextBox>
              </div>
              <asp:Button class="btn btn-success submitbtn" ID="DeleteBookSubmit" runat="server" Text="Submit" OnClick="DeleteBookSubmit_Click"></asp:Button>
              <asp:Button class="btn btn-primary submitbtn" ID="BackButton" runat="server" Text="Back" OnClick="BackButton_Click"></asp:Button>
        </div>
    </form>
</body>
</html>
