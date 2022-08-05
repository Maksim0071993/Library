<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResultSearch.aspx.cs" Inherits="Library.ResultSearch"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Результат поиска</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1> Вот что удалось найти по вашему запросу</h1>
    <hr />
    <table class="table">
        <thead>
            <tr>
                <th>Автор</th>
                <th>Название книги</th>
            </tr>
        </thead>
        <tbody>
            <%=GetFilterBooks() %>
        </tbody>
    </table>
        </div>
    </form>
</body>
</html>
