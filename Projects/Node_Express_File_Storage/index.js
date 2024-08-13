const express = require("express");
const path = require('path');
const myFileEntry = require("./routes/fileentry");
const myDataTable = require("./routes/datastring");
const myFavFoods = require("./routes/favfoods");

// Load express
const app = express();
const port = 3000;

// Routes in /routes/
// localhost:3000/user_routes
app.use("/user_entry", myFileEntry);
app.use("/user_table", myDataTable);
app.use("/user_foods", myFavFoods);

// Normally not done
app.use(express.static("public"));

// Use Bootstrap
app.use('/css', express.static(__dirname + '/node_modules/bootstrap/dist/css'));

// Routes in this file 
app.get("/", (req, res) => {
    res.sendFile(path.join(__dirname, 'public/userinput.html'));
});

// Set up the server
app.listen(port, () => {
    console.log("Server started on port: " + port);
});