var temp = 2;
var tempstring = "2";

var _count = 0;
var element = document.getElementById("output");
function increment() {
    var incrementby = prompt("How many would you like to increment by?");
    _count += incrementby;
    element.innerText = _count;
    alert("You have incremented!");
}

function decrement() {
    _count--;
    element.innerText = _count;
}

///// Creating elements with the DOM /////////

var sample = document.getElementById("sample");
//sample.innerText = "<div>hello</div>";
//sample.innerHTML = "<div>hello</div>";

var something = document.createElement("span");
something.innerText = "Zack's method!!!";
sample.appendChild(something);

//var globalVar = "Heyyyy youuuuu guuuuuuuyss";
$(document).ready(function () {
    
    // All divs - $("div")
    $("div:even").css("color", "red").click(function () {
        alert("clicked!");
    });

    // Sample by id $("#sample")

});

(function(){
    // self invoking anonomous function
})();