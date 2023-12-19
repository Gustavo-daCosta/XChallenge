import "./MainContent.css"
import React from 'react';

const MainContent = ({children}) => {
    return (
        <div className='centraliza'>
            {children}
        </div>
    );
};

export default MainContent;