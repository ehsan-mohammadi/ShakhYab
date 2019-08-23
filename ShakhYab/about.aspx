<%@ Page Title="Shakh Yab - About" Language="C#" MasterPageFile="~/master/WebMaster.Master" AutoEventWireup="true" CodeBehind="about.aspx.cs" Inherits="ShakhYab.about" %>
<asp:Content ID="Content1" ContentPlaceHolderID="main" runat="server">
    <div class="title-side-by-side">
        <div class="title-logo">
            <div class="title-logo-image" style="width: 150px; height: 150px; border: 1px solid #e6e6e6; border-radius: 100%;  background-image: url(https://avatars1.githubusercontent.com/u/22881814?s=460&v=4)"></div>
            <div style="margin-top: 20px;">
                <a class="button-circle-white ripple stay" href="mailto:mohammadi.ehsan1994@gmail.com" target="_blank">
                    <img width="26" height="26" src="/images/image-email.svg" style="vertical-align: top; margin-top:10px;"/>
                    <span class="tooltip">Email</span>
                </a>
                <a class="button-circle-white ripple stay" href="https://github.com/ehsan-mohammadi" target="_blank">
                    <img width="30" height="30" src="/images/image-github.svg" style="vertical-align: top; margin-top:8px;"/>
                    <span class="tooltip">GitHub</span>
                </a>
                <a class="button-circle-white ripple stay" href="https://twitter.com/EhsanMhdi" target="_blank">
                    <img width="28" height="28" src="/images/image-twitter.svg" style="vertical-align: top; margin-top:9px;"/>
                    <span class="tooltip">Twitter</span>
                </a>
                <a class="button-circle-white ripple stay" href="https://www.linkedin.com/in/ehsan-mohammadi/" target="_blank">
                    <img width="27" height="27" src="/images/image-linkedin.svg" style="vertical-align: top; margin-top:8px;"/>
                    <span class="tooltip">Linkedin</span>
                </a>
            </div>
        </div>
        <div class="title-description">
            <h1 class="title">About me</h1>
            <h2 class="sub-title">Hi! My name is Ehsan Mohammadi.
                <br />Software engineer, Open-Source programmer and the creator of Shakh Yab project.
                <br />Shakh Yab is a fun, simple, free and open-source Instagram manager tool that find out users who don't follow you back on Instagram. With Shakh Yab you can easily find a list of all users who do not follow your account on Instagram but whom you follow.
                <br />I'm so happy you're here! I'm glad if you could help me to make this project better. Any help and contribution is welcomed and appreciated for further improvements. If you found any bug, click on "Bug reporting" button and describe the bug. But if you know how to code, send fixes and new features.
                <br />You can contact me by Email, Twitter and Linkedin. Also, don't forget to follow my projects on GitHub!
            </h2>
        </div>
    </div>
</asp:Content>
