const express = require("express");
const fs = require("node:fs");
const readline = require("readline");
const router = express.Router();

router.get("/", (req, res) => {
    const firstname = req.query.firstname;
    const lastname = req.query.lastname;
    const favfood = req.query.favfood;

    const content = firstname + " " + lastname + " " + favfood + "\n";

    fs.appendFile("MyInfo.txt", content, err => {
        if (err) {
            console.err(err);
        }
    });

    res.send(
        "<button type='button'><a href='/userinput.html'>User Form</a></button><button type='button'><a href='/userfoods.html'>User Foods</a></button><form action='/user_table'><input type='submit' value='User Table'/></form>" + 
        "<h1>Thank you " + firstname + " for your form submission!!</h1>"
    );

});

module.exports = router;