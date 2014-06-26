<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="UserEdit.aspx.cs" Inherits="UserEdit" %>

<asp:Content ID="ctMain" ContentPlaceHolderID="ctMainContentPlaceHolder" Runat="Server">
  <div class="row">
    <div class="col-sm-10 col-sm-offset-1 col-md-8 col-md-offset-2">
      <div class="edit-form">
        <form method="post" enctype="multipart/form-data">
          <div class="form-group">
            <label for="username">用户名</label>
            <input type="text" class="form-control" id="username" name="username"
                placeholder="请输入用户名" value="<%= user.Username%>">
          </div>
          <div class="form-group">
            <label for="password">密码</label>
            <input type="password" class="form-control" id="password" name="password"
                placeholder="请输入密码">
          </div>
          <div class="form-group">
            <label for="password2">确认密码</label>
            <input type="password" class="form-control" id="password2" name="password2"
                placeholder="请确认密码">
          </div>
          <asp:PlaceHolder ID="ctExtraInfo" runat="server">
            <div class="form-group">
              <label for="email">邮箱</label>
              <input type="text" class="form-control" id="email" name="email"
                  placeholder="请输入邮箱" value="<%= user.Email %>">
            </div>
            <div class="form-group">
              <label for="phone">手机号</label>
              <input type="text" class="form-control" id="phone" name="phone"
                  placeholder="请输入手机号", value="<%= user.Phone %>">
            </div>
            <div class="form-group">
              <label for="address">收货地址</label>
              <input type="text" class="form-control" id="address" name="address"
                  placeholder="请输入收货地址", value="<%= user.Address %>">
            </div>
            <div class="form-group">
              <label for="zip-code">邮编</label>
              <input type="text" class="form-control" id="zip-code" name="zip-code"
                  placeholder="请输入邮编", value="<%= user.ZipCode %>">
            </div>
          </asp:PlaceHolder>
          <button type="submit" class="btn btn-primary">提交</button>
        </form>
      </div>
    </div>
  </div>
</asp:Content>

