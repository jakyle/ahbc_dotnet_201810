var temp = 2;
var tempstring = "2";

// hello
if (temp == tempstring) {
    
} 

var _count = 0;
var element = document.getElementById("output");
function increment() {
    _count++;
    element.innerText = _count;
}

function decrement() {
    _count--;
    element.innerText = _count;
}