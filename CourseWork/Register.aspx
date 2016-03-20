<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="CourseWork.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style1 {
            background-color: #CCCCCC;
        }
        .auto-style5 {
            width: 200px;
            height: 23px;
        }
        .auto-style6 {
            height: 23px;
        }
        .auto-style7 {
            width: 312px;
        }
        .auto-style8 {
            height: 46px;
            width: 312px;
        }
        .auto-style12 {
            height: 47px;
        }
    .auto-style15 {
        height: 26px;
    }
        .auto-style16 {
            width: 59px;
            height: 26px;
            font-size: medium;
            color: #006666;
        }
        .auto-style19 {
            height: 37px;
            width: 253px;
        }
        .auto-style22 {
            color: #336699;
            height: 18px;
            width: 232px;
        }
        .auto-style25 {
            height: 37px;
            width: 232px;
        }
        .auto-style26 {
            font-size: medium;
        }
        .auto-style29 {
            color: #009999;
            width: 59px;
        }
        .auto-style31 {
            height: 37px;
            width: 59px;
            color: #006666;
            font-size: medium;
        }
        .auto-style33 {
            height: 47px;
            width: 59px;
            color: #006666;
            font-size: medium;
        }
        .auto-style35 {
            color: #006666;
            width: 59px;
            font-size: medium;
        }
        .auto-style43 {
            width: 59px;
            height: 18px;
            font-size: medium;
            color: #006666;
        }
        .auto-style44 {
            height: 18px;
            font-size: medium;
        }
        .auto-style45 {
            color: #006666;
        }
        .auto-style46 {
            color: #006666;
            font-size: medium;
        }
        .auto-style49 {
            color: #006666;
            width: 176px;
            font-size: medium;
        }
        .auto-style50 {
            width: 176px;
            height: 26px;
            font-size: medium;
            color: #006666;
        }
        .auto-style51 {
            width: 176px;
            height: 18px;
            font-size: medium;
            color: #006666;
        }
        .auto-style52 {
            height: 37px;
            width: 176px;
            color: #006666;
            font-size: medium;
        }
        .auto-style53 {
            height: 47px;
            width: 176px;
            color: #006666;
            font-size: medium;
        }
        .auto-style54 {
            color: #009999;
            width: 176px;
        }
        .auto-style55 {
            width: 270px;
        }
        .auto-style56 {
            font-size: medium;
            width: 270px;
        }
        .auto-style57 {
            height: 18px;
            font-size: medium;
            width: 270px;
        }
        .auto-style58 {
            height: 37px;
            width: 270px;
        }
        .auto-style59 {
            height: 26px;
            width: 270px;
        }
        .auto-style60 {
            height: 47px;
            width: 270px;
        }
        .auto-style62 {
            height: 26px;
            width: 232px;
        }
        .auto-style63 {
            height: 47px;
            width: 232px;
        }
        .auto-style74 {
            color: #009999;
            width: 232px;
        }
        .auto-style77 {
            color: #009999;
            width: 232px;
            height: 29px;
        }
        .auto-style78 {
            height: 29px;
            width: 59px;
            color: #006666;
            font-size: medium;
        }
        .auto-style79 {
            height: 29px;
            width: 176px;
            color: #006666;
            font-size: medium;
        }
        .auto-style80 {
            height: 29px;
            width: 270px;
        }
        .auto-style81 {
            height: 29px;
        }
        .auto-style84 {
            color: #009999;
            width: 232px;
            height: 16px;
        }
        .auto-style85 {
            height: 16px;
            width: 270px;
        }
        .auto-style86 {
            height: 16px;
        }
        .auto-style87 {
            width: 59px;
            height: 16px;
            font-size: medium;
            color: #006666;
        }
        .auto-style88 {
            width: 176px;
            height: 16px;
            font-size: medium;
            color: #006666;
        }
        .auto-style91 {
            color: #009999;
            width: 232px;
            height: 45px;
        }
        .auto-style92 {
            height: 45px;
            width: 59px;
            color: #006666;
            font-size: medium;
        }
        .auto-style93 {
            height: 45px;
            width: 176px;
            color: #006666;
            font-size: medium;
        }
        .auto-style94 {
            height: 45px;
            width: 270px;
        }
        .auto-style95 {
            height: 45px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style1">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label4" runat="server" style="color: #FFFFFF; font-size: xx-large; background-color: #CCCCCC" Text="Create an Acount"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
        </tr>
        </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style92">
                </td>
            <td class="auto-style93">
                Name:</td>
            <td class="auto-style91">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Please inser your name"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style94"></td>
            <td class="auto-style95"></td>
            <td class="auto-style95"></td>
        </tr>
        <tr>
            <td class="auto-style78"></td>
            <td class="auto-style79">&nbsp;Surname:</td>
            <td class="auto-style77">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style80">
                </td>
            <td class="auto-style81">
                </td>
            <td class="auto-style81">
                </td>
        </tr>
        <tr>
            <td class="auto-style87"></td>
            <td class="auto-style88"></td>
            <td class="auto-style84">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Please insert your surname"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style85">
                </td>
            <td class="auto-style86">
                </td>
            <td class="auto-style86">
                </td>
        </tr>
        <tr>
            <td class="auto-style35">
                &nbsp;</td>
            <td class="auto-style49">
                Address:</td>
            <td class="auto-style74">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style55">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style35">
                &nbsp;</td>
            <td class="auto-style49">
                Telephone number:</td>
            <td class="auto-style74">
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style56">
                <span class="auto-style45">Chose a password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
                <asp:TextBox ID="TextBox8" TextMode="Password" runat="server" CssClass="auto-style46"></asp:TextBox>
            </td>
            <td class="auto-style26">
                &nbsp;</td>
            <td class="auto-style26">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style35">
                &nbsp;</td>
            <td class="auto-style49">
                &nbsp;</td>
            <td class="auto-style74">
                &nbsp;</td>
            <td class="auto-style56">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox8" ErrorMessage="Please insert a password"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style26">
                &nbsp;</td>
            <td class="auto-style26">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style43">
                &nbsp;</td>
            <td class="auto-style51">
                Email Address:</td>
            <td class="auto-style22">
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style57"><span class="auto-style45">Repeat the password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
                <asp:TextBox ID="TextBox9" TextMode="Password" runat="server" CssClass="auto-style46"></asp:TextBox>
            </td>
            <td class="auto-style44">&nbsp;</td>
            <td class="auto-style44">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style43">
                &nbsp;</td>
            <td class="auto-style51">
                &nbsp;</td>
            <td class="auto-style22">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox5" ErrorMessage="Please insert an email adress"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style57">&nbsp;</td>
            <td class="auto-style44">&nbsp;</td>
            <td class="auto-style44">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style35">
                &nbsp;</td>
            <td class="auto-style49">
                Gender</td>
            <td class="auto-style74">
                <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatDirection="Horizontal" ForeColor="Black">
                    <asp:ListItem Value="1">male</asp:ListItem>
                    <asp:ListItem Value="2">female</asp:ListItem>
                </asp:CheckBoxList>
            </td>
            <td class="auto-style55">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBox9" ErrorMessage="Please insert a password"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style31">
                &nbsp;</td>
            <td class="auto-style52">
                Age:</td>
            <td class="auto-style25">
                <asp:TextBox ID="TextBox6" runat="server" CssClass="auto-style26"></asp:TextBox>
            </td>
            <td class="auto-style58">
                </td>
            <td class="auto-style19">
                &nbsp;</td>
            <td class="auto-style19">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style16">
                &nbsp;</td>
            <td class="auto-style50">
                Yoga experience:</td>
            <td class="auto-style62">
                <asp:CheckBoxList ID="CheckBoxList3" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Value="1">Advanced</asp:ListItem>
                    <asp:ListItem Value="2">Intermediate</asp:ListItem>
                    <asp:ListItem Value="3">Beginer</asp:ListItem>
                </asp:CheckBoxList>
            </td>
            <td class="auto-style59"></td>
            <td class="auto-style15">&nbsp;</td>
            <td class="auto-style15">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style35">
                &nbsp;</td>
            <td class="auto-style49">
                Health issues :</td>
            <td class="auto-style74">
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style55">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style33" aria-hidden="False">
                &nbsp;</td>
            <td class="auto-style53" aria-hidden="False">
                <asp:Label ID="Label3" runat="server" Text="Acount Type:"></asp:Label>
            </td>
            <td class="auto-style63">
                <asp:CheckBoxList ID="CheckBoxList2" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Value="1">Client</asp:ListItem>
                    <asp:ListItem Value="2">Staff</asp:ListItem>
                </asp:CheckBoxList>
            </td>
            <td class="auto-style60"></td>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style12">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">
                &nbsp;</td>
            <td class="auto-style54">
                &nbsp;</td>
            <td class="auto-style74">
                <asp:Button ID="Button1" runat="server" Text="Create Account" OnClick="Button1_Click" BackColor="#669999" ForeColor="White" />
            </td>
            <td class="auto-style55">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style29">&nbsp;</td>
            <td class="auto-style54">&nbsp;</td>
            <td class="auto-style74">&nbsp;</td>
            <td class="auto-style55">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        </table>
</asp:Content>
