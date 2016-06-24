<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Work.Pages.Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>AddWorker</title>
      <link rel="stylesheet" href="/Content/Styles.css" />
</head>
<body>
    
    <h1>Редактирование сотрудника</h1>
    <form id="form3" runat="server">
        <div>
            Имя <textarea id="textareaName" name="Name"></textarea>         
        </div>
        <div>
            Фамилия <textarea id="textareaSurname" name="Surname"></textarea>         
        </div>
        <div>
            Возраст <textarea id="textareaAge" name="Age"></textarea>         
        </div>
        <div>
            Отдел <select name="department_id">
                 <%
                foreach (Work.Models.Worker worker in GetWorkers())
                {
                    Response.Write(String.Format(@"
                     <option>{0}</option>                  
                       ", worker.department_id));
                }
            %>
                  </select>
        </div>
        <div>
            Язык программирования <select name="lang_id">
                <%
                foreach (Work.Models.Language language in GetLanguage())
                {
                    Response.Write(String.Format(@"
                     <option>{0}</option>                  
                       ", language.lang_id));
                }
            %>
                  </select>
        </div>

        <asp:Button ID="Button3"   runat="server" OnClick="Edit_Confirm_Click" Text="Сохранить" />
        <asp:Button ID="Button4" runat="server" OnClick="Button2_Click" Text="Отмена" />

    </form>
</body>
</html>