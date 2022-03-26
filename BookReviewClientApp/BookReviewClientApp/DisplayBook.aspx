<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayBook.aspx.cs" Inherits="BookReviewClientApp.DisplayBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Display Book</title>
    <link href="lib/twitter-bootstrap/css/bootstrap.css" rel="stylesheet" />
    <style>
        .box{
            width: 500px;
            padding: 40px;
            position: absolute;
            top: 40%;
            left: 50%;
            transform: translate(-50%,-50%);
            background-color: gainsboro;
            text-align: center;
            height:400px;
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
    <form id="form1" class="container-fluid align-content-center my-3" runat="server">
        
<div class="card mt-auto" style="width: 18rem;">
  <div class="card-body">
    <h5 class="card-title">Card title</h5>
    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
    <a href="#" class="btn btn-primary">Go somewhere</a>
  </div>
</div>
    </form>
</body>
</html>
