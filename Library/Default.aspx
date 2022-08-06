<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Library._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div class="jumbotron">
        <h1>Добро пожаловать в нашу библиотеку.</h1>
    </div>
    <div class="row">
        <div class="col-md-4">
            <h2>Список книг</h2>
                        <p>
                Вы можете посмотреть все книги, которые есть у нас в библиотеке
            </p>
            <p>
                <a class="btn btn-default" runat="server" href="~/AllBooks">Посмотреть &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Добавить книгу</h2>
            <p>
                Если у вас есть книга, которой вы готовы поделиться с другими, вы можете добавить ее в наш список книг
            </p>
            <p>
                <a class="btn btn-default" runat="server" href="~/AddAuthor">Добавить &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Поиск книги</h2>
            <p>
                Вы можете проверить, есть ли нужная вам книга в нашей библиотеке
            </p>
            <p>
                <a class="btn btn-default" runat="server" href="~/Search">Поиск &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
