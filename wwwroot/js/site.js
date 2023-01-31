document.getElementById("contact-form").addEventListener("submit", function (event) {
    event.preventDefault();
    var name = document.getElementById("name").value;
    var email = document.getElementById("email").value;
    var message = document.getElementById("message").value;
    if (!name || !email || !message) {
        alert("Please fill out all fields!");
        return;
    }
    if (!email.includes("@")) {
        alert("Please enter a valid email address!");
        return;
    }

    // Send the form data to the server
    //...
    document.getElementById("contact-form").addEventListener("submit", function (event) {
        event.preventDefault();
        var name = document.getElementById("name").value;
        var email = document.getElementById("email").value;
        var message = document.getElementById("message").value;
        // Send a post request to the server
        fetch("/submit-form", {
            method: "POST",
            body: JSON.stringify({ name: name, email: email, message: message }),
            headers: { "Content-Type": "application/json" }
        })
            .then(response => response.json())
            .then(data => {
                if (data.success) {
                    alert("Form submitted successfully!");
                } else {
                    alert("An error occurred: " + data);
                }

            }


