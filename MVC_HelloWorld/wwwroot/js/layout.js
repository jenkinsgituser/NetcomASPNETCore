
        //var name;
        //window.onload = function () {
        //    name = prompt("Enter Name");
        //    var divelement = document.getElementById("username");
        //    divelement.innerHTML ="<h3>Hello " + name + "</h3>";
        //}
        $(document).ready(function () {

            //var age = prompt("Enter Age");
            //if (age >= 18 && age <= 60) {

            //    // $(".container").css("backgroundColor", "green");
            //    $("#container").addClass("success");
            //}
            //else {

            //    $("#container").addClass("error");
            //}

            //add click event handler
            $("#btnSubmit").click(function () {

                //read value from textbox
                var name = $("#tbname").val();

                //add message to username div
                $("#username").html("<h2>Your name is " + name + "</h2>");
            })

            $("#container").html("<h3>Age is " + age + "</h3>");

        })
