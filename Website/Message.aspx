<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="Message.aspx.cs" Inherits="Message" %>

<asp:Content ID="ctMain" ContentPlaceHolderID="ctMainContentPlaceHolder" Runat="Server">
  <div class="row">
    <div class="col-sm-10 col-sm-offset-1 col-md-8 col-md-offset-2">
      <div class="message bordered">
        <p><%= Context.Items["Message"] %></p>
        <a class="btn btn-primary go-back" href="#">返回</a>
      </div>
    </div>
  </div>
</asp:Content>
