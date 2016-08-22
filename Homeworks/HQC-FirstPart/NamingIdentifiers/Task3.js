function buttonEvent('onclick', arguments) {
    var myWindow = window,
        browser = myWindow.navigator.appCodeName,
        currentBrowser = browser == "Mozilla";
    if (currentBrowser) {
        alert("Yes");
    } else {
        alert("No");
    }
}