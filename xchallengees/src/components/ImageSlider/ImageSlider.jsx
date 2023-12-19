import React, { useState } from 'react';

const ImageSlider = ( {slides} ) => {

    const [indexImage, setIndexImage] = useState(0);

    return (
        <div>
        <div style={ {backgroundImage: `url(${slides[indexImage].url})`} }></div>
        </div>
    );
};

export default ImageSlider;