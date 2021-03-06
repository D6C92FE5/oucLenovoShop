﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="Signup.aspx.cs" Inherits="Signup" %>

<asp:Content ID="ctMain" ContentPlaceHolderID="ctMainContentPlaceHolder" Runat="Server">
  <div class="row">
    <div class="col-sm-10 col-sm-offset-1 col-md-8 col-md-offset-2">
      <div class="edit-form">
        <form method="post">
          <div class="form-group">
            <label for="username">用户名</label>
            <input type="text" class="form-control" id="username" name="username" required
                placeholder="请输入用户名">
          </div>
          <div class="form-group">
            <label for="password">密码</label>
            <input type="password" class="form-control" id="password" name="password" required
                placeholder="请输入密码">
          </div>
          <div class="form-group">
            <label for="password2">确认密码</label>
            <input type="password" class="form-control" id="password2" name="password2" required
                placeholder="请确认密码">
          </div>
          <div class="form-group">
            <label for="email">邮箱</label>
            <input type="text" class="form-control" id="email" name="email" required
                placeholder="请输入邮箱">
          </div>
          <div class="form-group">
            <label for="phone">手机号</label>
            <input type="text" class="form-control" id="phone" name="phone" required
                placeholder="请输入手机号">
          </div>
          <div class="form-group">
            <label for="address">收货地址</label>
            <input type="text" class="form-control" id="address" name="address" required
                placeholder="请输入收货地址">
          </div>
          <div class="form-group">
            <label for="zip-code">邮编</label>
            <input type="text" class="form-control" id="zip-code" name="zip-code" required
                placeholder="请输入邮编">
          </div>
          <button type="submit" class="btn btn-primary">提交</button>
        </form>
      </div>
    </div>
  </div>
</asp:Content>
