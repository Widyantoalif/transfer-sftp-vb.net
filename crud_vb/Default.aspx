<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="crud_vb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     <div class="container">
        <h2><%: Title %></h2>

        <a href="Create_S.aspx">Create New</a>


        <h4>Search Student</h4>

        <div class="form-horizontal">
            <hr />
            <table class="nav-justified">
                <tr>
                    <td class="modal-sm control-label col-md-2" style="width: 293px; font-weight: bold;">Student ID</td>
                    <td>
                       <asp:FileUpload ID="fileupload" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td><p></p></td>
                </tr>
              
                <tr>
                    <td class="modal-sm control-label col-md-2" style="width: 293px; font-weight: bold;">&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Input" CssClass="btn btn-default"/>
                    &nbsp;<asp:Button ID="Button2" runat="server" Text="Update" CssClass="btn btn-default"/>
                    &nbsp;</td>
                </tr>
            </table>
            <hr />
        </div>
        <div>

</asp:Content>
