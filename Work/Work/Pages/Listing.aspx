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
            <%
                foreach (Work.Models.Worker worker in GetWorkers())
                {
                    Response.Write(String.Format(@"
                        <div class='item'>                 
                        <tr>
                            <td>{0}</td>
                             <td> {1}</td>
                             <td>{2}</td>  
<td>{3}</td>   
<td>{4}</td>     
<td><button name='edit'  runat='server' OnClick='Edit_Click'> Изменить  </button>    
<button name='delete'  OnClick='Delete_Click' > Удалить  </button></td>                   
                       ", worker.Name, worker.Surname, worker.Age, worker.lang_id, worker.department_id));

                }
            %>
            </table>
        </div>
    </form>
</body>
</html>