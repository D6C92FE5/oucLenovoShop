<%@ Page Title="" Language="C#" MasterPageFile="~/Auth.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="ctMain" ContentPlaceHolderID="ctMainContentPlaceHolder" Runat="Server">
  <h1>
    请登录
    <span class="error"><asp:Literal ID="ctMessage" runat="server"></asp:Literal></span>
  </h1>
  <input type="text" name="username" placeholder="用户名" autofocus="autofocus" class="form-control" />
  <input type="password" name="password" placeholder="密码" class="form-control" />
  <button type="submit" class="btn btn-lg btn-primary">登录</button>
  <a href="Signup.aspx" class="alter">创建新帐户</a>
</asp:Content>
