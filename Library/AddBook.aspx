<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="Library.AddBook" %>
<%@ Import Namespace="System.Web.Routing" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div class="jumbotron">
        <h1>Добавление книг</h1>
    </div>
    <div class="row">
        <div class="col-md-4">
            </div>
           <div>  
              <asp:Label runat="server" ID="NameOfBook">Название книги</asp:Label>  
             </div>
        
         <div>  
              <asp:TextBox runat="server" ID="AddedBookName" required="required" ErrorMessage="Поле должно быть заполнено"/> 
         </div> 
        </div>
    <div>  
               <asp:Button runat="server" OnClick="AddNewBook" Text="Добавить" /> 
        </div>  
        

</asp:Content>