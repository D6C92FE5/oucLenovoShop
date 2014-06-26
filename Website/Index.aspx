<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<asp:Content ID="ctMain" ContentPlaceHolderID="ctMainContentPlaceHolder" Runat="Server">
  <form method="get" id="filter">
    <div class="row">
      <div class="col-sm-5">
        <select class="form-control" name="ScreenSize">
          <option value="">请选择屏幕尺寸</option>
              <asp:Repeater ID="ctScreenSizes" runat="server">
                <ItemTemplate>
          <option><%# Container.DataItem %></option>
                </ItemTemplate>
              </asp:Repeater>
        </select>
      </div>
      <div class="col-sm-5">
        <select class="form-control" name="Processor">
          <option value="">请选择 CPU 型号</option>
              <asp:Repeater ID="ctProcessors" runat="server">
                <ItemTemplate>
          <option><%# Container.DataItem %></option>
                </ItemTemplate>
              </asp:Repeater>
        </select>
      </div>
      <div class="col-sm-2">
        <button type="submit" class="btn btn-primary">筛选</button>
      </div>
    </div>
  </form>
  <div class="pure-g" id="items">
        <asp:Repeater ID="ctItems" runat="server">
          <ItemTemplate>
    <div class="pure-u-xl-1-5 pure-u-lg-1-4 pure-u-md-1-3 pure-u-sm-1-2">
      <div class="item">
        <a class="title" href="Item.aspx?ID=<%# Eval("ID") %>">
          <img src="<%# ResolveUrl(Eval("ListPicture").ToString()) %>">
        </a>
        <span class="price"><span>¥</span><strong><%# Eval("Price") %></strong></span>
        <a class="title" href="Item.aspx?ID=<%# Eval("ID") %>"><%# Eval("Name") %></a>
      </div>
    </div>
          </ItemTemplate>
        </asp:Repeater>
    <div class="pure-u-xl-1-5 pure-u-lg-1-4 pure-u-md-1-3 pure-u-sm-1-2">
      <div class="item">&nbsp;</div>
    </div>
    <div class="pure-u-xl-1-5 pure-u-lg-1-4 pure-u-md-1-3 pure-u-sm-1-2">
      <div class="item">&nbsp;</div>
    </div>
    <div class="pure-u-xl-1-5 pure-u-lg-1-4 pure-u-md-1-3 pure-u-sm-1-2">
      <div class="item">&nbsp;</div>
    </div>
    <div class="pure-u-xl-1-5 pure-u-lg-1-4 pure-u-md-1-3 pure-u-sm-1-2">
      <div class="item">&nbsp;</div>
    </div>
    <div class="pure-u-xl-1-5 pure-u-lg-1-4 pure-u-md-1-3 pure-u-sm-1-2">
      <div class="item">&nbsp;</div>
    </div>
  </div>
</asp:Content>
