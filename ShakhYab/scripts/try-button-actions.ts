// This TypeScript file, used for buttonTryNow actions

// When you click on buttonTryNow
function buttonTryNow_Click() {
    const divLogin: HTMLDivElement = document.querySelector("#main_divLogin") as HTMLDivElement;

    let divLoginIsShow: boolean = divLogin != null && divLogin.style.display != "none";

    if (divLoginIsShow) {
        // Scroll to the divLogin
        divLogin.scrollIntoView();
    }
    else {
        // Go to the index page and scroll to the divLogin
        window.location.href = "../index.aspx#login";
    }

    return false;
}