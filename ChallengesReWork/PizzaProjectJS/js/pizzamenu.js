function getSizePrice() {
var sizeprice = 0;
if(document.getElementById('personal').checked)
	sizeprice = 6.00;
else if(document.getElementById('medium').checked)
	sizeprice = 10.00;
else if(document.getElementById('large').checked)
	sizeprice = 14.00;
else if(document.getElementById('extralarge').checked)
	sizeprice = 16.00;
return sizeprice;	
};

function getSizeNameAndPrice() {
var sizenameandprice = "";
if(document.getElementById('personal').checked)
	sizenameandprice = "Personal - $6.00";
else if(document.getElementById('medium').checked)
	sizenameandprice = "Medium - $10.00";
else if(document.getElementById('large').checked)
	sizenameandprice = "Large - $14.00";
else if(document.getElementById('extralarge').checked)
	sizenameandprice = "Extra Large - $16.00";
return sizenameandprice;	
};

function getCheesePrice() {
	var cheeseprice = 0;
if(document.getElementById('extracheese').checked)
	cheeseprice = 3;
else cheeseprice = 0;
return cheeseprice;
};

function getCheeseNameAndPrice() {
var cheesenameandprice = "";
if(document.getElementById('extracheese').checked)
	cheesenameandprice = "Extra Cheese - $3.00";
else if(document.getElementById('nocheese').checked)
	cheesenameandprice = "No Cheese - $0.00";
else if(document.getElementById('regular').checked)
	cheesenameandprice = "Regular Cheese = $0.00";
return cheesenameandprice;
};

function getSauceNameAndPrice() {
var saucenameandprice = "";
if(document.getElementById('saucemarinara').checked)
	saucenameandprice = "Marinara Sauce - $0.00";
if(document.getElementById('saucewhite').checked)
	saucenameandprice = "White Sauce - $0.00";
if(document.getElementById('saucebarbeque').checked)
	saucenameandprice = "Barbeque Sauce - $0.00";
if(document.getElementById('saucenone').checked)
	saucenameandprice = "No Sauce - $0.00"
return saucenameandprice;
};

function getCrustPrice() {
var crustprice = 0;
if(document.getElementById('crustcheesestuffed').checked)
	crustprice = 3;
else crustprice = 0;
return crustprice;
}

function getCrustNameAndPrice() {
var crustnameandprice = "";
if(document.getElementById('crustplain').checked)
	crustnameandprice = "Plain Crust - $0.00";
if(document.getElementById('crustgarlicbutter').checked)
	crustnameandprice = "Garlic Butter Crust - $0.00";
if(document.getElementById('crustcheesestuffed').checked)
	crustnameandprice = "Cheese Stuffed Crust - $3.00";
if(document.getElementById('crustspicy').checked)
	crustnameandprice = "Spicy Crust - $0.00";
if(document.getElementById('crusthousespecial').checked)
	crustnameandprice = "House Special Crust - $0.00";
return crustnameandprice;
};

function getTotalMeatsPrice() {
var inputs = document.getElementsByTagName("input");
var totalmeatcount = 0;
for (var i = 0; i < inputs.length; i++) {
	if (inputs[i].type == "checkbox" && inputs[i].name == "meats" && inputs[i].checked == true) {
		totalmeatcount++;
		}
	}
	if (totalmeatcount == 1) totalmeatcount = 0;
	else if (totalmeatcount >= 2) totalmeatcount = totalmeatcount - 1;
return totalmeatcount;
}

function getMeatsNameAndPrice() {
function getCount(count) {
if (count < 2) meatcost = 0;
else meatcost = 1;
return meatcost;
}
var meatsnameandprice = "";
var count = 0;
if(document.getElementById('pepperoni').checked)
	count++, meatsnameandprice += "Pepperoni - $" + getCount(count) + ".00<br>";
if(document.getElementById('sausage').checked)
	count++, meatsnameandprice += "Sausage - $" + getCount(count) + ".00<br>";
if(document.getElementById('canadianbacon').checked)
	count++, meatsnameandprice += "Canadian Bacon - $" + getCount(count) + ".00<br>";
if(document.getElementById('groundbeef').checked)
	count++, meatsnameandprice += "Ground Beef - $" + getCount(count) + ".00<br>";
if(document.getElementById('anchovy').checked)
	count++, meatsnameandprice += "Anchovy - $" + getCount(count) + ".00<br>";
if(document.getElementById('chicken').checked)
	count++, meatsnameandprice += "Chicken - $" + getCount(count) + ".00<br>";
return meatsnameandprice;
};

function getTotalVeggiesPrice() {
var inputs = document.getElementsByTagName("input");
var totalveggiecount = 0;

for (var i = 0; i < inputs.length; i++) {
	if(inputs[i].type == "checkbox" && inputs[i].name == "veggies" && inputs[i].checked == true) {
		totalveggiecount++;
		}
	}
	if (totalveggiecount == 1) totalveggiecount = 0;
	else if (totalveggiecount >= 2) totalveggiecount = totalveggiecount - 1;
return totalveggiecount;
};

function getVeggiesNameAndPrice() {
function getCount(count) {
if (count < 2) veggiecost = 0;
else veggiecost = 1;
return veggiecost;
}
var veggiesnameandprice = "";
var count = 0;
if(document.getElementById('tomatoes').checked)
	count++, veggiesnameandprice += "Tomatoes - $" + getCount(count) + ".00<br>";
if(document.getElementById('onions').checked)
	count++, veggiesnameandprice += "Onions - $" + getCount(count) + ".00<br>";
if(document.getElementById('olives').checked)
	count++, veggiesnameandprice += "Olives - $" + getCount(count) + ".00<br>";
if(document.getElementById('greenpeppers').checked)
	count++, veggiesnameandprice += "Green Peppers - $" + getCount(count) + ".00<br>";
if(document.getElementById('mushrooms').checked)
	count++, veggiesnameandprice += "Mushrooms - $" + getCount(count) + ".00<br>";
if(document.getElementById('pineapple').checked)
	count++, veggiesnameandprice += "Pineapple - $" + getCount(count) + ".00<br>";
if(document.getElementById('spinach').checked)
	count++, veggiesnameandprice += "Spinach - $" + getCount(count) + ".00<br>";
if(document.getElementById('jalepeno').checked)
	count++, veggiesnameandprice += "Jalpeno - $" + getCount(count) + ".00<br>";
return veggiesnameandprice;
};

function displayTotal() {
$('#total').empty();
$('#total').append( " - Items ordered - " + "<br>" + 
getSizeNameAndPrice() + "<br>" + 
getCheeseNameAndPrice() + "<br>" + 
getSauceNameAndPrice() + "<br>" +
getCrustNameAndPrice() + "<br>" +
getMeatsNameAndPrice() +
getVeggiesNameAndPrice() + 
 "TOTAL PIZZA PRICE: $" + (getSizePrice() + getCheesePrice() + 
 	getCrustPrice() + getTotalMeatsPrice() + 
 	getTotalVeggiesPrice()) + ".00");
};