<%@ Page Async="true" Title="" Language="C#" MasterPageFile="~/master/WebMaster.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ShakhYab.Index" %>
<asp:Content ID="mainContent" ContentPlaceHolderID="main" runat="server">
    <script type="text/javascript" src="scripts/actions.js"></script>
    <div class="title-side-by-side">
        <div class="title-logo">
            <div class="title-logo-image"></div>
            <div style="margin-top: 20px;">
                <a class="button-circle-black ripple" href="https://github.com/ehsan-mohammadi/ShakhYab" target="_blank">
                    <img width="30" height="30" src="/images/image-github.svg" style="vertical-align: top; margin-top:8px;"/>
                    <span class="tooltip">Shakh Yab on GitHub</span>
                </a>
                <a class="button-circle-black ripple" href="https://github.com/ehsan-mohammadi/ShakhYab/issues" target="_blank">
                    <img width="30" height="30" src="/images/image-bug.svg" style="vertical-align: top; margin-top:8px;"/>
                    <span class="tooltip">Bug reporting</span>
                </a>
                <a class="button-circle-black ripple">
                    <img width="28" height="28" src="/images/image-info.svg" style="vertical-align: top; margin-top:9px;"/>
                    <span class="tooltip">About</span>
                </a>
            </div>
        </div>
        <div class="title-description">
            <h1 class="title">What is Shakh Yab?</h1>
            <h2 class="sub-title">Sometimes, you may follow someone on Instagram, but he doesn't follow you back. Or might he follow you back and after that, he unfollow you.
                <br />In Iran, we call these people "شاخ" (Say: Shakh)!
                <br />Absolutely, it's hard and boring to looking for these people by comparing follower and following list.
                <br /><span style="font-family:'SegoeUI-bold'; font-weight:bold">Shakh Yab</span> is a simple, free and open-source Instagram manager tool that find out users who don't follow you back on Instagram. With Shakh Yab you can easily find a list of all users who do not follow your account on Instagram but whom you follow.
                <br />So, if you are asking yourself "Who unfollowed me on Instagram?", just start using Shakh Yab to find out who unfollowed you.
            </h2>
        </div>
        <asp:ScriptManager ID="scriptManager" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="updatePanelIndex" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                 <div id="divLogin" class="container" style="margin-top: 50px;" runat="server">
                    <h1 class="title" style="text-align: center; margin-bottom: 20px;">Try Shakh Yab!</h1>
                    <p class="normal-text" style="margin-bottom: 10px;">Instagram Username:</p>
                    <asp:TextBox ID="textBoxUsername" CssClass="text-box" runat="server"></asp:TextBox>
                    <p class="normal-text" style="margin-bottom: 10px;">Password:</p>
                    <asp:TextBox ID="textBoxPassword" CssClass="text-box" TextMode="Password" runat="server"></asp:TextBox>
                    <div style="display: flex; margin: 0px 40px;">
                        <img width="25" height="25" src="/images/image-hint.svg"/>
                        <p class="normal-text" style="width:auto; padding: 2px 0px 0px 5px; color: #7a7a7a;">We never save your information!</p>
                        <p style="flex: 1;"></p>
                    </div>
                    <div style="display: flex; margin: 0px 40px;">
                        <img width="25" height="25" src="/images/image-hint.svg"/>
                        <p class="normal-text" style="width:auto; padding: 2px 0px 0px 5px; color: #7a7a7a;">Don't trust me? <a class="hyper-link">Click here</a></p>
                        <p style="flex: 1;"></p>
                    </div>
                    <p id="errorMessage" class="normal-text" style="margin: 15px 0px; text-align:center; color:red;" runat="server"></p>
                    <asp:Button ID="buttonStart" CssClass="button-start" runat="server" Text="START!" OnClientClick="return buttonStart_Click()" OnClick="buttonStart_Click"/>
                    <div id="divLoading" style="margin: 0px 40px; display: none;" runat="server">
                        <div class="lds-ripple"><div></div><div></div></div>
                    </div>
                    <p class="normal-text" style="margin-bottom: 30px;"></p>
                </div>
                <div id="divUser" class="container" style="width: 800px; margin-top: 50px; display: block;" runat="server">
                    <div id="divProfileImage" class="login-profile-image" runat="server"></div>
                    <p id="textWelcome" class="normal-title" style="text-align: center; margin-bottom: 0px; font-family:'SegoeUI-Light'; font-weight:lighter;" runat="server">Welcome User!</p>
                    <p id="textUsername" class="normal-title" style="text-align: center; font-size: 17pt; color: #7a7a7a; margin-bottom: 20px;" runat="server">@username</p>
                    <div class="splitter" style="margin: 20px auto 15px auto"></div>
                    <p class="normal-text" style="text-align: center; font-size: 14pt; margin-bottom: 30px;">Here is the list of people who not follow you back! (SHAKHS)</p>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</asp:Content>
