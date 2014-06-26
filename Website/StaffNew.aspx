<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="StaffNew.aspx.cs" Inherits="StaffNew" %>

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
          <button type="submit" class="btn btn-primary">提交</button>
        </form>
      </div>
    </div>
  </div>
</asp:Content>
