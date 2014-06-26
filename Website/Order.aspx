<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="Order.aspx.cs" Inherits="Order" %>

<asp:Content ID="ctMain" ContentPlaceHolderID="ctMainContentPlaceHolder" Runat="Server">
  <div class="row">
    <div class="col-sm-10 col-sm-offset-1 col-lg-8 col-lg-offset-2">
      <table class="table table-striped orders">
        <tr>
          <th>编号</th>
          <th>商品</th>
          <th>客户</th>
          <th>操作</th>
        </tr>
            <asp:Repeater ID="ctOrders" runat="server">
              <ItemTemplate>
        <tr>
          <td><%# Eval("ID") %></td>
          <td><a href="/Item.aspx?ID=<%# Eval("ComputerID") %>"><%# Eval("Computer.Name") %></a></td>
          <td><a href="/User.aspx?ID=<%# Eval("UserID") %>"><%# Eval("User.Username") %></a></td>
          <td></td>
        </tr>
              </ItemTemplate>
            </asp:Repeater>
      </table>
    </div>
  </div>
</asp:Content>

