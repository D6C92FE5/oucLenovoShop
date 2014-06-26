<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="Password.aspx.cs" Inherits="Password" %>

<asp:Content ID="ctMain" ContentPlaceHolderID="ctMainContentPlaceHolder" Runat="Server">
  <div class="row">
    <div class="col-sm-10 col-sm-offset-1 col-md-8 col-md-offset-2">
      <div class="edit-form">
        <form method="post">
          <div class="form-group">
            <label for="password0">原密码</label>
            <input type="password" class="form-control" id="password0" name="password0"
                placeholder="请输入原密码">
          </div>
          <div class="form-group">
            <label for="password">新密码</label>
            <input type="password" class="form-control" id="password" name="password"
                placeholder="请输入新密码">
          </div>
          <div class="form-group">
            <label for="password2">确认密码</label>
            <input type="password" class="form-control" id="password2" name="password2"
                placeholder="请确认新密码">
          </div>
          <button type="submit" class="btn btn-primary">提交</button>
        </form>
      </div>
    </div>
  </div>
</asp:Content>
