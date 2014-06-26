<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="User.aspx.cs" Inherits="User_" %>

<asp:Content ID="ctMain" ContentPlaceHolderID="ctMainContentPlaceHolder" Runat="Server">
  <div class="row">
    <div class="col-md-8 col-md-offset-2">
      <ul class="user bordered">
        <li>
          <label>用户名</label>
          <span class="info-item"><%= user.Username %></span>
        </li>
        <li>
          <label>邮箱</label>
          <span class="info-item"><%= user.Email %></span>
        </li>
        <li>
          <label>手机号</label>
          <span class="info-item"><%= user.Phone %></span>
        </li>
        <li>
          <label>收货地址</label>
          <span class="info-item"><%= user.Address %></span>
        </li>
        <li>
          <label>邮编</label>
          <span class="info-item"><%= user.ZipCode %></span>
        </li>
      </ul>
    </div>
  </div>
</asp:Content>
