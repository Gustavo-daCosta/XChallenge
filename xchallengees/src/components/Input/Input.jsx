import "./Input.css"
import React from 'react';


const Input = ({
    idInput,
    inputType,
    placeholder,
    value,
    manipulatorFunction,
}
) => {
    return (
        <input
            type={inputType}
            placeholder={placeholder}
            value={value}
            onChange={manipulatorFunction}
            id={idInput}
        />
    );
};

export default Input;