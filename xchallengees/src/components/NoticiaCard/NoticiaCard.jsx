import "./NoticiaCard.css"
import React from 'react';

import Button from "../Button/Button";
import { Tooltip } from "react-tooltip";




const NoticiaCard = ({title, data}) => {



    return (
        <section className="card">
            <h2
                data-tooltip-id="my-tooltip"
                data-tooltip-content={title}
                data-tooltip-place="top"
            >
                <Tooltip id="my-tooltip" className='tooltip' />
                {title.substr(0,15)}...
            </h2>
            <h2>{new Date(data).toLocaleDateString() }</h2>
            <Button buttonText={"Ler mais"}/>
        </section>
    );
};

export default NoticiaCard;