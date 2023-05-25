// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


//$('#createCustomerBtn').on('click', function () {
//    $.ajax({
//        url: '/Customers/Create',
//        method: 'post',
//        data: {
//            FirstName: $('#FirstName').val(),
//            FirstName: $('#LastName').val(),
//            FirstName: $('#MobileNumber').val(),
//            FirstName: $('#City').val(),
//            FirstName: $('#UserID').val(),
//            FirstName: $('#IsActive').val(),
//        }
//    }).done(function (result) {
//        if (result) {
//            // code valid
//            $('createCustomer').submit();
//        } else {
//            // show error
//        }
//    }).fail(function () {
//        // ajax request failed
//    });
//});
function validateForm() {
    let x = document.forms["createCustomer"]["FirstName"].value;
    let a = document.forms["createCustomer"]["LastName"].value;
    let b = document.forms["createCustomer"]["City"].value;
    let c = document.forms["createCustomer"]["UserID"].value;
    let y = document.getElementById("MobileNumber").value;
    if (x == "") {
        alert("First Name must be filled out");
        return false;
    }
    if (a == "") {
        alert("Last Name must be filled out");
        return false;
    }
    if (b == "") {
        alert("City must be filled out");
        return false;
    }
    if (c == "") {
        alert("User ID must be filled out");
        return false;
    }
    // Get the value of the input field with id="numb"
    // If x is Not a Number or less than one or greater than 10
    if (isNaN(y)) {
        alert("Mobile Number must be number");
        return false;
    }
    if (y.length < 10) {
        alert("Mobile Number must be 10-digit");
        return false;
    }
    if (y == "") {
        alert("Mobile Number must be filled out");
        return false;
    }
}

function editValidateForm() {
    let x = document.forms["editCustomer"]["FirstName"].value;
    let a = document.forms["editCustomer"]["LastName"].value;
    let b = document.forms["editCustomer"]["City"].value;
    let c = document.forms["editCustomer"]["UserID"].value;
    let m = document.getElementById("editMobileNumber").value;

    if (m == "") {
        alert("Mobile Number must be filled out");
        return false;
    }
    if (isNaN(m)) {
        alert("Mobile Number must be number");
        return false;
    }
    if (m.length < 10) {
        alert("Mobile Number must be 10-digit");
        return false;
    }
    if (x == "") {
        alert("First Name must be filled out");
        return false;
    }
    if (a == "") {
        alert("Last Name must be filled out");
        return false;
    }
    if (b == "") {
        alert("City must be filled out");
        return false;
    }
    if (c == "") {
        alert("User ID must be filled out");
        return false;
    }
}

function skuValidateForm() {
    let x = document.forms["createSku"]["Name"].value;
    let a = document.forms["createSku"]["Code"].value;
    let b = document.forms["createSku"]["UnitPrice"].value;
    if (isNaN(b)) {
        alert("UnitPrice must be number");
        return false;
    }
    if (x == "") {
        alert("Name must be filled out");
        return false;
    }
    if (a == "") {
        alert("Code must be filled out");
        return false;
    }
    if (b == "") {
        alert("Unit Price must be filled out");
        return false;
    }
}

function editSkuValidateForm() {
    let x = document.forms["editSku"]["Name"].value;
    let a = document.forms["editSku"]["Code"].value;
    let b = document.forms["editSku"]["UnitPrice"].value;
    if (isNaN(b)) {
        alert("UnitPrice must be number");
        return false;
    }
    if (x == "") {
        alert("Name must be filled out");
        return false;
    }
    if (a == "") {
        alert("Code must be filled out");
        return false;
    }
    if (b == "") {
        alert("Unit Price must be filled out");
        return false;
    }
}