import "./NoticiaCard.css"
import React from 'react';

import Button from "../Button/Button";


const NoticiaCard = ({noticias}) => {
    return (
        <section className="card">
            <h2>titulo noticia</h2>
            <h2>data noticia</h2>
            <Button buttonText={"Ler mais"}/>
        </section>
    );
};

export default NoticiaCard;