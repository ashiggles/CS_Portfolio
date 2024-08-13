import React from "react";
 
// We import bootstrap to make our application look better.
import "bootstrap/dist/css/bootstrap.css";
 
// We import NavLink to utilize the react router.
import { NavLink } from "react-router-dom";
 
// Here, we display our Navbar
export default function Navbar() {
 return (
    <div>

      <nav className="navbar navbar-light bg-light">
        <h1 className="m-2">Bank Account</h1>
        <form className="form-inline">
          <button className="btn btn-outline-success m-2" type="button">
            <NavLink className="nav-link" to="/login">
              Login
            </NavLink>
          </button>
          <button className="btn btn-outline-success m-2" type="button">
            <NavLink className="nav-link" to="/create">
              Register
            </NavLink>
          </button>
          <button className="btn btn-outline-success m-2" type="button">
            <NavLink className="nav-link" to="/">
              Account List
            </NavLink>
          </button>
        </form>
      </nav>

    </div>
 );
}