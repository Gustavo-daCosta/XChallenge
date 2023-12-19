
import React, { useState } from 'react';
import arrow from "../../assets/Images/icons/Seta.png"

const ImageSlider = ({ slides, images }) => {

    const [indexImage, setIndexImage] = useState(0);

    const slideStyle = {
        width: "100%",
        height: "100%",
        backgroundPosition: "center",
        backgroundSize: "cover",
        backgroundImage: `url(${slides[indexImage].url})`,
        transition: "3s",

        display: "flex",
        justifyContent: "center",
        alignItems: "center",
    }

    const imageStyle = {
        width: "400px",
        height: "400px",
        backgroundPosition: "center",
        backgroundSize: "cover",
        backgroundImage: `url(${images[indexImage].url})`,
        transition: "3s",
    }

    const sliderStyle = {
        height: "100%",
        position: "relative",

    }

    const leftArrow = {
        width: "50px",
        height: "50px",
        position: "absolute",
        top: "50%",
        left: "10px",
        cursor: "pointer"
    }

    const rightArrow = {
        width: "50px",
        height: "50px",
        rotate: "-180deg",
        position: "absolute",
        top: "50%",
        right: "10px",
        cursor: "pointer"
    }


    function goNext() {
        if (indexImage === slides.length - 1) {
            return
        }
        setIndexImage(indexImage + 1);
    }
    function goPrevious() {
        if (indexImage === 0) {
            return
        }
        setIndexImage(indexImage - 1);
    }



    return (
        <div style={sliderStyle}>
            <img style={leftArrow} src={arrow} onClick={goPrevious} alt="" />
            <div className="slide" style={slideStyle}>
                <div style={imageStyle}>
                </div>
            </div>
            <img style={rightArrow} src={arrow} onClick={goNext} alt="" />
        </div>
    );
};

export default ImageSlider;