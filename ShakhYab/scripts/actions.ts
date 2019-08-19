// This TypeScript file, used for client side actions

// When you click on buttonStart
function buttonStart_Click() {
    const textBoxUsername: HTMLInputElement = document.querySelector("#main_textBoxUsername") as HTMLInputElement;
    const textBoxPassword: HTMLInputElement = document.querySelector("#main_textBoxPassword") as HTMLInputElement;
    const errorMessage: HTMLParagraphElement = document.querySelector("#main_errorMessage") as HTMLParagraphElement;
    const buttonStart: HTMLButtonElement = document.querySelector("#main_buttonStart") as HTMLButtonElement;
    const divLoading: HTMLDivElement = document.querySelector("#main_divLoading") as HTMLDivElement;

    let username: string = textBoxUsername.value;
    let password: string = textBoxPassword.value;

    if (username == "" || password == "") {
        if (username == "") {
            textBoxUsername.setAttribute("style", "border-color: red");
            textBoxPassword.setAttribute("style", "border-color: red");

            // Clear password textbox and show error message
            textBoxPassword.value = "";
            errorMessage.textContent = "Both username and password must be filled out";
        }
        else {
            textBoxUsername.setAttribute("style", "border-color: #ccc");

            if (password == "") {
                textBoxPassword.setAttribute("style", "border-color: red");

                // Show error message
                errorMessage.textContent = "Please enter your password";
            }
        }

        return false;
    }
    else {
        // Reset Username and Password border-color
        textBoxUsername.setAttribute("style", "border-color: #ccc");
        textBoxPassword.setAttribute("style", "border-color: #ccc");

        // Clear error message
        errorMessage.textContent = "";

        // Disable textboxes
        textBoxUsername.disabled = true;
        textBoxPassword.disabled = true;

        // Hide Start button and show Loading div
        buttonStart.setAttribute("style", "display: none");
        divLoading.setAttribute("style", "display: block");
    }
}