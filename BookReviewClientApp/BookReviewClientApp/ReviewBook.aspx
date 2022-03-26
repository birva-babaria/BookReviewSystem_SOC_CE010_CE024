<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReviewBook.aspx.cs" Inherits="BookReviewClientApp.ReviewBook" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Review Book</title>
    <link href="lib/twitter-bootstrap/css/bootstrap.css" rel="stylesheet" />
        <style>
            .box{
            width: 552px;
            padding: 40px;
            position: absolute;
            top: 40%;
            left: 50%;
            transform: translate(-50%,-50%);
            background-color: gainsboro;
            text-align: center;
            height:350px;
            border-radius:15px;
        }
        .diff{
            margin-bottom:20px;
        }
        .submitbtn{
            width: 25%;
            margin-bottom: 20px;
        }
        .backbtn{
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
         <asp:Label ID="Label4" runat="server" ></asp:Label>
    </div>
    <form class="box" id="form1" runat="server">
         <div>
              <div class="form-group diff">
                  <asp:Label ID="Label1" runat="server" Text="Book ID:"></asp:Label>
                  <asp:TextBox class="form-control" ID="id" runat="server" placeholder="Enter Book's ID to update"></asp:TextBox>
              </div>
             <div class="form-group diff">
                  <asp:Label ID="Label2" runat="server" Text="Books's Name:"></asp:Label>
                  <asp:TextBox class="form-control" ID="name" runat="server" placeholder="Enter Book's Name"></asp:TextBox>
              </div>
                <asp:Button class="btn btn-success submitbtn" ID="goodreview1" runat="server" OnClick="goodreview1_Click" Text="Good" />
                &nbsp;&nbsp;&nbsp;
              <asp:Button class="btn btn-warning submitbtn" ID="avgreview" runat="server" OnClick="avgreview_Click" Text="Average" />
                &nbsp;&nbsp;&nbsp;
              <asp:Button class="btn btn-danger submitbtn" ID="badreview" runat="server" OnClick="badreview_Click" Text="Bad" />
             <br />
                &nbsp;<asp:Button class="btn btn-primary backbtn" ID="BackButton" runat="server" Text="Back" OnClick="BackButton_Click"></asp:Button>
        </div>
    </form>
</body>
</html>
