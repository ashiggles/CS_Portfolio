import React, { useState, useEffect } from "react";
import { useParams, useNavigate } from "react-router";
 
export default function View() {
 const [form, setForm] = useState({
    firstname: "",
    lastname: "",
    email: "",
    phone: "",
    password: "",
    savings: "",
    checking: "",
    roles: "",
 });
 const params = useParams();
 const navigate = useNavigate();
 
 useEffect(() => {
   async function fetchData() {
     const id = params.id.toString();
     const response = await fetch(`http://localhost:5000/accounts/${params.id.toString()}`);
 
     if (!response.ok) {
       const message = `An error has occurred: ${response.statusText}`;
       window.alert(message);
       return;
     }
 
     const account = await response.json();
     if (!account) {
       window.alert(`Account with id ${id} not found`);
       navigate("/");
       return;
     }
 
     setForm(account);
     console.log(account);
   }
 
   fetchData();
 
   return;
 }, [params.id, navigate]);
 
 // These methods will update the state properties.
 function updateForm(value) {
   return setForm((prev) => {
     return { ...prev, ...value };
   });
 }
 
 async function onSubmit(e) {
   e.preventDefault();
   const editedPerson = {
        firstname: form.firstname,
        lastname: form.lastname,
        email: form.email,
        phone: form.phone,
        password: form.password,
        savings: form.savings,
        checking: form.checking,
        roles: "",
   };
   // This will send a post request to update the data in the database.
   await fetch(`http://localhost:5000/update-balance/${params.id}`, {
     method: "PUT",
     body: JSON.stringify(editedPerson),
     headers: {
       'Content-Type': 'application/json'
     },
   });
 
   navigate("/");
 }
 
 // This following section will display the form that takes input from the user to update the data.
 return (
    <div>
        <h3 className="m-3">{form.firstname} {form.lastname}'s Account</h3>
        <h4 className="m-3">Email: {form.email}</h4>
        <h4 className="m-3">Phone: {form.phone}</h4>
        <h4 className="m-3">Savings Balance:</h4>
        <h4 className="m-3">$ {form.savings}</h4>
        <h4 className="m-3">Checking Balance:</h4>
        <h4 className="m-3">$ {form.checking}</h4>
        <h4 className="m-3">Roles: {form.roles}</h4>
        <h5 className="m-5"></h5>
        <form onSubmit={onSubmit}>
            <div className="form-group m-3">
                <h3>Withdraw:</h3>
                <label htmlFor="savings">Savings: </label>
                <input
                    type="text"
                    className="form-control"
                    id="savings"
                    value={form.savings}
                    onChange={(e) => updateForm({ savings: e.target.value })}
                />
                <label htmlFor="savings">Checking: </label>
                <input
                    type="text"
                    className="form-control"
                    id="checking"
                    value={form.checking}
                    onChange={(e) => updateForm({ checking: e.target.value })}
                />
            </div>
            <div className="form-group m-3">
                <h3>Deposit:</h3>
                <label htmlFor="savings">Savings: </label>
                <input
                    type="text"
                    className="form-control"
                    id="savings"
                    value={form.savings}
                    onChange={(e) => updateForm({ savings: e.target.value })}
                />
                <label htmlFor="savings">Checking: </label>
                <input
                    type="text"
                    className="form-control"
                    id="checking"
                    value={form.checking}
                    onChange={(e) => updateForm({ checking: e.target.value })}
                />
            </div>
            <br />
            <div className="form-group m-3">
            <input
                type="submit"
                value="Update Account"
                className="btn btn-primary"
            />
            </div>
        </form>
    </div>
 );
}