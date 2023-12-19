import "./Button.css"
import React from 'react';

const Button = ( {
    buttonText, 
    additionalClass = null, 
    manipulatorFunction = null } ) => {
    return (
        <>
        <button 
        className={additionalClass} 
        onClick={manipulatorFunction}
        >{buttonText}</button>
        </>
    );
};

export default Button;