import React from 'react';

const Select = ({options}) => {
    return (
        <>
        <select name="" id="">Selecione uma opção</select>
        {options.map(() => {
            return(
                <option value={options.value}>{options.text}</option>
            )
        })}
        </>
    );
};

export default Select;