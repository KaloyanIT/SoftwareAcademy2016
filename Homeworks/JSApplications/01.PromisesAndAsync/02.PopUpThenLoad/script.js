(function(){
    var locationElement = document.getElementById("popup");

    function popUp() {
        return new Promise((resolve, reject) => {
            navigator.geolocation.getCurrentPosition(
                (position) => { resolve(position) },
                (error) => { reject(error) });
        });
    }
    alert("<strong>Pesho</strong>");
}());