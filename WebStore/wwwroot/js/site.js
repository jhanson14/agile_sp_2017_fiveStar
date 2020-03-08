// nav shopping cart counter
var counter = 0;

function cartCounter() {
    counter += 1;
    document.getElementById("shoppingCartNav").innerHTML = "(" + counter + ")";
}

// shopping cart button
function checkoutBtn() {

    alert("Thank you for your purchase! \n Expect your pekedge in 1 to 2 weeks.");

}