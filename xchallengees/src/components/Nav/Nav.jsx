import "./Nav.css"
import React from 'react';
import { Link } from 'react-router-dom';


const Nav = () => {
    return (
        <div>
            <Link to={"/"}>HomePage</Link>
            <Link to={"/LoginPage"}>Login Page</Link>
            <Link to={"/Modalidades"}>Modalidades</Link>
            <Link to={"/Resultados"}>Resultados</Link>
        </div>
    );
};

export default Nav;