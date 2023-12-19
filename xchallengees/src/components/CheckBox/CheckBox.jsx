import "./CheckBox.css"
import React from 'react';

const CheckBox = ({ isDark, setIsDark }) => {
    return (
    
            <label>
                <input type="checkbox" 
                checked={isDark} 
                onChange={setIsDark} />
            Dark</label>
    );
};

export default CheckBox;