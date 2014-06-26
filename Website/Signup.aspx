<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="Signup.aspx.cs" Inherits="Signup" %>

<asp:Content ID="ctMain" ContentPlaceHolderID="ctMainContentPlaceHolder" Runat="Server">
  <div class="auth">
    <h1>新账户</h1>
    <form method="post">
      <input type="text" name="username" placeholder="用户名" autofocus="autofocus" class="form-control" />
      <input type="password" name="password" placeholder="密码" class="form-control" />
      <input type="password" name="password2" placeholder="确认密码" class="form-control" />
      <button type="submit" class="btn btn-lg btn-info">创建</button>
      <a href="Login.aspx" class="alter">登录</a>
    </form>
  </div>
</asp:Content>

