import "./Nav.css"
import React from 'react';
import { Link } from 'react-router-dom';


const Nav = ({isLogged}) => {
    return (
        
        <nav>
            <Link to={"/Bulhufas"}>Not found</Link>
            {isLogged?
            <>
            <Link className="navItem" to={"/"}>Home</Link>
            <Link className="navItem" to={"/Modalidades"}>Modalidades</Link>
            <Link className="navItem" to={"/Resultados"}>Resultados</Link>
            </>:<>
            <Link className="navItem" to={"/"}>Skills</Link>
            </>}
        </nav>
    );
};

export default Nav;