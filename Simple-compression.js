var compress = function(uncompressed) {
    var compressed = "";
    var curr = uncompressed[0];
    var count = 1;
    for(var i = 1; i < uncompressed.length; i++) {
        var next = uncompressed[i];
        if(curr == next) count++;
        else {
             compressed  += (count == 1 ? curr : curr + count);
             curr = next;
             count = 1
             }
    }
    compressed  += (count == 1 ? curr : curr + count);
    return compressed;
}

var decompress = function(compressed) {
    var decompressed = "";
    var curr = compressed[0];
    var count = "";
    for(var i = 1; i < compressed.length; i++) {
        if(Number.isNaN(+compressed[i])) {
            decompressed  += curr.repeat(+(count.length ? count : 1));
            curr = compressed[i];
            count = "";
        }
        else count += compressed[i];
    }
    decompressed += curr.repeat(+(count.length ? count : 1));
    return decompressed ;
}

/*
  aaabbcdda -->  a3b2cd2a  --> aaabbcdda

  aaaaaaaaaa       (10 x a)  --> a\10
  a9               --> a9
  a99   -->  a\99|

  aa99  --> a\2|9\2   
*/

// Test Cases...
var compressed = compress('aaabbcdda');
if (compressed != 'a3b2cd2a') {
    Console.Log('compression failed')
}
else {
    console.Log('Compression succeeded');
}

// test decompress
var decompressed = decompress('a3b2cd2a');
if (decompressed != 'aaabbcdda') {
    Console.Log('compression failed')
} else {

    Console.Log('compression succeeded')
}

*/
