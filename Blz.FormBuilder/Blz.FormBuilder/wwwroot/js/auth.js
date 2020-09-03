function CloseChangePasswordModal() {
    var close_icon = document.querySelector("#changePasswordModal > div > div > div.modal-header > button > span");
    $(close_icon).click();
    console.log("modal close");
}