function solve(params) {
    var s = params[0].split(' ').map(Number),
        result;
    var hillsFound;
    var rocks = 0;
    result = 0;

    function findHills(s) {
        var hills = [];
        hills.push(0);
        for (var i = 1; i < s.length; i = i + 1) {
            if (s[i] > s[i - 1] && s[i] > s[i + 1]) {
                hills.push(i);
            };
        }
        hills.push(s.length - 1);
        return hills;
    };

    hillsFound = findHills(s);

    for (var i = 1; i < hillsFound.length; i = i+1) {
        rocks = hillsFound[i] - hillsFound[i - 1];
        if (rocks > result) {
            result = rocks;   
        };
    };
    
    console.log(result);
}