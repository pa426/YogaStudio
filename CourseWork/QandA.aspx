<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="QandA.aspx.cs" Inherits="CourseWork.QandA" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style5 {
            width: 350px;
        }
        .auto-style6 {
        width: 285px;
    }
    .auto-style7 {
        width: 285px;
        height: 21px;
    }
    .auto-style8 {
        width: 51px;
        height: 21px;
    }
    .auto-style9 {
        height: 21px;
    }
        .auto-style10 {
            width: 253px;
            height: 50px;
        }
        .auto-style11 {
            width: 51px;
            height: 50px;
        }
        .auto-style12 {
            height: 50px;
        }
        .auto-style13 {
            width: 253px;
            height: 15px;
        }
        .auto-style14 {
            width: 51px;
            height: 15px;
        }
        .auto-style15 {
            height: 15px;
        }
        .auto-style16 {
            width: 285px;
            height: 7px;
            color: #009999;
        }
        .auto-style17 {
            height: 7px;
            color: #006600;
            font-size: x-large;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:100%; height: 340px;">
        <tr>
            <td class="auto-style16"></td>
            <td class="auto-style17" colspan="2">
                Forum Page</td>
        </tr>
        <tr>
            <td class="auto-style7"></td>
            <td class="auto-style8">
                <asp:Label ID="Label1" runat="server" BorderColor="#0066CC" BackColor="#E6FFF2" BorderStyle="Solid" BorderWidth="1px" ForeColor="#006600"></asp:Label>
            </td>
            <td class="auto-style9"></td>
        </tr>
        <tr>
            <td class="auto-style13"></td>
            <td class="auto-style14">
                <asp:TextBox ID="TextBox2" runat="server" Height="69px" style="margin-top: 13px" Width="358px"></asp:TextBox>
            </td>
            <td class="auto-style15"></td>
        </tr>
        <tr>
            <td class="auto-style10"></td>
            <td class="auto-style11">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Comment" BackColor="#669999" ForeColor="White" />
            </td>
            <td class="auto-style12"></td>
        </tr>
        <tr>
            <td class="auto-style10">&nbsp;</td>
            <td class="auto-style11">
                &nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
        </tr>
        </table>
</asp:Content>
