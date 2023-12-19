import "./Header.css"
import React, { useState } from 'react';
import Nav from '../Nav/Nav';
import logo from "../../assets/Images/Icone.png"
import { Link } from "react-router-dom";
import CheckBox from "../CheckBox/CheckBox";
import Button from "../Button/Button";
import Line from "../Line/Line";

const Header = () => {

    const [isDark, setIsDark] = useState(true);

    const [isLogged, setIsLogged] = useState(true);


    function changeTheme() {
        isDark ? setIsDark(false) : setIsDark(true);
        console.log(isDark);
    }

    return (
        <>
            <header>
                <Link to={"/"}>
                    <img className="logo" src={logo} alt="Logo do site, clique para voltar para a página inicial" />
                </Link>

                {isLogged ?

                    <>
                        <Nav isLogged={isLogged} />

                        <CheckBox
                            isDark={isDark}
                            setIsDark={changeTheme}
                        />

                        <Button buttonText={"Sair"} />

                    </> : <>
                        <Nav isLogged={isLogged} />

                        <CheckBox
                            isDark={isDark}
                            setIsDark={changeTheme}
                        />

                        <Button buttonText={"Login"} />

                    </>}

            </header>
            <Line/>
        </>
    );
};

export default Header;