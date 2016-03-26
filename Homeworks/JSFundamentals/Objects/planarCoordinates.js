function isNumber(n) {
    return !isNaN(parseFloat(n)) && isFinite(n);
}

function Point(x, y) {
    if (!isNumber(x) || !isNumber(y)) {
        throw  new Error('X and Y should be numbers.');
    }

    if (!(this instanceof Point)) {
        return new Point(x, y);
    }

    this.x = x;
    this.y = y;
}

Point.prototype.toString = function() {
    return 'P(' + this.x + ', ' + this.y + ')';
};

function Line(point1, point2) {
    if (!(point1 instanceof  Point && point2 instanceof Point)) {
        return Error('This is not line!');
    }

    if (!(this instanceof Line)) {
        return new Line(point1, point2)
    }

    this.point1 = point1;
    this.point2 = point2;
}

Line.prototype.toString = function() {
    return 'L(' + this.point1.toString() + ', ' + this.point2.toString() + ')';
};

Line.prototype.getDistance = function() {
    var x = (this.point1.x - this.point2.x) * (this.point1.x - this.point2.x);
    var y = (this.point1.y - this.point2.y) * (this.point1.y - this.point2.y);

    return Math.sqrt(x + y);
};

function Triangle(a, b, c) {
    if (!(a instanceof Line) || !(b instanceof Line) || !(c instanceof Line)) {
        throw  new Error('A, B and C should be instances of Line');
    }

    if (!(this instanceof Triangle)) {
        return new Triangle(a, b, c);
    }

    if (!canFormTriangle(a, b, c)) {
        throw  new Error('invalid triangle');
    }

    this.a = a;
    this.b = b;
    this.c = c;
}

function canFormTriangle(a, b, c) {
    return a.getDistance() < b.getDistance() + c.getDistance() &&
        b.getDistance() < c.getDistance() + a.getDistance() &&
        c.getDistance() < a.getDistance() + b.getDistance();
}



var firstPoint = Point(10, 19);
var secondPoint = Point(10, 16);
console.log(firstPoint.toString());
var someLine = Line(firstPoint, secondPoint);
console.log(someLine.toString());
console.log(someLine.getDistance());