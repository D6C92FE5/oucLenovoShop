﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="ItemEdit.aspx.cs" Inherits="ItemEdit" ValidateRequest="false" %>

<asp:Content ID="ctMain" ContentPlaceHolderID="ctMainContentPlaceHolder" Runat="Server">
  <div class="row">
    <div class="col-sm-10 col-sm-offset-1 col-md-8 col-md-offset-2">
      <div class="edit-form">
        <form method="post" enctype="multipart/form-data">
          <div class="form-group">
            <label for="name">名称</label>
            <input type="text" class="form-control" id="name" name="name" required
                placeholder="请输入商品名称" value="<%= item.Name %>">
          </div>
          <div class="form-group">
            <label for="price">价格</label>
            <input type="text" class="form-control" id="price" name="price" required
                placeholder="请输入价格" value="<%= item.Price %>">
          </div>
          <div class="form-group">
            <label for="modal">型号</label>
            <input type="text" class="form-control" id="modal" name="modal" required
                placeholder="请输入型号" value="<%= item.Model %>">
          </div>
          <div class="form-group">
            <label for="screen-size">屏幕尺寸</label>
            <input type="text" class="form-control" id="screen-size" name="screen-size" required
                placeholder="请输入屏幕尺寸" value="<%= item.ScreenSize %>">
          </div>
          <div class="form-group">
            <label for="processor">处理器</label>
            <input type="text" class="form-control" id="processor" name="processor" required
                placeholder="请输入处理器型号" value="<%= item.Processor %>">
          </div>
          <div class="form-group">
            <label for="list-picture">列表图片</label>
            <input type="file" id="list-picture" name="list-picture">
          </div>
          <div class="form-group">
            <label for="detail-picture">展示图片</label>
            <input type="file" id="detail-picture" name="detail-picture" multiple>
          </div>
          <div>
            <label for="detail-picture">详细介绍</label>
            <textarea class="wysiwyg form-control" rows="10" name="intro">
              <%= item.Intro %>
            </textarea>
          </div>
          <button type="submit" class="btn btn-primary">提交</button>
        </form>
      </div>
    </div>
  </div>
</asp:Content>
