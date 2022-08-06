<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddAuthor.aspx.cs" Inherits="Library.AddAuthor" %>
<%@ Import Namespace="System.Web.Routing" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div class="jumbotron">
        <h1>Добавление автора</h1>
    </div>
    <div class="row">
        <div class="col-md-4">
            <div>  
              <asp:Label runat="server" ID="AuthorFirstName">Имя автора</asp:Label>  
             </div>
         <div>  
              <asp:TextBox runat="server" ID="FirstName" required="required" ErrorMessage="Поле должно быть заполнено"/> 
         </div> 
           <div>  
              <asp:Label runat="server" ID="AuthorLastName">Фамилия автора</asp:Label>  
             </div>
         <div>  
              <asp:TextBox runat="server" ID="LastName" required="required" ErrorMessage="Поле должно быть заполнено" /> 
         </div> 
        </div>
        </div> 
    <div>  
               <asp:Button runat="server" OnClick="AddNewAuthor" Text="Добавить" /> 
        </div>  

</asp:Content>
