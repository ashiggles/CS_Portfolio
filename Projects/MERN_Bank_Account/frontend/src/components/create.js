import React, { useState } from "react";
import { useNavigate } from "react-router";
 
export default function Create() {
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
  const navigate = useNavigate();

  // These methods will update the state properties.
  function updateForm(value) {
    return setForm((prev) => {
      return { ...prev, ...value };
    });
  }

  // This function will handle the submission.
  async function onSubmit(e) {
    e.preventDefault();

    // When a post request is sent to the create url, we'll add a new record to the database.
    const newPerson = { ...form };

    const response = await fetch("http://localhost:5000/accounts/add", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(newPerson),
    })
    .catch(error => {
      window.alert(error);
      return;
    });

    const message = await response.json();
    console.log(message.message);

    setForm({ firstname: "", lastname: "", email: "", phone: "", password: "", savings: 0, checking: 0, roles: "", });
    navigate("/");
  }

  // This following section will display the form that takes the input from the user.
  return (
    <div>
      <h3 className="m-3">Create New Account</h3>
      <form onSubmit={onSubmit}>
        <div className="form-group m-3">
          <label htmlFor="firstname">First Name</label>
          <input
            type="text"
            className="form-control"
            id="firstname"
            value={form.firstname}
            onChange={(e) => updateForm({ firstname: e.target.value })}
          />
        </div>
        <div className="form-group m-3">
          <label htmlFor="lastname">Last Name</label>
          <input
            type="text"
            className="form-control"
            id="lastname"
            value={form.lastname}
            onChange={(e) => updateForm({ lastname: e.target.value })}
          />
        </div>
        <div className="form-group m-3">
          <label htmlFor="email">Email</label>
          <input
            type="text"
            className="form-control"
            id="email"
            value={form.email}
            onChange={(e) => updateForm({ email: e.target.value })}
          />
        </div>
        <div className="form-group m-3">
          <label htmlFor="phone">Phone</label>
          <input
            type="text"
            className="form-control"
            id="phone"
            value={form.phone}
            onChange={(e) => updateForm({ phone: e.target.value })}
          />
        </div>
        <div className="form-group m-3">
          <label htmlFor="password">Password</label>
          <input
            type="text"
            className="form-control"
            id="password"
            value={form.password}
            onChange={(e) => updateForm({ password: e.target.value })}
          />
        </div>
        <div className="form-group m-3">
          <label htmlFor="roles">Roles</label>
          <input
            type="text"
            className="form-control"
            id="roles"
            value={form.roles}
            onChange={(e) => updateForm({ roles: e.target.value })}
            readOnly
          />
        </div>
        <div className="form-group m-3">
          <input
            type="submit"
            value="Create Account"
            className="btn btn-primary"
          />
        </div>
      </form>
    </div>
  );
}