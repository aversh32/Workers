<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listing.aspx.cs" Inherits="Work.Pages.Listing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Workers</title>
      <link rel="stylesheet" href="/Content/Styles.css" />
</head>
<body>
    <h1>Список сотрудников</h1>
    <form id="form1" runat="server">
        <div>

 <asp:Button ID="AddButton"   runat="server" OnClick="Add_Click" Text="Добавить" />
            <table>
                <tr>
                    <td><h3>Имя</h3></td>
                    <td><h3>Фамилия</h3></td>
                    <td><h3>Возраст</h3></td>
                    <td><h3>Язык</h3></td>
                    <td><h3>Отдел</h3></td>
                </tr>
                <asp:Repeater ItemType="Work.Models.Worker"
                SelectMethod="GetWorkers" runat="server">
            <ItemTemplate>
                <tr class="item">
                    <td><%# Item.Name %></td>
                    <td><%# Item.Surname %></td>
                    <td><%# Item.Age %></td>
                    <td><%# Item.department_id %></td>
                    <td><%# Item.lang_id %></td>
<td><asp:Button ID="btnEdit" Runat="server" OnClick="Edit_Click" Text="Редактировать"></asp:Button></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
            </table>
        </div>
    </form>
</body>
</html>


