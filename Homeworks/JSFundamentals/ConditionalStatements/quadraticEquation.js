console.log(solve([5, 2, 8]));
function solve(array) {
    var a = parseFloat(array[0]);
    var b = parseFloat(array[1]);
    var c = parseFloat(array[2]);
    var diskriminant = Math.sqrt(Math.pow(b, 2) - 4*a*c);

    var root1 = (-b + diskriminant) / (2 * a);

    var root2 = (-b - diskriminant) / (2 * a);
    if(diskriminant == 0){
        return "x1=x2=" + parseFloat(Math.round((-b / (2 * a) ) * 100 / 100)).toFixed(2);
    }
    if (isNaN(root1) && isNaN(root2)) {
        return 'no real roots';
    } else {
        if(root1 < root2){
            return "x1=" + parseFloat(Math.round(root1 * 100) / 100).toFixed(2) + "; x2=" + parseFloat(Math.round(root2 * 100) / 100).toFixed(2);
        }else {
            return "x1=" + parseFloat(Math.round(root2 * 100) / 100).toFixed(2) + "; x2=" + parseFloat(Math.round(root1 * 100) / 100).toFixed(2);
        }
    }
}