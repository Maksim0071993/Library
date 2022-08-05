<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookAdditionConfirmation.aspx.cs" Inherits="Library.BookAdditionConfirmation" %>
<%@ Import Namespace="System.Web.Routing" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-4">
            <div>  
              <asp:Label runat="server" ID="AuthorFirstName">Книга успешно добавлена</asp:Label>  
             </div>
       </div>
        </div>
</asp:Content>