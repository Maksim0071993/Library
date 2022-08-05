<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="Library.AddBook" %>
<%@ Import Namespace="System.Web.Routing" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div class="jumbotron">
        <h1>Добавление книг</h1>
    </div>
    <div class="row">
        <div class="col-md-4">
            <div>  
              <asp:Label runat="server" ID="AuthorFirstName">Имя автора</asp:Label>  
             </div>
         <div>  
              <asp:TextBox runat="server" ID="FirstName" /> 
         </div> 
           <div>  
              <asp:Label runat="server" ID="AuthorLastName">Фамилия автора</asp:Label>  
             </div>
         <div>  
              <asp:TextBox runat="server" ID="LastName" /> 
         </div> 
        </div>
        </div> 
           <div>  
              <asp:Label runat="server" ID="NameOfBook">Название книги</asp:Label>  
             </div>
         <div>  
              <asp:TextBox runat="server" ID="BookName" /> 
         </div> 
    <div>  
               <asp:Button runat="server" OnClick="AddNewBook" Text="Добавить" /> 
        </div>  

</asp:Content>