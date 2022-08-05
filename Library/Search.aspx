<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="Library.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Поиск книг</title>
</head>
<body>
    <form id="form1" runat="server" >
        <div>
            <h1>Поиск книг</h1>
        </div>
         <div>  
              <asp:Label runat="server" ID="AuthorName">Фамилия автора</asp:Label>  
             </div>
         <div>  
              <asp:TextBox runat="server" ID="LastName" /> 
         </div> 
        
         <div>  
              <asp:Label runat="server" ID="NameBook">Название книги</asp:Label> 
             </div>
         <div>  
               <asp:TextBox runat="server" ID="NameOfBook" />  
         </div>  
        <div>  
               <asp:Button runat="server" OnClick="SearchBook" Text="Поиск" /> 
        </div>  
                  
    </form>
</body>
</html>
