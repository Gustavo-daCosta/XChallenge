import "./Footer.css"
import React from 'react';

import tube from "../../assets/Images/icons/youtube 2.png"
import face from "../../assets/Images/icons/youtube 1.png"
import tter from "../../assets/Images/icons/twitter.png"




const Footer = () => {
    return (
        <div className="background">

            <footer>

                    <div className="footer-part">
                        <h2>WSTowers</h2>
                        <p>Skills</p>
                        <p>Parceiros</p>
                        <p>Visitantes</p>
                    </div>

                    <div className="footer-part">
                        <h2>Redes Sociais</h2>
                        <div className="social">
                            <img src={face} alt="icone do facebook" />
                            <p>Facebook</p>
                        </div>
                        <div className="social">
                            <img src={tube} alt="icone do youtube" />
                            <p>Youtube</p>
                        </div>
                        <div className="social">
                            <img src={tter} alt="icone do twitter" />
                            <p>Twitter</p>
                        </div>
                    </div>
                    
            </footer>

            <hr />
            <p>Xchallenge - 2023</p>
        </div>
    );
};

export default Footer;