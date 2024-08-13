import React, { useState, useEffect } from "react";
import { useParams, useNavigate } from "react-router";
 
export default function Edit() {
 const [form, setForm] = useState({
    firstname: "",
    lastname: "",
    email: "",
    phone: "",
    password: "",
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
     roles: "",
   };
   // This will send a post request to update the data in the database.
   await fetch(`http://localhost:5000/update/${params.id}`, {
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
     <h3>Update Account</h3>
     <form onSubmit={onSubmit}>
       <div className="form-group m-3">
         <label htmlFor="firstname">First Name: </label>
         <input
           type="text"
           className="form-control"
           id="firstname"
           value={form.firstname}
           onChange={(e) => updateForm({ firstname: e.target.value })}
         />
       </div>
       <div className="form-group m-3">
         <label htmlFor="lastname">Last Name: </label>
         <input
           type="text"
           className="form-control"
           id="lastname"
           value={form.lastname}
           onChange={(e) => updateForm({ lastname: e.target.value })}
         />
       </div>
       <div className="form-group m-3">
         <label htmlFor="email">Email: </label>
         <input
           type="text"
           className="form-control"
           id="email"
           value={form.email}
           onChange={(e) => updateForm({ email: e.target.value })}
         />
       </div>
       <div className="form-group m-3">
         <label htmlFor="phone">Phone: </label>
         <input
           type="text"
           className="form-control"
           id="lastname"
           value={form.phone}
           onChange={(e) => updateForm({ phone: e.target.value })}
         />
       </div>
       <div className="form-group m-3">
         <label htmlFor="password">Password: </label>
         <input
           type="text"
           className="form-control"
           id="password"
           value={form.password}
           onChange={(e) => updateForm({ password: e.target.value })}
         />
       </div>
       <div className="form-group m-3">
         <label htmlFor="roles">Roles: </label>
         <input
           type="text"
           className="form-control"
           id="roles"
           value={form.roles}
           onChange={(e) => updateForm({ roles: e.target.value })}
           readOnly
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