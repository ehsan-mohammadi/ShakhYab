<%@ Page Title="" Language="C#" MasterPageFile="~/master/WebMaster.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ShakhYab.Index" %>
<asp:Content ID="mainContent" ContentPlaceHolderID="main" runat="server">
    <div class="title-side-by-side">
        <div class="title-logo">
            <div class="title-logo-image"></div>
            <div style="margin-top: 20px;">
                <a class="button-circle-black ripple">
                    <img width="30" height="30" src="/images/image-github.svg" style="vertical-align: top; margin-top:8px;"/>
                    <span class="tooltip">Shakh-Yab on GitHub</span>
                </a>
                <a class="button-circle-black ripple">
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
                While tracking non-followers, Shakh Yab also lets you unfollow these users.
                <br />So, if you are asking yourself "Who unfollowed me on Instagram?", just start using Shakh Yab to find out who unfollowed you.
            </h2>
        </div>
    </div>
</asp:Content>
