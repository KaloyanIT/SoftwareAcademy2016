var numbers = [5, 2, 8];

console.log(solveQuadraticEquation(numbers[0], numbers[1], numbers[2]));

function solveQuadraticEquation(a, b, c) {
    var diskriminant = Math.sqrt(Math.pow(b, 2) - 4*a*c);

    var root1 = (-b + diskriminant) / (2 * a);

    var root2 = (-b - diskriminant) / (2 * a);
    if (isNaN(root1) && isNaN(root2)) {
        return 'No real roots';
    }
    if (isNaN(root1)) {
       return root2 + ', Not real root';
    }
    if (isNaN(root2)) {
        return root1 + ', Not real root';
    } else {
        return root1 + ' ' + root2;
    }


}