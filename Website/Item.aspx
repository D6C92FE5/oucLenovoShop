<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="Item.aspx.cs" Inherits="Item" %>

<asp:Content ID="ctMain" ContentPlaceHolderID="ctMainContentPlaceHolder" Runat="Server">
  <div class="detail bordered">
    <div class="row">
      <div class="col-md-7">
        <img src="<%= ResolveUrl(item.DetailPicture) %>" />
      </div>
      <div class="col-md-5">
        <h2>Yoga2 13-ITH (日光橙) (H)</h2>
        <ul class="info">
          <li>
            <label>价格</label>
            <span class="info-item price"><span>¥</span><strong><%= item.Price %></strong></span>
          </li>
          <li>
            <label>型号</label>
            <span class="info-item"><%= item.Model %></span>
          </li>
          <li>
            <label>屏幕大小</label>
            <span class="info-item"><%= item.ScreenSize %></span>
          </li>
          <li>
            <label>处理器</label>
            <span class="info-item"><%= item.Processor %></span>
          </li>
        </ul>
        <div class="operate">
          <asp:PlaceHolder ID="ctOperateUser" runat="server">
            <a class="btn btn-success" href="/OrderNew.aspx?ItemID=<%= item.ID %>">预定</a>
          </asp:PlaceHolder>
          <asp:PlaceHolder ID="ctOperateAdmin" runat="server">
            <a class="btn btn-info" href="/ItemEdit.aspx?ID=<%= item.ID %>">修改</a>
            <a class="btn btn-danger" href="/ItemDelete.aspx?ID=<%= item.ID %>">删除</a>
          </asp:PlaceHolder>
          <asp:PlaceHolder ID="ctDeleted" runat="server">
            <a class="btn btn-default disabled">此商品已被删除</a>
          </asp:PlaceHolder>
        </div>
      </div>
    </div>
  </div>
  <div class="detail bordered intro">
    <%= item.Intro %>
  </div>
</asp:Content>
