var dotNetObject_var;

function renderButton(dotNetObject) {
    dotNetObject_var = dotNetObject;
    gapi.signin2.render('my-signin2', {
        'scope': 'profile email',
        'width': 240,
        'height': 50,
        'longtitle': true,
        'theme': 'dark',
        'onsuccess': onSuccess,
        'onfailure': onFailure
    });
}

function onSuccess(googleUser) {
    console.log('Logged in as: ' + googleUser.getBasicProfile().getName());
    console.log('Logged in as: ' + googleUser.getBasicProfile().getEmail());
    var profile = googleUser.getBasicProfile();
    var nameGmail = profile.getName();
    var Gmail = profile.getEmail();
    dotNetObject_var.invokeMethodAsync('GettingGmailInfo', Gmail);

}
function onFailure(error) {
    console.log(error);
}
