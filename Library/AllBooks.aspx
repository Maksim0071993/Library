<%@ Page Language="C#" Debug="true" AutoEventWireup="true" CodeBehind="AllBooks.aspx.cs" Inherits="Library.AllBooks" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Все книги</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Наши книги</h1>
            <hr />
            <table class="table">
                <thead>
                <tr>
                    <th>Автор</th>
                    <th>Название книги</th>
                </tr>
                    </thead>
                <tbody>
                    <%= GetAllBooks()%>
                </tbody>
            </table>
        </div>
    </form>
    <div>
        <%
            for (int i = 1; i <= MaxPage; i++)
            {
                Response.Write(
                    String.Format("<a href='/AllBooks.aspx?page={0}' {1}>{2}</a>",
                        i, i == CurrentPage ? "class='selected'" : " ", i));
            }
        %>
    </div>
</body>
</html>
