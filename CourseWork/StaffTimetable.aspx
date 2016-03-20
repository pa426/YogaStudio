<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StaffTimetable.aspx.cs" Inherits="CourseWork.StaffTimetable" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .auto-style6 {
            width: 192px;
        }
    .auto-style7 {
            width: 177px;
            height: 21px;
        }
    .auto-style9 {
            width: 185px;
            height: 21px;
        }
    .auto-style10 {
            height: 21px;
            width: 776px;
        }
    .auto-style11 {
            width: 12px;
            height: 27px;
            font-size: x-large;
            color: #006699;
        }
    .auto-style13 {
            width: 185px;
            height: 27px;
        }
    .auto-style14 {
        height: 27px;
            width: 776px;
        }
        .auto-style19 {
            width: 776px;
            height: 36px;
        }
        .auto-style23 {
            width: 12px;
            height: 62px;
        }
        .auto-style25 {
            width: 776px;
            height: 62px;
        }
        .auto-style26 {
            width: 12px;
            height: 42px;
        }
        .auto-style28 {
            width: 776px;
            height: 42px;
        }
        .auto-style29 {
            width: 12px;
            height: 37px;
        }
        .auto-style31 {
            width: 776px;
            height: 37px;
        }
        .auto-style35 {
            width: 12px;
            height: 21px;
            color: #009999;
        }
        .auto-style36 {
            width: 12px;
            height: 36px;
        }
        .auto-style37 {
            color: #336699;
            font-size: x-large;
        }
        .auto-style39 {
            width: 185px;
            height: 62px;
        }
        .auto-style40 {
            width: 185px;
            height: 42px;
        }
        .auto-style41 {
            width: 185px;
            height: 37px;
        }
        .auto-style42 {
            width: 185px;
            height: 36px;
        }
        .auto-style43 {
            width: 12px;
            height: 35px;
        }
        .auto-style44 {
            width: 185px;
            height: 35px;
        }
        .auto-style45 {
            width: 776px;
            height: 35px;
        }
        .auto-style46 {
            width: 12px;
            height: 16px;
            font-size: x-large;
            color: #006699;
        }
        .auto-style47 {
            width: 185px;
            height: 16px;
        }
        .auto-style48 {
            height: 16px;
            width: 776px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style13">
                <br />
            </td>
            <td class="auto-style14">
                <span class="auto-style37">Please select an action:<br />
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem Value="1">Add Class</asp:ListItem>
                    <asp:ListItem Value="2">Add Workshop</asp:ListItem>
                    <asp:ListItem Value="3">Cancel or remove Class</asp:ListItem>
                    <asp:ListItem Value="4">Cancel or remove Workshop</asp:ListItem>
                    <asp:ListItem Value="5">Remove comment</asp:ListItem>
                </asp:DropDownList>
                </span>
            </td>
        </tr>
        <tr>
            <td class="auto-style46"></td>
            <td class="auto-style47">
                <asp:Label ID="Label1" runat="server" Text="Class starting time:" style="font-size: medium"></asp:Label>
            </td>
            <td class="auto-style48">
                <asp:TextBox ID="TextBox1" runat="server" Width="320px"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Insert valid date and time dd/mm/yyyy hh:mm:ss" ValidationExpression="^(([0]?[1-9]|1[0-2])/([0-2]?[0-9]|3[0-1])/[1-2]\d{3}) (20|21|22|23|[0-1]?\d{1}):([0-5]?\d{1}):([0-5]?\d{1})$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style43">
            </td>
            <td class="auto-style44">
                <asp:Label ID="Label2" runat="server" Text="Class Name:" style="font-size: medium"></asp:Label>
            </td>
            <td class="auto-style45">
                <asp:TextBox ID="TextBox2" runat="server" Height="16px" Width="320px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style35"></td>
            <td class="auto-style9">
                <asp:Label ID="Label3" runat="server" Text="Class Teacher :" style="font-size: medium"></asp:Label>
            </td>
            <td class="auto-style10">
                <asp:DropDownList ID="DropDownList2" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style35"></td>
            <td class="auto-style9">
                <asp:Label ID="Label4" runat="server" Text="Class Level:" style="font-size: medium"></asp:Label>
            </td>
            <td class="auto-style10">
                <asp:DropDownList ID="DropDownList3" runat="server" Height="16px">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem Value="1">Advanced</asp:ListItem>
                    <asp:ListItem Value="2">Intermediate</asp:ListItem>
                    <asp:ListItem Value="3">Beginner</asp:ListItem>
                </asp:DropDownList>
                <asp:GridView ID="GridView2" runat="server" CellPadding="4" ForeColor="#666666" GridLines="None" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" BorderStyle="Solid" BorderWidth="1px" Width="839px" BorderColor="#999999">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:ButtonField  ButtonType="Button" Text="Delete Comment" CommandName="Select" > 
<ItemStyle Width="300px"></ItemStyle>
                        </asp:ButtonField>
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#336699" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
                <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="47px" Width="839px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BorderStyle="Solid" BorderWidth="1px" BackColor="Black" BorderColor="#999999">
                    <Columns>
                        <asp:ButtonField  ButtonType="Button" Text="Remove or cancel" CommandName="Select" ItemStyle-Width="300"  >
<ItemStyle Width="300px"></ItemStyle>
                        </asp:ButtonField>
                    </Columns>
                    <AlternatingRowStyle BackColor="White" ForeColor="#999999" />
                    <EditRowStyle BackColor="#2461BF" />
                    <EmptyDataRowStyle BackColor="#BCDEDE" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E9F8E9" ForeColor="#666666" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="auto-style35"></td>
            <td class="auto-style9">
                <asp:Label ID="Label5" runat="server" Text="Class duration:" ViewStateMode="Enabled" style="font-size: medium"></asp:Label>
            </td>
            <td class="auto-style10">
                <asp:TextBox ID="TextBox3" runat="server" Height="30px" Width="320px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style23"></td>
            <td class="auto-style39">
                <asp:Label ID="Label6" runat="server" Text="Class description:" style="font-size: medium"></asp:Label>
            </td>
            <td class="auto-style25">
                <asp:TextBox ID="TextBox4" runat="server" Height="30px" Width="320px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style26"></td>
            <td class="auto-style40">
                <asp:Label ID="Label7" runat="server" Text="Places available:" style="font-size: medium"></asp:Label>
            </td>
            <td class="auto-style28">
                <asp:DropDownList ID="DropDownList4" runat="server" Height="16px">
                    <asp:ListItem>6</asp:ListItem>
                    <asp:ListItem>7</asp:ListItem>
                    <asp:ListItem>8</asp:ListItem>
                    <asp:ListItem>9</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                    <asp:ListItem>13</asp:ListItem>
                    <asp:ListItem>14</asp:ListItem>
                    <asp:ListItem>15</asp:ListItem>
                    <asp:ListItem>16</asp:ListItem>
                    <asp:ListItem>17</asp:ListItem>
                    <asp:ListItem>18</asp:ListItem>
                    <asp:ListItem>19</asp:ListItem>
                    <asp:ListItem>20</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style29"></td>
            <td class="auto-style41">
                <asp:Label ID="Label8" runat="server" Text="Select period of time:" style="font-size: medium"></asp:Label>
            </td>
            <td class="auto-style31">
                <asp:DropDownList ID="DropDownList5" runat="server" Height="16px">
                    <asp:ListItem Value="1">Once</asp:ListItem>
                    <asp:ListItem Value="2">2 Weeks</asp:ListItem>
                    <asp:ListItem Value="3 ">3 Weeks</asp:ListItem>
                    <asp:ListItem Value="4 ">4 Weeks</asp:ListItem>
                    <asp:ListItem Value="5">5 Weeks</asp:ListItem>
                    <asp:ListItem Value="6 ">6 Weeks</asp:ListItem>
                    <asp:ListItem Value="7">7 Weeks</asp:ListItem>
                    <asp:ListItem Value="8 ">8 Weeks</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style36"></td>
            <td class="auto-style42"></td>
            <td class="auto-style19">
                <asp:Button ID="Button1" runat="server" Text="Add to timetable" OnClick="Button1_Click" BackColor="#669999" ForeColor="White" />
            </td>
        </tr>
        <tr>
            <td class="auto-style36">&nbsp;</td>
            <td class="auto-style42">&nbsp;</td>
            <td class="auto-style19">
                &nbsp;</td>
        </tr>
        </table>
</asp:Content>
